<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminKullanici.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
    <meta name="generator" content="Hugo 0.82.0" />
    <link rel="stylesheet" href="../assets/css/bootstrap.min.css" />
    <script src="../Kaynak/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="../assets/css/fontawesome.min.css" />
    <script src="../assets/js/jquery-1.11.0.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.slim.min.js"></script>


    <title></title>
    <style>
        body {
            min-height: 110vh;
            background-color: #4ca1af;
            background-image: linear-gradient(135deg, #4ca1af 0%, #c4e0e5 100%);
        }

        </style>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    <link href="../assets/style.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,700' rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- partial:index.partial.html -->
        <header class="header" role="banner">
            <h1 class="logo">
                <a href="#">Admin <span>Paneli</span></a>
            </h1>
            <div class="nav-wrap">
                <nav class="main-nav" role="navigation">
                    <ul class="unstyled list-hover-slide">
                        <li><a href="AdminUrun.aspx">Ürünler</a></li>
                        <li><a href="#">Kullanıcılar</a></li>
                        <li><a href="../login2.aspx">Çıkış Yap</a></li>
           
                    </ul>
                </nav>
            </div>

        </header>
        <div style="margin-left: 300px; margin-top:30px;">
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" BackColor="#CCFFCC" Font-Names="Arial" Height="256px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="634px"></asp:ListBox>
        </div>
        <div style="margin-left: 500px;">

        </div>

            <br />
            <br />
            <div style="margin-left: 300px; margin-right: 500px;">
                <div class="card card-primary" style="left: 1px; top: 0px">
                    <div class="card-header">
                        <h3 class="card-title">Kullanıcı Güncelle</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->

                    <div class="card-body">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Kullanıcı Adı</label>
                            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Adı Soyadı</label>

                            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Kullanıcı E-Posta</label>

                            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Kullanıcı Parola</label>

                            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                        </div><div class="form-group">
                            <label for="exampleInputPassword1">Kullanıcı Rolü</label>

                            <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <!-- /.card-body -->

                    <div class="card-footer">
                        <asp:Button ID="Button1" runat="server" Text="Kaydet" class="w-100 btn btn-lg btn-dark" OnClick="Button1_Click" Width="47px" />
                        <br />
                        <br />
                        <asp:Button ID="Button3" runat="server" Text="Sil" class="w-100 btn btn-lg btn-danger" OnClick="Button3_Click" />
                    </div>

                </div>
                <br />
            <br />
                <div class="card card-primary" style="left: 1px; top: 0px">
                    <div class="card-header">
                        <h3 class="card-title">Kullanıcı Ekleme</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->

                    <div class="card-body">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Kullanıcı Adı</label>
                            <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Adı Soyadı</label>

                            <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Kullanıcı E-Posta</label>

                            <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Kullanıcı Parola</label>

                            <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Kullanıcı Rolü</label>

                            <asp:TextBox ID="TextBox10" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                       

                    </div>

                    <!-- /.card-body -->

                    <div class="card-footer">
                        <asp:Button ID="Button2" runat="server" Text="Ekle" class="w-100 btn btn-lg btn-dark" OnClick="Button2_Click" />
                    </div>

                </div>
            </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT [urun_adi], [urun_fiyat], [urun_katagori], [urun_resim], [aciklama] FROM [urunler]"></asp:SqlDataSource>
        <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    </form>
</body>
</html>