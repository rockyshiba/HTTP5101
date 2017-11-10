<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="records.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List of Vendors</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Textbox ID="txt_name" runat="server"></asp:Textbox>
        <asp:Button ID="btn_search_name" runat="server" OnClick="btn_search_name_Click" Text="Search by name"/>
    </form>
    <ol id="vendors_list" runat="server"></ol>
</body>
</html>
