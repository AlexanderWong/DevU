<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpyChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="spyImage" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <h2>Spy New Assignment Form</h2>
            <br />
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codenameTextBox" runat="server" OnTextChanged="codenameTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentnameTextBox" runat="server" OnTextChanged="assignmentnameTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment<asp:Calendar ID="endPreviousCalendar" runat="server" OnSelectionChanged="endPreviousCalendar_SelectionChanged"></asp:Calendar>
            <br />
            Start Date of New Assignment<asp:Calendar ID="startNewCalendar" runat="server" OnSelectionChanged="startNewCalendar_SelectionChanged"></asp:Calendar>
            <br />
            Projected End Date of New Assignment<asp:Calendar ID="projectedEndOfNewCalendar" runat="server" OnSelectionChanged="projectedEndOfNewCalendar_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Button ID="assignButton" runat="server" Text="Assign Spy" OnClick="assignButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
