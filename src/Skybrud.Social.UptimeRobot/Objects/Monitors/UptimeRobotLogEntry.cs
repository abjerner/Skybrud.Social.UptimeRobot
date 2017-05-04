using System;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.UptimeRobot.Enums;

namespace Skybrud.Social.UptimeRobot.Objects.Monitors {

    /// <summary>
    /// Class representing a log entry of a monitor.
    /// </summary>
    public class UptimeRobotLogEntry : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the type of the log entry.
        /// </summary>
        public UptimeRobotLogType Type { get; private set; }

        /// <summary>
        /// Gets the timestamp of the log entry.
        /// </summary>
        public DateTime DateTime { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the log entry.</param>
        protected UptimeRobotLogEntry(JObject obj) : base(obj) {
            Type = obj.GetInt32("type", ParseEnum<UptimeRobotLogType>);
            DateTime = obj.GetString("datetime", ParseDate);
        }

        #endregion

        #region Member methods

        private DateTime ParseDate(string str) {
            try {
                return DateTime.ParseExact(str, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            } catch (Exception) {
                throw new Exception("Unable to parse date " + str);
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>UptimeRobotLogEntry</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotLogEntry</code>.</returns>
        public static UptimeRobotLogEntry Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotLogEntry(obj);
        }

        #endregion
    
    }

}