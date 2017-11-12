<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Terms.aspx.cs" Inherits="records.Terms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_id" runat="server" Text="Id:"></asp:Label>
        <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_terms_description" runat="server" Text="Terms Description:"></asp:Label>
        <asp:TextBox ID="txt_terms_description" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_terms_due_days" runat="server" Text="Terms Due Days:"></asp:Label>
        <asp:TextBox ID="txt_terms_due_days" runat="server"></asp:TextBox>
        <asp:Button ID="btn_add_terms" runat="server" Text="Add Terms item" OnClick="btn_add_terms_Click" />
        <asp:Label ID="lbl_result_message" runat="server"></asp:Label>
    </form>
    <!--<table id="terms_table" runat="server">
        <tr><th>ID</th><th>Terms Description</th><th>Terms Due Days</th></tr>
    </table>-->
    <asp:Table ID="tbl_terms" runat="server" BorderWidth="1px" BorderColor="Black" BorderStyle="Groove">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>Id</asp:TableHeaderCell>
            <asp:TableHeaderCell>Terms Description</asp:TableHeaderCell>
            <asp:TableHeaderCell>Terms Due Days</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>
</body>
</html>
