using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Project1
{
    public partial class Product_details : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select prod_name,prod_image,prod_price,prod_description,prod_stock from product_tab where prod_id=" + Session["pdid"] + "";
            SqlDataReader dr = obj.fn_reader(s);
            while (dr.Read())
            {
                Image1.ImageUrl = dr["prod_image"].ToString();
                Label1.Text = dr["prod_name"].ToString();
                Label2.Text = dr["prod_price"].ToString();
                Label3.Text = dr["prod_description"].ToString();
                TextBox1.Text = dr["prod_stock"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            string str = "select max(cart_id) from cart_tab";
            string i = obj.fn_scalar(str);
            int cartid;
            if (i == "")
            {
                cartid = 1;
            }
            else
            {
                int newcartid = Convert.ToInt32(i);
                cartid = newcartid + 1;

            }
            int quantity = Convert.ToInt32(TextBox1.Text);
            Session["qua"] = quantity;
            int price = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(Label2.Text);
            int userid = Convert.ToInt32(Session["userid"]);
            int pid = Convert.ToInt32(Session["pid"]);



            string ph = Image1.ImageUrl;

            string ss = "insert into cart_tab values(" + cartid + "," + userid + "," + pid + "," + TextBox1.Text + ",'" + price + "','available')";
            int f = obj.fn_nonquery(ss);
            if (f == 1)
            {
                Label4.Text = "hurraayy!! Added to cart";
            }

        }
    }
}