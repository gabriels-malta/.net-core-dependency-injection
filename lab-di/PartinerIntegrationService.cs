using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab_di
{
    public class PartinerIntegrationService
    {
        private readonly IEnumerable<IPartnerIntegration> _partners;

        public PartinerIntegrationService(IEnumerable<IPartnerIntegration> partners)
        {
            _partners = partners;
        }

        public async Task<List<string>> IntegrateWithAllPartners()
        {
            List<string> _result = new List<string>();
            foreach (var partner in _partners)
            {
                var request = new PartnerIntegrationRequest { importantParnetData = Guid.NewGuid().ToString() };
                var output = await partner.Handler(request);                
                _result.Add(JsonSerializer.Serialize(output));
            }
            return _result;
        }
    }
}
