<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="noFunctions.aspx.cs" Inherits="NotTwitter.noFunctions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_chirp" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btn_chirp" runat="server" Text="POST" onclick="btn_chirp_Click"/>
        </div>
        <asp:Label ID="lbl_chirp" runat="server"></asp:Label>
    </form>
</body>
</html>
