using Skybrud.Social.Http;

namespace Skybrud.Social.UptimeRobot.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the accounts endpoint.
    /// </summary>
    public class UptimeRobotAccountsRawEndpoint {

        #region Properties
        
        /// <summary>
        /// Gets a reference to the Uptime Robot client.
        /// </summary>
        public UptimeRobotClient Client { get; private set; }

        #endregion

        #region Constructors

        internal UptimeRobotAccountsRawEndpoint(UptimeRobotClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the details of the account behind the current <code>apiKey</code>.
        /// </summary>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse GetAccountDetails() {
            return Client.DoHttpGetRequest("https://api.uptimerobot.com/getAccountDetails");
        }

        #endregion

    }

}