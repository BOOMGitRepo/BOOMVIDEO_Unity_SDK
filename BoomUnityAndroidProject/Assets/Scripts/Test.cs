using System;
using UnityEngine;
using System.Collections;
using ContactListPOC;
using Pathfinding.Serialization.JsonFx;


public class Test : MonoBehaviour {

	public GUIText guiText;
	

	// Use this for initialization
	void OnGUI () 
	{



		//string Boom_GUID = "3207f013-1626-4cd7-9ad7-1905af309013";

		//string Boom_GUID = "8f3907b7-5e6c-47c1-b6db-acbcfb061b4c";

		string Boom_GUID = "91db1880-af5b-4ac9-aab4-a097b5becf3d";


		if(GUI.Button(new Rect(10,10,200,50),"Open Offerlist "))
		{

			AndroidClasses.openOfferlist(Boom_GUID);
		}

		if(GUI.Button(new Rect(10,200,200,50),"Open Preroll "))
		{


			AndroidClasses.openPreroll(Boom_GUID);
		}

		if(GUI.Button(new Rect(10,300,200,50),"Open Rewards"))
		{


			AndroidClasses.openRewards_YT(Boom_GUID);
		}
	
	}

	void sendTrackEvent(string trackEvent)
	{

		var operationResult = JsonReader.Deserialize<OperationResult> (trackEvent);

		

		var resultmessage = (OPERATIONAL_RESULT_MESSAGES)Enum.Parse (typeof(OPERATIONAL_RESULT_MESSAGES), operationResult.result_message);

		switch(resultmessage)
		{
		
		case OPERATIONAL_RESULT_MESSAGES.AD_VIEW_LOADED:
			Debug.Log("ad view load called");
			break;
		case OPERATIONAL_RESULT_MESSAGES.AD_FAILED:
			//Debug.Log("ad view fail called "+operationResult.error_type);
			break;
		case OPERATIONAL_RESULT_MESSAGES.POINTS_REVEALED:
			Debug.Log("points revealed called "+operationResult.points);
			break;
		case OPERATIONAL_RESULT_MESSAGES.SUCCESSFUL_SHARED_ON_FACEBOOK:
			Debug.Log("facebook shared called");

			break;
		case OPERATIONAL_RESULT_MESSAGES.SUCCESSFUL_SHARED_ON_GOOGLEPLUS:
			Debug.Log("google plus shared called");
			break;
		case OPERATIONAL_RESULT_MESSAGES.SUCCESSFUL_SHARED_ON_TWITTER:
			Debug.Log("twitter share called");
			break;
		case OPERATIONAL_RESULT_MESSAGES.AD_VIEW_CLOSED:
			Debug.Log("ad view close called");
			break;
			
		default:
			break;
		
		}



	}
}