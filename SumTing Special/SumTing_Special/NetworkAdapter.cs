using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SumTing_Special
{
	// Token: 0x02000002 RID: 2
	public class NetworkAdapter
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public NetworkAdapter(NetworkInterface networkInterface) : this(networkInterface.Description)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002540 File Offset: 0x00000740
		private NetworkAdapter(string name)
		{
			this._AdapterName = name;
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE Name='" + this._AdapterName + "'").Get();
			this._Adapter = Enumerable.FirstOrDefault<ManagementObject>(Enumerable.Cast<ManagementObject>(managementObjectCollection));
			try
			{
				Match match = Regex.Match(this._Adapter.Path.RelativePath, "\\\"(\\d+)\\\"$");
				this._DeviceNumber = int.Parse(match.Groups[1].Value);
			}
			catch
			{
				return;
			}
			this._CustomName = Enumerable.FirstOrDefault<string>(Enumerable.Select<NetworkInterface, string>(Enumerable.Where<NetworkInterface>(NetworkInterface.GetAllNetworkInterfaces(), (NetworkInterface o) => o.Description == this._AdapterName), (NetworkInterface o) => " (" + o.Name + ")"));
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002065 File Offset: 0x00000265
		private NetworkInterface ManagedAdapter
		{
			get
			{
				return Enumerable.FirstOrDefault<NetworkInterface>(Enumerable.Where<NetworkInterface>(NetworkInterface.GetAllNetworkInterfaces(), (NetworkInterface ani) => ani.Description == this._AdapterName));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000261C File Offset: 0x0000081C
		public string PhysicalAddress
		{
			get
			{
				string result;
				try
				{
					result = BitConverter.ToString(this.ManagedAdapter.GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
		private string RegistryKey
		{
			get
			{
				return string.Format("SYSTEM\\ControlSet001\\Control\\Class\\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\\{0:D4}", this._DeviceNumber);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000266C File Offset: 0x0000086C
		public string RegistryPhysicalAddress
		{
			get
			{
				string result;
				try
				{
					using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.RegistryKey, false))
					{
						string text;
						if (registryKey == null)
						{
							text = null;
						}
						else
						{
							object value = registryKey.GetValue("NetworkAddress");
							text = ((value != null) ? value.ToString() : null);
						}
						result = text;
					}
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000026D8 File Offset: 0x000008D8
		public bool SetRegistryPhysicalAddress(string value, string title)
		{
			bool flag = false;
			bool result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.RegistryKey, true))
				{
					if (registryKey == null)
					{
						throw new Exception("Registry Key Failed to Open");
					}
					if (registryKey.GetValue("AdapterModel") as string != this._AdapterName && registryKey.GetValue("DriverDesc") as string != this._AdapterName)
					{
						throw new Exception("Adapter Not Found in Registry!");
					}
					if ((uint)this._Adapter.InvokeMethod("Disable", null) != 0U)
					{
						throw new Exception("Adapter Could Not Be Disabled!");
					}
					flag = true;
					if (value.Length > 0)
					{
						registryKey.SetValue("NetworkAddress", value, RegistryValueKind.String);
					}
					else if (!string.IsNullOrEmpty(registryKey.GetValue("NetworkAddress") as string))
					{
						registryKey.DeleteValue("NetworkAddress");
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				result = false;
			}
			finally
			{
				if (flag && (uint)this._Adapter.InvokeMethod("Enable", null) != 0U)
				{
					MessageBox.Show("Adapter Could Not Be Reactivated!");
				}
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002099 File Offset: 0x00000299
		public override string ToString()
		{
			return this._AdapterName + this._CustomName;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002818 File Offset: 0x00000A18
		public static string GenerateRandomMAC()
		{
			Random random = new Random();
			byte[] array = new byte[6];
			random.NextBytes(array);
			array[0] = (array[0] | 2);
			array[0] = (array[0] & 254);
			return NetworkAdapter.ConvertMACToString(array);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002854 File Offset: 0x00000A54
		public static bool IsValidMAC(string mac, bool actual)
		{
			if (mac.Length != 12)
			{
				return false;
			}
			if (mac != mac.ToUpper())
			{
				return false;
			}
			if (!Regex.IsMatch(mac, "^[0-9A-F]*$"))
			{
				return false;
			}
			if (actual)
			{
				return true;
			}
			char c = mac[1];
			return c == 'A' || c == 'E' || c == '2' || c == '6';
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020AC File Offset: 0x000002AC
		public static bool IsValidMAC(byte[] bytes, bool actual)
		{
			return NetworkAdapter.IsValidMAC(NetworkAdapter.ConvertMACToString(bytes), actual);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BA File Offset: 0x000002BA
		private static string ConvertMACToString(byte[] bytes)
		{
			return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
		}

		// Token: 0x04000001 RID: 1
		private readonly ManagementObject _Adapter;

		// Token: 0x04000002 RID: 2
		private readonly string _AdapterName;

		// Token: 0x04000003 RID: 3
		private readonly string _CustomName;

		// Token: 0x04000004 RID: 4
		private readonly int _DeviceNumber;
	}
}
