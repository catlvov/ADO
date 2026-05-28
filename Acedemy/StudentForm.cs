using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acedemy
{
    public partial class StudentForm : HumanForm
    {
        Models.Student student;
        public StudentForm()
        {
            InitializeComponent();
            cbGroup.DataSource = DataBase.Connector.Select($"SELECT group_id, group_name FROM Groups");
            cbGroup.DisplayMember = "group_name";
            cbGroup.ValueMember = "group_id";
            DataBase.LoadComboBoxFromBase(cbGroup,"Groups");
            
        }

        protected override void btnOk_Click(object sender, EventArgs e)
        {
            base.btnOk_Click(sender, e);
            student = new Models.Student(human,(int)cbGroup.SelectedValue);
            DataBase.Connector.Insert($"INSERT Students({student.GetNames()}) VALUES({student.GetValues()})");
        }
    }
}
