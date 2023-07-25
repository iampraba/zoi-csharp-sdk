using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SheetCallbackSettings : Model
	{
		private string saveFormat;
		private string saveUrl;
		private Dictionary<string, object> saveUrlParams;
		private Dictionary<string, object> saveUrlHeaders;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string SaveFormat
		{
			/// <summary>The method to get the saveFormat</summary>
			/// <returns>string representing the saveFormat</returns>
			get
			{
				return  this.saveFormat;

			}
			/// <summary>The method to set the value to saveFormat</summary>
			/// <param name="saveFormat">string</param>
			set
			{
				 this.saveFormat=value;

				 this.keyModified["save_format"] = 1;

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

		public Dictionary<string, object> SaveUrlParams
		{
			/// <summary>The method to get the saveUrlParams</summary>
			/// <returns>Dictionary representing the saveUrlParams<String,Object></returns>
			get
			{
				return  this.saveUrlParams;

			}
			/// <summary>The method to set the value to saveUrlParams</summary>
			/// <param name="saveUrlParams">Dictionary<string,object></param>
			set
			{
				 this.saveUrlParams=value;

				 this.keyModified["save_url_params"] = 1;

			}
		}

		public Dictionary<string, object> SaveUrlHeaders
		{
			/// <summary>The method to get the saveUrlHeaders</summary>
			/// <returns>Dictionary representing the saveUrlHeaders<String,Object></returns>
			get
			{
				return  this.saveUrlHeaders;

			}
			/// <summary>The method to set the value to saveUrlHeaders</summary>
			/// <param name="saveUrlHeaders">Dictionary<string,object></param>
			set
			{
				 this.saveUrlHeaders=value;

				 this.keyModified["save_url_headers"] = 1;

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