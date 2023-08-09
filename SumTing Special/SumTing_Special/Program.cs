using System;
using System.Windows.Forms;

namespace SumTing_Special
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000221E File Offset: 0x0000041E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
