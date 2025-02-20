using AppDomainCore.CategoryEntitie.AppService;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_HomeService.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryController(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var result = await _categoryAppService.GetAll(cancellationToken);

            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDto categoryDTO, CancellationToken cancellationToken)
        {
            var result = await _categoryAppService.Create(categoryDTO, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> Update(int id,CategoryUpdateDto categoryDTO, CancellationToken cancellationToken)
        {
            var result = await _categoryAppService.Update(id,categoryDTO, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int Id, CancellationToken cancellationToken)
        {
            var result = await _categoryAppService.Delete(Id, cancellationToken);


            return RedirectToAction("Index");
        }
    }
}
