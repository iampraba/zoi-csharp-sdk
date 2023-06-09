using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class WatermarkParameters : Model
	{
		private string url;
		private StreamWrapper document;
		private WatermarkSettings watermarkSettings;
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

		public WatermarkSettings WatermarkSettings
		{
			/// <summary>The method to get the watermarkSettings</summary>
			/// <returns>Instance of WatermarkSettings</returns>
			get
			{
				return  this.watermarkSettings;

			}
			/// <summary>The method to set the value to watermarkSettings</summary>
			/// <param name="watermarkSettings">Instance of WatermarkSettings</param>
			set
			{
				 this.watermarkSettings=value;

				 this.keyModified["watermark_settings"] = 1;

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