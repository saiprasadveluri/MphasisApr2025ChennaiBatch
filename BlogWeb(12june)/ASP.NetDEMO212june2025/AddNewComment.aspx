<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddNewComment.aspx.cs" Inherits="ASP.NetDEMO212june2025.AddNewComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Add Comments</h3>
    <table style="width: 100%;">
        <tr>
            <td>Post Id:</td>
            <td>
                <asp:DropDownList ID="PostIdDropDown" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Comment Title:</td>
            <td>
                <asp:TextBox ID="TextCommentTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Comment Text:</td>
            <td>
                <asp:TextBox ID="TextComment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="SaveCommentButton" runat="server" Text="SaveComment" OnClick="SaveCommentButton_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
