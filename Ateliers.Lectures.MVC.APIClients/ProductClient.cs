using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Ateliers.Lectures.MVC.APIClients
{
    public class ProductClient
    {
        public string ServerPath { get; }

        public ProductClient(string serverPath) 
        {
            ServerPath = serverPath;
        }

        public async Task<IEnumerable<string>> GetProductAll(string apiUrl = "", CancellationToken token = default)
        {
            // 商品リストを取得するリクエストURL
            var url = string.IsNullOrWhiteSpace(apiUrl)
                ? Path.Combine(ServerPath, "api/product/all")
                : apiUrl;

            return await GetAsync<IEnumerable<string>>(url, token);
        }

        protected virtual async Task<T> GetAsync<T>(string apiUrl, CancellationToken token = default)
        {
            using (HttpClient client = new HttpClient())
            {
                // ここで GET リクエストを送信
                var response = await client.GetAsync(apiUrl, token);

                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<T>(responseBody);
            }
        }
    }
}
