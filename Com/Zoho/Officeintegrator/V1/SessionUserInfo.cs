using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SessionUserInfo : Model
	{
		private string displayName;
		private string userId;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayName
		{
			/// <summary>The method to get the displayName</summary>
			/// <returns>string representing the displayName</returns>
			get
			{
				return  this.displayName;

			}
			/// <summary>The method to set the value to displayName</summary>
			/// <param name="displayName">string</param>
			set
			{
				 this.displayName=value;

				 this.keyModified["display_name"] = 1;

			}
		}

		public string UserId
		{
			/// <summary>The method to get the userId</summary>
			/// <returns>string representing the userId</returns>
			get
			{
				return  this.userId;

			}
			/// <summary>The method to set the value to userId</summary>
			/// <param name="userId">string</param>
			set
			{
				 this.userId=value;

				 this.keyModified["user_id"] = 1;

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