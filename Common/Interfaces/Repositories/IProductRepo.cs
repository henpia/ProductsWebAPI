using System;
using System.Collections.Generic;
using System.Text;
using Common.Models;

namespace Common.Interfaces.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        void CreateProduct(Product product);
    }
}
