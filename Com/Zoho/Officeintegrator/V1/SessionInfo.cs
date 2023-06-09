using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SessionInfo : Model
	{
		private string documentId;
		private long? createdTimeMs;
		private string createdTime;
		private long? expiresOnMs;
		private string expiresOn;
		private string sessionUrl;
		private string sessionDeleteUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DocumentId
		{
			/// <summary>The method to get the documentId</summary>
			/// <returns>string representing the documentId</returns>
			get
			{
				return  this.documentId;

			}
			/// <summary>The method to set the value to documentId</summary>
			/// <param name="documentId">string</param>
			set
			{
				 this.documentId=value;

				 this.keyModified["document_id"] = 1;

			}
		}

		public long? CreatedTimeMs
		{
			/// <summary>The method to get the createdTimeMs</summary>
			/// <returns>long? representing the createdTimeMs</returns>
			get
			{
				return  this.createdTimeMs;

			}
			/// <summary>The method to set the value to createdTimeMs</summary>
			/// <param name="createdTimeMs">long?</param>
			set
			{
				 this.createdTimeMs=value;

				 this.keyModified["created_time_ms"] = 1;

			}
		}

		public string CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>string representing the createdTime</returns>
			get
			{
				return  this.createdTime;

			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">string</param>
			set
			{
				 this.createdTime=value;

				 this.keyModified["created_time"] = 1;

			}
		}

		public long? ExpiresOnMs
		{
			/// <summary>The method to get the expiresOnMs</summary>
			/// <returns>long? representing the expiresOnMs</returns>
			get
			{
				return  this.expiresOnMs;

			}
			/// <summary>The method to set the value to expiresOnMs</summary>
			/// <param name="expiresOnMs">long?</param>
			set
			{
				 this.expiresOnMs=value;

				 this.keyModified["expires_on_ms"] = 1;

			}
		}

		public string ExpiresOn
		{
			/// <summary>The method to get the expiresOn</summary>
			/// <returns>string representing the expiresOn</returns>
			get
			{
				return  this.expiresOn;

			}
			/// <summary>The method to set the value to expiresOn</summary>
			/// <param name="expiresOn">string</param>
			set
			{
				 this.expiresOn=value;

				 this.keyModified["expires_on"] = 1;

			}
		}

		public string SessionUrl
		{
			/// <summary>The method to get the sessionUrl</summary>
			/// <returns>string representing the sessionUrl</returns>
			get
			{
				return  this.sessionUrl;

			}
			/// <summary>The method to set the value to sessionUrl</summary>
			/// <param name="sessionUrl">string</param>
			set
			{
				 this.sessionUrl=value;

				 this.keyModified["session_url"] = 1;

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