using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;

namespace Ateliers.Lectures.MVC.Net46.WebForms.Forms
{
    public partial class GetUserAll : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected async void GetUserListButton_Click(object sender, EventArgs e)
        {
            await FetchUserListAsync();
        }

        private async Task FetchUserListAsync()
        {
            LoadingLabel.Visible = true;
            UserListGridView.Visible = false;
            ErrorLabel.Visible = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // APIエンドポイントのリクエストURLを構築
                    string requestUrl = "https://localhost:44380/api/user/all";
                    var response = await client.GetAsync(requestUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Newtonsoft.Jsonを使ってJSONをリストにデシリアライズ
                        var responseBody = await response.Content.ReadAsStringAsync();
                        var userList = JsonConvert.DeserializeObject<List<string>>(responseBody);
                        DisplayUserList(userList);
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        DisplayError(error);
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
            finally
            {
                LoadingLabel.Visible = false;
            }
        }

        private void DisplayUserList(List<string> userList)
        {
            UserListGridView.DataSource = userList;
            UserListGridView.DataBind();
            UserListGridView.Visible = true;
        }

        private void DisplayError(string errorMessage)
        {
            ErrorLabel.Text = $"Error: {errorMessage}";
            ErrorLabel.Visible = true;
        }
    }
}