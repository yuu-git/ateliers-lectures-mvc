<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetUserId.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms.Forms.GetUserId" Async="true" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get User Info</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="userId">Enter User ID:</label>
            <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="GetUserButton" runat="server" Text="Get User Info" OnClick="GetUserButton_Click" />
        </div>
        <asp:Label ID="LoadingLabel" runat="server" Text="Loading..." Visible="false"></asp:Label>
        <asp:Label ID="UserInfoLabel" runat="server" Visible="false"></asp:Label>
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    </form>
</body>
</html>
