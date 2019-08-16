using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Interfaces.Repositories;
using Common.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductRepo _productRepo;

        public ProductsController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _productRepo.GetProducts();
            return products;
        }
    }
}
