namespace Skybrud.Social.UptimeRobot.Enums {
    
    /// <summary>
    /// Class representing the status of a monitor.
    /// </summary>
    public enum UptimeRobotMonitorStatus {
        
        /// <summary>
        /// Indicates that a monitor is currently paused.
        /// </summary>
        Paused = 0,

        /// <summary>
        /// Indicates that a monitor hasn't been checked yet.
        /// </summary>
        NotCheckedYet = 1,

        /// <summary>
        /// Indicates that a monitor is up.
        /// </summary>
        Up = 2,

        /// <summary>
        /// Indicates that a monitor seems to be down.
        /// </summary>
        SeemsDown = 8,

        /// <summary>
        /// Indicates that a monitor is currently down.
        /// </summary>
        Down = 9
    
    }

}