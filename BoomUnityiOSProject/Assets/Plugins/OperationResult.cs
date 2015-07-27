using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ContactListPOC
{
	[System.Serializable]
    public class OperationResult
    {
        #region Property

		public string eventName{get; set;}

		public float videoPercentage { get; set;}

		public int pointsRevealed { get; set;}

        #endregion

	}

	public enum OPERATIONAL_RESULT_MESSAGES
	{
		videoPlayStart, videoCompleted, videoCompletedWithPercent, adViewClosed, adViewLoaded, videoPaused,
		videoCompletedAsPerRule, redirectedToAnnotation, linkPostedOnFacebook,
		linkPostedOnTwitter, linkPostedOnGooglePlus, redirectedToInstallation, redirectedToSignUp,
		redirectedToSlideshare, redirectedToPurchase, redirectedToBlog, redirectedToInstagram,
		surveyCompleted, surveyNotCompleted, networkNotAvailable,
		kInterstitialLoaded, kInterstitialClosed, kInterstitialClicked, unknownError
	}
   
}
