using System.Threading.Tasks;

namespace lab_di
{
    public class TheBoringCoPartner : IPartnerIntegration
    {
        public async Task<PartnerIntegrationResponse> Handler(PartnerIntegrationRequest request)
        {
            return await Task.FromResult(new PartnerIntegrationResponse
            {
                RequestId = request.importantParnetData,
                Issuer = "THE_BORING_COMPANY"
            });
        }
    }
}
