﻿using AppDomainCore.UserEntite.Dtos.ExpertDtos;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Data
{
    public interface IExpertRepository
    {
        public Task<bool> Add(ExpertCreateDto expert, CancellationToken cancellation);
        public Task<bool> Delete(int expertId, CancellationToken cancellation);
        public Task<bool> Edit(int expertId, ExpertUpdateDto expert, CancellationToken cancellation);
        public Task<Expert> GetById(int expertId, CancellationToken cancellation);
        public Task<List<Expert>> GetAll(CancellationToken cancellation);
    }
}
