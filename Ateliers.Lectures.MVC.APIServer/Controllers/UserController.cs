using Microsoft.AspNetCore.Mvc;

namespace Ateliers.Lectures.MVC.APIServer.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class UserController : ControllerBase
    {
        // 仮のユーザーデータをリストとして保持
        private static readonly List<string> _UserList = new List<string>
        {
            "Alice", "Bob", "Charlie"
        };

        // --- HTTP GET -------------------------------------------------------------------------------------------------------

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public ActionResult<string> GetUserById(int id)
        {
            // ユーザー情報を確認して、ユーザー情報かエラーを返す
            return id < 0 || id >= _UserList.Count
                ? NotFound("ユーザーが見つかりません")
                : Ok(_UserList[id]);
        }

        // GET: api/user/all
        [HttpGet("All")]
        public ActionResult<IEnumerable<string>> GetUsers()
        {
            // ユーザー情報を確認して、ユーザーリストかエラーを返す
            return _UserList.Any()
                ? Ok(_UserList.Select(user => $"ID:{_UserList.IndexOf(user)}, USER:{user}"))
                : NotFound("ユーザーは0件です。");
        }

        // --- HTTP POST ------------------------------------------------------------------------------------------------------

        // POST: api/user
        [HttpPost]
        public ActionResult<string> CreateUser([FromBody] string newUser)
        {
            if (string.IsNullOrWhiteSpace(newUser))
            {
                return BadRequest("ユーザー名が不正です");
            }

            // 新しいユーザーをリストに追加
            _UserList.Add(newUser);

            // 作成されたユーザー情報を返す
            return CreatedAtAction(nameof(CreateUser), new { id = _UserList.Count - 1 }, newUser);
        }

        // --- HTTP PUT -------------------------------------------------------------------------------------------------------

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] string newUser)
        {
            // IDに対応するユーザー情報を取得
            if (id < 0 || id >= _UserList.Count)
            {
                return NotFound("ユーザーが見つかりません");
            }

            // ユーザーデータの更新処理
            _UserList[id] = newUser;

            // 更新結果を返す
            return Ok("ユーザー情報を更新しました");
        }

        // --- HTTP DELETE ----------------------------------------------------------------------------------------------------

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // IDに対応するユーザー情報を取得
            if (id < 0 || id >= _UserList.Count)
            {
                // 204 No Content ステータスを返す
                return NoContent();
            }

            // ユーザーデータの削除処理
            _UserList.RemoveAt(id);

            // 204 No Content ステータスを返す
            return NoContent(); 
        }
    }
}
