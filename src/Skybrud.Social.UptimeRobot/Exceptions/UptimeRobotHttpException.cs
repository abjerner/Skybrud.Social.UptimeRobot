using System;
using Skybrud.Social.Http;
using Skybrud.Social.UptimeRobot.Models.Errors;

namespace Skybrud.Social.UptimeRobot.Exceptions {
    
    /// <summary>
    /// Class representing an exception/error returned by the Uptime Robot API.
    /// </summary>
    public class UptimeRobotHttpException : Exception {
        
        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>.
        /// </summary>
        public SocialHttpResponse Response { get; }

        /// <summary>
        /// Gets a reference to the error returned by the API.
        /// </summary>
        public UptimeRobotError Error { get; }

        #endregion

        #region Constructors

        internal UptimeRobotHttpException(SocialHttpResponse response) : this(response, null) {
            Response = response;
        }

        internal UptimeRobotHttpException(SocialHttpResponse response, UptimeRobotError error) : base("Invalid response received from the Uptime Robot API") {
            Response = response;
            Error = error;
        }

        #endregion

    }

}