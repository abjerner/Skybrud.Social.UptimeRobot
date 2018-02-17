namespace Skybrud.Social.UptimeRobot.Models.Monitors {
    
    /// <summary>
    /// Enum class representing the sub type of a port monitor.
    /// </summary>
    public enum UptimeRobotMonitorSubType {

        /// <summary>
        /// Indicates a monitor that doesn't have a sub type.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Indicates a port monitor that will check <strong>port 443</strong>.
        /// </summary>
        Http = 1,

        /// <summary>
        /// Indicates a port monitor that will check <strong>port 443</strong>.
        /// </summary>
        Https = 2,

        /// <summary>
        /// Indicates a port monitor that will check <strong>port 21</strong>.
        /// </summary>
        Ftp = 3,

        /// <summary>
        /// Indicates a port monitor that will check <strong>port 25</strong>.
        /// </summary>
        Smtp = 4,

        /// <summary>
        /// Indicates a port monitor that will check <strong>port 110</strong>.
        /// </summary>
        Pop3 = 5,

        /// <summary>
        /// Indicates a port monitor that will check <strong>port 143</strong>.
        /// </summary>
        Imap = 6,

        /// <summary>
        /// Indicates a port monitor that will check a custom port number.
        /// </summary>
        CustomPort = 99
    
    }

}