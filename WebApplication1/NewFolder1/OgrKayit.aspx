<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OgrKayit.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>


    </title>        <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body style="width: 436px">
    <form id="form1" runat="server">
        <table class="style1">
            <tr>
                <td>
                    Öğrencinin Adı</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Öğrencinin Soyadı</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Adres</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="90px" TextMode="MultiLine"
                        Width="225px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Cep Tel.</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Kaydet" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; color: #FF9900">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
