using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Ateliers.Lectures.MVC.APIClients
{
    // 説明のために汎用性を捨てた限界まで雑なコード
    public class UserClient : IUserClient
    {
        public async Task<IEnumerable<string>> GetUserAll(CancellationToken token = default)
        {
            using (HttpClient client = new HttpClient())
            {
                // ユーザーリストを取得するリクエストURL
                string url = "https://localhost:44380/api/product/all";
                // ここで GET リクエストを送信
                var response = await client.GetAsync(url, token);

                // 成功(200~299)以外、HttpRequestExceptionをスロー
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<IEnumerable<string>>(responseBody);
            }
        }

        public async Task<string> GetUserById(int userId, CancellationToken token = default)
        {
            using (HttpClient client = new HttpClient())
            {
                // ユーザー情報を取得するリクエストURL
                string url = $"https://localhost:44380/api/user/{userId}";
                // ここで GET リクエストを送信
                var response = await client.GetAsync(url, token);

                // 成功(200~299)以外、HttpRequestExceptionをスロー
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
        }
    }
}