using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CommentEntite.Entite
{
    public class Comment
    {
        public int Id { get; set; }

        [MaxLength(1000,ErrorMessage ="کاربر گرامی تعداد کارکترهای موجود بیش از 1000 حرف می باشد")]
        [Required]
        public string Titel { get; set; }
        public DateTime SaveTime { get; set; } = DateTime.Now;

        [Range(1,5)]
        public int? Reaction { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Expert Expert { get; set; }
        public int ExpertId { get; set; }
        public bool IsDeleted { get; set; }



    }
}
