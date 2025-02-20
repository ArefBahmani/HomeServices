using AppDomainCore.AddressEntitie.Enums;
using AppDomainCore.CityEntite.Entite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.AddressEntitie.Dtos
{
    public class CreateAddressDto
    {
        [DisplayName("عنوان")]
        public string Title { get; set; }
        public int ProvinceId { get; set; }
        [DisplayName("شهر")]
        public Province Province { get; set; }
        [DisplayName("خیابان")]
        public string Street { get; set; }
        [DisplayName("منطقه و کوچه و آپارتمان و ...")]
        public CheckEnum? Check { get; set; }

        [DisplayName("کدپستی")]
        public string PostalCode { get; set; }
        [DisplayName("پیش فرض")]
        public bool IsDefault { get; set; }
    }
}
