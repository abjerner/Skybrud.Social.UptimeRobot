using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Models.Monitors {

    /// <summary>
    /// Class representing the reason of a log entry of a monitor.
    /// </summary>
    public class UptimeRobotLogEntryReason : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the code of the log entry.
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// Gets a text representing the status of the log entry.
        /// </summary>
        public string Detail  { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the log entry.</param>
        protected UptimeRobotLogEntryReason(JObject obj) : base(obj) {
            Code = obj.GetInt32("code");
            Detail = obj.GetString("detail");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotLogEntryReason"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotLogEntryReason"/>.</returns>
        public static UptimeRobotLogEntryReason Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotLogEntryReason(obj);
        }

        #endregion
    
    }

}