<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayit.aspx.cs" Inherits="WebApplication1.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
    <meta name="generator" content="Hugo 0.82.0" />

    <title></title>
    <link href="Kaynak/bootstrap.min.css" rel="stylesheet" />
    <link rel="canonical" href="https://getbootstrap.com/docs/5.0/examples/sign-in/" />
    <link href="Kaynak/signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    <main class="form-signin">
        <form id="form1" runat="server">           
            <h1 class="h3 mb-3 fw-normal">Hoşgeldiniz</h1>
            <div class="form-floating"> 
                <asp:Label ID="Label1" runat="server" CssClass="col-form-label-lg" Text="Kullanıcı Adı"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox1" ErrorMessage="Kullanıcı Adı Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label2" runat="server" CssClass="col-form-label-lg" Text="Ad Soyad:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Adınızı ve Soyadınızı Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label3" runat="server" CssClass="col-form-label-lg" Text="E-Posta:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="E-Posta Adresinizi Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Lütfen Geçerli Bir E-Posta Giriniz!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="aaa">*</asp:RegularExpressionValidator>
                    
                <br />
                <asp:Label ID="Label4" runat="server" CssClass="col-form-label-lg" Text="Parola:"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Parolanızı Giriniz!" ForeColor="Red" ValidationGroup="aaa">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label5" runat="server" CssClass="col-form-label-lg" Text="Parola Tekrar:"></asp:Label>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Paralanız Eşleşmiyor!" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="aaa">*</asp:CompareValidator>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="aaa" />
            <br />                      
            <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" class="w-100 btn btn-lg btn-info" OnClick="Button1_Click1"  />  
            <br />
            <br />                     
            <asp:Button ID="Button2" runat="server" Text="Giriş Ekranına Dön" class="w-100 btn btn-lg btn-secondary" OnClick="Button2_Click" />
        </form>
    </main>
</body>
</html>
