using System;
using System.ComponentModel.DataAnnotations;

namespace Ateliers.Lectures.MVC.SharedModel
{
    public class UserModel
    {
        [Required(ErrorMessage = "ユーザー名を入力してください。")]
        public string UserName { get; set; } = "";
        [Required(ErrorMessage = "パスワードを入力してください。")]
        public string Password { get; set; } = "";
    }
}
