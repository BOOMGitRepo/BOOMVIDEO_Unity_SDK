using System;
using System.Collections.Generic;
using System.Collections;

using System.IO;
using System.Linq;
//using System.Runtime.Serialization.Json;
using System.Text;


namespace ContactListPOC
{
	[System.Serializable]
    public class OperationResult
    {
        #region Data Members




        public static int SUCCESS = 0;
        public static int WARN = 1;
        public static int ERROR = 2;
        public static int VIDEO_NOT_COMPLETE = 3;

        public int VIDEO_COMPLETED_25P = 40;
        public int VIDEO_COMPLETED_50P = 50;
        public int VIDEO_COMPLETED_75P = 60;
		/*

        private int POINTS;

        private int operationalCode = SUCCESS;

        private OPERATIONAL_RESULT_MESSAGES resultMessages;

       // private TRACKING_TYPE trackingType;

        private StringBuilder message = new StringBuilder();

        private Object result = null;
*/
        #endregion

        #region Property

        //[DataMember(Name = "message")]
		 public string message{get; set;}

        //[DataMember(Name = "points")]
		 public int points { get; set;}

        //[DataMember(Name = "operationcode")]
		 public int operationcode { get; set;}

        //[DataMember(Name = "result")]
		public string result { get; set;}

		//public string trackingtype { get; set;}

		public string result_message { get; set;}

  
/*
        public void setOperationalCode(int opCode)
        {
            operationalCode = opCode;
        }

        public void setResult(Object result)
        {
            this.result = result;
        }

        public OPERATIONAL_RESULT_MESSAGES getResultMessages()
        {
            return resultMessages;
        }

        public void setResultMessages(OPERATIONAL_RESULT_MESSAGES resultMessages)
        {
            this.resultMessages = resultMessages;
        }
      
        public void setPoints(int points)
        {
            this.POINTS = points;
        }
*/
        //public TRACKING_TYPE getTrackingType()
        //{
        //    return trackingType;
        //}

        //public void setTrackingType(TRACKING_TYPE trackingType)
        //{
        //    this.trackingType = trackingType;
        //}

        #endregion

        #region Enum

        

        #endregion

    }

	public enum OPERATIONAL_RESULT_MESSAGES
	{
		INTERNET_UNAVAILABLE, UKNOWN_ERROR,
		VIDEO_UNAVAILABLE, VIDEO_ENDED, PLAYER_INITAILIZATION_ERROR,
		VIDEO_CALLBACK_FIRETIME_COMPLETED, VIDEO_FIRST_PLAY, VIDEO_END_PLAY, PURCHASE, SIGNUP,
		FACEBOOK_SHARE_COMPLETED, TWITTER_SHARE_COMPLETED, GOOGLE_SHARE_COMPLETED,
		ANNOTATION_CLICK, APP_INSTALLED, SLIDESHARE_URL, BLOG_URL, INSTAGRAM_URL, WEBSITE,
		SURVEY_COMPLETED, VIDEO_PAUSED, VIDEO_PROGRESS, OFFER_AVAILED_ALREADY,
		INTERSTITIAL_LOADED, INTERSTITIAL_CLICKED, INTERSTITIAL_CLOSED,AD_VIEW_LOADED,AD_VIEW_CLOSED
	}
}
