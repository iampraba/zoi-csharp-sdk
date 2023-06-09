using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SessionDeleteSuccessResponse : Model, SheetResponseHandler, ShowResponseHandler
	{
		private string sessionDelete;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string SessionDelete
		{
			/// <summary>The method to get the sessionDelete</summary>
			/// <returns>string representing the sessionDelete</returns>
			get
			{
				return  this.sessionDelete;

			}
			/// <summary>The method to set the value to sessionDelete</summary>
			/// <param name="sessionDelete">string</param>
			set
			{
				 this.sessionDelete=value;

				 this.keyModified["session_delete"] = 1;

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