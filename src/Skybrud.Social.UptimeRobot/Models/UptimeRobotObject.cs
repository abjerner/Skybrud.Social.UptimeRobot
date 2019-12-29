using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.UptimeRobot.Models {
    
    /// <summary>
    /// Class representing a basic object from the Uptime Robot API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class UptimeRobotObject : JsonObjectBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected UptimeRobotObject(JObject obj) : base(obj) { }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified UNIX <paramref name="timestamp"/> into an instance of <see cref="EssentialsTime"/>.
        /// </summary>
        /// <param name="timestamp">The UNIX timestamp to be parsed.</param>
        /// <returns>An instance of <see cref="EssentialsTime"/>.</returns>
        protected EssentialsTime ParseDate(long timestamp) {
            
            if (timestamp == 0) return null;
            
            // TODO: Do we actually need this method now?
            try {
                return EssentialsTime.FromUnixTimestamp(timestamp);
            } catch (Exception) {
                throw new Exception("Unable to parse date " + timestamp);
            }
        }

        #endregion

    }

}