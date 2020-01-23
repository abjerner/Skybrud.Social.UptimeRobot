using Skybrud.Essentials.Http;
using Skybrud.Social.UptimeRobot.Http;

namespace Skybrud.Social.UptimeRobot.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the accounts endpoint.
    /// </summary>
    public class UptimeRobotAccountsRawEndpoint {

        #region Properties
        
        /// <summary>
        /// Gets a reference to the Uptime Robot client.
        /// </summary>
        public UptimeRobotHttpClient Client { get; }

        #endregion

        #region Constructors

        internal UptimeRobotAccountsRawEndpoint(UptimeRobotHttpClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the details of the account behind the current <see cref="UptimeRobotHttpClient.ApiKey"/>.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetAccountDetails() {
            return Client.Post("https://api.uptimerobot.com/v2/getAccountDetails");
        }

        #endregion

    }

}