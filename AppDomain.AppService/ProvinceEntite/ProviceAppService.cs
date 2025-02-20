using AppDomainCore.CityEntite.Entite;
using AppDomainCore.ProvinceEntite.AppService;
using AppDomainCore.ProvinceEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.ProvinceEntite
{
    public class ProviceAppService : IProviceAppService
    {
        private readonly IProviceService _proviceService;
        public ProviceAppService(IProviceService proviceService)
        {
            _proviceService = proviceService;
        }
        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
            return await _proviceService.GetAll(cancellationToken);
        }

        public async Task<Province> GetProvinceById(int id, CancellationToken cancellation)
        {
           return await _proviceService.GetProvinceById(id, cancellation);
        }
    }
}
