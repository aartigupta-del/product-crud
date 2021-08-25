using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int editid = Convert.ToInt32(Request.QueryString["id"]);
            Connection con = new Connection();
            string sql = " select id, name, price, descp,category,stock from addproduct where id = '"+ editid + "' ";

            using (SqlConnection conn = new SqlConnection(con.connect()))
            {
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = conn;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            foreach(DataRow dr in dt.Rows)
                            {
                                hiddenid.Text = dr[0].ToString();
                                Pr_Name.Text = dr[1].ToString();
                                Pr_Price.Text = dr[2].ToString();
                                Pr_Description.Text = dr[3].ToString();
                                Pr_Category.Text = dr[4].ToString();
                                Pr_Stock.Text = dr[5].ToString();
                            }
                            //Repeater1.DataSource = dt;
                            //Repeater1.DataBind();
                        }
                    }
                }
            }

        }


        protected void updateproduct(object sender, EventArgs e)
        {
            SqlConnection sqlc = null;
            try
            {
                string name = Pr_Name.Text;
                int price = Convert.ToInt32(Pr_Price.Text);
                string descp = Pr_Description.Text;
                string category = Pr_Category.Text;
                int stock = Convert.ToInt32(Pr_Stock.Text);
                int id = Convert.ToInt32(hiddenid.Text);
                Connection c = new Connection();
              
                sqlc  = new SqlConnection(c.connect());
                string sql = "update addproduct set name = '"+ name + "', price = '"+ price + "', descp = '"+ descp + "', category = '"+ category + "', stock = '"+ stock + "' where id = '" + id + "'";
                sqlc.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlc);
               
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    Status.Text = "Update Successfully";
                    //Console.WriteLine("successfully Completed");
                  //  Response.Redirect("Default");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlc.Close();
            }
        }
    }
}