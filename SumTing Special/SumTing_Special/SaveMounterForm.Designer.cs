namespace SumTing_Special
{
	// Token: 0x02000006 RID: 6
	public partial class SaveMounterForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000022A2 File Offset: 0x000004A2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003954 File Offset: 0x00001B54
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SumTing_Special.SaveMounterForm));
			this.FormDragBarPnl = new global::System.Windows.Forms.Panel();
			this.MinimizeBtn = new global::System.Windows.Forms.Button();
			this.ExitBtn = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.StatusDynamicLbl = new global::System.Windows.Forms.Label();
			this.StatusStaticLbl = new global::System.Windows.Forms.Label();
			this.UbiLocateLbl = new global::System.Windows.Forms.Label();
			this.R6LocateLbl = new global::System.Windows.Forms.Label();
			this.LocateUbiBtn = new global::System.Windows.Forms.Button();
			this.UbiPathTB = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.LocateR6Btn = new global::System.Windows.Forms.Button();
			this.R6PathTB = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.AutoLoadSaveBtn = new global::System.Windows.Forms.Button();
			this.LoadSaveBtn = new global::System.Windows.Forms.Button();
			this.UserIDLbl = new global::System.Windows.Forms.Label();
			this.UserIDCB = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.MiddlePnl = new global::System.Windows.Forms.Panel();
			this.FormDragBarPnl.SuspendLayout();
			this.panel1.SuspendLayout();
			this.MiddlePnl.SuspendLayout();
			base.SuspendLayout();
			this.FormDragBarPnl.BackColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.FormDragBarPnl.Controls.Add(this.MinimizeBtn);
			this.FormDragBarPnl.Controls.Add(this.ExitBtn);
			this.FormDragBarPnl.Location = new global::System.Drawing.Point(0, 0);
			this.FormDragBarPnl.Name = "FormDragBarPnl";
			this.FormDragBarPnl.Size = new global::System.Drawing.Size(191, 34);
			this.FormDragBarPnl.TabIndex = 2;
			this.FormDragBarPnl.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseDown);
			this.FormDragBarPnl.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseMove);
			this.FormDragBarPnl.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseUp);
			this.MinimizeBtn.FlatAppearance.BorderSize = 0;
			this.MinimizeBtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.MinimizeBtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Red;
			this.MinimizeBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.MinimizeBtn.Image = global::SumTing_Special.Properties.Resources.icons8_minimize_20;
			this.MinimizeBtn.Location = new global::System.Drawing.Point(139, 7);
			this.MinimizeBtn.Name = "MinimizeBtn";
			this.MinimizeBtn.Size = new global::System.Drawing.Size(20, 20);
			this.MinimizeBtn.TabIndex = 2;
			this.MinimizeBtn.UseVisualStyleBackColor = true;
			this.MinimizeBtn.Click += new global::System.EventHandler(this.MinimizeBtn_Click);
			this.ExitBtn.FlatAppearance.BorderSize = 0;
			this.ExitBtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.ExitBtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Red;
			this.ExitBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ExitBtn.Image = global::SumTing_Special.Properties.Resources.icons8_x_20;
			this.ExitBtn.Location = new global::System.Drawing.Point(164, 7);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new global::System.Drawing.Size(20, 20);
			this.ExitBtn.TabIndex = 1;
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new global::System.EventHandler(this.ExitBtn_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.panel1.Controls.Add(this.StatusDynamicLbl);
			this.panel1.Controls.Add(this.StatusStaticLbl);
			this.panel1.Controls.Add(this.UbiLocateLbl);
			this.panel1.Controls.Add(this.R6LocateLbl);
			this.panel1.Controls.Add(this.LocateUbiBtn);
			this.panel1.Controls.Add(this.UbiPathTB);
			this.panel1.Controls.Add(this.LocateR6Btn);
			this.panel1.Controls.Add(this.R6PathTB);
			this.panel1.Controls.Add(this.AutoLoadSaveBtn);
			this.panel1.Controls.Add(this.LoadSaveBtn);
			this.panel1.Controls.Add(this.UserIDLbl);
			this.panel1.Controls.Add(this.UserIDCB);
			this.panel1.Location = new global::System.Drawing.Point(9, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(164, 269);
			this.panel1.TabIndex = 4;
			this.StatusDynamicLbl.AutoSize = true;
			this.StatusDynamicLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.StatusDynamicLbl.ForeColor = global::System.Drawing.Color.White;
			this.StatusDynamicLbl.Location = new global::System.Drawing.Point(56, 240);
			this.StatusDynamicLbl.Name = "StatusDynamicLbl";
			this.StatusDynamicLbl.Size = new global::System.Drawing.Size(55, 16);
			this.StatusDynamicLbl.TabIndex = 17;
			this.StatusDynamicLbl.Text = "Waiting";
			this.StatusDynamicLbl.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.StatusStaticLbl.AutoSize = true;
			this.StatusStaticLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.StatusStaticLbl.ForeColor = global::System.Drawing.Color.White;
			this.StatusStaticLbl.Location = new global::System.Drawing.Point(3, 240);
			this.StatusStaticLbl.Name = "StatusStaticLbl";
			this.StatusStaticLbl.Size = new global::System.Drawing.Size(57, 16);
			this.StatusStaticLbl.TabIndex = 16;
			this.StatusStaticLbl.Text = "Status:";
			this.UbiLocateLbl.AutoSize = true;
			this.UbiLocateLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.UbiLocateLbl.ForeColor = global::System.Drawing.Color.White;
			this.UbiLocateLbl.Location = new global::System.Drawing.Point(9, 85);
			this.UbiLocateLbl.Name = "UbiLocateLbl";
			this.UbiLocateLbl.Size = new global::System.Drawing.Size(68, 16);
			this.UbiLocateLbl.TabIndex = 15;
			this.UbiLocateLbl.Text = "Ubi Path:";
			this.R6LocateLbl.AutoSize = true;
			this.R6LocateLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.R6LocateLbl.ForeColor = global::System.Drawing.Color.White;
			this.R6LocateLbl.Location = new global::System.Drawing.Point(9, 44);
			this.R6LocateLbl.Name = "R6LocateLbl";
			this.R6LocateLbl.Size = new global::System.Drawing.Size(64, 16);
			this.R6LocateLbl.TabIndex = 14;
			this.R6LocateLbl.Text = "R6 Path:";
			this.LocateUbiBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.LocateUbiBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.LocateUbiBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LocateUbiBtn.Font = new global::System.Drawing.Font("Verdana", 6.75f);
			this.LocateUbiBtn.ForeColor = global::System.Drawing.Color.White;
			this.LocateUbiBtn.Location = new global::System.Drawing.Point(120, 101);
			this.LocateUbiBtn.Name = "LocateUbiBtn";
			this.LocateUbiBtn.Size = new global::System.Drawing.Size(32, 22);
			this.LocateUbiBtn.TabIndex = 13;
			this.LocateUbiBtn.Text = "...";
			this.LocateUbiBtn.UseVisualStyleBackColor = false;
			this.LocateUbiBtn.Click += new global::System.EventHandler(this.LocateUbiBtn_Click);
			this.UbiPathTB.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.UbiPathTB.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.UbiPathTB.DefaultText = "";
			this.UbiPathTB.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.UbiPathTB.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.UbiPathTB.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.UbiPathTB.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.UbiPathTB.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.UbiPathTB.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UbiPathTB.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.UbiPathTB.ForeColor = global::System.Drawing.Color.White;
			this.UbiPathTB.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UbiPathTB.Location = new global::System.Drawing.Point(12, 101);
			this.UbiPathTB.Name = "UbiPathTB";
			this.UbiPathTB.PasswordChar = '\0';
			this.UbiPathTB.PlaceholderText = "";
			this.UbiPathTB.ReadOnly = true;
			this.UbiPathTB.SelectedText = "";
			this.UbiPathTB.Size = new global::System.Drawing.Size(102, 22);
			this.UbiPathTB.TabIndex = 12;
			this.UbiPathTB.TextChanged += new global::System.EventHandler(this.UbiPathTB_TextChanged);
			this.LocateR6Btn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.LocateR6Btn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.LocateR6Btn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LocateR6Btn.Font = new global::System.Drawing.Font("Verdana", 6.75f);
			this.LocateR6Btn.ForeColor = global::System.Drawing.Color.White;
			this.LocateR6Btn.Location = new global::System.Drawing.Point(120, 60);
			this.LocateR6Btn.Name = "LocateR6Btn";
			this.LocateR6Btn.Size = new global::System.Drawing.Size(32, 22);
			this.LocateR6Btn.TabIndex = 11;
			this.LocateR6Btn.Text = "...";
			this.LocateR6Btn.UseVisualStyleBackColor = false;
			this.LocateR6Btn.Click += new global::System.EventHandler(this.LocateR6Btn_Click);
			this.R6PathTB.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.R6PathTB.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.R6PathTB.DefaultText = "";
			this.R6PathTB.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.R6PathTB.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.R6PathTB.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.R6PathTB.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.R6PathTB.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.R6PathTB.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.R6PathTB.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.R6PathTB.ForeColor = global::System.Drawing.Color.White;
			this.R6PathTB.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.R6PathTB.Location = new global::System.Drawing.Point(12, 60);
			this.R6PathTB.Name = "R6PathTB";
			this.R6PathTB.PasswordChar = '\0';
			this.R6PathTB.PlaceholderText = "";
			this.R6PathTB.ReadOnly = true;
			this.R6PathTB.SelectedText = "";
			this.R6PathTB.Size = new global::System.Drawing.Size(102, 22);
			this.R6PathTB.TabIndex = 10;
			this.R6PathTB.TextChanged += new global::System.EventHandler(this.R6PathTB_TextChanged);
			this.AutoLoadSaveBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.AutoLoadSaveBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.AutoLoadSaveBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.AutoLoadSaveBtn.Font = new global::System.Drawing.Font("Verdana", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AutoLoadSaveBtn.ForeColor = global::System.Drawing.Color.White;
			this.AutoLoadSaveBtn.Location = new global::System.Drawing.Point(6, 202);
			this.AutoLoadSaveBtn.Name = "AutoLoadSaveBtn";
			this.AutoLoadSaveBtn.Size = new global::System.Drawing.Size(152, 25);
			this.AutoLoadSaveBtn.TabIndex = 9;
			this.AutoLoadSaveBtn.Text = "Mount Save (Automatic)";
			this.AutoLoadSaveBtn.UseVisualStyleBackColor = false;
			this.AutoLoadSaveBtn.Click += new global::System.EventHandler(this.AutoLoadSaveBtn_Click);
			this.LoadSaveBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.LoadSaveBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.LoadSaveBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoadSaveBtn.Font = new global::System.Drawing.Font("Verdana", 6.75f);
			this.LoadSaveBtn.ForeColor = global::System.Drawing.Color.White;
			this.LoadSaveBtn.Location = new global::System.Drawing.Point(6, 171);
			this.LoadSaveBtn.Name = "LoadSaveBtn";
			this.LoadSaveBtn.Size = new global::System.Drawing.Size(152, 25);
			this.LoadSaveBtn.TabIndex = 8;
			this.LoadSaveBtn.Text = "Mount Save (Manual)";
			this.LoadSaveBtn.UseVisualStyleBackColor = false;
			this.LoadSaveBtn.Click += new global::System.EventHandler(this.LoadSaveBtn_Click);
			this.UserIDLbl.AutoSize = true;
			this.UserIDLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.UserIDLbl.ForeColor = global::System.Drawing.Color.White;
			this.UserIDLbl.Location = new global::System.Drawing.Point(9, 1);
			this.UserIDLbl.Name = "UserIDLbl";
			this.UserIDLbl.Size = new global::System.Drawing.Size(42, 16);
			this.UserIDLbl.TabIndex = 7;
			this.UserIDLbl.Text = "User:";
			this.UserIDCB.BackColor = global::System.Drawing.Color.Transparent;
			this.UserIDCB.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.UserIDCB.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.UserIDCB.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UserIDCB.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.UserIDCB.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UserIDCB.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UserIDCB.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.UserIDCB.ForeColor = global::System.Drawing.Color.White;
			this.UserIDCB.ItemHeight = 18;
			this.UserIDCB.Location = new global::System.Drawing.Point(12, 17);
			this.UserIDCB.Name = "UserIDCB";
			this.UserIDCB.Size = new global::System.Drawing.Size(140, 24);
			this.UserIDCB.TabIndex = 6;
			this.MiddlePnl.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.MiddlePnl.Controls.Add(this.panel1);
			this.MiddlePnl.Location = new global::System.Drawing.Point(4, 40);
			this.MiddlePnl.Name = "MiddlePnl";
			this.MiddlePnl.Size = new global::System.Drawing.Size(182, 287);
			this.MiddlePnl.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			base.ClientSize = new global::System.Drawing.Size(191, 331);
			base.Controls.Add(this.MiddlePnl);
			base.Controls.Add(this.FormDragBarPnl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "SaveMounterForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SaveMounterForm";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.SaveMounterForm_FormClosing);
			base.Load += new global::System.EventHandler(this.SaveMounterForm_Load);
			this.FormDragBarPnl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.MiddlePnl.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button MinimizeBtn;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button ExitBtn;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Panel FormDragBarPnl;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Panel MiddlePnl;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label UserIDLbl;

		// Token: 0x04000022 RID: 34
		private global::Guna.UI2.WinForms.Guna2ComboBox UserIDCB;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button LoadSaveBtn;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button AutoLoadSaveBtn;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label UbiLocateLbl;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label R6LocateLbl;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button LocateUbiBtn;

		// Token: 0x04000028 RID: 40
		private global::Guna.UI2.WinForms.Guna2TextBox UbiPathTB;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button LocateR6Btn;

		// Token: 0x0400002A RID: 42
		private global::Guna.UI2.WinForms.Guna2TextBox R6PathTB;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label StatusDynamicLbl;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label StatusStaticLbl;
	}
}
