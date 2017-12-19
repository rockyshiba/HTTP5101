<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sessions.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1 id="page_title" runat="server"></h1>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_get_var" runat="server"></asp:Label>
        <div>
            email: <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        </div>
        <div>
            password: <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="login"/>
        </div>
    </form>
</body>
</html>
