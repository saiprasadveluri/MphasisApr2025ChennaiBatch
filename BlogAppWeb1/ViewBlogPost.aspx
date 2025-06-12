<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPost.aspx.cs" Inherits="BlogAppWeb1.ViewBlogPost" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>BlogPost List:</h3>
    <asp:GridView ID="gridBlogPost" runat="server">
    </asp:GridView>

    <h3>Comments:</h3>
    <asp:GridView ID="gridComments" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="CommentText" HeaderText="Comment" />
            <asp:BoundField DataField="CommentBy" HeaderText="Posted By" />
        </Columns>
    </asp:GridView>

    
    
</asp:Content>
