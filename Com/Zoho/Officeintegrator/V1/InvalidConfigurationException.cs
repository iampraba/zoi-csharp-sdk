using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class InvalidConfigurationException : Model, WriterResponseHandler, SheetResponseHandler, ShowResponseHandler, ResponseHandler
	{
		private string keyName;
		private int? code;
		private string parameterName;
		private string message;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string KeyName
		{
			/// <summary>The method to get the keyName</summary>
			/// <returns>string representing the keyName</returns>
			get
			{
				return  this.keyName;

			}
			/// <summary>The method to set the value to keyName</summary>
			/// <param name="keyName">string</param>
			set
			{
				 this.keyName=value;

				 this.keyModified["key_name"] = 1;

			}
		}

		public int? Code
		{
			/// <summary>The method to get the code</summary>
			/// <returns>int? representing the code</returns>
			get
			{
				return  this.code;

			}
			/// <summary>The method to set the value to code</summary>
			/// <param name="code">int?</param>
			set
			{
				 this.code=value;

				 this.keyModified["code"] = 1;

			}
		}

		public string ParameterName
		{
			/// <summary>The method to get the parameterName</summary>
			/// <returns>string representing the parameterName</returns>
			get
			{
				return  this.parameterName;

			}
			/// <summary>The method to set the value to parameterName</summary>
			/// <param name="parameterName">string</param>
			set
			{
				 this.parameterName=value;

				 this.keyModified["parameter_name"] = 1;

			}
		}

		public string Message
		{
			/// <summary>The method to get the message</summary>
			/// <returns>string representing the message</returns>
			get
			{
				return  this.message;

			}
			/// <summary>The method to set the value to message</summary>
			/// <param name="message">string</param>
			set
			{
				 this.message=value;

				 this.keyModified["message"] = 1;

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