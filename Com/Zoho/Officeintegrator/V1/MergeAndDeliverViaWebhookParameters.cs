using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class MergeAndDeliverViaWebhookParameters : Model
	{
		private StreamWrapper fileContent;
		private string fileUrl;
		private string outputFormat;
		private MailMergeWebhookSettings webhook;
		private string mergeTo;
		private Dictionary<string, object> mergeData;
		private StreamWrapper mergeDataCsvContent;
		private StreamWrapper mergeDataJsonContent;
		private string mergeDataCsvUrl;
		private string mergeDataJsonUrl;
		private string password;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public StreamWrapper FileContent
		{
			/// <summary>The method to get the fileContent</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.fileContent;

			}
			/// <summary>The method to set the value to fileContent</summary>
			/// <param name="fileContent">Instance of StreamWrapper</param>
			set
			{
				 this.fileContent=value;

				 this.keyModified["file_content"] = 1;

			}
		}

		public string FileUrl
		{
			/// <summary>The method to get the fileUrl</summary>
			/// <returns>string representing the fileUrl</returns>
			get
			{
				return  this.fileUrl;

			}
			/// <summary>The method to set the value to fileUrl</summary>
			/// <param name="fileUrl">string</param>
			set
			{
				 this.fileUrl=value;

				 this.keyModified["file_url"] = 1;

			}
		}

		public string OutputFormat
		{
			/// <summary>The method to get the outputFormat</summary>
			/// <returns>string representing the outputFormat</returns>
			get
			{
				return  this.outputFormat;

			}
			/// <summary>The method to set the value to outputFormat</summary>
			/// <param name="outputFormat">string</param>
			set
			{
				 this.outputFormat=value;

				 this.keyModified["output_format"] = 1;

			}
		}

		public MailMergeWebhookSettings Webhook
		{
			/// <summary>The method to get the webhook</summary>
			/// <returns>Instance of MailMergeWebhookSettings</returns>
			get
			{
				return  this.webhook;

			}
			/// <summary>The method to set the value to webhook</summary>
			/// <param name="webhook">Instance of MailMergeWebhookSettings</param>
			set
			{
				 this.webhook=value;

				 this.keyModified["webhook"] = 1;

			}
		}

		public string MergeTo
		{
			/// <summary>The method to get the mergeTo</summary>
			/// <returns>string representing the mergeTo</returns>
			get
			{
				return  this.mergeTo;

			}
			/// <summary>The method to set the value to mergeTo</summary>
			/// <param name="mergeTo">string</param>
			set
			{
				 this.mergeTo=value;

				 this.keyModified["merge_to"] = 1;

			}
		}

		public Dictionary<string, object> MergeData
		{
			/// <summary>The method to get the mergeData</summary>
			/// <returns>Dictionary representing the mergeData<String,Object></returns>
			get
			{
				return  this.mergeData;

			}
			/// <summary>The method to set the value to mergeData</summary>
			/// <param name="mergeData">Dictionary<string,object></param>
			set
			{
				 this.mergeData=value;

				 this.keyModified["merge_data"] = 1;

			}
		}

		public StreamWrapper MergeDataCsvContent
		{
			/// <summary>The method to get the mergeDataCsvContent</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.mergeDataCsvContent;

			}
			/// <summary>The method to set the value to mergeDataCsvContent</summary>
			/// <param name="mergeDataCsvContent">Instance of StreamWrapper</param>
			set
			{
				 this.mergeDataCsvContent=value;

				 this.keyModified["merge_data_csv_content"] = 1;

			}
		}

		public StreamWrapper MergeDataJsonContent
		{
			/// <summary>The method to get the mergeDataJsonContent</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.mergeDataJsonContent;

			}
			/// <summary>The method to set the value to mergeDataJsonContent</summary>
			/// <param name="mergeDataJsonContent">Instance of StreamWrapper</param>
			set
			{
				 this.mergeDataJsonContent=value;

				 this.keyModified["merge_data_json_content"] = 1;

			}
		}

		public string MergeDataCsvUrl
		{
			/// <summary>The method to get the mergeDataCsvUrl</summary>
			/// <returns>string representing the mergeDataCsvUrl</returns>
			get
			{
				return  this.mergeDataCsvUrl;

			}
			/// <summary>The method to set the value to mergeDataCsvUrl</summary>
			/// <param name="mergeDataCsvUrl">string</param>
			set
			{
				 this.mergeDataCsvUrl=value;

				 this.keyModified["merge_data_csv_url"] = 1;

			}
		}

		public string MergeDataJsonUrl
		{
			/// <summary>The method to get the mergeDataJsonUrl</summary>
			/// <returns>string representing the mergeDataJsonUrl</returns>
			get
			{
				return  this.mergeDataJsonUrl;

			}
			/// <summary>The method to set the value to mergeDataJsonUrl</summary>
			/// <param name="mergeDataJsonUrl">string</param>
			set
			{
				 this.mergeDataJsonUrl=value;

				 this.keyModified["merge_data_json_url"] = 1;

			}
		}

		public string Password
		{
			/// <summary>The method to get the password</summary>
			/// <returns>string representing the password</returns>
			get
			{
				return  this.password;

			}
			/// <summary>The method to set the value to password</summary>
			/// <param name="password">string</param>
			set
			{
				 this.password=value;

				 this.keyModified["password"] = 1;

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