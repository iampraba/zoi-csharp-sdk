using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class CompareDocumentResponse : Model, WriterResponseHandler
	{
		private string compareUrl;
		private string sessionDeleteUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string CompareUrl
		{
			/// <summary>The method to get the compareUrl</summary>
			/// <returns>string representing the compareUrl</returns>
			get
			{
				return  this.compareUrl;

			}
			/// <summary>The method to set the value to compareUrl</summary>
			/// <param name="compareUrl">string</param>
			set
			{
				 this.compareUrl=value;

				 this.keyModified["compare_url"] = 1;

			}
		}

		public string SessionDeleteUrl
		{
			/// <summary>The method to get the sessionDeleteUrl</summary>
			/// <returns>string representing the sessionDeleteUrl</returns>
			get
			{
				return  this.sessionDeleteUrl;

			}
			/// <summary>The method to set the value to sessionDeleteUrl</summary>
			/// <param name="sessionDeleteUrl">string</param>
			set
			{
				 this.sessionDeleteUrl=value;

				 this.keyModified["session_delete_url"] = 1;

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