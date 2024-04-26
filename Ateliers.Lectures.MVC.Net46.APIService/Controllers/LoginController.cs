
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
        [Route("login")]
        public IHttpActionResult Login([FromBody] UserModel userModel)
        {
            return Ok();
        }

    }
}
