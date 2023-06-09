using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class Margin : Model
	{
		private string left;
		private string right;
		private string top;
		private string bottom;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Left
		{
			/// <summary>The method to get the left</summary>
			/// <returns>string representing the left</returns>
			get
			{
				return  this.left;

			}
			/// <summary>The method to set the value to left</summary>
			/// <param name="left">string</param>
			set
			{
				 this.left=value;

				 this.keyModified["left"] = 1;

			}
		}

		public string Right
		{
			/// <summary>The method to get the right</summary>
			/// <returns>string representing the right</returns>
			get
			{
				return  this.right;

			}
			/// <summary>The method to set the value to right</summary>
			/// <param name="right">string</param>
			set
			{
				 this.right=value;

				 this.keyModified["right"] = 1;

			}
		}

		public string Top
		{
			/// <summary>The method to get the top</summary>
			/// <returns>string representing the top</returns>
			get
			{
				return  this.top;

			}
			/// <summary>The method to set the value to top</summary>
			/// <param name="top">string</param>
			set
			{
				 this.top=value;

				 this.keyModified["top"] = 1;

			}
		}

		public string Bottom
		{
			/// <summary>The method to get the bottom</summary>
			/// <returns>string representing the bottom</returns>
			get
			{
				return  this.bottom;

			}
			/// <summary>The method to set the value to bottom</summary>
			/// <param name="bottom">string</param>
			set
			{
				 this.bottom=value;

				 this.keyModified["bottom"] = 1;

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