<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="Web2.NewUserForm" EnableTheming="true" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 93px;
        }
        .auto-style2 {
            width: 691px;
        }
        .auto-style3 {
            width: 204px;
        }
    </style>
</head>
<body style="height: 225px">
    <form id="form1" runat="server">
        <div>
            <table style="width=100%">
                <tr>
                    <td class="auto-style3">
                         Display Name
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtName" runat="server" Width="257px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="Vdname" runat="server" ControlToValidate="txtpassword" ErrorMessage="Display ReqValidator">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        Email

                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtemail"  runat="server" Width="257px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="Vemail" runat="server" ControlToValidate="txtemail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="VRemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Email RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        Password

                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="257px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="Vreqpassword" runat="server" ControlToValidate="txtcpassword" ErrorMessage="Passowrd RequiredFieldValidator">*</asp:RequiredFieldValidator>

                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">
                        Confirm Password
                    </td>
                    <td class="auto-style2">

                        <asp:TextBox ID="txtcpassword" runat="server" TextMode="Password" Width="257px"></asp:TextBox>

                        <asp:CompareValidator ID="Vcpassword" runat="server" ControlToCompare="txtcpassword" ControlToValidate="txtpassword" ErrorMessage="MisMatch">*</asp:CompareValidator>

                    </td>
                </tr>
                 <tr>
                     <td class="auto-style3">
                         News Letter

                     </td>
                     <td class="auto-style2">

                         <asp:TextBox ID="txtnews" runat="server" Width="257px"></asp:TextBox>

                     </td>

                 </tr>
                <tr>
                    
                    <td colspan="2" class="auto-style1">
                        <asp:Button ID="btnSave" runat="server" Text="Save User" Width="105px" style="margin-left: 100px" OnClick="btnSave_Click" />
                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" style="margin-left: 80px" Text="Cancel" Width="128px" />
                    </td>
                </tr>
                
            </table>
        </div>
        
        <asp:ValidationSummary ID="ValSummary1" runat="server" />
        
    </form>
</body>
</html>
