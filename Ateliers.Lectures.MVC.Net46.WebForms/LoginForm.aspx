<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms.LoginForm" Async="true" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="UserName">ユーザー名:</label>
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="Password">パスワード:</label>
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="LoginButton" runat="server" Text="ログイン" OnClick="LoginButton_Click" />
        </div>
    </form>
</body>
</html>