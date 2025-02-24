﻿using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SuggestionEntite.Dtos
{
    public class GetSuggestionByExpertIdDto
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public int? ExpertId { get; set; }
        public Request? Request { get; set; }
        public int? RequestId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? SuggestedDate { get; set; }
        public string? SuggestedDateString { get; set; }
        public StatusEnum Status { get; set; }
    }
}
