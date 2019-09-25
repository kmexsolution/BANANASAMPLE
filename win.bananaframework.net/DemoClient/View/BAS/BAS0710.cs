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
	/// 제  목: 대리점정보등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-13 19:21
	/// 설  명: 대리점정보를 신규로 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0710 : DemoClient.Controllers.BasePopupForm
	{
		#region BAS0710 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0710()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0710_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0710_Load(object sender, EventArgs e)
		{
			try
			{
				// 사업자구분
				DataTable _dt	= base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "A01"
					, ""
					, ""
					, ""
					, ""
					);
				base.SetListItem(_cmbBI_BINF_CD
					, _dt
					, "TOTAL_CODE"
					, "CODE_NAME"
					);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				this.Close();
			}
		}
		#endregion

		#region BAS0710_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0710_Shown(object sender, EventArgs e)
		{
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
				if ((!_chkAuto.Checked)
					&& (_txtAGT_CD.Text == ""))
				{
					MessageBox.Show("대리점코드는 필수 입력 사항입니다.");
					_txtAGT_CD.Focus();
					return;
				}

				// 사업자등록번호
				string bizno	= string.Empty;
				if (!base.ValidateFormat(_txtBI_SAUP_NO, "{0:###-##-#####}", out bizno))
					return;

				// 법인등록번호
				string bubinno	= string.Empty;
				if (!base.ValidateFormat(_txtBI_BUBIN_NO, "{0:######-#######}", out bubinno))
					return;

				// 주민등록번호
				string juminno	= string.Empty;
				if (!base.ValidateFormat(_txtPI_CNTZ_NO, "{0:######-#######}", out juminno))
					return;

				//// 우편번호 01
				//string zipno_01	= string.Empty;
				//if (!base.ValidateFormat(_txtZIP_NO, "{0:###-###}", out zipno_01))
				//	return;

				//// 우편번호 02
				//string zipno_02	= string.Empty;
				//if (!base.ValidateFormat(_txtBI_ZIP_NO, "{0:###-###}", out zipno_02))
				//	return;

				//// 우편번호 03
				//string zipno_03	= string.Empty;
				//if (!base.ValidateFormat(_txtPI_ZIP_NO, "{0:###-###}", out zipno_03))
				//	return;

				base.ExecuteNonQuery("PCSP_BAS0710_C1"
					, _chkAuto.Checked ? "AUTO" : _txtAGT_CD.Text	// 대리점코드
					, base.GetCookie("COMPANY_CD")					// 운영회사코드
					, _txtAGT_NM.Text								// 대리점명
					, _txtPRSNT_NM.Text								// 대표자명
					, _txtZIP_NO.Text								// 우편번호
					, _txtADDR_BSC.Text								// 기본주소
					, _txtADDR_DTL.Text								// 상세주소
					, _txtTELNO.Text								// 전화번호
					, _txtFAXNO.Text								// 팩스번호
					, _txtBI_COMPANY_NM.Text						// 법인명(단체명)
					, _txtBI_PRSNT_NM.Text							// 대표자명
					, _cmbBI_BINF_CD.SelectedValue					// 사업자구분
					, _rbBI_SIMTAX_Y.Checked ? "Y" : "N"			// 간이과세여부
					, _txtBI_SAUP_NO.Text							// 사업자등록번호
					, _txtBI_BUBIN_NO.Text							// 법인등록번호
					, _txtBI_ZIP_NO.Text							// 우편번호
					, _txtBI_ADDR_BSC.Text							// 기본주소
					, _txtBI_ADDR_DTL.Text							// 상세주소
					, _txtBI_UPTE.Text								// 업태
					, _txtBI_JONGMOK.Text							// 종목
					, _txtBI_EMAIL.Text								// 세금계산서 이메일
					, _txtPI_PRSNT_NM.Text							// 대표자명
					, base.GetEncryptTripleDES(_txtPI_CNTZ_NO.Text)	// 주민등록번호
					, _txtPI_TELNO.Text								// 자택번호
					, _txtPI_CELLNO.Text							// 휴대폰번호
					, _txtPI_ZIP_NO.Text							// 자택 우편번호
					, _txtPI_ADDR_BSC.Text							// 자택 기본주소
					, _txtPI_ADDR_DTL.Text							// 자택 상세주소
					, _txtPI_EMAIL.Text								// 대표자 이메일
					, ""											// 계약일자
					, ""											// 해지일자
					, null											// 입금은행코드
					, ""											// 계좌번호
					, ""											// 예금주
					, ""											// 로그인ID
					, ""											// 비밀번호
					, ""											// 로그인 가능 일자
					, "Y"											// 일시중지여부
					, _txtMEMO.Text									// 메모
					, ""											// 비고
					, base.GetCookie("USRID")						// 시스템등록자ID
					, base.GetCookie("USRNM")						// 시스템등록자명
					);

				MessageBox.Show("신규 대리점을 등록하였습니다.");
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

		#region _chkAuto_CheckedChanged : 자동채번 체크 이벤트
		/// <summary>
		/// 자동채번 체크 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _chkAuto_CheckedChanged(object sender, EventArgs e)
		{
			if (_chkAuto.Checked)
			{
				_txtAGT_CD.ReadOnly	= true;
			}
			else
			{
				_txtAGT_CD.ReadOnly	= false;
			}
		}
		#endregion

		#region _btnFindZipCode01_Click : 우편번호 찾기 버튼 이벤트
		/// <summary>
		/// 우편번호 찾기 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnFindZipCode01_Click(object sender, EventArgs e)
		{
			Common.frmFindZipCode	form	= new Common.frmFindZipCode();
			form.ZipCodeTextBox				= _txtZIP_NO;
			form.AddressBasicTextBox		= _txtADDR_BSC;
			DialogResult res				= form.ShowDialog();

			if (res == System.Windows.Forms.DialogResult.OK)
			{
				_txtADDR_DTL.Focus();
			}
		}
		#endregion

		#region _btnFindZipCode02_Click : 우편번호 찾기 버튼 이벤트
		/// <summary>
		/// 우편번호 찾기 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnFindZipCode02_Click(object sender, EventArgs e)
		{
			Common.frmFindZipCode	form	= new Common.frmFindZipCode();
			form.ZipCodeTextBox				= _txtBI_ZIP_NO;
			form.AddressBasicTextBox		= _txtBI_ADDR_BSC;
			DialogResult res				= form.ShowDialog();

			if (res == System.Windows.Forms.DialogResult.OK)
			{
				_txtBI_ADDR_DTL.Focus();
			}
		}
		#endregion

		#region _btnFindZipCode03_Click : 우편번호 찾기 버튼 이벤트
		/// <summary>
		/// 우편번호 찾기 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnFindZipCode03_Click(object sender, EventArgs e)
		{
			Common.frmFindZipCode	form	= new Common.frmFindZipCode();
			form.ZipCodeTextBox				= _txtPI_ZIP_NO;
			form.AddressBasicTextBox		= _txtPI_ADDR_BSC;
			DialogResult res				= form.ShowDialog();

			if (res == System.Windows.Forms.DialogResult.OK)
			{
				_txtPI_ADDR_DTL.Focus();
			}
		}
		#endregion

		#region _cmbBI_BINF_CD_DropDownClosed : 법인사업자 = 간이과세 안 됨
		/// <summary>
		/// 법인사업자 = 간이과세 안 됨
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _cmbBI_BINF_CD_DropDownClosed(object sender, EventArgs e)
		{
			if (_cmbBI_BINF_CD.SelectedValue.ToString() == "A01001")
			{
				_rbBI_SIMTAX_N.Checked	= true;
				_rbBI_SIMTAX_Y.Enabled	= false;
				_rbBI_SIMTAX_N.Enabled	= false;
			}
			else
			{
				_rbBI_SIMTAX_Y.Enabled	= true;
				_rbBI_SIMTAX_N.Enabled	= true;
			}
		}
		#endregion
	}
}
