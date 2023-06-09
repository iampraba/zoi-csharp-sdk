using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class CompareDocumentParameters : Model
	{
		private StreamWrapper document1;
		private string url1;
		private StreamWrapper document2;
		private string url2;
		private string title;
		private string lang;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public StreamWrapper Document1
		{
			/// <summary>The method to get the document1</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.document1;

			}
			/// <summary>The method to set the value to document1</summary>
			/// <param name="document1">Instance of StreamWrapper</param>
			set
			{
				 this.document1=value;

				 this.keyModified["document1"] = 1;

			}
		}

		public string Url1
		{
			/// <summary>The method to get the url1</summary>
			/// <returns>string representing the url1</returns>
			get
			{
				return  this.url1;

			}
			/// <summary>The method to set the value to url1</summary>
			/// <param name="url1">string</param>
			set
			{
				 this.url1=value;

				 this.keyModified["url1"] = 1;

			}
		}

		public StreamWrapper Document2
		{
			/// <summary>The method to get the document2</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.document2;

			}
			/// <summary>The method to set the value to document2</summary>
			/// <param name="document2">Instance of StreamWrapper</param>
			set
			{
				 this.document2=value;

				 this.keyModified["document2"] = 1;

			}
		}

		public string Url2
		{
			/// <summary>The method to get the url2</summary>
			/// <returns>string representing the url2</returns>
			get
			{
				return  this.url2;

			}
			/// <summary>The method to set the value to url2</summary>
			/// <param name="url2">string</param>
			set
			{
				 this.url2=value;

				 this.keyModified["url2"] = 1;

			}
		}

		public string Title
		{
			/// <summary>The method to get the title</summary>
			/// <returns>string representing the title</returns>
			get
			{
				return  this.title;

			}
			/// <summary>The method to set the value to title</summary>
			/// <param name="title">string</param>
			set
			{
				 this.title=value;

				 this.keyModified["title"] = 1;

			}
		}

		public string Lang
		{
			/// <summary>The method to get the lang</summary>
			/// <returns>string representing the lang</returns>
			get
			{
				return  this.lang;

			}
			/// <summary>The method to set the value to lang</summary>
			/// <param name="lang">string</param>
			set
			{
				 this.lang=value;

				 this.keyModified["lang"] = 1;

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