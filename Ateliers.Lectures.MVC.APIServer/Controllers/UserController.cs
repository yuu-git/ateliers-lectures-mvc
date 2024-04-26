using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ateliers.Lectures.MVC.APIServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // GET: UserController
        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }

        // GET: UserController/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return Ok();
        }

        // POST: UserController/Create
        [HttpPost]
        public ActionResult Create([FromBody] IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest(500);
            }
        }

        // POST: UserController/Edit/5
        [HttpPost("id")]
        public ActionResult Edit(int id, [FromBody] IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest(500);
            }
        }

        // POST: UserController/Delete/5
        [HttpDelete("id")]
        public ActionResult Delete(int id, [FromBody] IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest(500);
            }
        }
    }
}
