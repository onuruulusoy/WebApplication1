using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class UrunDetay : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            string adi = Request.QueryString["urun_adi"];
            if (adi != null)
            {
                SqlCommand sorgu2 = new SqlCommand("select * from urunler where urun_adi LIKE '%"+adi+"%' ", wcb);

                //sorgu2.Parameters.AddWithValue("@urun_adi", adi);
                SqlDataReader oku2 = sorgu2.ExecuteReader();
                if (oku2.Read())
                {
                    Image2.ImageUrl = oku2["urun_resim"].ToString();
                    Label7.Text = oku2["urun_adi"].ToString();
                    Label8.Text = oku2["urun_fiyat"].ToString();
                    Session["UrunDetayFiyat"] = oku2["urun_fiyat"].ToString();
                    Label1.Text = oku2["aciklama"].ToString();


                }
                oku2.Close();
            }


            string id = Request.QueryString["urun_id"];
            SqlCommand sorgu = new SqlCommand("select * from urunler where urun_id=@urun_id ", wcb);
            sorgu.Parameters.AddWithValue("@urun_id", Convert.ToInt32(id));
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                Image2.ImageUrl = oku["urun_resim"].ToString();
                Label7.Text = oku["urun_adi"].ToString();
                Label8.Text = oku["urun_fiyat"].ToString();
                Session["UrunDetayFiyat"] = oku["urun_fiyat"].ToString();
                Label1.Text = oku["aciklama"].ToString();
                

            }
        }
        protected void btn_sepeteekle_Click(object sender, EventArgs e)
        {
            //*********Bağlantı kodu*********
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand komut = new SqlCommand("Select sum(Fiyat) from SepetDetay where KullaniciId=@KullaniciId", wcb);
            komut.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Session["ToplamFiyat"] = dr[0];
                //Label1.Text = Session["ToplamFiyat"].ToString();
            }
            dr.Close();

            SqlCommand sorgu = new SqlCommand("select * from Sepet2 where KullaniciId=@KullaniciId", wcb);
            sorgu.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader oku = sorgu.ExecuteReader();

            oku.Read();
            //if (!string.IsNullOrEmpty(Session["SepetId"].ToString()))
            if (!string.IsNullOrEmpty(Session["ToplamFiyat"].ToString()))
            {
                string sqlkodu2 = "UPDATE Sepet2 SET Fiyat= @Fiyat, Tarih= @Tarih where KullaniciId= @KullaniciId";
                SqlCommand sqlcommand2 = new SqlCommand(sqlkodu2, wcb);
                sqlcommand2.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["ToplamFiyat"]));
                sqlcommand2.Parameters.AddWithValue("@Tarih", DateTime.Now);
                sqlcommand2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                oku.Close();
                sqlcommand2.ExecuteNonQuery();

                //Label6.Text = Session["ToplamFiyat"].ToString(); ;
                //sqlcommand2.ExecuteNonQuery();
                //update kodu yazılacak
            }

            else
            {
                string sqlkodu = "insert into Sepet2(KullaniciId,Fiyat,Tarih) values (@KullaniciId,@fiyat,@Tarih)";
                SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
                sqlcommand.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                sqlcommand.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["urun_fiyat"]));
                sqlcommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                oku.Close();
                sqlcommand.ExecuteNonQuery();
                //Label6.Text = Session["ToplamFiyat"].ToString(); ;

            }
            string id = Request.QueryString["urun_id"];
            string fiyat = Request.QueryString["urun_fiyat"];
            string komut1 = "insert into SepetDetay(SepetId,UrunId,KullaniciId,Fiyat,Tarih) values (@SepetId,@UrunId,@KullaniciId,@Fiyat,@Tarih)";
            SqlCommand komutco = new SqlCommand(komut1, wcb);
            komutco.Parameters.AddWithValue("@SepetId", Session["SepetDetayId"]);
            komutco.Parameters.AddWithValue("@UrunId", Convert.ToInt32(id));
            komutco.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            komutco.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(fiyat));
            komutco.Parameters.AddWithValue("@Tarih", DateTime.Now);
            //komutco.ExecuteScalar();
            int a = komutco.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Eklendi');", true);
            }
            else
            {
                Response.Write("<script> alert('eklenmedi')</script>");
            }

            wcb.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //*********Bağlantı kodu*********
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand komut = new SqlCommand("Select sum(Fiyat) from SepetDetay where KullaniciId=@KullaniciId", wcb);
            komut.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Session["ToplamFiyat"] = dr[0];
                //Label1.Text = Session["ToplamFiyat"].ToString();
            }
            dr.Close();

            SqlCommand sorgu = new SqlCommand("select * from Sepet2 where KullaniciId=@KullaniciId", wcb);
            sorgu.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader oku = sorgu.ExecuteReader();

            oku.Read();
            //if (!string.IsNullOrEmpty(Session["SepetId"].ToString()))
            if (!string.IsNullOrEmpty(Session["ToplamFiyat"].ToString()))
            {
                string sqlkodu2 = "UPDATE Sepet2 SET Fiyat= @Fiyat, Tarih= @Tarih where KullaniciId= @KullaniciId";
                SqlCommand sqlcommand2 = new SqlCommand(sqlkodu2, wcb);
                sqlcommand2.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["ToplamFiyat"]));
                sqlcommand2.Parameters.AddWithValue("@Tarih", DateTime.Now);
                sqlcommand2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                oku.Close();
                sqlcommand2.ExecuteNonQuery();

                //Label6.Text = Session["ToplamFiyat"].ToString(); ;
                //sqlcommand2.ExecuteNonQuery();
                //update kodu yazılacak
            }

            else
            {
                string sqlkodu = "insert into Sepet2(KullaniciId,Fiyat,Tarih) values (@KullaniciId,@fiyat,@Tarih)";
                SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
                sqlcommand.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                sqlcommand.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["urun_fiyat"]));
                sqlcommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                oku.Close();
                sqlcommand.ExecuteNonQuery();
                //Label6.Text = Session["ToplamFiyat"].ToString(); ;

            }



            string id = Request.QueryString["urun_id"];
            string komut1 = "insert into SepetDetay(SepetId,UrunId,urun_adi,KullaniciId,Fiyat,Tarih) values (@SepetId,@UrunId,@urun_adi,@KullaniciId,@Fiyat,@Tarih)";
            SqlCommand komutco = new SqlCommand(komut1, wcb);
            komutco.Parameters.AddWithValue("@SepetId", Session["SepetDetayId"]);
            komutco.Parameters.AddWithValue("@UrunId", Convert.ToInt32(id));
            komutco.Parameters.AddWithValue("@urun_adi", Session["urun_adi"]);
            komutco.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            komutco.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(Session["UrunDetayFiyat"]));
            komutco.Parameters.AddWithValue("@Tarih", DateTime.Now);
            //komutco.ExecuteScalar();
            int a = komutco.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Eklendi');", true);

            }
            else
            {
                Response.Write("<script> alert('eklenmedi')</script>");
            }







            wcb.Close();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //*********Bağlantı kodu*********
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand komut = new SqlCommand("Select sum(Fiyat) from SepetDetay where KullaniciId=@KullaniciId", wcb);
            komut.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Session["ToplamFiyat"] = dr[0];
                //Label1.Text = Session["ToplamFiyat"].ToString();
            }
            dr.Close();

            SqlCommand sorgu = new SqlCommand("select * from Sepet2 where KullaniciId=@KullaniciId", wcb);
            sorgu.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader oku = sorgu.ExecuteReader();

            oku.Read();
            //if (!string.IsNullOrEmpty(Session["SepetId"].ToString()))
            if (!string.IsNullOrEmpty(Session["ToplamFiyat"].ToString()))
            {
                string sqlkodu2 = "UPDATE Sepet2 SET Fiyat= @Fiyat, Tarih= @Tarih where KullaniciId= @KullaniciId";
                SqlCommand sqlcommand2 = new SqlCommand(sqlkodu2, wcb);
                sqlcommand2.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["ToplamFiyat"]));
                sqlcommand2.Parameters.AddWithValue("@Tarih", DateTime.Now);
                sqlcommand2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                oku.Close();
                sqlcommand2.ExecuteNonQuery();

                //Label6.Text = Session["ToplamFiyat"].ToString(); ;
                //sqlcommand2.ExecuteNonQuery();
                //update kodu yazılacak
            }

            else
            {
                string sqlkodu = "insert into Sepet2(KullaniciId,Fiyat,Tarih) values (@KullaniciId,@fiyat,@Tarih)";
                SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
                sqlcommand.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                sqlcommand.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["urun_fiyat"]));
                sqlcommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                oku.Close();
                sqlcommand.ExecuteNonQuery();
                //Label6.Text = Session["ToplamFiyat"].ToString(); ;

            }



            string id = Request.QueryString["urun_id"];
            string komut1 = "insert into SepetDetay(SepetId,UrunId,KullaniciId,Fiyat,Tarih) values (@SepetId,@UrunId,@KullaniciId,@Fiyat,@Tarih)";
            SqlCommand komutco = new SqlCommand(komut1, wcb);
            komutco.Parameters.AddWithValue("@SepetId", Session["SepetDetayId"]);
            komutco.Parameters.AddWithValue("@UrunId", Convert.ToInt32(id));
            komutco.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            komutco.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(Session["UrunDetayFiyat"]));
            komutco.Parameters.AddWithValue("@Tarih", DateTime.Now);
            //komutco.ExecuteScalar();
            int a = komutco.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Eklendi');", true);
            }
            else
            {
                Response.Write("<script> alert('eklenmedi')</script>");
            }
            wcb.Close();
        }
    }
    

}