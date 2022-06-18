<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ACT2Lepkom.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Latihan Web Form</title>
    <style type="text/css">        .style1 {
            width: 156px;
        }
        .style2 {
            width: 332px;
        }
        .auto-style1 {
            width: 156px;
            height: 23px;
        }
        .auto-style2 {
            width: 332px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:54%">
            <tr>
                <td class="style1">Nama:</td>
                <td class="style2">
                    <asp:TextBox ID="txtnama" runat="server" style="width:230px">
                    </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">Alamat</td>
                <td class="style2">
                    <asp:TextBox ID="txtalamat" runat="server" style="width:230px">
                    </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">Kota</td>
                <td class="style2">
                    <asp:TextBox ID="txtkota" runat="server" style="width:230px">
                    </asp:TextBox>
                    </td>
            </tr>
            <tr>
            <td class="style1">Provinsi</td>
                <td class="style2">
                    <asp:TextBox ID="txtprovinsi" runat="server" style="width:230px">
                    </asp:TextBox>
                    </td>
                </tr>
            <tr>
                <td class="style1"></td>
                <td class="style2"></td>
            </tr>
            <tr>
                <td class="style1"></td>
                <td id="displayrow" runat="server" class="style2"></td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
    </form>
</body>
</html>
