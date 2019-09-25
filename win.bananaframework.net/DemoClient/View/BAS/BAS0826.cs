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
	/// 제  목: 가맹점.보증예치금추가
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-12 22:34
	/// 설  명: 가맹점의 보증예치금을 추가하는 화면입니다.
	/// </summary>
	public partial class BAS0826 : DemoClient.Controllers.BasePopupForm
	{
		#region BAS0826 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0826()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0826_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0826_Load(object sender, EventArgs e)
		{
			try
			{
				// 차감기준
				DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B01", "", "", "", "");
				base.SetListItem(_cmbDPST_GIJUN_CD, _dt01, "TOTAL_CODE", "CODE_NAME");

				// 계산방법
				DataTable _dt02		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B02", "", "", "", "");
				base.SetListItem(_cmbDPST_CAL_CD, _dt02, "TOTAL_CODE", "CODE_NAME");

				_dtpDPST_STRT_DT.Checked	= false;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
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
				// 계산방법과 차감기준 체크
				if ((_cmbDPST_CAL_CD.SelectedValue.ToString() == "B02002")
					&& (_cmbDPST_GIJUN_CD.SelectedValue.ToString() == "B01001"))
				{
					MessageBox.Show("계산방법이 정률일 경우에는 차감기준을 선택하셔야 합니다.");
					return;
				}

				base.ExecuteNonQuery("PCSP_BAS0826_C1"
					, STR_CD.Text							// 가맹점코드
					, base.GetDate(_dtpDPST_STRT_DT)		// 적용시작일
					, _rbDPST_USE_Y.Checked ? "Y" : "N"		// 사용여부(Y/N)
					, base.GetString(_cmbDPST_GIJUN_CD)		// 차감기준(없음/승인금액/실출금액/입금예정액)
					, base.GetString(_cmbDPST_CAL_CD)		// 계산방법(정액/정률)
					, _rbDPST_INTST_Y.Checked ? "Y" : "N"	// 정액 미차감 시 이자발생 여부(Y/N)
					, base.GetDecimal(_txtDPST_PER)			// 차감수치
					, base.GetInteger(_txtDPST_AMT)			// 보증한도금액
					, base.GetInteger(_txtDPST_LMT_AMT)		// 일적립한도
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템등록자ID
					, base.GetCookie("USRNM")				// 시스템등록자명
					);

				MessageBox.Show("보증예치금을 등록 하였습니다.");
				this.DialogResult	= System.Windows.Forms.DialogResult.OK;
				this.Close();
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

		#region _cmbDPST_CAL_CD_DropDownClosed : 계산방법 변경 이벤트
		/// <summary>
		/// 계산방법 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _cmbDPST_CAL_CD_DropDownClosed(object sender, EventArgs e)
		{
			// 정액
			if (_cmbDPST_CAL_CD.SelectedValue.ToString() == "B02001")
			{
				_lblDPST_CAL_CD.Text			= "원";
				_txtDPST_PER.ImeMode			= BANANA.Windows.Controls.ImeMode.Integer;
				_txtDPST_PER.Text				= _txtDPST_PER.Text.Replace(".", "");
				_cmbDPST_GIJUN_CD.SelectedValue	= "B01001";
				_cmbDPST_GIJUN_CD.Enabled		= false;
			}
			// 정률
			else if (_cmbDPST_CAL_CD.SelectedValue.ToString() == "B02002")
			{
				_lblDPST_CAL_CD.Text			= "%";
				_txtDPST_PER.ImeMode			= BANANA.Windows.Controls.ImeMode.Decimal;
				_cmbDPST_GIJUN_CD.Enabled		= true;
			}
		}
		#endregion
	}
}
