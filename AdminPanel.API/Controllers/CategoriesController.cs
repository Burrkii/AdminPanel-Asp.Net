using AdminPanel.Business.Abstract;
using AdminPanel.Entities.Concrete;
using AdminPanel.Entities.Concrete.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
       private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(template: "getlist")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
            
        }
        [HttpPost(template:"add")]
       public IActionResult CategoryAdd(Category category)
        {
            
            if (_categoryService.CanAddCategory(category.RoleId))
            {
                _categoryService.AddCategory(category);
                return Ok("Ürün başarıyla eklendi");
            }
             return Unauthorized("Bu işlemi gerçekleştirmek için yetkiniz yok.");
        }
        [HttpPost(template: "delete")]
        public IActionResult Categoryde(Category category)
        {

            if (_categoryService.CanDeletecategory(category.RoleId))
            {
                _categoryService.DeleteCategory(category);
                return Ok("Ürün başarıyla Silindi");
            }
            return Unauthorized("Bu işlemi gerçekleştirmek için yetkiniz yok.");
        }
    }
}
