
namespace FacebookNet
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Configuration object for Facebook API.
    /// </summary>
    public class FacebookApiConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookApiConfiguration"/> class.
        /// </summary>
        public FacebookApiConfiguration()
        {
            this.BaseApiUrl = "https://graph.facebook.com";
            this.BaseOAuthUrl = "https://graph.facebook.com";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookApiConfiguration"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiSecretKey">The API secret key.</param>
        public FacebookApiConfiguration(string apiKey, string apiSecretKey)
            : this()
        {
            this.ApiKey = apiKey;
            this.ApiSecretKey = apiSecretKey;
        }

        /// <summary>
        /// Gets or sets the base API URL.
        /// </summary>
        public string BaseApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the base automatic authentication URL.
        /// </summary>
        public string BaseOAuthUrl { get; set; }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the API secret key.
        /// </summary>
        public string ApiSecretKey { get; set; }

        /// <summary>
        /// Creates a configuration object froms the application settings.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <returns></returns>
        public static FacebookApiConfiguration FromAppSettings(string prefix)
        {
            if (prefix != null)
            {
                if (!prefix.EndsWith("."))
                    prefix += ".";
            }

            var me = new FacebookApiConfiguration();
            me.ApiKey = ConfigurationManager.AppSettings[prefix + "ApiKey"];
            me.ApiSecretKey = ConfigurationManager.AppSettings[prefix + "ApiSecretKey"];

            return me;
        }

        internal FacebookApiConfiguration Clone()
        {
            return new FacebookApiConfiguration
            {
                BaseApiUrl = this.BaseApiUrl,
                BaseOAuthUrl = this.BaseOAuthUrl,
                ApiKey = this.ApiKey,
                ApiSecretKey = this.ApiSecretKey,
            };
        }
    }
}
