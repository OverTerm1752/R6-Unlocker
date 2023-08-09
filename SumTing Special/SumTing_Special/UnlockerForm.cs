using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SumTing_Special.Properties;

namespace SumTing_Special
{
	// Token: 0x02000007 RID: 7
	public partial class UnlockerForm : Form
	{
		// Token: 0x06000036 RID: 54
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000037 RID: 55
		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000038 RID: 56
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);

		// Token: 0x06000039 RID: 57
		[DllImport("gdi32.dll")]
		public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

		// Token: 0x0600003A RID: 58
		[DllImport("user32.dll")]
		public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

		// Token: 0x0600003B RID: 59 RVA: 0x00004A98 File Offset: 0x00002C98
		public UnlockerForm()
		{
			this.InitializeComponent();
			this._Form = this;
			this.timer.Interval = 100;
			this.timer.Tick += this.Timer_Tick;
			this.AdaptersCB.SelectedIndexChanged += this.AdaptersCB_SelectedIndexChanged;
			this.KeyBindTB.KeyDown += this.KeyBindTB_KeyDown;
			this.KeyBindTB.TextChanged += this.KeyBindTB_TextChanged;
			this.AutoSpoofCKB.CheckedChanged += this.AutoSpoofCKB_CheckedChanged;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004B4C File Offset: 0x00002D4C
		private void UnlockerForm_Load(object sender, EventArgs e)
		{
			foreach (NetworkInterface networkInterface in Enumerable.OrderByDescending<NetworkInterface, bool>(Enumerable.Where<NetworkInterface>(NetworkInterface.GetAllNetworkInterfaces(), (NetworkInterface FA) => NetworkAdapter.IsValidMAC(FA.GetPhysicalAddress().GetAddressBytes(), true)), (NetworkInterface FA) => FA.IsReceiveOnly))
			{
				this.AdaptersCB.Items.Add(new NetworkAdapter(networkInterface));
			}
			this.UpdateStatusLabel();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022C1 File Offset: 0x000004C1
		private void FormDragBarPnl_MouseDown(object sender, MouseEventArgs e)
		{
			this._MouseOffset = new Point(-e.X, -e.Y);
			this._UserDraggingForm = true;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004BF8 File Offset: 0x00002DF8
		private void FormDragBarPnl_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._UserDraggingForm)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this._MouseOffset.X, this._MouseOffset.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022E3 File Offset: 0x000004E3
		private void FormDragBarPnl_MouseUp(object sender, MouseEventArgs e)
		{
			this._UserDraggingForm = false;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002260 File Offset: 0x00000460
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000212B File Offset: 0x0000032B
		private void MinimizeBtn_Click(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Minimized;
				return;
			}
			base.WindowState |= FormWindowState.Normal;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000022EC File Offset: 0x000004EC
		private void KeyBindTB_Click(object sender, EventArgs e)
		{
			this.KeyBindTB.Text = "Press any key...";
			this._CapturingKey = true;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004C38 File Offset: 0x00002E38
		private void KeyBindTB_KeyDown(object sender, KeyEventArgs e)
		{
			if (this._CapturingKey && !this._SelectedKey.HasFlag(Keys.Modifiers))
			{
				if (this.IsValidSingleCharacterKey(e.KeyCode))
				{
					this._SelectedKey = e.KeyCode;
					this.KeyBindTB.Text = this._SelectedKey.ToString();
				}
				else
				{
					this._SelectedKey = Keys.None;
					this.KeyBindTB.Text = "Invalid key. Press any key...";
				}
				e.SuppressKeyPress = true;
				e.Handled = true;
				this._Form.Focus();
				base.ActiveControl = null;
				this.UpdateStatusLabel();
			}
			if (string.IsNullOrEmpty(this.KeyBindTB.Text))
			{
				return;
			}
			UnlockerForm.UnregisterHotKey(base.Handle, 1);
			uint fsModifiers = Convert.ToUInt32(Control.ModifierKeys);
			uint vk = Convert.ToUInt32(e.KeyCode);
			UnlockerForm.RegisterHotKey(base.Handle, 1, fsModifiers, vk);
			this._KeyBind = this.KeyBindTB.Text;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002305 File Offset: 0x00000505
		private void KeyBindTB_TextChanged(object sender, EventArgs e)
		{
			this.UpdateStatusLabel();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000230D File Offset: 0x0000050D
		private void KeyBindTB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this._CapturingKey)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000231E File Offset: 0x0000051E
		private bool IsValidSingleCharacterKey(Keys key)
		{
			return !key.HasFlag(Keys.Modifiers) && char.IsLetterOrDigit((char)key);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002340 File Offset: 0x00000540
		private void SpoofMacBtn_Click(object sender, EventArgs e)
		{
			this._NewMac = NetworkAdapter.GenerateRandomMAC();
			if (NetworkAdapter.IsValidMAC(this._NewMac, false))
			{
				this.SetMAC(this._NewMac, "Change MAC Address");
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000236C File Offset: 0x0000056C
		public void SetMAC(string MAC, string Title)
		{
			if ((this.AdaptersCB.SelectedItem as NetworkAdapter).SetRegistryPhysicalAddress(MAC, Title))
			{
				Thread.Sleep(333);
				this.UA();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004D44 File Offset: 0x00002F44
		public void UA()
		{
			NetworkAdapter networkAdapter = this.AdaptersCB.SelectedItem as NetworkAdapter;
			this._OldMac = networkAdapter.PhysicalAddress;
			if (!string.IsNullOrEmpty(networkAdapter.RegistryPhysicalAddress))
			{
				this._NewMac = networkAdapter.RegistryPhysicalAddress;
				return;
			}
			this._NewMac = this._OldMac;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002397 File Offset: 0x00000597
		private void AdaptersCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UA();
			this.UpdateStatusLabel();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004D94 File Offset: 0x00002F94
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 786 && m.WParam.ToInt32() == 1)
			{
				this._NewMac = NetworkAdapter.GenerateRandomMAC();
				if (NetworkAdapter.IsValidMAC(this._NewMac, false))
				{
					this.SetMAC(this._NewMac, "Change MAC Address");
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004DF0 File Offset: 0x00002FF0
		private void updateHotkeyTimer_Tick(object sender, EventArgs e)
		{
			if (this.KeyBindTB.Text != this._KeyBind)
			{
				UnlockerForm.UnregisterHotKey(base.Handle, 1);
				uint fsModifiers = Convert.ToUInt32(Control.ModifierKeys);
				uint vk = Convert.ToUInt32((Keys)Enum.Parse(typeof(Keys), this.KeyBindTB.Text));
				UnlockerForm.RegisterHotKey(base.Handle, 1, fsModifiers, vk);
				this._KeyBind = this.KeyBindTB.Text;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004E7C File Offset: 0x0000307C
		private void FixWifiBtn_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID='Wi-Fi' OR NetConnectionID='Ethernet'").Get())
				{
					((ManagementObject)managementBaseObject).InvokeMethod("Enable", null);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000023A5 File Offset: 0x000005A5
		private void AutoSpoofCKB_CheckedChanged(object sender, EventArgs e)
		{
			if (this.AutoSpoofCKB.Checked)
			{
				this.StartScanning();
				this.StatusDynamicLbl.Text = "Waiting";
				return;
			}
			this.StopScanning();
			this.UpdateStatusLabel();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002122 File Offset: 0x00000322
		private void UnlockerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000023D7 File Offset: 0x000005D7
		private void StartScanning()
		{
			this.isScanning = true;
			this.timer.Start();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000023EB File Offset: 0x000005EB
		private void StopScanning()
		{
			this.isScanning = false;
			this.timer.Stop();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000023FF File Offset: 0x000005FF
		private void Timer_Tick(object sender, EventArgs e)
		{
			if (this.isScanning)
			{
				this.CheckPixelColors();
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004EF0 File Offset: 0x000030F0
		private void CheckPixelColors()
		{
			Color color = Color.FromArgb(255, 255, 255);
			Rectangle bounds = Screen.PrimaryScreen.Bounds;
			Point location = new Point(bounds.Width / 2, bounds.Height / 2);
			Color screenPixelColor = this.GetScreenPixelColor(location);
			if (this.AreColorsSimilar(screenPixelColor, color, this.tolerance) && !this.cooldownActive)
			{
				MessageBox.Show("Match");
				this.StartCooldown(300000);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004F6C File Offset: 0x0000316C
		private void StartCooldown(int cooldownTime)
		{
			UnlockerForm.<StartCooldown>d__42 <StartCooldown>d__;
			<StartCooldown>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<StartCooldown>d__.<>4__this = this;
			<StartCooldown>d__.cooldownTime = cooldownTime;
			<StartCooldown>d__.<>1__state = -1;
			<StartCooldown>d__.<>t__builder.Start<UnlockerForm.<StartCooldown>d__42>(ref <StartCooldown>d__);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004FAC File Offset: 0x000031AC
		private bool AreColorsSimilar(Color color1, Color color2, int tolerance)
		{
			int num = Math.Abs((int)(color1.R - color2.R));
			int num2 = Math.Abs((int)(color1.G - color2.G));
			int num3 = Math.Abs((int)(color1.B - color2.B));
			return num <= tolerance && num2 <= tolerance && num3 <= tolerance;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005008 File Offset: 0x00003208
		private Color GetScreenPixelColor(Point location)
		{
			Color pixel;
			using (Bitmap bitmap = new Bitmap(1, 1))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.CopyFromScreen(location, Point.Empty, new Size(1, 1));
				}
				pixel = bitmap.GetPixel(0, 0);
			}
			return pixel;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005078 File Offset: 0x00003278
		private void UpdateStatusLabel()
		{
			if (this.cooldownActive)
			{
				this.StatusDynamicLbl.Text = "Cooldown";
				this.StatusDynamicLbl.ForeColor = Color.Blue;
			}
			if (this.AdaptersCB.SelectedItem == null)
			{
				this.StatusDynamicLbl.Text = "Select Adapter";
				this.StatusDynamicLbl.ForeColor = Color.Red;
				return;
			}
			if (string.IsNullOrEmpty(this.KeyBindTB.Text))
			{
				this.StatusDynamicLbl.Text = "Select Keybind";
				this.StatusDynamicLbl.ForeColor = Color.Red;
				return;
			}
			this.StatusDynamicLbl.Text = "Waiting";
			this.StatusDynamicLbl.ForeColor = Color.White;
		}

		// Token: 0x0400002D RID: 45
		private bool _UserDraggingForm;

		// Token: 0x0400002E RID: 46
		private Point _MouseOffset;

		// Token: 0x0400002F RID: 47
		private Keys _SelectedKey;

		// Token: 0x04000030 RID: 48
		private bool _CapturingKey;

		// Token: 0x04000031 RID: 49
		private Form _Form;

		// Token: 0x04000032 RID: 50
		private string _NewMac;

		// Token: 0x04000033 RID: 51
		private string _OldMac;

		// Token: 0x04000034 RID: 52
		private const int WMHotkey = 786;

		// Token: 0x04000035 RID: 53
		private const int ModNoRepeat = 16384;

		// Token: 0x04000036 RID: 54
		private const int HotkeyID = 1;

		// Token: 0x04000037 RID: 55
		private string _KeyBind;

		// Token: 0x04000038 RID: 56
		private bool cooldownActive;

		// Token: 0x04000039 RID: 57
		private Timer timer = new Timer();

		// Token: 0x0400003A RID: 58
		private bool isScanning;

		// Token: 0x0400003B RID: 59
		private int tolerance = 30;
	}
}
