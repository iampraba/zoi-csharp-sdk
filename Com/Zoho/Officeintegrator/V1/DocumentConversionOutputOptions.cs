using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class DocumentConversionOutputOptions : Model
	{
		private string format;
		private string documentName;
		private string password;
		private string includeChanges;
		private string includeComments;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Format
		{
			/// <summary>The method to get the format</summary>
			/// <returns>string representing the format</returns>
			get
			{
				return  this.format;

			}
			/// <summary>The method to set the value to format</summary>
			/// <param name="format">string</param>
			set
			{
				 this.format=value;

				 this.keyModified["format"] = 1;

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

		public string Password
		{
			/// <summary>The method to get the password</summary>
			/// <returns>string representing the password</returns>
			get
			{
				return  this.password;

			}
			/// <summary>The method to set the value to password</summary>
			/// <param name="password">string</param>
			set
			{
				 this.password=value;

				 this.keyModified["password"] = 1;

			}
		}

		public string IncludeChanges
		{
			/// <summary>The method to get the includeChanges</summary>
			/// <returns>string representing the includeChanges</returns>
			get
			{
				return  this.includeChanges;

			}
			/// <summary>The method to set the value to includeChanges</summary>
			/// <param name="includeChanges">string</param>
			set
			{
				 this.includeChanges=value;

				 this.keyModified["include_changes"] = 1;

			}
		}

		public string IncludeComments
		{
			/// <summary>The method to get the includeComments</summary>
			/// <returns>string representing the includeComments</returns>
			get
			{
				return  this.includeComments;

			}
			/// <summary>The method to set the value to includeComments</summary>
			/// <param name="includeComments">string</param>
			set
			{
				 this.includeComments=value;

				 this.keyModified["include_comments"] = 1;

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