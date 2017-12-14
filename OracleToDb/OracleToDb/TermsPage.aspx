<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TermsPage.aspx.cs" Inherits="OracleToDb.TermsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btn_add_terms" runat="server" OnClick="btn_add_terms_Click" Text="Add new terms"/>
        <asp:Label ID="lbl_success_message" runat="server"></asp:Label>
        <asp:Label ID="lbl_error_message" runat="server"></asp:Label>
    </form>
</body>
</html>
