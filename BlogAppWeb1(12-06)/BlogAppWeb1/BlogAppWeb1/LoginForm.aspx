<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="BlogAppWeb1.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="User Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Requires"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 11px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Mandate"></asp:RequiredFieldValidator>
            
        </div>
        <asp:Button ID="BtnLogin" runat="server" OnClick="Btn_Click" Text="Button" />
    </form>
</body>
</html>
