<%@ Page Title="" Language="C#" MasterPageFile="~/Add.Master" AutoEventWireup="true" CodeBehind="ViewBlogComment.aspx.cs" Inherits="BlogWebApp1.ViewBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>BlogComment List:<asp:GridView ID="gridBlogComment" runat="server" Width="408px">
        </asp:GridView>
    </h3>
    
</asp:Content>
