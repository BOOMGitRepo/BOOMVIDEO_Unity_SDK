using UnityEngine;
using System.Collections;
using System;

using System.Runtime.InteropServices;

public class BMUnityPlugin : MonoBehaviour {

	[System.Runtime.InteropServices.DllImport("__Internal")]
	extern static public void showPrerollView(string boomGuid);
	//Sends message to iOS
	static void openPreroll()
	{
		showPrerollView("boom");
	}
	
	[System.Runtime.InteropServices.DllImport("__Internal")]
	extern static public void showRewardView(string boomGuid);
	//Sends message to iOS
	static void openReward()
	{
		showRewardView("boom");
	}
	
	[System.Runtime.InteropServices.DllImport("__Internal")]
	extern static public void showOfferlistView(string boomGuid);
	//Sends message to iOS
	static void openOfferlist()
	{
		showOfferlistView("boom");
	}
}
