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
	/// 제  목: 가맹점정산/계약정보
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-15 01:18
	/// 설  명: 가맹점의 정산/계약정보를 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0805 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		private Thread _thread;		// 검색 쓰레드

		#region BAS0805 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0805()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0805_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0805_Load(object sender, EventArgs e)
		{
			try
			{
				// 서비스상태
				DataTable _dtCI_SVC_STAT	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A04", "", "", "", "");
				base.SetListItem(_cmbCI_SVC_STAT, _dtCI_SVC_STAT, "TOTAL_CODE", "CODE_NAME");
				base.SetListItem(_cmbCI_SVC_STAT_S, _dtCI_SVC_STAT, "TOTAL_CODE", "CODE_NAME", true);

				// 출금상태
				DataTable _dtCI_WTHR_STAT	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A05", "", "", "", "");
				base.SetListItem(_cmbCI_WTHR_STAT, _dtCI_WTHR_STAT, "TOTAL_CODE", "CODE_NAME");
				base.SetListItem(_cmbCI_WTHR_STAT_S, _dtCI_WTHR_STAT, "TOTAL_CODE", "CODE_NAME", true);

				//// 대출.은행코드
				//DataTable _dtCI_LN_BNK_CD	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A02", "", "", "", "");
				//base.SetListItem(_cmbCI_LN_BNK_CD, _dtCI_LN_BNK_CD, "TOTAL_CODE", "CODE_NAME", true);

				// 상환.은행코드
				DataTable _dtCI_RDM_BNK_CD	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A02", "", "", "", "");
				base.SetListItem(_cmbCI_RDM_BNK_CD, _dtCI_RDM_BNK_CD, "TOTAL_CODE", "CODE_NAME", true);

				// 지급.은행코드
				DataTable _dtCI_PAY_BNK_CD = base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A02", "", "", "", "");
				base.SetListItem(_cmbCI_PAY_BNK_CD, _dtCI_PAY_BNK_CD, "TOTAL_CODE", "CODE_NAME", true);

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

		#region BAS0805_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0805_Shown(object sender, EventArgs e)
		{
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
			_txtSTR_CD.Text					= "";
			_txtSTR_NM.Text					= "";
			_txtPRSNT_NM.Text				= "";
			_dtpCI_CNTR_STRT_DT.Value		= System.DateTime.Now;
			_dtpCI_CNTR_STRT_DT.Checked		= false;
			_dtpCI_CNTR_END_DT.Value		= System.DateTime.Now;
			_dtpCI_CNTR_END_DT.Checked		= false;
			_dtpCI_WTHR_STRT_DT.Value		= System.DateTime.Now;
			_dtpCI_WTHR_STRT_DT.Checked		= false;
			_cmbCI_SVC_STAT.SelectedIndex	= 0;
			_cmbCI_WTHR_STAT.SelectedIndex	= 0;
			_txtCI_BZL_PER.Text				= "";
			_txtCI_ACCOUNT_FEE.Text			= "";
			_rbCI_WTHR_TYPE_Y.Checked		= true;
			_rbCI_WTHR_TYPE_T.Checked		= false;
			_rbCI_WTHR_TYPE_E.Checked		= false;
			_txtCI_UNIT_LMT.Text			= "";
			_txtCI_DAILY_LMT.Text			= "";
			_txtCI_TOT_LMT.Text				= "";
			_chkCI_USE_INSRNC.Checked		= false;
			_chkCI_USE_BLNC.Checked			= false;
			_chkCI_USE_SRT.Checked			= false;
			//_cmbCI_LN_BNK_CD.SelectedIndex	= 0;
			//_txtCI_LN_ACCT_NO.Text			= "";
			//_txtCI_LN_ACCT_NM.Text			= "";
			_cmbCI_RDM_BNK_CD.SelectedIndex	= 0;
			_txtCI_RDM_ACCT_NO.Text			= "";
			_txtCI_RDM_ACCT_NM.Text			= "";
			_cmbCI_PAY_BNK_CD.SelectedIndex = 0;
			_txtCI_PAY_ACCT_NO.Text			= "";
			_txtCI_PAY_ACCT_NM.Text			= "";
			_txtCI_LN_RATE.Text				= "";
			_txtCI_LN_OVD.Text				= "";
			_cmbCI_AGT_CD.SelectedIndex		= 0;
			_dtpCI_APP_DT.Value				= System.DateTime.Now;
			_dtpCI_APP_DT.Checked			= false;
			_cmbCI_LNR_CD.SelectedIndex		= 0;
			_rbCI_LN_GUBUN01.Checked		= true;
			_rbCI_LN_GUBUN02.Checked		= false;
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화
		/// <summary>
		/// 컨트롤 활성화/비활성화
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			//_txtAGT_NM_S.Enabled		= _bTrue;
			//_txtAGT_CD_S.Enabled		= _bTrue;
			//_txtPRSNT_NM_S.Enabled		= _bTrue;
			//_txtADDR_BSC_S.Enabled		= _bTrue;
			//_cmbBI_BINF_CD_S.Enabled	= _bTrue;
			//_txtBI_SAUP_NO_S.Enabled	= _bTrue;
			//_btnSearch.Enabled			= _bTrue;

			gridView1.Enabled			= _bTrue;
		}
		#endregion
		
		#region EnableControls2 : 컨트롤 활성화/비활성화
		/// <summary>
		/// 컨트롤 활성화/비활성화
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			_dtpCI_CNTR_STRT_DT.Enabled		= _bTrue;
			_dtpCI_CNTR_END_DT.Enabled		= _bTrue;
			_dtpCI_WTHR_STRT_DT.Enabled		= _bTrue;
			_cmbCI_SVC_STAT.Enabled			= _bTrue;
			_cmbCI_WTHR_STAT.Enabled		= _bTrue;
			_txtCI_BZL_PER.ReadOnly			= !_bTrue;
			_txtCI_ACCOUNT_FEE.ReadOnly		= !_bTrue;
			_rbCI_WTHR_TYPE_Y.Enabled		= _bTrue;
			_rbCI_WTHR_TYPE_T.Enabled		= _bTrue;
			_rbCI_WTHR_TYPE_E.Enabled		= _bTrue;
			_txtCI_UNIT_LMT.ReadOnly		= !_bTrue;
			_chkCI_USE_INSRNC.Enabled		= _bTrue;
			_chkCI_USE_BLNC.Enabled			= _bTrue;
			_chkCI_USE_SRT.Enabled			= _bTrue;
			_txtCI_DAILY_LMT.ReadOnly		= !_bTrue;
			_txtCI_TOT_LMT.ReadOnly			= !_bTrue;
			//_cmbCI_LN_BNK_CD.Enabled		= _bTrue;
			//_txtCI_LN_ACCT_NO.ReadOnly		= !_bTrue;
			//_txtCI_LN_ACCT_NM.ReadOnly		= !_bTrue;
			_cmbCI_RDM_BNK_CD.Enabled		= _bTrue;
			_txtCI_RDM_ACCT_NO.ReadOnly		= !_bTrue;
			_txtCI_RDM_ACCT_NM.ReadOnly		= !_bTrue;
			_cmbCI_PAY_BNK_CD.Enabled		= _bTrue;
			_txtCI_PAY_ACCT_NO.ReadOnly		= !_bTrue;
			_txtCI_PAY_ACCT_NM.ReadOnly		= !_bTrue;
			_txtCI_LN_RATE.ReadOnly			= !_bTrue;
			_cmbCI_AGT_CD.Enabled			= _bTrue;
			_dtpCI_APP_DT.Enabled			= _bTrue;
			_cmbCI_LNR_CD.Enabled			= _bTrue;
			_rbCI_LN_GUBUN01.Enabled		= _bTrue;
			_rbCI_LN_GUBUN02.Enabled		= _bTrue;
			_btnRate.Enabled				= _bTrue;
			_btnLimit.Enabled				= _bTrue;
			_btnSave01.Enabled				= _bTrue;
			_btnSave02.Enabled				= _bTrue;
			//_btnSave03.Enabled				= _bTrue;
			//_btnSave04.Enabled				= _bTrue;
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
			// 스톱와치 시작
			base.MainForm.StartStopWatch();
			// 커서 기다림
			base.SetWaitCursor();
			// 컨트롤 비활성화
			EnableControls1(false);
			EnableControls2(false);

			// 컨트롤 초기화
			ClearControls();

			// 스플릿바 처리
			if (!collapsibleSplitter1.IsCollapsed)
			{
				collapsibleSplitter1.ToggleState();
			}

			_thread = new Thread(new ThreadStart(SearchThread));
			_thread.Start();
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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0805_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtSTR_CD_S.Text
					, _txtPRSNT_NM_S.Text
					, _cmbCI_SVC_STAT_S.SelectedValue
					, _cmbCI_WTHR_STAT_S.SelectedValue
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

		#region collapsibleSplitter1_DoubleClick : 스플릿바 더블 클릭 이벤트
		/// <summary>
		/// 스플릿바 더블 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void collapsibleSplitter1_DoubleClick(object sender, EventArgs e)
		{
			panel1.Width	= 710;
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
				ShowMainInfo(e.RowIndex);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region ShowMainInfo : 메인 정보 출력
		/// <summary>
		/// 메인 정보 출력
		/// 2016-07-22 한인수 추가
		/// </summary>
		/// <param name="_intRowIndex">그리드 로우</param>
		void ShowMainInfo(int _intRowIndex)
		{
			try
			{
				if (_intRowIndex > -1)
				{
					// 스플릿바 처리
					if (collapsibleSplitter1.IsCollapsed)
					{
						collapsibleSplitter1.ToggleState();
					}

					EnableControls2(true);

					DataSet _ds		= base.GetDataSet("PCSP_BAS0805_R2"
						, gridView1.Rows[_intRowIndex].Cells["STR_CD"].Value
						);

					// 기본정보
					if (_ds.Tables[0].Rows.Count > 0)
					{
						_txtSTR_CD.Text					= _ds.Tables[0].Rows[0]["STR_CD"].ToString().Trim();
						_txtSTR_NM.Text					= _ds.Tables[0].Rows[0]["STR_NM"].ToString();
						_txtPRSNT_NM.Text				= _ds.Tables[0].Rows[0]["PRSNT_NM"].ToString();
						_dtpCI_CNTR_STRT_DT.Value		= _ds.Tables[0].Rows[0]["CI_CNTR_STRT_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[0].Rows[0]["CI_CNTR_STRT_DT"].ToString());
						_dtpCI_CNTR_STRT_DT.Checked		= _ds.Tables[0].Rows[0]["CI_CNTR_STRT_DT"].ToString().Trim() == "" ? false : true;
						_dtpCI_CNTR_END_DT.Value		= _ds.Tables[0].Rows[0]["CI_CNTR_END_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[0].Rows[0]["CI_CNTR_END_DT"].ToString());
						_dtpCI_CNTR_END_DT.Checked		= _ds.Tables[0].Rows[0]["CI_CNTR_END_DT"].ToString().Trim() == "" ? false : true;
						_dtpCI_WTHR_STRT_DT.Value		= _ds.Tables[0].Rows[0]["CI_WTHR_STRT_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[0].Rows[0]["CI_WTHR_STRT_DT"].ToString());
						_dtpCI_WTHR_STRT_DT.Checked		= _ds.Tables[0].Rows[0]["CI_WTHR_STRT_DT"].ToString().Trim() == "" ? false : true;
						_cmbCI_SVC_STAT.SelectedValue	= _ds.Tables[0].Rows[0]["CI_SVC_STAT"].ToString();
						_cmbCI_WTHR_STAT.SelectedValue	= _ds.Tables[0].Rows[0]["CI_WTHR_STAT"].ToString();
						_txtCI_BZL_PER.Text				= _ds.Tables[0].Rows[0]["CI_BZL_PER"].ToString();
						_txtCI_ACCOUNT_FEE.Text			= _ds.Tables[0].Rows[0]["CI_ACCOUNT_FEE"].ToString();
						_rbCI_WTHR_TYPE_Y.Checked		= _ds.Tables[0].Rows[0]["CI_WTHR_TYPE"].ToString() == "Y" ? true : false;
						_rbCI_WTHR_TYPE_T.Checked		= _ds.Tables[0].Rows[0]["CI_WTHR_TYPE"].ToString() == "T" ? true : false;
						_rbCI_WTHR_TYPE_E.Checked		= _ds.Tables[0].Rows[0]["CI_WTHR_TYPE"].ToString() == "E" ? true : false;
						_chkCI_USE_INSRNC.Checked		= _ds.Tables[0].Rows[0]["CI_USE_INSRNC"].ToString() == "Y" ? true : false;
						_chkCI_USE_BLNC.Checked			= _ds.Tables[0].Rows[0]["CI_USE_BLNC"].ToString() == "Y" ? true : false;
						_chkCI_USE_SRT.Checked			= _ds.Tables[0].Rows[0]["CI_USE_SRT"].ToString() == "Y" ? true : false;
						//_cmbCI_LN_BNK_CD.SelectedValue	= _ds.Tables[0].Rows[0]["CI_LN_BNK_CD"].ToString();
						//_txtCI_LN_ACCT_NO.Text			= _ds.Tables[0].Rows[0]["CI_LN_ACCT_NO"].ToString();
						//_txtCI_LN_ACCT_NM.Text			= _ds.Tables[0].Rows[0]["CI_LN_ACCT_NM"].ToString();
						_cmbCI_RDM_BNK_CD.SelectedValue	= _ds.Tables[0].Rows[0]["CI_RDM_BNK_CD"].ToString();
						_txtCI_RDM_ACCT_NO.Text			= _ds.Tables[0].Rows[0]["CI_RDM_ACCT_NO"].ToString();
						_txtCI_RDM_ACCT_NM.Text			= _ds.Tables[0].Rows[0]["CI_RDM_ACCT_NM"].ToString();
						_cmbCI_PAY_BNK_CD.SelectedValue = _ds.Tables[0].Rows[0]["CI_PAY_BNK_CD"].ToString();
						_txtCI_PAY_ACCT_NO.Text			= _ds.Tables[0].Rows[0]["CI_PAY_ACCT_NO"].ToString();
						_txtCI_PAY_ACCT_NM.Text			= _ds.Tables[0].Rows[0]["CI_PAY_ACCT_NM"].ToString();
					}
					else
					{
						_txtSTR_CD.Text					= gridView1.Rows[_intRowIndex].Cells["STR_CD"].Value.ToString();
						_txtSTR_NM.Text					= gridView1.Rows[_intRowIndex].Cells["STR_NM"].Value.ToString();
						_txtPRSNT_NM.Text				= gridView1.Rows[_intRowIndex].Cells["PRSNT_NM"].Value.ToString();
						_dtpCI_CNTR_STRT_DT.Value		= System.DateTime.Now;
						_dtpCI_CNTR_STRT_DT.Checked		= false;
						_dtpCI_CNTR_END_DT.Value		= System.DateTime.Now;
						_dtpCI_CNTR_END_DT.Checked		= false;
						_dtpCI_WTHR_STRT_DT.Value		= System.DateTime.Now;
						_dtpCI_WTHR_STRT_DT.Checked		= false;
						_cmbCI_SVC_STAT.SelectedIndex	= 0;
						_cmbCI_WTHR_STAT.SelectedIndex	= 0;
						_txtCI_BZL_PER.Text				= "";
						_txtCI_ACCOUNT_FEE.Text			= "";
						_rbCI_WTHR_TYPE_Y.Checked		= true;
						_rbCI_WTHR_TYPE_T.Checked		= false;
						_rbCI_WTHR_TYPE_E.Checked		= false;
						_chkCI_USE_INSRNC.Checked		= false;
						_chkCI_USE_BLNC.Checked			= false;
						_chkCI_USE_SRT.Checked			= false;
						//_cmbCI_LN_BNK_CD.SelectedIndex	= 0;
						//_txtCI_LN_ACCT_NO.Text			= "";
						//_txtCI_LN_ACCT_NM.Text			= "";
						_cmbCI_RDM_BNK_CD.SelectedIndex	= 0;
						_txtCI_RDM_ACCT_NO.Text			= "";
						_txtCI_RDM_ACCT_NM.Text			= "";
						_cmbCI_PAY_BNK_CD.SelectedIndex = 0;
						_txtCI_PAY_ACCT_NO.Text			= "";
						_txtCI_PAY_ACCT_NM.Text			= "";
					}

					// 대출이자정보
					ShowLoanInfo(_ds);
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region ShowLoanInfo : 한도정보 및 대출이자정보 출력
		/// <summary>
		/// 한도정보 및 대출이자정보 출력
		/// </summary>
		/// <param name="_ds"></param>
		void ShowLoanInfo(DataSet _ds)
		{
			try
			{
				// 대출한도정보
				if (_ds.Tables[1].Rows.Count == 0)
				{
					// 현재 등록된 대출한도정보가 없으면, 컨트롤을 활성화 시킨다.
					_txtCI_UNIT_LMT.Text		= "";
					_txtCI_UNIT_LMT.ReadOnly	= false;

					_txtCI_DAILY_LMT.Text		= "";
					_txtCI_DAILY_LMT.ReadOnly	= false;

					_txtCI_TOT_LMT.Text			= "";
					_txtCI_TOT_LMT.ReadOnly		= false;

					_dtpCI_LMT_APP_DT.Value		= System.DateTime.Now;
					_dtpCI_LMT_APP_DT.Enabled	= true;
					_dtpCI_LMT_APP_DT.Checked	= false;

					_btnLimit.Enabled			= false;
					_btnSave04.Enabled			= true;
				}
				else
				{
					/*
					 * 현재 등록된 대출한도정보가 있으면, 바인딩하고 컨트롤은 비활성화 시킨다.
					 * 대출한도정보의 변경은 "한도 조정" 버튼을 활용한다.
					 */
					_txtCI_UNIT_LMT.Text		= _ds.Tables[1].Rows[0]["CI_UNIT_LMT"].ToString();
					_txtCI_UNIT_LMT.ReadOnly	= true;

					_txtCI_DAILY_LMT.Text		= _ds.Tables[1].Rows[0]["CI_DAILY_LMT"].ToString();
					_txtCI_DAILY_LMT.ReadOnly	= true;

					_txtCI_TOT_LMT.Text			= _ds.Tables[1].Rows[0]["CI_TOT_LMT"].ToString();
					_txtCI_TOT_LMT.ReadOnly		= true;

					_dtpCI_LMT_APP_DT.Value		= _ds.Tables[1].Rows[0]["CI_LMT_APP_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[1].Rows[0]["CI_LMT_APP_DT"].ToString());
					_dtpCI_LMT_APP_DT.Enabled	= false;
					_dtpCI_LMT_APP_DT.Checked	= _ds.Tables[1].Rows[0]["CI_LMT_APP_DT"].ToString().Trim() == "" ? false : true;

					_btnLimit.Enabled			= true;
					_btnSave04.Enabled			= false;
				}

				// 대출이자정보
				if (_ds.Tables[2].Rows.Count == 0)
				{
					// 현재 등록된 대출이자정보가 없으면, 컨트롤을 활성화 시킨다.
					_txtCI_LN_RATE.Text			= "";
					_txtCI_LN_RATE.ReadOnly		= false;

					_txtCI_LN_OVD.Text			= "";
					_txtCI_LN_OVD.ReadOnly		= false;

					_cmbCI_AGT_CD.SelectedIndex	= 0;
					_cmbCI_AGT_CD.Enabled		= true;
						
					_dtpCI_APP_DT.Value			= System.DateTime.Now;
					_dtpCI_APP_DT.Enabled		= true;
					_dtpCI_APP_DT.Checked		= false;

					_cmbCI_LNR_CD.SelectedIndex	= 0;
					_cmbCI_LNR_CD.Enabled		= true;

					_rbCI_LN_GUBUN01.Checked	= true;
					_rbCI_LN_GUBUN01.Enabled	= true;
					_rbCI_LN_GUBUN02.Enabled	= true;

					_btnRate.Enabled			= false;
					_btnSave03.Enabled			= true;
				}
				else
				{
					/*
					 * 현재 등록된 대출이자정보가 있으면, 바인딩하고 컨트롤은 비활성화 시킨다.
					 * 이자율 및 각종 정보의 변경은 "이자율 조정" 버튼을 활용한다.
					 */
					_txtCI_LN_RATE.Text			= _ds.Tables[2].Rows[0]["CI_LN_RATE"].ToString();
					_txtCI_LN_RATE.ReadOnly		= true;

					_txtCI_LN_OVD.Text			= _ds.Tables[2].Rows[0]["CI_LN_OVD"].ToString();
					_txtCI_LN_OVD.ReadOnly		= true;

					_cmbCI_AGT_CD.SelectedValue	= _ds.Tables[2].Rows[0]["CI_AGT_CD"].ToString();
					_cmbCI_AGT_CD.Enabled		= false;

					_dtpCI_APP_DT.Value			= _ds.Tables[2].Rows[0]["CI_APP_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[2].Rows[0]["CI_APP_DT"].ToString());
					_dtpCI_APP_DT.Enabled		= false;
					_dtpCI_APP_DT.Checked		= _ds.Tables[2].Rows[0]["CI_APP_DT"].ToString().Trim() == "" ? false : true;

					_cmbCI_LNR_CD.SelectedValue	= _ds.Tables[2].Rows[0]["CI_LNR_CD"].ToString();
					_cmbCI_LNR_CD.Enabled		= false;
						
					_rbCI_LN_GUBUN01.Checked	= _ds.Tables[2].Rows[0]["CI_LN_GUBUN"].ToString() == "A07001" ? true : false;
					_rbCI_LN_GUBUN01.Enabled	= false;
					_rbCI_LN_GUBUN02.Checked	= _ds.Tables[2].Rows[0]["CI_LN_GUBUN"].ToString() == "A07002" ? true : false;
					_rbCI_LN_GUBUN02.Enabled	= false;
						
					_btnRate.Enabled			= true;
					_btnSave03.Enabled			= false;
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region gridView1_CellDoubleClick : 그리드 더블 클릭 시, 상세 정보 보여줌
		/// <summary>
		/// 그리드 더블 클릭 시, 상세 정보 보여줌
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (collapsibleSplitter1.IsCollapsed)
			{
				collapsibleSplitter1.ToggleState();
			}
		}
		#endregion
		
		#region _btnSave01_Click : 저장 버튼 클릭 이벤트
		/// <summary>
		/// 저장 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave01_Click(object sender, EventArgs e)
		{
			try
			{
				// 계약정보가 개시일 경우 출금시작일을 반드시 입력해야 한다.
				if (_cmbCI_SVC_STAT.SelectedValue.ToString() == "A04002")
				{
					if (!_dtpCI_WTHR_STRT_DT.Checked)
					{
						MessageBox.Show("계약정보가 개시일 경우 출금시작일은 필수 입력 사항입니다.");
						_dtpCI_WTHR_STRT_DT.Focus();
						return;
					}
				}

				if (_txtCI_ACCOUNT_FEE.Text == "")
				{
					MessageBox.Show("정산수수료율은 필수 입력 사항입니다.");
					_txtCI_ACCOUNT_FEE.Focus();
					return;
				}

				if (_cmbCI_WTHR_STAT.SelectedValue.ToString() == "")
				{
					MessageBox.Show("출금상태는 필수 입력 사항입니다.");
					_cmbCI_WTHR_STAT.Focus();
					return;
				}

				// 대출한도정보
				bool _blIsStartedToEdit1	= false;
				if ((_txtCI_UNIT_LMT.Text != "")
					|| (_txtCI_DAILY_LMT.Text != "")
					|| (_txtCI_TOT_LMT.Text != "")
					|| (base.GetDate(_dtpCI_LMT_APP_DT) != ""))
				{
					_blIsStartedToEdit1	= true;
				}
				if (_blIsStartedToEdit1)
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
				}

				// 대출이자율정보
				bool _blIsStartedToEdit2	= false;
				if ((_txtCI_LN_RATE.Text != "")
					|| (_txtCI_LN_OVD.Text != "")
					|| (_dtpCI_APP_DT.Checked)
					|| (base.GetString(_cmbCI_LNR_CD) != null))
				{
					_blIsStartedToEdit2	= true;
				}

				if (_blIsStartedToEdit2)
				{
					if (_txtCI_LN_RATE.Text == "")
					{
						MessageBox.Show("대출이자율은 필수 입력 사항입니다.");
						_txtCI_LN_RATE.Focus();
						return;
					}
					else if (_txtCI_LN_OVD.Text == "")
					{
						MessageBox.Show("연체이자율은 필수 입력 사항입니다.");
						_txtCI_LN_OVD.Focus();
						return;
					}
					else if (!_dtpCI_APP_DT.Checked)
					{
						MessageBox.Show("적용시작일은 필수 입력 사항입니다.");
						_dtpCI_APP_DT.Focus();
						return;
					}
					else if (base.GetString(_cmbCI_LNR_CD) == null)
					{
						MessageBox.Show("여신사는 필수 선택 사항입니다.");
						_cmbCI_LNR_CD.Focus();
						return;
					}
				}

				// 출금유형구분(T:당일 6시, Y:전일 총액, E:그 외)
				string _strCI_WTHR_TYPE = string.Empty;
				if (_rbCI_WTHR_TYPE_T.Checked)
				{
					_strCI_WTHR_TYPE = "T";
				}

				if (_rbCI_WTHR_TYPE_Y.Checked)
				{
					_strCI_WTHR_TYPE = "Y";
				}

				if (_rbCI_WTHR_TYPE_E.Checked)
				{
					_strCI_WTHR_TYPE = "E";
				}

				base.ExecuteNonQuery("PCSP_BAS0805_U1"
					, _txtSTR_CD.Text									// 가맹점코드
					, base.GetDate(_dtpCI_CNTR_STRT_DT)					// 계약일자
					, base.GetDate(_dtpCI_CNTR_END_DT)					// 해지일자
					, base.GetDate(_dtpCI_WTHR_STRT_DT)					// 출금시작일자
					, base.GetString(_cmbCI_SVC_STAT)					// 서비스상태
					, base.GetString(_cmbCI_WTHR_STAT)					// 출금상태
					, _txtCI_BZL_PER.Text == "" ? 0 : base.GetDecimal(_txtCI_BZL_PER)					// 비즈론 연체이자율
					, base.GetDecimal(_txtCI_ACCOUNT_FEE)				// 정산수수료
					, _strCI_WTHR_TYPE									// 출금유형구분(T:당일 6시, Y:전일 총액, E:그 외)
					, _chkCI_USE_INSRNC.Checked ? "Y" : "N"				// 보증보험 사용여부
					, _chkCI_USE_BLNC.Checked ? "Y" : "N"				// 보증예치금 사용여부
					, _chkCI_USE_SRT.Checked ? "Y" : "N"				// 연대보증인 사용여부
					, base.GetString(_cmbCI_PAY_BNK_CD)					// 대출.은행코드
					, _txtCI_PAY_ACCT_NO.Text							// 대출.계좌번호
					, _txtCI_PAY_ACCT_NM.Text							// 대출.예금주
					, base.GetString(_cmbCI_RDM_BNK_CD)					// 상환.은행코드
					, _txtCI_RDM_ACCT_NO.Text							// 상환.계좌번호
					, _txtCI_RDM_ACCT_NM.Text							// 상환.예금주
					, base.GetString(_cmbCI_PAY_BNK_CD)					// 지급.은행코드
					, _txtCI_PAY_ACCT_NO.Text							// 지급.계좌번호
					, _txtCI_PAY_ACCT_NM.Text							// 지급.예금주

					, base.GetDate(_dtpCI_LMT_APP_DT)					// 적용시작일
					, base.GetInteger(_txtCI_UNIT_LMT)					// 건별대출한도
					, base.GetInteger(_txtCI_DAILY_LMT)					// 1일대출한도
					, base.GetInteger(_txtCI_TOT_LMT)					// 총대출한도

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

				MessageBox.Show("정산/계약정보를 수정 하였습니다.");

				// 그리드 셀 클릭 이벤트를 발생 시켜서, 한도조정 버튼의 enable 처리를 한다.
				ShowMainInfo(gridView1.CurrentRow.Index);
				//gridView1.RaiseCellClick(gridView1.CurrentRow.Index, 0);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnRate_Click : 이자율 조정 버튼 클릭 이벤트
		/// <summary>
		/// 이자율 조정 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnRate_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0806 _form	= new BAS0806();
				_form.STR_CD	= _txtSTR_CD.Text;
				_form.STR_NM	= _txtSTR_NM.Text;
				_form.ShowDialog();
			
				DataSet _ds		= base.GetDataSet("PCSP_BAS0805_R2"
					, gridView1.Rows[gridView1.CurrentRow.Index].Cells["STR_CD"].Value
					);
				ShowLoanInfo(_ds);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnLimit_Click : 한도 조정 버튼 클릭 이벤트
		/// <summary>
		/// 한도 조정 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnLimit_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0808 _form	= new BAS0808();
				_form.STR_CD	= _txtSTR_CD.Text;
				_form.STR_NM	= _txtSTR_NM.Text;
				_form.ShowDialog();
			
				DataSet _ds		= base.GetDataSet("PCSP_BAS0805_R2"
					, gridView1.Rows[gridView1.CurrentRow.Index].Cells["STR_CD"].Value
					);
				ShowLoanInfo(_ds);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
