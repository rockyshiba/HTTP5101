<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="sept26.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Login page</h1>
    <form id="form1" runat="server">
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <asp:Button ID="login_button" runat="server" Text="Login" onclick="login_button_Click"/>
        <asp:Button ID="length_button" runat="server" Text="Check length" OnClick="length_button_Click" />
        <asp:Label ID="server_response" runat="server"></asp:Label>
    </form>
</body>
</html>
