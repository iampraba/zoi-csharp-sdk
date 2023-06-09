using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FillableLinkOutputSettings : Model
	{
		private string format;
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