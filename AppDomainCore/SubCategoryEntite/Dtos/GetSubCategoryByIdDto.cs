using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategoryEntite.Dtos
{
    public class GetSubCategoryByIdDto
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Image { get; set; }
    }
}
