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
    public partial class Odeme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label5.Text = Session["ToplamFiyat"].ToString(); 
            for(int i=DateTime.Now.Year;i<= DateTime.Now.Year+15;i++)
            {
                DropDownList2.Items.Add(i.ToString());
            }
            Label7.Text = Session["ToplamFiyat"].ToString();

        }

        protected void btn_odeme_Click(object sender, EventArgs e)
        {

        }

        protected void btn_geridon_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //*********Bağlantı kodu*********
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            //*********Ekleme kodu***********
            string sqlkodu = "insert into Odeme(KullaniciId,SepetId,KartNo,KartCvv,Tutar,Tarih,Durumu,kartAdSoyad) values (@KullaniciId,@SepetId,@KartNo,@KartCvv,@Tutar,@Tarih,@Durumu,@kartAdSoyad)";
            SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
            sqlcommand.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
            sqlcommand.Parameters.AddWithValue("@SepetId", Session["SepetId"]);
            sqlcommand.Parameters.AddWithValue("@kartAdSoyad", TextBox1.Text);
            sqlcommand.Parameters.AddWithValue("@KartNo", TextBox2.Text);
            sqlcommand.Parameters.AddWithValue("@KartCvv", TextBox3.Text);
            sqlcommand.Parameters.AddWithValue("@Tutar", Session["ToplamFiyat"]);
            sqlcommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
            sqlcommand.Parameters.AddWithValue("@Durumu", "Ödendi");
            int a = sqlcommand.ExecuteNonQuery();
            if (a > 0)
            {
                
               
                
                SqlCommand komut = new SqlCommand("delete from Sepet2 where KullaniciId=@KullaniciId", wcb);
                komut.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("delete from SepetDetay where KullaniciId=@KullaniciId", wcb);
                komut2.Parameters.AddWithValue("@KullaniciId", Session["kullanici_id"]);
                komut2.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ödemeniz Tamamlandı.');", true);
                Response.Redirect("AnaSayfa.aspx");

            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ödemeniz Tamamlanmadı.');", true);
                Response.Redirect("Sepet.aspx");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }
    }
}