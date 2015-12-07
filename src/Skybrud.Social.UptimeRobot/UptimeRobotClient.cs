using System;
using System.Collections.Specialized;
using System.Net;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;
using Skybrud.Social.UptimeRobot.Endpoints.Raw;

namespace Skybrud.Social.UptimeRobot {
    
    /// <summary>
    /// Class representing the raw client to communicate with the Uptime Robot API.
    /// </summary>
    public class UptimeRobotClient {

        #region Properties

        /// <summary>
        /// Gets or sets the API key of the client.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets a reference to the raw accounts endpoint.
        /// </summary>
        public UptimeRobotAccountsRawEndpoint Accounts { get; private set; }

        /// <summary>
        /// Gets a reference to the raw monitors endpoint.
        /// </summary>
        public UptimeRobotMonitorsRawEndpoint Monitors { get; private set; }

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
        /// Initializes a new client with the specified <code>apiKey</code>.
        /// </summary>
        /// <param name="apiKey">The API key of your user.</param>
        public UptimeRobotClient(string apiKey) : this() {
            ApiKey = apiKey;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Makes a HTTP GET request to the specified <code>url</code>.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url) {
            return DoHttpGetRequest(url, default(SocialQueryString));
        }

        /// <summary>
        /// Makes a HTTP GET request to the specified <code>url</code> and with the specified <code>query</code> string.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="query">The query string of the request.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url, NameValueCollection query) {
            
            if (query == null) query = new NameValueCollection();

            // Append the access token to the query string
            if (!String.IsNullOrWhiteSpace(ApiKey)) {
                query.Add("apiKey", ApiKey);
            }

            query.Add("format", "json");
            query.Add("noJsonCallback", "1");

            // Make the call to the API
            HttpWebResponse response = SocialUtils.DoHttpGetRequest(url, query);

            // Wrap the native response class
            return SocialHttpResponse.GetFromWebResponse(response);


        }

        /// <summary>
        /// Makes a HTTP GET request to the specified <code>url</code> and with the specified <code>options</code>.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url, IGetOptions options) {
            return DoHttpGetRequest(url, options == null ? null : options.GetQueryString());
        }

        /// <summary>
        /// Makes a HTTP GET request to the specified <code>url</code> and with the specified <code>query</code> string.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="query">The query string of the request.</param>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse DoHttpGetRequest(string url, SocialQueryString query) {
            return DoHttpGetRequest(url, query == null ? null : query.NameValueCollection);
        }

        #endregion

    }

}