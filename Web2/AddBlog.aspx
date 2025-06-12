<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddBlog.aspx.cs" Inherits="Web2.siteM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 77px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3 style="height: 24px; width: 746px">New Blog</h3>
    <table style="width: 717px;">
        <tr>
            <td class="auto-style1">
                Title:
             </td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="427px"></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td class="auto-style1">
                Post Text:
            </td>
            <td>
                <asp:TextBox ID="txtPostText" runat="server" Height="92px" TextMode="MultiLine" Width="429px" style="margin-bottom: 0px"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="auto-style1">
                <asp:Button ID="AddPost" runat="server" Text="AddPost" OnClick="AddPost_Click" style="margin-left: 47px" Width="109px" />
            </td>
            
        </tr>
    </table>
</asp:Content>
