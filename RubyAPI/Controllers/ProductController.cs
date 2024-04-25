using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;

namespace RubyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        IEnumerable<Product> GetProducts() 
        { 
            var products = new List<Product>();
            var data = File.ReadAllLines(MOCK_DATA.json);
            Console.WriteLine(data);
            return products;
        }
    }
}
