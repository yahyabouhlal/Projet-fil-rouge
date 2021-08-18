﻿using Ecom.Models;
using Ecom.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Controllers
{
    public class ProductController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            private readonly IProductService _productService;

            public ProductController(IProductService productService)
            {
                _productService = productService;
            }

            [HttpGet]
            public async Task<ActionResult<List<Product>>> GetAllProducts()
            {
                return Ok(await _productService.GetAllProducts());
            }

            [HttpPost]
            public async Task<IActionResult> CreateProduct([FromBody] Product product)
            {
                if (product == null || ModelState.IsValid == false)
                    return BadRequest();

                await _productService.CreateProduct(product);

                return Created("", product);
            }

            [HttpGet("Category/{categoryUrl}")]
            public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
            {
                /*return Ok(await _productService.GetProductsByCategory(categoryUrl));*/
                return Ok(await _productService.GetProductsByCategory(categoryUrl));
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Product>> GetProduct(int id)
            {
                return Ok(await _productService.GetProduct(id));
            }
        }
    }


}
