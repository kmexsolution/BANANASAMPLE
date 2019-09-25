using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.WDR
{
	/// <summary>
	/// 제  목: 중복해제처리사유
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-27 23:00
	/// 설  명: 
	/// </summary>
	public partial class WDR0110 : DemoClient.Controllers.BasePopupForm
	{
		public string Reason { get; set; }

		#region WDR0110 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public WDR0110()
		{
			InitializeComponent();
		}
		#endregion

		#region _btnSave_Click : 사유입력 버튼 클릭
		/// <summary>
		/// 사유입력 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave_Click(object sender, EventArgs e)
		{
			this.Reason			= _txtMEMO.Text;
			this.DialogResult	= System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
		#endregion
	}
}
