<%@ Page Title="" Language="C#" MasterPageFile="~/Mysite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlogAppWeb1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 673px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post:</h3>
    <table style="width=80%">
        <tr>
            <td class="auto-style1">

                <br />
                Title&nbsp;
                <asp:TextBox ID="txtTitle" runat="server" Height="19px" Width="221px"></asp:TextBox>
                <br />
                <br />
                PostText
                <asp:TextBox ID="txtPostText" runat="server" Height="30px" TextMode="MultiLine" Width="204px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnAddPost" runat="server" OnClick="btnAddPost_Click" Text="Add Post" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />

            </td>
        </tr>
    </table>
</asp:Content>
