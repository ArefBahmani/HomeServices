using AppDomainCore.BaseEntity.AppService;
using AppDomainCore.BaseEntity.Dto;
using AppDomainCore.UserEntite.AppService.AdminAppService;
using Microsoft.AspNetCore.Mvc;

namespace MVC_HomeService.Areas.Account.Controllers
{
    [Area(areaName: "Account")]
    public class Login : Controller
    {
        private readonly IAccountAppService _adminAppService;

        public Login(IAccountAppService adminAppService)
        {
            _adminAppService = adminAppService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> login(string email,string pass, CancellationToken cancellationToken)
        {
           
            if (!ModelState.IsValid)
                return RedirectToAction("Index");
            var succeededLogin = await _adminAppService.Login(email,pass,cancellationToken);
            if (succeededLogin == true)
            {

                if (User.IsInRole("Admin"))
                {

                    return LocalRedirect("/Admin/Admin/Index");
                }

                if (User.IsInRole("Expert"))
                {
                    return LocalRedirect("/Expert/Index");
                }

                if (User.IsInRole("Customer"))
                    return LocalRedirect("/Customer/Index");
            }
            //return RedirectToAction("Index");
            ViewData["ErrorMessage"] = "Invalid email or password.";
            return View();
        }
    }
}
