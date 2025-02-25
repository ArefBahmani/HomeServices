using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.RequestEntite.AppService;
using AppDomainCore.RequestEntite.Dtos;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.RequestEntite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.RequestEntite
{
    public class RequestAppService : IRequestAppService
    {
        private readonly IBaseService _baseSevices;
        private readonly IRequestService _requestService;
        public RequestAppService(IRequestService requestService, IBaseService baseService)
        {
            _requestService = requestService;
            _baseSevices = baseService;
        }
        public async Task<bool> ChangeStatus(StatusEnum status, int requestId, CancellationToken cancellationToken)
        {
            return await _requestService.ChangeStatus(status, requestId, cancellationToken);
        }

        public async Task<bool> Create(RequestCreateDto request, CancellationToken cancellationToken)
        {
            request.Image = await _baseSevices.UploadImage("Request", request.ProfileImgFile!, cancellationToken);
            return await _requestService.Create(request, cancellationToken);
        }

        public async Task<bool> Delete(int requestId, CancellationToken cancellationToken)
        {
           return await _requestService.Delete(requestId, cancellationToken);
        }

        public Task<List<Request>> GetAll(CancellationToken cancellationToken)
        {
           return _requestService.GetAll(cancellationToken);
        }

        public async Task<GetRequestDto> GetById(int id, CancellationToken cancellationToken)
        {
            return await _requestService.GetById(id, cancellationToken);
        }

        public async Task<bool> Update(int requestId, RequestUpdateDto request, CancellationToken cancellationToken)
        {
            request.Image = await _baseSevices.UploadImage("Request", request.ProfileImgFile!, cancellationToken);
            return await _requestService.Update(requestId, request, cancellationToken); 
        }
    }
}
