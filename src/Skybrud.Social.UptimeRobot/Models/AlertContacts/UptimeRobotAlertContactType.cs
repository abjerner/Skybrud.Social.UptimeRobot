namespace Skybrud.Social.UptimeRobot.Models.AlertContacts {
    
    /// <summary>
    /// Enum class representing the type of an alert contact.
    /// </summary>
    public enum UptimeRobotAlertContactType {

        /// <summary>
        /// Indicates a SMS alert contact.
        /// </summary>
        Sms = 1,

        /// <summary>
        /// Indicates an email alert contact.
        /// </summary>
        Email = 2,

        /// <summary>
        /// Indicates a contact that is alerted through a <strong>Twitter</strong> direct message.
        /// </summary>
        Twitter = 3,

        /// <summary>
        /// Indicates a Boxcar alert contact.
        /// </summary>
        Boxcar = 4,

        /// <summary>
        /// Indicates a contact that is alerted through a web hook.
        /// </summary>
        WebHook = 5,

        /// <summary>
        /// Indicates a Pushbullet alert contact.
        /// </summary>
        Pushbullet = 6,

        /// <summary>
        /// Indicates a Zapier alert contact.
        /// </summary>
        Zapier = 7,

        /// <summary>
        /// Indicates a contact that is alerted through <strong>Pushover.net</strong>.
        /// </summary>
        Pushover = 8,

        /// <summary>
        /// Indicates a HipChat alert contact.
        /// </summary>
        HipChat = 10,

        /// <summary>
        /// Indicates a Slack alert contact.
        /// </summary>
        Slack = 11

    }

}