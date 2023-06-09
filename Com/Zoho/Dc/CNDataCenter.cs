using System;

namespace Com.Zoho.Dc
{
    /// <summary>
    /// This class represents the properties of Zoho in CN Domain.
    /// </summary>
    public class CNDataCenter : DataCenter
    {
        private static readonly CNDataCenter CN = new CNDataCenter();

        private CNDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho Production Environment in CN Domain.
        /// </summary>
        public static readonly  Environment PRODUCTION = new Environment("cn_prd", "https://www.zohoapis.com.cn", CN.GetIAMUrl(), CN.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Sandbox Environment in CN Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("cn_sdb", "https://sandbox.zohoapis.com.cn", CN.GetIAMUrl(), CN.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho Developer Environment in CN Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("cn_dev", "https://developer.zohoapis.com.cn", CN.GetIAMUrl(), CN.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.com.cn/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.com.cn";
        }
    }
}
