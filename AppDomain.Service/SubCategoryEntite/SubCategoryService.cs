using AppDomainCore.SubCategoryEntite.Data;
using AppDomainCore.SubCategoryEntite.Dtos;
using AppDomainCore.SubCategoryEntite.Entite;
using AppDomainCore.SubCategoryEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.SubCategoryEntite
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }
        public async Task<bool> Creat(CreateSubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            return await _subCategoryRepository.Creat(subCategory, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _subCategoryRepository.Delete(id, cancellationToken);
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
           return await _subCategoryRepository.GetAll(cancellationToken);
        }

        public async Task<GetSubCategoryDto> GetById(int id, CancellationToken cancellationToken)
        {
           return await _subCategoryRepository.GetById(id, cancellationToken);
        }

        public async Task<bool> Update(int id, UpdateSubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            return await _subCategoryRepository.Update(id, subCategory, cancellationToken);
        }
    }
}
