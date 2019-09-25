using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.WDR
{
	/// <summary>
	/// 제  목: 출금승인관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-27 18:38
	/// 설  명: 출금승인/반려를 처리하는 화면입니다.
	/// </summary>
	public partial class WDR0500 : Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;
		DataTable _DataTable = null;

		#region WDR0500 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public WDR0500()
		{
			InitializeComponent();
		}
		#endregion

		#region WDR0500_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WDR0500_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpTRADEDATE_S_S.Value			= Convert.ToDateTime(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " 00:00:00");
				_dtpTRADEDATE_E_S.Value			= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");

				#region 검색 일자 구분
				DataTable _dt					= new DataTable();
				_dt.Columns.Add("TOTAL_CODE");
				_dt.Columns.Add("CODE_NAME");

				DataRow _dr						= _dt.NewRow();
				_dr["TOTAL_CODE"]				= "1";
				_dr["CODE_NAME"]				= "거래일자";
				_dt.Rows.Add(_dr);

				_dr								= _dt.NewRow();
				_dr["TOTAL_CODE"]				= "2";
				_dr["CODE_NAME"]				= "입금예정일자";
				_dt.Rows.Add(_dr);

				base.SetListItem(_cmbDateGubun, _dt, "TOTAL_CODE", "CODE_NAME");
				#endregion

				// 매입카드사
				DataTable _dt01					= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A08", "", "Y", "", "");
				base.SetListItem(_cmbBUYING_CD_S, _dt01, "TOTAL_CODE", "CODE_NAME", true);

				// 카드종류
				DataTable _dt02					= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "V03", "", "", "", "");
				base.SetListItem(_cmbCREDIT_CD_S, _dt02, "TOTAL_CODE", "CODE_NAME", true);

				// 출금승인상태
				DataTable _dt04					= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "S02", "", "", "", "");
				base.SetListItem(_cmbWDRAPPR_CD, _dt04, "TOTAL_CODE", "CODE_NAME", true);

				// 출금처리상태
				DataTable _dtCOMPLETE_YN		= new DataTable();

				_dtCOMPLETE_YN.Columns.Add("TOTAL_CODE");
				_dtCOMPLETE_YN.Columns.Add("CODE_NAME");

				DataRow _drCOMPLETE_YN			= _dtCOMPLETE_YN.NewRow();
				_drCOMPLETE_YN["TOTAL_CODE"]	= "Y";
				_drCOMPLETE_YN["CODE_NAME"]		= "출금완료";
				_dtCOMPLETE_YN.Rows.Add(_drCOMPLETE_YN);

				_drCOMPLETE_YN					= _dtCOMPLETE_YN.NewRow();
				_drCOMPLETE_YN["TOTAL_CODE"]	= "P";
				_drCOMPLETE_YN["CODE_NAME"]		= "정산완료 출금대기";
				_dtCOMPLETE_YN.Rows.Add(_drCOMPLETE_YN);

				_drCOMPLETE_YN					= _dtCOMPLETE_YN.NewRow();
				_drCOMPLETE_YN["TOTAL_CODE"]	= "N";
				_drCOMPLETE_YN["CODE_NAME"]		= "출금대기";
				_dtCOMPLETE_YN.Rows.Add(_drCOMPLETE_YN);

				base.SetListItem(_cmbCOMPLETE_YN, _dtCOMPLETE_YN, "TOTAL_CODE", "CODE_NAME", true);

                // 출금승인상태
                DataTable _dt05					= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "V01", "", "", "", "");
                base.SetListItem(_cmbVAN_CD, _dt05, "TOTAL_CODE", "CODE_NAME", true);

				// 출금 후 취소 여부
				DataTable _dtAFTER_CANCEL = new DataTable();

				_dtAFTER_CANCEL.Columns.Add("TOTAL_CODE");
				_dtAFTER_CANCEL.Columns.Add("CODE_NAME");

				DataRow _drAFTER_CANCEL			= _dtAFTER_CANCEL.NewRow();
				_drAFTER_CANCEL["TOTAL_CODE"]	= "Y";
				_drAFTER_CANCEL["CODE_NAME"]	= "출금 후 취소";
				_dtAFTER_CANCEL.Rows.Add(_drAFTER_CANCEL);

				_drAFTER_CANCEL					= _dtAFTER_CANCEL.NewRow();
				_drAFTER_CANCEL["TOTAL_CODE"]	= "N";
				_drAFTER_CANCEL["CODE_NAME"]	= "일반";
				_dtAFTER_CANCEL.Rows.Add(_drAFTER_CANCEL);

				base.SetListItem(_cmbAFTER_CANCEL_S, _dtAFTER_CANCEL, "TOTAL_CODE", "CODE_NAME", true);
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
			_txtAPPRAMT_S_S.ReadOnly	= !_bTrue;
			_txtAPPRAMT_E_S.ReadOnly	= !_bTrue;
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
				
				//_btnApprove.Enabled		= false;
				//_btnDeny.Enabled		= false;
				//_btnComplete.Enabled	= false;

				//if (_cmbWDRAPPR_CD.SelectedValue.ToString() == "S02001")
				//{
				//	_btnApprove.Enabled = true;
				//	_btnDeny.Enabled = true;
				//}

				//if (_cmbWDRAPPR_CD.SelectedValue.ToString() == "S02002")
				//{
				//	if (_cmbCOMPLETE_YN.SelectedValue.ToString() == "P")
				//	{
				//		_btnComplete.Enabled = true;
				//	}
				//	else if (_cmbCOMPLETE_YN.SelectedValue.ToString() == "N")
				//	{
				//		_btnDeny.Enabled = true;
				//	}
				//}

				//if (_cmbWDRAPPR_CD.SelectedValue.ToString() == "S02003")
				//{
				//	if (_cmbCOMPLETE_YN.SelectedValue.ToString() == "N")
				//	{
				//		_btnApprove.Enabled = true;
				//	}
				//}
				
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
				int amt_strt	= _txtAPPRAMT_S_S.Text == "" ? -1000000000 : Convert.ToInt32(_txtAPPRAMT_S_S.Text);
				int amt_end		= _txtAPPRAMT_E_S.Text == "" ? 1000000000 : Convert.ToInt32(_txtAPPRAMT_E_S.Text);
				
				DataSet _ds			= base.GetDataSet("PCSP_WDR0500_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtSTR_CD_S.Text
					, _cmbDateGubun.SelectedValue
					, _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _cmbBUYING_CD_S.SelectedValue
					, _cmbCREDIT_CD_S.SelectedValue
					, amt_strt
					, amt_end
					, _cmbWDRAPPR_CD.SelectedValue			// 출금승인상태
					, _cmbCOMPLETE_YN.SelectedValue			// 출금처리상태
                    , _cmbVAN_CD.SelectedValue              // VAN사코드
					, _txtAPPRNO.Text						// 승인번호
					, _cmbAFTER_CANCEL_S.SelectedValue		// 출금 후 취소여부
                    );

				_DataTable = _ds.Tables[0];
				gridView1.DataSource = _DataTable;

				// 승인
				_txtAPPRAMT.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["APPRAMT"].ToString());

				// 취소
				_txtCNCLAMT.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["CNCLAMT"].ToString());

				// 실승인금액
				_txtAPPRAMT_R.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["APPRAMT_R"].ToString());

				// 매입카드수수료
				_txtBUYING_FEE.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["BUYING_FEE"].ToString());

				// 합계
				_txtSUB_TOTAL.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["SUB_TOTAL"].ToString());

				// 대출원금
				_txtLNAMT.Text			= string.Format("{0}", _ds.Tables[1].Rows[0]["LNAMT"].ToString());

				// 대출이자
				_txtLNINTST.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["LNINTST"].ToString());

				// 정산수수료
				_txtACCOUNT_FEE.Text	= string.Format("{0}", _ds.Tables[1].Rows[0]["ACCOUNT_FEE"].ToString());

				// 합계2
				_txtSUB_TOTAL2.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["SUB_TOTAL2"].ToString());

				_retValue				= _ds.Tables[0].Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion

		#region gridView1_DataBindingComplete : 선택불가 Row에 대한 처리
		/// <summary>
		/// 선택불가 Row에 대한 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			// 취소
			var cnclRows1 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["SUCCESSRES_CD"].Value.ToString().Trim().Equals("V02002"))
				.Select(row => row);
			foreach (DataGridViewRow row in cnclRows1)
			{
				row.DefaultCellStyle = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 승인완료
			var apprRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRAPPR_CD"].Value.ToString().Trim().Equals("S02002"))
				.Select(row => row);
			foreach (DataGridViewRow row in apprRows)
			{
				row.Cells["WDRAPPR_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Blue };
			}

			// 승인반려
			var cnclRows = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["WDRAPPR_CD"].Value.ToString().Trim().Equals("S02003"))
				.Select(row => row);
			foreach (DataGridViewRow row in cnclRows)
			{
				row.Cells["WDRAPPR_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 출금완료
			var comRows1 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["COMPLETE_YN"].Value.ToString().Trim().Equals("Y"))
				.Select(row => row);
			foreach (DataGridViewRow row in comRows1)
			{
				row.Cells["COMPLETE_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Blue };
			}

			// 정산완료 출금대기
			var comRows2 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["COMPLETE_YN"].Value.ToString().Trim().Equals("P"))
				.Select(row => row);
			foreach (DataGridViewRow row in comRows2)
			{
				row.Cells["COMPLETE_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
			}

			// 출금대기
			var comRows3 = gridView1.Rows.Cast<DataGridViewRow>()
				.Where(row => row.Cells["COMPLETE_YN"].Value.ToString().Trim().Equals("N"))
				.Select(row => row);
			foreach (DataGridViewRow row in comRows3)
			{
				row.Cells["COMPLETE_NM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Black };
			}
		}
		#endregion

		#region _btnCheckAll_Click : 전체체크 버튼 클릭 이벤트
		/// <summary>
		/// 전체체크 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnCheckAll_Click(object sender, EventArgs e)
		{
			//for (int i = 0; i < _DataTable.Rows.Count; i++)
			//{
			//	_DataTable.Rows[i]["CHK"] = "Y";
				//_DataTable.Rows[i]["CHK"] = "true";
			//}

			// [jmson]
			_DataTable.Columns.Remove("CHK");
			DataColumn _newColumn		= new DataColumn("CHK", typeof(string));
			_newColumn.DefaultValue		= "Y";
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
			//for (int i = 0; i < _DataTable.Rows.Count; i++)
			//{
			//	_DataTable.Rows[i]["CHK"] = "N";
				//_DataTable.Rows[i]["CHK"] = "true";
			//}
			// [jmson]
			_DataTable.Columns.Remove("CHK");
			DataColumn _newColumn		= new DataColumn("CHK", typeof(string));
			_newColumn.DefaultValue		= "N";
			_DataTable.Columns.Add(_newColumn);
		}
		#endregion

		#region _btnApprove_Click : 승인처리 버튼 클릭 이벤트
		/// <summary>
		/// 승인처리 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnApprove_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show("승인처리는 출금완료 여부가 '출금대기'일 경우에만 변경 됩니다.");

				WDR0510 _form		= new WDR0510();
				_form.Reason		= "승인처리";
				DialogResult res	= _form.ShowDialog();

				
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					// 스톱와치 시작
					base.MainForm.StartStopWatch();
					// 커서 기다림
					base.SetWaitCursor();

					string reason		= _form.Reason;
					base.MainForm.StartStopWatch();

					base.BeginTransaction();
				
					var checkedRows	= gridView1.Rows.Cast<DataGridViewRow>()
						.Where(row => row.Cells["CHK"].Value.ToString().Trim().Equals("Y"))
						.Select(row => row);

					string _strP = "PCSP_WDR0500_U1";

					foreach (DataGridViewRow row in checkedRows)
					{
						try
						{
							//string[] tmp	= row.Cells["TRADEDATE"].Value.ToString().Split(' ');

							base.ExecuteNonQuery(_strP
								, Convert.ToInt32(row.Cells["IDX"].Value.ToString())
								, row.Cells["WDRAPPR_CD"].Value.ToString()
								, "S02002"
								, reason
								, ""							// 비고
								, base.GetCookie("USRID")		// 시스템수정자ID
								, base.GetCookie("USRNM")		// 시스템수정자명
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
					// 스톱와치 중지
					base.MainForm.StopStopWatch();
					// 커서 복원
					base.RestoreCursor();

					base.CommitTransaction();

					MessageBox.Show("승인처리를 완료 하였습니다.");

					Search();
				}
				else
				{
					MessageBox.Show("승인처리를 취소 하였습니다.");
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnDeny_Click : 반려처리 버튼 클릭 이벤트
		/// <summary>
		/// 반려처리 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDeny_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show("반려처리는 출금완료 여부가 '출금대기'일 경우에만 변경 됩니다.");

				WDR0510 _form		= new WDR0510();
				_form.Reason		= "반려처리";
				DialogResult res	= _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					string reason		= _form.Reason;
					//// 스톱와치 시작
					//base.MainForm.StartStopWatch();
					//// 커서 기다림
					//base.SetWaitCursor();

					
					var checkedRows	= gridView1.Rows.Cast<DataGridViewRow>()
						.Where(row => row.Cells["CHK"].Value.ToString().Trim().Equals("Y"))
						.Select(row => row);
					foreach (DataGridViewRow row in checkedRows)
					{
						try
						{
							//string[] tmp	= row.Cells["TRADEDATE"].Value.ToString().Split(' ');

							base.ExecuteNonQuery("PCSP_WDR0500_U1"
								, Convert.ToInt32(row.Cells["IDX"].Value.ToString())
								, row.Cells["WDRAPPR_CD"].Value.ToString()
								, "S02003"
								, reason
								, ""							// 비고
								, base.GetCookie("USRID")		// 시스템수정자ID
								, base.GetCookie("USRNM")		// 시스템수정자명
								);
							//row.Cells["STATUS"].Value = "반려처리완료";
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

					
					//// 스톱와치 중지
					//base.MainForm.StopStopWatch();

					//// 커서 복원
					//base.RestoreCursor();
					MessageBox.Show("반려처리를 완료 하였습니다.");

					Search();
				}
				else
				{
					MessageBox.Show("반려처리를 취소 하였습니다.");
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
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

				//_dic.Add("F", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("J", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("K", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("A", "");
				_dic.Add("B", "@");
				_dic.Add("C", "@");
				_dic.Add("N", "@");

				//_dic.Add("C", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("D", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("H", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("L", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("X", "yyyy-MM-dd HH:mm:ss");
				
				//_dic.Add("G", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("H", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("I", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("J", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("K", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("L", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("Q", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("S", "yyyy-MM-dd HH:mm:ss");

				//_dic.Add("I", "@");
				//_dic.Add("N", "@");

				//_dic.Add("A", "#,###");
				//_dic.Add("H", "#,###");
				//_dic.Add("M", "#,###");
				gridView1.ExportToExcel(_dic);

				//gridView1.ExportToExcel();
			}
			catch 
			{
				//BANANA.Windows.Logger.Error(err);
				//MessageBox.Show(err.Message);
			}
		}
		#endregion

		private void _btnComplete_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show("출금완료는 출금완료 여부가 '정산완료 출금대기'일 경우에만 변경 됩니다.");

				WDR0510 _form		= new WDR0510();
				_form.Reason		= "출금완료처리";
				DialogResult res	= _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					string reason		= _form.Reason;
				
					var checkedRows	= gridView1.Rows.Cast<DataGridViewRow>()
						.Where(row => row.Cells["CHK"].Value.ToString().Trim().Equals("Y"))
						.Select(row => row);
					foreach (DataGridViewRow row in checkedRows)
					{
						//if (row.Cells["WDRAPPR_CD"].Value.ToString() == "S02002")
						try
						{
							//string[] tmp	= row.Cells["TRADEDATE"].Value.ToString().Split(' ');

							base.ExecuteNonQuery(
								"PCSP_WDR0500_U2"
								//, row.Cells["STR_CD"].Value.ToString()
								//, tmp[0]
								//, row.Cells["WDRAPPR_CD"].Value.ToString()
								//, "S02003"
								, Convert.ToInt32(row.Cells["IDX"].Value.ToString())
								, reason
								, ""							// 비고
								, base.GetCookie("USRID")		// 시스템수정자ID
								, base.GetCookie("USRNM")		// 시스템수정자명
								);
							//row.Cells["STATUS"].Value = "출금처리완료";
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

					MessageBox.Show("출금처리를 완료 하였습니다.");

					Search();
				}
				else
				{
					MessageBox.Show("출금처리를 취소 하였습니다.");
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void bananaButton1_Click(object sender, EventArgs e)
		{
			try
			{
				//WDR0481 _form = new WDR0481();
				//_form.STR_CD.Text	= _strSTR_CD;
				//_form.STR_NM.Text	= _strSTR_NM;

				//DialogResult res = _form.ShowDialog();
				//if (res == System.Windows.Forms.DialogResult.OK)
				//{
				//	Search();
				//}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}


        /*
		 *	출금완료처리 개발 하기
		 *	출금완료는 승인처리가 된 목록에서만 출금완료가 되어야 함
		 *	출금완료가 된 경우 승인처리 및 반려처리 변경 불가
		 *	
		 * 
		 * 
		 * 
		 * 
		 * 
		 * 
		 * 
		 * 
		 * 
		 * 
		 * 
		 */
    }
}
