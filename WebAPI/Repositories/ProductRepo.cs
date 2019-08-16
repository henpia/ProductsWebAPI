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
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Earphones", InStock = 10 },
                new Product() { Id = 2, Name = "Tablet", InStock = 4 },
                new Product() { Id = 3, Name = "Laptop", InStock = 2 }
            };
            return products;
        }
    }
}