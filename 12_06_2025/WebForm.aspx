<%@ Page Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication12.WebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            <table>
                <tr>
                    <td colspan="2">Display Name:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Name Required" Visible="False"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Email:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Not an Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style2">Password:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Confirm Password:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Passwords do not match">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Newsletter:</td>
                    <td class="auto-style1">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Subscribe to newsletter" />
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="63px" /></td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

</asp:Content>