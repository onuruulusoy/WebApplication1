using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection db_baglanti;

            db_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA Source=" + Server.MapPath("App_Data/Database1.mdb"));
                db_baglanti.Open();
                OleDbCommand db_komut = new OleDbCommand("insert into kayit,(adi_soyadi, eposta, parola, yas) Values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", db_baglanti);
                db_komut.ExecuteNonQuery();
                db_baglanti.Close();
                Label1.Text = "Kayıt Eklendi";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";

        }
    }
}
