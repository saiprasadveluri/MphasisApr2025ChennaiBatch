<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogComments.aspx.cs" Inherits="BlogAppWeb2.ViewBlogComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <asp:GridView ID="gridBlogComment" runat="server">
    </asp:GridView>
</asp:Content>
