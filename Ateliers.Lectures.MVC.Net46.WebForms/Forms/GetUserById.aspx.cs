using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;

namespace Ateliers.Lectures.MVC.Net46.WebForms.Forms
{
    public partial class GetUserById : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // ユーザー情報取得ボタンクリック時のイベントハンドラ
        protected async void GetUserButton_Click(object sender, EventArgs e)
        {
            // テキストボックスからユーザーIDを取得
            int userId;
            if (int.TryParse(UserIdTextBox.Text, out userId))
            {
                // ユーザーIDを指定してユーザー情報を取得
                await FetchUserInfoAsync(userId);
            }
            else
            {
                // バリデーション：ユーザーIDが不正な場合はエラーメッセージを表示
                DisplayError("Invalid User ID");
            }
        }

        // ユーザー情報を取得する非同期メソッド
        private async Task FetchUserInfoAsync(int userId)
        {
            LoadingLabel.Visible = true;
            UserInfoLabel.Visible = false;
            ErrorLabel.Visible = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // URLを指定してGETリクエストを送信
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