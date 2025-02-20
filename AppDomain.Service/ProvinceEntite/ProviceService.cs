using AppDomainCore.CityEntite.Entite;
using AppDomainCore.ProvinceEntite.Data;
using AppDomainCore.ProvinceEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.ProvinceEntite
{
    public class ProviceService : IProviceService
    {
        private readonly IProvinceRepository _provinceRepository;
        public ProviceService(IProvinceRepository provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }
        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
           return await _provinceRepository.GetAll(cancellationToken);
        }

        public async Task<Province> GetProvinceById(int id, CancellationToken cancellation)
        {
            return await _provinceRepository.GetProvinceById(id, cancellation);
        }
    }
}
