using _177237module01demo.Model;
using _177237module01demo.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _177237module01demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepoService _service;

        //public static List<Product> products = new List<Product>() {
        //    new Product() { Name="name01", Description="Des01", Id=1},
        //    new Product() { Name="name02", Description="Des02", Id=2},
        //    new Product() { Name="name03", Description="Des03", Id=3},

        //};

        public ProductController(IRepoService service)
        {
            this._service = service;
        }

        //CRUD
        //Read 
        [HttpGet("someName")]
        public IActionResult GetProduct()
        {

            return Ok(_service.GetProducts());

        }

        // [HttpGet]
        //// [Route("{id}")]
        // public IActionResult GetProductById([FromQuery]int id)
        // {


        //     return Ok(products.Find(x => x.Id.Equals(id)));

        // }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            

            return Ok(_service.CreateProduct(product)+": Created");

        }





    }
}
