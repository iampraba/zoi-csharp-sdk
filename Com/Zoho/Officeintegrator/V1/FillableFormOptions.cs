using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FillableFormOptions : Model
	{
		private bool? download;
		private bool? print;
		private bool? submit;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public bool? Download
		{
			/// <summary>The method to get the download</summary>
			/// <returns>bool? representing the download</returns>
			get
			{
				return  this.download;

			}
			/// <summary>The method to set the value to download</summary>
			/// <param name="download">bool?</param>
			set
			{
				 this.download=value;

				 this.keyModified["download"] = 1;

			}
		}

		public bool? Print
		{
			/// <summary>The method to get the print</summary>
			/// <returns>bool? representing the print</returns>
			get
			{
				return  this.print;

			}
			/// <summary>The method to set the value to print</summary>
			/// <param name="print">bool?</param>
			set
			{
				 this.print=value;

				 this.keyModified["print"] = 1;

			}
		}

		public bool? Submit
		{
			/// <summary>The method to get the submit</summary>
			/// <returns>bool? representing the submit</returns>
			get
			{
				return  this.submit;

			}
			/// <summary>The method to set the value to submit</summary>
			/// <param name="submit">bool?</param>
			set
			{
				 this.submit=value;

				 this.keyModified["submit"] = 1;

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