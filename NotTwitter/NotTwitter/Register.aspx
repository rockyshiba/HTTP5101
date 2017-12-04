<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NotTwitter.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!--form to create a post-->
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_post_author" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txt_post_author" runat="server"></asp:TextBox><!--input box for user to provide a name-->
            <asp:Label ID="lbl_post_author_validation_message" runat="server"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txt_post_body" textmode="MultiLine" col="50" rows="10" runat="server"></asp:TextBox><!--input textarea for user to provide a post-->
            <asp:Label ID="lbl_post_body_validation_message" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btn_post_submit" runat="server" Text="POST" OnClick="btn_post_submit_Click"/>
        </div>
    </form>
    <!--output from server-->
    <div>
        <asp:Label ID="lbl_post_body_server" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lbl_post_author_server" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lbl_post_count" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lbl_post_date" runat="server"></asp:Label>
    </div>
</body>
</html>
