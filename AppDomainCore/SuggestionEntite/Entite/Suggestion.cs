using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SuggestionEntite.Entite
{
    public class Suggestion
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public List<Expert>? Experts { get; set; }

        public Request? Request { get; set; }
        public int RequestId { get; set; }
        public decimal? Price { get; set; }
        public StatusEnum? Status { get; set; }
        public DateTime? SuggestionDate { get; set; }
        public DateTime CreatAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime UpdateAt { get; set; }

    }
}
