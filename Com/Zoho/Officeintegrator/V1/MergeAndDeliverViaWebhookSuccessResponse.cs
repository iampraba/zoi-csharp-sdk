using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class MergeAndDeliverViaWebhookSuccessResponse : Model, WriterResponseHandler
	{
		private string mergeReportDataUrl;
		private List<MergeAndDeliverRecordsMeta> records;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string MergeReportDataUrl
		{
			/// <summary>The method to get the mergeReportDataUrl</summary>
			/// <returns>string representing the mergeReportDataUrl</returns>
			get
			{
				return  this.mergeReportDataUrl;

			}
			/// <summary>The method to set the value to mergeReportDataUrl</summary>
			/// <param name="mergeReportDataUrl">string</param>
			set
			{
				 this.mergeReportDataUrl=value;

				 this.keyModified["merge_report_data_url"] = 1;

			}
		}

		public List<MergeAndDeliverRecordsMeta> Records
		{
			/// <summary>The method to get the records</summary>
			/// <returns>Instance of List<MergeAndDeliverRecordsMeta></returns>
			get
			{
				return  this.records;

			}
			/// <summary>The method to set the value to records</summary>
			/// <param name="records">Instance of List<MergeAndDeliverRecordsMeta></param>
			set
			{
				 this.records=value;

				 this.keyModified["records"] = 1;

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