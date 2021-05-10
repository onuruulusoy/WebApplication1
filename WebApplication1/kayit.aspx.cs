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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //*********Bağlantı kodu*********
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            //*********Ekleme kodu***********
            string sqlkodu = "insert into kullanici(kullanici_adi,sifre,eposta,adi_soyadi) values (@nick,@parola,@eposta,@adi_soyadi)";
            SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
            sqlcommand.Parameters.AddWithValue("@nick", TextBox1.Text);
            sqlcommand.Parameters.AddWithValue("@eposta", TextBox3.Text);
            sqlcommand.Parameters.AddWithValue("@parola", TextBox4.Text);
            sqlcommand.Parameters.AddWithValue("@adi_soyadi", TextBox2.Text);
            int a = sqlcommand.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Kaydınız Oluşturuldu.');", true);
                Response.Redirect("login2.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Kaydınız Oluşturulmadı.');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login2.aspx");
        }
    }
    
}