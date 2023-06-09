using System;

using System.Collections.Generic;

using System.Reflection;

using Com.Zoho.Exception;

using Com.Zoho.Util;

namespace Com.Zoho
{
    /// <summary>
    /// This class represents the HTTP header name and value.
    /// </summary>
    public class HeaderMap
    {
        private Dictionary<string, string> headerMap = new Dictionary<string, string>();

        /// <summary>
        /// This is a getter method to get header map.
        /// </summary>
        /// <returns>A Dictionary&lt;string, string&gt; representing the API response headers.</returns>
        public Dictionary<string, string> HeaderMaps
        {
            get
            {
                return headerMap;
            }
        }

        /// <summary>
        /// This method is to add header name and value.
        /// </summary>
        /// <typeparam name="T">A T containing the specified data type.</typeparam>
        /// <param name="header">A Header&lt;T&gt; class instance.</param>
        /// <param name="value">A T containing the header value.</param>
        public void Add<T>(Header<T> header, T value)
        {
            if(header == null)
            {
                throw new SDKException(Constants.HEADER_NULL_ERROR, Constants.HEADER_INSTANCE_NULL_ERROR);
            }

            string headerName = header.Name;

            if(headerName == null)
            {
                throw new SDKException(Constants.HEADER_NAME_NULL_ERROR, Constants.HEADER_NAME_NULL_ERROR_MESSAGE);
            }

            if(value == null)
            {
                throw new SDKException(Constants.HEADER_NULL_ERROR, headerName + Constants.NULL_VALUE_ERROR_MESSAGE);
            }

            string headerClassName = header.ClassName;

            string parsedHeaderValue;

            HeaderParamValidator<T> headerParamValidator = new HeaderParamValidator<T>();

            if (headerClassName != null)
            {
                headerClassName = headerParamValidator.GetClassName(headerClassName);

                parsedHeaderValue = headerParamValidator.Validate(headerName, headerClassName, value);
            }
            else
            {
                try
                {
                    parsedHeaderValue = Convert.ToString(headerParamValidator.GetValue(value));
                }
                catch (System.Exception)
                {
                    parsedHeaderValue = value.ToString();
                }
            }

            if (headerMap.ContainsKey(headerName) && !string.IsNullOrEmpty(headerMap[headerName]))
            {
                string existingHeaderValue = this.headerMap[headerName];

                existingHeaderValue = existingHeaderValue + "," + parsedHeaderValue.ToString();

                headerMap[headerName] = existingHeaderValue;
            }
            else
            {
                headerMap[headerName] = parsedHeaderValue.ToString();
            }
        }
    }
}
