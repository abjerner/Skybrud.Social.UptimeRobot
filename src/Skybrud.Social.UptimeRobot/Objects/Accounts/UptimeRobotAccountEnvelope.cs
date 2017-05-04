using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.UptimeRobot.Objects.Accounts {

    /// <summary>
    /// Class representing the response body of a call to get account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotAccountEnvelope : UptimeRobotEnvelope {

        #region Properties

        /// <summary>
        /// Gets a reference to the account details of the current user.
        /// </summary>
        public UptimeRobotAccountDetails Account { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the response body.</param>
        protected UptimeRobotAccountEnvelope(JObject obj) : base(obj) {
            Account = obj.GetObject("account", UptimeRobotAccountDetails.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="UptimeRobotAccountEnvelope"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="UptimeRobotAccountEnvelope"/>.</returns>
        public static UptimeRobotAccountEnvelope Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotAccountEnvelope(obj);
        }

        #endregion

    }

}