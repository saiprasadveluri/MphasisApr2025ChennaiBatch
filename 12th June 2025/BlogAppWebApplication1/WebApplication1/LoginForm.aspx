<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebApplication1.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUEmail" runat="server" Text="User Email"></asp:Label>
            <asp:TextBox ID="txtUEmail" runat="server" TextMode="Email" Width="383px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqUEmail" runat="server" ControlToValidate="txtUEmail" ErrorMessage="Email is required"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="lblPswd" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPswd" runat="server" TextMode="Password" Width="389px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqPswd" runat="server" ControlToValidate="txtPswd" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="141px" />
        </p>
    </form>
</body>
</html>
