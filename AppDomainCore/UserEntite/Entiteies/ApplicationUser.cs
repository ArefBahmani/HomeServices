using Microsoft.AspNetCore.Identity;

namespace AppDomainCore.UserEntite.Entiteies
{
    public class ApplicationUser : IdentityUser<int>
    {
        public Admin? Admin  { get; set; }
        public Expert? Expert { get; set; }
        public Customer? Customer { get; set; }
    }
}
