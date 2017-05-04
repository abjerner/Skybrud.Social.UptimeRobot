using System;
using Skybrud.Social.UptimeRobot.Endpoints;

namespace Skybrud.Social.UptimeRobot {

    /// <summary>
    /// Service implementation of the Uptime Robot API.
    /// </summary>
    public class UptimeRobotService {

        #region Properties

        /// <summary>
        /// Gets a referencer to the underlying client.
        /// </summary>
        public UptimeRobotClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to the accounts endpoint.
        /// </summary>
        public UptimeRobotAccountsEndpoint Accounts { get; private set; }

        /// <summary>
        /// Gets a reference to the monitors endpoint.
        /// </summary>
        public UptimeRobotMonitorsEndpoint Monitors { get; private set; }

        #endregion

        #region Constructors

        private UptimeRobotService(UptimeRobotClient client) {
            Client = client;
            Accounts = new UptimeRobotAccountsEndpoint(this);
            Monitors = new UptimeRobotMonitorsEndpoint(this);
        }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Initializes a new service based on the specified client.
        /// </summary>
        /// <param name="apiKey">The API key of an Uptime Robot user.</param>
        public static UptimeRobotService CreateFromApiKey(string apiKey) {
            if (String.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException("apiKey");
            return new UptimeRobotService(new UptimeRobotClient(apiKey));
        }

        /// <summary>
        /// Initializes a new service based on the specified client.
        /// </summary>
        /// <param name="client">The client to use.</param>
        public static UptimeRobotService CreateFromOAuthClient(UptimeRobotClient client) {
            if (client == null) throw new ArgumentNullException("client");
            return new UptimeRobotService(client);
        }

        #endregion

    }

}