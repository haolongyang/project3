using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class OrderDataProvider
    {
        public List<CafeOrder> Get()
        {
            GetOrderTable getOrderTable = new GetOrderTable();
            var cafeOrderTable = getOrderTable.Get();

            List<CafeOrder> list = new List<CafeOrder>();

            foreach(DataRow row in cafeOrderTable.Rows)
            {
                list.Add(new CafeOrder
                {
                    ID = (int)row["ID"],
                    CustomerName = (string)row["CustomerName"],
                    NumberOfDishes = (int)row["NumberOfDishes"],
                    Cost = (decimal)row["Cost"],
                    OrderDate = (DateTime)row["OrderDate"]
                });
            }

            return list;
        }
    }
}
