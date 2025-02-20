using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CategoryEntitie.Service
{
    public interface ICategoryService
    {
        public Task<bool> Creat(CategoryCreateDto category, CancellationToken cancellationToken);
        public Task<bool> Delete(int categoryId, CancellationToken cancellationToken);
        public Task<bool> Update(int id, CategoryUpdateDto category, CancellationToken cancellationToken);
        public Task<Category> GetCategory(int categoryId, CancellationToken cancellationToken);
        public Task<List<Category>> GetAllCategories(CancellationToken cancellationToken);
    }
}
