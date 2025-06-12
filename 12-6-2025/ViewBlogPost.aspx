<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPost.aspx.cs" Inherits="BlogWinApp.ViewBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>&nbsp;</h3>
<h3>&nbsp;BlogPost List:<asp:GridView ID="gridUserData" runat="server" Width="390px">
        </asp:GridView>
    </h3>
</asp:Content>
