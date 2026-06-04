using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Acedemy
{
    public partial class HumanForm : Form
    {
        internal Models.Human human;
        public HumanForm()
        {
            InitializeComponent();
            tbLastName.Text = "Фамилия";
            tbFerstName.Text = "Имя";
            tbMiddelName.Text = "Отчество";
            dtpBirthDate.Value = Convert.ToDateTime("2026-05-30");
            tbEmail.Text = "box@example.com";
        }
        protected virtual void Compress()
        {
            human = new Models.Human
                (
                Convert.ToInt32(labelID.Text == "" ? "0" : labelID.Text.Split(':').Last()),
                tbLastName.Text,
                tbFerstName.Text,
                tbMiddelName.Text,
                dtpBirthDate.Value.ToString("yyyy-MM-dd"),
                tbEmail.Text,
                tbPhone.Text,
                pictureBoxPhoto.Image
                );
        }

        protected virtual void btnOk_Click(object sender, EventArgs e)
        {
            Compress();
        }

        

        private void pictureBoxPhoto_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pictureBoxPhoto, "Для выбора фото сделайте двойной щелчек мышью");

        }

        private void pictureBoxPhoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
