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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-S32BU2F\SQLEXPRESS;database=DataB;Integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(ID) from tab2 where username='" + TextBox1.Text + "'and passwrod='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if(cid=="1")
            {
                //Label3.Text = "success";
                Response.Redirect("Viewuserprofile.aspx");
            }
            else
            {
                Label3.Text = "Failed";
            }
        }
    }
}