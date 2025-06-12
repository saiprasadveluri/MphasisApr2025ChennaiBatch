<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="WebApplication4.NewUserForm" EnableTheming="true" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 691px;
        }
        .auto-style3 {
            height: 26px;
            width: 691px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="passwordReq">
            <table>
                <tr>
                    <td>
                        Display Name:
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtDispName" runat="server" Width="515px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="dispNameReq" runat="server" ControlToValidate="txtDispName" ErrorMessage="Required Name">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Email:
                    </td>
                    <td class="auto-style3">

                        <asp:TextBox ID="txtEmail" type="email" runat="server" Width="514px" TextMode="SingleLine"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailformat" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Not Valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtPassword" runat="server" Width="515px" TextMode="Password"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="PasswordReq" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password:
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtConPassword" runat="server" Width="515px" TextMode="Password"></asp:TextBox>

                        <asp:CompareValidator ID="PassowrdComp" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConPassword" ErrorMessage="Password doesn't match">*</asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter:
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtNewsLetter" runat="server" Width="518px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Button ID="btnSaveUser" runat="server" Text="Save User" Width="124px" OnClick="btnSaveUser_Click" />

                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" style="margin-left: 159px" Text="Cancel" Width="137px" />
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
