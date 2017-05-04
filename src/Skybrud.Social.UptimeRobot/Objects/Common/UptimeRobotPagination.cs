using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Objects.Common {

    /// <summary>
    /// Class representing the response body of a call to get a list of monitors of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotPagination : UptimeRobotObject {

        #region Properties

        /// <summary>
        /// Gets the offset of the returned page.
        /// </summary>
        public int Offset { get; private set; }

        /// <summary>
        /// Gets the limit of the returned page.
        /// </summary>
        public int Limit { get; private set; }

        /// <summary>
        /// Gets the total amount of items.
        /// </summary>
        public int Total { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected UptimeRobotPagination(JObject obj) : base(obj) {
            Offset = obj.GetInt32("offset");
            Limit = obj.GetInt32("limit");
            Total = obj.GetInt32("total");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotPagination"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotPagination"/>.</returns>
        public static UptimeRobotPagination Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotPagination(obj);
        }

        #endregion

    }

}