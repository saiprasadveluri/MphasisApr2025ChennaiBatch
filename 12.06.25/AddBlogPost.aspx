<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="WebApplication4.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post:</h3>
    <table>
        <tr>
            <td>
                Title:
            </td>
            <td>

                <asp:TextBox ID="txtTtile" runat="server" Width="432px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                PostText:
            </td>
            <td>

                <asp:TextBox ID="txtPostText" runat="server" Height="82px" TextMode="MultiLine" Width="435px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td colspan="2">

                <asp:Button ID="btnAddPost" runat="server" OnClick="btnAddPost_Click" Text="Add Post" Width="211px" />

            </td>
        </tr>
    </table>
</asp:Content>
