<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogWinApp.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Useremail:&nbsp;
            <asp:TextBox ID="txtemail" runat="server" TextMode="Email" Width="365px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Email Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            Password:&nbsp;
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="370px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Password is mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="122px" />
            
        </div>
    </form>
</body>
</html>
