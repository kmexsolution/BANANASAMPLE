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
	/// 제  목: 가맹점.강제출금/자동차감 등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-13 21:24
	/// 설  명: 가맹점의 강제출금/자동차감을 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0828 : DemoClient.Controllers.BasePopupForm
	{
		public int IDX { get; set; }

		#region BAS0828 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0828()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0828_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0828_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpMNS_APP_DT.Value = DateTime.Now;

				// 출금/차감구분
				DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "C01", "", "", "", "");
				base.SetListItem(_cmbMNS_GUBUN_CD, _dt01, "TOTAL_CODE", "CODE_NAME");

				// 출금사유
				DataTable _dt02		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "C02", "", "", "", "");
				base.SetListItem(_cmbMNS_REG_CD, _dt02, "TOTAL_CODE", "CODE_NAME");

				// 차감기준
				DataTable _dt03		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B01", "", "", "", "");
				base.SetListItem(_cmbMNS_GIJUN_CD, _dt03, "TOTAL_CODE", "CODE_NAME");

				// 계산방법
				DataTable _dt04		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B02", "", "", "", "");
				base.SetListItem(_cmbMNS_CAL_CD, _dt04, "TOTAL_CODE", "CODE_NAME");

				// 차감사유
				DataTable _dt05		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "C03", "", "", "", "");
				base.SetListItem(_cmbMNS_REG_CD2, _dt05, "TOTAL_CODE", "CODE_NAME");

				// 회계구분
				DataTable _dt06		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "C05", "", "", "", "");
				base.SetListItem(_cmbMNS_ACCOUNT_CD, _dt06, "TOTAL_CODE", "CODE_NAME");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0828_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0828_Shown(object sender, EventArgs e)
		{
			try
			{
				// 등록
				if (this.IDX == 0)
				{
					_gb1.Visible = true;
					_gb2.Visible = false;
					_btnComplete.Visible = false;
				}
				// 수정
				else
				{
					DataTable _dt = base.GetDataTable(
						"PCSP_BAS0828_R1"
						, this.IDX
						);

					_dtpMNS_APP_DT.Value				= DateTime.Parse(_dt.Rows[0]["MNS_APP_DT"].ToString());			// 적용시작일
					_rbMNS_USE_Y.Checked				= _dt.Rows[0]["MNS_USE_YN"].ToString() == "Y" ? true : false;	// 사용여부(Y/N)
					_rbMNS_USE_N.Checked				= _dt.Rows[0]["MNS_USE_YN"].ToString() == "N" ? true : false;	// 사용여부(Y/N)
					_cmbMNS_GUBUN_CD.SelectedValue		= _dt.Rows[0]["MNS_GUBUN_CD"].ToString();						// 출금/차감구분
					_txtMEMO.Text						= _dt.Rows[0]["MEMO"].ToString();								// 메모

					if (_dt.Rows[0]["MNS_GUBUN_CD"].ToString() == "C01001")
					{
						_txtMNS_AMT_1.Text				= _dt.Rows[0]["MNS_AMT"].ToString();							// 출금금액
						_cmbMNS_REG_CD.SelectedValue	= _dt.Rows[0]["MNS_REG_CD"].ToString();							// 출금/차감사유코드
						_txtMNS_REG_MEMO.Text			= _dt.Rows[0]["MNS_REG_MEMO"].ToString();						// 출금/차감상세사유

						_txtMNS_AMT_2.Text				= "";															// 출금금액
						_cmbMNS_REG_CD2.SelectedIndex	= 0;															// 출금/차감사유코드
						_txtMNS_REG_MEMO2.Text			= "";															// 출금/차감상세사유
						_cmbMNS_GIJUN_CD.SelectedIndex	= 0;															// 차감기준(없음/승인금액/실출금액/입금예정액)
						_cmbMNS_CAL_CD.SelectedIndex	= 0;															// 계산방법(정액/정률)
						_rbMNS_INTST_Y.Checked			= true;															// 정액 미차감 시 이자발생 여부(Y/N)
						_rbMNS_INTST_N.Checked			= false;														// 정액 미차감 시 이자발생 여부(Y/N)
						_txtMNS_PER.Text				= "";															// 차감수치
					}
					else
					{
						_txtMNS_AMT_1.Text				= "";															// 출금금액
						_cmbMNS_REG_CD.SelectedIndex	= 0;															// 출금/차감사유코드
						_txtMNS_REG_MEMO.Text			= "";															// 출금/차감상세사유

						_txtMNS_AMT_2.Text				= _dt.Rows[0]["MNS_AMT"].ToString();							// 차감금액
						// 정액
						if (_dt.Rows[0]["MNS_CAL_CD"].ToString() == "B02001")
						{
							_lblDPST_CAL_CD.Text = "원";
							_txtMNS_PER.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
							_cmbMNS_GIJUN_CD.Enabled = false;
						}
						// 정률
						else if (_dt.Rows[0]["MNS_CAL_CD"].ToString() == "B02002")
						{
							_lblDPST_CAL_CD.Text = "%";
							_txtMNS_PER.ImeMode = BANANA.Windows.Controls.ImeMode.Decimal;
							_cmbMNS_GIJUN_CD.Enabled = true;
						}

						_cmbMNS_REG_CD2.SelectedValue	= _dt.Rows[0]["MNS_REG_CD"].ToString();							// 출금/차감사유코드
						_txtMNS_REG_MEMO2.Text			= _dt.Rows[0]["MNS_REG_MEMO"].ToString();						// 출금/차감상세사유
						_cmbMNS_GIJUN_CD.SelectedValue	= _dt.Rows[0]["MNS_GIJUN_CD"].ToString();						// 차감기준(없음/승인금액/실출금액/입금예정액)
						_cmbMNS_CAL_CD.SelectedValue	= _dt.Rows[0]["MNS_CAL_CD"].ToString();							// 계산방법(정액/정률)
						_rbMNS_INTST_Y.Checked			= _dt.Rows[0]["MNS_INTST_YN"].ToString() == "Y" ? true : false;	// 정액 미차감 시 이자발생 여부(Y/N)
						_rbMNS_INTST_N.Checked			= _dt.Rows[0]["MNS_INTST_YN"].ToString() == "N" ? true : false;	// 정액 미차감 시 이자발생 여부(Y/N)
						_txtMNS_PER.Text				= _dt.Rows[0]["MNS_PER"].ToString();							// 차감수치

						_cmbMNS_ACCOUNT_CD.SelectedValue = _dt.Rows[0]["MNS_ACCOUNT_CD"].ToString();					// 회계구분(C05)

						
					}

					// 차감 상환이 한건이라도 등록이 되었다면 저장 버튼 비 활성화
					if (_dt.Rows[0]["MNS_ACTN_AMT"].ToString() != "0")
					{
						_btnSave.Visible				= false;
					}

					// 처리 완료가 되면 일괄처리 버튼 안보이게 함
					if (_dt.Rows[0]["ISCOMPLETE"].ToString() == "Y")
					{
						_btnComplete.Visible			= false;
					}
					
					_cmbMNS_GUBUN_CD.Enabled			= false;
					_dtpMNS_APP_DT.Enabled				= false;

					SetEnabled();
				}

				_cmbMNS_GUBUN_CD.Focus();
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
				// 자동차감일 경우에만 체크한다.
				if (_cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01002")
				{
					if ((_cmbMNS_CAL_CD.SelectedValue.ToString() == "B02002")
						&& (_cmbMNS_GIJUN_CD.SelectedValue.ToString() == "B01001"))
					{
						MessageBox.Show("계산방법이 정률일 경우에는 차감기준을 선택하셔야 합니다.");
						return;
					}
				}
				
				// 등록
				if (this.IDX == 0)
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0828_C1"
						, STR_CD.Text										// 가맹점번호
						, _dtpMNS_APP_DT.Value.ToString("yyyy-MM-dd")		// 적용시작일
						, _rbMNS_USE_Y.Checked ? "Y" : "N"					// 사용여부(Y/N)
						, _cmbMNS_GUBUN_CD.SelectedValue					// 출금/차감구분
						//, PLS_IDX											// 상환일련번호
						, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? base.GetDecimal(_txtMNS_AMT_1) : base.GetDecimal(_txtMNS_AMT_2)	// 출금금액
						, "N"												// 실행여부(Y/N)
						, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? _cmbMNS_REG_CD.SelectedValue : _cmbMNS_REG_CD2.SelectedValue		// 출금/차감사유코드
						, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? _txtMNS_REG_MEMO.Text : _txtMNS_REG_MEMO2.Text					// 출금/차감상세사유
						, _cmbMNS_GIJUN_CD.SelectedValue					// 차감기준(없음/승인금액/실출금액/입금예정액)
						, _cmbMNS_CAL_CD.SelectedValue						// 계산방법(정액/정률)
						, _rbMNS_INTST_Y.Checked ? "Y" : "N"				// 정액 미차감 시 이자발생 여부(Y/N)
						, _cmbMNS_ACCOUNT_CD.SelectedValue					// 회계구분(C05)
						, base.GetDecimal(_txtMNS_PER)						// 차감수치
						, "N"												// 시스템등록여부(Y/N)
						, _txtMEMO.Text										// 메모
						, ""												// 비고
						, base.GetCookie("USRID")							// 시스템등록자ID
						, base.GetCookie("USRNM")							// 시스템등록자명
						);
				}
				// 수정
				else
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0828_U1"
						, this.IDX									// 일련번호
						//, _dtpMNS_APP_DT.Value.ToString("yyyy-MM-dd")		// 적용시작일
						, _rbMNS_USE_Y.Checked ? "Y" : "N"					// 사용여부(Y/N)
						//, _cmbMNS_GUBUN_CD.SelectedValue					// 출금/차감구분
						//, PLS_IDX											// 상환일련번호
						, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? base.GetDecimal(_txtMNS_AMT_1) : base.GetDecimal(_txtMNS_AMT_2)	// 출금금액
						//, MNS_ACTN_YN										// 실행여부(Y/N)
						, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? _cmbMNS_REG_CD.SelectedValue : _cmbMNS_REG_CD2.SelectedValue		// 출금/차감사유코드
						, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? _txtMNS_REG_MEMO.Text : _txtMNS_REG_MEMO2.Text					// 출금/차감상세사유
						, _cmbMNS_GIJUN_CD.SelectedValue					// 차감기준(없음/승인금액/실출금액/입금예정액)
						, _cmbMNS_CAL_CD.SelectedValue						// 계산방법(정액/정률)
						, _rbMNS_INTST_Y.Checked ? "Y" : "N"				// 정액 미차감 시 이자발생 여부(Y/N)
						, _cmbMNS_ACCOUNT_CD.SelectedValue					// 회계구분(C05)
						, base.GetDecimal(_txtMNS_PER)						// 차감수치
						//, ISSYSTEM										// 시스템등록여부(Y/N)
						, _txtMEMO.Text										// 메모
						, ""										// 비고
						, base.GetCookie("USRID")					// 시스템수정자ID
						, base.GetCookie("USRNM")					// 시스템수정자명
						);
				}

				this.DialogResult = System.Windows.Forms.DialogResult.OK;
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

		#region SetEnabled : 출금/차감 변경 시 컨트롤 활성화 처리
		/// <summary>
		/// 출금/차감 변경 시 컨트롤 활성화 처리
		/// </summary>
		private void SetEnabled()
		{
			// 강제출금
			if (_cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001")
			{
				// 강제출금 컨트롤
				_txtMNS_AMT_1.Enabled		= true;
				_cmbMNS_REG_CD.Enabled		= true;
				_txtMNS_REG_MEMO.Enabled	= true;

				// 자동차감 컨트롤
				_cmbMNS_GIJUN_CD.Enabled	= false;
				_cmbMNS_CAL_CD.Enabled		= false;
				_txtMNS_PER.Enabled			= false;
				_rbMNS_INTST_Y.Enabled		= false;
				_rbMNS_INTST_N.Enabled		= false;
				_cmbMNS_REG_CD2.Enabled		= false;
				_txtMNS_REG_MEMO2.Enabled	= false;

				_txtMNS_AMT_2.Text			= "";
				_txtMNS_PER.Text			= "";

				_gb1.Visible				= true;
				_gb2.Visible				= false;
			}
			// 자동차감
			else if (_cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01002")
			{
				// 강제출금 컨트롤
				_txtMNS_AMT_1.Enabled		= false;
				_cmbMNS_REG_CD.Enabled		= false;
				_txtMNS_REG_MEMO.Enabled	= false;

				_txtMNS_AMT_1.Text			= "";

				// 자동차감 컨트롤
				_cmbMNS_GIJUN_CD.Enabled	= true;
				_cmbMNS_CAL_CD.Enabled		= true;
				_txtMNS_PER.Enabled			= true;
				_rbMNS_INTST_Y.Enabled		= true;
				_rbMNS_INTST_N.Enabled		= true;
				_cmbMNS_REG_CD2.Enabled		= true;
				_txtMNS_REG_MEMO2.Enabled	= true;

				_gb1.Visible				= false;
				_gb2.Visible				= true;

				if (_cmbMNS_ACCOUNT_CD.SelectedValue.ToString() != "C05001")
				{
					_rbMNS_INTST_Y.Enabled = false;
					_rbMNS_INTST_N.Enabled = false;
					_cmbMNS_CAL_CD.Enabled = false;
					_cmbMNS_GIJUN_CD.Enabled = false;
				}
			}
		}
		#endregion

		#region _cmbMNS_GUBUN_CD_DropDownClosed : 출금/차감구분 변경 이벤트
		/// <summary>
		/// 출금/차감구분 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _cmbMNS_GUBUN_CD_DropDownClosed(object sender, EventArgs e)
		{
			SetEnabled();

			if (_cmbMNS_CAL_CD.SelectedValue.ToString() == "B02001")
			{
				_cmbMNS_GIJUN_CD.SelectedValue = "B01001";
				_cmbMNS_GIJUN_CD.Enabled = false;
			}
		}
		#endregion

		#region _cmbMNS_CAL_CD_DropDownClosed : 계산방법 변경 이벤트
		/// <summary>
		/// 계산방법 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _cmbMNS_CAL_CD_DropDownClosed(object sender, EventArgs e)
		{
			// 정액
			if (_cmbMNS_CAL_CD.SelectedValue.ToString() == "B02001")
			{
				_lblDPST_CAL_CD.Text			= "원";
				_txtMNS_PER.ImeMode				= BANANA.Windows.Controls.ImeMode.Integer;
				_txtMNS_PER.Text				= _txtMNS_PER.Text.Replace(".", "");
				_cmbMNS_GIJUN_CD.SelectedValue	= "B01001";
				_cmbMNS_GIJUN_CD.Enabled		= false;
			}
			// 정률
			else if (_cmbMNS_CAL_CD.SelectedValue.ToString() == "B02002")
			{
				_lblDPST_CAL_CD.Text			= "%";
				_txtMNS_PER.ImeMode				= BANANA.Windows.Controls.ImeMode.Decimal;
				_cmbMNS_GIJUN_CD.Enabled		= true;
			}
		}
		#endregion

		#region _btnSTR_Search_Click : 가맹점 검색 버튼 클릭 이벤트
		/// <summary>
		/// 가맹점 검색 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSTR_Search_Click(object sender, EventArgs e)
		{
			try
			{
				Common.STR_Form form	= new Common.STR_Form();
				DialogResult res		= form.ShowDialog();

				if (res == System.Windows.Forms.DialogResult.OK)
				{
					STR_CD.Text			= form.strSTR_Data.Split('|')[0];	// 가맹점코드
					STR_NM.Text			= form.strSTR_Data.Split('|')[1];	// 가맹점명
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnComplete_Click : 차감완료 버튼 클릭 이벤트
		/// <summary>
		/// 차감완료 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnComplete_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery(
					"PCSP_BAS0828_U2"
					, this.IDX									// 일련번호
					, ""										// 비고
					, base.GetCookie("USRID")					// 시스템수정자ID
					, base.GetCookie("USRNM")					// 시스템수정자명
					);

				MessageBox.Show("전액 차감 완료를 하였습니다.");

				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _cmbMNS_ACCOUNT_CD_DropDownClosed : 회계구분 코드 변경 이벤트
		/// <summary>
		/// 회계구분 코드 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _cmbMNS_ACCOUNT_CD_DropDownClosed(object sender, EventArgs e)
		{
			// 원금
			if (_cmbMNS_ACCOUNT_CD.SelectedValue.ToString() == "C05001")
			{
				_rbMNS_INTST_Y.Enabled		= true;
				_rbMNS_INTST_N.Enabled		= true;
				_cmbMNS_CAL_CD.Enabled		= true;
			}
			// 그외
			else
			{
				_rbMNS_INTST_Y.Enabled			= false;
				_rbMNS_INTST_N.Enabled			= false;
				_rbMNS_INTST_N.Checked			= true;

				_cmbMNS_CAL_CD.SelectedValue	= "B02001";
				_cmbMNS_CAL_CD.Enabled			= false;
				_lblDPST_CAL_CD.Text			= "원";
				_txtMNS_PER.ImeMode				= BANANA.Windows.Controls.ImeMode.Integer;
				_txtMNS_PER.Text				= _txtMNS_PER.Text.Replace(".", "");
				_cmbMNS_GIJUN_CD.SelectedValue	= "B01001";
				_cmbMNS_GIJUN_CD.Enabled		= false;
			}
		}
		#endregion
	}
}
