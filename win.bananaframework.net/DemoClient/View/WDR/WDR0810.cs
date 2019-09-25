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
    public partial class WDR0810 : DemoClient.Controllers.BaseForm
	{
		private Thread _thread;	// 검색 쓰레드
		private int _intBAS0830IDX = 0;
		private string _strSTR_CD;
		private string _strSTR_NM;

		#region WDR0810 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
        public WDR0810()
        {
            InitializeComponent();
        }
		#endregion

		#region WDR0810_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0810_Load(object sender, EventArgs e)
		{
			try
			{
				// 출금/차감구분
				DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "C01"
					, ""
					, ""
					, ""
					, ""
					);

				base.SetListItem(_cmbMNS_GUBUN_CD_S
					, _dt01
					, "TOTAL_CODE"
					, "CODE_NAME"
					, true
					);

				base.SetListItem(_cmbMNS_USE_YN_S
					, DataTableYorN("")
					, "TOTAL_CODE"
					, "CODE_NAME"
					, false
					);

				DataTable _dt02 = base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "C03"
					, ""
					, ""
					, ""
					, ""
					);

				base.SetListItem(_cmbMNS_REG_CD_S
					, _dt02
					, "TOTAL_CODE"
					, "CODE_NAME"
					, true
					);

				// 전체 그리드 ReadOnly 속성값 부여
				// 2016-12-01 한인수 수정
				// GridView.cs에서 하고 싶었으나 각 화면의 속성값을 최종적으로 가져가게 되어 화면단에서 처리
				foreach (DataGridViewColumn colum in gridView1.Columns)
				{
					colum.ReadOnly = true;
				}

				foreach (DataGridViewColumn colum in gridView2.Columns)
				{
					colum.ReadOnly = true;
				}

				foreach (DataGridViewColumn colum in gridView3.Columns)
				{
					colum.ReadOnly = true;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region WDR0810_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0810_Shown(object sender, EventArgs e)
		{
			_dtpMNS_APP_DT_S_S.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day);
			_dtpMNS_APP_DT_E_S.Value = DateTime.Now;
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
			_dtpMNS_APP_DT_S_S.Enabled	= _bTrue;
			_dtpMNS_APP_DT_E_S.Enabled	= _bTrue;
			_cmbMNS_GUBUN_CD_S.Enabled	= _bTrue;
			_cmbMNS_USE_YN_S.Enabled	= _bTrue;
			_cmbMNS_REG_CD_S.Enabled	= _bTrue;
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
				DataTable _dt = base.GetDataTable("PCSP_BAS0814_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtSTR_CD_S.Text
					, _dtpMNS_APP_DT_S_S.Value.ToString("yyyy-MM-dd")
					, _dtpMNS_APP_DT_E_S.Value.ToString("yyyy-MM-dd")
					, _cmbMNS_GUBUN_CD_S.SelectedValue
					, _cmbMNS_USE_YN_S.SelectedValue
					, _cmbMNS_REG_CD_S.SelectedValue
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

					EnableControls2(true);
					ClearControls();

					_intBAS0830IDX	= Int32.Parse(gridView1.Rows[e.RowIndex].Cells["BAS0830_IDX"].Value.ToString());
					_strSTR_CD		= gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value.ToString();
					_strSTR_NM		= gridView1.Rows[e.RowIndex].Cells["STR_NM"].Value.ToString();
					bool _bGubun	= gridView1.Rows[e.RowIndex].Cells["MNS_GUBUN_CODE"].Value.ToString() == "C01002" ? true : false;

					SetGridView2(_bGubun);
					SetGridView3(_bGubun);
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
		private void SetGridView2(bool _bGubun)
		{
			try
			{
				if (_bGubun)
				{
					DataSet _ds = base.GetDataSet("PCSP_BAS0814_R2"
						, _intBAS0830IDX
						);

					gridView2.DataSource = _ds.Tables[1];
				}
				else
				{
					gridView2.DataSource = null;;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region SetGridView3 : 상세정보 그리드 데이터 바인딩
		/// <summary>
		/// 상세정보 그리드 데이터 바인딩
		/// </summary>
		private void SetGridView3(bool _bGubun)
		{
			try
			{
				if (_bGubun)
				{
					DataTable _dt = base.GetDataTable("PCSP_WDR0810_R3"
						, _intBAS0830IDX
						);
					gridView3.DataSource = _dt;
				}
				else
				{
					gridView3.DataSource = null; ;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion		
    }
}