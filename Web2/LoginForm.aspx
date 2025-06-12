<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Web2.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="User Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 94px" Width="229px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is RequiredField"></asp:RequiredFieldValidator>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 103px" TextMode="Password" Width="223px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequiredField" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required"></asp:RequiredFieldValidator>
        </div>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="margin-left: 83px" Text="Login" />
        </p>
    </form>
</body>
</html>
