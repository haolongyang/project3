using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GetMenu
    {
        public string[] GetMenuFromWCFService()
        {

            //Create object of the Binding
            Binding binding = new BasicHttpBinding();
            //Create endpointAddress of the Service
            EndpointAddress endpointAddress = new
            EndpointAddress("http://localhost:8733/Design_Time_Addresses/MenuService/Service1/");
            //Create Client of the Service
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client(binding, endpointAddress);
            
            return sc.GetData();
        }
    }
}
