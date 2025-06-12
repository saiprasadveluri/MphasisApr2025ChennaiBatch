<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="Web2.AddComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    AddComments
    <table>
        
        <tr>
            <td>
                PostId:
            </td>
            <td>
                <asp:DropDownList ID="DrpPost" runat="server"></asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <td>
                Title:
            </td>
            <td>
                <asp:TextBox ID="txtComtitle" runat="server" Width="443px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Comment Text:
            </td>
            <td>
                <asp:TextBox ID="txtComText" runat="server" TextMode="MultiLine" Width="443px"></asp:TextBox>

            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnAddCom" runat="server" Text="AddComment" OnClick="btnAddCom_Click" style="margin-left: 56px" />
            </td>
        </tr>
    </table>
</asp:Content>
