<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewComments.aspx.cs" Inherits="BlogWinApp.ViewComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3>Comments:</h3>
    <br />
    <asp:GridView ID="gridcmtlist" runat="server">
    </asp:GridView>
</asp:Content>
