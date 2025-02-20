using AppDomainCore.BaseEntity.AppService;
using AppDomainCore.BaseEntity.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.BaseEntity
{
    public class BaseAppService : IBaseAppService
    {
        private readonly IBaseService _baseSevices;
        public BaseAppService(IBaseService baseSevices)
        {
            _baseSevices = baseSevices;
        }
        public async Task<string> UploadImage(IFormFile image)
        {
            return await _baseSevices.UploadImage(image);
        }
    }
}
