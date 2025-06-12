<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="WebApplication4.AddComment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Comments</h2>
 
        </div>
    <p>
        PostId:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlPostId" runat="server" Height="18px" Width="219px">
        </asp:DropDownList>
        </p>
        <p>
            Title:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtTitle" runat="server" style="margin-left: 20px" Width="209px"></asp:TextBox>
        </p>
        <p>
            Comment Text:&nbsp;
            <asp:TextBox ID="txtCommentText" runat="server" Width="217px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAddComment" runat="server" OnClick="btnAddComment_Click" Text="Add Comment" Width="130px" />
        </p>
        <asp:Label ID="lblStatus" runat="server" ForeColor="Green" />
    </form>
    </body>
</html>
