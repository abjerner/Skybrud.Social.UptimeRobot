using System;
using System.Linq;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;
using Skybrud.Social.UptimeRobot.Enums;

namespace Skybrud.Social.UptimeRobot.Options {
    
    /// <summary>
    /// Class representing the options for a call to get the monitors of the current user.
    /// </summary>
    public class UptimeRobotGetMonitorsOptions : IHttpPostOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the IDs of the monitors that should be returned. If not specified, all monitors will be
        /// returned.
        /// </summary>
        public long[] Monitors { get; set; }

        /// <summary>
        /// Gets or sets the type(s) of monitors to be returned - eg. <see cref="UptimeRobotMonitorType.Http"/>. If not
        /// specified, all monitors will be returned.
        /// </summary>
        public UptimeRobotMonitorType[] Types { get; set; }

        /// <summary>
        /// Gets or sets the type(s) of monitors to be returned - eg. <see cref="UptimeRobotMonitorStatus.Down"/>. If
        /// not specified, all monitors will be returned.
        /// </summary>
        public UptimeRobotMonitorStatus[] Statuses { get; set; }

        /// <summary>
        /// Gets or sets an array of custom uptime ratios specified in days - eg. <code>7</code>, <code>30</code> or
        /// <code>45</code>.
        /// </summary>
        public int[] CustomUptimeRatios { get; set; }

        /// <summary>
        /// Gets or sets whether the <strong>all time uptime ratio</strong> should be returned. It will slow down the
        /// response a bit and, if not really necessary, it is suggested not to use it. Default is <code>false</code>.
        /// </summary>
        public bool AllTimeUptimeRatio { get; set; }

        /// <summary>
        /// Gets or sets whether the <strong>all time durations of up-down-paused events</strong> should be returned.
        /// It will slow down the response a bit and, if not really necessary, it is suggested not to use it. Default
        /// is <code>false</code>.
        /// </summary>
        public bool AllTimeUptimeDurations { get; set; }
        
        /// <summary>
        /// Gets or sets whether the log of each monitor should be returned. Default value is <code>false</code>.
        /// </summary>
        public bool Logs { get; set; }

        /// <summary>
        /// Gets or sets the offset of the page to be returned. Default value is <code>0</code>.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of monitors to be returned by the API. Default and maximum value is <code>50</code>.
        /// </summary>
        public int Limit { get; set; }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {
            return new SocialHttpQueryString();
        }

        public IHttpPostData GetPostData() {

            SocialHttpPostData data = new SocialHttpPostData();

            if (Monitors != null && Monitors.Length > 0) data.Add("monitors", String.Join("-", Monitors));
            if (Types != null && Types.Length > 0) data.Add("types", String.Join("-", Types.Select(x => (int) x)));
            if (Statuses != null && Statuses.Length > 0) data.Add("statuses", String.Join("-", Statuses.Select(x => (int)x)));
            if (CustomUptimeRatios != null && CustomUptimeRatios.Length > 0) data.Add("custom_uptime_ratios", String.Join("-", CustomUptimeRatios));
            if (AllTimeUptimeRatio) data.Add("all_time_uptime_ratio", "1");
            if (AllTimeUptimeDurations) data.Add("all_time_uptime_durations", "1");
            if (Logs) data.Add("logs", "1");
            if (Offset > 0) data.Add("offset", Offset);
            if (Limit > 0) data.Add("limit", Limit);

            return data;
        
        }

        #endregion

    }

}