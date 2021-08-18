﻿using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Repository
{
    interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProductsByCategory(string categoryUrl);

        Task CreateProduct(Product product);
    }
}
