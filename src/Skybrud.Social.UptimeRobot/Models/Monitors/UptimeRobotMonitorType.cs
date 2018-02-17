namespace Skybrud.Social.UptimeRobot.Models.Monitors {
    
    /// <summary>
    /// Class representing the type of a monitor.
    /// </summary>
    public enum UptimeRobotMonitorType {

        /// <summary>
        /// Indicates a monitor that checks a given HTTP or HTTPS URL.
        /// </summary>
        Http = 1,

        /// <summary>
        /// Indicates a monitor that will check whether a given URL contains (or doesn't contain) a given keyword.
        /// </summary>
        Keyword = 2,

        /// <summary>
        /// Indicates a monitor that will ping a given IP address or host.
        /// </summary>
        Ping = 3,

        /// <summary>
        /// Indicates a monitor that will check a given port number.
        /// </summary>
        Port = 4
    
    }

}