<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="ASP.NetDEMO212june2025.NewUserForm" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style = "width =100%">
                <tr>
                    <td>
                        Display Name
                        <asp:TextBox ID="txtDisplayName" runat="server" style="margin-left: 51px" Width="262px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="dspname" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="DisplayNameisrequired">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email
                    <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 100px" Width="262px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="EmailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="MailError" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password
                    <asp:TextBox ID="txtpswd" runat="server" style="margin-left: 70px" Width="267px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpswd" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm password
                    <asp:TextBox ID="txtConfirmpassword" runat="server" style="margin-left: 21px" Width="268px" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpswd" ControlToValidate="txtConfirmpassword" ErrorMessage="Mismatch">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                          News Letter
                          <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 60px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <td colspan="2">

                    <asp:Button ID="btnSaveUser" runat="server" OnClick="btnSaveUser_Click" Text="Save" Width="243px" />
                    <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" Width="129px" />

                </td>


               
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
