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
        public UptimeRobotClient Client { get; private set; }

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
            return Client.DoHttpGetRequest("https://api.uptimerobot.com/getMonitors");
        }

        /// <summary>
        /// Gets a list of monitors matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetMonitors(UptimeRobotGetMonitorsOptions options) {
            return Client.DoHttpGetRequest("https://api.uptimerobot.com/getMonitors", options);
        }

        #endregion

    }

}