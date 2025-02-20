using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Dtos.ExpertDtos;
using AppDomainCore.UserEntite.Entiteies;
using AppDomainCore.UserEntite.Service.ExpertService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppDomain.Service.UserEntite
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;
        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }

        public async Task<bool> Add(ExpertCreateDto expert, CancellationToken cancellation)
        {
            return await _expertRepository.Add(expert, cancellation);
        }

        

        public async Task<bool> Delete(int expertId, CancellationToken cancellationToken)
        {
           return await _expertRepository.Delete(expertId, cancellationToken);
        }

        public async Task<bool> Edit(int expertId, ExpertUpdateDto expert, CancellationToken cancellation)
        {
           return await _expertRepository.Edit(expertId,expert, cancellation);
        }

  

        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken)
        {
           return await _expertRepository.GetAll(cancellationToken);
        }

        public async Task<Expert> GetById(int expertId, CancellationToken cancellationToken)
        {
            return await _expertRepository.GetById(expertId, cancellationToken);
        }

        
    }
}
