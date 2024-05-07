using Microsoft.AspNetCore.Mvc;

using Ateliers.Lectures.MVC.SharedModel;

namespace Ateliers.Lectures.MVC.APIServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult Login([FromBody] UserModel userModel)
        {
            // ここで認証処理を行います
            if (userModel.UserName == "user" && userModel.Password == "pass")
            {
                return Ok("ログイン成功");
            }

            return Unauthorized("認証失敗");
        }
    }
}
