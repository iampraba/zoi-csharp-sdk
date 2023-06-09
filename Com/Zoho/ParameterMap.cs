using System;
using System.Collections.Generic;
using System.Reflection;
using Com.Zoho.Exception;
using Com.Zoho.Util;

namespace Com.Zoho
{
    /// <summary>
    /// This class representing the HTTP parameter name and value.
    /// </summary>
    public class ParameterMap
    {
        private Dictionary<string, string> parameterMap = new Dictionary<string, string>();

        /// <summary>
        /// This is a getter method to get parameter map.
        /// </summary>
        /// <returns>A Dictionary&lt;string, string&gt; representing the API response parameters.</returns>
        public Dictionary<string, string> ParameterMaps
        {
            get
            {
                return parameterMap;
            }
        }

        /// <summary>
        /// This method to add parameter name and value.
        /// </summary>
        /// <typeparam name="T">A T containing the specified data type.</typeparam>
        /// <param name="param">A Param&lt;T&gt; class instance.</param>
        /// <param name="value">A T containing the parameter value.</param>
        public void Add<T>(Param<T> param, T value)
        {
            if(param == null)
            {
                throw new SDKException(Constants.PARAMETER_NULL_ERROR, Constants.PARAM_INSTANCE_NULL_ERROR);
            }

            string paramName = param.Name;

            if(paramName == null)
            {
                throw new SDKException(Constants.PARAM_NAME_NULL_ERROR, Constants.PARAM_NAME_NULL_ERROR_MESSAGE);
            }

            if(value == null)
            {
                throw new SDKException(Constants.PARAMETER_NULL_ERROR, paramName + Constants.NULL_VALUE_ERROR_MESSAGE);
            }

            string paramClassName = param.ClassName;

            string parsedParamValue;

            HeaderParamValidator<T> headerParamValidator = new HeaderParamValidator<T>();
            if (paramClassName != null)
            {
                paramClassName = headerParamValidator.GetClassName(param.ClassName);

                parsedParamValue = headerParamValidator.Validate(paramName, paramClassName, value);
            }
            else
            {
                try
                {
                    parsedParamValue = Convert.ToString(headerParamValidator.GetValue(value));
                }
                catch (System.Exception)
                {
                    parsedParamValue = value.ToString();
                }
            }

            if (ParameterMaps.ContainsKey(paramName) && !string.IsNullOrEmpty(ParameterMaps[paramName]))
            {
                string existingParamValue = ParameterMaps[paramName];

                existingParamValue = existingParamValue + "," + parsedParamValue.ToString();

                ParameterMaps[paramName] = existingParamValue;
            }
            else
            {
                ParameterMaps[paramName] = parsedParamValue.ToString();
            }
        }
    }
}
