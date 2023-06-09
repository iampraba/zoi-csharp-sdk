using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class SessionMeta : Model, WriterResponseHandler, SheetResponseHandler, ShowResponseHandler
	{
		private string status;
		private SessionInfo info;
		private SessionUserInfo userInfo;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Status
		{
			/// <summary>The method to get the status</summary>
			/// <returns>string representing the status</returns>
			get
			{
				return  this.status;

			}
			/// <summary>The method to set the value to status</summary>
			/// <param name="status">string</param>
			set
			{
				 this.status=value;

				 this.keyModified["status"] = 1;

			}
		}

		public SessionInfo Info
		{
			/// <summary>The method to get the info</summary>
			/// <returns>Instance of SessionInfo</returns>
			get
			{
				return  this.info;

			}
			/// <summary>The method to set the value to info</summary>
			/// <param name="info">Instance of SessionInfo</param>
			set
			{
				 this.info=value;

				 this.keyModified["info"] = 1;

			}
		}

		public SessionUserInfo UserInfo
		{
			/// <summary>The method to get the userInfo</summary>
			/// <returns>Instance of SessionUserInfo</returns>
			get
			{
				return  this.userInfo;

			}
			/// <summary>The method to set the value to userInfo</summary>
			/// <param name="userInfo">Instance of SessionUserInfo</param>
			set
			{
				 this.userInfo=value;

				 this.keyModified["user_info"] = 1;

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