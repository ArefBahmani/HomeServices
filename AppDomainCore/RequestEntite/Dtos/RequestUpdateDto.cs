using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.SuggestionEntite.Entite;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.RequestEntite.Dtos
{
    public class RequestUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName("وضعیت")]
        public StatusEnum Status { get; set; }
        public Expert? Expert { get; set; }
        public int? ExpertId { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public CategoryService CategoryService { get; set; }
        public LocationEnum Location { get; set; }
        public int CategoryServiceId { get; set; }
        [DisplayName("عکس ها")]
        public string? Image { get; set; }
        public DateTime? DoneAt { get; set; }
    }
}
