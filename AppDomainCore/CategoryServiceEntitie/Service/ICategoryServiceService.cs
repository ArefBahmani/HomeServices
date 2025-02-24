﻿using AppDomainCore.CategoryServiceEntitie.Dtos;
using AppDomainCore.CategoryServiceEntitie.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CategoryServiceEntitie.Service
{
    public interface ICategoryServiceService
    {
        public Task<bool> Creat(CreateCategoryService categoryService, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
        public Task<bool> Edit(int id, CategoryService categoryService, CancellationToken cancellationToken);
        public Task<GetCategoryServiceDto> GetById(int id, CancellationToken cancellationToken);
        public Task<List<CategoryService>> GetAll(CancellationToken cancellationToken);
    }
}
