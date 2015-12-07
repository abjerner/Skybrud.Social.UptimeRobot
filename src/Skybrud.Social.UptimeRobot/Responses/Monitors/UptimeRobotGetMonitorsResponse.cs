using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Social.UptimeRobot.Objects.Monitors;

namespace Skybrud.Social.UptimeRobot.Responses.Monitors {

    /// <summary>
    /// Class representing the response of a call to get a list of monitors of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotGetMonitorsResponse : UptimeRobotResponse<UptimeRobotGetMonitorsResponseBody> {

        #region Constructors

        private UptimeRobotGetMonitorsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>UptimeRobotGetMonitorsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotGetMonitorsResponse</code>.</returns>
        public static UptimeRobotGetMonitorsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");
            
            // Validate the response
            ValidateResponse(response);

            // Parse the JSON into an instance of JObject
            JObject xml = JObject.Parse(response.Body);

            // Initialize the response object
            return new UptimeRobotGetMonitorsResponse(response) {
                Body = UptimeRobotGetMonitorsResponseBody.Parse(xml)
            };

        }

        #endregion

    }

}