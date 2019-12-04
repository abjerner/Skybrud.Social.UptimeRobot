using System;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Models.Monitors
{

    /// <summary>
    /// Class representing a log entry of a monitor.
    /// </summary>
    public class UptimeRobotMonitorSsl : UptimeRobotObject
    {

        #region Properties

        /// <summary>
        /// Gets the SSL brand name for the Monitor.
        /// </summary>
        public string Brand { get; }

        /// <summary>
        /// Gets the SSL product name for the Monitor.
        /// </summary>
        public string Product { get; }

        /// <summary>
        /// Gets the SSL ignore_errors setting for the Monitor.
        /// </summary>
        public bool IgnoreErrors { get; }

        /// <summary>
        /// Gets the SSL disable_notifications setting for the Monitor.
        /// </summary>
        public bool DisableNotifications { get; }

        /// <summary>
        /// Gets the expiration date of the SSL certificate. 
        /// </summary>
        public DateTime Expires { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the log entry.</param>
        protected UptimeRobotMonitorSsl(JObject obj) : base(obj)
        {
            Brand = obj.GetString("brand");
            Product = obj.GetString("product");
            Expires = obj.GetInt64("expires", ParseDate);
            IgnoreErrors = obj.GetBoolean("ignore_errors");
            DisableNotifications = obj.GetBoolean("disable_notifications");
        }

        #endregion

        #region Member methods

        private DateTime ParseDate(long src)
        {
            try
            {
                return Essentials.Time.EssentialsDateTime.FromUnixTimestamp(src).DateTime;
            }
            catch (Exception)
            {
                throw new Exception("Unable to parse date " + src);
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotMonitorSsl"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotMonitorSsl"/>.</returns>
        public static UptimeRobotMonitorSsl Parse(JObject obj)
        {
            return obj == null ? null : new UptimeRobotMonitorSsl(obj);
        }

        #endregion

    }

}