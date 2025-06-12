<%@ Page Title="" Language="C#" MasterPageFile="~/Mysite.Master" AutoEventWireup="true" CodeBehind="AddBlogpost.aspx.cs" Inherits="BlogAppWeb.AddBlogpost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post</h3>
    <p>&nbsp;</p>
    <p>Title:<asp:TextBox ID="txtTitle" runat="server" style="margin-left: 57px" Width="194px"></asp:TextBox>
    </p>
    <p>Post Text<asp:TextBox ID="txtPostText" runat="server" Height="52px" style="margin-left: 25px" TextMode="MultiLine" Width="385px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Post" />
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
