using AppDomainCore.SubCategoryEntite.AppService;
using AppDomainCore.SubCategoryEntite.Dtos;
using AppDomainCore.SubCategoryEntite.Entite;
using AppDomainCore.SubCategoryEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.SubCategoryEntite
{
    public class SubCategoryAppService : ISubCategoryAppService
    {
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryAppService(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        public async Task<bool> Creat(CreateSubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Creat(subCategory, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Delete(id, cancellationToken);
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            return await _subCategoryService.GetAll(cancellationToken);
        }

        public async Task<GetSubCategoryDto> GetById(int id, CancellationToken cancellationToken)
        {
           return await _subCategoryService.GetById(id, cancellationToken);
        }

        public async Task<bool> Update(int id, UpdateSubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Update(id, subCategory, cancellationToken);
        }
    }
}
