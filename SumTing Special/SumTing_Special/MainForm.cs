using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SumTing_Special.Properties;

namespace SumTing_Special
{
	// Token: 0x02000004 RID: 4
	public partial class MainForm : Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002114 File Offset: 0x00000314
		public MainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002122 File Offset: 0x00000322
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002124 File Offset: 0x00000324
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000212B File Offset: 0x0000032B
		private void MinimizeBtn_Click(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Minimized;
				return;
			}
			base.WindowState |= FormWindowState.Normal;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000214B File Offset: 0x0000034B
		private void FormDragBarPnl_MouseDown(object sender, MouseEventArgs e)
		{
			this._MouseOffset = new Point(-e.X, -e.Y);
			this._UserDraggingForm = true;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000028B0 File Offset: 0x00000AB0
		private void FormDragBarPnl_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._UserDraggingForm)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this._MouseOffset.X, this._MouseOffset.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000216D File Offset: 0x0000036D
		private void FormDragBarPnl_MouseUp(object sender, MouseEventArgs e)
		{
			this._UserDraggingForm = false;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002176 File Offset: 0x00000376
		private void DiscordBtn_Click(object sender, EventArgs e)
		{
			Process.Start("cmd", "/c start https://discord.com/invite/r4c");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002188 File Offset: 0x00000388
		private void WebsiteBtn_Click(object sender, EventArgs e)
		{
			Process.Start("cmd", "/c start https://tomware.cc");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000219A File Offset: 0x0000039A
		private void AboutBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Made by vPurpp \n Version: 6.0", "About | Discord.gg/r4c", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021AF File Offset: 0x000003AF
		private void UnlockerBtn_Click(object sender, EventArgs e)
		{
			base.Hide();
			UnlockerForm unlockerForm = new UnlockerForm();
			unlockerForm.FormClosed += new FormClosedEventHandler(this.UnlockerForm_FormClosed);
			unlockerForm.Show();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021D3 File Offset: 0x000003D3
		private void UnlockerForm_FormClosed(object sender, EventArgs e)
		{
			base.Show();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000021DB File Offset: 0x000003DB
		private void SaveMounterBtn_Click(object sender, EventArgs e)
		{
			base.Hide();
			SaveMounterForm saveMounterForm = new SaveMounterForm();
			saveMounterForm.FormClosed += new FormClosedEventHandler(this.SaveMounterForm_FormClosed);
			saveMounterForm.Show();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000021D3 File Offset: 0x000003D3
		private void SaveMounterForm_FormClosed(object sender, EventArgs e)
		{
			base.Show();
		}

		// Token: 0x04000007 RID: 7
		private bool _UserDraggingForm;

		// Token: 0x04000008 RID: 8
		private Point _MouseOffset;

		// Token: 0x04000009 RID: 9
		private UnlockerForm _UnlockerForm;

		// Token: 0x0400000A RID: 10
		private SaveMounterForm _SaveMounterForm;
	}
}
