<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="WebApplication1.AnaSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
    <meta name="generator" content="Hugo 0.82.0" />



    <link rel="apple-touch-icon" href="assets/img/apple-icon.png" />
    <link rel="shortcut icon" type="image/x-icon" href="assets/img/favicon.ico" />
    <link rel="stylesheet" href="assets/css/bootstrap.min.css" />
    <link rel="stylesheet" href="assets/css/templatemo.css" />
    <link rel="stylesheet" href="assets/css/custom.css" />

    <!-- Load fonts style after rendering the layout styles -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;200;300;400;500;700;900&display=swap" />
    <link rel="stylesheet" href="assets/css/fontawesome.min.css" />
    <title></title>
    <link href="Kaynak/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }

        .auto-style5 {
            font-size: x-large;
        }

        .auto-style6 {
            font-size: large;
        }

        #DataList1 {
            margin-top: 50px;
            margin-left: 220px;
            margin-right: 220px;
        }

        .auto-style9 {
            left: -11px;
            top: -428px;
        }

        .auto-style10 {
            margin-left: 568px;
        }
    </style>
    <link href="Kaynak/headers.css" rel="stylesheet" />
</head>
<body>
    <!-- Start Top Nav -->
    <nav class="navbar navbar-expand-lg bg-dark navbar-light d-none d-lg-block" id="templatemo_nav_top">
        <div class="container text-light">
            <div class="w-100 d-flex justify-content-between">
                <div>
                    <i class="fa fa-envelope mx-2"></i>
                    <a class="navbar-sm-brand text-light text-decoration-none" href="mailto:info@zamazon.com">info@zamazon.com</a>
                    <i class="fa fa-phone mx-2"></i>
                    <a class="navbar-sm-brand text-light text-decoration-none" href="#">0-850-00-00</a>
                </div>
                <div>
                    <a class="text-light" href="https://fb.com/templatemo" target="_blank" rel="sponsored"><i class="fab fa-facebook-f fa-sm fa-fw me-2"></i></a>
                    <a class="text-light" href="https://www.instagram.com/" target="_blank"><i class="fab fa-instagram fa-sm fa-fw me-2"></i></a>
                    <a class="text-light" href="https://twitter.com/" target="_blank"><i class="fab fa-twitter fa-sm fa-fw me-2"></i></a>
                    <a class="text-light" href="https://www.linkedin.com/" target="_blank"><i class="fab fa-linkedin fa-sm fa-fw"></i></a>
                </div>
            </div>
        </div>
    </nav>
    <!-- Close Top Nav -->

    <svg xmlns="http://www.w3.org/2000/svg" style="display: none;">
        <symbol id="bootstrap" viewBox="0 0 118 94">
            <title>Bootstrap</title>
            <path fill-rule="evenodd" clip-rule="evenodd" d="M24.509 0c-6.733 0-11.715 5.893-11.492 12.284.214 6.14-.064 14.092-2.066 20.577C8.943 39.365 5.547 43.485 0 44.014v5.972c5.547.529 8.943 4.649 10.951 11.153 2.002 6.485 2.28 14.437 2.066 20.577C12.794 88.106 17.776 94 24.51 94H93.5c6.733 0 11.714-5.893 11.491-12.284-.214-6.14.064-14.092 2.066-20.577 2.009-6.504 5.396-10.624 10.943-11.153v-5.972c-5.547-.529-8.934-4.649-10.943-11.153-2.002-6.484-2.28-14.437-2.066-20.577C105.214 5.894 100.233 0 93.5 0H24.508zM80 57.863C80 66.663 73.436 72 62.543 72H44a2 2 0 01-2-2V24a2 2 0 012-2h18.437c9.083 0 15.044 4.92 15.044 12.474 0 5.302-4.01 10.049-9.119 10.88v.277C75.317 46.394 80 51.21 80 57.863zM60.521 28.34H49.948v14.934h8.905c6.884 0 10.68-2.772 10.68-7.727 0-4.643-3.264-7.207-9.012-7.207zM49.948 49.2v16.458H60.91c7.167 0 10.964-2.876 10.964-8.281 0-5.406-3.903-8.178-11.425-8.178H49.948z"></path>
        </symbol>
        <symbol id="home" viewBox="0 0 16 16">
            <path d="M8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4.5a.5.5 0 0 0 .5-.5v-4h2v4a.5.5 0 0 0 .5.5H14a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146zM2.5 14V7.707l5.5-5.5 5.5 5.5V14H10v-4a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 0-.5.5v4H2.5z" />
        </symbol>
        <symbol id="speedometer2" viewBox="0 0 16 16">
            <path d="M8 4a.5.5 0 0 1 .5.5V6a.5.5 0 0 1-1 0V4.5A.5.5 0 0 1 8 4zM3.732 5.732a.5.5 0 0 1 .707 0l.915.914a.5.5 0 1 1-.708.708l-.914-.915a.5.5 0 0 1 0-.707zM2 10a.5.5 0 0 1 .5-.5h1.586a.5.5 0 0 1 0 1H2.5A.5.5 0 0 1 2 10zm9.5 0a.5.5 0 0 1 .5-.5h1.5a.5.5 0 0 1 0 1H12a.5.5 0 0 1-.5-.5zm.754-4.246a.389.389 0 0 0-.527-.02L7.547 9.31a.91.91 0 1 0 1.302 1.258l3.434-4.297a.389.389 0 0 0-.029-.518z" />
            <path fill-rule="evenodd" d="M0 10a8 8 0 1 1 15.547 2.661c-.442 1.253-1.845 1.602-2.932 1.25C11.309 13.488 9.475 13 8 13c-1.474 0-3.31.488-4.615.911-1.087.352-2.49.003-2.932-1.25A7.988 7.988 0 0 1 0 10zm8-7a7 7 0 0 0-6.603 9.329c.203.575.923.876 1.68.63C4.397 12.533 6.358 12 8 12s3.604.532 4.923.96c.757.245 1.477-.056 1.68-.631A7 7 0 0 0 8 3z" />
        </symbol>
        <symbol id="table" viewBox="0 0 16 16">
            <path d="M0 2a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V2zm15 2h-4v3h4V4zm0 4h-4v3h4V8zm0 4h-4v3h3a1 1 0 0 0 1-1v-2zm-5 3v-3H6v3h4zm-5 0v-3H1v2a1 1 0 0 0 1 1h3zm-4-4h4V8H1v3zm0-4h4V4H1v3zm5-3v3h4V4H6zm4 4H6v3h4V8z" />
        </symbol>
        <symbol id="people-circle" viewBox="0 0 16 16">
            <path d="M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z" />
            <path fill-rule="evenodd" d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z" />
        </symbol>
        <symbol id="grid" viewBox="0 0 16 16">
            <path d="M1 2.5A1.5 1.5 0 0 1 2.5 1h3A1.5 1.5 0 0 1 7 2.5v3A1.5 1.5 0 0 1 5.5 7h-3A1.5 1.5 0 0 1 1 5.5v-3zM2.5 2a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zm6.5.5A1.5 1.5 0 0 1 10.5 1h3A1.5 1.5 0 0 1 15 2.5v3A1.5 1.5 0 0 1 13.5 7h-3A1.5 1.5 0 0 1 9 5.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zM1 10.5A1.5 1.5 0 0 1 2.5 9h3A1.5 1.5 0 0 1 7 10.5v3A1.5 1.5 0 0 1 5.5 15h-3A1.5 1.5 0 0 1 1 13.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3zm6.5.5A1.5 1.5 0 0 1 10.5 9h3a1.5 1.5 0 0 1 1.5 1.5v3a1.5 1.5 0 0 1-1.5 1.5h-3A1.5 1.5 0 0 1 9 13.5v-3zm1.5-.5a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 0-.5-.5h-3z" />
        </symbol>
    </svg>
    <form id="form1" runat="server">


        <!-- Header -->
        <nav class="navbar navbar-expand-lg navbar-light shadow">
            <div class="container d-flex justify-content-between align-items-center">

                <a class="navbar-brand text-success logo h1 align-self-center" href="AnaSayfa.aspx">Zamazon
                </a>

                <button class="navbar-toggler border-0" type="button" data-bs-toggle="collapse" data-bs-target="#templatemo_main_nav" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="align-self-center collapse navbar-collapse flex-fill  d-lg-flex justify-content-lg-between" id="templatemo_main_nav">
                    <div class="flex-fill">
                        <ul class="nav navbar-nav d-flex justify-content-between mx-lg-auto">
                            <li class="nav-item">
                                <a class="nav-link" href="AnaSayfa.aspx">Anasayfa</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Kategori.aspx?urun_katagori=telefon">Telefonlar</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Kategori.aspx?urun_katagori=laptop">Bilgisayarlar</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Kategori.aspx?urun_katagori=tablet">Tabletler</a>
                            </li>
                        </ul>
                    </div>
                    <div class="navbar align-self-center d-flex">
                        <div class="d-lg-none flex-sm-fill mt-3 mb-4 col-7 col-sm-auto pr-3">
                            <%--                        <div class="input-group">
                            <input type="text" class="form-control" id="inputMobileSearch" placeholder="Search ...">
                            <div class="input-group-text">
                                <i class="fa fa-fw fa-search"></i>
                            </div>--%>
                        </div>
                    </div>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                
                    <asp:Button ID="Button1" runat="server" Text="Ara" OnClick="Button1_Click" CssClass="btn btn-dark" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <a class="nav-icon d-none d-lg-inline" href="login2.aspx" data-bs-toggle="modal" data-bs-target="#templatemo_search">
                        <i class="fas fa-sign-out-alt"></i>
                    </a>
                    <a class="nav-icon position-relative text-decoration-none" href="Sepet.aspx">
                        <i class="fas fa-shopping-cart"></i>
                        <span class="position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark"></span>
                    </a>
                </div>
            </div>


        </nav>
        <!-- Close Header -->
        <%--<div class="b-example-divider"></div>--%>
        <!-- Start Banner Hero -->
        <div id="template-mo-zay-hero-carousel" class="carousel slide" data-bs-ride="carousel">
            <ol class="carousel-indicators">
                <li data-bs-target="#template-mo-zay-hero-carousel" data-bs-slide-to="0" class="active"></li>
                <li data-bs-target="#template-mo-zay-hero-carousel" data-bs-slide-to="1"></li>
                <li data-bs-target="#template-mo-zay-hero-carousel" data-bs-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <div class="container">
                        <div class="row p-5">
                            <div class="mx-auto col-md-8 col-lg-6 order-lg-last">
                                <a href="UrunDetay.aspx?urun_id=2">
                                <img class="img-fluid"  src="Images/iphone12png.png"  alt="" /></a>
                            </div>
                            <div class="col-lg-6 mb-0 d-flex align-items-center">
                                <div class="text-align-left align-self-center">
                                    <h1 class="h1 text-success"><b>Zamazon</b> Ticaret</h1>
                                    <h3 class="h2">Iphone 12 </h3>
                                    <p>
                                        Neden Apple’dan satın almalısınız?
Yeni iPhone’unuzu iletişim operatörünüze bağlayabilir, aygıtınızın kurulumunu hızla yapabilir ve dilediğiniz zaman bir Uzman ile online sohbet edebilirsiniz.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="container">
                        <div class="row p-5">
                            <div class="mx-auto col-md-8 col-lg-6 order-lg-last">
                                <a href="UrunDetay.aspx?urun_id=12">
                                <img class="img-fluid" src="Images/mi11litepng.png"  alt="" /></a>
                            </div>
                            <div class="col-lg-6 mb-0 d-flex align-items-center">
                                <div class="text-align-left">
                                    <h1 class="h1">Muhteşem Ürünler</h1>
                                    <h3 class="h2">Xiaomi Mi 11 Lite</h3>
                                    <p>
                                       Gücünü 8 çekirdekli Snapdragon 780G işlemciden alan Xiaomi Mi 11 Lite 5G, 6 GB RAM bellek ve 128 GB depolama alanı sunuyor.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="container">
                        <div class="row p-5">
                            <div class="mx-auto col-md-8 col-lg-6 order-lg-last">
                                <a href="UrunDetay.aspx?urun_id=13">
                                <img class="img-fluid" src="./Images/a72png.png" /></a>
                            </div>
                            <div class="col-lg-6 mb-0 d-flex align-items-center">
                                <div class="text-align-left">
                                    <h1 class="h1">Gelecek İçin</h1>
                                    <h3 class="h2">Samsung Galaxy A72 128 GB</h3>
                                    <p>
                                        Acayip iyi ekran ile akıcı görüntüleri yakından keşfedin
Parlak gün ışığında bile 800 nit¹ değerlerine ulaşabilen FHD+ Super AMOLED ekranın canlı renkleriyle acayip iyi bir dünyanın keyfini sürün. Göz koruma kalkanı² mavi ışığı azaltır.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev text-decoration-none w-auto ps-3" href="#template-mo-zay-hero-carousel" role="button" data-bs-slide="prev">
                <i class="fas fa-chevron-left"></i>
            </a>
            <a class="carousel-control-next text-decoration-none w-auto pe-3" href="#template-mo-zay-hero-carousel" role="button" data-bs-slide="next">
                <i class="fas fa-chevron-right"></i>
            </a>
        </div>
        <!-- End Banner Hero -->

        <!-- Start Categories of The Month -->
        <section class="container py-5">
            <div class="row text-center pt-3">
                <div class="col-lg-6 m-auto">
                    <h1 class="h1">Ayın En Çok Satanları</h1>
                    <p>
                        Zamazon'da Ayın En Çok Satanları Sizlerle.
                    </p>
                </div>
            </div>
            
            <div class="row">
                <div class="col-12 col-md-4 p-5 mt-3">
                    
                        <img src="Images/macbookpro.jpg" class="rounded-circle img-fluid border"/>
                    <h5 class="text-center mt-3 mb-3">Apple MacBook Pro Intel Core i5</h5>
                    <p class="text-center">
                        <asp:Button ID="Button2" runat="server" Text="Git" CssClass="btn btn-success" OnClick="Button2_Click" /></p>
                </div>
                <div class="col-12 col-md-4 p-5 mt-3">
                    
                        <img src="Images/a72.jpg" class="rounded-circle img-fluid border"/>
                    <h2 class="h5 text-center mt-3 mb-3">Samsung Galaxy A72 128 GB</h2>
                    <p class="text-center"><asp:Button ID="Button3" runat="server" Text="Git" CssClass="btn btn-success" OnClick="Button3_Click" /></p>
                </div>
                <div class="col-12 col-md-4 p-5 mt-3">
                    
                        <img src="Images/yoga.jpg" class="rounded-circle img-fluid border"/>
                    <h2 class="h5 text-center mt-3 mb-3">Lenovo Yoga Smart TAB 64GB 10.1"</h2>
                    <p class="text-center"><asp:Button ID="Button4" runat="server" Text="Git" CssClass="btn btn-success" OnClick="Button4_Click" /></p>
                </div>
            </div>
        </section>
        <!-- End Categories of The Month -->


         <!-- Start Footer -->
    <footer class="bg-dark" id="tempaltemo_footer" style="height:300px;">
        <div class="container">
            <div class="row">

                <div class="col-md-4 pt-5">
                    <h2 class="h2 text-success border-bottom pb-3 border-light logo">Zamazon Ticaret</h2>
                    <ul class="list-unstyled text-light footer-link-list">
                        <li>
                            <i class="fas fa-map-marker-alt fa-fw"></i>
                            Devlet Atatürk Bulvarı No:153, 06543 Çankaya/Ankara
                        </li>
                        <li>
                            <i class="fa fa-phone fa-fw"></i>
                            <a class="text-decoration-none" href="tel:0-850-00-00">0-850-00-00</a>
                        </li>
                        <li>
                            <i class="fa fa-envelope fa-fw"></i>
                            <a class="text-decoration-none" href="mailto:info@zamazon.com">info@zamazon.com</a>
                        </li>
                    </ul>
                </div>

                <div class="col-md-4 pt-5">
                    <h2 class="h2 text-light border-bottom pb-3 border-light">Ürünler</h2>
                    <ul class="list-unstyled text-light footer-link-list">
                        <li><a class="text-decoration-none" href="Kategori.aspx?urun_katagori=telefon">Telefonlar</a></li>
                        <li><a class="text-decoration-none" href="Kategori.aspx?urun_katagori=laptop">Bilgisayarlar</a></li>
                        <li><a class="text-decoration-none" href="Kategori.aspx?urun_katagori=tablet">Tabletler</a></li>
                    </ul>
                </div>

                <div class="col-md-4 pt-5">

                    
                </div>
            </div>          
        </div>
        <div class="w-100 bg-black py-3">
            <div class="container">
                <div class="row pt-2">
                    <div class="col-12">
                        <p class="text-left text-light">
                            Copyright &copy; 2021 Zamazon E-Ticaret 
                            | Designed by Onur Ulusoy
                        </p>
                    </div>
                </div>
            </div>
        </div>

    </footer>
    <!-- End Footer -->





        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT * FROM [urunler]"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" RepeatDirection="Horizontal">
            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Adobe Arabic" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
            <ItemTemplate>
                <div class="d-flex justify-content-center container mt-5">
                    <div class="auto-style9">
                        <i class="fa fa-apple"></i>
                        <div class="about-product text-center mt-2">
                            <a href="UrunDetay.aspx?urun_id=<%# Eval("urun_id")%>">
                                <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("urun_resim") %>' Width="300" Height="300" />
                            </a>
                            <div>
                                <h4>
                                    <asp:Label ID="Label7" runat="server" CssClass="auto-style5" Text='<%# Eval("urun_adi") %>'></asp:Label></h4>
                            </div>
                        </div>
                        <div class="stats mt-2">
                            <div class="d-flex justify-content-between p-price"><span>Fiyat</span><span><asp:Label ID="Label8" runat="server" CssClass="auto-style6" Text='<%# Eval("urun_fiyat") %>'></asp:Label></span></div>
                        </div>
                        <div class="d-flex justify-content-between total font-weight-bold mt-4">
                            <asp:ImageButton ID="ImageButton1" ImageUrl='~/Images/sepeteekle.jpg' runat="server" CommandArgument='<%# Eval("urun_id") %>' CommandName="SepeteEkleBtn" OnClick="ImageButton1_Click" Height="54px" Width="152px" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>--%>
    </form>
    <script src="assets/js/jquery-1.11.0.min.js"></script>
    <script src="assets/js/jquery-migrate-1.2.1.min.js"></script>
    <script src="assets/js/bootstrap.bundle.min.js"></script>
    <script src="assets/js/templatemo.js"></script>
    <script src="assets/js/custom.js"></script>
</body>
</html>
