namespace Skybrud.Social.UptimeRobot.Models.Monitors {
    
    /// <summary>
    /// Enum class representing the type of a log entry.
    /// </summary>
    public enum UptimeRobotLogType {
    
        /// <summary>
        /// Indicates that a monitor is down.
        /// </summary>
        Down = 1,

        /// <summary>
        /// Indicates that a monitor is up.
        /// </summary>
        Up = 2,

        /// <summary>
        /// Indicates that a monitor is currently paused.
        /// </summary>
        Paused = 99,

        /// <summary>
        /// Indicates that a monitor has been started.
        /// </summary>
        Started = 98
    
    }

}