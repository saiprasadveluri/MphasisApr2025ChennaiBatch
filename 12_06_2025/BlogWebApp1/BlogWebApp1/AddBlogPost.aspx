<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlogWebApp1.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     
   
     
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post</h3>
    <table>
        <tr>
            <td>
                Title
            </td>
            <td>

                <asp:TextBox ID="txtTitle" runat="server" Width="211px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                Post Text
            </td>
            <td>
                &nbsp;<asp:TextBox ID="txtPostText" runat="server" Height="189px" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnAddBlogPost" runat="server" Text="Add New BlogPost" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
