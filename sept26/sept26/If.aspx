<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="If.aspx.cs" Inherits="sept26.If" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="output" runat="server">
            Odd/Even
        </div>
        Number:
        <asp:TextBox ID="user_input_textbox" runat="server"></asp:TextBox>
        <asp:Button ID="user_button" runat="server" OnClick="user_button_click" Text="Check"/>
    </form>
</body>
</html>
