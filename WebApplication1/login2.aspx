<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="WebApplication1.WebForm4" %>

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
                
            </div>
            <br />
            <div class="form-floating">
                <asp:Label ID="Label2" runat="server" CssClass="col-form-label-lg" Text="Şifre"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" class="w-100 btn btn-lg btn-secondary" OnClick="Button1_Click"  />
            
            <br />
            <br />
            
            <asp:Button ID="Button2" runat="server" Text="Kayıt Ol" class="w-100 btn btn-lg btn-info" OnClick="Button2_Click"  />
            
            <br />
            <br />
            
            <asp:Button ID="Button3" runat="server" Text="Admin Girişi Yap" class="w-100 btn btn-lg btn-dark" OnClick="Button3_Click"  />
        </form>
    </main>
</body>
</html>
