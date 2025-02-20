using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryEntitie.AppService;
using AppDomainCore.SubCategoryEntite.AppService;
using AppDomainCore.SubCategoryEntite.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MVC_HomeService.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryAppService _subCategoryAppService;
        private readonly ICategoryAppService _categoryAppService;
        private readonly IBaseService _baseDataService;

        public SubCategoryController(ISubCategoryAppService subCategoryAppService, ICategoryAppService categoryAppService, IBaseService baseDataService)
        {
            _subCategoryAppService = subCategoryAppService;
            _categoryAppService = categoryAppService;
            _baseDataService = baseDataService;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var result = await _subCategoryAppService.GetAll(cancellationToken);

            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Create(CancellationToken cancellationToken)
        {
            var categories = await _categoryAppService.GetAll(cancellationToken);
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSubCategoryDto addSubCategoryDTO, CancellationToken cancellationToken)
        {
            var result = await _subCategoryAppService.Creat(addSubCategoryDTO, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdatePage(int Id, UpdateSubCategoryDto updateSub,CancellationToken cancellationToken)
        {
            var result = await _subCategoryAppService.Update(Id, updateSub, cancellationToken);
            var categories = await _categoryAppService.GetAll(cancellationToken);
            ViewBag.Categories = categories;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateSubCategoryDto updateSubCategoryDTO, int id,CancellationToken cancellationToken)
        {
           // updateSubCategoryDTO.Image = await _baseDataService.UploadImage(updateSubCategoryDTO.ProfileImgFile!, "SubCategories", cancellationToken);
            var result = await _subCategoryAppService.Update(id, updateSubCategoryDTO, cancellationToken);
            if (result == false)
            {
                throw new Exception("مشکلی به وجود آمد");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int Id, CancellationToken cancellationToken)
        {
            var result = await _subCategoryAppService.Delete(Id, cancellationToken);


            return RedirectToAction("Index");
        }
    }
}
