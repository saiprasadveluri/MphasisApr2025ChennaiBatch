<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogAppWeb.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            UserEmai:<asp:TextBox ID="txtemail" runat="server" style="margin-left: 22px" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
            <br />
            <br />
            Password:<asp:TextBox ID="txtpassword" runat="server" style="margin-left: 23px" TextMode="Password" Width="174px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Password Is Required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Button" Width="189px" />

        </div>
    </form>
</body>
</html>
