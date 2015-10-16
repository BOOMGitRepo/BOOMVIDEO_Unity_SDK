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


		string Boom_GUID = "9c6543a6-a41e-4657-9178-84210b22d794";



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

		//Debug.Log ("string from andorid to unity(simple)" + trackEvent);





		var operationResult = JsonReader.Deserialize<OperationResult> (trackEvent);

		//Debug.Log ("Total result: " + result);
		//Debug.Log ("operation_result :::message value" + operationResult.message);
		//Debug.Log ("operation_result  :::points value" + operationResult.points);
		//Debug.Log ("operation_result :::operation code value" + operationResult.operationcode);
		//Debug.Log ("operation_result  :::result value" + operationResult.result);
		//Debug.Log ("operation_result  :::result message value" + operationResult.result_message);


		var resultmessage = (OPERATIONAL_RESULT_MESSAGES)Enum.Parse (typeof(OPERATIONAL_RESULT_MESSAGES), operationResult.result_message);

		switch(resultmessage)
		{
		case OPERATIONAL_RESULT_MESSAGES.INTERNET_UNAVAILABLE:
			Debug.Log("INTERNET UNAVAILABLE called in Unity");
			break;
		

		case OPERATIONAL_RESULT_MESSAGES.PLAYER_INITAILIZATION_ERROR:
			Debug.Log("PLAYER_INITAILIZATION_ERROR URL called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.VIDEO_FIRST_PLAY:
			Debug.Log("VIDEO_FIRST_PLAY called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.VIDEO_END_PLAY:
			Debug.Log("VIDEO_END_PLAY called in Unity");
			break;
		
		case OPERATIONAL_RESULT_MESSAGES.ANNOTATION_CLICK:
			Debug.Log("ANNOTATION_CLICK called in Unity");
			break;
		
		case OPERATIONAL_RESULT_MESSAGES.VIDEO_CALLBACK_FIRETIME_COMPLETED:
			Debug.Log("VIDEO_CALLBACK_FIRETIME_COMPLETED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.FACEBOOK_SHARE_COMPLETED:
			Debug.Log("FACEBOOK_SHARE_COMPLETED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.GOOGLE_SHARE_COMPLETED:
			Debug.Log("GOOGLE_SHARE_COMPLETED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.TWITTER_SHARE_COMPLETED:
			Debug.Log("TWITTER_SHARE_COMPLETED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.VIDEO_PAUSED:
			Debug.Log("VIDEO_PAUSED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.INSTAGRAM_URL:
			Debug.Log("INSTAGRAM_URL called in Unity");
			break;



		case OPERATIONAL_RESULT_MESSAGES.SLIDESHARE_URL:
			Debug.Log("SLIDESHARE_URL called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.SURVEY_COMPLETED:
			Debug.Log("SURVEY_COMPLETED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.BLOG_URL:
			Debug.Log("BLOG_URL called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.APP_INSTALLED:
			Debug.Log("APP_INSTALLED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.OFFER_AVAILED_ALREADY:
			Debug.Log("OFFER_AVAILED_ALREADY called in Unity");
			break;
					
		case OPERATIONAL_RESULT_MESSAGES.INTERSTITIAL_LOADED:
			Debug.Log("INTERSTITIAL_LOADED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.INTERSTITIAL_CLICKED:
			Debug.Log("INTERSTITIAL_CLICKED called in Unity");
			break;

		case OPERATIONAL_RESULT_MESSAGES.INTERSTITIAL_CLOSED:
			Debug.Log("INTERSTITIAL_CLOSED called in Unity");
			break;
		case OPERATIONAL_RESULT_MESSAGES.VIDEO_PROGRESS:
			Debug.Log("video progress called in Unity");

			int progressRule;
			int.TryParse(operationResult.result, out progressRule);

			if(progressRule == operationResult.VIDEO_COMPLETED_25P)
			{
				Debug.Log("VIDEO_COMPLETED_25P");
			}
			else if(progressRule == operationResult.VIDEO_COMPLETED_50P)
			{
				Debug.Log("VIDEO_COMPLETED_50P");
			}
			else if(progressRule == operationResult.VIDEO_COMPLETED_75P)
			{
				Debug.Log("VIDEO_COMPLETED_75P");
			}

			break;
		case OPERATIONAL_RESULT_MESSAGES.AD_VIEW_LOADED:
			Debug.Log("ad view loaded called");
			break;
		case OPERATIONAL_RESULT_MESSAGES.AD_VIEW_CLOSED:
			Debug.Log("ad view close called");
			break;
		default:
			break;
		}



	}
}