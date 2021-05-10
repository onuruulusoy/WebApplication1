<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hiddenfield.aspx.cs" Inherits="WebApplication1.hiddenfield" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="güncelle" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="load employee" />
        </div>
    </form>
</body>
</html>
