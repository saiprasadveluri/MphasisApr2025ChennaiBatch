<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogAppWeb2.NewUserForm" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 177px">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Display Name
                    </td>
                    <td>

                        <asp:TextBox ID="txtDisplayName" runat="server" Width="348px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="dispnameReq" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="Display Name is Required">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Email
                    </td>
                    <td>

                        <asp:TextBox ID="txtEmail" runat="server" Width="348px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailFormat" runat="server" ControlToValidate="txtEmail" EnableClientScript="False" ErrorMessage="Email Format is Wrong" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$">*</asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Password
                    </td>
                    <td>

                        <asp:TextBox ID="txtPassword" runat="server" Width="348px" TextMode="Password"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="passwordRequired" runat="server" ControlToValidate="txtConfirm" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password
                    </td>
                    <td>

                        <asp:TextBox ID="txtConfirm" runat="server" Width="348px" TextMode="Password"></asp:TextBox>

                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Do not Match">*</asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter :
                    </td>
                    <td>

                        <asp:TextBox ID="txtNewsLetter" runat="server" Width="348px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Button ID="btnSaveUser" runat="server" OnClick="btnSaveUser_Click" Text="Save User" Width="218px" />
                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" Text="Cancel" Width="254px" />
                        <br />
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
