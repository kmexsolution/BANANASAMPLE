using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient.View.WDR
{
	/// <summary>
	/// 제  목: 거래원장조회
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-10 12:29
	/// 설  명: 파워밴에서 스크래핑한 승인내역 정보를 조회한다.
	/// </summary>
	public partial class WDR0700 : Controllers.BaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region WDR0100 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public WDR0700()
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
				// VAN 바인딩
				DataTable _dt	= base.GetDataTable("PCSP_WDR0700_R2");
				base.SetListItem(_cmbVAN_CD, _dt, "VAN_CD", "VAN_NM", true);

				//// 승인요청상태
				//_dt	= Model.PowerVan.GetSuccessReqEnum();
				//base.SetListItem(_cmbSUCCESSREQENUM, _dt, "KEY", "VAL", true);

				//// 승인결과상태
				//_dt = Model.PowerVan.GetSuccessResEnum();
				//base.SetListItem(_cmbSUCCESSRESENUM, _dt, "KEY", "VAL", true);

				//// 카드구분
				//_dt = Model.PowerVan.GetCreditEnum();
				//base.SetListItem(_cmbCREDITENUM, _dt, "KEY", "VAL", true);

				//// 발급사구분
				//_dt = Model.PowerVan.GetIssuedbyEnum();
				//base.SetListItem(_cmbISSUEDBYENUM, _dt, "KEY", "VAL", true);

				//// 매입사구분
				//_dt = Model.PowerVan.GetBuyingEnum();
				//base.SetListItem(_cmbBUYINGENUM, _dt, "KEY", "VAL", true);

				// 날짜 설정
				_dtpTRADEDATE1.Value	= System.DateTime.Now.AddDays(0 - Convert.ToInt32(string.IsNullOrEmpty(base.GetCookie("SRCHDUR03")) ? "1" : base.GetCookie("SRCHDUR03"))).Date;
				_dtpTRADEDATE2.Value	= System.DateTime.Now.Date.AddDays(1).AddTicks(-1);
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region WDR0100_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0100_Shown(object sender, EventArgs e)
		{
			_txtAFF_NM.Focus();
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
			EnableControls(false);

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
				DataTable _dt			= base.GetDataTable("PCSP_WDR0700_R1"
					, base.GetCookie("COMPANY_CD")
					, _cmbVAN_CD.SelectedValue.ToString()
					, _txtAFF_NM.Text
					, _txtUSER_ID.Text
					, _cmbSUCCESSREQENUM.SelectedValue.ToString()
					, _cmbSUCCESSRESENUM.SelectedValue.ToString()
					, _cmbCREDITENUM.SelectedValue.ToString()
					, string.Format("{0}", _dtpTRADEDATE1.Value.ToString("yyyy-MM-dd HH:mm:ss"))
					, string.Format("{0}", _dtpTRADEDATE2.Value.ToString("yyyy-MM-dd HH:mm:ss"))
					, _txtAPPRNO.Text
					, _cmbISSUEDBYENUM.SelectedValue.ToString()
					, _cmbBUYINGENUM.SelectedValue.ToString()
					, _txtAPPRAMT1.Text.Trim() == "" ? "-100000000" : _txtAPPRAMT1.Text.Trim()
					, _txtAPPRAMT2.Text.Trim() == "" ? "100000000" : _txtAPPRAMT2.Text.Trim()
					, _txtUSERMEMO.Text
					);
				gridView1.DataSource	= _dt;

				base.MainForm.UpdateStatus(string.Format("{0:N0}건을 검색 하였습니다.", _dt.Rows.Count));

				// 합계 데이터
				_txtSum01.Text = string.Format("{0:0,0}원", _dt.Rows.Cast<DataRow>().AsEnumerable().Sum(x => x["SUCCESSRESENUM"].ToString().Trim() == "승인" ? Int64.Parse(x["APPRAMT"].ToString().Trim()) : 0));
				_txtSum02.Text = string.Format("{0:0,0}건", _dt.Rows.Cast<DataRow>().AsEnumerable().Count(x => x["SUCCESSRESENUM"].ToString().Trim() == "승인"));
				_txtSum03.Text = string.Format("{0:0,0}원", _dt.Rows.Cast<DataRow>().AsEnumerable().Sum(x => x["SUCCESSRESENUM"].ToString().Trim() == "취소" ? Int64.Parse(x["APPRAMT"].ToString().Trim()) : 0));
				_txtSum04.Text = string.Format("{0:0,0}건", _dt.Rows.Cast<DataRow>().AsEnumerable().Count(x => x["SUCCESSRESENUM"].ToString().Trim() == "취소"));
				_txtSum05.Text = string.Format("{0:0,0}원"
					, _dt.Rows.Cast<DataRow>().AsEnumerable().Sum(x => x["SUCCESSRESENUM"].ToString().Trim() == "승인" ? Int64.Parse(x["APPRAMT"].ToString().Trim()) : 0)
						+ _dt.Rows.Cast<DataRow>().AsEnumerable().Sum(x => x["SUCCESSRESENUM"].ToString().Trim() == "취소" ? Int64.Parse(x["APPRAMT"].ToString().Trim()) : 0)
					);
				_txtSum06.Text = string.Format("{0:0,0}건"
					, _dt.Rows.Cast<DataRow>().AsEnumerable().Count(x => x["SUCCESSRESENUM"].ToString().Trim() == "승인")
						- _dt.Rows.Cast<DataRow>().AsEnumerable().Count(x => x["SUCCESSRESENUM"].ToString().Trim() == "취소")
					);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				// 컨트롤 활성화
				EnableControls(true);
				// 스톱와치 중지
				base.MainForm.StopStopWatch();
				// 커서 복원
				base.RestoreCursor();
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
				
				// 날짜
				_dic.Add("G", "yyyy-MM-dd HH:mm:ss");	// 거래일자
				_dic.Add("Q", "yyyy-MM-dd HH:mm:ss");	// 승인취소일/원거래일
				_dic.Add("R", "yyyy-MM-dd HH:mm:ss");	// 청구일자
				_dic.Add("S", "yyyy-MM-dd HH:mm:ss");	// 입금예정일/입금일
				_dic.Add("AK", "yyyy-MM-dd HH:mm:ss");	// 최초등록시각
				_dic.Add("AM", "yyyy-MM-dd HH:mm:ss");	// 최종수정시각

				// 숫자
				_dic.Add("Z", "#,###");					// 승인금액①
				_dic.Add("AA", "#,###");				// 할부
				_dic.Add("AB", "#,###");				// 봉사료
				_dic.Add("AC", "#,###");				// 부가세
				_dic.Add("AD", "#,###.##");				// 매입카드수수료②
				_dic.Add("AE", "#,###.##");				// 입금예정금액(① - ②)

				// 문자
				_dic.Add("F", "@");						// 아이디
				_dic.Add("N", "@");						// 카드종류(원)
				_dic.Add("I", "@");						// 승인요청상태(원)
				_dic.Add("K", "@");						// 승인결과상태(원)
				_dic.Add("P", "@");						// 승인방법(원)
				_dic.Add("T", "@");						// 승인번호
				_dic.Add("V", "@");						// 발급사(원)
				_dic.Add("X", "@");						// 매입사(원)
				_dic.Add("AG", "@");					// 단말기번호
				_dic.Add("AH", "@");					// 가맹점번호
				_dic.Add("AI", "@");					// 사업자등록번호
				_dic.Add("AQ", "@");					// 비고1
				_dic.Add("AR", "@");					// 비고2
				_dic.Add("AS", "@");					// 비고3
				gridView1.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _txtAFF_NM_KeyDown : 엔터키 입력 시, 이벤트
		/// <summary>
		/// 엔터키 입력 시, 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtAFF_NM_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnSearch.PerformClick();
			}
		}
		#endregion

		#region EnableControls : 컨트롤 활성화/비활성화
		/// <summary>
		/// 컨트롤 활성화/비활성화
		/// </summary>
		/// <param name="_bTrue">활성화/비활성화 여부</param>
		void EnableControls(bool _bTrue)
		{
			_cmbVAN_CD.Enabled			= _bTrue;
			_txtAFF_NM.Enabled			= _bTrue;
			_txtUSER_ID.Enabled			= _bTrue;
			_cmbSUCCESSREQENUM.Enabled	= _bTrue;
			_cmbSUCCESSRESENUM.Enabled	= _bTrue;
			_cmbCREDITENUM.Enabled		= _bTrue;
			_dtpTRADEDATE1.Enabled		= _bTrue;
			_dtpTRADEDATE2.Enabled		= _bTrue;
			_txtAPPRNO.Enabled			= _bTrue;
			_cmbISSUEDBYENUM.Enabled	= _bTrue;
			_cmbBUYINGENUM.Enabled		= _bTrue;
			_txtAPPRAMT1.Enabled		= _bTrue;
			_txtAPPRAMT2.Enabled		= _bTrue;
			_txtUSERMEMO.Enabled		= _bTrue;
			_btnSearch.Enabled			= _bTrue;
			_btnExcel.Enabled			= _bTrue;
		}
		#endregion

		#region gridView1_DataBindingComplete : 폰트 색깔 변경하기
		/// <summary>
		/// 폰트 색깔 변경하기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow row in gridView1.Rows)
			{
				try
				{
					// 승인요청이 승인 이외의 자료
					if (!row.Cells["SUCCESSREQENUM"].Value.ToString().Trim().Equals("승인"))
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							cell.Style.ForeColor	= Color.Red;
						}
					}
					// 승인요청결과가 승인요청과 다른 경우
					else if (row.Cells["SUCCESSREQENUM"].Value.ToString().Trim() != row.Cells["SUCCESSRESENUM"].Value.ToString().Trim())
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							cell.Style.ForeColor	= Color.Red;
						}
					}
					// 유류전용 카드
					else if (Convert.ToBoolean(row.Cells["ISOILONLY"].Value.ToString().Trim()))
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							cell.Style.ForeColor	= Color.Gray;
						}
					}
				}
				catch
				{
				}
			}
		}
		#endregion

	}
}
