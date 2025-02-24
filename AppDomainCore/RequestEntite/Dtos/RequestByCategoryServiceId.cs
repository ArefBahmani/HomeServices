﻿using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.CategoryServiceEntitie.Entite;

namespace AppDomainCore.RequestEntite.Dtos
{
    public class RequestByCategoryServiceId
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public CategoryService CategoryService { get; set; }
        public int CategoryServiceId { get; set; }
        public string CategoryServiceName { get; set; }
        [DisplayName("عکس")]
        public string? Image { get; set; }
    }
}
