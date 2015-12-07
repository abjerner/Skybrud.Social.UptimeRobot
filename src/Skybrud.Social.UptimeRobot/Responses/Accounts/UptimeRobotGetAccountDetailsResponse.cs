using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Social.UptimeRobot.Objects.Accounts;

namespace Skybrud.Social.UptimeRobot.Responses.Accounts {

    /// <summary>
    /// Class representing the response of a call to get account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotGetAccountDetailsResponse : UptimeRobotResponse<UptimeRobotAccountResponseBody> {

        #region Constructors

        private UptimeRobotGetAccountDetailsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>UptimeRobotGetAccountDetailsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotGetAccountDetailsResponse</code>.</returns>
        public static UptimeRobotGetAccountDetailsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");
            
            // Validate the response
            ValidateResponse(response);

            // Parse the JSON into an instance of JObject
            JObject xml = JObject.Parse(response.Body);

            // Initialize the response object
            return new UptimeRobotGetAccountDetailsResponse(response) {
                Body = UptimeRobotAccountResponseBody.Parse(xml)
            };

        }

        #endregion

    }

}