using AppDomainCore.SubCategoryEntite.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CategoryEntitie.Entite
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime  CreateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? Image { get; set; }
        public List<SubCategory>? SubCategories { get; set; }

    }
}
