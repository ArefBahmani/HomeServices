using AppDomainCore.RequestEntite.Data;
using AppDomainCore.RequestEntite.Dtos;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.RequestEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.RequestEntite
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }
        public async Task<bool> ChangeStatus(StatusEnum status, int requestId, CancellationToken cancellationToken)
        {
            return await _requestRepository.ChangeStatus(status, requestId, cancellationToken);
        }

        public async Task<bool> Create(RequestCreateDto request, CancellationToken cancellationToken)
        {
            return await _requestRepository.Create(request, cancellationToken);
        }

        public async Task<bool> Delete(int requestId, CancellationToken cancellationToken)
        {
            return await _requestRepository.Delete(requestId, cancellationToken);   
        }

        public async Task<List<Request>> GetAll(CancellationToken cancellationToken)
        {
            return await _requestRepository.GetAll(cancellationToken);
        }

        public async Task<GetRequestDto> GetById(int id, CancellationToken cancellationToken)
        {
           return await _requestRepository.GetById(id, cancellationToken);
        }

        public async Task<bool> Update(int requestId, RequestUpdateDto request, CancellationToken cancellationToken)
        {
            return await _requestRepository.Update(requestId, request, cancellationToken);
        }
    }
}
