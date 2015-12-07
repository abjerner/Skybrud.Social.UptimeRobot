using Skybrud.Social.Http;
using Skybrud.Social.Interfaces;

namespace Skybrud.Social.UptimeRobot.Options {
    
    /// <summary>
    /// Class representing the options for a call to get the monitors of the current user.
    /// </summary>
    public class UptimeRobotGetMonitorsOptions : IGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets whether the log of each monitor should be returned. Default value is <code>false</code>.
        /// </summary>
        public bool Logs { get; set; }

        /// <summary>
        /// Gets or sets the offset of the page to be returned. Default value is <code>0</code>.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of monitors to be returned by the API. Default and maximum value is <code>50</code>.
        /// </summary>
        public int Limit { get; set; }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <code>SocialQueryString</code> representing the GET parameters.
        /// </summary>
        public SocialQueryString GetQueryString() {
            
            SocialQueryString query = new SocialQueryString();

            if (Logs) query.Add("logs", "1");
            if (Offset > 0) query.Add("offset", Offset);
            if (Limit > 0) query.Add("limit", Limit);

            return query;

        }

        #endregion

    }

}