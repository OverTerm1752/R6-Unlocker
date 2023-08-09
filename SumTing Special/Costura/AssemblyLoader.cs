using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x0200000C RID: 12
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000252F File Offset: 0x0000072F
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006088 File Offset: 0x00004288
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000060F8 File Offset: 0x000042F8
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000612C File Offset: 0x0000432C
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				Stream result;
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, 0))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						result = memoryStream;
					}
				}
				return result;
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000061B8 File Offset: 0x000043B8
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000061D8 File Offset: 0x000043D8
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006200 File Offset: 0x00004400
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000062C0 File Offset: 0x000044C0
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				object obj2 = AssemblyLoader.nullCacheLock;
				lock (obj2)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006398 File Offset: 0x00004598
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("casbin", "costura.casbin.dll.compressed");
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("csvhelper", "costura.csvhelper.dll.compressed");
			AssemblyLoader.assemblyNames.Add("darkui", "costura.darkui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("dotnet.glob", "costura.dotnet.glob.dll.compressed");
			AssemblyLoader.assemblyNames.Add("dynamicexpresso.core", "costura.dynamicexpresso.core.dll.compressed");
			AssemblyLoader.assemblyNames.Add("guna.ui2", "costura.guna.ui2.dll.compressed");
			AssemblyLoader.assemblyNames.Add("hzh_controls", "costura.hzh_controls.dll.compressed");
			AssemblyLoader.assemblyNames.Add("lithiumui", "costura.lithiumui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.bcl.hashcode", "costura.microsoft.bcl.hashcode.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.dependencyinjection.abstractions", "costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.dependencyinjection", "costura.microsoft.extensions.dependencyinjection.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.logging.abstractions", "costura.microsoft.extensions.logging.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.logging", "costura.microsoft.extensions.logging.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.options", "costura.microsoft.extensions.options.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.primitives", "costura.microsoft.extensions.primitives.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.visualstudio.debuggervisualizers", "costura.microsoft.visualstudio.debuggervisualizers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("mintui", "costura.mintui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("realtaiizor", "costura.realtaiizor.dll.compressed");
			AssemblyLoader.assemblyNames.Add("siticone.ui", "costura.siticone.ui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.collections.immutable", "costura.system.collections.immutable.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.interactive.async", "costura.system.interactive.async.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.linq.async", "costura.system.linq.async.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.reactive", "costura.system.reactive.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
			AssemblyLoader.assemblyNames.Add("yamldotnet", "costura.yamldotnet.dll.compressed");
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000668C File Offset: 0x0000488C
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x04000057 RID: 87
		private static object nullCacheLock = new object();

		// Token: 0x04000058 RID: 88
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x04000059 RID: 89
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x0400005A RID: 90
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x0400005B RID: 91
		private static int isAttached;
	}
}
