using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class DocumentDeleteSuccessResponse : Model, WriterResponseHandler
	{
		private bool? documentDeleted;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? DocumentDeleted
		{
			/// <summary>The method to get the documentDeleted</summary>
			/// <returns>bool? representing the documentDeleted</returns>
			get
			{
				return  this.documentDeleted;

			}
			/// <summary>The method to set the value to documentDeleted</summary>
			/// <param name="documentDeleted">bool?</param>
			set
			{
				 this.documentDeleted=value;

				 this.keyModified["document_deleted"] = 1;

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