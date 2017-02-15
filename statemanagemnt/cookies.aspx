<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cookies.aspx.cs" Inherits="cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Set cookies" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear Cookie" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="check" />
        :&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
