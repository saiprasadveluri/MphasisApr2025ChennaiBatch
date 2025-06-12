<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlogWinApp.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 477px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New BlogPost:</h3>
    <table class="auto-style2">
        <tr>
            <td>Title:</td>
            <td> 
                <asp:TextBox ID="txttitle" runat="server" Width="307px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Post Text:</td>
            <td> 
                <asp:TextBox ID="txtPosttxt" runat="server" Height="180px" TextMode="MultiLine" Width="306px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnaddpost" runat="server" Text="Add Post" Width="224px" OnClick="btnaddpost_Click" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
