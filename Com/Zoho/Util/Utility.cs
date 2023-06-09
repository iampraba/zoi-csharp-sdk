using System;

using Com.Zoho.Exception;

using Newtonsoft.Json.Linq;

namespace Com.Zoho.Util
{
    /// <summary>
    /// This class handles module field details.
    /// </summary>
    public class Utility
    {
        public static void AssertNotNull(object value, string errorCode, string errorMessage)
        {
            if(value == null)
            {
                throw new SDKException(errorCode, errorMessage);
            }
        }

        public static JObject GetJSONObject(JObject json, string key)
        {
            foreach(var entry in json)
            {
                string keyInJSON = entry.Key;

                if(keyInJSON.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    return (JObject)entry.Value;
                }
            }

            return null;
        }
    }
}
