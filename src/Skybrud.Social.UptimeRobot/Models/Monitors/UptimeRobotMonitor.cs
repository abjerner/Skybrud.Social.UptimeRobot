using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.UptimeRobot.Models.Monitors {
    
    /// <summary>
    /// Class representing an Uptime Robot monitor.
    /// </summary>
    public class UptimeRobotMonitor : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the monitor.
        /// </summary>
        public int Id  { get; }

        /// <summary>
        /// Gets the friendly name of the monitor.
        /// </summary>
        public string FriendlyName  { get; }

        /// <summary>
        /// Gets the URL of the monitor. Depending on the monitor type, this property will instead return the IP
        /// address or hostname the monitor will check.
        /// </summary>
        public string Url  { get; }

        /// <summary>
        /// Gets the type of the monitor.
        /// </summary>
        public UptimeRobotMonitorType Type  { get; }

        /// <summary>
        /// Gets the sub type of the monitor.
        /// </summary>
        public UptimeRobotMonitorSubType SubType  { get; }

        /// <summary>
        /// Gets the interval of the monitor.
        /// </summary>
        public TimeSpan Interval  { get; }

        /// <summary>
        /// Gets the current status of the monitor.
        /// </summary>
        public UptimeRobotMonitorStatus Status  { get; }

        /// <summary>
        /// Gets a timestamp for when the monitor was created.
        /// </summary>
        public EssentialsDateTime Created  { get; }

        /// <summary>
        /// Gets the alltime uptime ratio of the monitor.
        /// </summary>
        public float AlltimeUptimeRatio  { get; }

        /// <summary>
        /// Gets an array with the log entries of the monitor, or <c>null</c> depending on the options of the
        /// request to the API.
        /// </summary>
        public UptimeRobotLogEntry[] Logs  { get; }

        /// <summary>
        /// Gets details of about the sites SSL certificate for the monitor, or <c>null</c> depending on the options of the
        /// request to the API.
        /// </summary>
        public UptimeRobotMonitorSsl Ssl { get; }

        // responsetime[]

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the monitor.</param>
        protected UptimeRobotMonitor(JObject obj) : base(obj) {
            Id = obj.GetInt32("id");
            FriendlyName = obj.GetString("friendly_name");
            Url = obj.GetString("url");
            Type = obj.GetEnum<UptimeRobotMonitorType>("type");
            SubType = obj.GetEnum<UptimeRobotMonitorSubType>("type");
            Interval = obj.GetDouble("interval", TimeSpan.FromSeconds);
            Status = obj.GetEnum<UptimeRobotMonitorStatus>("status");
            Created = obj.GetInt32("create_datetime", EssentialsDateTime.FromUnixTimestamp);
            AlltimeUptimeRatio = obj.GetFloat("all_time_uptime_ratio");
            Logs = obj.GetArray("logs", UptimeRobotLogEntry.Parse);
            Ssl = obj.GetObject("ssl", UptimeRobotMonitorSsl.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotMonitor"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotMonitor"/>.</returns>
        public static UptimeRobotMonitor Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotMonitor(obj);
        }

        #endregion
    
    }

}