using System.Threading.Tasks;

namespace lab_di
{
    public interface IPartnerIntegration
    {
        Task<PartnerIntegrationResponse> Handler(PartnerIntegrationRequest request);
    }
}
