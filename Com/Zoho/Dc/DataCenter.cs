using System;

namespace Com.Zoho.Dc
{
    /// <summary>
    /// The abstract class represents the properties of Zoho DataCenter.
    /// </summary>
    public abstract class DataCenter
    {
        /// <summary>
        /// This method to get accounts URL. URL to be used when calling an OAuth accounts.
        /// </summary>
        /// <returns>A String representing the accounts URL.</returns>
        public abstract string GetIAMUrl();

        /// <summary>
        /// This method to get File Upload URL.
        /// </summary>
        /// <returns>A String representing the FileUpload URL.</returns>
        public abstract string GetFileUploadUrl();

        /// <summary>
        /// The abstract class represents the properties of Zoho Environment.
        /// </summary>
        public class Environment
        {
            private string name;

            private string url;

            private string accountsUrl;

            private string fileUploadUrl;

            public Environment(string name, string url, string accountsUrl, string fileUploadUrl)
            {
                this.name = name;

                this.accountsUrl = accountsUrl;

                this.url = url;

                this.fileUploadUrl = fileUploadUrl;
            }

            /// <summary>
            /// This method to get Zoho API URL.
            /// </summary>
            /// <returns>A String representing the Zoho API URL.</returns>
            public string GetUrl()
            {
                return this.url;
            }

            /// <summary>
            /// This method to get Zoho Accounts URL.
            /// </summary>
            /// <returns>A String representing the accounts URL.</returns>
            public string GetAccountsUrl()
            {
                return this.accountsUrl;
            }

            /// <summary>
            /// This method to get Zoho File Upload URL.
            /// </summary>
            /// <returns>A String representing the FileUpload URL.</returns>
            public string GetFileUploadUrl()
            {
                return this.fileUploadUrl;
            }

            /// <summary>
            /// This method to get Environment Name.
            /// </summary>
            /// <returns>A String representing the Environment Name.</returns>
            public string GetName()
            {
                return this.name;
            }
        }
    }
}
