using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppDomainCore.SubCategoryEntite.Dtos
{
    public class CreateSubCategoryDto
    {
        [DisplayName("نام دسته بندی")]
        [MaxLength(100, ErrorMessage = "نام دسته بندی نمیتواند بیشتر از 100 کاراکتر باشد")]
        [MinLength(3, ErrorMessage = "نام دسته بندی نمیتواند کمتر از 3 کاراکتر باشد")]
        [Required(ErrorMessage = "وارد کردن نام دسته بندی اجباری است.")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
        public string? Image { get; set; }
    }
}
