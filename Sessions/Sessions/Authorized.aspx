<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authorized.aspx.cs" Inherits="Sessions.Authorized" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1 id="page_heading" runat="server"></h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click"/>
    </form>
    
</body>
</html>
