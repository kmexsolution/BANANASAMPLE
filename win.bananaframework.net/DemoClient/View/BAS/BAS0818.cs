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
	/// 제  목: 가맹점.정산/계약정보이력조회
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-10 20:34
	/// 설  명: 가맹점의 정산/계약정보 변경이력을 조회하는 화면입니다.
	/// </summary>
	public partial class BAS0818 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		private Thread _thread;	// 검색 쓰레드

		#region BAS0818 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0818()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0818_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0818_Load(object sender, EventArgs e)
		{
			try
			{
				//// 컬럼 머지 처리-거래일자
				//var merge01	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "GROUP_NO", DisplayColumnIndex = 2 };
				//this.gridView1.AddMergingDataInfo(merge01);

				//// 컬럼 머지 처리-시스템등록일
				//var merge02	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "SYSREGDATE", DisplayColumnIndex = 29 };
				//this.gridView1.AddMergingDataInfo(merge02);

				//// 컬럼 머지 처리-시스템등록자
				//var merge03	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "SYSREGNAME", DisplayColumnIndex = 30 };
				//this.gridView1.AddMergingDataInfo(merge03);

				//// 컬럼 머지 처리-시스템수정일
				//var merge04	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "SYSMODDATE", DisplayColumnIndex = 31 };
				//this.gridView1.AddMergingDataInfo(merge04);

				//// 컬럼 머지 처리-시스템수정자
				//var merge05	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "SYSMODNAME", DisplayColumnIndex = 32 };
				//this.gridView1.AddMergingDataInfo(merge05);

				//// 컬럼 머지 처리-시스템삭제일
				//var merge06	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "SYSDELDATE", DisplayColumnIndex = 33 };
				//this.gridView1.AddMergingDataInfo(merge06);

				//// 컬럼 머지 처리-시스템삭제자
				//var merge07	= new BANANA.Windows.Controls.DataGridView.ColumnMergeInfo { DataColumnName = "SYSDELNAME", DisplayColumnIndex = 34 };
				//this.gridView1.AddMergingDataInfo(merge07);

				// 날짜
				_dtpCI_CNTR_STRT_DT_S.Checked	= false;
				_dtpCI_CNTR_STRT_DT_E.Checked	= false;
				_dtpCI_CNTR_END_DT_S.Checked	= false;
				_dtpCI_CNTR_END_DT_E.Checked	= false;
				_dtpCI_WTHR_STRT_DT_S.Checked	= false;
				_dtpCI_WTHR_STRT_DT_E.Checked	= false;

				// 처리기간
				_dtpSYSMODDATE_S_S.Value	= Convert.ToDateTime(System.DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd 00:00:00"));
				_dtpSYSMODDATE_E_S.Value	= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0818_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0818_Shown(object sender, EventArgs e)
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

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtSTR_NM_S.ReadOnly			= !_bTrue;
			_txtSTR_CD_S.ReadOnly			= !_bTrue;
			_dtpCI_CNTR_STRT_DT_S.Enabled	= _bTrue;
			_dtpCI_CNTR_STRT_DT_E.Enabled	= _bTrue;
			_dtpCI_CNTR_END_DT_S.Enabled	= _bTrue;
			_dtpCI_CNTR_END_DT_E.Enabled	= _bTrue;
			_dtpCI_WTHR_STRT_DT_S.Enabled	= _bTrue;
			_dtpCI_WTHR_STRT_DT_E.Enabled	= _bTrue;
			_txtCI_UNIT_LMT_S.ReadOnly		= !_bTrue;
			_txtCI_UNIT_LMT_E.ReadOnly		= !_bTrue;
			_txtCI_DAILY_LMT_S.ReadOnly		= !_bTrue;
			_txtCI_DAILY_LMT_E.ReadOnly		= !_bTrue;
			_txtCI_TOT_LMT_S.ReadOnly		= !_bTrue;
			_txtCI_TOT_LMT_E.ReadOnly		= !_bTrue;
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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0818_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_CD_S.Text																					// 가맹점코드
					, _txtSTR_NM_S.Text																					// 가맹점명
					, base.GetDate(_dtpCI_CNTR_STRT_DT_S) == "" ? "1900-01-01" : base.GetDate(_dtpCI_CNTR_STRT_DT_S)	// 계약일자(시작)
					, base.GetDate(_dtpCI_CNTR_STRT_DT_E) == "" ? "2100-12-31" : base.GetDate(_dtpCI_CNTR_STRT_DT_E)	// 계약일자(종료)
					, base.GetDate(_dtpCI_CNTR_END_DT_S) == "" ? "1900-01-01" : base.GetDate(_dtpCI_CNTR_END_DT_S)		// 해지일자(시작)
					, base.GetDate(_dtpCI_CNTR_END_DT_E) == "" ? "2100-12-31" : base.GetDate(_dtpCI_CNTR_END_DT_E)		// 해지일자(종료)
					, base.GetDate(_dtpCI_WTHR_STRT_DT_S) == "" ? "1900-01-01" : base.GetDate(_dtpCI_WTHR_STRT_DT_S)	// 출금시작일자(시작)
					, base.GetDate(_dtpCI_WTHR_STRT_DT_E) == "" ? "2100-12-31" : base.GetDate(_dtpCI_WTHR_STRT_DT_E)	// 출금시작일자(종료)
					, _txtCI_UNIT_LMT_S.Text == "" ? -1000000000 : base.GetInteger(_txtCI_UNIT_LMT_S)					// 건별대출한도(시작)
					, _txtCI_UNIT_LMT_E.Text == "" ? 1000000000 : base.GetInteger(_txtCI_UNIT_LMT_E)					// 건별대출한도(종료)
					, _txtCI_DAILY_LMT_S.Text == "" ? -1000000000 : base.GetInteger(_txtCI_DAILY_LMT_S)					// 1일대출한도(시작)
					, _txtCI_DAILY_LMT_E.Text == "" ? 1000000000 : base.GetInteger(_txtCI_DAILY_LMT_E)					// 1일대출한도(종료)
					, _txtCI_TOT_LMT_S.Text == "" ? -1000000000 : base.GetInteger(_txtCI_TOT_LMT_S)						// 총대출한도(시작)
					, _txtCI_TOT_LMT_E.Text == "" ? 1000000000 : base.GetInteger(_txtCI_TOT_LMT_E)						// 총대출한도(종료)
					, _txtSYSREGNAME_S.Text																				// 처리자
					, _dtpSYSMODDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")											// 처리기간(시작)
					, _dtpSYSMODDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")											// 처리기간(종료)
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

		#region _btnExcel_Click : 엑셀 버튼 클릭 이벤트
		/// <summary>
		/// 엑셀 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				Dictionary<string, string> _dic = new Dictionary<string, string>();
				_dic.Add("F", "yyyy-MM-dd");
				_dic.Add("AC", "yyyy-MM-dd");
				_dic.Add("W", "yyyy-MM-dd");
				_dic.Add("AD", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("AF", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("AH", "yyyy-MM-dd HH:mm:ss");

				_dic.Add("Z", "#,###");
				_dic.Add("AA", "#,###");
				_dic.Add("AB", "#,###");
				gridView1.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
