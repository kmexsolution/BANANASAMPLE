using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace DemoClient.View.WDR
{
    public partial class WDR0910 : DemoClient.Controllers.BaseForm
	{
		private Thread _thread;		// 검색 쓰레드

		#region WDR0910 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
        public WDR0910()
        {
            InitializeComponent();
        }
		#endregion

		#region WDR0910_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0910_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpDPST_STRT_DT_S_S.Value		= DateTime.Now.AddDays(1 - DateTime.Now.Day);
				_dtpDPST_STRT_DT_E_S.Value		= DateTime.Now;

				//// 차감기준
				//DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B01", "", "", "", "");
				//base.SetListItem(_cmbDPST_GIJUN_CD, _dt01, "TOTAL_CODE", "CODE_NAME");

				//// 계산방법
				//DataTable _dt02		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B02", "", "", "", "");
				//base.SetListItem(_cmbDPST_CAL_CD, _dt02, "TOTAL_CODE", "CODE_NAME");
				
				// 차감기준(검색)
				DataTable _dt03		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B01", "", "", "", "");
				base.SetListItem(_cmbDPST_GIJUN_CD_S, _dt03, "TOTAL_CODE", "CODE_NAME", true);

				// 계산방법(검색)
				DataTable _dt04		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B02", "", "", "", "");
				base.SetListItem(_cmbDPST_CAL_CD_S, _dt04, "TOTAL_CODE", "CODE_NAME", true);

				//_dtpDPST_STRT_DT.Checked		= false;
				_dtpDPST_STRT_DT_S_S.Checked	= false;
				_dtpDPST_STRT_DT_E_S.Checked	= false;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region WDR0910_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0910_Shown(object sender, EventArgs e)
		{

		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
			//_txtSTR_CD.Text					= "";
			//_txtSTR_NM.Text					= "";
			//_dtpDPST_STRT_DT.Value			= DateTime.Now;
			//_dtpDPST_STRT_DT.Checked		= false;
			//_rbDPST_USE_Y.Checked			= true;
			//_rbDPST_USE_N.Checked			= false;
			//_cmbDPST_GIJUN_CD.SelectedIndex	= 0;
			//_cmbDPST_GIJUN_CD.Enabled		= false;
			//_cmbDPST_CAL_CD.SelectedIndex	= 0;
			//_rbDPST_INTST_Y.Checked			= true;
			//_rbDPST_INTST_N.Checked			= false;
			//_txtDPST_LMT_AMT.Text			= "";
			//_txtDPST_PER.Text				= "";
			//_lblDPST_CAL_CD.Text			= "원";
			//_txtDPST_AMT.Text				= "";
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
			_dtpDPST_STRT_DT_S_S.Enabled	= _bTrue;
			_dtpDPST_STRT_DT_E_S.Enabled	= _bTrue;
			_cmbDPST_GIJUN_CD_S.Enabled		= _bTrue;
			_cmbDPST_CAL_CD_S.Enabled		= _bTrue;
			_txtDPST_AMT_S_S.ReadOnly		= !_bTrue;
			_txtDPST_AMT_E_S.ReadOnly		= !_bTrue;
			_btnSearch.Enabled				= _bTrue;
			_btnExcel.Enabled				= _bTrue;

			gridView1.Enabled				= _bTrue;
			//gridView2.Enabled				= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			//_dtpDPST_STRT_DT.Enabled	= _bTrue;
			//_rbDPST_USE_Y.Enabled		= _bTrue;
			//_rbDPST_USE_N.Enabled		= _bTrue;
			//_cmbDPST_GIJUN_CD.Enabled	= _bTrue;
			//_cmbDPST_CAL_CD.Enabled		= _bTrue;
			//_rbDPST_INTST_Y.Enabled		= _bTrue;
			//_rbDPST_INTST_N.Enabled		= _bTrue;
			//_txtDPST_LMT_AMT.ReadOnly	= !_bTrue;
			//_txtDPST_PER.ReadOnly		= !_bTrue;
			//_txtDPST_AMT.ReadOnly		= !_bTrue;
			
			//_btnAdd01.Enabled			= _bTrue;
			//_btnSave01.Enabled			= _bTrue;
			//_btnDel01.Enabled			= _bTrue;

			//_btnAdd02.Enabled			= _bTrue;
			//_btnDel02.Enabled			= _bTrue;
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
				int? strt	= _txtDPST_AMT_S_S.Text == "" ? -1000000000 : base.GetInteger(_txtDPST_AMT_S_S);
				int? end	= _txtDPST_AMT_E_S.Text == "" ? 1000000000 : base.GetInteger(_txtDPST_AMT_E_S);

				DataTable _dt			= base.GetDataTable("PCSP_BAS0816_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_CD_S.Text
					, _txtSTR_NM_S.Text						// 가맹점명
					, base.GetDate(_dtpDPST_STRT_DT_S_S)	// 적용시작일(시작)
					, base.GetDate(_dtpDPST_STRT_DT_E_S)	// 적용시작일(종료)
					, base.GetString(_cmbDPST_GIJUN_CD_S)	// 차감기준
					, base.GetString(_cmbDPST_CAL_CD_S)		// 계산방법
					, strt									// 보증한도금액(시작)
					, end									// 보증한도금액(종료)
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
				_dic.Add("C", "yyyy-MM-dd");
				_dic.Add("J", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("L", "yyyy-MM-dd HH:mm:ss");

				_dic.Add("I", "#,###");
				gridView1.ExportToExcel(_dic);
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
			panel1.Width = 600;
		}
		#endregion

		#region gridView1_CellClick : 검색결과 그리드 클릭 이벤트
		/// <summary>
		/// 검색결과 그리드 클릭 이벤트
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

					ClearControls();

					DataSet _ds = base.GetDataSet(
						"PCSP_WDR0910_R2"
						, gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value
						);

					//_txtSTR_CD.Text = gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value.ToString().Trim();
					//_txtSTR_NM.Text = gridView1.Rows[e.RowIndex].Cells["STR_NM"].Value.ToString();

					// 상세정보 바인딩
					SetGridView2(_ds.Tables[0]);

					// 예외기간 바인딩
					SetGridView3(_ds.Tables[1]);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region SetGridView2 : 상세정보 그리드 데이터 바인딩
		/// <summary>
		/// 상세정보 그리드 데이터 바인딩
		/// </summary>
		private void SetGridView2(DataTable _dt)
		{
			try
			{
				gridView2.DataSource = _dt;
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region SetGridView3 : 예외기간 그리드 데이터 바인딩
		/// <summary>
		/// 예외기간 그리드 데이터 바인딩
		/// </summary>
		private void SetGridView3(DataTable _dt)
		{
			try
			{
				gridView3.DataSource = _dt;
			}
			catch
			{
				throw;
			}
		}
		#endregion		
    }
}