using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPracticeSite.Models;
using MyPracticeSite.Services;

//operates on product class, 
namespace MyPracticeSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService) {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get() {

            return ProductService.GetProducts();
        }

        [Route ("rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string Id, 
            [FromQuery] int Ratings) {
            ProductService.AddRating(Id, Ratings);
            return Ok();
        }


    }
}
