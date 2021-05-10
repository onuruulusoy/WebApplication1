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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("Select* from kullanici where kullanici_adi=@user and sifre=@password", wcb);
            sorgu.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox1.Text;
            sorgu.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text;
            SqlDataReader oku = sorgu.ExecuteReader();
            //Session["kullanici_id"] = oku["kullanici_id"].ToString();
            if (oku.Read())
            {
                Session["kullanici_id"] = oku["kullanici_id"].ToString();
                //Session["kullanici_adi"] = oku["kullanici_adi"].ToString();
                Response.Redirect("AnaSayfa.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Hatalı Giriş');", true);
            }
            oku.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("kayit.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminGirisi.aspx");
        }
    }
}
