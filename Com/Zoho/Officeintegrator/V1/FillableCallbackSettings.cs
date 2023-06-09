using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FillableCallbackSettings : Model
	{
		private FillableLinkOutputSettings output;
		private string url;
		private string httpMethodType;
		private int? retries;
		private int? timeout;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public FillableLinkOutputSettings Output
		{
			/// <summary>The method to get the output</summary>
			/// <returns>Instance of FillableLinkOutputSettings</returns>
			get
			{
				return  this.output;

			}
			/// <summary>The method to set the value to output</summary>
			/// <param name="output">Instance of FillableLinkOutputSettings</param>
			set
			{
				 this.output=value;

				 this.keyModified["output"] = 1;

			}
		}

		public string Url
		{
			/// <summary>The method to get the url</summary>
			/// <returns>string representing the url</returns>
			get
			{
				return  this.url;

			}
			/// <summary>The method to set the value to url</summary>
			/// <param name="url">string</param>
			set
			{
				 this.url=value;

				 this.keyModified["url"] = 1;

			}
		}

		public string HttpMethodType
		{
			/// <summary>The method to get the httpMethodType</summary>
			/// <returns>string representing the httpMethodType</returns>
			get
			{
				return  this.httpMethodType;

			}
			/// <summary>The method to set the value to httpMethodType</summary>
			/// <param name="httpMethodType">string</param>
			set
			{
				 this.httpMethodType=value;

				 this.keyModified["http_method_type"] = 1;

			}
		}

		public int? Retries
		{
			/// <summary>The method to get the retries</summary>
			/// <returns>int? representing the retries</returns>
			get
			{
				return  this.retries;

			}
			/// <summary>The method to set the value to retries</summary>
			/// <param name="retries">int?</param>
			set
			{
				 this.retries=value;

				 this.keyModified["retries"] = 1;

			}
		}

		public int? Timeout
		{
			/// <summary>The method to get the timeout</summary>
			/// <returns>int? representing the timeout</returns>
			get
			{
				return  this.timeout;

			}
			/// <summary>The method to set the value to timeout</summary>
			/// <param name="timeout">int?</param>
			set
			{
				 this.timeout=value;

				 this.keyModified["timeout"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( this.keyModified.ContainsKey(key))))
			{
				return  this.keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 this.keyModified[key] = modification;


		}


	}
}