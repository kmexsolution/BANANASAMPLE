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
	/// 제  목: 공통코드관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-18 06:00
	/// 설  명: 공통코드를 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0500 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region BAS0500 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0500()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0500_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0500_Load(object sender, EventArgs e)
		{
			try
			{
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
			_txtTOTAL_CODE.Text		= "";
			_txtMAIN_CODE.Text		= "";
			_txtSUB_CODE.Text		= "";
			_txtCODE_NAME.Text		= "";
			_rbDISPLAYY.Checked		= true;
			_rbDISPLAYN.Checked		= false;
			_txtORDERBY.Text		= "";
			_txtBIGO1.Text			= "";
			_txtBIGO2.Text			= "";
			_txtBIGO3.Text			= "";
			_txtBIGO4.Text			= "";
			_txtBIGO5.Text			= "";
			_txtBIGO6.Text			= "";
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtMAIN_CODE_S.ReadOnly	= !_bTrue;
			_txtCODE_NAME_S.ReadOnly	= !_bTrue;

			_btnSearch.Enabled			= _bTrue;

            gridView01.Enabled			= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			_txtTOTAL_CODE_S.ReadOnly	= !_bTrue;
			_txtCODE_NAME_S2.ReadOnly	= !_bTrue;

			_btnSearch2.Enabled			= _bTrue;
			_btnAdd02.Enabled			= _bTrue;

			gridView2.Enabled			= _bTrue;
		}
		#endregion

		#region EnableControls3 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		void EnableControls3(bool _bTrue)
		{
			//_txtTOTAL_CODE.ReadOnly		= !_bTrue;
			//_txtMAIN_CODE.ReadOnly		= !_bTrue;
			//_txtSUB_CODE.ReadOnly		= !_bTrue;
			_txtCODE_NAME.ReadOnly		= !_bTrue;
			_rbDISPLAYY.Enabled			= _bTrue;
			_rbDISPLAYN.Enabled			= _bTrue;
			_txtORDERBY.ReadOnly		= !_bTrue;
			_txtBIGO1.ReadOnly			= !_bTrue;
			_txtBIGO2.ReadOnly			= !_bTrue;
			_txtBIGO3.ReadOnly			= !_bTrue;
			_txtBIGO4.ReadOnly			= !_bTrue;
			_txtBIGO5.ReadOnly			= !_bTrue;
			_txtBIGO6.ReadOnly			= !_bTrue;

			_btnAdd02.Enabled			= _bTrue;
			_btnSave.Enabled			= _bTrue;
			_btnDel.Enabled				= _bTrue;
		}
		#endregion

		#region _btnSearch_Click : (왼쪽)검색 버튼 클릭 이벤트
		/// <summary>
		/// (왼쪽)검색 버튼 클릭 이벤트
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
			EnableControls3(false);

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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0500_R1"
					, _txtMAIN_CODE_S.Text
					, _txtCODE_NAME_S.Text
					);

                if (gridView01.InvokeRequired)
                {
                    gridView01.Invoke(new Action(() => gridView01.DataSource = _dt));
                }
                else
                {
                    gridView01.DataSource = _dt;
                }

                // 오른쪽 그리드 초기화
                DataTable _dt2			= base.GetDataTable("PCSP_BAS0500_R2"
					, "$"
					, "$"
					, "$"
					);
				gridView2.DataSource	= _dt2;

				_retValue				= _dt.Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion

		#region collapsibleSplitter2_DoubleClick : (왼쪽)스플릿바 더블 클릭 이벤트
		/// <summary>
		/// (왼쪽)스플릿바 더블 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void collapsibleSplitter2_DoubleClick(object sender, EventArgs e)
		{
			panel1.Width	= 328;
		}
		#endregion

		#region gridView1_CellClick : (왼쪽)그리드 클릭 시, 상세 목록 바인딩
		/// <summary>
		/// (왼쪽)그리드 클릭 시, 상세 목록 바인딩
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex > -1)
				{
					EnableControls2(true);

					// 시스템사용여부 판단
					if (Convert.ToBoolean(gridView01.Rows[e.RowIndex].Cells["SYSTEMYN"].Value.ToString()))
					{
						삭제ToolStripMenuItem.Enabled	= false;
					}
					else
					{
						삭제ToolStripMenuItem.Enabled	= true;
					}

					DataTable _dt			= base.GetDataTable("PCSP_BAS0500_R2"
						, gridView01.Rows[e.RowIndex].Cells["MAIN_CODE"].Value
						, _txtTOTAL_CODE_S.Text
						, _txtCODE_NAME_S2.Text
						);
					gridView2.DataSource	= _dt;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView1_CellMouseDown : (왼쪽)그리드 우측 마우스 버튼 클릭 시, 스트립 메뉴 처리
		/// <summary>
		/// (왼쪽)그리드 우측 마우스 버튼 클릭 시, 스트립 메뉴 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			// 시스템사용여부 판단
			if (Convert.ToBoolean(gridView01.Rows[e.RowIndex].Cells["SYSTEMYN"].Value.ToString()))
			{
				삭제ToolStripMenuItem.Enabled	= false;
			}
			else
			{
				삭제ToolStripMenuItem.Enabled	= true;
			}
		}
		#endregion

		#region collapsibleSplitter1_DoubleClick : (오른쪽)스플릿바 더블 클릭 이벤트
		/// <summary>
		/// (오른쪽)스플릿바 더블 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void collapsibleSplitter1_DoubleClick(object sender, EventArgs e)
		{
			groupBox4.Width		= 468;
		}
		#endregion

		#region gridView2_CellClick : (오른쪽)그리드 클릭 시, 상세정보 바인딩
		/// <summary>
		/// (오른쪽)그리드 클릭 시, 상세정보 바인딩
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex > -1)
				{
					EnableControls3(true);

					DataTable _dt			= base.GetDataTable("PCSP_BAS0500_R3"
						, gridView2.Rows[e.RowIndex].Cells["TOTAL_CODE"].Value
						);
					_txtTOTAL_CODE.Text		= _dt.Rows[0]["TOTAL_CODE"].ToString();
					_txtMAIN_CODE.Text		= _dt.Rows[0]["MAIN_CODE"].ToString();
					_txtSUB_CODE.Text		= _dt.Rows[0]["SUB_CODE"].ToString();
					_txtCODE_NAME.Text		= _dt.Rows[0]["CODE_NAME"].ToString();
					_rbDISPLAYY.Checked		= Convert.ToBoolean(_dt.Rows[0]["DISPLAYYN"].ToString()) ? true : false;
					_rbDISPLAYN.Checked		= Convert.ToBoolean(_dt.Rows[0]["DISPLAYYN"].ToString()) ? false : true;
					_txtORDERBY.Text		= _dt.Rows[0]["ORDERBY"].ToString();
					_txtBIGO1.Text			= _dt.Rows[0]["BIGO1"].ToString();
					_txtBIGO2.Text			= _dt.Rows[0]["BIGO2"].ToString();
					_txtBIGO3.Text			= _dt.Rows[0]["BIGO3"].ToString();
					_txtBIGO4.Text			= _dt.Rows[0]["BIGO4"].ToString();
					_txtBIGO5.Text			= _dt.Rows[0]["BIGO5"].ToString();
					_txtBIGO6.Text			= _dt.Rows[0]["BIGO6"].ToString();

					if (Convert.ToBoolean(_dt.Rows[0]["SYSTEMYN"].ToString()))
					{
						_btnSave.Enabled	= false;
						_btnDel.Enabled		= false;
						_lblInfo.Visible	= true;
					}
					else
					{
						_lblInfo.Visible	= false;
					}
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnSearch2_Click : (오른쪽)검색 버튼 클릭 이벤트
		/// <summary>
		/// (오른쪽)검색 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSearch2_Click(object sender, EventArgs e)
		{
			// 스톱와치 시작
			base.MainForm.StartStopWatch();
			// 커서 기다림
			base.SetWaitCursor();
			// 컨트롤 비활성화
			EnableControls1(false);
			EnableControls2(false);
			EnableControls3(false);

			// 컨트롤 초기화
			ClearControls();

			_thread = new Thread(new ThreadStart(SearchThread2));
			_thread.Start();
		}

		/// <summary>
		/// 검색 쓰레드
		/// </summary>
		void SearchThread2()
		{
			try
			{
				int res			= Search2();
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
				EnableControls2(true);
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
		int Search2()
		{
			int _retValue	= -1;

			try
			{
				DataTable _dt			= base.GetDataTable("PCSP_BAS0500_R2"
					, gridView01.Rows[gridView01.CurrentRow.Index].Cells["MAIN_CODE"].Value
					, _txtTOTAL_CODE_S.Text
					, _txtCODE_NAME_S2.Text
					);
				gridView2.DataSource	= _dt;

				_retValue				= _dt.Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion
		
		#region 검색 버튼 자동으로 클릭
		/// <summary>
		/// (왼쪽)텍스트박스 엔터키 입력 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtMAIN_CODE_S_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnSearch.PerformClick();

				// 비프소리 중지
				e.SuppressKeyPress	= true;
				e.Handled			= true;
			}
		}

		/// <summary>
		/// (오른쪽)텍스트박스 엔터키 입력 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtTOTAL_CODE_S_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnSearch2.PerformClick();

				// 비프소리 중지
				e.SuppressKeyPress	= true;
				e.Handled			= true;
			}
		}
		#endregion

		#region _btnAdd01_Click : 메인코드 추가 버튼 클릭 이벤트
		/// <summary>
		/// 메인코드 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd01_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0510 form = new BAS0510();
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

		#region _btnAdd02_Click : 상세코드 추가 버튼 클릭 이벤트
		/// <summary>
		/// 상세코드 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd02_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0520 form	= new BAS0520();
				form.MAIN_CODE	= string.Format("{0}", gridView01.Rows[gridView01.CurrentRow.Index].Cells["MAIN_CODE"].Value);
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

		#region _btnSave_Click : 저장 버튼 클릭 이벤트
		/// <summary>
		/// 저장 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0500_U1"
					, _txtTOTAL_CODE.Text					// 공통코드
					, _txtCODE_NAME.Text					// 코드명
					, _rbDISPLAYY.Checked ? true : false	// 사용여부
					, _txtORDERBY.Text						// 순서
					, _txtBIGO1.Text						// 비고1
					, _txtBIGO2.Text						// 비고2
					, _txtBIGO3.Text						// 비고3
					, base.GetDecimal(_txtBIGO4)			// 비고4
					, base.GetDecimal(_txtBIGO5)			// 비고5
					, base.GetDecimal(_txtBIGO6)			// 비고6
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				MessageBox.Show("공통코드를 수정하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		/// <summary>
		/// 삭제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0500_D1"
					, _txtTOTAL_CODE.Text					// 공통코드
					);

				_btnSearch2.PerformClick();
				MessageBox.Show("공통코드를 삭제하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		/// <summary>
		/// 메인코드 삭제
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult res	= MessageBox.Show("선택된 공통코드를 삭제하시겠습니까", "공통코드 삭제", MessageBoxButtons.YesNo);
				if (res == System.Windows.Forms.DialogResult.Yes)
				{
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
	}
}
