using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.SuggestionEntite.Entite;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.RequestEntite.Entite
{
    public class Request
    {
        public int Id { get; set; }
        [MaxLength(500, ErrorMessage = "تعداد کارکترها بیش از حد مجاز است")]
        public string Description { get; set; }

        [MaxLength(50,ErrorMessage = "تعداد کارکترها بیش از حد مجاز است")]
        public string Titel { get; set; }
        public int? CountExpert { get; set; }
        public LocationEnum? Location { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public bool IsDeleted { get; set; } = false;

        public StatusEnum  Status { get; set; }
        public DateTime? DateRequest { get; set; } 
        public DateTime CustomerRequest { get; set; } = DateTime.Now;
        public CategoryService CategoryServices { get; set; }
        public int CategoryServiceId {  get; set; }
        public Expert? Expert { get; set; }
        public int? ExpertId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public decimal? Price { get; set; }
    }
}
