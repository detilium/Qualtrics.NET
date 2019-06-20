using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Core
{
    public class Context
    {
        private string _qualtricsBaseUrl;
        /// <summary>
        /// Base URL til Qualtrics API'et
        /// </summary>
        public string QualtricsBaseUrl
        {
            get
            {
                if (string.IsNullOrEmpty(_qualtricsBaseUrl))
                    throw new ConfigurationErrorsException("Qualtrics base URL er ikke sat");

                return _qualtricsBaseUrl;
            }
            set
            {
                _qualtricsBaseUrl = value;
            }
        }

        private string _qualtricsApiToken;
        /// <summary>
        /// API token til Qualtrics API'et
        /// </summary>
        public string QualtricsApiToken
        {
            get
            {
                if (string.IsNullOrEmpty(_qualtricsApiToken))
                    throw new ConfigurationErrorsException("Qualtrics APi token er ikke sat");

                return _qualtricsApiToken;
            }
            set
            {
                _qualtricsApiToken = value;
            }
        }

        private static Context _defaultContext;
        /// <summary>
        /// Instantiere en ny Context baseret på default config settings (kigger i web- eller app.config)
        /// </summary>
        public static Context Default
        {
            get
            {
                if (_defaultContext != null)
                    return _defaultContext;

                var qualtricsBaseUrl = ConfigurationManager.AppSettings["Qualtrics_BaseUrl"];

                return _defaultContext = new Context
                {
                    QualtricsBaseUrl = qualtricsBaseUrl
                };
            }
        }
    }
}
