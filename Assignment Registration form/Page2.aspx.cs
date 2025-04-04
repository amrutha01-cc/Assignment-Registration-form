using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_Registration_form
{
    public partial class Page2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-S32BU2F\SQLEXPRESS;database=DataB;Integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "insert into tab1 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i==1)
            {
                Label1.Text = "successfully inserted";
            }
        }
    }
}