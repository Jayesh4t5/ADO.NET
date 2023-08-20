using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace WindowsFormsApp2.Models
{
    public class ProductCrud
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public ProductCrud()
        {
            string connstr = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
            con = new SqlConnection(connstr);
        }

        //public int AddProduct(Product prod)
        //{
        //    string qry = "insert into Product values(@name,@price,@cid)";
        //}

        public List<Category1> GetCategories()
        {
            List<Category1> list = new List<Category1>();

            string qry = "select * from Category";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr=cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    Category1 c = new Category1();
                    c.Cid = Convert.ToInt32(dr["cid"]);
                    c.Cname = dr["cname"].ToString();
                    list.Add(c);
                }
            }
            con.Close();
            return list;

        }
    }
}
