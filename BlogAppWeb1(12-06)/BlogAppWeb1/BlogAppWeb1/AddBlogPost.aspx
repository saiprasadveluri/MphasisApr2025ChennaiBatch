<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlogAppWeb1.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 255px;
    }
    .auto-style2 {
        width: 58px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h3>New Blog Post</h3>
    <table>
        <tr>
            <td class="auto-style2">
                Title
            </td>
            <td class="auto-style1">

                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                Post Text
            </td>
            <td class="auto-style1">

                <asp:TextBox ID="txtPostText" runat="server" TextMode="MultiLine"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td colspan class="auto-style2">

                <asp:Button ID="btnAddPost" runat="server" OnClick="btnAddPost_Click" Text="Add Post" />

            </td>
        </tr>
    </table>
</asp:Content>

  

