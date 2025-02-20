using AppDomainCore.CategoryServiceEntitie.AppService;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.SubCategoryEntite.AppService;
using Microsoft.AspNetCore.Mvc;

namespace MVC_HomeService.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class ServiceController : Controller
    {
        private readonly ISubCategoryAppService _subCategoryAppService;
        private readonly ICategoryServiceAppService _serviceAppService;

        public ServiceController(ISubCategoryAppService subCategoryAppService, ICategoryServiceAppService serviceAppService)
        {
            _subCategoryAppService = subCategoryAppService;
            _serviceAppService = serviceAppService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {

            var result = await _serviceAppService.GetAll(cancellationToken);

            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Create(CancellationToken cancellationToken)
        {
            var categories = await _subCategoryAppService.GetAll(cancellationToken);
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryService addServiceDTO, CancellationToken cancellationToken)
        {
            var result = await _serviceAppService.Creat(addServiceDTO, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdatePage(int Id, CategoryService addServiceDTO, CancellationToken cancellationToken)
        {
            var result = await _serviceAppService.Edit(Id, addServiceDTO,cancellationToken);
            var categories = await _subCategoryAppService.GetAll(cancellationToken);
            ViewBag.Categories = categories;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,CategoryService addServiceDTO, CancellationToken cancellationToken)
        {
            var result = await _serviceAppService.Edit(id,addServiceDTO, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int Id, CancellationToken cancellationToken)
        {
            var result = await _serviceAppService.Delete(Id, cancellationToken);


            return RedirectToAction("Index");
        }
    }
}
