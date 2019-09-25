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
	/// 제  목: 대출한도등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-22 22:29
	/// 설  명: 가맹점의 대출한도를 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0809 : DemoClient.Controllers.BasePopupForm
	{
		public string STR_CD { get; set; }
		public string STR_NM { get; set; }

		#region BAS0809 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0809()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0809_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0809_Load(object sender, EventArgs e)
		{
		}
		#endregion

		#region BAS0809_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0809_Shown(object sender, EventArgs e)
		{
			_txtCI_UNIT_LMT.Focus();
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
				if (_txtCI_UNIT_LMT.Text == "")
				{
					MessageBox.Show("건별대출한도는 필수 입력 사항입니다.");
					_txtCI_UNIT_LMT.Focus();
					return;
				}
				else if (_txtCI_DAILY_LMT.Text == "")
				{
					MessageBox.Show("1일대출한도는 필수 입력 사항입니다.");
					_txtCI_DAILY_LMT.Focus();
					return;
				}
				else if (_txtCI_TOT_LMT.Text == "")
				{
					MessageBox.Show("총대출한도는 필수 입력 사항입니다.");
					_txtCI_TOT_LMT.Focus();
					return;
				}
				else if (!_dtpCI_LMT_APP_DT.Checked)
				{
					MessageBox.Show("적용시작일은 필수 입력 사항입니다.");
					_dtpCI_LMT_APP_DT.Focus();
					return;
				}

				base.ExecuteNonQuery("PCSP_BAS0809_C1"
					, this.STR_CD							// 가맹점코드
					, base.GetDate(_dtpCI_LMT_APP_DT)		// 적용시작일
					, base.GetInteger(_txtCI_UNIT_LMT)		// 건별대출한도
					, base.GetInteger(_txtCI_DAILY_LMT)		// 1일대출한도
					, base.GetInteger(_txtCI_TOT_LMT)		// 총대출한도
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				MessageBox.Show("대출한도를 등록 하였습니다.");
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
