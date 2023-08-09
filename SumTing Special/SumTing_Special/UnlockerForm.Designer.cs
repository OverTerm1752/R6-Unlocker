namespace SumTing_Special
{
	// Token: 0x02000007 RID: 7
	public partial class UnlockerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000240F File Offset: 0x0000060F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005130 File Offset: 0x00003330
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SumTing_Special.UnlockerForm));
			this.FormDragBarPnl = new global::System.Windows.Forms.Panel();
			this.MinimizeBtn = new global::System.Windows.Forms.Button();
			this.ExitBtn = new global::System.Windows.Forms.Button();
			this.MiddlePnl = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.StatusDynamicLbl = new global::System.Windows.Forms.Label();
			this.StatusStaticLbl = new global::System.Windows.Forms.Label();
			this.AutoSpoofCKB = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.FixWifiBtn = new global::System.Windows.Forms.Button();
			this.KeyBindTB = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.KeyBindLbl = new global::System.Windows.Forms.Label();
			this.AdapterLbl = new global::System.Windows.Forms.Label();
			this.AdaptersCB = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.SpoofMacBtn = new global::System.Windows.Forms.Button();
			this.updateHotkeyTimer = new global::System.Windows.Forms.Timer(this.components);
			this.FormDragBarPnl.SuspendLayout();
			this.MiddlePnl.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.FormDragBarPnl.BackColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.FormDragBarPnl.Controls.Add(this.MinimizeBtn);
			this.FormDragBarPnl.Controls.Add(this.ExitBtn);
			this.FormDragBarPnl.Location = new global::System.Drawing.Point(0, 0);
			this.FormDragBarPnl.Name = "FormDragBarPnl";
			this.FormDragBarPnl.Size = new global::System.Drawing.Size(192, 34);
			this.FormDragBarPnl.TabIndex = 1;
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
			this.MiddlePnl.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.MiddlePnl.Controls.Add(this.panel1);
			this.MiddlePnl.Location = new global::System.Drawing.Point(4, 40);
			this.MiddlePnl.Name = "MiddlePnl";
			this.MiddlePnl.Size = new global::System.Drawing.Size(182, 287);
			this.MiddlePnl.TabIndex = 4;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.panel1.Controls.Add(this.StatusDynamicLbl);
			this.panel1.Controls.Add(this.StatusStaticLbl);
			this.panel1.Controls.Add(this.AutoSpoofCKB);
			this.panel1.Controls.Add(this.FixWifiBtn);
			this.panel1.Controls.Add(this.KeyBindTB);
			this.panel1.Controls.Add(this.KeyBindLbl);
			this.panel1.Controls.Add(this.AdapterLbl);
			this.panel1.Controls.Add(this.AdaptersCB);
			this.panel1.Controls.Add(this.SpoofMacBtn);
			this.panel1.Location = new global::System.Drawing.Point(9, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(164, 269);
			this.panel1.TabIndex = 4;
			this.StatusDynamicLbl.AutoSize = true;
			this.StatusDynamicLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.StatusDynamicLbl.ForeColor = global::System.Drawing.Color.White;
			this.StatusDynamicLbl.Location = new global::System.Drawing.Point(61, 245);
			this.StatusDynamicLbl.Name = "StatusDynamicLbl";
			this.StatusDynamicLbl.Size = new global::System.Drawing.Size(29, 16);
			this.StatusDynamicLbl.TabIndex = 11;
			this.StatusDynamicLbl.Text = "null";
			this.StatusDynamicLbl.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.StatusStaticLbl.AutoSize = true;
			this.StatusStaticLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.StatusStaticLbl.ForeColor = global::System.Drawing.Color.White;
			this.StatusStaticLbl.Location = new global::System.Drawing.Point(8, 245);
			this.StatusStaticLbl.Name = "StatusStaticLbl";
			this.StatusStaticLbl.Size = new global::System.Drawing.Size(57, 16);
			this.StatusStaticLbl.TabIndex = 10;
			this.StatusStaticLbl.Text = "Status:";
			this.AutoSpoofCKB.AutoSize = true;
			this.AutoSpoofCKB.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.AutoSpoofCKB.CheckedState.BorderRadius = 0;
			this.AutoSpoofCKB.CheckedState.BorderThickness = 0;
			this.AutoSpoofCKB.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.AutoSpoofCKB.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.AutoSpoofCKB.ForeColor = global::System.Drawing.Color.White;
			this.AutoSpoofCKB.Location = new global::System.Drawing.Point(32, 153);
			this.AutoSpoofCKB.Name = "AutoSpoofCKB";
			this.AutoSpoofCKB.Size = new global::System.Drawing.Size(100, 20);
			this.AutoSpoofCKB.TabIndex = 9;
			this.AutoSpoofCKB.Text = "Auto Spoof";
			this.AutoSpoofCKB.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.AutoSpoofCKB.UncheckedState.BorderRadius = 0;
			this.AutoSpoofCKB.UncheckedState.BorderThickness = 1;
			this.AutoSpoofCKB.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.AutoSpoofCKB.CheckedChanged += new global::System.EventHandler(this.AutoSpoofCKB_CheckedChanged);
			this.FixWifiBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.FixWifiBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.FixWifiBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.FixWifiBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FixWifiBtn.ForeColor = global::System.Drawing.Color.White;
			this.FixWifiBtn.Location = new global::System.Drawing.Point(6, 207);
			this.FixWifiBtn.Name = "FixWifiBtn";
			this.FixWifiBtn.Size = new global::System.Drawing.Size(152, 25);
			this.FixWifiBtn.TabIndex = 8;
			this.FixWifiBtn.Text = "Fix Wifi";
			this.FixWifiBtn.UseVisualStyleBackColor = false;
			this.FixWifiBtn.Click += new global::System.EventHandler(this.FixWifiBtn_Click);
			this.KeyBindTB.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.KeyBindTB.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.KeyBindTB.DefaultText = "";
			this.KeyBindTB.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.KeyBindTB.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.KeyBindTB.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyBindTB.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyBindTB.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.KeyBindTB.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyBindTB.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.KeyBindTB.ForeColor = global::System.Drawing.Color.White;
			this.KeyBindTB.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyBindTB.Location = new global::System.Drawing.Point(79, 73);
			this.KeyBindTB.Name = "KeyBindTB";
			this.KeyBindTB.PasswordChar = '\0';
			this.KeyBindTB.PlaceholderText = "";
			this.KeyBindTB.SelectedText = "";
			this.KeyBindTB.Size = new global::System.Drawing.Size(73, 22);
			this.KeyBindTB.TabIndex = 7;
			this.KeyBindTB.Click += new global::System.EventHandler(this.KeyBindTB_Click);
			this.KeyBindTB.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.KeyBindTB_KeyDown);
			this.KeyBindTB.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.KeyBindTB_KeyPress);
			this.KeyBindLbl.AutoSize = true;
			this.KeyBindLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.KeyBindLbl.ForeColor = global::System.Drawing.Color.White;
			this.KeyBindLbl.Location = new global::System.Drawing.Point(9, 76);
			this.KeyBindLbl.Name = "KeyBindLbl";
			this.KeyBindLbl.Size = new global::System.Drawing.Size(64, 16);
			this.KeyBindLbl.TabIndex = 6;
			this.KeyBindLbl.Text = "KeyBind:";
			this.AdapterLbl.AutoSize = true;
			this.AdapterLbl.Font = new global::System.Drawing.Font("Verdana", 9.75f);
			this.AdapterLbl.ForeColor = global::System.Drawing.Color.White;
			this.AdapterLbl.Location = new global::System.Drawing.Point(9, 7);
			this.AdapterLbl.Name = "AdapterLbl";
			this.AdapterLbl.Size = new global::System.Drawing.Size(65, 16);
			this.AdapterLbl.TabIndex = 5;
			this.AdapterLbl.Text = "Adapter:";
			this.AdaptersCB.BackColor = global::System.Drawing.Color.Transparent;
			this.AdaptersCB.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.AdaptersCB.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.AdaptersCB.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AdaptersCB.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.AdaptersCB.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.AdaptersCB.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.AdaptersCB.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.AdaptersCB.ForeColor = global::System.Drawing.Color.White;
			this.AdaptersCB.ItemHeight = 18;
			this.AdaptersCB.Location = new global::System.Drawing.Point(12, 26);
			this.AdaptersCB.Name = "AdaptersCB";
			this.AdaptersCB.Size = new global::System.Drawing.Size(140, 24);
			this.AdaptersCB.TabIndex = 0;
			this.AdaptersCB.SelectedIndexChanged += new global::System.EventHandler(this.AdaptersCB_SelectedIndexChanged);
			this.SpoofMacBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.SpoofMacBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.SpoofMacBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SpoofMacBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SpoofMacBtn.ForeColor = global::System.Drawing.Color.White;
			this.SpoofMacBtn.Location = new global::System.Drawing.Point(6, 176);
			this.SpoofMacBtn.Name = "SpoofMacBtn";
			this.SpoofMacBtn.Size = new global::System.Drawing.Size(152, 25);
			this.SpoofMacBtn.TabIndex = 4;
			this.SpoofMacBtn.Text = "Spoof";
			this.SpoofMacBtn.UseVisualStyleBackColor = false;
			this.SpoofMacBtn.Click += new global::System.EventHandler(this.SpoofMacBtn_Click);
			this.updateHotkeyTimer.Tick += new global::System.EventHandler(this.updateHotkeyTimer_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			base.ClientSize = new global::System.Drawing.Size(191, 331);
			base.Controls.Add(this.MiddlePnl);
			base.Controls.Add(this.FormDragBarPnl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "UnlockerForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Unlocker";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.UnlockerForm_FormClosing);
			base.Load += new global::System.EventHandler(this.UnlockerForm_Load);
			this.FormDragBarPnl.ResumeLayout(false);
			this.MiddlePnl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400003C RID: 60
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Panel FormDragBarPnl;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Button MinimizeBtn;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Button ExitBtn;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Panel MiddlePnl;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button SpoofMacBtn;

		// Token: 0x04000043 RID: 67
		private global::Guna.UI2.WinForms.Guna2ComboBox AdaptersCB;

		// Token: 0x04000044 RID: 68
		private global::Guna.UI2.WinForms.Guna2TextBox KeyBindTB;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label KeyBindLbl;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label AdapterLbl;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button FixWifiBtn;

		// Token: 0x04000048 RID: 72
		private global::Guna.UI2.WinForms.Guna2CheckBox AutoSpoofCKB;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label StatusStaticLbl;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Timer updateHotkeyTimer;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label StatusDynamicLbl;
	}
}
