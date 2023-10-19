using AdminPanel.Business.Abstract;
using AdminPanel.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet(template: "getlist")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet(template: "getlistbycategory")]
        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _productService.GetListByCategory(categoryId);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet(template: "getbyıd")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct(Product product)
        {
            if (_productService.CanAddProduct(product.RoleId))
            {
                _productService.AddProduct(product);
                return Ok("Ürün başarıyla eklendi.");
            }
            return Unauthorized("Bu işlemi gerçekleştirmek için yetkiniz yok.");
        }

        [HttpPost(template: "update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


        [HttpPost]
        [Route("delete")]
        public IActionResult DeleteProduct(Product product)
        {
            if (_productService.CanDeleteProduct(product.RoleId))
            {
                _productService.DeleteProduct(product);
                return Ok("Ürün başarıyla Silindi.");
            }
            return Unauthorized("Bu işlemi gerçekleştirmek için yetkiniz yok.");
        }

    }
}
