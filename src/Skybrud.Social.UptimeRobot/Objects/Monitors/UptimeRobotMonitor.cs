using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.UptimeRobot.Enums;

namespace Skybrud.Social.UptimeRobot.Objects.Monitors {
    
    /// <summary>
    /// Class representing an Uptime Robot monitor.
    /// </summary>
    public class UptimeRobotMonitor : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the monitor.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets the friendly name of the monitor.
        /// </summary>
        public string FriendlyName { get; private set; }

        /// <summary>
        /// Gets the URL of the monitor. Depending on the monitor type, this property will instead return the IP
        /// address or hostname the monitor will check.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the type of the monitor.
        /// </summary>
        public UptimeRobotMonitorType Type { get; private set; }

        /// <summary>
        /// Gets the sub type of the monitor.
        /// </summary>
        public UptimeRobotMonitorSubType SubType { get; private set; }

        /// <summary>
        /// Gets the interval of the monitor.
        /// </summary>
        public TimeSpan Interval { get; private set; }

        /// <summary>
        /// Gets the current status of the monitor.
        /// </summary>
        public UptimeRobotMonitorStatus Status { get; private set; }

        /// <summary>
        /// Gets the alltime uptime ratio of the monitor.
        /// </summary>
        public float AlltimeUptimeRatio { get; private set; }

        /// <summary>
        /// Gets an array with the log entries of the monitor, or <code>null</code> depending on the options of the
        /// request to the API.
        /// </summary>
        public UptimeRobotLogEntry[] Log { get; private set; } 

        // responsetime[]

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the monitor.</param>
        protected UptimeRobotMonitor(JObject obj) : base(obj) {
            Id = obj.GetInt32("id");
            FriendlyName = obj.GetString("friendlyname");
            Url = obj.GetString("url");
            Type = obj.GetInt32("type", ParseEnum<UptimeRobotMonitorType>);
            SubType = obj.GetInt32("type", ParseEnum<UptimeRobotMonitorSubType>);
            Interval = obj.GetInt32("interval", x => TimeSpan.FromSeconds(x));
            Status = obj.GetInt32("status", ParseEnum<UptimeRobotMonitorStatus>);
            AlltimeUptimeRatio = obj.GetFloat("alltimeuptimeratio");
            Log = obj.GetArray("log", UptimeRobotLogEntry.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>UptimeRobotMonitor</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotMonitor</code>.</returns>
        public static UptimeRobotMonitor Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotMonitor(obj);
        }

        #endregion
    
    }

}