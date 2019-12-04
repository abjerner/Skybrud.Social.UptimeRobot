using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Social.UptimeRobot.Models.Monitors;

namespace Skybrud.Social.UptimeRobot.Responses.Monitors {

    /// <summary>
    /// Class representing the response of a call to get a list of monitors of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotGetMonitorsResponse : UptimeRobotResponse<UptimeRobotMonitorsList> {

        #region Constructors

        private UptimeRobotGetMonitorsResponse(IHttpResponse response) : base(response) {

            // Validate the response
            JObject body = ValidateResponse(response);

            // Parse the response body
            Body = UptimeRobotMonitorsList.Parse(body);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="UptimeRobotGetMonitorsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotGetMonitorsResponse"/>.</returns>
        public static UptimeRobotGetMonitorsResponse ParseResponse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new UptimeRobotGetMonitorsResponse(response);
        }

        #endregion

    }

}