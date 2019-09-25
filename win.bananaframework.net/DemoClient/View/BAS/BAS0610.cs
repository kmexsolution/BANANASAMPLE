using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	/// <summary>
	/// 제  목: 공휴일등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-25 01:49
	/// 설  명: 공휴일을 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0610 : DemoClient.Controllers.BasePopupForm
	{
		#region BAS0610 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0610()
		{
			InitializeComponent();
		}
		#endregion

		#region _btnSave_Click : 저장 버튼 클릭 이벤트
		/// <summary>
		/// 저장 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0610_C1"
					, base.GetDate(_dtpWKDAY)
					, _txtWKMEMO.Text
					, ""						// 비고
					, base.GetCookie("USRID")	// 시스템등록자ID
					, base.GetCookie("USRNM")	// 시스템등록자명
					);

				MessageBox.Show("신규 공휴일을 등록하였습니다.");

				_dtpWKDAY.Checked	= false;
				_txtWKMEMO.Text		= "";
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnClose_Click : 닫기 버튼 클릭 이벤트
		/// <summary>
		/// 닫기 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
