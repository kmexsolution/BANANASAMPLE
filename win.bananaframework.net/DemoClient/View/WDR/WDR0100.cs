using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.WDR
{
	/// <summary>
	/// 제  목: 중복예상거래관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-27 18:38
	/// 설  명: 중복예상거래를 관리하는 화면입니다.
	/// </summary>
	public partial class WDR0100 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region WDR0100 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public WDR0100()
		{
			InitializeComponent();
		}
		#endregion

		#region WDR0100_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0100_Load(object sender, EventArgs e)
		{
			try
			{
				//// 컬럼 밴드 처리-원거래정보
				//var band01	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND01", HeaderText = "원거래정보", BackColor = Color.Azure, UseBackColor = true };
				//band01.Columns.Add(VAN_NM);
				//band01.Columns.Add(STR_NM);
				//band01.Columns.Add(TRADEDATE);
				//band01.Columns.Add(SUCCESSRES_CD);
				//band01.Columns.Add(SUCCESSRES_NM);
				//band01.Columns.Add(BUYING_NM);
				//band01.Columns.Add(CREDIT_NM);
				//band01.Columns.Add(METHOD_NM);
				//band01.Columns.Add(CANCELDATE);
				//band01.Columns.Add(DUEDATE);
				//band01.Columns.Add(CARDNO);
				//band01.Columns.Add(APPRNO);
				//band01.Columns.Add(APPRAMT);
				//band01.Columns.Add(AFFNO);
				//band01.Columns.Add(BUSINESSNO);
				//this.gridView1.AddBand(band01);
				
				//// 컬럼 밴드 처리-중복거래여부
				//var band02	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND02", HeaderText = "중복거래여부", BackColor = Color.LightBlue, UseBackColor = true };
				//band02.Columns.Add(IS_DUPL);
				//band02.Columns.Add(DUPL_RLS_MEMO);
				//this.gridView1.AddBand(band02);
				
				//// 컬럼 밴드 처리-한도초과여부
				//var band03	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND03", HeaderText = "한도초과여부", BackColor = Color.LightCoral, UseBackColor = true };
				//band03.Columns.Add(IS_UNIT_LIMITED);
				//band03.Columns.Add(IS_DAILY_LIMITED);
				//band03.Columns.Add(IS_TOT_LIMITED);
				//band03.Columns.Add(LMT_RLS_MEMO);
				//this.gridView1.AddBand(band03);
				
				//// 컬럼 밴드 처리-출금요청상태
				//var band04	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND04", HeaderText = "출금요청상태", BackColor = Color.LightCyan, UseBackColor = true };
				//band04.Columns.Add(WDRREQ_NM);
				//band04.Columns.Add(WDRREQFAIL_NM);
				//band04.Columns.Add(WDRREQ_MEMO);
				//this.gridView1.AddBand(band04);
				
				//// 컬럼 밴드 처리-출금승인상태
				//var band05	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND05", HeaderText = "출금승인상태", BackColor = Color.LightGoldenrodYellow, UseBackColor = true };
				//band05.Columns.Add(WDRAPPR_NM);
				//band05.Columns.Add(WDRAPPR_MEMO);
				//this.gridView1.AddBand(band05);
				
				//// 컬럼 밴드 처리-출금처리상태
				//var band06	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND06", HeaderText = "출금처리상태", BackColor = Color.LightGray, UseBackColor = true };
				//band06.Columns.Add(WDREXEC_NM);
				//band06.Columns.Add(WDREXEC_MEMO);
				//this.gridView1.AddBand(band06);
				
				//// 컬럼 밴드 처리-자동요청여부
				//var band07	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND07", HeaderText = "자동요청여부", BackColor = Color.LightGreen, UseBackColor = true };
				//band07.Columns.Add(AUTO_REQ);
				//band07.Columns.Add(AUTO_MEMO);
				//this.gridView1.AddBand(band07);

				_dtpTRADEDATE_S_S.Value		= Convert.ToDateTime(System.DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 00:00:00"));
				_dtpTRADEDATE_E_S.Value		= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));

				gridView1.ReadOnly			= false;
				CHK.ReadOnly				= false;
				IDX.ReadOnly				= true;
				TIDX.ReadOnly				= true;

				// 매입카드사
				DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A08", "", "Y", "", "");
				base.SetListItem(_cmbBUYING_CD_S, _dt01, "TOTAL_CODE", "CODE_NAME", true);

				// 카드종류
				DataTable _dt02		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "V03", "", "", "", "");
				base.SetListItem(_cmbCREDIT_CD_S, _dt02, "TOTAL_CODE", "CODE_NAME", true);
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
			_txtSTR_NM_S.ReadOnly		= !_bTrue;
			_txtSTR_CD_S.ReadOnly		= !_bTrue;
			_dtpTRADEDATE_S_S.Enabled	= _bTrue;
			_dtpTRADEDATE_E_S.Enabled	= _bTrue;
			_cmbBUYING_CD_S.Enabled		= _bTrue;
			_cmbCREDIT_CD_S.Enabled		= _bTrue;
			_txtAPPRAMT_S_S.ReadOnly	= !_bTrue;
			_txtAPPRAMT_E_S.ReadOnly	= !_bTrue;
			_btnSearch.Enabled			= _bTrue;
			_btnExcel.Enabled			= _bTrue;
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

				DataTable _dt			= base.GetDataTable("PCSP_WDR0100_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtSTR_CD_S.Text
					, _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _cmbBUYING_CD_S.SelectedValue
					, _cmbCREDIT_CD_S.SelectedValue
					, amt_strt
					, amt_end
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

		#region gridView1_DataBindingComplete : 선택불가 Row에 대한 처리
		/// <summary>
		/// 선택불가 Row에 대한 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			//foreach (DataGridViewRow row in gridView1.Rows)
			//{
			//	// 체크박스 및 선택불가 처리
			//	if (gridView1.Rows[row.Index].Cells["CHK2"].Value.ToString() == "X")
			//	{
			//		gridView1.Rows[row.Index].Cells["CHK"].ReadOnly	= true;
			//		gridView1.Rows[row.Index].DefaultCellStyle		= new DataGridViewCellStyle { ForeColor = Color.LightGray };
			//	}
			//	else
			//	{
			//		gridView1.Rows[row.Index].Cells["CHK"].ReadOnly	= false;
			//	}
			//}

			// 체크박스 및 선택불가 처리
			var chekRows	= gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["CHK2"].Value.ToString() == "X")
				.Select(row => row);
			foreach (DataGridViewRow row in chekRows)
			{
				row.Cells["CHK"].ReadOnly	= true;
				row.DefaultCellStyle		= new DataGridViewCellStyle() { ForeColor = Color.LightGray };
			}

			// 중복
			var duplRows	= gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_DUPL"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in duplRows)
			{
				row.Cells["IS_DUPL"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 건별한도
			var indvRows	= gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_UNIT_LIMITED"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in indvRows)
			{
				row.Cells["IS_UNIT_LIMITED"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 1일한도
			var dailyRows	= gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_DAILY_LIMITED"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in dailyRows)
			{
				row.Cells["IS_DAILY_LIMITED"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 총한도
			var totRows		= gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["IS_TOT_LIMITED"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in totRows)
			{
				row.Cells["IS_TOT_LIMITED"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 취소
			var cnclRows	= gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["SUCCESSRES_CD"].Value.ToString().Trim().Equals("V02002"))
				.Select(row => row);
			foreach (DataGridViewRow row in cnclRows)
			{
				row.DefaultCellStyle	= new DataGridViewCellStyle() { ForeColor = Color.Red };
			}
		}
		#endregion

		#region _btnCheckAll_Click : 전체체크 버튼 클릭 이벤트
		/// <summary>
		/// 전체체크 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnCheckAll_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in gridView1.Rows)
			{
				if (gridView1.Rows[row.Index].Cells["CHK2"].Value.ToString() != "X")
				{
					gridView1.Rows[row.Index].Cells["CHK"].Value	= "Y";
				}
			}
		}
		#endregion

		#region _btnUnCheckAll_Click : 전체해제 버튼 클릭 이벤트
		/// <summary>
		/// 전체해제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnUnCheckAll_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in gridView1.Rows)
			{
				if (gridView1.Rows[row.Index].Cells["CHK2"].Value.ToString() != "X")
				{
					gridView1.Rows[row.Index].Cells["CHK"].Value	= "N";
				}
			}
		}
		#endregion

		#region _btnReleaseDupl_Click : 중복해제처리 버튼 클릭 이벤트
		/// <summary>
		/// 중복해제처리 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnReleaseDupl_Click(object sender, EventArgs e)
		{
			try
			{
				WDR0110 _form		= new WDR0110();
				DialogResult res	= _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					string reason		= _form.Reason;

					foreach (DataGridViewRow row in gridView1.Rows)
					{
						DataGridViewCheckBoxCell cell	= row.Cells["CHK"] as DataGridViewCheckBoxCell;

						if (cell.Value == cell.TrueValue)
						{
							try
							{
								base.ExecuteNonQuery("PCSP_WDR0100_U1"
									, Convert.ToInt32(row.Cells["IDX"].Value.ToString())
									, reason
									, ""							// 비고
									, base.GetCookie("USRID")		// 시스템수정자ID
									, base.GetCookie("USRNM")		// 시스템수정자명
									);
								gridView1.Rows[row.Index].Cells["STATUS"].Value	= "중복해제처리완료";
								gridView1.Rows[row.Index].Cells["CHK2"].Value	= "X";
							}
							catch (Exception err)
							{
								gridView1.Rows[row.Index].Cells["STATUS"].Value	= err.Message;
								gridView1.Rows[row.Index].Cells["STATUS"].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
							}
							gridView1.Rows[row.Index].Cells["CHK"].Value	= "N";
						}
					}

					MessageBox.Show("중복해제처리를 완료 하였습니다.");
				}
				else
				{
					MessageBox.Show("중복해제처리를 취소 하였습니다.");
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
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
				_dic.Add("G", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("M", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("N", "yyyy-MM-dd HH:mm:ss");

				_dic.Add("C", "@");
				_dic.Add("D", "@");
				_dic.Add("P", "@");
				_dic.Add("R", "@");
				_dic.Add("S", "@");

				_dic.Add("Q", "#,###");
				gridView1.ExportToExcel(_dic);
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
