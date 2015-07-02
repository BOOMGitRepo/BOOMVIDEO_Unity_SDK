using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ContactListPOC
{
     //[DataContract]
	[System.Serializable]
    public class OperationResult
    {
        #region Data Members


		/*

        public static int SUCCESS = 0;
        public static int WARN = 1;
        public static int ERROR = 2;
        public static int VIDEO_NOT_COMPLETE = 3;

        public static int VIDEO_COMPLETED_25P = 40;
        public static int VIDEO_COMPLETED_50P = 50;
        public static int VIDEO_COMPLETED_75P = 60;


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
		 public string eventName{get; set;}

        //[DataMember(Name = "points")]
		public float videoPercentage { get; set;}

        //[DataMember(Name = "operationcode")]
		public int pointsRevealed { get; set;}

        //[DataMember(Name = "result")]
		// public Object result { get; set;}

  
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
		videoPlayStart, videoCompleted, VideoCompletedWithPercent, videoPaused,
		videoCompletedAsPerRule, redirectedToAnnotation, linkPostedOnFacebook,
		linkPostedOnTwitter, linkPostedOnGooglePlus, redirectedToInstallation, redirectedToSignUp,
		redirectedToSlideshare, redirectedToPurchase, redirectedToBlog, redirectedToInstagram,
		surveyCompleted, surveyNotCompleted, networkNotAvailable,
		kInterstitialLoaded, kInterstitialClosed, kInterstitialClicked, unknownError
	}
   
}
