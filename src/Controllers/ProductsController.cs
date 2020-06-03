using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Thinktecture.AKS.Webinar.Configuration;
using Thinktecture.AKS.Webinar.Models;
using Thinktecture.AKS.Webinar.Services;

namespace Thinktecture.AKS.Webinar.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        public ProductsService ProductsService { get; }
        public WebinarConfiguration WebinarConfiguration { get; }

        public ProductsController(ProductsService productsService, WebinarConfiguration webinarConfiguration)
        {
            ProductsService = productsService;
            WebinarConfiguration = webinarConfiguration;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetProductsAsync()
        {

            var allProducts = await ProductsService.GetAllProductsAsync();
            return Ok(allProducts.Take(WebinarConfiguration.ListLimit));
        }

        
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetProductByIdAsync(Guid id)
        {
            var product = await ProductsService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateProductAsync([FromBody] NewProductItem newProduct)
        {
            var product = await ProductsService.AddProductAsync(newProduct);
            return Created("", product);
        }
         
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateProductAsync(Guid id, [FromBody] UpdateProductItem updateProduct)
        {
            var product = await ProductsService.UpdateProductAsync(id, updateProduct);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        
        [HttpDelete()]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteProductAsync(Guid id)
        {
            var deleted = await ProductsService.DeleteProductAsync(id);
            if (deleted)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
