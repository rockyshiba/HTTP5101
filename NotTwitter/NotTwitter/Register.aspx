<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NotTwitter.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_post_author" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txt_post_author" runat="server"></asp:TextBox>
            <asp:Label ID="lbl_post_author_validation_message" runat="server"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txt_post_body" textmode="MultiLine" col="50" rows="10" runat="server"></asp:TextBox>
            <asp:Label ID="lbl_post_body_validation_message" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btn_post_submit" runat="server" Text="POST"/>
        </div>
    </form>
    <div>
        <asp:Label ID="lbl_post_body_server" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lbl_post_author_server" runat="server"></asp:Label>
    </div>
</body>
</html>
