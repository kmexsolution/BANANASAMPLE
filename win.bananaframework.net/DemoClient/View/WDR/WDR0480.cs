using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DemoClient.View.WDR
{
	public partial class WDR0480 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;
		DataTable _DataTable = null;

		#region WDR0480 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public WDR0480()
		{
			InitializeComponent();
		}
		#endregion

		#region WDR0480_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0480_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpTRADEDATE_S_S.Value		= Convert.ToDateTime(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " 00:00:00");
				_dtpTRADEDATE_E_S.Value		= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");

				#region 검색 일자 구분
				DataTable _dt			= new DataTable();

				_dt.Columns.Add("TOTAL_CODE");
				_dt.Columns.Add("CODE_NAME");

				DataRow _dr				= _dt.NewRow();
				_dr["TOTAL_CODE"]		= "1";
				_dr["CODE_NAME"]		= "취소일자";
				_dt.Rows.Add(_dr);

				_dr						= _dt.NewRow();
				_dr["TOTAL_CODE"]		= "2";
				_dr["CODE_NAME"]		= "취소입금예정일";
				_dt.Rows.Add(_dr);

				base.SetListItem(_cmbDateGubun, _dt, "TOTAL_CODE", "CODE_NAME");
				#endregion

				// 매입카드사
				DataTable _dt01				= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A08", "", "Y", "", "");
				base.SetListItem(_cmbBUYING_CD_S, _dt01, "TOTAL_CODE", "CODE_NAME", true);

				// 카드종류
				DataTable _dt02				= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "V03", "", "", "", "");
				base.SetListItem(_cmbCREDIT_CD_S, _dt02, "TOTAL_CODE", "CODE_NAME", true);

				// 출금승인상태
				DataTable _dt04				= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "S02", "", "", "", "");
				base.SetListItem(_cmbWDRAPPR_CD, _dt04, "TOTAL_CODE", "CODE_NAME", true);

				// VAN사
				DataTable _dt05				= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "V01", "", "", "", "");
				base.SetListItem(_cmbVAN_CD, _dt05, "TOTAL_CODE", "CODE_NAME", true);

				// 강제출금 등록여부
				DataTable _dtC01001_YN		= new DataTable();

				_dtC01001_YN.Columns.Add("TOTAL_CODE");
				_dtC01001_YN.Columns.Add("CODE_NAME");

				DataRow _drC01001_YN		= _dtC01001_YN.NewRow();
				_drC01001_YN["TOTAL_CODE"]	= "Y";
				_drC01001_YN["CODE_NAME"]	= "등록";
				_dtC01001_YN.Rows.Add(_drC01001_YN);

				_drC01001_YN				= _dtC01001_YN.NewRow();
				_drC01001_YN["TOTAL_CODE"]	= "N";
				_drC01001_YN["CODE_NAME"]	= "미등록";
				_dtC01001_YN.Rows.Add(_drC01001_YN);

				base.SetListItem(_cmbC01001_YN, _dtC01001_YN, "TOTAL_CODE", "CODE_NAME", true);
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
			_cmbDateGubun.Enabled		= _bTrue;
			_dtpTRADEDATE_S_S.Enabled	= _bTrue;
			_dtpTRADEDATE_E_S.Enabled	= _bTrue;
			_cmbBUYING_CD_S.Enabled		= _bTrue;
			_cmbCREDIT_CD_S.Enabled		= _bTrue;
			_cmbC01001_YN.Enabled		= _bTrue;
			_cmbVAN_CD.Enabled			= _bTrue;
			_txtAPPRNO.ReadOnly			= !_bTrue;
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
				DataSet _ds			= base.GetDataSet("PCSP_WDR0480_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtSTR_CD_S.Text
					, _cmbWDRAPPR_CD.SelectedValue			// 출금승인상태
					, _cmbDateGubun.SelectedValue
					, _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _cmbBUYING_CD_S.SelectedValue
					, _cmbCREDIT_CD_S.SelectedValue
                    , _cmbVAN_CD.SelectedValue              // VAN사코드
					, _txtAPPRNO.Text						// 승인번호
					, _cmbC01001_YN.SelectedValue			// 강제출금등록여부(Y/N)
                    );

				_DataTable = _ds.Tables[0];
				gridView1.DataSource = _DataTable;

				//// 승인
				//_txtAPPRAMT.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["APPRAMT"].ToString());

				//// 취소
				//_txtCNCLAMT.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["CNCLAMT"].ToString());

				//// 실승인금액
				//_txtAPPRAMT_R.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["APPRAMT_R"].ToString());

				//// 매입카드수수료
				//_txtBUYING_FEE.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["BUYING_FEE"].ToString());

				//// 합계
				//_txtSUB_TOTAL.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["SUB_TOTAL"].ToString());

				//// 대출원금
				//_txtLNAMT.Text			= string.Format("{0}", _ds.Tables[1].Rows[0]["LNAMT"].ToString());

				//// 대출이자
				//_txtLNINTST.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["LNINTST"].ToString());

				//// 정산수수료
				//_txtACCOUNT_FEE.Text	= string.Format("{0}", _ds.Tables[1].Rows[0]["ACCOUNT_FEE"].ToString());

				//// 합계2
				//_txtSUB_TOTAL2.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["SUB_TOTAL2"].ToString());

				_retValue				= _ds.Tables[0].Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion

		private void _btnExcel_Click(object sender, EventArgs e)
		{

		}

		#region _btnCheckAll_Click : 전체체크 버튼 클릭 이벤트
		/// <summary>
		/// 전체체크 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnCheckAll_Click(object sender, EventArgs e)
		{
			_DataTable.Columns.Remove("CHK");
			DataColumn _newColumn = new DataColumn("CHK", typeof(string));
			_newColumn.DefaultValue = "Y";
			_DataTable.Columns.Add(_newColumn);
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
			_DataTable.Columns.Remove("CHK");
			DataColumn _newColumn = new DataColumn("CHK", typeof(string));
			_newColumn.DefaultValue = "N";
			_DataTable.Columns.Add(_newColumn);
		}
		#endregion

		#region _btnApprove_Click : 강제출금 등록 버튼 클릭 이벤트
		/// <summary>
		/// 강제출금 등록 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnApprove_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("강제출금 등록은 강제출금 등록여부가 '미등록'일 경우에만 등록 됩니다.\r\n강제출금 등록을 하시겠습니까?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					base.BeginTransaction();

					var checkedRows = gridView1.Rows.Cast<DataGridViewRow>()
						.Where(row => row.Cells["CHK"].Value.ToString().Trim().Equals("Y"))
						.Select(row => row);

					foreach (DataGridViewRow row in checkedRows)
					{
						try
						{
							base.ExecuteNonQuery(
								"PCSP_WDR0480_C1"
								, row.Cells["STR_CD"].Value.ToString()						// 가맹점번호
								, Convert.ToInt32(row.Cells["IDX"].Value.ToString())
								, Convert.ToInt32(row.Cells["TIDX"].Value.ToString())
								, DateTime.Now.ToString("yyyy-MM-dd")						// 적용시작일
								, "Y"														// 사용여부(Y/N)
								, "C01001"													// 출금/차감구분
								, Math.Abs(Convert.ToInt32(row.Cells["SUB_TOTAL"].Value))	// 출금금액
								, "N"														// 실행여부(Y/N)
								, "C02100"													// 출금/차감사유코드
								, "출금 후 취소"											// 출금/차감상세사유
								, "N"														// 시스템등록여부(Y/N)
								, "원거래일 " + row.Cells["CANCELDATE"].Value.ToString() + " / 취소일 " + row.Cells["TRADEDATE"].Value.ToString() + " / " + row.Cells["BUYING_NM"].Value.ToString()		// 메모
								, ""														// 비고
								, base.GetCookie("USRID")									// 시스템등록자ID
								, base.GetCookie("USRNM")									// 시스템등록자명
								);
							//row.Cells["STATUS"].Value = "승인처리완료";
							//row.Cells["CHK"].Value = "N";
							////row.Cells["CHK"].ReadOnly	= true;
							//row.DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.LightGray };
						}
						catch (Exception err)
						{
							//row.Cells["CHK"].Value = "N";
							//row.Cells["STATUS"].Value = err.Message;
							//row.DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
						}
					}

					base.CommitTransaction();

					MessageBox.Show("강제출금 등록을 완료 하였습니다.");

					Search();
				}
				else
				{
					MessageBox.Show("강제출금 등록을 취소 하였습니다.");
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
