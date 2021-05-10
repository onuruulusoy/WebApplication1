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
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            LoadUrun();
            SepetDetayListele();
            SepetListele();
            List();
            if (IsPostBack)
            {
                List();
                LoadUrun();
                SepetDetayListele();
                    SepetListele();
            }


        }

        private void LoadUrun()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sqlQuery = "select * from urunler";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Session["urun_id"] = rdr["urun_id"].ToString();
                        Session["urun_adi"] = rdr["urun_adi"].ToString();
                        Session["urun_fiyat"] = rdr["urun_fiyat"].ToString();
                        Session["urun_resim"] = rdr["urun_resim"].ToString();
                    }
                }
            }
        }
        private void List()
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("select * from urunler", wcb);
            SqlDataReader oku = sorgu.ExecuteReader();
            string id = Request.QueryString["urun_id"];
            string fiyat = Request.QueryString["urun_fiyat"];

        }
        private void SepetDetayListele()
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("select * from SepetDetay where KullaniciId=@KullaniciId",wcb);
            sorgu.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);        
            SqlDataReader oku = sorgu.ExecuteReader();
            if(oku.Read())
            {

                Session["SepetDetayId"] = oku["Id"].ToString();
                Session["SepetDetayFiyat"] = oku["Fiyat"].ToString();
                Session["UrunAdiDetay"] = oku["urun_adi"].ToString();

            }
            oku.Close();
            


        }
        private void SepetListele()
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("select * from Sepet2 where KullaniciId=@KullaniciId", wcb);
            sorgu.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader oku = sorgu.ExecuteReader();
            
            if (oku.Read())
            {
                
                Session["SepetId"] = oku["Id"].ToString();
                Session["SepetFiyat"] = oku["Fiyat"].ToString();
            }
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
                //Label6ext = Session["ToplamFiyat"].ToString();

            }
            //string id = Request.QueryString["urun_id"];

            ImageButton btn = (ImageButton)sender;
            string id = btn.CommandArgument.ToString();
            Session["id"] = id;
            SqlCommand sorgu2 = new SqlCommand("select * from urunler where urun_id=@urun_id ", wcb);
            sorgu2.Parameters.AddWithValue("@urun_id", Convert.ToInt32(id));
            SqlDataReader oku2 = sorgu2.ExecuteReader();
            if (oku2.Read())
            {
                Session["SptUrunAdi"]= oku2["urun_adi"].ToString();
                Session["SptFiyat"] = oku2["urun_fiyat"].ToString();
                Session["SptUrunResim"] = oku2["urun_resim"].ToString();

            }
            oku2.Close();



            if (Session["SepetId"] == null)
            {
                string sqlkodu = "insert into Sepet2(KullaniciId,Fiyat,Tarih) values (@KullaniciId,@fiyat,@Tarih)";
                SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
                sqlcommand.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                sqlcommand.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(Session["SptFiyat"]));
                sqlcommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                oku.Close();
                sqlcommand.ExecuteNonQuery();
                SepetListele();


            }


            string komut1 = "insert into SepetDetay(SepetId,UrunId,urun_adi,KullaniciId,Fiyat,Tarih,urun_resim) values (@SepetId,@UrunId,@urun_adi,@KullaniciId,@Fiyat,@Tarih,@urun_resim)";
            SqlCommand komutco = new SqlCommand(komut1, wcb);
            komutco.Parameters.AddWithValue("@SepetId", Session["SepetId"]);
            komutco.Parameters.AddWithValue("@UrunId", Session["id"]);
            komutco.Parameters.AddWithValue("@urun_adi", Session["SptUrunAdi"]);
            komutco.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            komutco.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(Session["SptFiyat"]));
            komutco.Parameters.AddWithValue("@Tarih", DateTime.Now);
            komutco.Parameters.AddWithValue("@urun_resim", Session["SptUrunResim"]);
            int a = komutco.ExecuteNonQuery();
            if (a > 0)
            {
                SqlCommand komut2 = new SqlCommand("Select sum(Fiyat) from SepetDetay where KullaniciId=@KullaniciId", wcb);
                komut2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    Session["ToplamFiyat"] = dr2[0];
                    //Label6ext = Session["ToplamFiyat"].ToString();

                }

                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Eklendi');", true);
            }
            else
            {
                Response.Write("<script> alert('eklenmedi')</script>");
            }

            wcb.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != null)
            {
                Response.Redirect("UrunDetay.aspx?urun_adi=" + TextBox1.Text + "");
            }
        }
    }
    
}