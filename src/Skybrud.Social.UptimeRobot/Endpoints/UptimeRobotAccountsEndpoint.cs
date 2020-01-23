using Skybrud.Social.UptimeRobot.Endpoints.Raw;
using Skybrud.Social.UptimeRobot.Http;
using Skybrud.Social.UptimeRobot.Responses.Accounts;

namespace Skybrud.Social.UptimeRobot.Endpoints {

    /// <summary>
    /// Class representing the implementation of the <strong>Accounts</strong> endpoint.
    /// </summary>
    public class UptimeRobotAccountsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Uptime Robot service.
        /// </summary>
        public UptimeRobotService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public UptimeRobotAccountsRawEndpoint Raw => Service.Client.Accounts;

        #endregion

        #region Constructors

        internal UptimeRobotAccountsEndpoint(UptimeRobotService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the details of the account behind the current <see cref="UptimeRobotHttpClient.ApiKey"/>.
        /// </summary>
        /// <returns>An instance of <see cref="UptimeRobotGetAccountDetailsResponse"/> representing the response.</returns>
        public UptimeRobotGetAccountDetailsResponse GetAccountDetails() {
            return UptimeRobotGetAccountDetailsResponse.ParseResponse(Raw.GetAccountDetails());
        }

        #endregion

    }

}