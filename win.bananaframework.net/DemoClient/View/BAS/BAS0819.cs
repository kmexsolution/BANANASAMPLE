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
	/// 제  목: 가맹점.매입카드이력조회
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-11 21:21
	/// 설  명: 가맹점의 매입카드이력을 조회하는 화면입니다.
	/// </summary>
	public partial class BAS0819 : DemoClient.Controllers.BaseForm
	{
		private Thread _thread;	// 검색 쓰레드

		#region BAS0819 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0819()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0819_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0819_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpBY_APP_DT_S_S.Checked	= false;
				_dtpBY_APP_DT_E_S.Checked	= false;

				// 적용시작일
				_dtpBY_APP_DT_S_S.Value		= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));
				_dtpBY_APP_DT_E_S.Value		= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));

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

		#region BAS0819_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0819_Shown(object sender, EventArgs e)
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
			_dtpBY_APP_DT_S_S.Enabled		= _bTrue;
			_dtpBY_APP_DT_E_S.Enabled		= _bTrue;
			_txtSYSREGNAME_S.ReadOnly		= !_bTrue;
			_dtpSYSMODDATE_E_S.Enabled		= _bTrue;
			_dtpSYSMODDATE_S_S.Enabled		= _bTrue;
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
				DataTable _dt			= base.GetDataTable("PCSP_BAS0819_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_CD_S.Text																			// 가맹점코드
					, _txtSTR_NM_S.Text																			// 가맹점명
					, base.GetDate(_dtpBY_APP_DT_S_S) == "" ? "1900-01-01" : base.GetDate(_dtpBY_APP_DT_S_S)	// 적용일자(시작)
					, base.GetDate(_dtpBY_APP_DT_E_S) == "" ? "2100-12-31" : base.GetDate(_dtpBY_APP_DT_E_S)	// 적용일자(종료)
					, _txtSYSREGNAME_S.Text																		// 처리자
					, _dtpSYSMODDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")									// 처리기간(시작)
					, _dtpSYSMODDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")									// 처리기간(종료)
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
				_dic.Add("E", "yyyy-MM-dd");
				_dic.Add("AZ", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("BB", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("BD", "yyyy-MM-dd HH:mm:ss");
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
