using System;
using System.Net;
using Skybrud.Social.Http;

namespace Skybrud.Social.UptimeRobot.Responses {

    /// <summary>
    /// Class representing a response from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotResponse : SocialResponse {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <code>UptimeRobotResponse</code> from the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        protected UptimeRobotResponse(SocialHttpResponse response) : base(response) { }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            throw new Exception("Oh noes!!!\n\n" + response.Body);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotResponse<T> : UptimeRobotResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <code>UptimeRobotResponse</code> from the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        protected UptimeRobotResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }

}