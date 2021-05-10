using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class hiddenfield : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
        }
        private void LoadEmployee()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sqlQuery = "select employeeid, name,gender, deptname from tblEmplpyee where employeeid=1";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        TextBox1.Text = rdr["name"].ToString();
                        TextBox2.Text = rdr["gender"].ToString();
                        TextBox3.Text = rdr["deptname"].ToString();
                        HiddenField1.Value = rdr["employeeid"].ToString();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sqlQuery = "update tblEmplpyee set name=@name, gender=@gender, deptname=@dptname where employeeid=@employeeid";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@gender", TextBox2.Text);
                cmd.Parameters.AddWithValue("@dptname", TextBox3.Text);
                cmd.Parameters.AddWithValue("@employeeid", HiddenField1.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}