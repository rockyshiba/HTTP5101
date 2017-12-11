<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HappyBirthday.aspx.cs" Inherits="NotTwitter.HappyBirthday" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First name: <asp:TextBox ID="txt_first_name" runat="server"></asp:TextBox>
        </div>
        <div>
            Last name: <asp:TextBox ID="txt_last_name" runat="server"></asp:TextBox>
        </div>
        <div>
            Date of birth: <input type="date" runat="server" id="input_date" />
        </div>
        <div>
            <asp:Button ID="btn_bday" runat="server" Text="Is it my Bday?" onclick="btn_bday_Click"/>
        </div>
        <div>
            <asp:Label ID="bday_message" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
