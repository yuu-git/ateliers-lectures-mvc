using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using Newtonsoft.Json;
using Ateliers.Lectures.MVC.SharedModel;

namespace Ateliers.Lectures.MVC.Net46.WebForms
{
    public partial class LoginForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Text;

            var userModel = new UserModel { UserName = userName, Password = password };
            var json = JsonConvert.SerializeObject(userModel);

            using (var client = new HttpClient())
            {
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:44380/api/login", content);

                if (response.IsSuccessStatusCode)
                {
                    // ログイン成功時の処理をここに書く
                }
                else
                {
                    // ログイン失敗時の処理をここに書く
                }
            }
        }
    }
}
