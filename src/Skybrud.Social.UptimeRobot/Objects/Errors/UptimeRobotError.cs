using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Objects.Errors {
    
    /// <summary>
    /// Class representing an error received from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotError : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the type of the error.
        /// </summary>
        public string Type { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the error.</param>
        protected UptimeRobotError(JObject obj) : base(obj) {
            Type = obj.GetString("type");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotError"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotError"/>.</returns>
        public static UptimeRobotError Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotError(obj);
        }

        #endregion
    
    }

}