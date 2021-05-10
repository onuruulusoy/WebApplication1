using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OleDbConnection db_baglanti;
        void getir()
        {
            db_baglanti.Open();
            OleDbCommand getiir = new OleDbCommand("select * from kayit", db_baglanti);
            OleDbDataReader veri = getiir.ExecuteReader();
            GridView1.DataSource = veri;
            GridView1.DataBind();
            db_baglanti.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            

            db_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA Source=" + Server.MapPath("App_Data/Database1.mdb"));
            getir();
                db_baglanti.Open();
                Response.Write("Bağlantı gerçekleştirildi..");
                db_baglanti.Close();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            db_baglanti.Open();
            OleDbCommand db_komut = new OleDbCommand("Insert INTO kayit ( adi_soyadi, eposta, parola, yas, cinsiyet ) Values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + RadioButtonList1.SelectedItem.Text + "')", db_baglanti);
            db_komut.ExecuteNonQuery();
            db_baglanti.Close();
            getir();
            Label1.Text = "Kayıt Eklendi";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }


    }
}