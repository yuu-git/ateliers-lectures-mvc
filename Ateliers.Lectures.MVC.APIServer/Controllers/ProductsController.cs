using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ateliers.Lectures.MVC.APIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {        
        // 仮の商品データをリストとして保持
        private static readonly List<string> Products = new List<string>
        {
            "Tablet", "Smartphone", "Laptop"
        };

        // GET: api/products
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // 商品リストを返す
            return Products;
        }
    }
}
