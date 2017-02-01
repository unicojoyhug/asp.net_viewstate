<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ViewStatePractice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            You clicked  : 
        <br />
            <asp:Label ID="counterLabel" runat="server" />
            <br />

            <asp:Button ID="countButton" runat="server" Text="Count" OnClick="countButton_Click" />
            <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />

        </div>
    </form>
</body>
</html>
