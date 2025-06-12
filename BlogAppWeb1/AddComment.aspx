<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="BlogAppWeb1.AddComment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPostId" runat="server" Text="Select Blog Post:"></asp:Label>
<asp:DropDownList ID="ddlPostId" runat="server"></asp:DropDownList>
<br />
            <asp:Panel ID="pnlAddComment" runat="server">
    <asp:Label ID="lblTitle" runat="server" Text="Title:"></asp:Label>
    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblCommentText" runat="server" Text="Comment:"></asp:Label>
    <asp:TextBox ID="txtCommentText" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />

    <asp:Label ID="lblCommentBy" runat="server" Text="Your Name:"></asp:Label>
    <asp:TextBox ID="txtCommentBy" runat="server"></asp:TextBox>
    <br />


    <asp:Button ID="btnAddComment" runat="server" Text="Submit Comment" OnClick="btnAddComment_Click" />
</asp:Panel>
            <asp:GridView ID="gridComments" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Title" HeaderText="Title" />
        <asp:BoundField DataField="CommentText" HeaderText="Comment" />
        <asp:BoundField DataField="CommentBy" HeaderText="Posted By" />
    </Columns>
</asp:GridView>

        </div>
    </form>
</body>
</html>
