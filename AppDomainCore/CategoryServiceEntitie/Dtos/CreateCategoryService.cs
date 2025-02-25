using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppDomainCore.CategoryServiceEntitie.Dtos
{
    public class CreateCategoryService
    {
        [DisplayName("نام سرویس")]
        [MaxLength(100, ErrorMessage = "نام سرویس نمیتواند بیشتر از 100 کاراکتر باشد")]
        [MinLength(3, ErrorMessage = "نام سرویس نمیتواند کمتر از 3 کاراکتر باشد")]
        [Required(ErrorMessage = "نام سرویس  نمی‌تواند بدون مقدار باشد")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatTime { get; set; }
        public string? Title { get; set; }
        public int SubCategoryId { get; set; }
        [DisplayName("قیمت")]
        [Range(100000, 99000000, ErrorMessage = "قیمت نمی‌تواند کمتر از 100 هزار تومان (100000) و بیشتر از 99 میلیون تومان (99000000) باشد")]
        [Required(ErrorMessage = "قیمت نمی‌تواند بدون مقدار باشد")]
        public decimal? BidPrice { get; set; }
        public string? Image { get; set; }

        public IFormFile? ProfileImgFile { get; set; }
    }
}
