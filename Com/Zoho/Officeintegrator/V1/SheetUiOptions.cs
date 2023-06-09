using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SheetUiOptions : Model
	{
		private string saveButton;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string SaveButton
		{
			/// <summary>The method to get the saveButton</summary>
			/// <returns>string representing the saveButton</returns>
			get
			{
				return  this.saveButton;

			}
			/// <summary>The method to set the value to saveButton</summary>
			/// <param name="saveButton">string</param>
			set
			{
				 this.saveButton=value;

				 this.keyModified["save_button"] = 1;

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