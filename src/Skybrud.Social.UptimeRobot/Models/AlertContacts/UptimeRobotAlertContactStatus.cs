namespace Skybrud.Social.UptimeRobot.Models.AlertContacts {

    /// <summary>
    /// Enum class representing the status (or state) of an alert contact.
    /// </summary>
    public enum UptimeRobotAlertContactStatus {

        /// <summary>
        /// Indicates that the alert contact hasn't yet been activiated.
        /// </summary>
        NotActivated = 0,

        /// <summary>
        /// Indicates that the alert contact currently has been paused.
        /// </summary>
        Paused = 1,

        /// <summary>
        /// Indicates that the alert contact currently is active.
        /// </summary>
        Active = 2
    
    }

}