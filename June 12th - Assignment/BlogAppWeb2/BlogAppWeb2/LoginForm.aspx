<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogAppWeb2.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            User Email:
            <asp:TextBox ID="txtEmail" runat="server" Width="385px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email required"></asp:RequiredFieldValidator>
            <br />
            Password:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="390px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is mandatory"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="221px" />
            
        </div>
    </form>
</body>
</html>
