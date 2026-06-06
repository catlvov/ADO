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
            //Default constructor - это конструктор, который может быть вызван без параметров.
            InitializeComponent();
            //cbGroup.DataSource = DataBase.Connector.Select($"SELECT group_id,group_name FROM Groups");
            //cbGroup.DisplayMember = "group_name";
            //cbGroup.ValueMember = "group_id";
            DataBase.LoadComboBoxFromBase(cbGroup, "Groups");
        }

        public StudentForm(int id) : this()
        {
            DataTable data = DataBase.Connector.Select("*", "Students", $"stud_id={id}");
            //data.Rows[0].
            human = student = new Models.Student(data.Rows[0].ItemArray);
            Exctract();
        }

        protected override void Exctract()
        {
            base.Exctract();
            cbGroup.SelectedValue = student.group;
        }

        protected override void btnOk_Click(object sender, EventArgs e)
        {
            base.btnOk_Click(sender, e);
            student = new Models.Student(human, Convert.ToInt32(cbGroup.SelectedValue));
            if (student.id == 0) student.id = Convert.ToInt32(DataBase.Connector.Scalar
                (
                    $"INSERT INTO Students ({student.GetNames()}) VALUES ({student.GetValues()});" +
                    $"SELECT SCOPE_IDENTITY();"
                ));
            else DataBase.Connector.Update
                (
                    "Students",
                    student.GetUpdateExpression(),
                    $"stud_id={student.id}"
                );
            if (pictureBoxPhoto.Image != null)
                DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");
        }
    }
}
