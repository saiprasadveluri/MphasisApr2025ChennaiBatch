<%@ Page Title="" Language="C#" MasterPageFile="~/Add.Master" AutoEventWireup="true" CodeBehind="AddBlogComment.aspx.cs" Inherits="BlogWebApp1.AddBlogComment" %>
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
        .auto-style4 {
            height: 283px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>New Blog Comment:</h3>
      <table class="auto-style4">
          <tr>

<td class="auto-style2">
              Post Id:
</td>
<td>
 
              <asp:DropDownList ID="drpDownPostId" runat="server" Height="16px" Width="438px" >
              </asp:DropDownList>
 
          </td>
</tr>
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
              CommentText:
</td>
<td class="auto-style1">
 
              <asp:TextBox ID="txtCommentText" runat="server" Height="180px" TextMode="MultiLine" Width="435px"></asp:TextBox>
 
          </td>
</tr>
<tr>
<td colspan="2">
 
              <asp:Button ID="btnAddComment" runat="server" Text="Add Comment" Width="211px" OnClick="btnAddComment_Click" />
 
          </td>
</tr>
</table>
</asp:Content>

