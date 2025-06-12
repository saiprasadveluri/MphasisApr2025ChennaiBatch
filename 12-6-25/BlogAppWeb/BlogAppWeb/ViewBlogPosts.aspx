﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="ViewBlogPosts.aspx.cs" Inherits="BlogAppWeb.ViewBlogPosts" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Blogpost List:<asp:GridView ID="gridBlogPosts" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Width="100%">
        <Columns>
            <asp:BoundField DataField="PostId" HeaderText="Post Id" />
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="PostText" HeaderText="Post Text" />
            <asp:HyperLinkField DataNavigateUrlFields="PostId" DataNavigateUrlFormatString="AddComment?PID={0}" HeaderText="Add Comment" Text="Add" />
        </Columns>
        </asp:GridView>
    </h3>
    <p>&nbsp;</p>

</asp:Content>