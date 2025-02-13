using AppDomainCore.CategoryEntitie.Data;
using AppDomainCore.CategoryEntitie.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.CategoryEntite
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Creat(Category category, CancellationToken cancellationToken)
        {
            var newModel = new Category()
            {
                CreateDate = DateTime.Now,
                Image = category.Image,
                Name = category.Name,
                IsDeleted  = false,

            };
            await _context.Categories.AddAsync(newModel);
            await _context.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task<bool> Delete(int categoryId, CancellationToken cancellationToken)
        {
          var model = await _context.Categories.FirstOrDefaultAsync(x=>x.Id == categoryId,cancellationToken);
            model.IsDeleted = true;
           await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Category>> GetAllCategories(CancellationToken cancellationToken)
        {
           var models = await _context.Categories.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Category> GetCategory(int categoryId, CancellationToken cancellationToken)
        {
           var model = await _context.Categories.AsNoTracking().FirstOrDefaultAsync(x=>x.Id==categoryId,cancellationToken);
            return model;
        }

        public async Task<bool> Update(int id, Category category, CancellationToken cancellationToken)
        {
           var model = await _context.Categories.FirstOrDefaultAsync(x => x.Id==id,cancellationToken);
            model = new Category()
            {
                CreateDate = DateTime.Now,
                Image = category.Image,
                IsDeleted = false,
                Name = category.Name,
            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
