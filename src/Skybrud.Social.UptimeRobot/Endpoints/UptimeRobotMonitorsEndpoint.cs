using Skybrud.Social.UptimeRobot.Endpoints.Raw;
using Skybrud.Social.UptimeRobot.Options;
using Skybrud.Social.UptimeRobot.Responses.Monitors;

namespace Skybrud.Social.UptimeRobot.Endpoints {

    /// <summary>
    /// Class representing the implementation of the <strong>Monitors</strong> endpoint.
    /// </summary>
    public class UptimeRobotMonitorsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Uptime Robot service.
        /// </summary>
        public UptimeRobotService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public UptimeRobotMonitorsRawEndpoint Raw => Service.Client.Monitors;

        #endregion

        #region Constructors

        internal UptimeRobotMonitorsEndpoint(UptimeRobotService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of monitors.
        /// </summary>
        /// <returns>An instance of <see cref="UptimeRobotGetMonitorsResponse"/> representing the response.</returns>
        public UptimeRobotGetMonitorsResponse GetMonitors() {
            return UptimeRobotGetMonitorsResponse.ParseResponse(Raw.GetMonitors());
        }

        /// <summary>
        /// Gets a list of monitors matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="UptimeRobotGetMonitorsResponse"/> representing the response.</returns>
        public UptimeRobotGetMonitorsResponse GetMonitors(UptimeRobotGetMonitorsOptions options) {
            return UptimeRobotGetMonitorsResponse.ParseResponse(Raw.GetMonitors(options));
        }

        #endregion

    }

}