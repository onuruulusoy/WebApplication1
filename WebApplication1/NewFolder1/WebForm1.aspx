<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table cellpadding="5" cellspacing="0" class="auto-style3">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Ad Soyad: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Adınızı ve Soyadınızı Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="E-Posta:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server" Width="218px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="E-Posta Adresinizi Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Lütfen Geçerli Bir E-Posta Giriniz!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="aaa">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Parola:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Width="164px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Parolanızı Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Parola Tekrar:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="162px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Parolanızı Tekrar Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Parolanızı Hatalı Girdiniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Yaşınız: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Width="33px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Yaşınızı Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="18 ile 60 yaş arasında olmalısıznız!" ForeColor="Red" MaximumValue="60" MinimumValue="18" Type="Integer" ValidationGroup="aaa">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Cinsiyetiniz:"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Kadın</asp:ListItem>
                            <asp:ListItem>Erkek</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Cinsiyetinizi Seçiniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" ValidationGroup="aaa" OnClick="Button1_Click1" />
                        <br />
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="aaa" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="kullanici_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="kullanici_adi" HeaderText="kullanici_adi" SortExpression="kullanici_adi" />
                <asp:BoundField DataField="sifre" HeaderText="sifre" SortExpression="sifre" />
                <asp:BoundField DataField="eposta" HeaderText="eposta" SortExpression="eposta" />
                <asp:BoundField DataField="yas" HeaderText="yas" SortExpression="yas" />
                <asp:BoundField DataField="cinsiyet" HeaderText="cinsiyet" SortExpression="cinsiyet" />
                <asp:BoundField DataField="adi_soyadi" HeaderText="adi_soyadi" SortExpression="adi_soyadi" />
                <asp:BoundField DataField="kullanici_id" HeaderText="kullanici_id" InsertVisible="False" ReadOnly="True" SortExpression="kullanici_id" />
                <asp:BoundField DataField="admin" HeaderText="admin" SortExpression="admin" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" DeleteCommand="DELETE FROM [kullanici] WHERE [kullanici_id] = @kullanici_id" InsertCommand="INSERT INTO [kullanici] ([kullanici_adi], [sifre], [eposta], [yas], [cinsiyet], [adi_soyadi], [admin]) VALUES (@kullanici_adi, @sifre, @eposta, @yas, @cinsiyet, @adi_soyadi, @admin)" SelectCommand="SELECT * FROM [kullanici]" UpdateCommand="UPDATE [kullanici] SET [kullanici_adi] = @kullanici_adi, [sifre] = @sifre, [eposta] = @eposta, [yas] = @yas, [cinsiyet] = @cinsiyet, [adi_soyadi] = @adi_soyadi, [admin] = @admin WHERE [kullanici_id] = @kullanici_id">
            <DeleteParameters>
                <asp:Parameter Name="kullanici_id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="kullanici_adi" Type="String" />
                <asp:Parameter Name="sifre" Type="String" />
                <asp:Parameter Name="eposta" Type="String" />
                <asp:Parameter Name="yas" Type="String" />
                <asp:Parameter Name="cinsiyet" Type="String" />
                <asp:Parameter Name="adi_soyadi" Type="String" />
                <asp:Parameter Name="admin" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="kullanici_adi" Type="String" />
                <asp:Parameter Name="sifre" Type="String" />
                <asp:Parameter Name="eposta" Type="String" />
                <asp:Parameter Name="yas" Type="String" />
                <asp:Parameter Name="cinsiyet" Type="String" />
                <asp:Parameter Name="adi_soyadi" Type="String" />
                <asp:Parameter Name="admin" Type="String" />
                <asp:Parameter Name="kullanici_id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
