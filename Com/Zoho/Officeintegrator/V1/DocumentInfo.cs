using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class DocumentInfo : Model
	{
		private string documentName;
		private string documentId;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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