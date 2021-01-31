<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="strona.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Podaj swoje imie i nazwisko"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="168px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="20px" OnClick="Button1_Click" Text="Potwierdź" Width="80px" />
        </div>
    </form>
</body>
</html>
