using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Models {

    /// <summary>
    /// Class representing a basic response from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotEnvelope : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the status of the response.
        /// </summary>
        public UptimeRobotStatus Status { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the response body.</param>
        protected UptimeRobotEnvelope(JObject obj) : base(obj) {
            Status = obj.GetEnum<UptimeRobotStatus>("stat");
        }

        #endregion

    }

}