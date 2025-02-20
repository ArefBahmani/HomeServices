using AppDomainCore.AddressEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.CommentEntite.Entite;
using AppDomainCore.SuggestionEntite.Entite;
using AppDomainCore.UserEntite.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Entiteies
{
    public class Expert
    {
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage ="تعداد کارکترها بیش از حد مجاز است")]
        [MinLength(3, ErrorMessage = "تعداد کارکترها کمتر از حد مجاز است")]
        public string  FirstName { get; set; }
        [MaxLength(70, ErrorMessage = "تعداد کارکترها بیش از حد مجاز است")]
        [MinLength(3, ErrorMessage = "تعداد کارکترها کمتر از حد مجاز است")]
        public string LastName { get; set; }
        public GenderEnum? Gender { get; set; }
        public string? ImageProfile { get; set; }
        [StringLength(13, ErrorMessage = "شماره تماس شما باید 13 رقم داشته باشد و از پیش شماره +98 استفاده کنید")]
        public string? PhoneNumber { get; set; }
        public decimal? Balance { get; set; }
        public List<CategoryService>? CategoryServices { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }

        [DisplayName("آدرس")]
        public Address? Address { get; set; }
        public DateTime CreatAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime  UpdateAt { get; set; }

    }
}
