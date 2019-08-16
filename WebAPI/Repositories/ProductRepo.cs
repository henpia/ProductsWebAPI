using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Models;
using Common.Interfaces.Repositories;

namespace WebAPI.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private ProductsDBContext _context;

        public ProductRepo(ProductsDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _context.Products;
            return products;
        }
    }
}