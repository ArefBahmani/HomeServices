using AppDomainCore.UserEntite.AppService.ExpertAppService;
using AppDomainCore.UserEntite.Dtos.ExpertDtos;
using AppDomainCore.UserEntite.Entiteies;
using AppDomainCore.UserEntite.Service.ExpertService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.UserEntite
{
    public class ExpertAppService : IExpertAppService
    {
        private readonly IExpertService _expertService;
        public ExpertAppService(IExpertService expertService)
        {
            _expertService = expertService;
        }
        public async Task<bool> Add(ExpertCreateDto expert, CancellationToken cancellation)
        {
            return await _expertService.Add(expert, cancellation);
        }

        public async Task<bool> Delete(int expertId, CancellationToken cancellation)
        {
           return await _expertService.Delete(expertId, cancellation);
        }

        public async Task<bool> Edit(int expertId, ExpertUpdateDto expert, CancellationToken cancellation)
        {
            return await _expertService.Edit(expertId, expert, cancellation);
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellation)
        {
            return await _expertService.GetAll(cancellation);
        }

        public async Task<Expert> GetById(int expertId, CancellationToken cancellation)
        {
            return await _expertService.GetById(expertId, cancellation);
        }
    }
}
