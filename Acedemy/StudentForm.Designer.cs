namespace Acedemy
{
    partial class StudentForm
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
            this.Group = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(309, 444);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(216, 444);
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(17, 444);
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group.Location = new System.Drawing.Point(17, 371);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(78, 24);
            this.Group.TabIndex = 18;
            this.Group.Text = "Группа:";
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(17, 398);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(197, 32);
            this.cbGroup.TabIndex = 19;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 479);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.Group);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Controls.SetChildIndex(this.labelID, 0);
            this.Controls.SetChildIndex(this.btnCansel, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.Group, 0);
            this.Controls.SetChildIndex(this.cbGroup, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.ComboBox cbGroup;
    }
}