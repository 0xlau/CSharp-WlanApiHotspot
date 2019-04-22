using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WlanApiHelper;

namespace CSharpWlanApi
{
	public partial class WinMain : Form
	{

		private IntPtr WlanHANDLE = IntPtr.Zero;
		private UInt32 CurVerison = 0;
		private _WLAN_HOSTED_NETWORK_REASON FailReason;
		public uint isAllow = 1;

		public WinMain()
		{

			InitializeComponent();
		}
		
		private void button_Start_Click(object sender, EventArgs e)
		{
			_WLAN_HOSTED_NETWORK_CONNECTION_SETTINGS WHNCS = new _WLAN_HOSTED_NETWORK_CONNECTION_SETTINGS
			{
				hostedNetworkSSID = WlanApi.Create_DOT11_SSID(textBox_SSID.Text),
				dwMaxNumberOfPeers = 1
			};
			WlanApi.WlanOpenHandle(2, IntPtr.Zero, out CurVerison, out WlanHANDLE);
			WlanApi.WlanHostedNetworkInitSettings(WlanHANDLE, out FailReason, IntPtr.Zero);

			IntPtr data = Marshal.AllocHGlobal(Marshal.SizeOf(WHNCS));
			Marshal.StructureToPtr(WHNCS, data, false);

			WlanApi.WlanHostedNetworkSetProperty(WlanHANDLE,
				_WLAN_HOSTED_NETWORK_OPCODE.wlan_hosted_network_opcode_connection_settings,
				(uint) Marshal.SizeOf(WHNCS), 
				data, out FailReason, IntPtr.Zero);

			byte[] B = Encoding.Default.GetBytes(textBox_PassWord.Text);

			IntPtr key_Ptr = Marshal.AllocHGlobal(B.Length + 1);

			for (int c = 0; c < B.Length; c++)
			{
				Marshal.WriteByte(key_Ptr, c, B[c]);
			}

			Marshal.WriteByte(key_Ptr, B.Length, 0);
			WlanApi.WlanHostedNetworkSetSecondaryKey(WlanHANDLE,
				(uint) B.Length + 1,
				key_Ptr, true, false , out FailReason, IntPtr.Zero
				);

				WlanApi.WlanHostedNetworkForceStart(WlanHANDLE, out FailReason, IntPtr.Zero);
			WlanApi.WlanCloseHandle(WlanHANDLE, IntPtr.Zero);
		}

		private void button_Stop_Click(object sender, EventArgs e)
		{
			WlanApi.WlanOpenHandle(2, IntPtr.Zero, out CurVerison, out WlanHANDLE);
			WlanApi.WlanHostedNetworkForceStop(WlanHANDLE, out FailReason, IntPtr.Zero);
			WlanApi.WlanCloseHandle(WlanHANDLE, IntPtr.Zero);
		}
	}
}
