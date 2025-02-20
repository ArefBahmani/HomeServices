using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryEntitie.AppService;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryEntitie.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.CategoryEntite
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly IBaseService _baseSevices;
        private readonly ICategoryService _categoryService;
        public CategoryAppService(/*IBaseService baseService,*/ ICategoryService categoryService)
        {
            //_baseSevices = baseService;
            _categoryService = categoryService; 
        }
        public async Task<bool> Create(CategoryCreateDto serviceCategoryCreateDto,/* IFormFile image,*/ CancellationToken cancellationToken)
        {
            //var imageAddress = _baseSevices.UploadImage(image);
            //serviceCategoryCreateDto.Image = await imageAddress;
            return await _categoryService.Creat(serviceCategoryCreateDto, cancellationToken);
        }

        public async Task<bool> Delete(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoryService.Delete(categoryId, cancellationToken);
        }

        public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
        {
            return await _categoryService.GetAllCategories(cancellationToken);
        }

        public async Task<Category> GetById(int serviceCategoryId, CancellationToken cancellationToken)
        {
            return await _categoryService.GetCategory(serviceCategoryId, cancellationToken);
        }

        public async Task<bool> Update(int id, CategoryUpdateDto category, /*IFormFile image,*/ CancellationToken cancellationToken)
        {
            //if (image != null)
            //{
            //    var imageAddress = _baseSevices.UploadImage(image);
            //    category.Image = await imageAddress;
            //}
            return await _categoryService.Update(id,category,cancellationToken);
        }
    }
}
