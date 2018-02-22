<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChallengePostalCalculatorHelperMethods.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.ChallengePostalCalculatorHelperMethods" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:&nbsp;
            <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
            <br />
            Height:&nbsp;
            <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
            <br />
            Length:&nbsp;
            <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="lengthTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="nextdayRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="nextdayRadioButton_CheckedChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
