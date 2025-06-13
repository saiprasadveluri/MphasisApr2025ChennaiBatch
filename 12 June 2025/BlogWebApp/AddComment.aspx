<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="WebApplication12.AddComment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent4" runat="server">
    <asp:GridView ID="gridComment" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="CommentId" HeaderText="Comment ID" />
        <asp:BoundField DataField="BlogPostId" HeaderText="Post ID" />
        <asp:BoundField DataField="CommentTitle" HeaderText="Title" />
        <asp:BoundField DataField="CommentText" HeaderText="Content" />
        <asp:BoundField DataField="CommentBy" HeaderText="Author" />
    </Columns>
</asp:GridView>
</asp:Content>
