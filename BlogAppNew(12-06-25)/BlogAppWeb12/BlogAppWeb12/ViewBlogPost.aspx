<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPost.aspx.cs" Inherits="BlogAppWeb12.NewBlogPostaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h3>BlogPost List:</h3>
    <asp:GridView ID="gridBlogPosts" runat="server">
</asp:GridView>
    </asp:Content>
