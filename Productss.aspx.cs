using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class Productss : System.Web.UI.Page        //orginal
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = "select * from product_tab where cat_id=" + Session["catid"] + "";
                DataSet ds = obj.fn_dataadapter(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();


            }
        }

        //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        //{

        //}

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int pdid = Convert.ToInt32(e.CommandArgument);
            Session["pdid"] = pdid;
            Response.Redirect("Product_details.aspx");
        }
    }
}