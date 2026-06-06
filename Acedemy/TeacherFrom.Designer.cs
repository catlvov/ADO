namespace Acedemy
{
    partial class TeacherFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
            this.labelWorkSince = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.mtbRate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Size = new System.Drawing.Size(200, 29);
            // 
            // tbFerstName
            // 
            this.tbFerstName.Size = new System.Drawing.Size(200, 29);
            // 
            // tbMiddelName
            // 
            this.tbMiddelName.Size = new System.Drawing.Size(200, 29);
            // 
            // tbEmail
            // 
            this.tbEmail.Size = new System.Drawing.Size(200, 29);
            // 
            // tbPhone
            // 
            this.tbPhone.Size = new System.Drawing.Size(200, 29);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 29);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(309, 454);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(216, 454);
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(219, 339);
            // 
            // dtpWorkSince
            // 
            this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpWorkSince.Location = new System.Drawing.Point(13, 395);
            this.dtpWorkSince.Name = "dtpWorkSince";
            this.dtpWorkSince.Size = new System.Drawing.Size(200, 29);
            this.dtpWorkSince.TabIndex = 19;
            // 
            // labelWorkSince
            // 
            this.labelWorkSince.AutoSize = true;
            this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkSince.Location = new System.Drawing.Point(13, 368);
            this.labelWorkSince.Name = "labelWorkSince";
            this.labelWorkSince.Size = new System.Drawing.Size(110, 24);
            this.labelWorkSince.TabIndex = 20;
            this.labelWorkSince.Text = "Работает с";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRate.Location = new System.Drawing.Point(13, 427);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(178, 24);
            this.labelRate.TabIndex = 21;
            this.labelRate.Text = "Заработная плата:";
            // 
            // mtbRate
            // 
            this.mtbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbRate.Location = new System.Drawing.Point(17, 455);
            this.mtbRate.Mask = "00000";
            this.mtbRate.Name = "mtbRate";
            this.mtbRate.Size = new System.Drawing.Size(196, 29);
            this.mtbRate.TabIndex = 22;
            this.mtbRate.ValidatingType = typeof(int);
            // 
            // TeacherFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 492);
            this.Controls.Add(this.mtbRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelWorkSince);
            this.Controls.Add(this.dtpWorkSince);
            this.Name = "TeacherFrom";
            this.Text = "TeacherFrom";
            this.Controls.SetChildIndex(this.labelLastName, 0);
            this.Controls.SetChildIndex(this.labelFirstNmae, 0);
            this.Controls.SetChildIndex(this.labelMiddleName, 0);
            this.Controls.SetChildIndex(this.labelDirthDate, 0);
            this.Controls.SetChildIndex(this.labelPhone, 0);
            this.Controls.SetChildIndex(this.labelEmail, 0);
            this.Controls.SetChildIndex(this.labelPhoto, 0);
            this.Controls.SetChildIndex(this.tbLastName, 0);
            this.Controls.SetChildIndex(this.tbFerstName, 0);
            this.Controls.SetChildIndex(this.tbMiddelName, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.tbPhone, 0);
            this.Controls.SetChildIndex(this.dtpBirthDate, 0);
            this.Controls.SetChildIndex(this.btnCansel, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.labelID, 0);
            this.Controls.SetChildIndex(this.dtpWorkSince, 0);
            this.Controls.SetChildIndex(this.labelWorkSince, 0);
            this.Controls.SetChildIndex(this.labelRate, 0);
            this.Controls.SetChildIndex(this.mtbRate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWorkSince;
        private System.Windows.Forms.Label labelWorkSince;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.MaskedTextBox mtbRate;
    }
}