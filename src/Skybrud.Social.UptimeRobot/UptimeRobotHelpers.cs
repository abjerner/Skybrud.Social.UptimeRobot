using System;

namespace Skybrud.Social.UptimeRobot {
    
    /// <summary>
    /// Static class with various helper methods used througout the Uptime Robot implementation.
    /// </summary>
    public static class UptimeRobotHelpers {

        /// <summary>
        /// Parses an enum from the specified <code>ordinal</code>.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="ordinal">The ordinal of the enum.</param>
        /// <returns>Retursn an instance of <code>T</code>.</returns>
        public static T ParseEnum<T>(int ordinal) {
            return(T) Enum.ToObject(typeof(T), ordinal);
        }

    }

}