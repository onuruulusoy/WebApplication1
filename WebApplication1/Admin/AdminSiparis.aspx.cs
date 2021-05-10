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
    public partial class AdminSiparis : System.Web.UI.Page
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
                SqlCommand sorgu = new SqlCommand("select KullaniciAdiSoyadi from Odeme", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["KullaniciAdiSoyadi"].ToString());
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
            SqlCommand sorgu = new SqlCommand("select * from Odeme where KullaniciAdiSoyadi=@KullaniciAdiSoyadi", wcb);
            sorgu.Parameters.AddWithValue("@KullaniciAdiSoyadi", ListBox1.SelectedItem.Text.ToString());
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                
                TextBox1.Text = ListBox1.SelectedItem.Text;
                TextBox2.Text = oku["Tutar"].ToString();
                TextBox3.Text = oku["Tarih"].ToString();
                TextBox4.Text = oku["durumu"].ToString();
                TextBox9.Text = oku["SepetId"].ToString();
                TextBox5.Text = oku["KargoDurumu"].ToString();
            }
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            string sqlkodu2 = "UPDATE Odeme SET KargoDurumu= @KargoDurumu";
            SqlCommand sqlcommand2 = new SqlCommand(sqlkodu2, wcb);
            sqlcommand2.Parameters.AddWithValue("@KargoDurumu", TextBox5.Text);

            int a = sqlcommand2.ExecuteNonQuery();

            if (a > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Sipariş Güncellendi');", true);


            }
        }
    }
}