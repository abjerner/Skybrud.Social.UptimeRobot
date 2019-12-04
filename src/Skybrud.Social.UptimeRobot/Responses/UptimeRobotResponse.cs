using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.UptimeRobot.Exceptions;
using Skybrud.Social.UptimeRobot.Models.Errors;

namespace Skybrud.Social.UptimeRobot.Responses {

    /// <summary>
    /// Class representing a response from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotResponse : HttpResponseBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        protected UptimeRobotResponse(IHttpResponse response) : base(response) { }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Validates the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static JObject ValidateResponse(IHttpResponse response) {

            // Valid responses should be of the type "application/json"
            if (!response.ContentType.StartsWith("application/json")) throw new UptimeRobotHttpException(response);
            
            // Parse the JSON body
            JObject body = ParseJsonObject(response.Body);

            // The API always responds with "200 OK", so we need to check the "stat" property in the envelope instead
            if (body.GetString("stat") == "ok") return body;
                
            // Parse the error
            UptimeRobotError error = UptimeRobotError.Parse(body);

            // Throw the exception
            throw new UptimeRobotHttpException(response, error);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Uptime Robot API.
    /// </summary>
    public class UptimeRobotResponse<T> : UptimeRobotResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        protected UptimeRobotResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}