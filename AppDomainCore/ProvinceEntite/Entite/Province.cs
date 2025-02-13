using AppDomainCore.AddressEntitie.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CityEntite.Entite
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Address>? Addresses { get; set; }

    }
}
