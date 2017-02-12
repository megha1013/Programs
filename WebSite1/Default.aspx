<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/WebUserControl.ascx" TagPrefix="uc1" TagName="WebUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
 
        <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />

        <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button1_Click" />

        <asp:Button ID="Button3" runat="server" Text="Button3" OnClick="Button1_Click" />
  
        <asp:Button ID="Button4" runat="server" Text="Button4" OnClick="Button1_Click" />
           </div>
        <div>
            <uc1:WebUserControl runat="server" ID="WebUserControl" />
        </div>
    </form>
</body>
</html>
