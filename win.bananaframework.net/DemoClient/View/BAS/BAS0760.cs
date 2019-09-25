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
	/// 제  목: 정산/계약정보이력조회
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-14 21:36
	/// 설  명: 대리점의 정산/계약정보의 이력을 조회하는 화면입니다.
	/// </summary>
	public partial class BAS0760 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region BAS0760 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0760()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0760_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0760_Load(object sender, EventArgs e)
		{
			try
			{
				//// 컬럼 밴드 처리-사업자등록증정보
				//var band01	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND01", HeaderText = "변경 전", BackColor = Color.Azure, UseBackColor = true };
				//band01.Columns.Add(_CI_CNTR_STRT_DT);
				//band01.Columns.Add(_CI_CNTR_END_DT);
				//band01.Columns.Add(_CI_BNK_NM);
				//band01.Columns.Add(_CI_ACCT_NO);
				//band01.Columns.Add(_CI_ACCT_NM);
				//this.gridView1.AddBand(band01);
				
				//// 컬럼 밴드 처리-대표자정보
				//var band02	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND02", HeaderText = "변경 후", BackColor = Color.LightBlue, UseBackColor = true };
				//band02.Columns.Add(CI_CNTR_STRT_DT);
				//band02.Columns.Add(CI_CNTR_END_DT);
				//band02.Columns.Add(CI_BNK_NM);
				//band02.Columns.Add(CI_ACCT_NO);
				//band02.Columns.Add(CI_ACCT_NM);
				//this.gridView1.AddBand(band02);

				// 은행코드
				DataTable _dt03	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A02", "", "", "", "");
				base.SetListItem(_cmbCI_BNK_CD_S, _dt03, "TOTAL_CODE", "CODE_NAME", true);

				_dtpSYSMODDATE_S_S.Value	= Convert.ToDateTime(System.DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd 00:00:00"));
				_dtpSYSMODDATE_E_S.Value	= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0760_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0760_Shown(object sender, EventArgs e)
		{
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화
		/// <summary>
		/// 컨트롤 활성화/비활성화
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtAGT_NM_S.ReadOnly			= !_bTrue;
			_txtAGT_CD_S.ReadOnly			= !_bTrue;
			_cmbCI_BNK_CD_S.Enabled			= _bTrue;
			_txtCI_ACCT_NO_S.ReadOnly		= !_bTrue;
			_txtCI_ACCT_NM_S.ReadOnly		= !_bTrue;
			_txtSYSREGNAME_S.ReadOnly		= !_bTrue;
			_dtpSYSMODDATE_S_S.Enabled		= _bTrue;
			_dtpSYSMODDATE_E_S.Enabled		= _bTrue;
			_btnSearch.Enabled				= _bTrue;
			_btnExcel.Enabled				= _bTrue;

			gridView1.Enabled				= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
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
				int res			= Search();
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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0760_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtAGT_NM_S.Text
					, _txtAGT_CD_S.Text
					, _cmbCI_BNK_CD_S.SelectedValue
					, _txtCI_ACCT_NO_S.Text
					, _txtCI_ACCT_NM_S.Text
					, _txtSYSREGNAME_S.Text
					, base.GetDate(_dtpSYSMODDATE_S_S, "yyyy-MM-dd HH:mm:ss")
					, base.GetDate(_dtpSYSMODDATE_E_S, "yyyy-MM-dd HH:mm:ss")
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

		#region _btnExcel_Click : 엑셀버튼 클릭 이벤트
		/// <summary>
		/// 엑셀버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				gridView1.ExportToExcel();
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
