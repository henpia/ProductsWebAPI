using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Common.Models;

namespace WebAPI.Repositories
{
    public class ProductsDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}