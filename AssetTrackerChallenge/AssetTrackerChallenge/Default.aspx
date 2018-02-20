<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssetTrackerChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Calibri;
        }
        .auto-style2 {
            color: #333333;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
            <h2 class="auto-style1"><em><span class="auto-style2">Asset Performance Tracker</span></em></h2>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetsTextBox" runat="server" OnTextChanged="assetTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:&nbsp; <asp:TextBox ID="riggedTextBox" runat="server" OnTextChanged="riggedTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="subterfugeTextBox" runat="server" OnTextChanged="subterfugeTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
