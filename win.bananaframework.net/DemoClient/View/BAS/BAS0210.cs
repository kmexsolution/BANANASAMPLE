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
	/// 제  목: 이용자정보등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-18 20:05
	/// 설  명: 이용자정보를 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0210 : DemoClient.Controllers.BasePopupForm
	{
		#region BAS0210 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0210()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0210_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0210_Load(object sender, EventArgs e)
		{
			try
			{
				// 이용자구분(상세)
				DataTable _dt03	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A09", "", "", "", "");
				base.SetListItem(_cmbUSR_GUBUN, _dt03, "TOTAL_CODE", "CODE_NAME");

				// 부서(상세)
				DataTable _dt04	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A10", "", "", "", "");
				base.SetListItem(_cmbDEPT_CD, _dt04, "TOTAL_CODE", "CODE_NAME");
				
				// 소속회사
				DataSet _dsCompany				= base.GetDataSet("PCSP_LoadCompany"
					, base.GetCookie("USRID")
					);
				_clbCompany.DataSource			= _dsCompany.Tables[0];
				_clbCompany.ValueMember			= "COMPANY_CD";
				_clbCompany.DisplayMember		= "COMPANY_NM";
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
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
			Common.frmFindZipCode form	= new Common.frmFindZipCode();
			form.ZipCodeTextBox			= _txtZIP_NO;
			form.AddressBasicTextBox	= _txtADDR_BSC;
			DialogResult res			= form.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				_txtADDR_DTL.Focus();
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
				if (_txtPWD1.Text != _txtPWD2.Text)
				{
					MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다.");
					return;
				}

				base.BeginTransaction();

				base.ExecuteNonQuery("PCSP_BAS0210_C1"
					, _txtUSRID.Text							// 이용자ID
					, _txtUSRNM.Text							// 이용자명
					, base.GetEncryptTripleDES(_txtPWD1.Text)	// 비밀번호
					, _cmbUSR_GUBUN.SelectedValue				// 이용자구분(운영회사, 여신사, 채권사)
					, _cmbDEPT_CD.SelectedValue					// 소속부서코드
					, _txtTELNO.Text							// 전화번호
					, _txtFAXNO.Text							// 팩스번호
					, _txtHPNO.Text								// 휴대폰번호
					, _txtEMAIL.Text							// 이메일
					, _txtZIP_NO.Text							// 우편번호
					, _txtADDR_BSC.Text							// 기본주소
					, _txtADDR_DTL.Text							// 상세주소
					, _txtMEMO.Text								// 메모
					, ""										// 비고
					, base.GetCookie("USRID")					// 시스템등록자ID
					, base.GetCookie("USRNM")					// 시스템등록자명
					);

				foreach (var value in _clbCompany.CheckedItems)
				{
					DataRowView castedItem	= value as DataRowView;
					string comapnyCode		= castedItem["COMPANY_CD"].ToString();
					base.ExecuteNonQuery("PCSP_BAS0210_C2"
						, _txtUSRID.Text
						, comapnyCode
						);
				}

				base.CommitTransaction();

				MessageBox.Show("신규 이용자를 등록 하였습니다.");
				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				base.RollbackTransaction();
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
