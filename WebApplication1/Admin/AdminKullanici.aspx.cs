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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
                if (wcb.State == ConnectionState.Closed)
                {
                    wcb.Open();
                }
                SqlCommand sorgu = new SqlCommand("select kullanici_adi from kullanici", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["kullanici_adi"].ToString());
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("select * from kullanici where kullanici_adi=@kullanici_adi", wcb);
            sorgu.Parameters.AddWithValue("@kullanici_adi", ListBox1.SelectedItem.Text.ToString());
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                //string a = oku["urun_fiyat"].ToString();
                TextBox1.Text = ListBox1.SelectedItem.Text;
                TextBox2.Text = oku["adi_soyadi"].ToString();
                TextBox3.Text = oku["eposta"].ToString();
                TextBox4.Text = oku["sifre"].ToString();
                TextBox9.Text = oku["admin"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            string sqlkodu2 = "UPDATE kullanici SET kullanici_adi= @kullanici_adi, adi_soyadi= @adi_soyadi,  eposta=@eposta, sifre=@sifre, admin=@admin where kullanici_adi=@kullanici_adi";
            SqlCommand sqlcommand2 = new SqlCommand(sqlkodu2, wcb);
            sqlcommand2.Parameters.AddWithValue("@kullanici_adi", TextBox1.Text);
            sqlcommand2.Parameters.AddWithValue("@adi_soyadi", TextBox2.Text);
            sqlcommand2.Parameters.AddWithValue("@sifre", TextBox4.Text);
            sqlcommand2.Parameters.AddWithValue("@eposta", TextBox3.Text);
            sqlcommand2.Parameters.AddWithValue("@admin", TextBox9.Text);

            int a = sqlcommand2.ExecuteNonQuery();

            if (a > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Güncellendi');", true);


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            string sqlkodu = "insert into kullanici(kullanici_adi, adi_soyadi ,eposta ,sifre, admin) values (@kullanici_adi, @adi_soyadi ,@eposta ,@sifre, @admin)";
            SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
            sqlcommand.Parameters.AddWithValue("@kullanici_adi", TextBox5.Text);
            sqlcommand.Parameters.AddWithValue("@adi_soyadi", TextBox6.Text);
            sqlcommand.Parameters.AddWithValue("@eposta", TextBox7.Text);
            sqlcommand.Parameters.AddWithValue("@sifre", TextBox8.Text);
            sqlcommand.Parameters.AddWithValue("@admin", TextBox10.Text);


            int a = sqlcommand.ExecuteNonQuery();
            if (a > 0)
            {
                ListBox1.Items.Clear();
                SqlCommand sorgu = new SqlCommand("select kullanici_adi from kullanici", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["kullanici_adi"].ToString());
                }
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Eklendi');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Eklenmedi');", true);
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand komut = new SqlCommand("delete from kullanici where kullanici_adi=@kullanici_adi", wcb);
            komut.Parameters.AddWithValue("@kullanici_adi", TextBox1.Text);            
            int a = komut.ExecuteNonQuery();
            if (a > 0)
            {

                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Kullanıcı Silindi');", true);
                ListBox1.Items.Clear();
                SqlCommand sorgu = new SqlCommand("select kullanici_adi from kullanici", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["kullanici_adi"].ToString());
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Kullanıcı Silinmedi');", true);
            }
        }
    }
}