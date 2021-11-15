using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkateShopApi.Models;
using SkateShopApi.Services;

namespace SkateShopApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }
        // Get All
        [HttpGet]
        public ActionResult<List<ProductModel>> GetAll()
        {
            return ProductService.GetAll();
        }
        // Get by Id
        [HttpGet("{id}")]
        public ActionResult<ProductModel> Get(int id)
        {
            var product = ProductService.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
        // Post
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            ProductService.Add(product);
            return CreatedAtAction(nameof(Create), new { id = product.Id }, product);
        }
        // Put
        [HttpPut("{id}")]
        public ActionResult Update(int id, ProductModel product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var existingProduct = ProductService.Get(id);
            if (existingProduct is null)
            {
                return NotFound();
            }
            ProductService.Update(product);
            return NoContent();

        }
        // Delete
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = ProductService.Get(id);
            if (product is null)
            {
                return NotFound();
            }

            ProductService.Delete(id);
            return NoContent();
        }
    }
}
