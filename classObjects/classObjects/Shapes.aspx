<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shapes.aspx.cs" Inherits="classObjects.Shapes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shape Areas</title>
</head>
<body>
    <h1>Shape Areas</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_length" runat="server">Length: </asp:Label><asp:TextBox ID="txt_length" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbl_height" runat="server">Height: </asp:Label><asp:TextBox ID="txt_height" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbl_radius" runat="server">Radius: </asp:Label><asp:TextBox ID="txt_radius" runat="server"></asp:TextBox>
        </div>
        <ul>
            <li>
                <asp:Button ID="btn_circle" runat="server" Text="Circle" OnClick="btn_circle_Click" />
            </li>
        </ul>
        <asp:Label ID="result" runat="server"></asp:Label>
    </form>
</body>
</html>
