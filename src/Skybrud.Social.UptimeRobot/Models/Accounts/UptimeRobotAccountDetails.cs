using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Models.Accounts {
    
    /// <summary>
    /// Class representing the account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotAccountDetails : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the email address of the authenticated account.
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Gets the maximum amount of monitors allowed within the current plan.
        /// </summary>
        public int MonitorLimit { get; }

        /// <summary>
        /// Gets the lowest possible interval allowed within the current plan.
        /// </summary>
        public int MonitorInterval { get; }

        /// <summary>
        /// Gets the amount of monitors that are currently up.
        /// </summary>
        public int UpMonitors { get; }

        /// <summary>
        /// Gets the amount of monitors that are currently down.
        /// </summary>
        public int DownMonitors { get; }

        /// <summary>
        /// Gets the amount of monitors that are currently paused.
        /// </summary>
        public int PausedMonitors { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the account details.</param>
        protected UptimeRobotAccountDetails(JObject obj) : base(obj) {
            Email = obj.GetString("email");
            MonitorLimit = obj.GetInt32("monitor_limit");
            MonitorInterval = obj.GetInt32("monitor_interval");
            UpMonitors = obj.GetInt32("up_monitors");
            DownMonitors = obj.GetInt32("down_monitors");
            PausedMonitors = obj.GetInt32("paused_monitors");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <see cref="JObject"/> into an instance of <see cref="UptimeRobotAccountDetails"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotAccountDetails"/>.</returns>
        public static UptimeRobotAccountDetails Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotAccountDetails(obj);
        }

        #endregion
    
    }

}