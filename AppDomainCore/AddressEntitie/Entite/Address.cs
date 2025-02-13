using AppDomainCore.CityEntite.Entite;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.AddressEntitie.Entite
{
    public class Address
    {
       
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        [MaxLength(50,ErrorMessage = "نام خیابان شما باید کمتر از 50 کارکتر باشد")]
        public string?  Street { get; set; }
        [StringLength(10, ErrorMessage = " کد پستی شما باید 10 کارکتر باشد")]
        public string? PostalCode { get; set; }
        public Expert? Expert { get; set; }

        public int? ExpertId { get; set; }
        public Customer? Customer { get; set; }
        public int? CustomerId { get; set; }
        public DateTime CreatAt { get; set; }
        public bool IsDeleted { get; set; } = false;



    }
}
