using AppDomainCore.RequestEntite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SuggestionEntite.Dtos
{
    public class SuggestionDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public StatusEnum Status { get; set; }
        public decimal Price { get; set; }
    }
}
