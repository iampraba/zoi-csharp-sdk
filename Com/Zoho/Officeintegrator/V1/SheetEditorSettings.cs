using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SheetEditorSettings : Model
	{
		private string country;
		private string language;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Country
		{
			/// <summary>The method to get the country</summary>
			/// <returns>string representing the country</returns>
			get
			{
				return  this.country;

			}
			/// <summary>The method to set the value to country</summary>
			/// <param name="country">string</param>
			set
			{
				 this.country=value;

				 this.keyModified["country"] = 1;

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