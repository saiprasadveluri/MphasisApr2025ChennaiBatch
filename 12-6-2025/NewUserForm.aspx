<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogWinApp.NewUserForm" EnableTheming="True" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 498px;
        }
        .auto-style2 {
            height: 323px;
        }
    </style>
</head>
<body style="height: 330px">
    <form id="form1" runat="server" class="auto-style2">
        <div>
            <table style="width=100px">
                <tr>
                    <td>
                        Display Name:
                        
                    </td>
                    <td class="auto-style1">
                         <asp:TextBox ID="txtname" runat="server" Width="458px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="displaynamereq" runat="server" ControlToValidate="txtname" ErrorMessage="Display Name Is Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                </tr>
                <tr>
                    <td>
                        Email:
                       
                    </td>
                    <td class="auto-style1">
                         <asp:TextBox ID="txtemail" runat="server" Width="458px" OnTextChanged="txtemail_TextChanged" TextMode="Email"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="emailreq" runat="server" ControlToValidate="txtemail" ErrorMessage="Email Required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                         <asp:RegularExpressionValidator ID="emailregexp" runat="server" ControlToValidate="txtemail" ErrorMessage="Email Format is Wrong" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td class="auto-style1">
                             <asp:TextBox ID="txtpass" runat="server" Width="458px" TextMode="Password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="passreq" runat="server" ControlToValidate="txtpass" ErrorMessage="Password Required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                     </td>       
                </tr>
                <tr>
                    <td>
                        Confirm Password:
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtcpass" runat="server" Width="458px" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="compcpass" runat="server" ControlToCompare="txtpass" ControlToValidate="txtcpass" ErrorMessage="Mismatch" ForeColor="#FF3300">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter: 
                    </td>
                    <td class="auto-style1">
                       <asp:TextBox ID="txtnews" runat="server" Width="458px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save User" Width="223px" />
        <asp:Button ID="btncancel" runat="server" CausesValidation="False" OnClick="btncancel_Click" Text="Cancel" Width="219px" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="45px" Width="588px" ForeColor="#FF3300" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
