<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="BlogWinApp.AddComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>&nbsp;</h3>
    <h3>&nbsp;</h3>
    <h3>Add New Comment:</h3>
    <table class="auto-style2">
    <tr>
        <td>PostId:</td>
        <td> 
           
            <asp:TextBox ID="txtpostid" runat="server" TextMode="Number" Width="239px"></asp:TextBox>
           
        </td>
    </tr>
    <tr>
        <td>Title:</td>
        <td> 
           
            <asp:TextBox ID="txtcmtTitle" runat="server" Height="19px" Width="240px"></asp:TextBox>
           
        </td>
    </tr>
    <tr>
        <td>Comment Text:</td>
        <td> 
           
            <asp:TextBox ID="txtcmttxt" runat="server" Width="239px"></asp:TextBox>
           
        </td>
    </tr>
<tr>
    <td>Commented By:</td>
    <td> 
           
        <asp:TextBox ID="txtcmtedby" runat="server" Width="240px"></asp:TextBox>
           
    </td>
</tr>
    <tr>
        <td colspan="2">
           
            <asp:Button ID="btnaddCmt" runat="server" OnClick="btnaddCmt_Click" Text="Add Comment" Width="173px" />
           
        </td>
    </tr>
</table>
</asp:Content>
