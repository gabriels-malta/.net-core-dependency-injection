using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace lab_di
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = SetupDI();

            var integrationService = serviceProvider.GetService<PartinerIntegrationService>();

            foreach (var item in await integrationService.IntegrateWithAllPartners())
            {
                Console.WriteLine(item);
            }
        }

        private static ServiceProvider SetupDI()
        {
            return new ServiceCollection()
                        .AddSingleton<IPartnerIntegration, HugeBankPartner>()
                        .AddSingleton<IPartnerIntegration, AwesomeFintechPartner>()
                        .AddSingleton<IPartnerIntegration, TheBoringCoPartner>()
                        .AddSingleton<PartinerIntegrationService>()
                        .BuildServiceProvider();
        }
    }
}
