using AppDomainCore.SubCategoryEntite.Data;
using AppDomainCore.SubCategoryEntite.Dtos;
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
        

        public async Task<bool> Creat(CreateSubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            var model = new SubCategory()
            {
                Image = subCategory.Image,
                Name = subCategory.Name,
                CategoryId = subCategory.CategoryId,
                Created = DateTime.Now,

            };
            if (model == null)
            {
                return false;
            }
            await _context.AddAsync(model,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            
            return true;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
          var model = await _context.SubCategories.FirstOrDefaultAsync(c => c.Id == id,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
          
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.SubCategories.Where(x => x.IsDeleted == false).AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<SubCategory> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.SubCategories.Where(x => x.IsDeleted == false).AsNoTracking().FirstOrDefaultAsync(x=> x.Id == id,cancellationToken);
            return model;
        }

        

        public async Task<bool> Update(int id, UpdateSubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            var model = await _context.SubCategories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (model == null)
            {
                return false;
            }
            model = new SubCategory()
            {
                CategoryId = subCategory.CategoryId,
                Name = model.Name,
                Image = subCategory.Image,
                UpdateAt = DateTime.Now,

            };

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

       
    }
}
