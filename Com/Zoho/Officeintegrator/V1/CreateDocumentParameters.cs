using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class CreateDocumentParameters : Model
	{
		private string url;
		private StreamWrapper document;
		private CallbackSettings callbackSettings;
		private DocumentDefaults documentDefaults;
		private EditorSettings editorSettings;
		private Dictionary<string, object> permissions;
		private DocumentInfo documentInfo;
		private UserInfo userInfo;
		private UiOptions uiOptions;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public CallbackSettings CallbackSettings
		{
			/// <summary>The method to get the callbackSettings</summary>
			/// <returns>Instance of CallbackSettings</returns>
			get
			{
				return  this.callbackSettings;

			}
			/// <summary>The method to set the value to callbackSettings</summary>
			/// <param name="callbackSettings">Instance of CallbackSettings</param>
			set
			{
				 this.callbackSettings=value;

				 this.keyModified["callback_settings"] = 1;

			}
		}

		public DocumentDefaults DocumentDefaults
		{
			/// <summary>The method to get the documentDefaults</summary>
			/// <returns>Instance of DocumentDefaults</returns>
			get
			{
				return  this.documentDefaults;

			}
			/// <summary>The method to set the value to documentDefaults</summary>
			/// <param name="documentDefaults">Instance of DocumentDefaults</param>
			set
			{
				 this.documentDefaults=value;

				 this.keyModified["document_defaults"] = 1;

			}
		}

		public EditorSettings EditorSettings
		{
			/// <summary>The method to get the editorSettings</summary>
			/// <returns>Instance of EditorSettings</returns>
			get
			{
				return  this.editorSettings;

			}
			/// <summary>The method to set the value to editorSettings</summary>
			/// <param name="editorSettings">Instance of EditorSettings</param>
			set
			{
				 this.editorSettings=value;

				 this.keyModified["editor_settings"] = 1;

			}
		}

		public Dictionary<string, object> Permissions
		{
			/// <summary>The method to get the permissions</summary>
			/// <returns>Dictionary representing the permissions<String,Object></returns>
			get
			{
				return  this.permissions;

			}
			/// <summary>The method to set the value to permissions</summary>
			/// <param name="permissions">Dictionary<string,object></param>
			set
			{
				 this.permissions=value;

				 this.keyModified["permissions"] = 1;

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

		public UiOptions UiOptions
		{
			/// <summary>The method to get the uiOptions</summary>
			/// <returns>Instance of UiOptions</returns>
			get
			{
				return  this.uiOptions;

			}
			/// <summary>The method to set the value to uiOptions</summary>
			/// <param name="uiOptions">Instance of UiOptions</param>
			set
			{
				 this.uiOptions=value;

				 this.keyModified["ui_options"] = 1;

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