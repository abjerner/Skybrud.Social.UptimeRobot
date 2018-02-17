using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Social.UptimeRobot.Models.Accounts;

namespace Skybrud.Social.UptimeRobot.Responses.Accounts {

    /// <summary>
    /// Class representing the response of a request to get account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotGetAccountDetailsResponse : UptimeRobotResponse<UptimeRobotAccountEnvelope> {

        #region Constructors

        private UptimeRobotGetAccountDetailsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="UptimeRobotGetAccountDetailsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotGetAccountDetailsResponse"/>.</returns>
        public static UptimeRobotGetAccountDetailsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException(nameof(response));
            
            // Validate the response
            ValidateResponse(response);

            // Parse the JSON into an instance of JObject
            JObject xml = JObject.Parse(response.Body);

            // Initialize the response object
            return new UptimeRobotGetAccountDetailsResponse(response) {
                Body = UptimeRobotAccountEnvelope.Parse(xml)
            };

        }

        #endregion

    }

}