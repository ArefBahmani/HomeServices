using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryServiceEntitie.AppService;
using AppDomainCore.CategoryServiceEntitie.Dtos;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.SubCategoryEntite.AppService;
using AppDomainCore.SubCategoryEntite.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace MVC_HomeService.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class CategoryServiceController : Controller
    {
        private readonly ISubCategoryAppService _subCategoryAppService;
        private readonly IBaseService _baseDataService;
        private readonly ICategoryServiceAppService _categoryServiceAppService;
        public CategoryServiceController(ISubCategoryAppService subCategoryAppService, IBaseService baseService, ICategoryServiceAppService categoryServiceAppService)
        {
            _subCategoryAppService = subCategoryAppService;
            _baseDataService = baseService;
            _categoryServiceAppService = categoryServiceAppService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var result = await _categoryServiceAppService.GetAll(cancellationToken);
            

            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Create(CancellationToken cancellationToken)
        {
            var categories = await _subCategoryAppService.GetAll(cancellationToken);
            ViewBag.Categories = categories;
            var model = new CategoryService();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryService categoryService, CancellationToken cancellationToken)
        {
            categoryService.Image = await _baseDataService.UploadImage("CategoryService", categoryService.ProfileImgFile, cancellationToken);
            var result = await _categoryServiceAppService.Creat(categoryService, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryService categoryService, int id, CancellationToken cancellationToken)
        {
            categoryService.Image = await _baseDataService.UploadImage("SubCategories", categoryService.ProfileImgFile, cancellationToken);
            var result = await _categoryServiceAppService.Edit(id, categoryService,cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int Id, CancellationToken cancellationToken)
        {
            var result = await _categoryServiceAppService.Delete(Id, cancellationToken);


            return RedirectToAction("Index");
        }
    }
}
