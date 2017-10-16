<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quiz.aspx.cs" Inherits="quizExample.quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="question1">What is the capital of Canada?</label>
            <asp:TextBox ID="question1" runat="server"></asp:TextBox>
            <asp:Label ID="question1_correction" runat="server"></asp:Label>
        </div>
        <div>
            <label for="question2">How many lives does a cat have?</label>
            <asp:TextBox ID="question2" runat="server"></asp:TextBox>
            <asp:Label ID="question2_correction" runat="server"></asp:Label>
        </div>
        <div>
            <label for="question3">How many parking lots does Humber have?</label>
            <asp:Textbox ID="question3" runat="server" CausesValidation="True" MaxLength="100" ValidateRequestMode="Enabled"></asp:Textbox>
            <asp:Label ID="question3_correction" runat="server"></asp:Label>
        </div>
        <div>
            <label for="question4">If a tree falls in the woods and no one is around to hear it, does it make a sound?</label>
            <asp:RadioButtonList ID="question4" runat="server">
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Value="false">No</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="question4_correction" runat="server"></asp:Label>
        </div>
        <div>
            <label for="question5">Do you even lift?</label>
            <asp:RadioButtonList ID="question5" runat="server">
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Value="false">No</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="question5_correction" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Button ID="quiz_submit" runat="server" Text="Quiz me" OnClick="quiz_submit_Click"/>
            <asp:Label ID="feedback" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
