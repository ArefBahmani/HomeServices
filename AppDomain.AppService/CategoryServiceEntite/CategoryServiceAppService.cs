using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryEntitie.AppService;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.AppService;
using AppDomainCore.CategoryServiceEntitie.Dtos;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.CategoryServiceEntite
{
    public class CategoryServiceAppService : ICategoryServiceAppService
    {
        private readonly IBaseService _baseSevices;
        private readonly ICategoryServiceService _categoryServiceService;
        public CategoryServiceAppService(IBaseService baseService, ICategoryServiceService categoryServiceService)
        {
            _baseSevices = baseService;
            _categoryServiceService = categoryServiceService;
        }


        public async Task<bool> Creat(CreateCategoryService categoryService, CancellationToken cancellationToken)
        {
            categoryService.Image = await _baseSevices.UploadImage("CategoryService", categoryService.ProfileImgFile!, cancellationToken);
            return await _categoryServiceService.Creat(categoryService, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
           return await _categoryServiceService.Delete(id, cancellationToken);
        }

        public async Task<bool> Edit(int id, CategoryService categoryService, CancellationToken cancellationToken)
        {
            categoryService.Image = await _baseSevices.UploadImage("CategoryService", categoryService.ProfileImgFile!, cancellationToken);
            return await _categoryServiceService.Edit(id, categoryService, cancellationToken);
        }

        public async Task<List<CategoryService>> GetAll(CancellationToken cancellationToken)
        {
            return await _categoryServiceService.GetAll(cancellationToken);
        }

        public Task<GetCategoryServiceDto> GetById(int id, CancellationToken cancellationToken)
        {
            return _categoryServiceService.GetById(id, cancellationToken);
        }
    }
}
