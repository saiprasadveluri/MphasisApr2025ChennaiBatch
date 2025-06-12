<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUserForm.aspx.cs" Inherits="BlogAppWeb.NewUserForm" EnableTheming="true" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 396px; width: 761px">
    <form id="form1" runat="server">
        <div>
            <table style="height: 358px; width: 547px;">
                <tr>
                    <td>
                        Display Name
                        <asp:TextBox ID="txtDisplayName" runat="server" style="margin-left: 53px" Width="267px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="dispnameReq" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="Display name Required">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email
                        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 104px" Width="267px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="emailReq" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="mail error" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                 

                 <tr>
                    <td>
                        Password
                        <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 78px" Width="267px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" EnableTheming="False" ErrorMessage="Required Password">++</asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td>
                        Confirm Password
                        <asp:TextBox ID="txtConfirmPassword" runat="server" style="margin-left: 25px" Width="269px" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Mismatch">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        News Letter:
                        <asp:TextBox ID="txtNewsLetter" runat="server" style="margin-left: 56px" Width="276px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                
                <asp:Button ID="Button1" runat="server" Text="Button" />
                
                <tr>
                    <td>
                        <asp:Button ID="btnSaveUser" runat="server" Height="26px" OnClick="btnSaveUser_Click" Text="Save User" Width="176px" />
                        <asp:Button ID="btnCancle" runat="server" CausesValidation="False" EnableViewState="False" Height="26px" OnClick="btnCancle_Click" Text="Cancle" Width="176px" />
                    </td>
                </tr>
                
            </table>

            
        </div>
        
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="137px" style="margin-top: 98px" />
        
    </form>
</body>
</html>
