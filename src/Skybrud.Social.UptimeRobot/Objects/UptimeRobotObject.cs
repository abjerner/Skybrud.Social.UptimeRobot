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

        #region Member methods

        /// <summary>
        /// Parses an enum from the specified <paramref name="ordinal"/>.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="ordinal">The ordinal of the enum.</param>
        /// <returns>An instance of <typeparamref name="T"/>.</returns>
        protected T ParseEnum<T>(int ordinal) {
            return (T) Enum.ToObject(typeof(T), ordinal);
        }

        #endregion

    }

}