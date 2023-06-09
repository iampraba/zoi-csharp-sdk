using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FillableLinkResponse : Model, WriterResponseHandler
	{
		private string fillableFormUrl;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string FillableFormUrl
		{
			/// <summary>The method to get the fillableFormUrl</summary>
			/// <returns>string representing the fillableFormUrl</returns>
			get
			{
				return  this.fillableFormUrl;

			}
			/// <summary>The method to set the value to fillableFormUrl</summary>
			/// <param name="fillableFormUrl">string</param>
			set
			{
				 this.fillableFormUrl=value;

				 this.keyModified["fillable_form_url"] = 1;

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