<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlagAppWeb1.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post:</h3>
    <table style="width:80%">
        <tr>
            <td>
                Title:
            </td>
            <td>
                
                <asp:TextBox ID="txtTitle" runat="server" Width="395px"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                Post Text
            </td>
            <td>
                    
                <asp:TextBox ID="txtPostText" runat="server" Height="243px" TextMode="MultiLine" Width="402px"></asp:TextBox>
                    
            </td>
        </tr>
        <tr>
            <td colspan="2">

                <asp:Button ID="btnAddPost" runat="server" OnClick="btnAddPost_Click" Text="Add Post" Width="314px" />

            </td>
        </tr>
    </table>
</asp:Content>
