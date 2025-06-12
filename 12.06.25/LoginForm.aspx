<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebApplication4.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            User Email&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 37px; margin-top: 0px" Width="469px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password<asp:TextBox ID="txtPassword" runat="server" style="margin-left: 52px" TextMode="Password" Width="468px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is mandatory">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="LOGIN" Width="191px" />

        </div>
    </form>
</body>
</html>
