using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient.View.HLP
{
	/// <summary>
	/// 프로그램 사용법
	/// </summary>
	public partial class HLP0200 : Controllers.BaseForm
	{
		#region HLP200 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public HLP0200()
		{
			InitializeComponent();
		}
		#endregion

		#region HLP200_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HLP200_Load(object sender, EventArgs e)
		{
			_wbLeft.AppendHtml("DemoClient.Resources.Manual.HLP200_left.html");
			_wbRight.AppendHtml("DemoClient.Resources.Manual.HLP200_right.html");

			_wbLeft.ObjectForScripting	= new ScriptManager(this);
			_wbRight.ObjectForScripting = new ScriptManager(this);
		}
		#endregion

		#region HLP200_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HLP200_Shown(object sender, EventArgs e)
		{
			this.WindowState	= FormWindowState.Maximized;
		}
		#endregion

		#region CSS 추가
		/// <summary>
		/// CSS 추가
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _wbLeft_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			_wbLeft.AppendStyleSheet("DemoClient.Resources.Manual.HLP200.css");
			_wbLeft.AppendJavaScript("DemoClient.Resources.Manual.HLP200.js");
		}

		private void _wbRight_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			_wbRight.AppendStyleSheet("DemoClient.Resources.Manual.HLP200.css");
			_wbRight.AppendJavaScript("DemoClient.Resources.Manual.HLP200.js");
		}
		#endregion
	}

	#region public class ScriptManager : ScriptManager
	/// <summary>
	/// ScriptManager
	/// </summary>
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public class ScriptManager
	{
		private HLP0200 pForm;

		public ScriptManager(Form _pForm)
		{
			pForm	= (HLP0200)_pForm;
		}

		public void ShowMenu(string MnuCd)
		{
			string fileUrl	= string.Format("DemoClient.Resources.Manual.{0}.html"
				, MnuCd
				);

			pForm._wbRight.AppendHtml(fileUrl);
		}
	}
	#endregion
}
