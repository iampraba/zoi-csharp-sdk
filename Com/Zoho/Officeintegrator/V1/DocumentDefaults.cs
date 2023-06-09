using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class DocumentDefaults : Model
	{
		private string orientation;
		private string paperSize;
		private string fontName;
		private int? fontSize;
		private string trackChanges;
		private string language;
		private Margin margin;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Orientation
		{
			/// <summary>The method to get the orientation</summary>
			/// <returns>string representing the orientation</returns>
			get
			{
				return  this.orientation;

			}
			/// <summary>The method to set the value to orientation</summary>
			/// <param name="orientation">string</param>
			set
			{
				 this.orientation=value;

				 this.keyModified["orientation"] = 1;

			}
		}

		public string PaperSize
		{
			/// <summary>The method to get the paperSize</summary>
			/// <returns>string representing the paperSize</returns>
			get
			{
				return  this.paperSize;

			}
			/// <summary>The method to set the value to paperSize</summary>
			/// <param name="paperSize">string</param>
			set
			{
				 this.paperSize=value;

				 this.keyModified["paper_size"] = 1;

			}
		}

		public string FontName
		{
			/// <summary>The method to get the fontName</summary>
			/// <returns>string representing the fontName</returns>
			get
			{
				return  this.fontName;

			}
			/// <summary>The method to set the value to fontName</summary>
			/// <param name="fontName">string</param>
			set
			{
				 this.fontName=value;

				 this.keyModified["font_name"] = 1;

			}
		}

		public int? FontSize
		{
			/// <summary>The method to get the fontSize</summary>
			/// <returns>int? representing the fontSize</returns>
			get
			{
				return  this.fontSize;

			}
			/// <summary>The method to set the value to fontSize</summary>
			/// <param name="fontSize">int?</param>
			set
			{
				 this.fontSize=value;

				 this.keyModified["font_size"] = 1;

			}
		}

		public string TrackChanges
		{
			/// <summary>The method to get the trackChanges</summary>
			/// <returns>string representing the trackChanges</returns>
			get
			{
				return  this.trackChanges;

			}
			/// <summary>The method to set the value to trackChanges</summary>
			/// <param name="trackChanges">string</param>
			set
			{
				 this.trackChanges=value;

				 this.keyModified["track_changes"] = 1;

			}
		}

		public string Language
		{
			/// <summary>The method to get the language</summary>
			/// <returns>string representing the language</returns>
			get
			{
				return  this.language;

			}
			/// <summary>The method to set the value to language</summary>
			/// <param name="language">string</param>
			set
			{
				 this.language=value;

				 this.keyModified["language"] = 1;

			}
		}

		public Margin Margin
		{
			/// <summary>The method to get the margin</summary>
			/// <returns>Instance of Margin</returns>
			get
			{
				return  this.margin;

			}
			/// <summary>The method to set the value to margin</summary>
			/// <param name="margin">Instance of Margin</param>
			set
			{
				 this.margin=value;

				 this.keyModified["margin"] = 1;

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