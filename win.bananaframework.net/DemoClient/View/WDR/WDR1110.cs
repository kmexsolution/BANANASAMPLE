using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using System.Threading;

namespace DemoClient.View.WDR
{
	public partial class WDR1110 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
    {
		// 검색 쓰레드
		private Thread _thread;

		#region WDR1110 : 생성자
		/// <summary>
		/// 생성자
		/// </summary>
        public WDR1110()
        {
            InitializeComponent();
        }
		#endregion

		#region WDR1110_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR1110_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpTRADEDATE_S_S.Value		= Convert.ToDateTime(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " 00:00:00");
				_dtpTRADEDATE_E_S.Value		= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");

				#region 검색 일자 구분
				DataTable _dt = new DataTable();

				_dt.Columns.Add("TOTAL_CODE");
				_dt.Columns.Add("CODE_NAME");

				DataRow _dr = _dt.NewRow();
				_dr["TOTAL_CODE"] = "1";
				_dr["CODE_NAME"] = "거래일자";
				_dt.Rows.Add(_dr);

				_dr = _dt.NewRow();
				_dr["TOTAL_CODE"] = "2";
				_dr["CODE_NAME"] = "입금일자";
				_dt.Rows.Add(_dr);

				base.SetListItem(_cmbDateGubun, _dt, "TOTAL_CODE", "CODE_NAME");
				#endregion

				// 매입카드사
				DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A08", "", "Y", "", "");
				base.SetListItem(_cmbBUYING_CD_S, _dt01, "TOTAL_CODE", "CODE_NAME", true);

				// 카드종류
				DataTable _dt02		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "V03", "", "", "", "");
				base.SetListItem(_cmbCREDIT_CD_S, _dt02, "TOTAL_CODE", "CODE_NAME", true);

				// 중복거래
				base.SetListItem(_cmbIS_DUPL, base.DataTableYorN(""), "TOTAL_CODE", "CODE_NAME");

				// 건별한도초과
				base.SetListItem(_cmbIS_UNIT_LIMITED, base.DataTableYorN("건별한도초과"), "TOTAL_CODE", "CODE_NAME");

				// 1일한도초과
				base.SetListItem(_cmbIS_DAILY_LIMITED, base.DataTableYorN("1일한도초과"), "TOTAL_CODE", "CODE_NAME");

				// 총한도초과
				base.SetListItem(_cmbIS_TOT_LIMITED, base.DataTableYorN("총한도초과"), "TOTAL_CODE", "CODE_NAME");

				// 출금요청상태
				DataTable _dt03		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "S01", "", "", "", "");
				base.SetListItem(_cmbWDRREQ_CD, _dt03, "TOTAL_CODE", "CODE_NAME", true);

				// 출금승인상태
				DataTable _dt04		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "S02", "", "", "", "");
				base.SetListItem(_cmbWDRAPPR_CD, _dt04, "TOTAL_CODE", "CODE_NAME", true);

				// 변경내역
				DataTable _dt05		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A11", "", "", "", "");
				base.SetListItem(_cmbGUBUN_CD, _dt05, "TOTAL_CODE", "CODE_NAME", true);

				// 출금처리상태
				DataTable _dtCOMPLETE_YN		= new DataTable();

				_dtCOMPLETE_YN.Columns.Add("TOTAL_CODE");
				_dtCOMPLETE_YN.Columns.Add("CODE_NAME");

				DataRow _drCOMPLETE_YN			= _dtCOMPLETE_YN.NewRow();
				_drCOMPLETE_YN["TOTAL_CODE"]	= "Y";
				_drCOMPLETE_YN["CODE_NAME"]		= "출금완료";
				_dtCOMPLETE_YN.Rows.Add(_drCOMPLETE_YN);

				_drCOMPLETE_YN					= _dtCOMPLETE_YN.NewRow();
				_drCOMPLETE_YN["TOTAL_CODE"]	= "P";
				_drCOMPLETE_YN["CODE_NAME"]		= "정산완료 출금대기";
				_dtCOMPLETE_YN.Rows.Add(_drCOMPLETE_YN);

				_drCOMPLETE_YN					= _dtCOMPLETE_YN.NewRow();
				_drCOMPLETE_YN["TOTAL_CODE"]	= "N";
				_drCOMPLETE_YN["CODE_NAME"]		= "출금대기";
				_dtCOMPLETE_YN.Rows.Add(_drCOMPLETE_YN);

				base.SetListItem(_cmbCOMPLETE_YN, _dtCOMPLETE_YN, "TOTAL_CODE", "CODE_NAME", true);
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
			_txtWDR0100_IDX_S.ReadOnly		= !_bTrue;
			_cmbDateGubun.Enabled			= _bTrue;
			_dtpTRADEDATE_S_S.Enabled		= _bTrue;
			_dtpTRADEDATE_E_S.Enabled		= _bTrue;
			_cmbBUYING_CD_S.Enabled			= _bTrue;
			_cmbCREDIT_CD_S.Enabled			= _bTrue;
			_txtAPPRAMT_S_S.ReadOnly		= !_bTrue;
			_txtAPPRAMT_E_S.ReadOnly		= !_bTrue;
			_cmbWDRREQ_CD.Enabled			= _bTrue;
			_cmbWDRAPPR_CD.Enabled			= _bTrue;
			_cmbGUBUN_CD.Enabled			= _bTrue;
			_cmbIS_DUPL.Enabled				= _bTrue;
			_cmbCOMPLETE_YN.Enabled			= _bTrue;
			_cmbIS_UNIT_LIMITED.Enabled		= _bTrue;
			_cmbIS_DAILY_LIMITED.Enabled	= _bTrue;
			_cmbIS_TOT_LIMITED.Enabled		= _bTrue;
			_btnSearch.Enabled				= _bTrue;
			_btnExcel.Enabled				= _bTrue;
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
				int amt_strt	= _txtAPPRAMT_S_S.Text == "" ? -1000000000 : Convert.ToInt32(_txtAPPRAMT_S_S.Text);
				int amt_end		= _txtAPPRAMT_E_S.Text == "" ? 1000000000 : Convert.ToInt32(_txtAPPRAMT_E_S.Text);

				DataTable _dt			= base.GetDataTable(
					"PCSP_WDR1110_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtWDR0100_IDX_S.Text
					, _cmbDateGubun.SelectedValue			// 검색일자 구분(1:거래일자/2:입금일자)
					, _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _cmbBUYING_CD_S.SelectedValue
					, _cmbCREDIT_CD_S.SelectedValue
					, amt_strt
					, amt_end
					, _cmbWDRREQ_CD.SelectedValue			// 출금요청상태
					, _cmbWDRAPPR_CD.SelectedValue			// 출금승인상태
					, _cmbCOMPLETE_YN.SelectedValue			// 출금처리상태
					, _cmbIS_DUPL.SelectedValue				// 중복거래여부
					, _cmbGUBUN_CD.SelectedValue			// 출금관리 이력변경 코드(A11)
					, _cmbIS_UNIT_LIMITED.SelectedValue		// 건별대출한도 초과여부
					, _cmbIS_DAILY_LIMITED.SelectedValue	// 1일대출한도 초과여부
					, _cmbIS_TOT_LIMITED.SelectedValue		// 총대출한도 초과여부
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



		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			// 취소
			var cnclRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["SUCCESSRES_CD"].Value.ToString().Trim().Equals("V02002"))
				.Select(row => row);
			foreach (DataGridViewRow row in cnclRows)
			{
				row.DefaultCellStyle = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 중복
			var duplRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_DUPL"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in duplRows)
			{
				row.Cells["IS_DUPL"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 건별한도
			var indvRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_UNIT_LIMITED"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in indvRows)
			{
				row.Cells["IS_UNIT_LIMITED"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 1일한도
			var dailyRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_DAILY_LIMITED"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in dailyRows)
			{
				row.Cells["IS_DAILY_LIMITED"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 총한도
			var totRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_TOT_LIMITED"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in totRows)
			{
				row.Cells["IS_TOT_LIMITED"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}


			// 승인완료
			var apprRows1 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRREQ_CD"].Value.ToString().Trim().Equals("S01001"))
				.Select(row => row);
			foreach (DataGridViewRow row in apprRows1)
			{
				row.Cells["WDRREQ_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Black };
			}

			// 승인완료
			var apprRows2 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRREQ_CD"].Value.ToString().Trim().Equals("S01002"))
				.Select(row => row);
			foreach (DataGridViewRow row in apprRows2)
			{
				row.Cells["WDRREQ_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Blue };
			}

			// 승인완료
			var apprRows3 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRREQ_CD"].Value.ToString().Trim().Equals("S01003"))
				.Select(row => row);
			foreach (DataGridViewRow row in apprRows3)
			{
				row.Cells["WDRREQ_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 승인완료
			var cnclRows1 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRAPPR_CD"].Value.ToString().Trim().Equals("S02002"))
				.Select(row => row);
			foreach (DataGridViewRow row in cnclRows1)
			{
				row.Cells["WDRAPPR_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Blue };
			}

			// 승인완료
			var cnclRows2 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRAPPR_CD"].Value.ToString().Trim().Equals("S02003"))
				.Select(row => row);
			foreach (DataGridViewRow row in cnclRows2)
			{
				row.Cells["WDRAPPR_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}
		}

		private void _btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				Dictionary<string, string> _dic = new Dictionary<string, string>();
				_dic.Add("E", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("K", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("L", "yyyy-MM-dd HH:mm:ss");

				_dic.Add("A", "@");
				_dic.Add("B", "@");
				_dic.Add("N", "@");
				_dic.Add("P", "@");
				_dic.Add("Q", "@");

				_dic.Add("O", "#,###");
				gridView1.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
				MessageBox.Show(err.Message);
			}
		}
    }
}