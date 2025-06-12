<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogComment.aspx.cs" Inherits="BlogAppWeb1.ViewBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>BlogComment List:</h3>
<p>
    <asp:GridView ID="GridBComment" runat="server" Width="210px">
    </asp:GridView>
</p>
</asp:Content>
