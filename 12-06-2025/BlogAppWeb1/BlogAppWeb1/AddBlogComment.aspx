<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddBlogComment.aspx.cs" Inherits="BlogAppWeb1.AddBlogComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>&nbsp;</h3>
    <h3>&nbsp;</h3>
    <h3>Add Blog Comment </h3>
    <p>PostId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="PostIdDropdown" runat="server">
        </asp:DropDownList>
    </p>
    <p>Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCmntTitle" runat="server"></asp:TextBox>
    </p>
    <p>CommentText&nbsp; <asp:TextBox ID="txtCommentText" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Add Comment" />
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
