using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace DemoClient.View.HLP
{
	public partial class HLP0300 : DemoClient.Controllers.BaseForm//, Control.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region HLP0300 : 생성자
		/// <summary>
		/// 생성자
		/// </summary>
		public HLP0300()
		{
			InitializeComponent();
		}
		#endregion

		#region HLP0300_Load : 폼 로드
		/// <summary>
		/// 폼 로드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HLP0300_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpREGDATE_S_S.Value = Convert.ToDateTime(DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd"));
				_dtpREGDATE_E_S.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

				// 구분
				DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "A12"
					, ""
					, ""
					, ""
					, ""
					);
				base.SetListItem(_cmbGUBUN_S
					, _dt01
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
			_dtpREGDATE_S_S.Enabled		= _bTrue;
			_dtpREGDATE_E_S.Enabled		= _bTrue;
			_txtTITLE_S.ReadOnly		= !_bTrue;
			_cmbGUBUN_S.Enabled			= _bTrue;
			_btnSearch.Enabled			= _bTrue;
			_btnAdd.Enabled				= _bTrue;
			_btnExcel.Enabled			= _bTrue;
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
				int res = Search();
				string message = string.Format("{0:N0}건이 검색되었습니다.", res);

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
			int _retValue = -1;

			try
			{
				DataTable _dt = base.GetDataTable("PCSP_HLP0300_R1"
					, _dtpREGDATE_S_S.Value.ToString("yyyy-MM-dd")
					, _dtpREGDATE_E_S.Value.ToString("yyyy-MM-dd")
					, _txtTITLE_S.Text
					, _cmbGUBUN_S.SelectedValue
					);
				gridView1.DataSource = _dt;

				_retValue = _dt.Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
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
				HLP0310 form = new HLP0310();
				form.ShowDialog();

				// 새로운 정보 바인딩
				Search();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion 

		/// <summary>
		/// 엑셀 다운로드 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnExcel_Click(object sender, EventArgs e)
		{

		}

		private void gridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			HLP0310 _form		= new HLP0310();
			_form.IDX			= (int)gridView1.Rows[e.RowIndex].Cells["IDX"].Value;
			DialogResult res	= _form.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				Search();
			}
		}

	}
}
