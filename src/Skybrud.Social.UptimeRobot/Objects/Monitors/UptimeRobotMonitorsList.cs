using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.UptimeRobot.Objects.Common;

namespace Skybrud.Social.UptimeRobot.Objects.Monitors {

    /// <summary>
    /// Class representing the response body of a call to get a list of monitors of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotMonitorsList : UptimeRobotEnvelope {

        #region Properties

        /// <summary>
        /// Gets pagination information about the list.
        /// </summary>
        public UptimeRobotPagination Pagination { get; }

        /// <summary>
        /// Gets an array of monitors of the returned page.
        /// </summary>
        public UptimeRobotMonitor[] Monitors { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the list.</param>
        protected UptimeRobotMonitorsList(JObject obj) : base(obj) {
            Pagination = obj.GetObject("pagination", UptimeRobotPagination.Parse);
            Monitors = obj.GetArrayItems("monitors", UptimeRobotMonitor.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotMonitorsList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotMonitorsList"/>.</returns>
        public static UptimeRobotMonitorsList Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotMonitorsList(obj);
        }

        #endregion

    }

}