<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogComment.aspx.cs" Inherits="BlogAppWeb1.AddBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 393px;
        }
        .auto-style2 {
            width: 393px;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Comment</h3>
    <table>
        <tr>
            <td class="auto-style1">
                PostId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="PostIdDropDown" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                Title&nbsp; <asp:TextBox ID="txtTitle" runat="server" style="margin-left: 68px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                CommentText&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCommentText" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAddComment" runat="server" OnClick="btnAddComment_Click" Text="Add Comment" />
            </td>
        </tr>
    </table>
</asp:Content>
