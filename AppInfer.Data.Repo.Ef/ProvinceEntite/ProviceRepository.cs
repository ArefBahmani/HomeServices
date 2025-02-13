using AppDomainCore.CityEntite.Entite;
using AppDomainCore.ProvinceEntite.Data;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.ProvinceEntite
{
    public class ProviceRepository : IProvinceRepository
    {
        private readonly AppDbContext _context;
        public ProviceRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.Provinces.ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Province> GetProvinceById(int id, CancellationToken cancellation)
        {
            var model = await _context.Provinces.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return model;
        }
    }
}
