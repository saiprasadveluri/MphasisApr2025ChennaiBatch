<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPosts.aspx.cs" Inherits="BlogWebApp1.ViewBlogPosts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <h3>Blog Post List</h3>
    <asp:GridView runat="server" Height="224px" style="margin-top: 118px" Width="261px" ID="gridBlogPosts">
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
</asp:Content>
