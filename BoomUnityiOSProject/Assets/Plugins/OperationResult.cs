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

		public string errorDescription { get; set;}

		public string errorInfo { get; set;}

		public int pointsRevealed { get; set;}

        #endregion

	}

	public enum OPERATIONAL_RESULT_MESSAGES
	{
		adViewLoaded,
		adViewClosed,
		pointsRevealed,
		linkPostedOnFacebook,
		linkPostedOnTwitter,
		linkPostedOnGooglePlus,
		adFailed
	}
   
}
