using DBTools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acedemy
{
    static class DataBase
    {
        public static Connector Connector { get; set; } 
        static DataBase()
        {
            Connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
        }
       public static void LoadComboBoxFromBase(ComboBox comboBox, string table, string condition = "")
        {
            string column = table.Substring(0, table.Length - 1).ToLower();
            string cmd = $"SELECT {column}_id,{column}_name FROM {table}";
            if (condition != "") cmd += $" WHERE {condition}";
            DataTable dt = Connector.Select(cmd);
            DataRow rowDefault = dt.NewRow();
            rowDefault[0] = 0;
            rowDefault[1] = "Все";
            dt.Rows.InsertAt(rowDefault, 0);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = $"{column}_name";
            comboBox.ValueMember = $"{column}_id";
        }
    }
}
