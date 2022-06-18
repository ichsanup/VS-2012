<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBoxExample.aspx.cs" Inherits="ACTY1.ListBoxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>Phyton</asp:ListItem>
            <asp:ListItem>Java SCript</asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
