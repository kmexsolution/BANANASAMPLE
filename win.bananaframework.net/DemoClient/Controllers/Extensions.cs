using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using mshtml;
using System.Linq;

namespace DemoClient
{
	static class Extensions
	{
		#region AppendText : 리치텍스트박스 색상있는 텍스트 추가
		/// <summary>
		/// 리치텍스트박스 색상있는 텍스트 추가
		/// </summary>
		/// <param name="box"></param>
		/// <param name="text"></param>
		/// <param name="color"></param>
		public static void AppendText(this RichTextBox box, string text, System.Drawing.Color color)
		{
			box.SelectionStart = box.TextLength;
			box.SelectionLength = 0;

			box.SelectionColor = color;
			box.AppendText(text);
			box.SelectionColor = box.ForeColor;
		}
		#endregion

		#region AppendHtml : 리소스 파일을 읽어서 본문에 삽입(HTML)
		/// <summary>
		/// 리소스 파일을 읽어서 본문에 삽입(HTML)
		/// </summary>
		/// <param name="Url"></param>
		public static void AppendHtml(this WebBrowser WebBrowser, string Url)
		{
			try
			{
				var assembly = System.Reflection.Assembly.GetExecutingAssembly();
				string imageContent = string.Empty;
				string htmlContent = string.Empty;

				using (Stream stream = assembly.GetManifestResourceStream(Url))
				using (StreamReader reader = new StreamReader(stream))
				{
					htmlContent = reader.ReadToEnd();
					WebBrowser.DocumentText = htmlContent;
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region AppendJavaScript : 리소스 파일을 읽어서 본문에 삽입(JavaScript)
		/// <summary>
		/// 리소스 파일을 읽어서 본문에 삽입(JavaScript)
		/// </summary>
		/// <param name="Url"></param>
		public static void AppendJavaScript(this WebBrowser WebBrowser, string Url)
		{
			try
			{
				var assembly = System.Reflection.Assembly.GetExecutingAssembly();
				string scriptContent = string.Empty;
				HtmlElement head = WebBrowser.Document.GetElementsByTagName("head")[0];
				HtmlElement scriptEl = WebBrowser.Document.CreateElement("script");
				IHTMLScriptElement scriptElement = (IHTMLScriptElement)scriptEl.DomElement;

				using (Stream stream = assembly.GetManifestResourceStream(Url))
				using (StreamReader reader = new StreamReader(stream))
				{
					scriptContent = reader.ReadToEnd();
					scriptElement.text = scriptContent;
					head.AppendChild(scriptEl);
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region AppendStyleSheet : 리소스 파일을 읽어서 본문에 삽입(StyleSheet)
		/// <summary>
		/// 리소스 파일을 읽어서 본문에 삽입(StyleSheet)
		/// </summary>
		/// <param name="Url"></param>
		public static void AppendStyleSheet(this WebBrowser WebBrowser, string Url)
		{
			try
			{
				var assembly = System.Reflection.Assembly.GetExecutingAssembly();
				string cssContent = string.Empty;

				using (Stream stream = assembly.GetManifestResourceStream(Url))
				using (StreamReader reader = new StreamReader(stream))
				{
					cssContent = reader.ReadToEnd();
					HTMLDocument test = (HTMLDocument)WebBrowser.Document.DomDocument;
					if (test.styleSheets.length < 31)
					{
						IHTMLStyleSheet css = (IHTMLStyleSheet)test.createStyleSheet("", 0);
						css.cssText = cssContent;
					}
					else
					{
						throw new ArgumentException("Could not inject CSS due to styleSheets.length > 31");
					}
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region ConvertToDataTable : List를 DataTable로 변환
		/// <summary>
		/// List를 DataTable로 변환
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="lst"></param>
		/// <returns></returns>
		public static DataTable ConvertToDataTable<T>(this IList<T> lst)
		{
			//create DataTable Structure
			DataTable tbl = CreateTable<T>();
			Type entType = typeof(T);

			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
			//get the list item and add into the list
			foreach (T item in lst)
			{
				DataRow row = tbl.NewRow();
				foreach (PropertyDescriptor prop in properties)
				{
					row[prop.Name] = prop.GetValue(item);
				}
				tbl.Rows.Add(row);
			}

			return tbl;
		}

		static DataTable CreateTable<T>()
		{
			//T –> ClassName
			Type entType = typeof(T);
			//set the datatable name as class name
			DataTable tbl = new DataTable(entType.Name);
			//get the property list
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
			foreach (PropertyDescriptor prop in properties)
			{
				//add property as column
				tbl.Columns.Add(prop.Name, prop.PropertyType);
			}
			return tbl;
		}
		#endregion

        public static decimal Sum(this DataTable dt, string column)
        {
            return dt.AsEnumerable().Sum(p => (decimal)p[column]);
        }
	}
}
