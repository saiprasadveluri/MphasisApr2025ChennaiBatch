<%@ Page Title="" Language="C#" MasterPageFile="~/Add.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="BlogWebApp1.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 198px;
        }
        .auto-style2 {
            width: 82px;
        }
        .auto-style3 {
            height: 198px;
            width: 82px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Post:</h3>
      <table>
<tr>
<td class="auto-style2">
              Title:
</td>
<td>
 
              <asp:TextBox ID="txtTitle" runat="server" Width="432px"></asp:TextBox>
 
          </td>
</tr>
<tr>
<td class="auto-style3">
              PostText:
</td>
<td class="auto-style1">
 
              <asp:TextBox ID="txtPostText" runat="server" Height="180px" TextMode="MultiLine" Width="435px"></asp:TextBox>
 
          </td>
</tr>
<tr>
<td colspan="2">
 
              <asp:Button ID="btnAddPost" runat="server" Text="Add Post" Width="211px" OnClick="btnAddPost_Click" />
 
          </td>
</tr>
</table>
</asp:Content>
