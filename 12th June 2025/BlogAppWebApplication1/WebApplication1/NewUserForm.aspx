<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="WebApplication1.NewUserForm"  Theme="Skin1" EnableTheming="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 779px">
                <tr>
                    <td>
                        Display Name:
                    </td>
                    <td>

                        <asp:TextBox ID="txtDisplayName" runat="server" Width="450px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="dispNameReq" runat="server" ErrorMessage="Display Name is required" ControlToValidate="txtDisplayName" ForeColor="#FF3300">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>

                        <asp:TextBox ID="txtEmail" runat="server" Width="450px" TextMode="Email"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailRegValidator" runat="server" ControlToValidate="txtEmail" ErrorMessage="Format is incorrect" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td >

                        <asp:TextBox ID="txtPassword" runat="server" Width="450px" TextMode="Password"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="pswdReq" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Confirm Password:
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtConfirmPassword" runat="server" Width="450px" TextMode="Password"></asp:TextBox>

                        <asp:CompareValidator ID="confirmpswdReq" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Mismatch" ForeColor="#FF3300">*</asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter:
                    </td>
                    <td>

                        <asp:TextBox ID="txtNewsLetter" runat="server" Width="450px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        
                        <asp:Button ID="btnSaveUser" runat="server" Text="Save User" OnClick="btnSaveUser_Click" Width="301px" />

                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" Text="Cancel" Width="315px" />

                    </td>
                </tr>

            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
