using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FillableSubmissionSettings : Model
	{
		private FillableCallbackSettings callbackOptions;
		private string redirectUrl;
		private string onsubmitMessage;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public FillableCallbackSettings CallbackOptions
		{
			/// <summary>The method to get the callbackOptions</summary>
			/// <returns>Instance of FillableCallbackSettings</returns>
			get
			{
				return  this.callbackOptions;

			}
			/// <summary>The method to set the value to callbackOptions</summary>
			/// <param name="callbackOptions">Instance of FillableCallbackSettings</param>
			set
			{
				 this.callbackOptions=value;

				 this.keyModified["callback_options"] = 1;

			}
		}

		public string RedirectUrl
		{
			/// <summary>The method to get the redirectUrl</summary>
			/// <returns>string representing the redirectUrl</returns>
			get
			{
				return  this.redirectUrl;

			}
			/// <summary>The method to set the value to redirectUrl</summary>
			/// <param name="redirectUrl">string</param>
			set
			{
				 this.redirectUrl=value;

				 this.keyModified["redirect_url"] = 1;

			}
		}

		public string OnsubmitMessage
		{
			/// <summary>The method to get the onsubmitMessage</summary>
			/// <returns>string representing the onsubmitMessage</returns>
			get
			{
				return  this.onsubmitMessage;

			}
			/// <summary>The method to set the value to onsubmitMessage</summary>
			/// <param name="onsubmitMessage">string</param>
			set
			{
				 this.onsubmitMessage=value;

				 this.keyModified["onsubmit_message"] = 1;

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