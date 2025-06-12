<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogComment.aspx.cs" Inherits="BlogAppWeb2.AddBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Comment:</h3>
<table style="width:80%">
    <tr>
        <td>
            Blog PostId
            <asp:DropDownList ID="ddlBlogPostId" runat="server" Height="18px" Width="216px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            </td>
        <td>

        </td>
    </tr>
    <tr>
        <td>
            Comment Title:
            <asp:TextBox ID="txtCommentTitle" runat="server" Width="346px"></asp:TextBox>
            </td>
        <td>

        </td>
    </tr>
    <tr>
        <td>
            Comment Text:
            <asp:TextBox ID="txtCommentText" runat="server" TextMode="MultiLine" Width="344px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">

            <asp:Button ID="btnAddComment" runat="server" Text="Add Comment" Width="220px" OnClick="btnAddComment_Click1" />
        </td>
    </tr>
</table>
</asp:Content>
