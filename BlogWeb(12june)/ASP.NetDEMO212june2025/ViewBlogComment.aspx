<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogComment.aspx.cs" Inherits="ASP.NetDEMO212june2025.ViewBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        BlogCommentList:
    </h3>
<asp:GridView ID="GridviewComment" runat="server">
</asp:GridView>
</asp:Content>
