<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetUserAll.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms.Forms.GetUserAll" Async="true" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get User List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="GetUserListButton" runat="server" Text="Get User List" OnClick="GetUserListButton_Click" />
        </div>
        <asp:Label ID="LoadingLabel" runat="server" Text="Loading..." Visible="false"></asp:Label>
        <asp:GridView ID="UserListGridView" runat="server" AutoGenerateColumns="true" Visible="false"></asp:GridView>
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    </form>
</body>
</html>