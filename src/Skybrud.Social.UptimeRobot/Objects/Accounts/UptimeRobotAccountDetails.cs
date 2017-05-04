using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Objects.Accounts {
    
    /// <summary>
    /// Class representing the account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotAccountDetails : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the maximum amount of monitors allowed within the current plan.
        /// </summary>
        public int MonitorLimit { get; private set; }

        /// <summary>
        /// Gets the lowest possible interval allowed within the current plan.
        /// </summary>
        public int MonitorInterval { get; private set; }

        /// <summary>
        /// Gets the amount of monitors that are currently up.
        /// </summary>
        public int UpMonitors { get; private set; }

        /// <summary>
        /// Gets the amount of monitors that are currently down.
        /// </summary>
        public int DownMonitors { get; private set; }

        /// <summary>
        /// Gets the amount of monitors that are currently paused.
        /// </summary>
        public int PausedMonitors { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the account details.</param>
        protected UptimeRobotAccountDetails(JObject obj) : base(obj) {
            MonitorLimit = obj.GetInt32("monitorLimit");
            MonitorInterval = obj.GetInt32("monitorInterval");
            UpMonitors = obj.GetInt32("upMonitors");
            DownMonitors = obj.GetInt32("downMonitors");
            PausedMonitors = obj.GetInt32("pausedMonitors");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>UptimeRobotAccountDetails</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotAccountDetails</code>.</returns>
        public static UptimeRobotAccountDetails Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotAccountDetails(obj);
        }

        #endregion
    
    }

}