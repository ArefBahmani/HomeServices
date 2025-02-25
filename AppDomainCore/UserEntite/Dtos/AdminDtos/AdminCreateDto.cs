using AppDomainCore.UserEntite.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Dtos.AdminDtos
{
    public class AdminCreateDto
    {
        [DisplayName("نام")]
        public string? FirstName { get; set; }
        [DisplayName("نام خانوادگی")]
        public string? LastName { get; set; }
        [DisplayName("ایمیل")]
        public string? Email { get; set; }
        [DisplayName("رمز عبور")]
        public string Password { get; set; }
        [DisplayName("شماره تلفن")]
        public string PhoneNumber { get; set; }
        [DisplayName("جنسیت")]
        public GenderEnum Gender { get; set; }
        public string Image { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
    }
}
