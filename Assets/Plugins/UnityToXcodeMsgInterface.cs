using UnityEngine;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#if UNITY_IPHONE
public class UnityToXcodeMsgInterface : MonoBehaviour {

	[DllImport("__Internal")] 
	private static extern void _BuyProductByID (string szProductID, int nQuantity, string szUid);
	public static void BuyProductByID (string szProductID, int nQuantity, string szUid)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
		{
			_BuyProductByID(szProductID, nQuantity, szUid);
		}
	}
	
	[DllImport("__Internal")] 
	private static extern void _ReceivePaymentResult(int nResult, string szAppleReceipt, int nSize);
	public static void ReceivePaymentResult(int nResult, string szAppleReceipt, int nSize)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
		{
			_ReceivePaymentResult(nResult, szAppleReceipt, nSize);
		}
	}
	
	[DllImport("__Internal")] 
	private static extern void _CheckHistoryReceipt();
	public static void CheckHistoryReceipt()
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
		{
			_CheckHistoryReceipt();
		}
	}
}
#endif
