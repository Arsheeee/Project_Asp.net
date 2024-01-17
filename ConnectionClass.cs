using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Project1
{
    public class ConnectionClass
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-L7ALHL3\SQLEXPRESS;database=Project1;Integrated security=true");
        }

        public int fn_nonquery(string sqlquery) // insert,delete,update
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public string fn_scalar(string sqluery) //scalar
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqluery, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
        public SqlDataReader fn_reader(string sqluery)//display
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqluery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        public DataSet fn_dataadapter(string sqluery) //select
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqluery, con);
            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds;

        }
    }
}