using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class FillableLinkParameters : Model
	{
		private StreamWrapper document;
		private string url;
		private DocumentInfo documentInfo;
		private UserInfo userInfo;
		private Dictionary<string, object> prefillData;
		private string formLanguage;
		private FillableSubmissionSettings submitSettings;
		private FillableFormOptions formOptions;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public StreamWrapper Document
		{
			/// <summary>The method to get the document</summary>
			/// <returns>Instance of StreamWrapper</returns>
			get
			{
				return  this.document;

			}
			/// <summary>The method to set the value to document</summary>
			/// <param name="document">Instance of StreamWrapper</param>
			set
			{
				 this.document=value;

				 this.keyModified["document"] = 1;

			}
		}

		public string Url
		{
			/// <summary>The method to get the url</summary>
			/// <returns>string representing the url</returns>
			get
			{
				return  this.url;

			}
			/// <summary>The method to set the value to url</summary>
			/// <param name="url">string</param>
			set
			{
				 this.url=value;

				 this.keyModified["url"] = 1;

			}
		}

		public DocumentInfo DocumentInfo
		{
			/// <summary>The method to get the documentInfo</summary>
			/// <returns>Instance of DocumentInfo</returns>
			get
			{
				return  this.documentInfo;

			}
			/// <summary>The method to set the value to documentInfo</summary>
			/// <param name="documentInfo">Instance of DocumentInfo</param>
			set
			{
				 this.documentInfo=value;

				 this.keyModified["document_info"] = 1;

			}
		}

		public UserInfo UserInfo
		{
			/// <summary>The method to get the userInfo</summary>
			/// <returns>Instance of UserInfo</returns>
			get
			{
				return  this.userInfo;

			}
			/// <summary>The method to set the value to userInfo</summary>
			/// <param name="userInfo">Instance of UserInfo</param>
			set
			{
				 this.userInfo=value;

				 this.keyModified["user_info"] = 1;

			}
		}

		public Dictionary<string, object> PrefillData
		{
			/// <summary>The method to get the prefillData</summary>
			/// <returns>Dictionary representing the prefillData<String,Object></returns>
			get
			{
				return  this.prefillData;

			}
			/// <summary>The method to set the value to prefillData</summary>
			/// <param name="prefillData">Dictionary<string,object></param>
			set
			{
				 this.prefillData=value;

				 this.keyModified["prefill_data"] = 1;

			}
		}

		public string FormLanguage
		{
			/// <summary>The method to get the formLanguage</summary>
			/// <returns>string representing the formLanguage</returns>
			get
			{
				return  this.formLanguage;

			}
			/// <summary>The method to set the value to formLanguage</summary>
			/// <param name="formLanguage">string</param>
			set
			{
				 this.formLanguage=value;

				 this.keyModified["form_language"] = 1;

			}
		}

		public FillableSubmissionSettings SubmitSettings
		{
			/// <summary>The method to get the submitSettings</summary>
			/// <returns>Instance of FillableSubmissionSettings</returns>
			get
			{
				return  this.submitSettings;

			}
			/// <summary>The method to set the value to submitSettings</summary>
			/// <param name="submitSettings">Instance of FillableSubmissionSettings</param>
			set
			{
				 this.submitSettings=value;

				 this.keyModified["submit_settings"] = 1;

			}
		}

		public FillableFormOptions FormOptions
		{
			/// <summary>The method to get the formOptions</summary>
			/// <returns>Instance of FillableFormOptions</returns>
			get
			{
				return  this.formOptions;

			}
			/// <summary>The method to set the value to formOptions</summary>
			/// <param name="formOptions">Instance of FillableFormOptions</param>
			set
			{
				 this.formOptions=value;

				 this.keyModified["form_options"] = 1;

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