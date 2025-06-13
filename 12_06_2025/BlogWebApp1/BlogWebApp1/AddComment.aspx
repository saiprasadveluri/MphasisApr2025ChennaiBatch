<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="BlogWebApp1.AddComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Add Comment</h3>
    <table>
        <tr>
            <td>
                CommentId:
            </td>
            <td>
                <asp:TextBox ID="txtCommentId" runat="server" Width="211px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Comment Description:
            </td>
            <td>
                 &nbsp;<asp:TextBox ID="txtCommentDesc" runat="server" Height="189px" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnAddComment" runat="server" Text="Add New Comment" OnClick="btnAddComment_Click" Width="361px"/>
            </td>
        </tr>
        
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
