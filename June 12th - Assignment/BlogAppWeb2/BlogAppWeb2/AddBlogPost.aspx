<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlogAppWeb2.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post:</h3>
    <table style="width:80%">
        <tr>
            <td>
                Title:
                <asp:TextBox ID="txtTitle" runat="server" Width="488px"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Post Text
                <asp:TextBox ID="txtPostText" runat="server" TextMode="MultiLine" Width="456px"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td colspan="2">

                <asp:Button ID="btnAddPost" runat="server" OnClick="btnAddPost_Click" Text="Add Post" Width="219px" />

            </td>
        </tr>
    </table>
</asp:Content>
