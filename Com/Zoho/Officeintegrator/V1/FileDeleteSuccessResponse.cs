using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FileDeleteSuccessResponse : Model, SheetResponseHandler, ShowResponseHandler
	{
		private string docDelete;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DocDelete
		{
			/// <summary>The method to get the docDelete</summary>
			/// <returns>string representing the docDelete</returns>
			get
			{
				return  this.docDelete;

			}
			/// <summary>The method to set the value to docDelete</summary>
			/// <param name="docDelete">string</param>
			set
			{
				 this.docDelete=value;

				 this.keyModified["doc_delete"] = 1;

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