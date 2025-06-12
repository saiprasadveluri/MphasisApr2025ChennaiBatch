<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPost.aspx.cs" Inherits="WebApplication1.ViewBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Blogpost List<asp:GridView ID="gridPostList" runat="server">
    </asp:GridView>
</h3>
</asp:Content>
