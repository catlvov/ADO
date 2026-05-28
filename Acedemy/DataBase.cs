using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBTools;

namespace Acedemy
{
    static class DataBase
    {
        public static Connector Connector { get; set; } 
        static DataBase()
        {
            Connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
        }
    }
}
