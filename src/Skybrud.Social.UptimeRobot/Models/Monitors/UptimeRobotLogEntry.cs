using System;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.UptimeRobot.Enums;

namespace Skybrud.Social.UptimeRobot.Models.Monitors {

    /// <summary>
    /// Class representing a log entry of a monitor.
    /// </summary>
    public class UptimeRobotLogEntry : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the type of the log entry.
        /// </summary>
        public UptimeRobotLogType Type  { get; }

        /// <summary>
        /// Gets the timestamp of the log entry.
        /// </summary>
        public DateTime DateTime  { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the log entry.</param>
        protected UptimeRobotLogEntry(JObject obj) : base(obj) {
            Type = obj.GetEnum<UptimeRobotLogType>("type");
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
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotLogEntry"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotLogEntry"/>.</returns>
        public static UptimeRobotLogEntry Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotLogEntry(obj);
        }

        #endregion
    
    }

}