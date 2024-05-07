using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Ateliers.Lectures.MVC.Net46.APIServer.Controllers
{
    [RoutePrefix("API/User")]
    public class UserController : ApiController
    {
        // 仮のユーザーデータをリストとして保持
        private static readonly List<string> _UserList = new List<string>
        {
            "Alice", "Bob", "Charlie"
        };

        // --- HTTP GET -------------------------------------------------------------------------------------------------------

        // GET: api/user/{id}
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetUser(int id)
        {
            // IDに対応するユーザー情報を取得
            if (id < 0 || id >= _UserList.Count)
            {
                return NotFound();
            }

            // ユーザー情報を返す
            return Ok(_UserList[id]);
        }

        // GET: api/user/all
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetUsers()
        {
            if (!_UserList.Any())
            {
                return NotFound();
            }
            
            return Ok(_UserList.Select(user => $"ID:{_UserList.IndexOf(user)}, USER:{user}"));
        }

        // --- HTTP POST ------------------------------------------------------------------------------------------------------

        // POST: api/user
        [HttpPost]
        public IHttpActionResult CreateUser([FromBody] string newUser)
        {
            if (string.IsNullOrWhiteSpace(newUser))
            {
                return BadRequest("ユーザー名が不正です");
            }

            // 新しいユーザーをリストに追加
            _UserList.Add(newUser);

            // 作成されたユーザー情報を返す
            return CreatedAtRoute(nameof(CreateUser), new { id = _UserList.Count - 1 }, newUser);
        }

        // --- HTTP PUT -------------------------------------------------------------------------------------------------------

        // PUT: api/user/{id}
        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult UpdateUser(int id, [FromBody] string updatedUser)
        {
            if (id < 0 || id >= _UserList.Count)
            {
                return NotFound();
            }

            // ユーザーデータの更新処理
            _UserList[id] = updatedUser;

            // 更新結果を返す
            return Ok("ユーザー情報を更新しました");
        }

        // --- HTTP DELETE ----------------------------------------------------------------------------------------------------

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteUser(int id)
        {
            if (id < 0 || id >= _UserList.Count)
            {
                return NotFound();
            }

            // ユーザーデータを削除
            _UserList.RemoveAt(id);
            // 204 No Content ステータスコードを返す
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
