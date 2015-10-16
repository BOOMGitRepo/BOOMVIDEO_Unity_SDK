using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AndroidClasses : MonoBehaviour 
{
#if UNITY_ANDROID
	private static AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
	private static AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"); 







	
	public static void openRewards_YT(string Boom_GUID)
	{
		jo.Call("openRewards_YT",Boom_GUID);
	}
	public static void openOfferlist(string Boom_GUID)
	{
		jo.Call("openOfferlist",Boom_GUID);
	}

	public static void openPreroll(string Boom_GUID)
	{
		jo.Call("openPreroll",Boom_GUID);
	}




//	void SendUnityMessage(String objectname,String methodname,String param)
//	{
//		jo.CallStatic("SendUnityMessage",objectname,methodname,param);
//		
//	}



#endif
}
