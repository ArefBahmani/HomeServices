using AppDomainCore.CategoryServiceEntitie.Data;
using AppDomainCore.CategoryServiceEntitie.Dtos;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.CategoryServiceEntite
{
    public class CategoryServiceService : ICategoryServiceService
    {
        private readonly ICategoryServiceRepository _repository;
        public CategoryServiceService(ICategoryServiceRepository categoryServiceRepository)
        {
            _repository = categoryServiceRepository;
        }
        public async Task<bool> Creat(CreateCategoryService categoryService, CancellationToken cancellationToken)
        {
           return await _repository.Creat(categoryService, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _repository.Delete(id, cancellationToken);
        }

        public async Task<bool> Edit(int id, CategoryService categoryService, CancellationToken cancellationToken)
        {
           return await _repository.Edit(id, categoryService, cancellationToken);   
        }

        public async Task<List<CategoryService>> GetAll(CancellationToken cancellationToken)
        {
           return await _repository.GetAll(cancellationToken);
        }

        public async Task<GetCategoryServiceDto> GetById(int id, CancellationToken cancellationToken)
        {
            return await _repository.GetById(id, cancellationToken);
        }
    }
}
