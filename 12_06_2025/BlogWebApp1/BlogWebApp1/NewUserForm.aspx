<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogWebApp1.NewUserForm" EnableTheming="true" Theme="Skin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 392px">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Display Name :
                        
                    </td>
                    <td>
                        <asp:TextBox ID="boxDisplayName" runat="server"  Width="452px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="displayNameReq" runat="server" ControlToValidate="boxDisplayName" ErrorMessage="Display Name is required">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email :
                        
                    </td>
                    <td>
                        <asp:TextBox ID="boxEmail" runat="server"  Width="452px" ></asp:TextBox>
                        <asp:RegularExpressionValidator ID="emailRegEx" runat="server" ControlToValidate="boxEmail" ErrorMessage="Email format is wrong" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">**</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password :
                       
                    </td>
                    <td>
                         <asp:TextBox ID="boxPassword" runat="server" Width="452px" OnTextChanged="boxPassword_TextChanged"></asp:TextBox>

                         <asp:RequiredFieldValidator ID="passwordReq" runat="server" ControlToValidate="boxPassword" ErrorMessage="Password is required">*</asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password :
                       
                    </td>
                    <td>
                         <asp:TextBox ID="boxConfrmPassword" runat="server"  Width="452px"></asp:TextBox>
                         <asp:CompareValidator ID="confrmPasswordCompare" runat="server" ControlToCompare="boxPassword" ControlToValidate="boxConfrmPassword" ErrorMessage="Password Mismatch">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter :
                   
                    </td>
                    <td>
                         <asp:TextBox ID="boxNewsLetter" runat="server"  Width="452px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSaveUser" runat="server" Text="Save User" Width="375px" OnClick="btnSaveUser_Click" />
                        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Width="502px" />
                    </td>
                    <td>

                    </td>
                </tr>  
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>

                    </td>
                </tr>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </table>
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
        </div>
        
    </form>
</body>
</html>
