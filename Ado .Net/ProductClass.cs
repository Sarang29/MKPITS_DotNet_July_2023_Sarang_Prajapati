using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assi_Product_Form_Insert_Update_Delete
{
    internal class ProductClass
    {

        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mkpits";
        public string InsertProduct(int ProdId, string ProdName, int Price, int Quantity)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "insert into products values(@ProdId,@ProdName,@Price,@Quantity)";

                using (SqlCommand command = new SqlCommand(str, con))
                {

                    command.Parameters.AddWithValue("@ProdID", ProdId);
                    command.Parameters.AddWithValue("@ProdName", ProdName);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@Quantity", Quantity);

                    command.ExecuteNonQuery();

                    con.Close();

                    return "Record Inserted Successfully";
                }
            }
        }

        public string UpdateProduct(int ProdId, string ProdName, int Price, int Quantity)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "update products set ProdName=@ProdName,Price=@Price,Quantity=@Quantity where ProdId=@prodId";

                using (SqlCommand command = new SqlCommand(str, con))
                {

                    
                    command.Parameters.AddWithValue("@ProdName", ProdName);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@Quantity", Quantity);
                    command.Parameters.AddWithValue("@ProdID", ProdId);

                    command.ExecuteNonQuery();

                    con.Close();

                    return "Record Updated Successfully";
                }
            }
        }


        public string DeleteProduct(int ProdId, string ProdName)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "delete from products where ProdName=@ProdName or ProdId=@prodId";

                using (SqlCommand command = new SqlCommand(str, con))
                {


                    command.Parameters.AddWithValue("@ProdName", ProdName);
                    command.Parameters.AddWithValue("@ProdID", ProdId);

                    command.ExecuteNonQuery();

                    con.Close();

                    return "Record Deleted Successfully";
                }
            }
        }

        public List<Product> SearchProduct(int ProdId)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string str = "select * from products where ProdId=@ProdId";

                using (SqlCommand command = new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@ProdId", ProdId);

                    SqlDataReader dr = command.ExecuteReader();

                    List<Product> li = new List<Product>();
                    while (dr.Read())
                    {
                        li.Add(new Product(Convert.ToInt32(dr["ProdId"]), dr["ProdName"].ToString(), Convert.ToInt32(dr["Price"]), Convert.ToInt32(dr["Quantity"])));
                    }
                    return li;
                }
            }

        }
    }
}
