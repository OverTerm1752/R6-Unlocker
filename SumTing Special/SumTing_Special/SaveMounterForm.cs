using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SumTing_Special.Properties;
using YamlDotNet.RepresentationModel;

namespace SumTing_Special
{
	// Token: 0x02000006 RID: 6
	public partial class SaveMounterForm : Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003358 File Offset: 0x00001558
		public SaveMounterForm()
		{
			this.InitializeComponent();
			new ToolTip().SetToolTip(this.R6PathTB, this.R6PathTB.Text);
			new ToolTip().SetToolTip(this.UbiPathTB, this.UbiPathTB.Text);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002235 File Offset: 0x00000435
		private void FormDragBarPnl_MouseDown(object sender, MouseEventArgs e)
		{
			this._MouseOffset = new Point(-e.X, -e.Y);
			this._UserDraggingForm = true;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000033A8 File Offset: 0x000015A8
		private void FormDragBarPnl_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._UserDraggingForm)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this._MouseOffset.X, this._MouseOffset.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002257 File Offset: 0x00000457
		private void FormDragBarPnl_MouseUp(object sender, MouseEventArgs e)
		{
			this._UserDraggingForm = false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002260 File Offset: 0x00000460
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000212B File Offset: 0x0000032B
		private void MinimizeBtn_Click(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Minimized;
				return;
			}
			base.WindowState |= FormWindowState.Normal;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000033E8 File Offset: 0x000015E8
		private void LocateUbiBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Locate UbisoftConnect.exe";
			openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
			openFileDialog.FileName = "UbisoftConnect.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				this.UbiPathTB.Text = fileName;
				string directoryName = Path.GetDirectoryName(fileName);
				this.savegamesPath = Path.Combine(directoryName, "savegames");
				if (Directory.Exists(this.savegamesPath))
				{
					string[] directories = Directory.GetDirectories(this.savegamesPath);
					this.UserIDCB.Items.Clear();
					string[] array = directories;
					for (int i = 0; i < array.Length; i++)
					{
						string fileName2 = Path.GetFileName(array[i]);
						this.UserIDCB.Items.Add(fileName2);
					}
				}
				this.UbiPathTB.Text = fileName;
				this.StatusDynamicLbl.Text = "UbisoftConnect.exe located";
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000034C8 File Offset: 0x000016C8
		private void LocateR6Btn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Locate RainbowSix.exe";
			openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
			openFileDialog.FileName = "RainbowSix.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				this.R6PathTB.Text = fileName;
				this.StatusDynamicLbl.Text = "RainbowSix.exe located";
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002268 File Offset: 0x00000468
		private void R6PathTB_TextChanged(object sender, EventArgs e)
		{
			new ToolTip().SetToolTip(this.R6PathTB, this.R6PathTB.Text);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002285 File Offset: 0x00000485
		private void UbiPathTB_TextChanged(object sender, EventArgs e)
		{
			new ToolTip().SetToolTip(this.UbiPathTB, this.UbiPathTB.Text);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003528 File Offset: 0x00001728
		private void LoadSaveBtn_Click(object sender, EventArgs e)
		{
			object selectedItem = this.UserIDCB.SelectedItem;
			string text = (selectedItem != null) ? selectedItem.ToString() : null;
			if (string.IsNullOrEmpty(text))
			{
				MessageBox.Show("Please select a folder from the UserIDCB ComboBox.");
				return;
			}
			string text2 = Path.Combine(this.savegamesPath, text, "635");
			string text3 = Path.Combine(this.savegamesPath, text, "1843");
			bool flag = Directory.Exists(text2);
			bool flag2 = Directory.Exists(text3);
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select 1.save file";
			openFileDialog.Filter = "1.save files|1.save|All files|*.*";
			openFileDialog.FileName = "1.save";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				try
				{
					if (!flag)
					{
						Directory.CreateDirectory(text2);
					}
					if (!flag2)
					{
						Directory.CreateDirectory(text3);
					}
					File.Copy(fileName, Path.Combine(text2, "1.save"), true);
					File.Copy(fileName, Path.Combine(text3, "1.save"), true);
					this.StatusDynamicLbl.Text = "1.save loaded ";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error while loading the 1.save file: " + ex.Message);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002122 File Offset: 0x00000322
		private void SaveMounterForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000364C File Offset: 0x0000184C
		private void AutoLoadSaveBtn_Click(object sender, EventArgs e)
		{
			object selectedItem = this.UserIDCB.SelectedItem;
			string text = (selectedItem != null) ? selectedItem.ToString() : null;
			if (string.IsNullOrEmpty(text))
			{
				MessageBox.Show("Please select a folder from the User ID Combo Box.");
				return;
			}
			string text2 = Path.Combine(this.savegamesPath, text, "635");
			string text3 = Path.Combine(this.savegamesPath, text, "1843");
			bool flag = Directory.Exists(text2);
			bool flag2 = Directory.Exists(text3);
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select 1.save file";
			openFileDialog.Filter = "1.save files|1.save|All files|*.*";
			openFileDialog.FileName = "1.save";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				try
				{
					if (!flag)
					{
						Directory.CreateDirectory(text2);
					}
					if (!flag2)
					{
						Directory.CreateDirectory(text3);
					}
					File.Copy(fileName, Path.Combine(text2, "1.save"), true);
					File.Copy(fileName, Path.Combine(text3, "1.save"), true);
					this.StatusDynamicLbl.Text = "1.save file loaded";
					string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ubisoft Game Launcher", "settings.yaml");
					this.ModifySettingsYAML(filePath, true);
					Process.Start(this.R6PathTB.Text);
					this.StatusDynamicLbl.Text = "RainbowSix.exe Launching";
					Thread.Sleep(120000);
					this.CloseRainbowSix();
					this.ModifySettingsYAML(filePath, false);
					this.StatusDynamicLbl.Text = "RainbowSix.exe closed";
					Thread.Sleep(500);
					this.StatusDynamicLbl.Text = "Waiting";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error while loading the 1.save file or modifying settings.yaml: " + ex.Message);
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000037F8 File Offset: 0x000019F8
		private void ModifySettingsYAML(string filePath, bool setOfflineTrue)
		{
			YamlStream yamlStream = new YamlStream();
			using (StreamReader streamReader = new StreamReader(filePath))
			{
				yamlStream.Load(streamReader);
			}
			YamlNode yamlNode;
			if (((YamlMappingNode)yamlStream.Documents[0].RootNode).Children.TryGetValue(new YamlScalarNode("games"), out yamlNode))
			{
				YamlMappingNode yamlMappingNode = yamlNode as YamlMappingNode;
				YamlNode yamlNode2;
				if (yamlMappingNode != null && yamlMappingNode.Children.TryGetValue(new YamlScalarNode("TheDivision2"), out yamlNode2))
				{
					YamlMappingNode yamlMappingNode2 = yamlNode2 as YamlMappingNode;
					YamlNode value;
					if (yamlMappingNode2 != null && yamlMappingNode2.Children.TryGetValue(new YamlScalarNode("offline"), out value))
					{
						if (setOfflineTrue)
						{
							value = new YamlScalarNode("true");
						}
						else
						{
							value = new YamlScalarNode("false");
						}
						yamlMappingNode2.Children[new YamlScalarNode("offline")] = value;
						using (StreamWriter streamWriter = new StreamWriter(filePath))
						{
							yamlStream.Save(streamWriter, false);
						}
					}
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003918 File Offset: 0x00001B18
		private void CloseRainbowSix()
		{
			Process[] processesByName = Process.GetProcessesByName("RainbowSix.exe");
			if (processesByName.Length != 0)
			{
				foreach (Process process in processesByName)
				{
					process.CloseMainWindow();
					process.WaitForExit();
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002122 File Offset: 0x00000322
		private void SaveMounterForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x04000018 RID: 24
		private bool _UserDraggingForm;

		// Token: 0x04000019 RID: 25
		private Point _MouseOffset;

		// Token: 0x0400001A RID: 26
		private string savegamesPath;
	}
}
