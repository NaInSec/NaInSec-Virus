using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace NaInSec_Virus.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{

			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						((WindowsFormsApplicationBase)MyProject.Application).Shutdown += (ShutdownEventHandler)([DebuggerNonUserCode] [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
						{
							if (((WindowsFormsApplicationBase)MyProject.Application).SaveMySettingsOnExit)
							{
								((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
							}
						});
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int Setting
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this)["Setting"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["Setting"] = value;
		}
	}

	[DefaultSettingValue("3")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int tryre
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this)["tryre"]);
		}
		set
		{
			((ApplicationSettingsBase)this)["tryre"] = value;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.Application).SaveMySettingsOnExit)
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
