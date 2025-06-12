<%@ Page Title="" Language="C#" MasterPageFile="~/Mysite.Master" AutoEventWireup="true" CodeBehind="ViewBlogComment.aspx.cs" Inherits="BlogAppWeb.ViewBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Blog Comments List<asp:GridView ID="gridComments" runat="server">
    </asp:GridView>
</h3>
</asp:Content>
