using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.BaseEntity.AppService
{
    public interface IBaseAppService 
    {
        Task<string> UploadImage(IFormFile image);
    }
}
