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
	/// 제  목: 공휴일관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-25 12:47
	/// 설  명: 공휴일을 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0600 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region BAS0600 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0600()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0600_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0600_Load(object sender, EventArgs e)
		{
			DataTable _dt	= new DataTable();
			_dt.Columns.Add("CODE_NAME", typeof(string));
			_dt.Columns.Add("TOTAL_CODE", typeof(int));

			for (int i = -5; i < 5; i++)
			{
				DataRow _dr			= _dt.NewRow();
				_dr["CODE_NAME"]	= string.Format("{0}년", DateTime.Now.AddYears(i).Year);
				_dr["TOTAL_CODE"]	= DateTime.Now.AddYears(i).Year;
				_dt.Rows.Add(_dr);
			}

			_cmbYear_S.DisplayMember	= "CODE_NAME";
			_cmbYear_S.ValueMember	= "TOTAL_CODE";
			_cmbYear_S.DataSource		= _dt;
			_cmbYear_S.SelectedValue	= DateTime.Now.Year;
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
			_dtpWKDAY.Value		= System.DateTime.Now;
			_dtpWKDAY.Checked	= false;
			_txtWKMEMO.Text		= "";
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_cmbYear_S.Enabled		= _bTrue;
			_btnSearch.Enabled		= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			_dtpWKDAY.Enabled		= _bTrue;
			_txtWKMEMO.ReadOnly		= !_bTrue;
			_btnSave.Enabled		= _bTrue;
			_btnDel.Enabled			= _bTrue;
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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0600_R1"
					, _cmbYear_S.SelectedValue
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

		#region _btnAdd_Click : 추가 버튼 클릭 이벤트
		/// <summary>
		/// 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd_Click(object sender, EventArgs e)
		{
			BAS0610 _form	= new BAS0610();
			_form.ShowDialog();
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
				base.ExecuteNonQuery("PCSP_BAS0600_U1"
					, _lblPRE_WKDAY.Text
					, base.GetDate(_dtpWKDAY)
					, _txtWKMEMO.Text
					, ""						// 비고
					, base.GetCookie("USRID")	// 시스템등록자ID
					, base.GetCookie("USRNM")	// 시스템등록자명
					);

				MessageBox.Show("공휴일정보를 수정 하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnDel_Click : 삭제 버튼 클릭 이벤트
		/// <summary>
		/// 삭제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0600_D1"
					, base.GetDate(_dtpWKDAY)
					);

				MessageBox.Show("공휴일정보를 삭제 하였습니다.");
				Search();
				ClearControls();
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
			groupBox2.Width		= 549;
		}
		#endregion

		#region gridView1_CellClick : 그리드 클릭 시, 상세정보 바인딩
		/// <summary>
		/// 그리드 클릭 시, 상세정보 바인딩
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

					_lblPRE_WKDAY.Text	= gridView1.Rows[e.RowIndex].Cells["WKDAY"].Value.ToString();
					_dtpWKDAY.Value		= Convert.ToDateTime(gridView1.Rows[e.RowIndex].Cells["WKDAY"].Value.ToString());
					_txtWKMEMO.Text		= string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["WKMEMO"].Value);
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
