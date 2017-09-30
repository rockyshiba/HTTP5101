<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Geometry.aspx.cs" Inherits="sept26.Geometry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Radius: <asp:TextBox ID="radius" runat="server"></asp:TextBox> 
        Height: <asp:TextBox ID="height" runat="server"></asp:TextBox>
        <asp:Button ID="circle_button" runat="server" Text="Area of circle" Onclick="circle_button_Click"/>
        <asp:Button ID="sphere_button" runat="server" Text="Area of sphere" OnClick="sphere_button_Click" />
        <asp:Button ID="cylinder_button" runat="server" Text="Area of cylinder" OnClick="cylinder_button_Click" />
        <asp:Label ID="result" runat="server" Text="Results appear here"></asp:Label>
    </form>
</body>
</html>
