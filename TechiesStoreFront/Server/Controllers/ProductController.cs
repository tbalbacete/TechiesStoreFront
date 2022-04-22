using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechiesStoreFront.Server.Data;
using TechiesStoreFront.Server.Models;
using TechiesStoreFront.Server.Services.Product;
using TechiesStoreFront.Shared.Models.ProductModels;

namespace TechiesStoreFront.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<List<ProductListItem>> Index()
        {
            var products = await _productService.GetAllProductsAsync();

            return products.ToList();
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Product(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // GET: api/Product/category/5
        [HttpGet("category/{id}")]
        public async Task<List<ProductDetail>> ProductsByCategory(int categoryId)
        {
            var products = await _productService.GetAllProductsByCategoryIdAsync(categoryId);

            return products.ToList();
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult> Create(ProductCreate model)
        {
            if (model == null) return BadRequest();

            bool wasSuccess = await _productService.CreateProductAsync(model);

            if (wasSuccess)
            {
                return Ok();
            }

            else return UnprocessableEntity();
        }

        // PUT: api/Product/edit/5
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, ProductEdit model)
        {
            if (model == null || !ModelState.IsValid) return BadRequest();

            bool wasSuccess = await _productService.UpdateProductAsync(model);

            if (wasSuccess) return Ok();

            return BadRequest();
        }


        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var productEntity = await _productService.GetProductByIdAsync(id);

            if (productEntity == null)
            {
                return NotFound();
            }

            bool wasSuccess = await _productService.DeleteProductAsync(id);

            if(!wasSuccess) return BadRequest();
            
            return Ok();
        }

        private bool ProductEntityExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
