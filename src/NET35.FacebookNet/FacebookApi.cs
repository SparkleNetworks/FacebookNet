
namespace FacebookNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookNet.OAuth2;

    /// <summary>
    /// Facebook API client.
    /// </summary>
    public partial class FacebookApi
    {
        private readonly FacebookApiConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookApi"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <exception cref="System.ArgumentNullException">configuration</exception>
        public FacebookApi(FacebookApiConfiguration configuration)
            : base(null)
        {
            if (configuration == null)
                throw new ArgumentNullException("configuration");

            this.configuration = configuration.Clone();
        }

        /// <summary>
        /// Gets the OAuth2 API.
        /// </summary>
        public OAuth2Api OAuth2
        {
            get { return new OAuth2Api(this); }
        }

        internal FacebookApiConfiguration Configuration
        {
            get { return this.configuration; }
        }
    }
}
