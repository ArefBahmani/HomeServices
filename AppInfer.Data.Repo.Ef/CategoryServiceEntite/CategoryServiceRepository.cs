using AppDomainCore.CategoryServiceEntitie.Data;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.CategoryServiceEntite
{
    public class CategoryServiceRepository : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryServiceRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Creat(CategoryService categoryService, CancellationToken cancellationToken)
        {
            var model = new CategoryService()
            {
                BidPrice = categoryService.BidPrice,
                Description = categoryService.Description,
                CreatTime = DateTime.Now,
                Name = categoryService.Name,
                Titel = categoryService.Titel,
            };
            if (model == null)
            {
                return false;
            }
            await _context.CategoryServices.AddAsync(model);
            return true;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var model = await _context.CategoryServices.FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
           await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Edit(int id, CategoryService categoryService, CancellationToken cancellationToken)
        {
            var model = await _context.CategoryServices.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model = new CategoryService()
            {
                BidPrice = categoryService.BidPrice,
                Description = categoryService.Description,
                Name = categoryService.Name,
                Titel = categoryService.Titel,
                CreatTime = DateTime.Now,

            };
            await _context.SaveChangesAsync(cancellationToken) ;
            return true;
        }

        public async Task<List<CategoryService>> GetAll(CancellationToken cancellationToken)
        {
           var models = await _context.CategoryServices.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<CategoryService> GetById(int id, CancellationToken cancellationToken)
        {
           var model = await _context.CategoryServices.AsNoTracking().FirstOrDefaultAsync(x=>x.Id==id,cancellationToken);
            return model;
        }
    }
}
