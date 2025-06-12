<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewComments.aspx.cs" Inherits="WebApplication1.ViewComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        Comments List: <asp:GridView ID="gridCommentList" runat="server">
</asp:GridView>
    </h3>
</asp:Content>
