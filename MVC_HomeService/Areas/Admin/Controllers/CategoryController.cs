namespace MVC_HomeService.Areas.Admin.Controllers
{
    using AppDomainCore.BaseEntity.Service;
    using AppDomainCore.CategoryEntitie.AppService;
    using AppDomainCore.CategoryEntitie.Dtos;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    namespace YourProject.Controllers
    {
        [Area("Admin")]
        public class CategoryController : Controller
        {
            private readonly ICategoryAppService _categoryAppService;
            private readonly IBaseService _imageService;

            public CategoryController(ICategoryAppService categoryAppService, IBaseService imageService)
            {
                _categoryAppService = categoryAppService;
                _imageService = imageService;
            }

           
            [HttpGet]
            public async Task<IActionResult> Index(CancellationToken cancellationToken)
            {
                var categories = await _categoryAppService.GetAll(cancellationToken);
                return View(categories);
            }

            
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            
            [HttpPost]
            public async Task<IActionResult> Create(CategoryCreateDto categoryDTO, CancellationToken cancellationToken)
            {
                if (!ModelState.IsValid)
                {
                    return View(categoryDTO);
                }

                // آپلود تصویر در صورت وجود
                if (categoryDTO.ProfileImgFile != null && categoryDTO.ProfileImgFile.Length > 0)
                {
                    try
                    {
                        var filePath = await _imageService.UploadImage("Categories", categoryDTO.ProfileImgFile, cancellationToken);
                        categoryDTO.Image = filePath; // ذخیره مسیر تصویر
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "خطایی در آپلود تصویر رخ داد: " + ex.Message);
                        return View(categoryDTO);
                    }
                }

                var result = await _categoryAppService.Create(categoryDTO, cancellationToken);
                if (!result)
                {
                    ModelState.AddModelError("", "مشکلی در ایجاد دسته‌بندی به وجود آمد.");
                    return View(categoryDTO);
                }

                return RedirectToAction("Index");
            }


            [HttpGet]
            public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
            {
                var category = await _categoryAppService.GetById(id, cancellationToken);
                if (category == null)
                {
                    return NotFound();
                }

                
                var categoryDto = new CategoryUpdateDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    Image = category.Image 
                };

                return View(categoryDto);
            }



            [HttpPost]
            public async Task<IActionResult> Update(int id, CategoryUpdateDto categoryDTO, CancellationToken cancellationToken)
            {
                if (!ModelState.IsValid)
                {
                    return View(categoryDTO);
                }

                
                if (categoryDTO.ProfileImgFile != null && categoryDTO.ProfileImgFile.Length > 0)
                {
                    try
                    {
                        var filePath = await _imageService.UploadImage("Category", categoryDTO.ProfileImgFile, cancellationToken);
                        categoryDTO.Image = filePath; 
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "خطایی در آپلود تصویر رخ داد: " + ex.Message);
                        return View(categoryDTO);
                    }
                }

                var result = await _categoryAppService.Update(id, categoryDTO, cancellationToken);
                if (!result)
                {
                    ModelState.AddModelError("", "مشکلی در به‌روزرسانی به وجود آمد.");
                    return View(categoryDTO);
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

}
