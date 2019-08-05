using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace Business
{
    public class MenuProvider
    {
        public string[] Get()
        {
            GetMenu getMenu = new GetMenu();
            return getMenu.GetMenuFromWCFService();
        }

    }
}
