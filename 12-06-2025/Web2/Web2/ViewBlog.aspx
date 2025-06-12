<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewBlog.aspx.cs" Inherits="Web2.Site2M" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Blog List:<asp:GridView ID="GridPosts" runat="server" Height="189px" style="margin-left: 22px" Width="561px">
    </asp:GridView>
</h3>
    
</asp:Content>
