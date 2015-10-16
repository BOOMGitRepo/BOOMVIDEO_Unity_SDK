using UnityEngine;
using System.Collections;
using System;
using ContactListPOC;
using Pathfinding.Serialization.JsonFx;

public class UnityCode : MonoBehaviour {

	// Use this for initialization
	void OnGUI() {

		if (GUI.Button (new Rect (10, 200, 500, 50), "Preroll 84b753b7-6e99-4502-bb38-915ea6c9e98a"))
		{
			
			BMUnityPlugin.showPrerollView("84b753b7-6e99-4502-bb38-915ea6c9e98a");
			
		}

		if (GUI.Button (new Rect (10, 500, 500, 50), "Reward 9c6543a6-a41e-4657-9178-84210b22d794"))
		{
			
			BMUnityPlugin.showRewardView("9c6543a6-a41e-4657-9178-84210b22d794");
			
		}

		if (GUI.Button (new Rect (10, 700, 500, 50), "Offerlist 9c6543a6-a41e-4657-9178-84210b22d794"))
		{
			
			BMUnityPlugin.showOfferlistView("9c6543a6-a41e-4657-9178-84210b22d794");
			
		}
	}

	void boomTrackerInfo(String message) {

		var operationResult = JsonReader.Deserialize<OperationResult>(message);

		Debug.Log ("eventName!-->" + operationResult.eventName);
		Debug.Log ("pointsRevealed!-->" + operationResult.pointsRevealed);
		Debug.Log ("errorName!-->" + operationResult.errorInfo);

		var resultmessage = (OPERATIONAL_RESULT_MESSAGES)Enum.Parse (typeof(OPERATIONAL_RESULT_MESSAGES), operationResult.eventName);
		
		switch(resultmessage)
		{

			//*  RECOMMENDED CALLBACKS  *//
		case OPERATIONAL_RESULT_MESSAGES.adViewLoaded:
			Debug.Log("adViewLoaded called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.adViewClosed:
			Debug.Log("adViewClosed called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.pointsRevealed:
			Debug.Log("points revealed called in Unity");
			int points = operationResult.pointsRevealed;
			Debug.Log("Points->" + points);
			break;

		case OPERATIONAL_RESULT_MESSAGES.adFailed:
			Debug.Log("ad Failed to load called in Unity");
			string errorName = operationResult.errorInfo;
			Debug.Log("Error->" + errorName);
			break;
			//*  OPTIONAL CALLBACKS  *//
		case OPERATIONAL_RESULT_MESSAGES.linkPostedOnFacebook:
			Debug.Log("linkPostedOnFacebook called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.linkPostedOnTwitter:
			Debug.Log("linkPostedOnTwitter called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.linkPostedOnGooglePlus:
			Debug.Log("linkPostedOnGooglePlus called in Unity");
			break;

		default:
			Debug.Log("Unknown Error Occurred");
			break;
		}

	}


}
