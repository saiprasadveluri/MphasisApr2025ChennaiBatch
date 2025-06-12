<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogAppWeb1.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Email<asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged" Width="284px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            Password<asp:TextBox ID="txtPassword" runat="server" Width="291px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Button" Width="149px" />
    </form>
</body>
</html>
