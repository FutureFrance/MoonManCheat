using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TheMoonManCheat.Properties
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	internal class Resources
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002175 File Offset: 0x00000375
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00004440 File Offset: 0x00002640
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("TheMoonManCheat.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004480 File Offset: 0x00002680
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000217D File Offset: 0x0000037D
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004494 File Offset: 0x00002694
		internal static Bitmap bhop
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("bhop", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000044C0 File Offset: 0x000026C0
		internal static Bitmap moon__1_
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("moon (1)", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000044EC File Offset: 0x000026EC
		internal static Bitmap moonder
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("moonder", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400003F RID: 63
		private static ResourceManager resourceMan;

		// Token: 0x04000040 RID: 64
		private static CultureInfo resourceCulture;
	}
}
