using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SheetPreviewParameters : Model
	{
		private string url;
		private StreamWrapper document;
		private string language;
		private Dictionary<string, object> permissions;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Url
		{
			/// <summary>The method to get the url</summary>
			/// <returns>string representing the url</returns>
			get
			{
				return  this.url;

			}
			/// <summary>The method to set the value to url</summary>
			/// <param name="url">string</param>
			set
			{
				 this.url=value;

				 this.keyModified["url"] = 1;

			}
		}

		public StreamWrapper Document
		{
			/// <summary>The method to get the document</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.document;

			}
			/// <summary>The method to set the value to document</summary>
			/// <param name="document">Instance of StreamWrapper</param>
			set
			{
				 this.document=value;

				 this.keyModified["document"] = 1;

			}
		}

		public string Language
		{
			/// <summary>The method to get the language</summary>
			/// <returns>string representing the language</returns>
			get
			{
				return  this.language;

			}
			/// <summary>The method to set the value to language</summary>
			/// <param name="language">string</param>
			set
			{
				 this.language=value;

				 this.keyModified["language"] = 1;

			}
		}

		public Dictionary<string, object> Permissions
		{
			/// <summary>The method to get the permissions</summary>
			/// <returns>Dictionary representing the permissions<String,Object></returns>
			get
			{
				return  this.permissions;

			}
			/// <summary>The method to set the value to permissions</summary>
			/// <param name="permissions">Dictionary<string,object></param>
			set
			{
				 this.permissions=value;

				 this.keyModified["permissions"] = 1;

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