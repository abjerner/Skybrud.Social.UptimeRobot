using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.UptimeRobot.Objects.Accounts {

    /// <summary>
    /// Class representing the response body of a call to get account details of a Uptime Robot user.
    /// </summary>
    public class UptimeRobotAccountResponseBody : UptimeRobotResponseBody {

        #region Properties

        /// <summary>
        /// Gets a reference to the account details of the current user.
        /// </summary>
        public UptimeRobotAccountDetails Account { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the response body.</param>
        protected UptimeRobotAccountResponseBody(JObject obj) : base(obj) {
            Account = obj.GetObject("account", UptimeRobotAccountDetails.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <code>UptimeRobotAccountResponseBody</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        /// <returns>Returns an instance of <code>UptimeRobotAccountResponseBody</code>.</returns>
        public static UptimeRobotAccountResponseBody Parse(JObject obj) {
            return obj == null ? null : new UptimeRobotAccountResponseBody(obj);
        }

        #endregion

    }

}