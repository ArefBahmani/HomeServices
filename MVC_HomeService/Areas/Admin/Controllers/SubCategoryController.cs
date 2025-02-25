using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryEntitie.AppService;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
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
            var categories = await _categoryAppService.GetAll(cancellationToken) ?? new List<Category>();
            ViewBag.Categories = categories;
            var model = new CreateSubCategoryDto();
           
            return View(model);
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

        [HttpGet]
        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var category = await _subCategoryAppService.GetById(id, cancellationToken);
            if (category == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateSubCategoryDto updateSubCategoryDTO, int id,CancellationToken cancellationToken)
        {
            updateSubCategoryDTO.Image = await _baseDataService.UploadImage("SubCategory", updateSubCategoryDTO.ProfileImgFile,  cancellationToken);
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
