﻿using AppDomainCore.AddressEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.UserEntite.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Dtos.ExpertDtos
{
    public class ExpertCreateDto
    {
        [DisplayName("نام")]
        public string? FirstName { get; set; }
        [DisplayName("نام خانوداگی")]
        public string? LastName { get; set; }
        [DisplayName("جنسیت")]
        public GenderEnum? Gender { get; set; }
        [DisplayName("شماره تلفن")]
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        [DisplayName("تاریخ تولد")]
        public DateTime? BirthDate { get; set; }
        [DisplayName("عکس پروفایل")]
        public string? ProfileImage { get; set; }
        [DisplayName("شماره کارت بانکی")]
        public string? BankCardNumber { get; set; }
        public List<CategoryService> CategoryServices { get; set; }
        [DisplayName("آدرس")]
        public Address Address { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
    }
}
