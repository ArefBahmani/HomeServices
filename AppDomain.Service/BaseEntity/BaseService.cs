using AppDomainCore.BaseEntity.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.BaseEntity
{
    public class BaseService : IBaseService
    {
        public async Task<string> UploadImage(IFormFile image)
        {
            string filePath;
            string fileName;
            if (image != null)
            {
                fileName = Guid.NewGuid().ToString() +
                           ContentDispositionHeaderValue.Parse(image.ContentDisposition).FileName.Trim('"');
                filePath = Path.Combine("wwwroot/uploads", fileName);
                try
                {
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await image.CopyToAsync(stream);
                    }
                }
                catch
                {
                    throw new Exception("Upload files operation failed");
                }
                return $"/uploads/{fileName}";
            }
            else
                fileName = "";

            return fileName;
        }
    }
}
