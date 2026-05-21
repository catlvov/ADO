namespace Acedemy
{
	partial class MineFrom
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
			this.TabControlls = new System.Windows.Forms.TabControl();
			this.Students = new System.Windows.Forms.TabPage();
			this.Groups = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Disciplines = new System.Windows.Forms.TabPage();
			this.Teachers = new System.Windows.Forms.TabPage();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.dgvSrudents = new System.Windows.Forms.DataGridView();
			this.TabControlls.SuspendLayout();
			this.Students.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSrudents)).BeginInit();
			this.SuspendLayout();
			// 
			// TabControlls
			// 
			this.TabControlls.Controls.Add(this.Students);
			this.TabControlls.Controls.Add(this.Groups);
			this.TabControlls.Controls.Add(this.tabPage1);
			this.TabControlls.Controls.Add(this.Disciplines);
			this.TabControlls.Controls.Add(this.Teachers);
			this.TabControlls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControlls.Location = new System.Drawing.Point(0, 0);
			this.TabControlls.Name = "TabControlls";
			this.TabControlls.SelectedIndex = 0;
			this.TabControlls.Size = new System.Drawing.Size(800, 450);
			this.TabControlls.TabIndex = 0;
			// 
			// Students
			// 
			this.Students.Controls.Add(this.dgvSrudents);
			this.Students.Location = new System.Drawing.Point(4, 22);
			this.Students.Name = "Students";
			this.Students.Padding = new System.Windows.Forms.Padding(3);
			this.Students.Size = new System.Drawing.Size(792, 424);
			this.Students.TabIndex = 0;
			this.Students.Text = "Students";
			this.Students.UseVisualStyleBackColor = true;
			// 
			// Groups
			// 
			this.Groups.Location = new System.Drawing.Point(4, 22);
			this.Groups.Name = "Groups";
			this.Groups.Padding = new System.Windows.Forms.Padding(3);
			this.Groups.Size = new System.Drawing.Size(792, 424);
			this.Groups.TabIndex = 1;
			this.Groups.Text = "Groups";
			this.Groups.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 424);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Directions";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Disciplines
			// 
			this.Disciplines.Location = new System.Drawing.Point(4, 22);
			this.Disciplines.Name = "Disciplines";
			this.Disciplines.Padding = new System.Windows.Forms.Padding(3);
			this.Disciplines.Size = new System.Drawing.Size(792, 424);
			this.Disciplines.TabIndex = 3;
			this.Disciplines.Text = "Disciplines";
			this.Disciplines.UseVisualStyleBackColor = true;
			// 
			// Teachers
			// 
			this.Teachers.Location = new System.Drawing.Point(4, 22);
			this.Teachers.Name = "Teachers";
			this.Teachers.Padding = new System.Windows.Forms.Padding(3);
			this.Teachers.Size = new System.Drawing.Size(792, 424);
			this.Teachers.TabIndex = 4;
			this.Teachers.Text = "Teachers";
			this.Teachers.UseVisualStyleBackColor = true;
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			// 
			// dgvSrudents
			// 
			this.dgvSrudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSrudents.Location = new System.Drawing.Point(6, 24);
			this.dgvSrudents.Name = "dgvSrudents";
			this.dgvSrudents.Size = new System.Drawing.Size(780, 379);
			this.dgvSrudents.TabIndex = 0;
			// 
			// MineFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.TabControlls);
			this.Name = "MineFrom";
			this.Text = "MainFrom";
			this.TabControlls.ResumeLayout(false);
			this.Students.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSrudents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl TabControlls;
		private System.Windows.Forms.TabPage Students;
		private System.Windows.Forms.TabPage Groups;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage Disciplines;
		private System.Windows.Forms.TabPage Teachers;
		private System.Windows.Forms.DataGridView dgvSrudents;
	}
}

