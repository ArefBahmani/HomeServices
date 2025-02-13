using AppDomainCore.CityEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.ProvinceEntite.Data
{
    public interface IProvinceRepository
    {
        public Task<Province> GetProvinceById(int id,CancellationToken cancellation);
        public Task<List<Province>> GetAll(CancellationToken cancellationToken);
    }
}
