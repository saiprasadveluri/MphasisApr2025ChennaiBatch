<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogAppWeb12.NewUserForm" EnableTheming="true" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width=100%">
                <tr>
                    <td>
                        Display Name:
                        <asp:TextBox ID="txtDisplayName" runat="server" Width="388px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="dispnameReq" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="Display name is required">*</asp:RequiredFieldValidator>
                        </td>
                    
                </tr>
                <tr>
                    <td>
                        Email:

                        <asp:TextBox ID="txtEmail" runat="server" Height="19px" Width="436px">
</asp:TextBox>

                        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Format is wrong">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Mail Error" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="425px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="passwordRequired" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password:
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="368px"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="TextBox4" ErrorMessage="Mismatch">*</asp:CompareValidator>
                    </td>
                </tr>
               
                <tr>

                   
                    <td>
                        News Letter:
                    <asp:TextBox ID="TextBox5" runat="server" Width="406px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
        <asp:Button ID="btnSaveUser" runat="server" Text="Save user" Width="209px" OnClick="btnSaveUser_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button1_Click" CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
