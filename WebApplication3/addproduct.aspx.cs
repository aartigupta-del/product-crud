using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class addproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Pr_Name.Text;
                int price = Convert.ToInt32(Pr_Price.Text);
                string descp = Pr_Description.Text;
                string category = Pr_Category.Text;
                int stock = Convert.ToInt32(Pr_Stock.Text);
                Connection c = new Connection();
             
                SqlConnection sqlc = new SqlConnection(c.connect());
                string sql = "insert into addproduct(name,price,descp,category,stock) values('" + name+ "','" + price + "','" + descp + "','" + category + "','" +
                    stock + "')";
                SqlCommand cmd = new SqlCommand(sql, sqlc);
                sqlc.Open();
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    //Status.Text = "Inserted Successfully";
                    //Console.WriteLine("successfully Completed");
                    Response.Write("<script> alert('successfully Completed !!') </script>");  
                }
                else
                {
                    Response.Write("<script> alert('Fail !!') </script>");
                    Console.WriteLine("failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
         
    }
}