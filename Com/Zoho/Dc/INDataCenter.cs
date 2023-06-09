using System;

namespace Com.Zoho.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho in IN Domain.
    /// </summary>
    public class INDataCenter : DataCenter
    {
        private static readonly INDataCenter IN = new INDataCenter();

        private INDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho Production Environment in IN Domain.
        /// </summary>
        public static readonly Environment PRODUCTION = new Environment("in_prd", "https://www.zohoapis.in", IN.GetIAMUrl(), IN.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Sandbox Environment in IN Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("in_sdb", "https://sandbox.zohoapis.in", IN.GetIAMUrl(), IN.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Developer Environment in IN Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("in_dev", "https://developer.zohoapis.in", IN.GetIAMUrl(), IN.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.in/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.in";
        }
    }
}
