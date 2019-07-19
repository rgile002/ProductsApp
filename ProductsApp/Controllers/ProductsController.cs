using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product {Id = 2, Name = "Banana", Category = "Groceries", Price = 2 },
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 15.99M }
        };

        // api/products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // api/products/5
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
