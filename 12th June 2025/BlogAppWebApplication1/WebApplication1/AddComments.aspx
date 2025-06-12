<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddComments.aspx.cs" Inherits="WebApplication1.AddComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        Add Comments:
    </h3>
    <table>
        <tr>
            <td>
                Post Id:
            </td>
            <td>

                <asp:TextBox ID="txtPostId" runat="server" TextMode="Number" Width="456px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                Title:
            </td>
            <td>

                <asp:TextBox ID="txtTitle" runat="server" Width="458px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                Comment Text:
            </td>
            <td>

                <asp:TextBox ID="txtCommentTxt" runat="server" Height="84px" TextMode="MultiLine" Width="460px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td colspan="2">

                <asp:Button ID="btnAddComment" runat="server" Text="Add Comment" Width="205px" OnClick="btnAddComment_Click" />

            </td>
        </tr>
    </table>
</asp:Content>
