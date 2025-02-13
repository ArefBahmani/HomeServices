using AppDomainCore.UserEntite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Entiteies
{
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Balance { get; set; }
        public GenderEnum?  Gender { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime LastUpdated { get; set; }
        public DateTime RegisterAt { get; set; }

    }
}
