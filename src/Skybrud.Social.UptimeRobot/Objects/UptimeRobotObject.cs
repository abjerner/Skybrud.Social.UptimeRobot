using Newtonsoft.Json.Linq;

namespace Skybrud.Social.UptimeRobot.Objects {
    
    /// <summary>
    /// Class representing a basic object from the Uptime Robot API derived from an instance of <code>JObject</code>.
    /// </summary>
    public class UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets a reference to the instance of <code>JObject</code> the object was parsed from.
        /// </summary>
        public JObject JObject { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the object.</param>
        protected UptimeRobotObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}