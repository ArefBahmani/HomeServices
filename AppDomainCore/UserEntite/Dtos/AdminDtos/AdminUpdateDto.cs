using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.UserEntite.Enums;

namespace AppDomainCore.UserEntite.Dtos.AdminDtos
{
    public class AdminUpdateDto
    {
        public int Id { get; set; }
        [DisplayName("نام")]
        [MaxLength(50, ErrorMessage = "نام نمی‌تواند بیشتر از 50 کاراکتر باشد")]
        [MinLength(3, ErrorMessage = "نام نمی‌تواند کمتر از 3 کاراکتر باشد")]
        [Required(ErrorMessage = "نام نمی‌تواند بدون مقدار باشد")]
        public string? FirstName { get; set; }

        [DisplayName("نام خانوادگی")]
        [MaxLength(50, ErrorMessage = "نام خانوادگی نمی‌تواند بیشتر از 50 کاراکتر باشد")]
        [MinLength(3, ErrorMessage = "نام خانوادگی نمی‌تواند کمتر از 3 کاراکتر باشد")]
        [Required(ErrorMessage = "نام خانوادگی نمی‌تواند بدون مقدار باشد")]
        public string? LastName { get; set; }

        [DisplayName("شماره تلفن")]
        [Length(11, 11, ErrorMessage = " شماره تلفن نمی‌تواند کمتر یا بیشتر از 11 کاراکتر باشد")]
        [Required(ErrorMessage = "شماره تلفن نمی‌تواند بدون مقدار باشد")]
        public string PhoneNumber { get; set; }
        public GenderEnum Gender  { get; set; }
    }
}
