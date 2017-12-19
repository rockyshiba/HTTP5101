<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="Sessions.Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_username" runat="server"></asp:Label>
        <div>
            username: <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
        </div>
        <div>
            password: <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
        <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />
    </form>
</body>
</html>
