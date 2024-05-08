<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="GetUserAll.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms.Forms.GetUserAll" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Get User List</h2>
    <asp:Button ID="GetUserListButton" runat="server" Text="Get User List" OnClick="GetUserListButton_Click" />
    <asp:Label ID="LoadingLabel" runat="server" Text="Loading..." Visible="false"></asp:Label>
    <asp:GridView ID="UserListGridView" runat="server" AutoGenerateColumns="true" Visible="false"></asp:GridView>
    <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
</asp:Content>
