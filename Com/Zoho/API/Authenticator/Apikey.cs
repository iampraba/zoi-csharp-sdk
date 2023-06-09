using System;
using Com.Zoho.Util;
using Com.Zoho.Exception;

namespace Com.Zoho.API.Authenticator
{
	public class Apikey: Token
	{
        private string apikey;

        private string authenticationType;

        public Apikey SetApikey(string apikey)
        {
            Utility.AssertNotNull(apikey, Constants.TOKEN_ERROR, "APIKey is not empty/null. Configure proper apikey value");

            this.apikey = apikey;

            return this;
        }

        public Apikey SetAuthenticationType(string authenticationType)
        {
            Utility.AssertNotNull(authenticationType, Constants.TOKEN_ERROR, "APIKey Type not configured properly. Configure apikey type as params/header");

            this.authenticationType = authenticationType;

            return this;
        }

        public Apikey(string apikey, string authenticationType)
		{
            this.apikey = apikey;
            this.authenticationType = authenticationType;
		}

        public void Authenticate(APIHTTPConnector urlConnection)
        {
            Utility.AssertNotNull(authenticationType, Constants.TOKEN_ERROR, "APIKey Type not configured properly. Configure apikey type as params/header");

            if (Constants.PARAMS.Equals(authenticationType))
            {
                urlConnection.AddParam("apikey", this.apikey);
            } else if (Constants.HEADERS.Equals(authenticationType))
            {
                urlConnection.AddHeader("X-API-Key", this.apikey);
            } else
            {
                throw new SDKException("APIKey Type not configured properly", "Configure apikey type as params/header");
            }
        }

        public bool Remove()
        {
            return true;
        }
    }
}

