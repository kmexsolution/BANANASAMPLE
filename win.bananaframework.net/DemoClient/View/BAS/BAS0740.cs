using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace DemoClient.View.BAS
{
	public partial class BAS0740 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;
		private string _strAGT_CD;

		#region BAS0740 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0740()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0740_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0740_Load(object sender, EventArgs e)
		{
			try
			{
				// 사업자구분(검색)
				DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "A01"
					, ""
					, ""
					, ""
					, ""
					);

				// 사업자구분(검색)
				base.SetListItem(_cmbBI_BINF_CD_S
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
			//_txtAGT_CD.Text					= "";
			//_txtAGT_NM.Text					= "";
			//_txtPRSNT_NM.Text				= "";
			//_txtZIP_NO.Text					= "";
			//_txtADDR_BSC.Text				= "";
			//_txtADDR_DTL.Text				= "";
			//_txtTELNO.Text					= "";
			//_txtFAXNO.Text					= "";
			//_txtMEMO.Text					= "";
			//_txtBI_COMPANY_NM.Text			= "";
			//_txtBI_PRSNT_NM.Text			= "";
			//_cmbBI_BINF_CD.SelectedIndex	= 0;
			//_txtBI_SAUP_NO.Text				= "";
			//_txtBI_BUBIN_NO.Text			= "";
			//_rbBI_SIMTAX_Y.Checked			= false;
			//_rbBI_SIMTAX_Y.Enabled			= false;
			//_rbBI_SIMTAX_N.Checked			= true;
			//_rbBI_SIMTAX_N.Enabled			= false;
			//_txtBI_ZIP_NO.Text				= "";
			//_txtBI_ADDR_BSC.Text			= "";
			//_txtBI_ADDR_DTL.Text			= "";
			//_txtBI_UPTE.Text				= "";
			//_txtBI_JONGMOK.Text				= "";
			//_txtBI_EMAIL.Text				= "";
			//_txtPI_PRSNT_NM.Text			= "";
			//_txtPI_CNTZ_NO.Text				= "";
			//_txtPI_TELNO.Text				= "";
			//_txtPI_CELLNO.Text				= "";
			//_txtPI_EMAIL.Text				= "";
			//_txtPI_ZIP_NO.Text				= "";
			//_txtPI_ADDR_BSC.Text			= "";
			//_txtPI_ADDR_DTL.Text			= "";
			//_dtpCI_CNTR_STRT_DT.Value		= System.DateTime.Now;
			//_dtpCI_CNTR_STRT_DT.Checked		= false;
			//_dtpCI_CNTR_END_DT.Value		= System.DateTime.Now;
			//_dtpCI_CNTR_END_DT.Checked		= false;
			//_cmbCI_BNK_CD.SelectedIndex		= 0;
			//_txtCI_ACCT_NO.Text				= "";
			//_txtCI_ACCT_NM.Text				= "";
			//_txtMO_LOGIN_ID.Text			= "";
			//_txtMO_LOGIN_PW.Text			= "";
			//_dtpMO_STRT_DT.Value			= System.DateTime.Now;
			//_dtpMO_STRT_DT.Checked			= false;
			//_chkMO_PAUSED.Checked			= false;
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
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			_btnAdd01.Enabled			= _bTrue;
			//_btnSave01.Enabled			= _bTrue;
			//_btnDel01.Enabled			= _bTrue;
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
			groupBox3.Width = 703;
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
				DataTable _dt = base.GetDataTable("PCSP_BAS0700_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtAGT_NM_S.Text
					, _txtAGT_CD_S.Text
					, _txtPRSNT_NM_S.Text
					, _txtADDR_BSC_S.Text
					, _cmbBI_BINF_CD_S.SelectedValue
					, _txtBI_SAUP_NO_S.Text
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

		#region gridView1_CellClick : 대리점 정보 그리드 클릭 이벤트
		/// <summary>
		/// 대리점 정보 그리드 클릭 이벤트
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

					_strAGT_CD = gridView1.Rows[e.RowIndex].Cells["AGT_CD"].Value.ToString();

					SetGridView2();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region SetGridView2 : 정산수수료 그리드에 데이터 바인딩
		/// <summary>
		/// 정산수수료 그리드에 데이터 바인딩
		/// </summary>
		private void SetGridView2()
		{
			DataTable _dt = base.GetDataTable("PCSP_BAS0740_R2"
				, _strAGT_CD
				);

			gridView2.DataSource = _dt;
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
				BAS0741 _form = new BAS0741();
				_form.AGT_CD = _strAGT_CD;
				DialogResult res = _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					SetGridView2();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView2_CellDoubleClick : 정산수수료 그리드 더블클릭 이벤트
		/// <summary>
		/// 정산수수료 그리드 더블클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			BAS0741 _form		= new BAS0741();
			_form.AGT_CD		= _strAGT_CD;
			_form.IDX			= (int)gridView2.Rows[e.RowIndex].Cells["IDX"].Value;
			DialogResult res	= _form.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				SetGridView2();
			}
		}
		#endregion
	}
}
