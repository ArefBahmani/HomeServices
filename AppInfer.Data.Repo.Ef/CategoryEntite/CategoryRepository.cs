using AppDomainCore.CategoryEntitie.Data;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Dtos;
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
       

        public async Task<bool> Creat(CategoryCreateDto category, CancellationToken cancellationToken)
        {
            var newModel = new Category()
            {
                CreateDate = DateTime.Now,
                Image = category.Image,
                Name = category.Name,
                IsDeleted = false,

            };
            if (newModel == null)
            {
                return false;
            }
            await _context.Categories.AddAsync(newModel);
            await _context.SaveChangesAsync(cancellationToken);
          
            return true;
        }

        public async Task<bool> Delete(int categoryId, CancellationToken cancellationToken)
        {
          var model = await _context.Categories.FirstOrDefaultAsync(x=>x.Id == categoryId,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
           await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Category>> GetAllCategories(CancellationToken cancellationToken)
        {
           var models = await _context.Categories.Where(x => x.IsDeleted == false).AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Category> GetCategory(int categoryId, CancellationToken cancellationToken)
        {
           var model = await _context.Categories.Where(x=>x.IsDeleted==false).AsNoTracking().FirstOrDefaultAsync(x=>x.Id==categoryId,cancellationToken);
            return model;
        }

        public async Task<bool> Update(int id, Category category, CancellationToken cancellationToken)
        {
           var model = await _context.Categories.Where(x=>x.IsDeleted==false).FirstOrDefaultAsync(x => x.Id==id,cancellationToken);
            model = new Category()
            {
                CreateDate = DateTime.Now,
                Image = category.Image,              
                Name = category.Name,
            };
            if (model == null)
            {
                return false;
            }
      
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Update(int id, CategoryUpdateDto category, CancellationToken cancellationToken)
        {
            var model = await _context.Categories.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            model = new Category()
            {
                CreateDate = DateTime.Now,
                Image = category.Image,              
                Name = category.Name,
            };
            if (model == null)
            {
                return false;
            }
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

       
    }
}
