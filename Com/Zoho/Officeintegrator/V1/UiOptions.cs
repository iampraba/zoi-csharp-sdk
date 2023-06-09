using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class UiOptions : Model
	{
		private string saveButton;
		private string chatPanel;
		private string fileMenu;
		private string darkMode;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string SaveButton
		{
			/// <summary>The method to get the saveButton</summary>
			/// <returns>string representing the saveButton</returns>
			get
			{
				return  this.saveButton;

			}
			/// <summary>The method to set the value to saveButton</summary>
			/// <param name="saveButton">string</param>
			set
			{
				 this.saveButton=value;

				 this.keyModified["save_button"] = 1;

			}
		}

		public string ChatPanel
		{
			/// <summary>The method to get the chatPanel</summary>
			/// <returns>string representing the chatPanel</returns>
			get
			{
				return  this.chatPanel;

			}
			/// <summary>The method to set the value to chatPanel</summary>
			/// <param name="chatPanel">string</param>
			set
			{
				 this.chatPanel=value;

				 this.keyModified["chat_panel"] = 1;

			}
		}

		public string FileMenu
		{
			/// <summary>The method to get the fileMenu</summary>
			/// <returns>string representing the fileMenu</returns>
			get
			{
				return  this.fileMenu;

			}
			/// <summary>The method to set the value to fileMenu</summary>
			/// <param name="fileMenu">string</param>
			set
			{
				 this.fileMenu=value;

				 this.keyModified["file_menu"] = 1;

			}
		}

		public string DarkMode
		{
			/// <summary>The method to get the darkMode</summary>
			/// <returns>string representing the darkMode</returns>
			get
			{
				return  this.darkMode;

			}
			/// <summary>The method to set the value to darkMode</summary>
			/// <param name="darkMode">string</param>
			set
			{
				 this.darkMode=value;

				 this.keyModified["dark_mode"] = 1;

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