using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CafeOrder
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int NumberOfDishes { get; set; }
        public decimal Cost { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
