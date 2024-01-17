using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class Products_insert : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string str = "insert into product_tab values(" +TextBox6.Text+ ",'" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.fn_nonquery(str);

            if(i==1)
            {
                Label1.Text = "inserted";
            }
        }
    }
}