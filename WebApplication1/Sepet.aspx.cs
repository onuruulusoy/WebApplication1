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
    public partial class Sepet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            Listele();
            }
        }
        private void Listele()
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("select * from SepetDetay where KullaniciId=@KullaniciId", wcb);
            sorgu.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {

                Session["SepetDetayId"] = oku["Id"].ToString();
                Session["SepetDetayFiyat"] = oku["Fiyat"].ToString();
                Session["UrunAdiDetay"] = oku["urun_adi"].ToString();

            }
            oku.Close();

            if (Session["SepetDetayId"] != null)
            {

                SqlCommand komut2 = new SqlCommand("Select * from SepetDetay where KullaniciId=@KullaniciId", wcb);
                komut2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                SqlDataReader dr2 = komut2.ExecuteReader();
                dr2.Close();


                SqlCommand komut = new SqlCommand("Select sum(Fiyat) from SepetDetay where KullaniciId=@KullaniciId", wcb);
                komut.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Session["ToplamFiyat"] = dr[0];

                }
                dr.Close();

                SqlCommand komut3 = new SqlCommand("Select * from Sepet2 where KullaniciId=@KullaniciId", wcb);
                komut3.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                SqlDataReader dr3 = komut2.ExecuteReader();
                while (dr3.Read())
                {
                    Label3.Text = Session["ToplamFiyat"].ToString();
                }
                dr3.Close();

            }
            else
            {
                Button2.Visible = false;
                Label3.Text = "Sepetiniz Boş";
            }
           

        }

        protected void btn_odeme_Click(object sender, EventArgs e)
        {
            Response.Redirect("Odeme.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }


            Button btn = (Button)sender;
            string id = btn.CommandArgument.ToString();

            SqlCommand sorgu2 = new SqlCommand("select * from SepetDetay where UrunId=@UrunId ", wcb);
            sorgu2.Parameters.AddWithValue("@UrunId", Convert.ToInt32(id));
            //SqlDataReader oku4 = sorgu2.ExecuteReader();

            SqlCommand komut = new SqlCommand("delete from SepetDetay where UrunId=@UrunId", wcb);
            komut.Parameters.AddWithValue("@UrunId", Convert.ToInt32(id));
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("delete from Sepet2 where KullaniciId=@KullaniciId", wcb);
            komut2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            komut2.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("Select * from Sepet2", wcb);

            
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Lütfen Alışverişe Devam Edin');", true);
                Response.Redirect("Sepet.aspx");
            
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Odeme.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != null)
            {
                Response.Redirect("UrunDetay.aspx?urun_adi=" + TextBox1.Text + "");
            }
        }
    }
}