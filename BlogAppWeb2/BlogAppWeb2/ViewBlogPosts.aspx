<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPosts.aspx.cs" Inherits="BlogAppWeb2.ViewBlogPosts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>BlogPost List:</h3>
    <asp:GridView ID="gridBlogPosts" runat="server">
    </asp:GridView>
</asp:Content>
