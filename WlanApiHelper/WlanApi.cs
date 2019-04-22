using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WlanApiHelper
{

    public static class WlanApi
    {
		/* 文档：https://docs.microsoft.com/en-us/windows/desktop/api/wlanapi/ */

		[DllImport("Wlanapi.dll", EntryPoint = "WlanOpenHandle")]
		public static extern int WlanOpenHandle(
			[In] UInt32 dwClientVersion,
			[In, Out] IntPtr pReserved,
			[Out] out UInt32 pdwNegotiatedVersion,
			[Out] out IntPtr phClientHandle);

		[DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkInitSettings")]
		public static extern Int32 WlanHostedNetworkInitSettings(
			[In] IntPtr hClientHandle,
			[Out] out _WLAN_HOSTED_NETWORK_REASON pFailReason,
			IntPtr pvReserved);

		[DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkSetProperty")]
		public static extern int WlanHostedNetworkSetProperty(
			  [In] IntPtr clientHandle,
			  [In] _WLAN_HOSTED_NETWORK_OPCODE OpCode,
			  [In] UInt32 DataSize,
			  [In] IntPtr Data,
			  [Out] out _WLAN_HOSTED_NETWORK_REASON FailReason,
			  IntPtr reservedPtr);

		[DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkForceStart")]
		public static extern Int32 WlanHostedNetworkForceStart(
			IntPtr hClientHandle,
			out _WLAN_HOSTED_NETWORK_REASON pFailReason,
			IntPtr pvReserved);

		[DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkForceStop")]
		public static extern Int32 WlanHostedNetworkForceStop(
			[In] IntPtr hClientHandle,
			[Out] out _WLAN_HOSTED_NETWORK_REASON pFailReason,
			IntPtr pvReserved);

		[DllImport("Wlanapi.dll", EntryPoint = "WlanCloseHandle")]
		public static extern int WlanCloseHandle(
			[In] IntPtr hClientHandle,
			IntPtr pvReserved);

		[DllImport("wlanapi.dll", EntryPoint = "WlanHostedNetworkSetSecondaryKey")]
		public static extern int WlanHostedNetworkSetSecondaryKey(
		   [In] IntPtr clientHandle,
		   [In] uint dwKeyLength,
		   [In] IntPtr data,
		   [In] bool IsPassPhrase,
		   [In] bool Persistent,
		   [Out] out _WLAN_HOSTED_NETWORK_REASON FailReason,
		   IntPtr reservedPtr);

		public static _DOT11_SSID Create_DOT11_SSID(string SSID)
		{
			byte[] B = new byte[32];
			Encoding.UTF8.GetBytes(SSID, 0, SSID.Length, B, 0);
			return new _DOT11_SSID() { ucSSID = B, uSSIDLength = (uint)B.Length };

		}

	}
	public enum _WLAN_HOSTED_NETWORK_OPCODE
	{
		wlan_hosted_network_opcode_connection_settings,
		wlan_hosted_network_opcode_security_settings,
		wlan_hosted_network_opcode_station_profile,
		wlan_hosted_network_opcode_enable,
		v1_enum
	};

	public enum _WLAN_HOSTED_NETWORK_REASON
	{
		wlan_hosted_network_reason_success,
		wlan_hosted_network_reason_unspecified,
		wlan_hosted_network_reason_bad_parameters,
		wlan_hosted_network_reason_service_shutting_down,
		wlan_hosted_network_reason_insufficient_resources,
		wlan_hosted_network_reason_elevation_required,
		wlan_hosted_network_reason_read_only,
		wlan_hosted_network_reason_persistence_failed,
		wlan_hosted_network_reason_crypt_error,
		wlan_hosted_network_reason_impersonation,
		wlan_hosted_network_reason_stop_before_start,
		wlan_hosted_network_reason_interface_available,
		wlan_hosted_network_reason_interface_unavailable,
		wlan_hosted_network_reason_miniport_stopped,
		wlan_hosted_network_reason_miniport_started,
		wlan_hosted_network_reason_incompatible_connection_started,
		wlan_hosted_network_reason_incompatible_connection_stopped,
		wlan_hosted_network_reason_user_action,
		wlan_hosted_network_reason_client_abort,
		wlan_hosted_network_reason_ap_start_failed,
		wlan_hosted_network_reason_peer_arrived,
		wlan_hosted_network_reason_peer_departed,
		wlan_hosted_network_reason_peer_timeout,
		wlan_hosted_network_reason_gp_denied,
		wlan_hosted_network_reason_service_unavailable,
		wlan_hosted_network_reason_device_change,
		wlan_hosted_network_reason_properties_change,
		wlan_hosted_network_reason_virtual_station_blocking_use,
		wlan_hosted_network_reason_service_available_on_virtual_station,
		v1_enum
	};
	[StructLayout(LayoutKind.Sequential)]
	public struct _WLAN_HOSTED_NETWORK_CONNECTION_SETTINGS
	{
		public _DOT11_SSID hostedNetworkSSID;
		public int dwMaxNumberOfPeers;
	};
	[StructLayout(LayoutKind.Sequential)]
	public struct _DOT11_SSID
	{
		public uint uSSIDLength;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] ucSSID;
	};
}
