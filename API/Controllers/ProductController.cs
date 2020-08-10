using System.Collections.Generic;
using System.Threading.Tasks;
using API.Errors;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   [Authorize]
    public class ProductController : BaseApiController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService,IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;

        }

        [HttpGet("units")]
        public async Task<ActionResult<IReadOnlyList<Unit>>> GetUnits()
        {
            return Ok(await _productService.GetUnitsAsync());
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
        {
            return Ok(await _productService.GetProductsAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {  
            var productReturn = await _productService.CreateProductAsync(product);

            if(productReturn == null ) return BadRequest(new ApiResponse(400,"Problem in creating order. "));

            return Ok(productReturn);
         }

}
}