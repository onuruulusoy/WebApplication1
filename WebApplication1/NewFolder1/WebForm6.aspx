<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .card {
            width: 444px
        }

        body {
            background: #eee
        }
    </style>
    <link href="Kaynak/bootstrap.min.css" rel="stylesheet" />
    <script src="Kaynak/bootstrap.bundle.min.js"></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
</head>
<body>
    <form id="form1" runat="server">
       <div class="d-flex justify-content-center container mt-5">
    <div class="card p-3 bg-white"><i class="fa fa-apple"></i>
        <div class="about-product text-center mt-2"><asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("urun_resim") %>' Width="300" />
            <div>
                <h4><asp:Label ID="Label7" runat="server" CssClass="auto-style5" Text='<%# Eval("urun_adi") %>'></asp:Label></h4>
            </div>
        </div>
        <div class="stats mt-2">
            <div class="d-flex justify-content-between p-price"><span>Fiyat</span><span><asp:Label ID="Label8" runat="server" CssClass="auto-style6" Text='<%# Eval("urun_fiyat") %>'></asp:Label></span></div>
        </div>
        <div class="d-flex justify-content-between total font-weight-bold mt-4"><span>Total</span><span>$7,197.00</span></div>
    </div>
</div>

        <asp:ListView runat="server">
            <ItemTemplate>
                <div class="d-flex justify-content-center container mt-5">
                    <div class="card p-3 bg-white">
                        <i class="fa fa-apple"></i>
                        <div class="about-product text-center mt-2">
                            <img src="https://i.imgur.com/3VTaSeb.png" width="300">
                            <div>
                                <h4>Believing is seeing</h4>
                                <h6 class="mt-0 text-black-50">Apple pro display XDR</h6>
                            </div>
                        </div>
                        <div class="stats mt-2">
                            <div class="d-flex justify-content-between p-price"><span>Pro Display XDR</span><span>$5,999</span></div>
                            <div class="d-flex justify-content-between p-price"><span>Pro stand</span><span>$999</span></div>
                            <div class="d-flex justify-content-between p-price"><span>Vesa Mount Adapter</span><span>$199</span></div>
                        </div>
                        <div class="d-flex justify-content-between total font-weight-bold mt-4"><span>Total</span><span>$7,197.00</span></div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>



    </form>
</body>
</html>
