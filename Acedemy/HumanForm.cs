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
            //tbLastName.Text = "Фамилия";
            //tbFerstName.Text = "Имя";
            //tbMiddelName.Text = "Отчество";
            //dtpBirthDate.Value = Convert.ToDateTime("2026-05-30");
            //tbEmail.Text = "box@example.com";
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

        protected virtual void Exctract()
        {
            this.labelID.Text = $"ID:{human.id}";
            this.tbLastName.Text = human.last_name;
            this.tbFerstName.Text = human.first_name;
            this.tbMiddelName.Text = human.middle_name;
            this.dtpBirthDate.Value = Convert.ToDateTime(human.birth_date);
            this.tbEmail.Text = human.email;
            this.tbPhone.Text = human.phone;
            this.pictureBoxPhoto.Image = human.photo;
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
            dialog.Filter = "BMP files|*.bmp|PNG files|*.png|JPG files|*.jpg;*.jpeg|All image files|*.bmp;*.png;*.jpg;*.jpeg;*.svg;*.jfif;*.webp|All files|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
