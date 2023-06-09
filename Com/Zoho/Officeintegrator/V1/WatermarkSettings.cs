using Com.Zoho.Util;
using System.Collections.Generic;

namespace Com.Zoho.Officeintegrator.V1
{

	public class WatermarkSettings : Model
	{
		private string text;
		private string type;
		private string orientation;
		private string fontName;
		private int? fontSize;
		private string fontColor;
		private double? opacity;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Text
		{
			/// <summary>The method to get the text</summary>
			/// <returns>string representing the text</returns>
			get
			{
				return  this.text;

			}
			/// <summary>The method to set the value to text</summary>
			/// <param name="text">string</param>
			set
			{
				 this.text=value;

				 this.keyModified["text"] = 1;

			}
		}

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

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

		public string FontColor
		{
			/// <summary>The method to get the fontColor</summary>
			/// <returns>string representing the fontColor</returns>
			get
			{
				return  this.fontColor;

			}
			/// <summary>The method to set the value to fontColor</summary>
			/// <param name="fontColor">string</param>
			set
			{
				 this.fontColor=value;

				 this.keyModified["font_color"] = 1;

			}
		}

		public double? Opacity
		{
			/// <summary>The method to get the opacity</summary>
			/// <returns>double? representing the opacity</returns>
			get
			{
				return  this.opacity;

			}
			/// <summary>The method to set the value to opacity</summary>
			/// <param name="opacity">double?</param>
			set
			{
				 this.opacity=value;

				 this.keyModified["opacity"] = 1;

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