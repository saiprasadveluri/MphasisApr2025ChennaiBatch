<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogWebApp1.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Email :<asp:TextBox ID="txtEmail" runat="server" style="margin-left: 63px" Width="281px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="emailValidator" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
            <br />
            Password:
            <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 69px" Width="279px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Mandatory"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="276px" />
    </form>
</body>
</html>
