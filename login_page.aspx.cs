using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class login_page : System.Web.UI.Page
    {
        ConnectionClass obj3 = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(reg_id) from log_tab where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
            string cid = obj3.fn_scalar(str);
            int cid1 = Convert.ToInt32(cid);

            if (cid1 == 1)
            {
                string str1 = "select reg_id from log_tab where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string regid = obj3.fn_scalar(str);
                Session["userid"] = regid;


                string str2 = "select log_type from log_tab where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'";
                string logtype = obj3.fn_scalar(str2);

                if (logtype == "admin")
                {
                    Label3.Text = "admin";
                    Response.Redirect("Main_page.aspx");
                }
                else if (logtype == "user")
                {
                    Label3.Text = "user";
                }
            }
        }
    }
}