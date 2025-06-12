<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="BlogWebApp.View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>View</h3>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
