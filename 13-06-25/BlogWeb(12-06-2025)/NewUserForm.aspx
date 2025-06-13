<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogWebApp.NewUserForm" EnableTheming="true" Theme="Skin1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 530px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 530px;
            height: 26px;
        }
        .auto-style4 {
            margin-left: 127px;
        }
        .auto-style5 {
            margin-left: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>DisplayName :</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextDisplay" runat="server" Width="319px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextDisplay" ErrorMessage="Display name is required">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email :</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextEmail" type="email" AutoCompleteType="Email" runat="server" Width="321px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextEmail" ErrorMessage="Email is mandatory">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextEmail" ErrorMessage="Incorrect Email Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextPassword" type="password" runat="server" Width="320px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextPassword" ErrorMessage="Password is mandatory">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Confirm Password :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextConfirm" type="password" runat="server" Width="320px" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextPassword" ControlToValidate="TextConfirm" ErrorMessage="Password Mismatch ">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>News Letter :</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextNews" runat="server" Width="320px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="SaveButton" runat="server" CssClass="auto-style4" Text="Save" Width="138px" OnClick="SaveButton_Click" />
                        <asp:Button ID="CancelButton" runat="server" CausesValidation="False" CssClass="auto-style5" Text="Cancel" Width="150px" OnClick="CancelButton_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
