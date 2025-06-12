<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AddBlogPost.aspx.cs" Inherits="WebApplication12.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent2" runat="server">
    <h3>New Blog Post:</h3>
<table style="width:80%">
<tr>
<td>
                Title:
                <asp:TextBox ID="TextBox2" runat="server" Width="484px"></asp:TextBox>
</td>

</tr>
<tr>
<td>
                Post Text: 
<asp:TextBox ID="txtPostText" runat="server" TextMode="MultiLine" Width="456px"></asp:TextBox>
</td>

</tr>
<tr>
<td><asp:Label ID="Label1" runat="server" Text="PostedBy: "></asp:Label>
              <asp:TextBox ID="TextBox1" runat="server" Width="446px"></asp:TextBox>
            </td>
</tr>
    <tr>
        <td> <asp:Button ID="Button1" runat="server" Height="27px" Text="Button" Width="84px" OnClick="Btttn"/></td>
    </tr>
</table>
</asp:Content>