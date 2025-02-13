using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.RequestEntite.Data
{
    public interface IRequestRepository
    {
        public Task<bool> Create(Request request,CancellationToken cancellationToken);
        public Task<bool> Delete(int requestId, CancellationToken cancellationToken);
        public Task<bool> Update(int requestId,Request request ,CancellationToken cancellationToken);
        public Task<Request> GetById(int id,CancellationToken cancellationToken);
        public Task<List<Request>> GetAll(CancellationToken cancellationToken);
       // public Task<decimal> GetTotal(CancellationToken cancellationToken);
        public Task<bool> ChangeStatus(StatusEnum status,int requestId,CancellationToken cancellationToken);

    }
}
