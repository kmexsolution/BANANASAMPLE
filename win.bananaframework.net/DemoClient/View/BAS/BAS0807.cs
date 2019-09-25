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
	/// 제  목: 대출이자등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-15 23:51
	/// 설  명: 가맹점의 대출이자를 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0807 : DemoClient.Controllers.BasePopupForm
	{
		public string STR_CD { get; set; }
		public string STR_NM { get; set; }

		#region BAS0807 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0807()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0807_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0807_Load(object sender, EventArgs e)
		{
			try
			{
				this.Text	= string.Format("{1}({0}) {2}", this.STR_CD, this.STR_NM, this.Text);

				// 수익대리점
				DataTable _dtCI_AGT_CD		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Agent", "", "", base.GetCookie("COMPANY_CD"), "", "");
				base.SetListItem(_cmbCI_AGT_CD, _dtCI_AGT_CD, "TOTAL_CODE", "CODE_NAME", true);

				// 여신사
				DataTable _dtCI_LNR_CD		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Loaner", "", "", "", "", "");
				base.SetListItem(_cmbCI_LNR_CD, _dtCI_LNR_CD, "TOTAL_CODE", "CODE_NAME", true);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0807_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0807_Shown(object sender, EventArgs e)
		{
			_txtCI_LN_RATE.Focus();
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
				base.ExecuteNonQuery("PCSP_BAS0807_C1"
					, this.STR_CD										// 가맹점코드
					, base.GetDecimal(_txtCI_LN_RATE)					// 대출이자율
					, base.GetDecimal(_txtCI_LN_OVD)					// 연체이자율
					, base.GetString(_cmbCI_AGT_CD)						// 수익대리점
					, base.GetDate(_dtpCI_APP_DT)						// 적용시작일
					, base.GetString(_cmbCI_LNR_CD)						// 여신사
					, _rbCI_LN_GUBUN01.Checked ? "A07001" : "A07002"	// 즉시결제대출구분
					, ""												// 비고
					, base.GetCookie("USRID")							// 시스템수정자ID
					, base.GetCookie("USRNM")							// 시스템수정자명
					);

				MessageBox.Show("대출이자율을 등록 하였습니다.");
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
