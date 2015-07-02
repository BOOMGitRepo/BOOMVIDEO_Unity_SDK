using UnityEngine;
using System.Collections;
using System;
using ContactListPOC;
using Pathfinding.Serialization.JsonFx;

public class UnityCode : MonoBehaviour {

	// Use this for initialization
	void OnGUI() {

		if (GUI.Button (new Rect (10, 10, 200, 50), "Open Preroll"))
		{
			
			BMUnityPlugin.showPrerollView("9c6543a6-a41e-4657-9178-84210b22d794");
			
		}
		if (GUI.Button (new Rect (10, 100, 200, 50), "Open Reward"))
		{
			
			BMUnityPlugin.showRewardView("9c6543a6-a41e-4657-9178-84210b22d794");
			
		}
		if (GUI.Button (new Rect (10, 200, 200, 50), "Open Offerlist"))
		{
			
			BMUnityPlugin.showOfferlistView("9c6543a6-a41e-4657-9178-84210b22d794");
			
		}
	}

	void boomTrackerInfo(String message) {

		var operationResult = JsonReader.Deserialize<OperationResult>(message);

		Debug.Log ("eventName!-->" + operationResult.eventName);
		Debug.Log ("pointsRevealed!-->" + operationResult.pointsRevealed);
		Debug.Log ("videoPercentage!-->" + operationResult.videoPercentage);

		var resultmessage = (OPERATIONAL_RESULT_MESSAGES)Enum.Parse (typeof(OPERATIONAL_RESULT_MESSAGES), operationResult.eventName);
		
		switch(resultmessage)
		{
		case OPERATIONAL_RESULT_MESSAGES.videoPlayStart:
			Debug.Log("videoPlayStart called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.videoCompleted:
			Debug.Log("videoCompleted called in Unity");
			break;
			
			
		case OPERATIONAL_RESULT_MESSAGES.VideoCompletedWithPercent:
			Debug.Log("VideoCompletedWithPercent called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.videoPaused:
			Debug.Log("videoPaused called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.videoCompletedAsPerRule:
			Debug.Log("videoCompletedAsPerRule called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToAnnotation:
			Debug.Log("redirectedToAnnotation called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.linkPostedOnFacebook:
			Debug.Log("linkPostedOnFacebook called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.linkPostedOnTwitter:
			Debug.Log("linkPostedOnTwitter called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.linkPostedOnGooglePlus:
			Debug.Log("linkPostedOnGooglePlus called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToInstallation:
			Debug.Log("redirectedToInstallation called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToSignUp:
			Debug.Log("redirectedToSignUp called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToSlideshare:
			Debug.Log("redirectedToSlideshare called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToPurchase:
			Debug.Log("redirectedToPurchase called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToBlog:
			Debug.Log("redirectedToBlog called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.redirectedToInstagram:
			Debug.Log("redirectedToInstagram called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.surveyCompleted:
			Debug.Log("surveyCompleted called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.surveyNotCompleted:
			Debug.Log("surveyNotCompleted called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.networkNotAvailable:
			Debug.Log("networkNotAvailable called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.kInterstitialLoaded:
			Debug.Log("kInterstitialLoaded called in Unity");
			break;
			
		case OPERATIONAL_RESULT_MESSAGES.kInterstitialClosed:
			Debug.Log("kInterstitialClosed called in Unity");
			break;
		case OPERATIONAL_RESULT_MESSAGES.kInterstitialClicked:
			Debug.Log("kInterstitialClicked called in Unity");
			break;

		default:
			Debug.Log("Unknown Error Occurred");
			break;
		}

	}


}
