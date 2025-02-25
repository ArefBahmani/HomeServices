using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.SubCategoryEntite.Entite;
using AppDomainCore.UserEntite.Entiteies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CategoryServiceEntitie.Entite
{
    public class CategoryService
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage = "کاربر گرامی تعداد کارکترهانباید بیش از 50 حرف باشد")]
        public string Name { get; set; }
        [MaxLength(500, ErrorMessage = "تعداد کارکترها بیش از حد مجاز است")]
        [MinLength(10, ErrorMessage = "تعداد کارکترها کمتر از حد مجاز است")]
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal BidPrice { get; set; }
        public string? Titel { get; set; }
        public SubCategory? SubCategory { get; set; }
        public List<Expert>? Experts { get; set; }
        [NotMapped]
        public IFormFile? ProfileImgFile { get; set; }
        public List<Request>? Requests { get; set; }
        public DateTime CreatTime { get; set; }
        public bool IsDeleted { get; set; }
        public int SubCategoryId { get; set; }

    }
}
