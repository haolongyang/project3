using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataAccess
{
    public class GetOrderTable
    {
        public DataTable Get()
        {
            string connetionString;
            SqlConnection connection;
            string sql = null;
            connetionString = ConfigurationManager.ConnectionStrings["CafeOrderTableConnection"].ConnectionString;
            //connetionString = "Data Source=DESKTOP-QUQE209\\SQLEXPRESS;Initial Catalog=WorldBestCafe;Integrated Security=True";
            sql = "SELECT * FROM CafeOrder";
            DataSet cafeOrdersDS = new DataSet();
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                
                adapter.Fill(cafeOrdersDS, "CafeOrder");
            }
            finally
            {
                connection.Close();
            }

            return cafeOrdersDS.Tables["CafeOrder"];
        }
    }
}
