using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CommentEntite.Dtos
{
    public class CommentUpdateDto
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public DateTime SaveTime { get; set; }
        [MinLength(1, ErrorMessage = "کمترین نظر قابل ثبت 1 میباشد")]
        [MaxLength(5, ErrorMessage = "بیشترین نظر قابل ثبت 5 میباشد")]
        public int Reaction { get; set; }
        public string Description { get; set; }
    }
}
