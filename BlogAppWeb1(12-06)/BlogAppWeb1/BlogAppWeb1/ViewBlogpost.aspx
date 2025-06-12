<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogpost.aspx.cs" Inherits="BlogAppWeb1.ViewBlogpost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="height: 180px; margin-left: 36px; margin-top: 70px">BlogPost List:<asp:GridView ID="gridBpost" runat="server" Height="136px" style="margin-left: 50px">
    </asp:GridView>
</h3>
    
</asp:Content>
