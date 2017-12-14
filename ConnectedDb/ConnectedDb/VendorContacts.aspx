<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VendorContacts.aspx.cs" Inherits="ConnectedDb.VendorContacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_db_error" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lbl_rows_affected" runat="server"></asp:Label>
        <ul id="list_vendor_contacts" runat="server">

        </ul>
        ID: <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
        <br />
        First name: <asp:TextBox ID="txt_first_name" runat="server"></asp:TextBox>
        <br />
        Last name: <asp:TextBox ID="txt_last_name" runat="server"></asp:TextBox>
        <br />
        Email: <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_add_vc" runat="server" Text="Add Vendor Contact" onclick="btn_add_vc_Click"/>
        <br />
        <asp:Button ID="btn_update_vc" runat="server" Text="Update Vendor Contact" OnClick="btn_update_vc_Click" />
        <br />
        <asp:Button ID="btn_delete_vc" runat="server" Text="Delete Vendor Contact" OnClick="btn_delete_vc_Click" />
    </form>
</body>
</html>
