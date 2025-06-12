<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPosts.aspx.cs" Inherits="ASP.NetDEMO212june2025.ViewBlogPosts" %>
<asp:Content ID ="Context1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style ="height:181px;margin-left:36px;margin-top:78px"> BlogPostList<asp:GridView ID="gridBPost" runat="server">

    </asp:GridView>
</h3>
</asp:Content>
