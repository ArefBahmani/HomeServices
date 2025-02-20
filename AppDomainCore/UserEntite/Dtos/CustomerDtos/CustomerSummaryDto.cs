using AppDomainCore.AddressEntitie.Entite;
using AppDomainCore.CommentEntite.Entite;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.UserEntite.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Dtos.CustomerDtos
{
    public class CustomerSummaryDto
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public GenderEnum? Gender { get; set; }
        [MaxLength(11)]
        public string BackUpPhoneNumber { get; set; }

        public Address? Address { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Request>? Requests { get; set; }
    }
}
