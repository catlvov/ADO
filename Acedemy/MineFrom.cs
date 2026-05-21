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
		DataGridView[] tables;
		public MineFrom()
		{
			InitializeComponent();
			tables = new DataGridView[] {dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			//dgvSrudents.DataSource = connector.Select("SELECT * FROM Students");
			//dgvStudents.DataSource = connector.Select
			//	(
			//	"stud_id,last_name,first_name,middle_name,birth_date,group_name,direction_name",
			//	"Students,Groups,Directions",
			//	"[group]=group_id AND direction=direction_id"
			//	);

			TabControlls_SelectedIndexChanged(tabControl, null);
		}

		private void TabControlls_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Select("*", $"{tabControl.SelectedTab.Text}");
			toolStripStatusLable.Text = $"Количество Элементов: {tables[i].RowCount - 1}";
		}
	}
}
