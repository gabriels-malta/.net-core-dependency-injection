using System.Threading.Tasks;

namespace lab_di
{
    public class HugeBankPartner : IPartnerIntegration
    {
        public async Task<PartnerIntegrationResponse> Handler(PartnerIntegrationRequest request)
        {
            return await Task.FromResult(new PartnerIntegrationResponse
            {
                RequestId = request.importantParnetData,
                Issuer = "HUGE_BANK"
            });
        }
    }
}
