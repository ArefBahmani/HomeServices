using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.RequestEntite.Enums;

namespace AppDomainCore.SuggestionEntite.Dtos
{
    public class CeateSuggestionDto
    {
        [DisplayName("توضیحات")]
        [MaxLength(1000, ErrorMessage = "توضیحات نمی‌تواند بیشتر از 1000 کاراکتر باشد")]
        [MinLength(3, ErrorMessage = "توضیحات نمی‌تواند کمتر از 3 کاراکتر باشد")]
        [Required(ErrorMessage = "توضیحات نمی‌تواند بدون مقدار باشد")]
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
        public int? ExpertId { get; set; }
        public int RequestId { get; set; }
        [DisplayName("قیمت پیشنهادی")]
        [Range(100000, 99000000, ErrorMessage = "قیمت نمی‌تواند کمتر از 100 هزار تومان (100000) و بیشتر از 99 میلیون تومان (99000000) باشد")]
        [Required(ErrorMessage = "قیمت نمی‌تواند بدون مقدار باشد")]
        public decimal Price { get; set; }
        public DateTime? SuggastionDate { get; set; }
    }
}
