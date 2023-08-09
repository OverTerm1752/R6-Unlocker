namespace SumTing_Special
{
	// Token: 0x02000004 RID: 4
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000021FF File Offset: 0x000003FF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028F0 File Offset: 0x00000AF0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SumTing_Special.MainForm));
			this.FormDragBarPnl = new global::System.Windows.Forms.Panel();
			this.MinimizeBtn = new global::System.Windows.Forms.Button();
			this.ExitBtn = new global::System.Windows.Forms.Button();
			this.MiddlePnl = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.UnlockerBtn = new global::System.Windows.Forms.Button();
			this.SaveMounterBtn = new global::System.Windows.Forms.Button();
			this.AboutBtn = new global::System.Windows.Forms.Button();
			this.WebsiteBtn = new global::System.Windows.Forms.Button();
			this.R6SPB = new global::System.Windows.Forms.PictureBox();
			this.DiscordBtn = new global::System.Windows.Forms.Button();
			this.ExpandTmr = new global::System.Windows.Forms.Timer(this.components);
			this.FormDragBarPnl.SuspendLayout();
			this.MiddlePnl.SuspendLayout();
			this.panel1.SuspendLayout();
			this.R6SPB.BeginInit();
			base.SuspendLayout();
			this.FormDragBarPnl.BackColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.FormDragBarPnl.Controls.Add(this.MinimizeBtn);
			this.FormDragBarPnl.Controls.Add(this.ExitBtn);
			this.FormDragBarPnl.Location = new global::System.Drawing.Point(0, 0);
			this.FormDragBarPnl.Name = "FormDragBarPnl";
			this.FormDragBarPnl.Size = new global::System.Drawing.Size(198, 34);
			this.FormDragBarPnl.TabIndex = 0;
			this.FormDragBarPnl.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseDown);
			this.FormDragBarPnl.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseMove);
			this.FormDragBarPnl.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseUp);
			this.MinimizeBtn.FlatAppearance.BorderSize = 0;
			this.MinimizeBtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.MinimizeBtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Red;
			this.MinimizeBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.MinimizeBtn.Image = global::SumTing_Special.Properties.Resources.icons8_minimize_20;
			this.MinimizeBtn.Location = new global::System.Drawing.Point(144, 6);
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
			this.ExitBtn.Location = new global::System.Drawing.Point(169, 6);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new global::System.Drawing.Size(20, 20);
			this.ExitBtn.TabIndex = 1;
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new global::System.EventHandler(this.ExitBtn_Click);
			this.MiddlePnl.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.MiddlePnl.Controls.Add(this.panel1);
			this.MiddlePnl.Location = new global::System.Drawing.Point(8, 43);
			this.MiddlePnl.Name = "MiddlePnl";
			this.MiddlePnl.Size = new global::System.Drawing.Size(182, 317);
			this.MiddlePnl.TabIndex = 3;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.panel1.Controls.Add(this.UnlockerBtn);
			this.panel1.Controls.Add(this.SaveMounterBtn);
			this.panel1.Controls.Add(this.AboutBtn);
			this.panel1.Controls.Add(this.WebsiteBtn);
			this.panel1.Controls.Add(this.R6SPB);
			this.panel1.Controls.Add(this.DiscordBtn);
			this.panel1.Location = new global::System.Drawing.Point(9, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(164, 299);
			this.panel1.TabIndex = 4;
			this.UnlockerBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.UnlockerBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.UnlockerBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UnlockerBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.UnlockerBtn.ForeColor = global::System.Drawing.Color.White;
			this.UnlockerBtn.Location = new global::System.Drawing.Point(6, 125);
			this.UnlockerBtn.Name = "UnlockerBtn";
			this.UnlockerBtn.Size = new global::System.Drawing.Size(152, 25);
			this.UnlockerBtn.TabIndex = 9;
			this.UnlockerBtn.Text = "Unlocker";
			this.UnlockerBtn.UseVisualStyleBackColor = false;
			this.UnlockerBtn.Click += new global::System.EventHandler(this.UnlockerBtn_Click);
			this.SaveMounterBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.SaveMounterBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.SaveMounterBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SaveMounterBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SaveMounterBtn.ForeColor = global::System.Drawing.Color.White;
			this.SaveMounterBtn.Location = new global::System.Drawing.Point(6, 156);
			this.SaveMounterBtn.Name = "SaveMounterBtn";
			this.SaveMounterBtn.Size = new global::System.Drawing.Size(152, 25);
			this.SaveMounterBtn.TabIndex = 8;
			this.SaveMounterBtn.Text = "Save Mounter";
			this.SaveMounterBtn.UseVisualStyleBackColor = false;
			this.SaveMounterBtn.Click += new global::System.EventHandler(this.SaveMounterBtn_Click);
			this.AboutBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.AboutBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.AboutBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.AboutBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AboutBtn.ForeColor = global::System.Drawing.Color.White;
			this.AboutBtn.Location = new global::System.Drawing.Point(6, 267);
			this.AboutBtn.Name = "AboutBtn";
			this.AboutBtn.Size = new global::System.Drawing.Size(152, 25);
			this.AboutBtn.TabIndex = 6;
			this.AboutBtn.Text = "About";
			this.AboutBtn.UseVisualStyleBackColor = false;
			this.AboutBtn.Click += new global::System.EventHandler(this.AboutBtn_Click);
			this.WebsiteBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.WebsiteBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.WebsiteBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.WebsiteBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WebsiteBtn.ForeColor = global::System.Drawing.Color.White;
			this.WebsiteBtn.Location = new global::System.Drawing.Point(6, 236);
			this.WebsiteBtn.Name = "WebsiteBtn";
			this.WebsiteBtn.Size = new global::System.Drawing.Size(152, 25);
			this.WebsiteBtn.TabIndex = 5;
			this.WebsiteBtn.Text = "Website";
			this.WebsiteBtn.UseVisualStyleBackColor = false;
			this.WebsiteBtn.Click += new global::System.EventHandler(this.WebsiteBtn_Click);
			this.R6SPB.Image = global::SumTing_Special.Properties.Resources.R6S;
			this.R6SPB.Location = new global::System.Drawing.Point(-8, 3);
			this.R6SPB.Name = "R6SPB";
			this.R6SPB.Size = new global::System.Drawing.Size(181, 114);
			this.R6SPB.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.R6SPB.TabIndex = 3;
			this.R6SPB.TabStop = false;
			this.DiscordBtn.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.DiscordBtn.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.DiscordBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.DiscordBtn.Font = new global::System.Drawing.Font("Verdana", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DiscordBtn.ForeColor = global::System.Drawing.Color.White;
			this.DiscordBtn.Location = new global::System.Drawing.Point(6, 205);
			this.DiscordBtn.Name = "DiscordBtn";
			this.DiscordBtn.Size = new global::System.Drawing.Size(152, 25);
			this.DiscordBtn.TabIndex = 4;
			this.DiscordBtn.Text = "Discord";
			this.DiscordBtn.UseVisualStyleBackColor = false;
			this.DiscordBtn.Click += new global::System.EventHandler(this.DiscordBtn_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			base.ClientSize = new global::System.Drawing.Size(198, 367);
			base.Controls.Add(this.MiddlePnl);
			base.Controls.Add(this.FormDragBarPnl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Made by vPurpp";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.FormDragBarPnl.ResumeLayout(false);
			this.MiddlePnl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.R6SPB.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Panel FormDragBarPnl;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button MinimizeBtn;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button ExitBtn;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Panel MiddlePnl;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.PictureBox R6SPB;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button DiscordBtn;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button WebsiteBtn;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button AboutBtn;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Timer ExpandTmr;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button UnlockerBtn;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button SaveMounterBtn;
	}
}
