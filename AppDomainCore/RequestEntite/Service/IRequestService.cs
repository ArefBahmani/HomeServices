using AppDomainCore.RequestEntite.Dtos;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.RequestEntite.Service
{
    public interface IRequestService
    {
        public Task<bool> Create(RequestCreateDto request, CancellationToken cancellationToken);
        public Task<bool> Delete(int requestId, CancellationToken cancellationToken);
        public Task<bool> Update(int requestId, RequestUpdateDto request, CancellationToken cancellationToken);
        public Task<GetRequestDto> GetById(int id, CancellationToken cancellationToken);
        public Task<List<Request>> GetAll(CancellationToken cancellationToken);

        public Task<bool> ChangeStatus(StatusEnum status, int requestId, CancellationToken cancellationToken);
    }
}
