using System;
using Skybrud.Social.UptimeRobot.Endpoints;
using Skybrud.Social.UptimeRobot.Http;

namespace Skybrud.Social.UptimeRobot {

    /// <summary>
    /// Service implementation of the Uptime Robot API.
    /// </summary>
    public class UptimeRobotService {

        #region Properties

        /// <summary>
        /// Gets a referencer to the underlying client.
        /// </summary>
        public UptimeRobotHttpClient Client { get; }

        /// <summary>
        /// Gets a reference to the accounts endpoint.
        /// </summary>
        public UptimeRobotAccountsEndpoint Accounts { get; }

        /// <summary>
        /// Gets a reference to the monitors endpoint.
        /// </summary>
        public UptimeRobotMonitorsEndpoint Monitors { get; }

        #endregion

        #region Constructors

        private UptimeRobotService(UptimeRobotHttpClient client) {
            Client = client;
            Accounts = new UptimeRobotAccountsEndpoint(this);
            Monitors = new UptimeRobotMonitorsEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initializes a new service based on the specified <paramref name="apiKey"/>.
        /// </summary>
        /// <param name="apiKey">The API key of an Uptime Robot user.</param>
        public static UptimeRobotService CreateFromApiKey(string apiKey) {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));
            return new UptimeRobotService(new UptimeRobotHttpClient(apiKey));
        }

        /// <summary>
        /// Initializes a new service based on the specified <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The client to use.</param>
        public static UptimeRobotService CreateFromOAuthClient(UptimeRobotHttpClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return new UptimeRobotService(client);
        }

        #endregion

    }

}