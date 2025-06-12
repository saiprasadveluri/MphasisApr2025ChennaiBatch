<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogAppWeb1.NewUserForm" EnableTheming="true" Theme="Skin1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            height: 39px;
            width: 118px;
        }
        .auto-style5 {
            width: 324px;
            height: 39px;
        }
        .auto-style6 {
            height: 37px;
            width: 118px;
        }
        .auto-style7 {
            width: 324px;
            height: 37px;
        }
        .auto-style8 {
            height: 38px;
            width: 118px;
        }
        .auto-style9 {
            width: 324px;
            height: 38px;
        }
        .auto-style10 {
            height: 30px;
            width: 118px;
        }
        .auto-style11 {
            width: 324px;
            height: 30px;
        }
    </style>
</head>
<body style="height: 242px">
    <form id="txtSaveUser" runat="server">
        <div>
            <table style=""width:100%">
                <tr>
                    <td class="auto-style10">
                        Display Name:
                    </td>
                    <td id="disNameReq" class="auto-style11">

                        <asp:TextBox ID="txtDisplayName" runat="server" Width="215px" style="margin-left: 0px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="dispnameReq" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtDisplayName">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        Email:
                    </td>
                    <td class="auto-style5">

                        <asp:TextBox ID="txtEmail" runat="server" Width="212px" ></asp:TextBox>

                        <asp:RequiredFieldValidator ID="EmailReq" runat="server" ErrorMessage="Email format is wrong" ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailRegularExpression" runat="server" ErrorMessage="EmaiError" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail">*</asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        Password:
                    </td>
                    <td class="auto-style7">

                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="210px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        Confirm Password:
                    </td>
                    <td class="auto-style9">

                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Width="203px"></asp:TextBox>

                        &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Missmatch">*</asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        News Letter:
                    </td>
                    <td class="auto-style9">

                        <asp:TextBox ID="txtNewsLetter" runat="server" Width="207px"></asp:TextBox>

                    </td>
                </tr>
                <td colspan="2">

                    <asp:Button ID="btnSaveUser" runat="server" Height="24px" OnClick="btnSaveUser_Click" Text="Save User" Width="111px" style="margin-left: 29px" />

                    <asp:Button ID="btnCancel" runat="server" CausesValidation="False" Text="Cancel" Height="25px" style="margin-left: 67px" Width="100px" OnClick="btnCancel_Click" />

                </td>

            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
