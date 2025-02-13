using AppDomainCore.SubCategoryEntite.Data;
using AppDomainCore.SubCategoryEntite.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.SubCategoryEntite
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly AppDbContext _context;
        public SubCategoryRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Creat(SubCategory subCategory, CancellationToken cancellationToken)
        {
            var model =new SubCategory()
            {
                Image = subCategory.Image,
                Name = subCategory.Name,
                
            };
            await _context.AddAsync(model);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
          var model = await _context.SubCategories.FirstOrDefaultAsync(c => c.Id == id,cancellationToken);
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
          
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.SubCategories.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<SubCategory> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.SubCategories.AsNoTracking().FirstOrDefaultAsync(x=> x.Id == id,cancellationToken);
            return model;
        }

        public async Task<bool> Update(int id, SubCategory subCategory, CancellationToken cancellationToken)
        {
            var model = await _context.SubCategories.FirstOrDefaultAsync(x=> x.Id == id,cancellationToken);
            model = new SubCategory()
            {
                Name = subCategory.Name,
                Image = subCategory.Image,
                UpdateAt = DateTime.Now,

            };
           
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
