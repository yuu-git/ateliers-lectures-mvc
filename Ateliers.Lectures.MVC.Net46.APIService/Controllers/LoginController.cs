
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ateliers.Lectures.MVC.SharedModel;

namespace Ateliers.Lectures.MVC.Net46.APIServer.Controllers
{
    [RoutePrefix("api")]
    public class LoginController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Login([FromBody] UserModel userModel)
        {
            // ここで認証処理を行います
            if (userModel.UserName == "user" && userModel.Password == "pass")
            {
                return Ok("ログイン成功");
            }

            return Unauthorized();
        }

    }
}
