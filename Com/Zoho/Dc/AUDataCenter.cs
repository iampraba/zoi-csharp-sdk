using System;

namespace Com.Zoho.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho in AU Domain.
    /// </summary>
    public class AUDataCenter : DataCenter
    {
        private static readonly AUDataCenter AU = new AUDataCenter();

        private AUDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho Production Environment in AU Domain.
        /// </summary>
        public static readonly Environment PRODUCTION = new Environment("au_prd", "https://www.zohoapis.com.au", AU.GetIAMUrl(), AU.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Sandbox Environment in AU Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("au_sdb", "https://sandbox.zohoapis.com.au", AU.GetIAMUrl(), AU.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Developer Environment in AU Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("au_dev", "https://developer.zohoapis.com.au", AU.GetIAMUrl(), AU.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.com.au/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.com.au";
        }
    }
}
