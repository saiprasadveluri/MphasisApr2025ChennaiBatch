<%@ Page Title="" Language="C#" MasterPageFile="~/Add.Master" AutoEventWireup="true" CodeBehind="ViewBlogPost.aspx.cs" Inherits="BlogWebApp1.ViewBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>BlogPost List:<asp:GridView ID="gridBlogPost" runat="server" Width="408px">
        </asp:GridView>
    </h3>
    
</asp:Content>
