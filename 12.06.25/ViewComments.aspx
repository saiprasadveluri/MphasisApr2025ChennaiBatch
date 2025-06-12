<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewComments.aspx.cs" Inherits="WebApplication4.ViewComments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>View Comments by Blog Post</h2>

        <asp:DropDownList ID="ddlPosts" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPosts_SelectedIndexChanged" />
        <br /><br />

        <asp:GridView ID="gvComments" runat="server" AutoGenerateColumns="false" EmptyDataText="No comments found.">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="Comment Title" />
                <asp:BoundField DataField="CommentText" HeaderText="Comment Text" />
            </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
