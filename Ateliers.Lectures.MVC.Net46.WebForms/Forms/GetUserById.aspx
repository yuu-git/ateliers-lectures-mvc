<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="GetUserById.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms.Forms.GetUserById" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Get User By Id</h2>
    <div>
        <label for="userId">Enter User ID:</label>
        <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="GetUserButton" runat="server" Text="Get User Info" OnClick="GetUserButton_Click" />
    </div>
    <asp:Label ID="LoadingLabel" runat="server" Text="Loading..." Visible="false"></asp:Label>
    <asp:Label ID="UserInfoLabel" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
</asp:Content>
