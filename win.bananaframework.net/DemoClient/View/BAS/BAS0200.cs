using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	/// <summary>
	/// 제  목: 이용자정보관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-18 12:03
	/// 설  명: 이용자정보를 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0200 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region BAS0200 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0200()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0200_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0200_Load(object sender, EventArgs e)
		{
			try
			{
				// 이용자구분(검색)
				DataTable _dt01	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A09", "", "", "", "");
				base.SetListItem(_cmbUSR_GUBUN_S, _dt01, "TOTAL_CODE", "CODE_NAME", true);

				// 부서(검색)
				DataTable _dt02	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A10", "", "", "", "");
				base.SetListItem(_cmbDEPT_CD_S, _dt02, "TOTAL_CODE", "CODE_NAME", true);
				
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

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
			_txtUSRID.Text				= "";
			_txtUSRNM.Text				= "";
			_cmbUSR_GUBUN.SelectedIndex	= 0;
			_txtPWD1.Text				= "";
			_txtPWD2.Text				= "";
			_cmbDEPT_CD.SelectedIndex	= 0;
			_txtTELNO.Text				= "";
			_txtFAXNO.Text				= "";
			_txtHPNO.Text				= "";
			_txtZIP_NO.Text				= "";
			_txtADDR_BSC.Text			= "";
			_txtADDR_DTL.Text			= "";
			_txtEMAIL.Text				= "";
			_lblLST_LGN_TIME.Text		= "";
			_lblWRNG_PWD_CNT.Text		= "";
			_lblLCK_ACCT.Text			= "";
			for(int i = 0; i < _clbCompany.Items.Count; i++)
			{
				_clbCompany.SetItemChecked(i, false);
			}
			_txtMEMO.Text				= "";
		}
		#endregion
		
		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtUSRNM_S.ReadOnly		= !_bTrue;
			_cmbUSR_GUBUN_S.Enabled		= _bTrue;
			_cmbDEPT_CD_S.Enabled		= _bTrue;
			_txtUSRID_S.ReadOnly		= !_bTrue;
			_rbLCK_ACCT_A.Enabled		= _bTrue;
			_rbLCK_ACCT_Y.Enabled		= _bTrue;
			_rbLCK_ACCT_N.Enabled		= _bTrue;

			_btnSearch.Enabled			= _bTrue;
			gridView1.Enabled			= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			_txtUSRNM.ReadOnly			= !_bTrue;
			_cmbUSR_GUBUN.Enabled		= _bTrue;
			_txtPWD1.ReadOnly			= !_bTrue;
			_txtPWD2.ReadOnly			= !_bTrue;
			_cmbDEPT_CD.Enabled			= _bTrue;
			_txtTELNO.ReadOnly			= !_bTrue;
			_txtFAXNO.ReadOnly			= !_bTrue;
			_txtHPNO.ReadOnly			= !_bTrue;
			_txtZIP_NO.ReadOnly			= !_bTrue;
			_txtADDR_BSC.ReadOnly		= !_bTrue;
			_txtADDR_DTL.ReadOnly		= !_bTrue;
			_txtEMAIL.ReadOnly			= !_bTrue;
			_clbCompany.Enabled			= _bTrue;
			_txtMEMO.ReadOnly			= !_bTrue;

			_btnFindZipCode01.Enabled	= _bTrue;
			_btnSave.Enabled			= _bTrue;
			_btnDel.Enabled				= _bTrue;
		}
		#endregion

		#region _btnSearch_Click : 검색 버튼 클릭 이벤트
		/// <summary>
		/// 검색 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSearch_Click(object sender, EventArgs e)
		{

        }

        /// <summary>
        /// 검색 쓰레드
        /// </summary>
        void SearchThread()
		{
			try
			{
				int res		= Search();
				string message	= string.Format("{0:N0}건이 검색되었습니다.", res);

				// 상태표시줄 업데이트
				base.MainForm.UpdateStatus(message);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				// 컨트롤 활성화
				EnableControls1(true);
				// 스톱와치 중지
				base.MainForm.StopStopWatch();
				// 커서 복원
				base.RestoreCursor();
			}
		}

		/// <summary>
		/// 실제 검색을 수행하는 함수이다.
		/// 작업표시줄 상태 메시지를 업데이트 하지 않기 때문에, 삭제 후 혹은 수정 후 등에 사용하면 된다.
		/// </summary>
		/// <returns></returns>
		int Search()
		{
			int _retValue	= -1;

			try
			{
				DataTable _dt			= base.GetDataTable("PCSP_BAS0200_R1"
					, _txtUSRNM_S.Text
					, _cmbUSR_GUBUN_S.SelectedValue
					, _cmbDEPT_CD_S.SelectedValue
					, _txtUSRID_S.Text
					, _rbLCK_ACCT_A.Checked ? "" : (_rbLCK_ACCT_Y.Checked ? "Y" : "N")
					);


				gridView1.DataSource	= _dt;

				_retValue				= _dt.Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion

		#region gridView1_CellClick : 그리드 클릭 시, 상세정보 바인딩
		/// <summary>
		/// 그리드 클릭 시, 상세정보 바인딩
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1)
				{
					// 스플릿바 처리
					if (collapsibleSplitter1.IsCollapsed)
					{
						collapsibleSplitter1.ToggleState();
					}

					EnableControls2(true);

					DataSet _ds		= base.GetDataSet("PCSP_BAS0200_R2"
						, gridView1.Rows[e.RowIndex].Cells["USRID"].Value
						);
					_txtUSRID.Text				= _ds.Tables[0].Rows[0]["USRID"].ToString().Trim();
					_txtUSRNM.Text				= _ds.Tables[0].Rows[0]["USRNM"].ToString();
					_cmbUSR_GUBUN.SelectedValue	= _ds.Tables[0].Rows[0]["USR_GUBUN"].ToString();
					_txtPWD1.Text				= base.GetDecryptTripleDES(_ds.Tables[0].Rows[0]["PWD"].ToString());
					_txtPWD2.Text				= base.GetDecryptTripleDES(_ds.Tables[0].Rows[0]["PWD"].ToString());
					_cmbDEPT_CD.SelectedValue	= _ds.Tables[0].Rows[0]["DEPT_CD"].ToString();
					_txtTELNO.Text				= _ds.Tables[0].Rows[0]["TELNO"].ToString();
					_txtFAXNO.Text				= _ds.Tables[0].Rows[0]["FAXNO"].ToString();
					_txtHPNO.Text				= _ds.Tables[0].Rows[0]["HPNO"].ToString();
					_txtZIP_NO.Text				= _ds.Tables[0].Rows[0]["ZIP_NO"].ToString().Trim();
					_txtADDR_BSC.Text			= _ds.Tables[0].Rows[0]["ADDR_BSC"].ToString();
					_txtADDR_DTL.Text			= _ds.Tables[0].Rows[0]["ADDR_DTL"].ToString();
					_txtEMAIL.Text				= _ds.Tables[0].Rows[0]["EMAIL"].ToString();
					_lblLST_LGN_TIME.Text		= _ds.Tables[0].Rows[0]["LST_LGN_TIME"].ToString();
					_lblWRNG_PWD_CNT.Text		= _ds.Tables[0].Rows[0]["WRNG_PWD_CNT"].ToString();
					_lblLCK_ACCT.Text			= _ds.Tables[0].Rows[0]["LCK_ACCT"].ToString();
					for (int i = 0; i < _clbCompany.Items.Count; i++)
					{
						DataRowView castedItem	= _clbCompany.Items[i] as DataRowView;
						string comapnyCode		= castedItem["COMPANY_CD"].ToString();
						for (int j = 0; j < _ds.Tables[1].Rows.Count; j++)
						{
							if (_ds.Tables[1].Rows[j]["COMPANY_CD"].ToString() == comapnyCode)
							{
								_clbCompany.SetItemChecked(i, true);
								break;
							}
						}
					}
					_txtMEMO.Text				= _ds.Tables[0].Rows[0]["MEMO"].ToString();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region collapsibleSplitter1_DoubleClick : 스플릿바 더블 클릭 이벤트
		/// <summary>
		/// 스플릿바 더블 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void collapsibleSplitter1_DoubleClick(object sender, EventArgs e)
		{
			groupBox2.Width		= 698;
		}
		#endregion

		#region _txtUSRNM_S_KeyDown : 검색 버튼 자동으로 클릭
		/// <summary>
		/// 검색 버튼 자동으로 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtUSRNM_S_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnSearch.PerformClick();

				// 비프소리 중지
				e.SuppressKeyPress	= true;
				e.Handled			= true;
			}
		}
		
		private void _cmbUSR_GUBUN_S_DropDownClosed(object sender, EventArgs e)
		{
			_btnSearch.PerformClick();
		}

		private void _rbLCK_ACCT_A_CheckedChanged(object sender, EventArgs e)
		{
			_btnSearch.PerformClick();
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

		#region _btnAdd_Click : 추가 버튼 클릭 이벤트
		/// <summary>
		/// 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0210 form = new BAS0210();
				form.ShowDialog();
			
				// 새로운 정보 바인딩
				Search();
				ClearControls();
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
				if (_txtPWD1.Text != _txtPWD2.Text)
				{
					MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다.");
					return;
				}

				base.BeginTransaction();

				base.ExecuteNonQuery("PCSP_BAS0200_U1"
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

				base.ExecuteNonQuery("PCSP_BAS0200_D2"
					, _txtUSRID.Text
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

				MessageBox.Show("이용자정보를 수정 하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				base.RollbackTransaction();
			}
		}
		#endregion

		#region _btnDel_Click : 삭제 버튼 클릭 이벤트
		/// <summary>
		/// 삭제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0200_D1"
					, _txtUSRID.Text
					);
				MessageBox.Show("이용자정보를 삭제 하였습니다.");

				Search();
				ClearControls();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
        #endregion

    }
}
