<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewComments.aspx.cs" Inherits="Web2.ViewComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    CommentsList
    <asp:GridView ID="GridComment" runat="server"></asp:GridView>
</asp:Content>
