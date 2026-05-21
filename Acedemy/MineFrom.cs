using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using DBTools;

namespace Acedemy
{
	public partial class MineFrom : Form
	{
		Connector connector;
		public MineFrom()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			//dgvSrudents.DataSource = connector.Select("SELECT * FROM Students");
			dgvSrudents.DataSource = connector.Select
				(
				"stud_id,last_name,first_name,middle_name,birth_date,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
				);
		}
	}
}
