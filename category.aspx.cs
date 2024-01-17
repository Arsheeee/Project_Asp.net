using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    public partial class category : System.Web.UI.Page
    {
        ConnectionClass obj1 = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string st = "select * from category_tab";
                DataSet ds = obj1.fn_dataadapter(st);

                DataList1.DataSource = ds;
                DataList1.DataBind();

                //Cat_image, cat_name, cat_description
            }
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {

            int countid = Convert.ToInt32(e.CommandArgument);
     
            Session["catid"] = countid;
            Response.Redirect("Productss.aspx");
        }



        
    }
}