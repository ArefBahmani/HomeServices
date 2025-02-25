using AppDomainCore.CategoryEntitie.Data;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryEntitie.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.CategoryEntite
{
    public class CategoryServic : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServic(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<bool> Creat(CategoryCreateDto category, CancellationToken cancellationToken)
        {

           return await _categoryRepository.Creat(category, cancellationToken);
        }

        public async Task<bool> Delete(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoryRepository.Delete(categoryId, cancellationToken);
        }

        public async Task<List<Category>> GetAllCategories(CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAllCategories(cancellationToken);
        }

        public Task<Category> GetCategory(int categoryId, CancellationToken cancellationToken)
        {
            return _categoryRepository.GetCategory(categoryId,cancellationToken);
        }

        public async Task<bool> Update(int id, CategoryUpdateDto category, CancellationToken cancellationToken)
        {
            return await _categoryRepository.Update(id, category, cancellationToken);
        }
    }
}
