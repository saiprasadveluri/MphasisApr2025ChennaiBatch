<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogWebApp1.NewUserForm" EnableTheming="true" Theme="Skin1"  %>
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<style type="text/css">
        .auto-style1 {
            height: 26px;
        }
</style>
</head>
<body>
<form id="form1" runat="server">
<div>
<table>
<tr>
<td>
                        Display Name:
</td>
<td>
<asp:TextBox ID="txtDispName" runat="server" Width="515px"></asp:TextBox>
<asp:RequiredFieldValidator ID="dispNameReq" runat="server" ControlToValidate="txtDispName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td class="auto-style1">
                        Email:
</td>
<td class="auto-style1">
<asp:TextBox ID="txtEmail" runat="server" Width="514px"></asp:TextBox>
<asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="emailFormat" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Not Valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
</td>
</tr>
<tr>
<td>
                        Password:
</td>
<td>
<asp:TextBox ID="txtPassword" runat="server" Width="515px" TextMode="Password"></asp:TextBox>
<asp:RequiredFieldValidator ID="passwordRequired" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword">*</asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
                        Confirm Password:
</td>
<td>
<asp:TextBox ID="txtConPassword" runat="server" Width="515px" TextMode="Password"></asp:TextBox>
<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConPassword" ErrorMessage="CompareValidator">*</asp:CompareValidator>
</td>
</tr>
<tr>
<td>
                        News Letter:
</td>
<td>
<asp:TextBox ID="txtNewsLetter" runat="server" Width="513px"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="2">
<asp:Button ID="Button1" runat="server" Text="Save User" Width="217px" OnClick="btnSaveUser_Click" />
<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CausesValidation="False" Width="248px" />
</td>
</tr>
</table>
</div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</form>
</body>
</html>
