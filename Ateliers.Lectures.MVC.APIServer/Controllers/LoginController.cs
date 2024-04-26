using Microsoft.AspNetCore.Mvc;

using Ateliers.Lectures.MVC.SharedModel;

namespace Ateliers.Lectures.MVC.APIServer.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult Login([FromBody] UserModel userModel)
        {
            return Ok();
        }
    }
}
