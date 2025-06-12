

<%@ Page Language="C#" MasterPageFile="~/mysite.master" AutoEventWireup="true" CodeBehind="ViewBlogPost.aspx.cs" Inherits="WebApplication12.ViewBlogPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent33" runat="server">
    <asp:GridView ID="gridBlogPost" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="BlogPostId" HeaderText="Post ID" />
        <asp:BoundField DataField="BlogTitle" HeaderText="Title" />
        <asp:BoundField DataField="BlogText" HeaderText="Content" />
        <asp:BoundField DataField="PostedBy" HeaderText="Author" />
    </Columns>
</asp:GridView>
</asp:Content>