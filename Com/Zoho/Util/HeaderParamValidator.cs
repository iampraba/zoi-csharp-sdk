using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Com.Zoho.Util
{
    public class HeaderParamValidator<T>
    {
        private readonly JObject jsonDetails = Initializer.jsonDetails;

        public string Validate(string name, string className, T value)
        {
            if (jsonDetails.ContainsKey(className))
            {
                JObject classObject = (JObject)jsonDetails.GetValue(className);

                foreach (KeyValuePair<string, JToken> data in classObject)
                {
                    JObject memberDetail = (JObject)classObject.GetValue(data.Key);

                    string keyName = (string)memberDetail.GetValue(Constants.NAME);

                    if (name.Equals(keyName, StringComparison.OrdinalIgnoreCase))
                    {
                        if (memberDetail.ContainsKey(Constants.STRUCTURE_NAME))
                        {
                            return JsonConvert.SerializeObject(new JSONConverter(null).FormRequest(value, (string)memberDetail.GetValue(Constants.STRUCTURE_NAME), null, null)).ToString();
                        }
                        object parseData = ParseData(value);
                        if(parseData is IDictionary || parseData is IList)
                        {
                            return JsonConvert.SerializeObject(parseData);
                        }
                        return parseData.ToString();
                    }
                }
            }

            return GetValue(value).ToString();
        }

        public object GetValue(object value)
        {
            if (value is Boolean)
            {
                return value.ToString().ToLowerInvariant();
            }
            string type = value.GetType().FullName;
            Type dataTypeConverter = Type.GetType(Constants.DATATYPECONVERTER.Replace(Constants._TYPE, type));
            MethodInfo method = dataTypeConverter.GetMethod(Constants.POST_CONVERT);
            return method.Invoke(null, new object[] { value, type });
        }

        public object ParseData(object value)
        {
            if (value is IDictionary dictionary)
            {
                JObject jsonObject = new JObject();
                IDictionary requestObject = dictionary;
                if (requestObject.Count > 0)
                {
                    foreach (var key in requestObject.Keys)
                    {
                        object data = ParseData(requestObject[key]);

                        jsonObject.Add((string)key, data != null ? JToken.FromObject(data) : JValue.CreateNull());
                    }
                }
                return jsonObject;
            }
            else if (value is IList list)
            {
                JArray jsonArray = new JArray();
                IList requestObjects = list;

                if (requestObjects.Count > 0)
                {
                    foreach (object requestObject in requestObjects)
                    {
                        jsonArray.Add(ParseData(requestObject));
                    }
                }
                return jsonArray;
            }
            else
            {
                return GetValue(value).ToString();
            }
        }

        public static string Capitalize(string str)
        {
            if (str == null || string.IsNullOrEmpty(str))
            {
                return str;
            }

            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        public string GetClassName(string canonicalName)
        {
            string[] packages = canonicalName.Split('.');

            List<string> fileName = new List<string>();

            for (int i = 0; i < packages.Length; i++)
            {
                string name = packages[i];

                string packageName = Capitalize(name);

                if (packageName != null && !canonicalName.Contains("java."))
                {
                    if (packageName.Equals("api", StringComparison.OrdinalIgnoreCase))
                    {
                        packageName = packageName.ToUpper();
                    }

                    fileName.Add(packageName);
                }
                else
                {
                    if (name.Equals("api", StringComparison.OrdinalIgnoreCase))
                    {
                        name = name.ToUpper();
                    }

                    fileName.Add(name);
                }
            }

            return string.Join(".", fileName);
        }
    }
}
