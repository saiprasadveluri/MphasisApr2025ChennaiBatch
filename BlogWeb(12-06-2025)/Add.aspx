<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="BlogWebApp.Site1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Add Blog</h3>
    <table style="width:100%;">
        <tr>
            <td>Title:</td>
            <td>
                <asp:TextBox ID="TextTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>PostText:</td>
            <td>
                <asp:TextBox ID="TextPostText" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="AddPost" runat="server" Text="AddPost" OnClick="AddPost_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
