using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.UptimeRobot.Objects {
    
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

    }

}