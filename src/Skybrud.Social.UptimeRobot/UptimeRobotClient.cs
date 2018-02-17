using System;
using Skybrud.Social.Http;
using Skybrud.Social.UptimeRobot.Endpoints.Raw;

namespace Skybrud.Social.UptimeRobot {
    
    /// <summary>
    /// Class representing the raw client to communicate with the Uptime Robot API.
    /// </summary>
    public class UptimeRobotClient : SocialHttpClient {

        #region Properties

        /// <summary>
        /// Gets or sets the API key of the client.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets a reference to the raw accounts endpoint.
        /// </summary>
        public UptimeRobotAccountsRawEndpoint Accounts { get; }

        /// <summary>
        /// Gets a reference to the raw monitors endpoint.
        /// </summary>
        public UptimeRobotMonitorsRawEndpoint Monitors { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new client with default options.
        /// </summary>
        public UptimeRobotClient() {
            Accounts = new UptimeRobotAccountsRawEndpoint(this);
            Monitors = new UptimeRobotMonitorsRawEndpoint(this);
        }

        /// <summary>
        /// Initializes a new client with the specified <paramref name="apiKey"/>.
        /// </summary>
        /// <param name="apiKey">The API key of your user.</param>
        public UptimeRobotClient(string apiKey) : this() {
            ApiKey = apiKey;
        }

        #endregion

        #region Member methods
        
        protected override void PrepareHttpRequest(SocialHttpRequest request) {

            if (request.PostData == null) request.PostData = new SocialHttpPostData();

            // Append the access token to the POST data
            if (!String.IsNullOrWhiteSpace(ApiKey)) {
                request.PostData.Add("api_key", ApiKey);
            }

            request.PostData.Add("format", "json");
        
        }

        #endregion

    }

}