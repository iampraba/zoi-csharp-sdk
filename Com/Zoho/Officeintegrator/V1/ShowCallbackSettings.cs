using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class ShowCallbackSettings : Model
	{
		private string saveFormat;
		private string saveUrl;
		private string contextInfo;
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

		public string ContextInfo
		{
			/// <summary>The method to get the contextInfo</summary>
			/// <returns>string representing the contextInfo</returns>
			get
			{
				return  this.contextInfo;

			}
			/// <summary>The method to set the value to contextInfo</summary>
			/// <param name="contextInfo">string</param>
			set
			{
				 this.contextInfo=value;

				 this.keyModified["context_info"] = 1;

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