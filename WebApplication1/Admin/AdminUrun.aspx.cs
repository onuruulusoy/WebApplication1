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
    public partial class WebForm7 : System.Web.UI.Page
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
                SqlCommand sorgu = new SqlCommand("select urun_adi from urunler", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["urun_adi"].ToString());
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TextBox1.Text = ListBox1.SelectedItem.Text;
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            SqlCommand sorgu = new SqlCommand("select * from urunler where urun_adi=@urun_adi", wcb);
            sorgu.Parameters.AddWithValue("@urun_adi", ListBox1.SelectedItem.Text);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                //string a = oku["urun_fiyat"].ToString();
                TextBox1.Text = ListBox1.SelectedItem.Text;
                TextBox2.Text = oku["urun_fiyat"].ToString();
                TextBox4.Text = oku["urun_katagori"].ToString();
                TextBox3.Text = oku["aciklama"].ToString();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection wcb = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (wcb.State == ConnectionState.Closed)
            {
                wcb.Open();
            }
            if (FileUpload1.HasFile)
            {
                string dosyaturu = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (dosyaturu.ToLower() != ".jpg" && dosyaturu.ToLower() != ".png")
                {
                    Label1.Text = "dosya türü yanlış(jpg,png)";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int dosyasize = FileUpload1.PostedFile.ContentLength;
                    if (dosyasize > 2097152)
                    {
                        Label1.Text = "dosya büyüklüğü 2MB'den büyük olamaz.";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Images/" + FileUpload1.FileName));
                        Label1.Text = "File Uploaded";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                Label1.Text = "dosya seçin";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            string sqlkodu2 = "UPDATE urunler SET urun_adi= @urun_adi, urun_fiyat= @urun_fiyat,  urun_katagori=@urun_katagori, aciklama=@aciklama, urun_resim=@urun_resim where urun_adi=@urun_adi";
            SqlCommand sqlcommand2 = new SqlCommand(sqlkodu2, wcb);
            sqlcommand2.Parameters.AddWithValue("@urun_adi", TextBox1.Text);
            sqlcommand2.Parameters.AddWithValue("@urun_fiyat", TextBox2.Text);
            sqlcommand2.Parameters.AddWithValue("@urun_katagori", TextBox4.Text);
            sqlcommand2.Parameters.AddWithValue("@aciklama", TextBox3.Text);
            sqlcommand2.Parameters.AddWithValue("@urun_resim", "~/Images/" + FileUpload1.FileName);
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
            if (FileUpload2.HasFile)
            {
                string dosyaturu = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (dosyaturu.ToLower() != ".jpg" && dosyaturu.ToLower() != ".png" && dosyaturu.ToLower() != "..jpeg")
                {
                    Label2.Text = "dosya türü yanlış(jpg,png)";
                    Label2.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int dosyasize = FileUpload1.PostedFile.ContentLength;
                    if (dosyasize > 2097152)
                    {
                        Label2.Text = "dosya büyüklüğü 2MB'den büyük olamaz.";
                        Label2.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload2.SaveAs(Server.MapPath("~/Images/" + FileUpload1.FileName));
                        Label2.Text = "File Uploaded";
                        Label2.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                Label2.Text = "dosya seçin";
                Label2.ForeColor = System.Drawing.Color.Red;
            }


            //*********Ekleme kodu***********
            string sqlkodu = "insert into urunler(urun_adi, urun_fiyat ,urun_katagori ,aciklama, urun_resim) values (@urun_adi, @urun_fiyat ,@urun_katagori ,@aciklama, @urun_resim)";
            SqlCommand sqlcommand = new SqlCommand(sqlkodu, wcb);
            sqlcommand.Parameters.AddWithValue("@urun_adi", TextBox5.Text);
            sqlcommand.Parameters.AddWithValue("@urun_fiyat", TextBox6.Text); 
            sqlcommand.Parameters.AddWithValue("@urun_katagori", TextBox8.Text);
            sqlcommand.Parameters.AddWithValue("@aciklama", TextBox7.Text);
            sqlcommand.Parameters.AddWithValue("@urun_resim", "~/Images/" + FileUpload2.FileName.ToString());

            int a = sqlcommand.ExecuteNonQuery();
            if (a > 0)
            {
                ListBox1.Items.Clear();
                SqlCommand sorgu = new SqlCommand("select urun_adi from urunler", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["urun_adi"].ToString());
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
            SqlCommand komut = new SqlCommand("delete from urunler where urun_adi=@urun_adi", wcb);
            komut.Parameters.AddWithValue("@urun_adi", TextBox1.Text);
            int a = komut.ExecuteNonQuery();
            if (a > 0)
            {

                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Silindi');", true);
                ListBox1.Items.Clear();
                SqlCommand sorgu = new SqlCommand("select urun_adi from urunler", wcb);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {

                    ListBox1.Items.Add(oku["urun_adi"].ToString());
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Ürün Silinmedi');", true);
            }
        }
    }
}