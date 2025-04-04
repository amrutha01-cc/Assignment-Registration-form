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
    public partial class Regform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-S32BU2F\SQLEXPRESS;database=DataB;Integrated security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label13.Text = TextBox1.Text;
            Label14.Text = TextBox2.Text;
            Label15.Text = TextBox10.Text;
            Label16.Text = TextBox4.Text;
            Label17.Text = TextBox5.Text;
            Label18.Text = RadioButtonList1.SelectedItem.Text;
            Label19.Text = DropDownList1.SelectedItem.Text;
            string items = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    items = items + CheckBoxList1.Items[i].Text + ",";
                }
            }
            Label20.Text = items;
            string pa = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));
            Image1.ImageUrl = pa;
            Label22.Text = TextBox7.Text;
            Label23.Text = TextBox8.Text;
            Label1.Text = "Name";
            Label2.Text = "Age";
            Label3.Text = "Address";
            Label4.Text = "Phone";
            Label5.Text = "Email";
            Label6.Text = "Gender";
            Label7.Text = "State";
            Label8.Text = "Qualification";
            Label9.Text = "Photo";
            Label10.Text = "Username";
            Label11.Text = "Password";
            Label12.Text = "Password confirmed";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string pa = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));

            string items = " ";
            for(int i=0;i<CheckBoxList1.Items.Count;i++)
            {
                if(CheckBoxList1.Items[i].Selected)
                {
                    items = items + CheckBoxList1.Items[i].Text + ",";
                }
            }
            string str = "insert into tab2 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox10.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','" + items + "','" + pa + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
            SqlCommand cm = new SqlCommand(str, con);
            con.Open();
            int i1 = cm.ExecuteNonQuery();
            con.Close();
            if(i1==1)
            {
                Label24.Text = "inserted";
            }
        }
    }
}