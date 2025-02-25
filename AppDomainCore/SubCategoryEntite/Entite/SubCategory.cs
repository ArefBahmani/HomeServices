using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategoryEntite.Entite
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage =" تعداد کارکترهای ورودی کمتر از 50 باشد")]
        public string Name { get; set; }
        public string? Image { get; set; }
        public List<CategoryService>? CategoryServices { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime Created { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
