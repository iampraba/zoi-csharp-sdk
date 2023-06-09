using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class CreateSheetResponse : Model, SheetResponseHandler
	{
		private string documentUrl;
		private string documentId;
		private string saveUrl;
		private string sessionId;
		private string sessionDeleteUrl;
		private string documentDeleteUrl;
		private string gridviewUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DocumentUrl
		{
			/// <summary>The method to get the documentUrl</summary>
			/// <returns>string representing the documentUrl</returns>
			get
			{
				return  this.documentUrl;

			}
			/// <summary>The method to set the value to documentUrl</summary>
			/// <param name="documentUrl">string</param>
			set
			{
				 this.documentUrl=value;

				 this.keyModified["document_url"] = 1;

			}
		}

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

		public string SaveUrl
		{
			/// <summary>The method to get the saveUrl</summary>
			/// <returns>string representing the saveUrl</returns>
			get
			{
				return  this.saveUrl;

			}
			/// <summary>The method to set the value to saveUrl</summary>
			/// <param name="saveUrl">string</param>
			set
			{
				 this.saveUrl=value;

				 this.keyModified["save_url"] = 1;

			}
		}

		public string SessionId
		{
			/// <summary>The method to get the sessionId</summary>
			/// <returns>string representing the sessionId</returns>
			get
			{
				return  this.sessionId;

			}
			/// <summary>The method to set the value to sessionId</summary>
			/// <param name="sessionId">string</param>
			set
			{
				 this.sessionId=value;

				 this.keyModified["session_id"] = 1;

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

		public string DocumentDeleteUrl
		{
			/// <summary>The method to get the documentDeleteUrl</summary>
			/// <returns>string representing the documentDeleteUrl</returns>
			get
			{
				return  this.documentDeleteUrl;

			}
			/// <summary>The method to set the value to documentDeleteUrl</summary>
			/// <param name="documentDeleteUrl">string</param>
			set
			{
				 this.documentDeleteUrl=value;

				 this.keyModified["document_delete_url"] = 1;

			}
		}

		public string GridviewUrl
		{
			/// <summary>The method to get the gridviewUrl</summary>
			/// <returns>string representing the gridviewUrl</returns>
			get
			{
				return  this.gridviewUrl;

			}
			/// <summary>The method to set the value to gridviewUrl</summary>
			/// <param name="gridviewUrl">string</param>
			set
			{
				 this.gridviewUrl=value;

				 this.keyModified["gridview_url"] = 1;

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