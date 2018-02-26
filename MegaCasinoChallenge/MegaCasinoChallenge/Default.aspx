<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaCasinoChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Georgia, "Times New Roman", Times, serif;
        }
        .auto-style2 {
            background-color: #FFCC00;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style6 {
            font-family: Calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style1"><em><span class="auto-style2">Welcome to the Casino! Are you ready to win big?</span></em></h2>
            <br />
            <asp:Image ID="Image1" runat="server" Height="165px" Width="157px" />
            <asp:Image ID="Image2" runat="server" Height="165px" Width="157px" />
            <asp:Image ID="Image3" runat="server" Height="165px" Width="157px" />
            <br />
            <br />
            Your Bet:&nbsp; <asp:TextBox ID="betTextBox" runat="server" OnTextChanged="betTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="pullLeverButton" runat="server" OnClick="pullLeverButton_Click" Text="Pull Lever!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry - x2 Your Bet<br />
            2 Cherry - x3 Your Bet<br />
            3 Cherry - x4 Your Bet<br />
            3 7&#39;s - JACKPOT - x100 Your Bet<br />
            HOWEVER... if there is even <em>ONE</em> <strong>BAR</strong> you win <span class="auto-style3">NOTHING</span>!</div>
    </form>
</body>
</html>
