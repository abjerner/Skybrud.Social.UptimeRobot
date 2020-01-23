using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.UptimeRobot.Endpoints.Raw;

namespace Skybrud.Social.UptimeRobot.Http {
    
    /// <summary>
    /// Class representing the raw client to communicate with the Uptime Robot API.
    /// </summary>
    public class UptimeRobotHttpClient : HttpClient {

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
        public UptimeRobotHttpClient() {
            Accounts = new UptimeRobotAccountsRawEndpoint(this);
            Monitors = new UptimeRobotMonitorsRawEndpoint(this);
        }

        /// <summary>
        /// Initializes a new client with the specified <paramref name="apiKey"/>.
        /// </summary>
        /// <param name="apiKey">The API key of your user.</param>
        public UptimeRobotHttpClient(string apiKey) : this() {
            ApiKey = apiKey;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns the response of the request identified by the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instanceo of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public virtual IHttpResponse GetResponse(IHttpRequestOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            IHttpRequest request = options.GetRequest();
            PrepareHttpRequest(request);
            return request.GetResponse();
        }

        /// <summary>
        /// Updates new HTTP requests with information specific to the Uptime Robot. If an <see cref="ApiKey"/> is
        /// specified, the value is appended to the HTTP post data to authenticate your requests.
        /// </summary>
        /// <param name="request">The request.</param>
        protected override void PrepareHttpRequest(IHttpRequest request) {

            if (request.PostData == null) request.PostData = new HttpPostData();

            // Append the access token to the POST data
            if (!string.IsNullOrWhiteSpace(ApiKey)) {
                request.PostData.Add("api_key", ApiKey);
            }

            request.PostData.Add("format", "json");
        
        }

        #endregion

    }

}