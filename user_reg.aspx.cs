using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class user_reg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(reg_id) from log_tab";

            string regid = obj.fn_scalar(sel);
            int reg_id = 0;

            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(reg_id);
                reg_id = newregid + 1;
            }

            string str = "insert into user_reg_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj.fn_nonquery(str);
            if (i != 0)
            {


                string stri = "insert into log_tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
                int j = obj.fn_nonquery(stri);


                if (j != 0)
                {
                    Label1.Text = "inserted";
                }
            }
        }
    }
}