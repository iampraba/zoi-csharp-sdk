using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class GetMergeFieldsParameters : Model
	{
		private StreamWrapper fileContent;
		private string fileUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public StreamWrapper FileContent
		{
			/// <summary>The method to get the fileContent</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.fileContent;

			}
			/// <summary>The method to set the value to fileContent</summary>
			/// <param name="fileContent">Instance of StreamWrapper</param>
			set
			{
				 this.fileContent=value;

				 this.keyModified["file_content"] = 1;

			}
		}

		public string FileUrl
		{
			/// <summary>The method to get the fileUrl</summary>
			/// <returns>string representing the fileUrl</returns>
			get
			{
				return  this.fileUrl;

			}
			/// <summary>The method to set the value to fileUrl</summary>
			/// <param name="fileUrl">string</param>
			set
			{
				 this.fileUrl=value;

				 this.keyModified["file_url"] = 1;

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