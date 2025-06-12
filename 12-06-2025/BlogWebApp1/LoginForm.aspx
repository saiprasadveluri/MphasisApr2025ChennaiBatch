<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogWebApp1.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            User Email
            <asp:TextBox ID="txtEmail" runat="server" Width="223px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Email_Required" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
        </p>
        <p>
            Password
            <asp:TextBox ID="txtPassword" runat="server" Width="226px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="93px" />
    </form>
</body>
</html>
