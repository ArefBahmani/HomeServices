using AppDomainCore.CategoryServiceEntitie.Data;
using AppDomainCore.CategoryServiceEntitie.Dtos;
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
    public class CategoryServiceRepository : ICategoryServiceRepository
    {
        private readonly AppDbContext _context;
        public CategoryServiceRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Creat(CreateCategoryService categoryService, CancellationToken cancellationToken)
        {
            var model = new CategoryService()
            {
                BidPrice = (decimal)categoryService.BidPrice,
                Description = categoryService.Description,
                CreatTime = DateTime.Now,
                Name = categoryService.Name,
                Titel = categoryService.Title,
                Image = categoryService.Image,
                SubCategoryId = categoryService.SubCategoryId,
            };
            if (model == null)
            {
                return false;
            }
            await _context.CategoryServices.AddAsync(model);
            await _context.SaveChangesAsync(cancellationToken);
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
            var model = await _context.CategoryServices.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
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
                Image = categoryService.Image,
                CreatTime = DateTime.Now,

            };
            await _context.SaveChangesAsync(cancellationToken) ;
            return true;
        }

       

        public async Task<List<CategoryService>> GetAll(CancellationToken cancellationToken)
        {
           var models = await _context.CategoryServices.Where(x => x.IsDeleted == false).AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<CategoryService> GetById(int id, CancellationToken cancellationToken)
        {
           var model = await _context.CategoryServices.Where(x => x.IsDeleted == false).AsNoTracking().FirstOrDefaultAsync(x=>x.Id==id,cancellationToken);
            return model;
        }

        Task<GetCategoryServiceDto> ICategoryServiceRepository.GetById(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
