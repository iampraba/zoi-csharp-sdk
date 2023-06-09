using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class MailMergeWebhookSettings : Model
	{
		private string invokeUrl;
		private string invokePeriod;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string InvokeUrl
		{
			/// <summary>The method to get the invokeUrl</summary>
			/// <returns>string representing the invokeUrl</returns>
			get
			{
				return  this.invokeUrl;

			}
			/// <summary>The method to set the value to invokeUrl</summary>
			/// <param name="invokeUrl">string</param>
			set
			{
				 this.invokeUrl=value;

				 this.keyModified["invoke_url"] = 1;

			}
		}

		public string InvokePeriod
		{
			/// <summary>The method to get the invokePeriod</summary>
			/// <returns>string representing the invokePeriod</returns>
			get
			{
				return  this.invokePeriod;

			}
			/// <summary>The method to set the value to invokePeriod</summary>
			/// <param name="invokePeriod">string</param>
			set
			{
				 this.invokePeriod=value;

				 this.keyModified["invoke_period"] = 1;

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