﻿using AppDomainCore.SubCategoryEntite.Dtos;
using AppDomainCore.SubCategoryEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategoryEntite.Service
{
    public interface ISubCategoryService
    {
        public Task<bool> Creat(CreateSubCategoryDto subCategory, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
        public Task<bool> Update(int id, UpdateSubCategoryDto subCategory, CancellationToken cancellationToken);
        public Task<SubCategory> GetById(int id, CancellationToken cancellationToken);
        public Task<List<SubCategory>> GetAll(CancellationToken cancellationToken);
    }
}
