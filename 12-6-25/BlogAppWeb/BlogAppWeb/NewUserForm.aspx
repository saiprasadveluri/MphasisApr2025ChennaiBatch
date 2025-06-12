<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogAppWeb.NewUserForm" EnableTheming="true" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 430px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width=100%">
                <tr>
                    <td>
                        Display Name:
                    </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="txtDisplayName" runat="server" Width="490px" ></asp:TextBox>

                        <asp:RequiredFieldValidator ID="dispnameReq" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="Display name is required">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td class="auto-style1">
                        
                        <asp:TextBox ID="txtEmail" runat="server" Width="487px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailFormat" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Format is wrong" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="txtPassword" runat="server" Width="488px" TextMode="Password"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="passwordRequired" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password:
                    </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="txtConfirm" runat="server" Width="487px" TextMode="Password"></asp:TextBox>

                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" ErrorMessage="Mismatch">*</asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter:
                    </td>
                    <td class="auto-style1">
                        
                        <asp:TextBox ID="txtNewsLetter" runat="server" Width="484px"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSaveUser" runat="server" Text="Save user" Width="314px" OnClick="btnSaveUser_Click" />

                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" Text="Cancel" Width="298px" />
                        <br />
                        <asp:ValidationSummary ID="valSummary1" runat="server" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>