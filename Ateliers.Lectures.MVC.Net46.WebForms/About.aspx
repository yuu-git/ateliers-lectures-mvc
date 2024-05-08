<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Ateliers.Lectures.MVC.Net46.WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <p>参考情報です。</p>
        <h3>ソースコード</h3>
        <ul>
            <li><a target="_blank" href="https://github.com/yuu-git">GitHub ホーム (https://github.com/yuu-git)</a></li>
            <li><a target="_blank" href="https://github.com/yuu-git/ateliers-lectures-mvc">GitHub リポジトリ (https://github.com/yuu-git/ateliers-lectures-mvc)</a></li>
        </ul>
        <h3>ドキュメント</h3>
        <ul>
            <li><a target="_blank" href="https://ateliers.dev/">ateliers.dev ホーム (https://ateliers.dev/)</a></li>
            <li><a target="_blank" href="https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/basic-explanation">ateliers.dev - HTTP プロトコルメソッドの基本解説 (https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/basic-explanation)</a></li>
            <li><a target="_blank" href="https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/get-method">ateliers.dev - HTTP プロトコルの『GET』解説 (https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/get-method)</a></li>
            <li><a target="_blank" href="https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/post-method">ateliers.dev - HTTP プロトコルの『POST』解説 (https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/post-method)</a></li>
            <li><a target="_blank" href="https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/put-method">ateliers.dev - HTTP プロトコルの『PUT』解説 (https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/put-method)</a></li>
            <li><a target="_blank" href="https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/delete-method">ateliers.dev - HTTP プロトコルの『DELETE』解説 (https://ateliers.dev/docs/technical-notebook/dotnet/http-protocol/delete-method)</a></li>
        </ul>
    </main>
</asp:Content>
