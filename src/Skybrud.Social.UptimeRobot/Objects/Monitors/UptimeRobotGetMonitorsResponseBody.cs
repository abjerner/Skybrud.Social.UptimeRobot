using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Objects.Monitors {

    /// <summary>
    /// Class representing the response body of a call to get a list of monitors of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotGetMonitorsResponseBody : UptimeRobotResponseBody {

        #region Properties

        /// <summary>
        /// Gets the offset of the returned page.
        /// </summary>
        public int Offset { get; private set; }

        /// <summary>
        /// Gets the limit of the returned page.
        /// </summary>
        public int Limit { get; private set; }

        /// <summary>
        /// Gets the total amount of monitors of the current user.
        /// </summary>
        public int Total { get; private set; }

        /// <summary>
        /// Gets an array of monitors of the returned page.
        /// </summary>
        public UptimeRobotMonitor[] Monitors { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the response body.</param>
        protected UptimeRobotGetMonitorsResponseBody(JObject obj) : base(obj) {
            Offset = obj.GetInt32("offset");
            Limit = obj.GetInt32("limit");
            Total = obj.GetInt32("total");
            Monitors = obj.GetObject("monitors").GetArray("monitor", UptimeRobotMonitor.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>UptimeRobotGetMonitorsResponseBody</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotGetMonitorsResponseBody</code>.</returns>
        public static UptimeRobotGetMonitorsResponseBody Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotGetMonitorsResponseBody(obj);
        }

        #endregion

    }

}