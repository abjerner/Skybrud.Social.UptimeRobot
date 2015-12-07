using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;
using Skybrud.Social.UptimeRobot.Enums;

namespace Skybrud.Social.UptimeRobot.Objects {

    /// <summary>
    /// Class representing a basic response from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotResponseBody : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the status of the response.
        /// </summary>
        public UptimeRobotStatus Status { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the response body.</param>
        protected UptimeRobotResponseBody(JObject obj) : base(obj) {
            Status = obj.GetEnum<UptimeRobotStatus>("stat");
        }

        #endregion

    }

}