using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class DocumentMeta : Model, WriterResponseHandler
	{
		private string documentId;
		private int? collaboratorsCount;
		private int? activeSessionsCount;
		private string documentName;
		private string documentType;
		private string createdTime;
		private long? createdTimeMs;
		private string expiresOn;
		private long? expiresOnMs;
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

		public int? CollaboratorsCount
		{
			/// <summary>The method to get the collaboratorsCount</summary>
			/// <returns>int? representing the collaboratorsCount</returns>
			get
			{
				return  this.collaboratorsCount;

			}
			/// <summary>The method to set the value to collaboratorsCount</summary>
			/// <param name="collaboratorsCount">int?</param>
			set
			{
				 this.collaboratorsCount=value;

				 this.keyModified["collaborators_count"] = 1;

			}
		}

		public int? ActiveSessionsCount
		{
			/// <summary>The method to get the activeSessionsCount</summary>
			/// <returns>int? representing the activeSessionsCount</returns>
			get
			{
				return  this.activeSessionsCount;

			}
			/// <summary>The method to set the value to activeSessionsCount</summary>
			/// <param name="activeSessionsCount">int?</param>
			set
			{
				 this.activeSessionsCount=value;

				 this.keyModified["active_sessions_count"] = 1;

			}
		}

		public string DocumentName
		{
			/// <summary>The method to get the documentName</summary>
			/// <returns>string representing the documentName</returns>
			get
			{
				return  this.documentName;

			}
			/// <summary>The method to set the value to documentName</summary>
			/// <param name="documentName">string</param>
			set
			{
				 this.documentName=value;

				 this.keyModified["document_name"] = 1;

			}
		}

		public string DocumentType
		{
			/// <summary>The method to get the documentType</summary>
			/// <returns>string representing the documentType</returns>
			get
			{
				return  this.documentType;

			}
			/// <summary>The method to set the value to documentType</summary>
			/// <param name="documentType">string</param>
			set
			{
				 this.documentType=value;

				 this.keyModified["document_type"] = 1;

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