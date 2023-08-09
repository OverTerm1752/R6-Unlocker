using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SumTing_Special.Properties
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000020F5 File Offset: 0x000002F5
		internal Resources()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002463 File Offset: 0x00000663
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("SumTing_Special.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000248F File Offset: 0x0000068F
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002496 File Offset: 0x00000696
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000249E File Offset: 0x0000069E
		internal static Bitmap icons8_minimize_20
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("icons8-minimize-20", Resources.resourceCulture);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000024B9 File Offset: 0x000006B9
		internal static Bitmap icons8_x_20
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("icons8-x-20", Resources.resourceCulture);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000024D4 File Offset: 0x000006D4
		internal static Bitmap R6S
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("R6S", Resources.resourceCulture);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000024EF File Offset: 0x000006EF
		internal static Bitmap Untitled_1_
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Untitled(1)", Resources.resourceCulture);
			}
		}

		// Token: 0x04000054 RID: 84
		private static ResourceManager resourceMan;

		// Token: 0x04000055 RID: 85
		private static CultureInfo resourceCulture;
	}
}
