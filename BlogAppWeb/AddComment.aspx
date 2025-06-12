<%@ Page Title="" Language="C#" MasterPageFile="~/Mysite.Master" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="BlogAppWeb.AddComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        PostId:<asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 61px">
        </asp:DropDownList>
    </p>
    <p>
        Title:<asp:TextBox ID="txtTitle" runat="server" style="margin-left: 71px"></asp:TextBox>
    </p>
    <p>
        CommentText:<asp:TextBox ID="txtCommentText" runat="server" style="margin-left: 9px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAddComments" runat="server" OnClick="btnAddComments_Click" Text="Add Comments" Width="166px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
