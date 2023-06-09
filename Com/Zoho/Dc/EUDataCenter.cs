using System;

namespace Com.Zoho.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho in EU Domain.
    /// </summary>
    public class EUDataCenter : DataCenter
    {
        private static readonly EUDataCenter EU = new EUDataCenter();

        private EUDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho Production Environment in EU Domain.
        /// </summary>
        public static readonly  Environment PRODUCTION = new Environment("eu_prd", "https://www.zohoapis.eu", EU.GetIAMUrl(), EU.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Sandbox Environment in EU Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("eu_sdb", "https://sandbox.zohoapis.eu", EU.GetIAMUrl(), EU.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Developer Environment in EU Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("eu_dev", "https://developer.zohoapis.eu", EU.GetIAMUrl(), EU.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.eu/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.eu";
        }
    }
}
