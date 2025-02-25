using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CategoryEntitie.AppService
{
    public interface ICategoryAppService
    {
  
        Task<bool> Create(CategoryCreateDto serviceCategoryCreateDto, CancellationToken cancellationToken);
        Task<bool> Update(int id,CategoryUpdateDto category,  CancellationToken cancellationToken);
        public Task<bool> Delete(int categoryId, CancellationToken cancellationToken);
        Task<Category> GetById(int serviceCategoryId, CancellationToken cancellationToken);
        Task<List<Category>> GetAll(CancellationToken cancellationToken);
    }
}
