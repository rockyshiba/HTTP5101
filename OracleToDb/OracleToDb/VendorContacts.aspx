<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VendorContacts.aspx.cs" Inherits="OracleToDb.VendorContacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Button ID="btn_blank" runat="server" OnClick="btn_blank_Click" />
    <form id="form1" runat="server">
        <div id="vendor_contacts" runat="server">

        </div>
        Vendor Id: <asp:TextBox ID="txt_vendor_id" runat="server"></asp:TextBox>
        <br />
        Vendor first name: <asp:TextBox ID="txt_vendor_first_name" runat="server"></asp:TextBox>
        <br />
        Vendor last name: <asp:TextBox ID="txt_vendor_last_name" runat="server"></asp:TextBox>
        <br />
        Vendor email: <asp:TextBox ID="txt_vendor_email" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_add_vendor_contact" runat="server" Text="Add Vendor" onclick="btn_add_vendor_contact_Click"/>
        <br />
        <asp:Button ID="btn_update_vendor_contact" runat="server" Text="Update vendor" OnClick="btn_update_vendor_contact_Click" />
        <br />
        <asp:Button ID="btn_delete_vendor_contact" runat="server" Text="Delete vendor" OnClick="btn_delete_vendor_contact_Click" />
        <br />
        <asp:Label ID="lbl_server_message" runat="server"></asp:Label>
    </form>
</body>
</html>
