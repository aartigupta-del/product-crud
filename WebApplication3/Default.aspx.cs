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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Connection c = new Connection();
            //c.connect();
            string sql = "select * from addproduct order by id desc";
            using(SqlConnection  conn = new SqlConnection(c.connect())){
                using (SqlCommand cmd = new SqlCommand(sql)) {
                    using (SqlDataAdapter sda = new SqlDataAdapter()) {
                        cmd.Connection = conn;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                                Repeater1.DataSource = dt;
                                Repeater1.DataBind();
                        }
                    }
                }
            }
        }


        protected void addProducts(object sender, EventArgs e)
        {
            try
            {
                string name = Pr_Name.Text;
                int price = Convert.ToInt32(Pr_Price.Text);
                string descp = Pr_Description.Text;
                string category = Pr_Category.Text;
                int stock = Convert.ToInt32(Pr_Stock.Text);

                Connection c = new Connection();
                c.connect();
                SqlConnection sqlc = new SqlConnection(c.connect());
                string sql = "insert into addproduct(name,price,descp,category,stock) values('" + name + "','" + price + "','" + descp + "','" + category + "','" +
                    stock + "')";
                SqlCommand cmd = new SqlCommand(sql, sqlc);
                sqlc.Open();
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    Status.Text = "Inserted Successfully";
                    Console.WriteLine("successfully Completed");
                    Response.Redirect("Default");
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
        }

        [System.Web.Services.WebMethod]
        public static string GetCurrentTime(string name)
        {
            return "Hello " + name + Environment.NewLine + "The Current Time is: "
                + DateTime.Now.ToString();
        }

    }
}