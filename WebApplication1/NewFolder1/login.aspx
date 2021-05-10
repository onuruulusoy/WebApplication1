<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        body {
            margin: 0;
            background-color: aquamarine;
        }

        .auto-style2 {
            width: 429px;
            height: 164px;
        }

        .auto-style3 {
            width: 164px;
        }

        #div1 {
            width: 30%;
            height: 200px;
            background-color: lightblue;
            position: absolute;
            border-radius: 10px;
            left: 35%;
            top: 25%;
        }


    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div id="div1">

            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kullanıcı Adı:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Şifre:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Giriş Yap" Width="127px" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;
                        Üyeliğiniz yok ise tıklayın.</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Kayıt Ol" Width="106px" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
    <p>
        &nbsp;
    </p>
</body>
</html>
