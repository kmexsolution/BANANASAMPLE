using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	/// <summary>
	/// 제  목: 대리점정보관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-13 06:58
	/// 설  명: 대리점정보를 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0700 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region BAS0700 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0700()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0700_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0700_Load(object sender, EventArgs e)
		{
			try
			{
				//// 컬럼 밴드 처리-사업자등록증정보
				//var band01	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND01", HeaderText = "사업자등록증정보", BackColor = Color.Azure, UseBackColor = true };
				//band01.Columns.Add(BI_COMPANY_NM);
				//band01.Columns.Add(BI_PRSNT_NM);
				//band01.Columns.Add(BI_BINF_NM);
				//band01.Columns.Add(BI_SIMTAX_YN);
				//band01.Columns.Add(BI_SAUP_NO);
				//this.gridView1.AddBand(band01);
				
				//// 컬럼 밴드 처리-대표자정보
				//var band02	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND02", HeaderText = "대표자정보", BackColor = Color.LightBlue, UseBackColor = true };
				//band02.Columns.Add(PI_PRSNT_NM);
				//band02.Columns.Add(PI_TELNO);
				//band02.Columns.Add(PI_CELLNO);
				//this.gridView1.AddBand(band02);
				
				//// 컬럼 밴드 처리-정산/계약정보
				//var band03	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND03", HeaderText = "정산/계약정보", BackColor = Color.LightGreen, UseBackColor = true };
				//band03.Columns.Add(CI_CNTR_STRT_DT);
				//band03.Columns.Add(CI_CNTR_END_DT);
				//this.gridView1.AddBand(band03);
				
				//// 컬럼 밴드 처리-마이오피스정보
				//var band04	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND04", HeaderText = "마이오피스정보", BackColor = Color.LightCoral, UseBackColor = true };
				//band04.Columns.Add(MO_LOGIN_ID);
				//band04.Columns.Add(MO_STRT_DT);
				//band04.Columns.Add(MO_PAUSED);
				//this.gridView1.AddBand(band04);

				// 사업자구분(수정)
				DataTable _dt01	= base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "A01"
					, ""
					, ""
					, ""
					, ""
					);
				base.SetListItem(_cmbBI_BINF_CD
					, _dt01
					, "TOTAL_CODE"
					, "CODE_NAME"
					);

				// 사업자구분(검색)
				DataTable _dt02	= _dt01.Copy();
				base.SetListItem(_cmbBI_BINF_CD_S
					, _dt02
					, "TOTAL_CODE"
					, "CODE_NAME"
					, true
					);

				// 은행코드
				DataTable _dt03	= base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "A02"
					, ""
					, ""
					, ""
					, ""
					);
				base.SetListItem(_cmbCI_BNK_CD
					, _dt03
					, "TOTAL_CODE"
					, "CODE_NAME"
					, true
					);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0700_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0700_Shown(object sender, EventArgs e)
		{
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
			_txtAGT_CD.Text					= "";
			_txtAGT_NM.Text					= "";
			_txtPRSNT_NM.Text				= "";
			_txtZIP_NO.Text					= "";
			_txtADDR_BSC.Text				= "";
			_txtADDR_DTL.Text				= "";
			_txtTELNO.Text					= "";
			_txtFAXNO.Text					= "";
			_txtMEMO.Text					= "";
			_txtBI_COMPANY_NM.Text			= "";
			_txtBI_PRSNT_NM.Text			= "";
			_cmbBI_BINF_CD.SelectedIndex	= 0;
			_txtBI_SAUP_NO.Text				= "";
			_txtBI_BUBIN_NO.Text			= "";
			_rbBI_SIMTAX_Y.Checked			= false;
			_rbBI_SIMTAX_Y.Enabled			= false;
			_rbBI_SIMTAX_N.Checked			= true;
			_rbBI_SIMTAX_N.Enabled			= false;
			_txtBI_ZIP_NO.Text				= "";
			_txtBI_ADDR_BSC.Text			= "";
			_txtBI_ADDR_DTL.Text			= "";
			_txtBI_UPTE.Text				= "";
			_txtBI_JONGMOK.Text				= "";
			_txtBI_EMAIL.Text				= "";
			_txtPI_PRSNT_NM.Text			= "";
			_txtPI_CNTZ_NO.Text				= "";
			_txtPI_TELNO.Text				= "";
			_txtPI_CELLNO.Text				= "";
			_txtPI_EMAIL.Text				= "";
			_txtPI_ZIP_NO.Text				= "";
			_txtPI_ADDR_BSC.Text			= "";
			_txtPI_ADDR_DTL.Text			= "";
			_dtpCI_CNTR_STRT_DT.Value		= System.DateTime.Now;
			_dtpCI_CNTR_STRT_DT.Checked		= false;
			_dtpCI_CNTR_END_DT.Value		= System.DateTime.Now;
			_dtpCI_CNTR_END_DT.Checked		= false;
			_cmbCI_BNK_CD.SelectedIndex		= 0;
			_txtCI_ACCT_NO.Text				= "";
			_txtCI_ACCT_NM.Text				= "";
			_txtMO_LOGIN_ID.Text			= "";
			_txtMO_LOGIN_PW.Text			= "";
			_dtpMO_STRT_DT.Value			= System.DateTime.Now;
			_dtpMO_STRT_DT.Checked			= false;
			_chkMO_PAUSED.Checked			= false;
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtAGT_NM_S.ReadOnly		= !_bTrue;
			_txtAGT_CD_S.ReadOnly		= !_bTrue;
			_txtPRSNT_NM_S.ReadOnly		= !_bTrue;
			_txtADDR_BSC_S.ReadOnly		= !_bTrue;
			_cmbBI_BINF_CD_S.Enabled	= _bTrue;
			_txtBI_SAUP_NO_S.ReadOnly	= !_bTrue;
			_btnSearch.Enabled			= _bTrue;

			gridView1.Enabled			= _bTrue;
			gridView2.Enabled			= _bTrue;
			gridView3.Enabled			= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			//_txtAGT_CD.Enabled			= _bTrue;
			_txtAGT_NM.ReadOnly			= !_bTrue;
			_txtPRSNT_NM.ReadOnly		= !_bTrue;
			_txtZIP_NO.ReadOnly			= !_bTrue;
			_btnFindZipCode01.Enabled	= _bTrue;
			_txtADDR_BSC.ReadOnly		= !_bTrue;
			_txtADDR_DTL.ReadOnly		= !_bTrue;
			_txtTELNO.ReadOnly			= !_bTrue;
			_txtFAXNO.ReadOnly			= !_bTrue;
			_txtMEMO.ReadOnly			= !_bTrue;
			_btnAdd01.Enabled			= _bTrue;
			_btnSave01.Enabled			= _bTrue;
			_btnDel01.Enabled			= _bTrue;
			_txtBI_COMPANY_NM.ReadOnly	= !_bTrue;
			_txtBI_PRSNT_NM.ReadOnly	= !_bTrue;
			_cmbBI_BINF_CD.Enabled		= _bTrue;
			_txtBI_SAUP_NO.ReadOnly		= !_bTrue;
			_txtBI_BUBIN_NO.ReadOnly	= !_bTrue;
			_rbBI_SIMTAX_Y.Enabled		= _bTrue;
			_rbBI_SIMTAX_N.Enabled		= _bTrue;
			_txtBI_ZIP_NO.ReadOnly		= !_bTrue;
			_btnFindZipCode02.Enabled	= _bTrue;
			_txtBI_ADDR_BSC.ReadOnly	= !_bTrue;
			_txtBI_ADDR_DTL.ReadOnly	= !_bTrue;
			_txtBI_UPTE.ReadOnly		= !_bTrue;
			_txtBI_JONGMOK.ReadOnly		= !_bTrue;
			_txtBI_EMAIL.ReadOnly		= !_bTrue;
			_btnSave02.Enabled			= _bTrue;
			_txtPI_PRSNT_NM.ReadOnly	= !_bTrue;
			_txtPI_CNTZ_NO.ReadOnly		= !_bTrue;
			_txtPI_TELNO.ReadOnly		= !_bTrue;
			_txtPI_CELLNO.ReadOnly		= !_bTrue;
			_txtPI_EMAIL.ReadOnly		= !_bTrue;
			_txtPI_ZIP_NO.ReadOnly		= !_bTrue;
			_btnFindZipCode03.Enabled	= _bTrue;
			_txtPI_ADDR_BSC.ReadOnly	= !_bTrue;
			_txtPI_ADDR_DTL.ReadOnly	= !_bTrue;
			_btnSave03.Enabled			= _bTrue;
			_dtpCI_CNTR_STRT_DT.Enabled	= _bTrue;
			_dtpCI_CNTR_END_DT.Enabled	= _bTrue;
			_cmbCI_BNK_CD.Enabled		= _bTrue;
			_txtCI_ACCT_NO.ReadOnly		= !_bTrue;
			_txtCI_ACCT_NM.ReadOnly		= !_bTrue;
			_btnSave04.Enabled			= _bTrue;
			_txtMO_LOGIN_ID.ReadOnly	= !_bTrue;
			_txtMO_LOGIN_PW.ReadOnly	= !_bTrue;
			_dtpMO_STRT_DT.Enabled		= _bTrue;
			_chkMO_PAUSED.Enabled		= _bTrue;
			_btnSave05.Enabled			= _bTrue;
			_btnAdd02.Enabled			= _bTrue;
			_btnDel02.Enabled			= _bTrue;
			_btnAdd03.Enabled			= _bTrue;
			_btnDel03.Enabled			= _bTrue;
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
			tabControl1.Width = 703;
		}
		#endregion

		#region _btnAdd01_Click : 추가 버튼 이벤트
		/// <summary>
		/// 추가 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd01_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0710 form = new BAS0710();
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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0700_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtAGT_NM_S.Text
					, _txtAGT_CD_S.Text
					, _txtPRSNT_NM_S.Text
					, _txtADDR_BSC_S.Text
					, _cmbBI_BINF_CD_S.SelectedValue
					, _txtBI_SAUP_NO_S.Text
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

				base.ExecuteNonQuery("PCSP_BAS0700_U1"
					, _txtAGT_CD.Text																		// 대리점코드
					, _txtAGT_NM.Text																		// 대리점명
					, _txtPRSNT_NM.Text																		// 대표자명
					, _txtZIP_NO.Text																		// 우편번호
					, _txtADDR_BSC.Text																		// 기본주소
					, _txtADDR_DTL.Text																		// 상세주소
					, _txtTELNO.Text																		// 전화번호
					, _txtFAXNO.Text																		// 팩스번호
					, _txtBI_COMPANY_NM.Text																// 법인명(단체명)
					, _txtBI_PRSNT_NM.Text																	// 대표자명
					, _cmbBI_BINF_CD.SelectedValue															// 사업자구분
					, _rbBI_SIMTAX_Y.Checked ? "Y" : "N"													// 간이과세여부
					, bizno																					// 사업자등록번호
					, bubinno																				// 법인등록번호
					, _txtBI_ZIP_NO.Text																	// 우편번호
					, _txtBI_ADDR_BSC.Text																	// 기본주소
					, _txtBI_ADDR_DTL.Text																	// 상세주소
					, _txtBI_UPTE.Text																		// 업태
					, _txtBI_JONGMOK.Text																	// 종목
					, _txtBI_EMAIL.Text																		// 세금계산서 이메일
					, _txtPI_PRSNT_NM.Text																	// 대표자명
					, base.GetEncryptTripleDES(juminno)														// 주민등록번호
					, _txtPI_TELNO.Text																		// 자택번호
					, _txtPI_CELLNO.Text																	// 휴대폰번호
					, _txtPI_ZIP_NO.Text																	// 자택 우편번호
					, _txtPI_ADDR_BSC.Text																	// 자택 기본주소
					, _txtPI_ADDR_DTL.Text																	// 자택 상세주소
					, _txtPI_EMAIL.Text																		// 대표자 이메일
					, _dtpCI_CNTR_STRT_DT.Checked ? _dtpCI_CNTR_STRT_DT.Value.ToString("yyyy-MM-dd") : ""	// 계약일자
					, _dtpCI_CNTR_END_DT.Checked ? _dtpCI_CNTR_STRT_DT.Value.ToString("yyyy-MM-dd") : ""	// 해지일자
					, _cmbCI_BNK_CD.SelectedValue															// 입금은행코드
					, _txtCI_ACCT_NO.Text																	// 계좌번호
					, _txtCI_ACCT_NM.Text																	// 예금주
					, _txtMO_LOGIN_ID.Text																	// 로그인ID
					, base.GetEncryptTripleDES(_txtMO_LOGIN_PW.Text)										// 비밀번호
					, _dtpMO_STRT_DT.Checked ? _dtpMO_STRT_DT.Value.ToString("yyyy-MM-dd") : ""				// 로그인 가능 일자
					, _chkMO_PAUSED.Checked ? "Y" : "N"														// 일시중지여부
					, _txtMEMO.Text																			// 메모
					, ""																					// 비고
					, base.GetCookie("USRID")																// 시스템수정자ID
					, base.GetCookie("USRNM")																// 시스템수정자명
					);

				MessageBox.Show("대리점정보를 수정 하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
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
				if (e.RowIndex > -1)
				{
					// 스플릿바 처리
					if (collapsibleSplitter1.IsCollapsed)
					{
						collapsibleSplitter1.ToggleState();
					}

					EnableControls2(true);
					ClearControls();

					DataSet _ds		= base.GetDataSet("PCSP_BAS0700_R2"
						, gridView1.Rows[e.RowIndex].Cells["AGT_CD"].Value
						);
					_txtAGT_CD.Text					= _ds.Tables[0].Rows[0]["AGT_CD"].ToString();
					_txtAGT_NM.Text					= _ds.Tables[0].Rows[0]["AGT_NM"].ToString();
					_txtPRSNT_NM.Text				= _ds.Tables[0].Rows[0]["PRSNT_NM"].ToString();
					_txtZIP_NO.Text					= _ds.Tables[0].Rows[0]["ZIP_NO"].ToString().Trim();
					_txtADDR_BSC.Text				= _ds.Tables[0].Rows[0]["ADDR_BSC"].ToString();
					_txtADDR_DTL.Text				= _ds.Tables[0].Rows[0]["ADDR_DTL"].ToString();
					_txtTELNO.Text					= _ds.Tables[0].Rows[0]["TELNO"].ToString();
					_txtFAXNO.Text					= _ds.Tables[0].Rows[0]["FAXNO"].ToString();
					_txtMEMO.Text					= _ds.Tables[0].Rows[0]["MEMO"].ToString();
					_txtBI_COMPANY_NM.Text			= _ds.Tables[0].Rows[0]["BI_COMPANY_NM"].ToString();
					_txtBI_PRSNT_NM.Text			= _ds.Tables[0].Rows[0]["BI_PRSNT_NM"].ToString();
					_cmbBI_BINF_CD.SelectedValue	= _ds.Tables[0].Rows[0]["BI_BINF_CD"].ToString();
					_txtBI_SAUP_NO.Text				= _ds.Tables[0].Rows[0]["BI_SAUP_NO"].ToString().Trim();
					_txtBI_BUBIN_NO.Text			= _ds.Tables[0].Rows[0]["BI_BUBIN_NO"].ToString().Trim();
					_rbBI_SIMTAX_Y.Checked			= _ds.Tables[0].Rows[0]["BI_SIMTAX_YN"].ToString() == "Y" ? true : false;
					_rbBI_SIMTAX_Y.Enabled			= _ds.Tables[0].Rows[0]["BI_BINF_CD"].ToString() == "A01001" ? false : true;
					_rbBI_SIMTAX_N.Checked			= _ds.Tables[0].Rows[0]["BI_SIMTAX_YN"].ToString() == "N" ? true : false;
					_rbBI_SIMTAX_N.Enabled			= _ds.Tables[0].Rows[0]["BI_BINF_CD"].ToString() == "A01001" ? false : true;
					_txtBI_ZIP_NO.Text				= _ds.Tables[0].Rows[0]["BI_ZIP_NO"].ToString().Trim();
					_txtBI_ADDR_BSC.Text			= _ds.Tables[0].Rows[0]["BI_ADDR_BSC"].ToString();
					_txtBI_ADDR_DTL.Text			= _ds.Tables[0].Rows[0]["BI_ADDR_DTL"].ToString();
					_txtBI_UPTE.Text				= _ds.Tables[0].Rows[0]["BI_UPTE"].ToString();
					_txtBI_JONGMOK.Text				= _ds.Tables[0].Rows[0]["BI_JONGMOK"].ToString();
					_txtBI_EMAIL.Text				= _ds.Tables[0].Rows[0]["BI_EMAIL"].ToString();
					_txtPI_PRSNT_NM.Text			= _ds.Tables[0].Rows[0]["PI_PRSNT_NM"].ToString();
					_txtPI_CNTZ_NO.Text				= base.GetDecryptTripleDES(_ds.Tables[0].Rows[0]["PI_CNTZ_NO"].ToString().Trim());
					_txtPI_TELNO.Text				= _ds.Tables[0].Rows[0]["PI_TELNO"].ToString();
					_txtPI_CELLNO.Text				= _ds.Tables[0].Rows[0]["PI_CELLNO"].ToString();
					_txtPI_EMAIL.Text				= _ds.Tables[0].Rows[0]["PI_EMAIL"].ToString();
					_txtPI_ZIP_NO.Text				= _ds.Tables[0].Rows[0]["PI_ZIP_NO"].ToString().Trim();
					_txtPI_ADDR_BSC.Text			= _ds.Tables[0].Rows[0]["PI_ADDR_BSC"].ToString();
					_txtPI_ADDR_DTL.Text			= _ds.Tables[0].Rows[0]["PI_ADDR_DTL"].ToString();
					_dtpCI_CNTR_STRT_DT.Value		= _ds.Tables[0].Rows[0]["CI_CNTR_STRT_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[0].Rows[0]["CI_CNTR_STRT_DT"].ToString().Trim());
					_dtpCI_CNTR_STRT_DT.Checked		= _ds.Tables[0].Rows[0]["CI_CNTR_STRT_DT"].ToString().Trim() == "" ? false : true;
					_dtpCI_CNTR_END_DT.Value		= _ds.Tables[0].Rows[0]["CI_CNTR_END_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[0].Rows[0]["CI_CNTR_END_DT"].ToString().Trim());
					_dtpCI_CNTR_END_DT.Checked		= _ds.Tables[0].Rows[0]["CI_CNTR_END_DT"].ToString().Trim() == "" ? false : true;
					_cmbCI_BNK_CD.SelectedValue		= _ds.Tables[0].Rows[0]["CI_BNK_CD"].ToString();
					_txtCI_ACCT_NO.Text				= _ds.Tables[0].Rows[0]["CI_ACCT_NO"].ToString();
					_txtCI_ACCT_NM.Text				= _ds.Tables[0].Rows[0]["CI_ACCT_NM"].ToString();
					_txtMO_LOGIN_ID.Text			= _ds.Tables[0].Rows[0]["MO_LOGIN_ID"].ToString().Trim();
					_txtMO_LOGIN_PW.Text			= base.GetDecryptTripleDES(_ds.Tables[0].Rows[0]["MO_LOGIN_PW"].ToString());
					_dtpMO_STRT_DT.Value			= _ds.Tables[0].Rows[0]["MO_STRT_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_ds.Tables[0].Rows[0]["MO_STRT_DT"].ToString().Trim());
					_dtpMO_STRT_DT.Checked			= _ds.Tables[0].Rows[0]["MO_STRT_DT"].ToString().Trim() == "" ? false : true;
					_chkMO_PAUSED.Checked			= _ds.Tables[0].Rows[0]["MO_PAUSED"].ToString().Trim() == "Y" ? true : false;

					_txtAGT_NM.Focus();

                    // 구비서류 바인딩
                    LoadFileInfo(_txtAGT_CD.Text);

                    // 통화내역 바인딩
                    LoadCallInfo(_txtAGT_CD.Text);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
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

        // 구비서류
        #region LoadFileInfo : 구비서류 데이터그리드 바인딩
        /// <summary>
        /// 구비서류 데이터그리드 바인딩
        /// </summary>
        /// <param name="AGT_CD"></param>
        void LoadFileInfo(string AGT_CD)
        {
            try
            {
                DataTable _dt           = base.GetDataTable("PCSP_BAS0700_R3"
                    , AGT_CD
                    );
                gridView2.DataSource    = _dt;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region _btnAdd02_Click : 구비서류 추가 버튼 클릭 이벤트
        /// <summary>
        /// 구비서류 추가 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAdd02_Click(object sender, EventArgs e)
        {
            BAS0702 _form		= new BAS0702();
            _form.AGT_CD		= _txtAGT_CD.Text;
            DialogResult res	= _form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                LoadFileInfo(_txtAGT_CD.Text);
            }
        }
        #endregion

        #region gridView2_DataBindingComplete : 구비서류 아이콘 매핑
        /// <summary>
        /// 구비서류 아이콘 매핑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gridView2.Rows)
            {
                switch (row.Cells["DOC_FILE_TYPE"].Value.ToString())
                {
					case "XLS":
						row.Cells[4].Value			= _iglDocuments.Images[0];
						row.Cells[4].ToolTipText	= "엑셀 문서";
						break;
					case "PPT":
						row.Cells[4].Value			= _iglDocuments.Images[1];
						row.Cells[4].ToolTipText	= "파워포인트 문서";
						break;
					case "DOC":
						row.Cells[4].Value			= _iglDocuments.Images[2];
						row.Cells[4].ToolTipText	= "워드 문서";
						break;
					case "HWP":
						row.Cells[4].Value			= _iglDocuments.Images[3];
						row.Cells[4].ToolTipText	= "한글 문서";
						break;
					case "PDF":
						row.Cells[4].Value			= _iglDocuments.Images[4];
						row.Cells[4].ToolTipText	= "PDF 문서";
						break;
					case "JPG":
						row.Cells[4].Value			= _iglDocuments.Images[5];
						row.Cells[4].ToolTipText	= "JPG 이미지";
						break;
					case "PNG":
						row.Cells[4].Value			= _iglDocuments.Images[6];
						row.Cells[4].ToolTipText	= "PNG 이미지";
						break;
					case "GIF":
						row.Cells[4].Value			= _iglDocuments.Images[7];
						row.Cells[4].ToolTipText	= "GIF 이미지";
						break;
					case "BMP":
						row.Cells[4].Value			= _iglDocuments.Images[8];
						row.Cells[4].ToolTipText	= "BMP 이미지";
						break;
                }
            }
        }
        #endregion

        #region gridView2_CellContentClick : 구비서류 다운로드
        /// <summary>
        /// 구비서류 다운로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                gridView2.Enabled = false;
                progressBar1.Visible = true;
                base.SetWaitCursor();

                _thread = new Thread(() => OpenFile(Convert.ToInt32(gridView2.Rows[e.RowIndex].Cells["IDX2"].Value.ToString())));
                _thread.Start();
            }
        }

        void OpenFile(int IDX)
        {
            try
            {
                DataTable _dt = base.GetDataTable("PCSP_BAS0700_R4"
                    , IDX
                    );

                string tempPath = System.IO.Path.GetTempPath();
                string tempFileName = _dt.Rows[0]["DOC_FILE_NAME"].ToString();
                string fullFileName = string.Format("{0}{1}", tempPath, tempFileName);

                // 임시 폴더에 파일을 저장
                byte[] buff = (byte[])_dt.Rows[0]["DOC_FILE_DATA"];
                File.WriteAllBytes(fullFileName, buff);

                // 임시 파일을 실행
                Process proc = new Process();
                proc.StartInfo.FileName = fullFileName;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                gridView2.Enabled = true;

                progressBar1.Invoke((MethodInvoker)delegate()
                {
                    progressBar1.Visible = false;
                });

                base.RestoreCursor();
            }
        }
        #endregion

		#region gridView2_CellDoubleClick : 구비서류 그리드 더블 클릭
		/// <summary>
		/// 구비서류 그리드 더블 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			BAS0702 _form		= new BAS0702();
			_form.AGT_CD		= _txtAGT_CD.Text;
			_form.IDX			= (int)gridView2.Rows[e.RowIndex].Cells["IDX2"].Value;
			DialogResult res	= _form.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				LoadFileInfo(_txtAGT_CD.Text);
			}
		}
		#endregion

        #region _btnDel02_Click : 구비서류 삭제 버튼 클릭 이벤트
        /// <summary>
        /// 구비서류 삭제 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnDel02_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("삭제할 구비서류를 선택하세요. Ctrl + 마우스 클릭 시, 여러 개를 동시에 선택할 수 있습니다.");
                    return;
                }

                foreach (DataGridViewRow _row in gridView2.SelectedRows)
                {
                    base.ExecuteNonQuery("PCSP_BAS0700_D2"
                        , Convert.ToInt32(_row.Cells["IDX2"].Value.ToString())
						, _txtAGT_CD.Text								// 대리점코드
						, ""											// 비고
						, base.GetCookie("USRID")						// 시스템삭제자ID
						, base.GetCookie("USRNM")						// 시스템삭제자명
                        );
                }

                LoadFileInfo(_txtAGT_CD.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        // 통화내역
        #region LoadCallInfo : 통화내역 데이터그리드 바인딩
        /// <summary>
        /// 통화내역 데이터그리드 바인딩
        /// </summary>
        /// <param name="AGT_CD"></param>
        void LoadCallInfo(string AGT_CD)
        {
            try
            {
                DataTable _dt = base.GetDataTable("PCSP_BAS0700_R5"
                    , AGT_CD
                    );
                gridView3.DataSource = _dt;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region _btnAdd03_Click : 통화내역 추가 버튼 클릭 이벤트
        /// <summary>
        /// 통화내역 추가 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAdd03_Click(object sender, EventArgs e)
        {
            BAS0703 _form = new BAS0703();
            _form.AGT_CD = _txtAGT_CD.Text;
            DialogResult res = _form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                LoadCallInfo(_txtAGT_CD.Text);
            }
        }
        #endregion

        #region _btnDel03_Click : 통화내역 삭제 버튼 클릭 이벤트
        /// <summary>
        /// 통화내역 삭제 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnDel03_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView3.SelectedRows.Count == 0)
                {
                    MessageBox.Show("삭제할 통화내역을 선택하세요. Ctrl + 마우스 클릭 시, 여러 개를 동시에 선택할 수 있습니다.");
                    return;
                }

                foreach (DataGridViewRow _row in gridView3.SelectedRows)
                {
                    base.ExecuteNonQuery("PCSP_BAS0700_D3"
                        , Convert.ToInt32(_row.Cells["IDX3"].Value.ToString())
                        );
                }

                LoadCallInfo(_txtAGT_CD.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region gridView3_CellDoubleClick : 통화내역 그리드 더블 클릭
        /// <summary>
        /// 통화내역 그리드 더블 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BAS0703 _form = new BAS0703();
            _form.AGT_CD = _txtAGT_CD.Text;
            _form.IDX = (int)gridView3.Rows[e.RowIndex].Cells["IDX3"].Value;
            DialogResult res = _form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                LoadCallInfo(_txtAGT_CD.Text);
            }
        }
        #endregion
    }
}