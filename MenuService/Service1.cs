using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MenuService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string[] GetData()
        {
            string[] menuList = new string[5];
            menuList[0] = "Crispy Pork Belly";
            menuList[1] = "Dry-Fried Enggplant";
            menuList[2] = "Chongqing Chicken";
            menuList[3] = "Bamnoo Fish";
            menuList[4] = "Seefood Stone Pot";
            return menuList;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
