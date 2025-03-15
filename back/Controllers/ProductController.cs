using Microsoft.AspNetCore.Mvc;
using back.Models;
using back.Services;
using System;

namespace back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET /product/id/:id
        [HttpGet("id/{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var product = _productService.GetProductById(id);
                return product != null ? Ok( new { product }) : NotFound(new { message = "Product not found" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // GET /product/name/:name
        [HttpGet("name/{name}")]
        public IActionResult GetProductByName(string name)
        {
            try
            {
                var product = _productService.GetProductByName(name);
                return product != null ? Ok( new { product }) : NotFound(new { message = "Product not found" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // GET /product/all
        [HttpGet("all")]
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _productService.GetAllProducts();
                return Ok(new { products });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // POST /product
        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductModel product)
        {
            try
            {
                var createdProduct = _productService.CreateProduct(product);
                return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, new { createdProduct });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // PUT /product/:id
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductModel product)
        {
            try
            {
                var updatedProduct = _productService.UpdateProduct(id, product);
                return Ok(new { updatedProduct });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE /product/:id
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _productService.DeleteProduct(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
