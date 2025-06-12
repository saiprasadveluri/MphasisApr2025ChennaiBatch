<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogAppWeb1.NewUserForm" EnableTheming="true" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 380px;
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
                    <td class="auto-style1" id="disNameReq">

                        <asp:TextBox ID="txtDisplayName" runat="server" Width="177px"></asp:TextBox>
                       
                        <asp:RequiredFieldValidator ID="displaynameReq" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="Display Name is Required">*</asp:RequiredFieldValidator>
                       
                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>

                        <asp:TextBox ID="txtEmail" runat="server" Width="175px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="emailFormat" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>

                    </td>
                    </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>

                        <asp:TextBox ID="txtPassword" runat="server" Width="179px" TextMode="Password"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="FormatPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password:
                    </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="txtCnfrmPassword" runat="server" Width="182px" TextMode="Password"></asp:TextBox>

                        <asp:CompareValidator ID="FormatCnfrmPassword" runat="server" ControlToValidate="txtCnfrmPassword" ErrorMessage="Missmatched">*</asp:CompareValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter:
                    </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="txtNews" runat="server" Width="180px"></asp:TextBox>

                    </td>
                </tr>
                  
                   </table>
        </div>
        <asp:Button ID="btnSave" runat="server" Text="Save User" OnClick="btnSave_Click" Width="123px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" Text="Cancel" Width="100px" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
    </form>
</body>
</html>
