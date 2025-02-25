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
        public async Task<string> UploadImage(string folderName, IFormFile image, CancellationToken cancellationToken)
        {
            if (image == null || image.Length == 0)
            {
                return string.Empty;
            }

            // بررسی و ایجاد مسیر ذخیره‌سازی در `wwwroot`
            var uploadsFolder = Path.Combine("wwwroot", "Img", folderName);
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            // ایجاد نام یکتا برای فایل با پسوند اصلی
            var fileExtension = Path.GetExtension(image.FileName);
            var fileName = $"{Guid.NewGuid()}{fileExtension}";
            var filePath = Path.Combine(uploadsFolder, fileName);

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("خطایی در آپلود فایل رخ داده است.", ex);
            }

            return $"/Img/{folderName}/{fileName}";
        }

    }
}
