using System;
using Skybrud.Social.Http;
using Skybrud.Social.UptimeRobot.Options;

namespace Skybrud.Social.UptimeRobot.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the monitors endpoint.
    /// </summary>
    public class UptimeRobotMonitorsRawEndpoint {

        #region Properties
        
        /// <summary>
        /// Gets a reference to the Uptime Robot client.
        /// </summary>
        public UptimeRobotClient Client { get; }

        #endregion

        #region Constructors

        internal UptimeRobotMonitorsRawEndpoint(UptimeRobotClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of monitors.
        /// </summary>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetMonitors() {
            return Client.DoHttpPostRequest("https://api.uptimerobot.com/v2/getMonitors");
        }

        /// <summary>
        /// Gets a list of monitors matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetMonitors(UptimeRobotGetMonitorsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("https://api.uptimerobot.com/v2/getMonitors", options);
        }

        #endregion

    }

}