using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Configuration;
using DBTools;


namespace Acedemy
{
	public partial class MineFrom : Form
	{
		Connector connector;
		DataGridView[] tables;
		Query[] queries =
			{
			new Query
				(
					"stud_id,FORMATMESSAGE(N'%s %s %s',last_name,first_name,middle_name)AS N'Student',birth_date,group_name,direction_name",
					"Students,Groups,Directions",
					"[group]=group_id AND direction=direction_id"
				),
			new Query
				(
				"group_id,group_name,direction_name,start_date,start_time,learning_days",
				"Groups, Directions",
				"direction=direction_id"
				),
			new Query("*", "Directions"),
			new Query("*", "Disciplines"),
			new Query("*", "Teachers")
		};

		public MineFrom()
		{
			AllocConsole();
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
			//---------------------------------------------------------------
			LoadComboBoxFromBase(cbGroupsDirection, "Directions");
			LoadComboBoxFromBase(cbStudentsGroups, "Groups");
            LoadComboBoxFromBase(cbStudentsDirections, "Directions");
        }
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		void LoadComboBoxFromBase(ComboBox comboBox,string table )
		{
			string column = table.Substring(0,table.Length-1).ToLower();
			DataTable dt = connector.Select($"SELECT {column}_id,{column}_name FROM {table}");
			DataRow rowDefault = dt.NewRow();
			rowDefault[0] = 0;
			rowDefault[1] = "Все";
			dt.Rows.InsertAt(rowDefault, 0);
			comboBox.DataSource = dt;
            comboBox.DisplayMember = $"{column}_name";
            comboBox.ValueMember = $"{column}_id";
			//cbGroupsDirections.SelectedValue = 0;

		}
		private void TabControlls_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			//tables[i].DataSource = connector.Select("*", $"{tabControl.SelectedTab.Text}");
			tables[i].DataSource = connector.Select(queries[i].ToString());
			toolStripStatusLabel.Text = $"Количество записей: {tables[i].RowCount - 1}";
			tables[i].Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}

		private void cbGroupsDirections_SelectionChangeCommitted(object sender, EventArgs e)
		{
			//if (cbGroupsDirections.SelectedIndex > 0)
				tables[1].DataSource = connector.Select
				(
					queries[1].ToString() + 
					(cbGroupsDirection.SelectedIndex == 0 ? "" : $" AND direction={cbGroupsDirection.SelectedValue}")
				);
			//Console.WriteLine($"SelectedIndex:{cbGroupsDirections.SelectedIndex}");
			//console.writeline($"selectedindex:{cbgroupsdirections.selecteditem}");
			//console.writeline($"selectedindex:{cbgroupsdirections.selectedtext}");
			//console.writeline($"selectedindex:{cbgroupsdirections.selectedvalue}");
		}
	}
}
