using System;
using System.Net;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Exceptions;
using Skybrud.Social.UptimeRobot.Models.Errors;

namespace Skybrud.Social.UptimeRobot.Exceptions {
    
    /// <summary>
    /// Class representing an exception/error returned by the Uptime Robot API.
    /// </summary>
    public class UptimeRobotHttpException : Exception, IHttpException {

        #region Properties

        /// <inheritdoc />
        public IHttpResponse Response { get; }

        /// <inheritdoc />
        public HttpStatusCode StatusCode => Response.StatusCode;

        /// <summary>
        /// Gets a reference to the error returned by the API.
        /// </summary>
        public UptimeRobotError Error { get; }

        #endregion

        #region Constructors

        internal UptimeRobotHttpException(IHttpResponse response) : this(response, null) {
            Response = response;
        }

        internal UptimeRobotHttpException(IHttpResponse response, UptimeRobotError error) : base("Invalid response received from the Uptime Robot API") {
            Response = response;
            Error = error;
        }

        #endregion

    }

}