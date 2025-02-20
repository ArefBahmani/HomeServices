using AppDomainCore.SubCategoryEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CategoryServiceEntitie.Dtos
{
    public class GetCategoryServiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SubCategory? SubCategory { get; set; }
        public int SubCategoryId { get; set; }
        public decimal? BidPrice { get; set; }
        public string? Image { get; set; }
        public bool IsDeleted { get; set; }
    }
}
