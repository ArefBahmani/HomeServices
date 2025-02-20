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

namespace AppDomainCore.RequestEntite.Dtos
{
    public class GetRequestDto
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
        public Customer Customer { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public CategoryService Service { get; set; }
        public string? Image { get; set; }
    }
}
