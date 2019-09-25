﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DemoClient.View.BAS
{
	public partial class BAS0400 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;
		private string _strTOTAL_CODE;

		#region BAS0400 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0400()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0400_Load : 폼 로드
		/// <summary>
		/// 폼 로드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0400_Load(object sender, EventArgs e)
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
			//_txtTOTAL_CODE.Text		= "";
			//_txtMAIN_CODE.Text		= "";
			//_txtSUB_CODE.Text		= "";
			//_txtCODE_NAME.Text		= "";
			//_rbDISPLAYY.Checked		= true;
			//_rbDISPLAYN.Checked		= false;
			//_txtORDERBY.Text		= "";
			//_txtBIGO1.Text			= "";
			//_txtBIGO2.Text			= "";
			//_txtBIGO3.Text			= "";
			//_txtBIGO4.Text			= "";
			//_txtBIGO5.Text			= "";
			//_txtBIGO6.Text			= "";
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtCODE_NAME_S.ReadOnly	= !_bTrue;

			_btnSearch.Enabled			= _bTrue;

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
			//_txtCODE_NAME_S2.ReadOnly	= !_bTrue;
			_txtPRG_NAME_S.ReadOnly		= !_bTrue;

			_btnSearch2.Enabled			= _bTrue;
			_btnSave2.Enabled			= _bTrue;

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
			//_txtCODE_NAME.ReadOnly		= !_bTrue;
			//_rbDISPLAYY.Enabled			= _bTrue;
			//_rbDISPLAYN.Enabled			= _bTrue;
			//_txtORDERBY.ReadOnly		= !_bTrue;
			//_txtBIGO1.ReadOnly			= !_bTrue;
			//_txtBIGO2.ReadOnly			= !_bTrue;
			//_txtBIGO3.ReadOnly			= !_bTrue;
			//_txtBIGO4.ReadOnly			= !_bTrue;
			//_txtBIGO5.ReadOnly			= !_bTrue;
			//_txtBIGO6.ReadOnly			= !_bTrue;

			//_btnAdd02.Enabled			= _bTrue;
			//_btnSave.Enabled			= _bTrue;
			//_btnDel.Enabled				= _bTrue;
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
			//EnableControls3(false);

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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0400_R1"
					, _txtCODE_NAME_S.Text
					//, _txtCODE_NAME_S.Text
					);
				gridView1.DataSource	= _dt;

				// 오른쪽 그리드 초기화
				DataTable _dt2			= base.GetDataTable("PCSP_BAS0400_R2"
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

		#region collapsibleSplitter2_DoubleClick : 스플릿바 더블 클릭 이벤트
		/// <summary>
		/// 스플릿바 더블 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void collapsibleSplitter2_DoubleClick(object sender, EventArgs e)
		{
			panel1.Width = 328;
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
					_txtCODE_NAME_S2.Text	= gridView1.Rows[e.RowIndex].Cells["CODE_NAME"].Value.ToString();
					_strTOTAL_CODE			= gridView1.Rows[e.RowIndex].Cells["TOTAL_CODE"].Value.ToString();

					Search2();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnSearch2_Click : 상세그리드 검색 버튼 클릭 이벤트
		/// <summary>
		/// 상세그리드 검색 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSearch2_Click(object sender, EventArgs e)
		{
			try
			{
				Search2();
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region Search2 : 상세 검색
		/// <summary>
		/// 상세 검색
		/// </summary>
		private void Search2()
		{
			try
			{
				DataTable _dt = base.GetDataTable("PCSP_BAS0400_R2"
					, _strTOTAL_CODE
					, _txtPRG_NAME_S.Text
					);
				gridView2.DataSource = _dt;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnSave2_Click : 저장 버튼 클릭 이벤트
		/// <summary>
		/// 저장 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave2_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < gridView2.Rows.Count; i++)
				{
					string _strPRG_ID = gridView2.Rows[i].Cells["PRG_ID"].Value.ToString().Trim(); // 프로그램ID

					for (int j = 2; j < gridView2.Columns.Count; j++)
					{
						if (gridView2.Columns[j].GetType().ToString() == "System.Windows.Forms.DataGridViewCheckBoxColumn")
						{
							base.ExecuteNonQuery(
								"PCSP_BAS0400_U1"
								, _strPRG_ID									// 프로그램ID
								, _strTOTAL_CODE								// 사용자그룹코드
								, gridView2.Columns[j].HeaderText				// 유저 버튼 명
								, gridView2.Rows[i].Cells[j].Value.ToString()	// 버튼 사용 유무
								, string.Empty									// 비고
								, base.GetCookie("USRID")						// 시스템수정자ID
								, base.GetCookie("USRNM")						// 시스템수정자명
								);
						}
					}
				}

				MessageBox.Show("수정하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
