﻿using AppDomainCore.AddressEntitie.Entite;
using AppDomainCore.UserEntite.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Dtos.CustomerDtos
{
    public class CustomerCreateDto
    {
        public string? FirstName { get; set; }
        [DisplayName("نام خانوادگی")]
        public string? LastName { get; set; }
        [DisplayName("جنسیت")]
        public GenderEnum? Gender { get; set; }
        [DisplayName("شماره تلفن")]
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public string Image { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
    }
}
