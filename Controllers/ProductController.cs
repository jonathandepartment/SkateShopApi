
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SkateShopApi.Models;
using SkateShopApi.Services;
using System;

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
        public ActionResult GetAll()
        {
            if (ProductService.GetAll().Count == 0   || ProductService.GetAll() == null ) return NotFound();

            return Ok(ProductService.GetAll());
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
        public ActionResult Create(Object product)
        {
            JObject jsonProduct = JObject.Parse(product.ToString());

            ProductService.Add(jsonProduct);
            return Ok(); 
            // return CreatedAtAction(nameof(Create), new { id = product.Id }, product);
        }
        // Put
        [HttpPut("{id}")]
        public ActionResult Update(int id, Object product)
        {
            JObject jsonProduct = JObject.Parse(product.ToString()); 
 
            if (id != (int)jsonProduct.GetValue("id"))
            {
                return BadRequest();
            }
            var existingProduct = ProductService.Get(id);
            if (existingProduct is null)
            {
                return NotFound();
            }
            ProductService.Update(jsonProduct);
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
