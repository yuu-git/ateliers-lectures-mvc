<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">MVC サンプルアプリケーション</h1>
            <p class="lead">MVCデザインパターンで、サーバーに対するデータ操作を行うサンプルです。</p>
        </section>

        <border />

        <div>
            <h2> HTTP GET </h2>
            <div>
                <a href="./forms/getuserall.aspx" class="btn btn-primary">Get-User-All</a>
                <p> ユーザーリストを取得するサンプル </p>
            </div>
            <div>
                <a href="./forms/getuserbyid.aspx" class="btn btn-primary">Get-User-By-Id</a>
                <p> ユーザーIDでユーザー情報を取得するサンプル </p>
            </div>
        </div>

        <div>
            <h2> HTTP POST </h2>
        </div>

        <div>
            <h2> HTTP PUT </h2>
        </div>

        <div>
            <h2> HTTP DELETE </h2>
        </div>

    </main>

</asp:Content>
