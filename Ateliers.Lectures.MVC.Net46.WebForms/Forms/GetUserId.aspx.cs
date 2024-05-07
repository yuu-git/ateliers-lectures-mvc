using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;

namespace Ateliers.Lectures.MVC.Net46.WebForms.Forms
{
    public partial class GetUserId : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected async void GetUserButton_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(UserIdTextBox.Text, out userId))
            {
                await FetchUserInfoAsync(userId);
            }
            else
            {
                DisplayError("Invalid User ID");
            }
        }

        private async Task FetchUserInfoAsync(int userId)
        {
            LoadingLabel.Visible = true;
            UserInfoLabel.Visible = false;
            ErrorLabel.Visible = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // APIエンドポイントのリクエストURLを構築
                    string requestUrl = $"https://localhost:44380/api/user/{userId}";
                    var response = await client.GetAsync(requestUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string userInfo = await response.Content.ReadAsStringAsync();
                        DisplayUserInfo(userInfo);
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

        private void DisplayUserInfo(string userInfo)
        {
            UserInfoLabel.Text = $"User Info: {userInfo}";
            UserInfoLabel.Visible = true;
        }

        private void DisplayError(string errorMessage)
        {
            ErrorLabel.Text = $"Error: {errorMessage}";
            ErrorLabel.Visible = true;
        }
    }
}