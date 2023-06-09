using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class MergeAndDeliverRecordsMeta : Model
	{
		private string downloadLink;
		private string email;
		private string name;
		private string status;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DownloadLink
		{
			/// <summary>The method to get the downloadLink</summary>
			/// <returns>string representing the downloadLink</returns>
			get
			{
				return  this.downloadLink;

			}
			/// <summary>The method to set the value to downloadLink</summary>
			/// <param name="downloadLink">string</param>
			set
			{
				 this.downloadLink=value;

				 this.keyModified["download_link"] = 1;

			}
		}

		public string Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>string representing the email</returns>
			get
			{
				return  this.email;

			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">string</param>
			set
			{
				 this.email=value;

				 this.keyModified["email"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

			}
		}

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