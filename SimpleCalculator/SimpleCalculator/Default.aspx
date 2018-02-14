<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                <span class="auto-style1">First Value:</span>&nbsp;&nbsp;
                <asp:TextBox ID="firstValueTextBox" runat="server" OnTextChanged="firstValueTextBox_TextChanged"></asp:TextBox>
            </p>
            <p>
                <span class="auto-style1">Second Value:</span>&nbsp;
                <asp:TextBox ID="secondValueTextBox" runat="server" OnTextChanged="secondValueTextBox_TextChanged"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" />
&nbsp;&nbsp;
                <asp:Button ID="subtractionButton" runat="server" OnClick="subtractionButton_Click" Text="-" />
&nbsp;&nbsp;
                <asp:Button ID="multiplicationButton" runat="server" OnClick="multiplicationButton_Click" Text="*" />
&nbsp;&nbsp;
                <asp:Button ID="divisionButton" runat="server" OnClick="divisionButton_Click" Text="/" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; font-size: medium"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
