using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Social.UptimeRobot.Models.Accounts;

namespace Skybrud.Social.UptimeRobot.Responses.Accounts {

    /// <summary>
    /// Class representing the response of a request to get account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotGetAccountDetailsResponse : UptimeRobotResponse<UptimeRobotAccountEnvelope> {

        #region Constructors

        private UptimeRobotGetAccountDetailsResponse(IHttpResponse response) : base(response) {

            // Validate the response
            JObject body = ValidateResponse(response);

            // Parse the response body
            Body = UptimeRobotAccountEnvelope.Parse(body);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="UptimeRobotGetAccountDetailsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotGetAccountDetailsResponse"/>.</returns>
        public static UptimeRobotGetAccountDetailsResponse ParseResponse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new UptimeRobotGetAccountDetailsResponse(response);
        }

        #endregion

    }

}