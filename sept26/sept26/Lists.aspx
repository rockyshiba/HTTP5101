<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lists.aspx.cs" Inherits="sept26.Lists" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ul id="name_output" runat="server">

        </ul>

        <hr />

        Search by name:
        <asp:TextBox ID="search_box" runat="server" OnTextChanged="search_box_TextChanged"></asp:TextBox>
        <asp:Label ID="search_response" runat="server"></asp:Label>
    </form>
</body>
</html>
