<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BlogWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 59px;
        }
        .auto-style2 {
            height: 34px;
        }
        .auto-style3 {
            margin-left: 63px;
        }
        .auto-style4 {
            margin-left: 125px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:Label ID="UserEmailLabel" runat="server" Text="UserEmail"></asp:Label>
            <asp:TextBox ID="TextUserEmail" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextUserEmail" ErrorMessage="Email Required">*</asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextPassword" runat="server" CssClass="auto-style3"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextPassword" ErrorMessage="Password Required">*</asp:RequiredFieldValidator>
        <p>
            <asp:Button ID="SaveButton" runat="server" CssClass="auto-style4" OnClick="Button1_Click" Text="Save" Width="117px" />
        </p>
    </form>
</body>
</html>
