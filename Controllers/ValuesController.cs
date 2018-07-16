using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace simple_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {

            var CatalogList = new List<Catalog>();
            Catalog Catalog1 = new Catalog {
                id = 0,
                name = "First catalog",
                products = new List<Product>()
            };
            Catalog Catalog2 = new Catalog{
                id = 1,
                name = "Second catalog",
                products = new List<Product>()
            };
            Catalog Catalog3 = new Catalog{
                id = 2,
                name = "Third Catalog",
                products = new List<Product>()
            };

            Product product1 = new Product { id = 0, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product2 = new Product { id = 1, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product3 = new Product { id = 2, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product4 = new Product { id = 3, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product5 = new Product { id = 4, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product6 = new Product { id = 5, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product7 = new Product { id = 6, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product8 = new Product { id = 7, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product9 = new Product { id = 8, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };
            Product product10 = new Product { id = 9, productDescription = "description", productTitle = "title", tileThumbnail = "http://worldartsme.com/images/light-green-square-clipart-1.jpg" };

            Catalog1.products.Add(product1);
            Catalog1.products.Add(product2);
            Catalog1.products.Add(product3);
            Catalog1.products.Add(product4);

            Catalog2.products.Add(product5);
            Catalog2.products.Add(product6);
            Catalog2.products.Add(product7);

            Catalog3.products.Add(product8);
            Catalog3.products.Add(product9);
            Catalog3.products.Add(product10);



            CatalogList.Add(Catalog1);
            CatalogList.Add(Catalog2);
            CatalogList.Add(Catalog3);

            return new JsonResult(CatalogList);
        }
    }

    public class Product
    {
        public int id { get; set; }
        public string productDescription { get; set; }
        public string productTitle { get; set; }
        public string tileThumbnail { get; set; }
    }

    public class Catalog
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Product> products { get; set; }
    }
}
