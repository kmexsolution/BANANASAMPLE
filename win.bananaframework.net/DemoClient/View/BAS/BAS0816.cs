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
	/// 제  목: 가맹점.보증예치금관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-12 22:34
	/// 설  명: 가맹점의 보증예치금을 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0816 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		private Thread _thread;		// 검색 쓰레드

		#region BAS0816 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0816()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0816_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0816_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpDPST_STRT_DT_S_S.Value		= DateTime.Now.AddDays(1 - DateTime.Now.Day);
				_dtpDPST_STRT_DT_E_S.Value		= DateTime.Now;

				// 차감기준
				DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B01", "", "", "", "");
				base.SetListItem(_cmbDPST_GIJUN_CD, _dt01, "TOTAL_CODE", "CODE_NAME");

				// 계산방법
				DataTable _dt02		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B02", "", "", "", "");
				base.SetListItem(_cmbDPST_CAL_CD, _dt02, "TOTAL_CODE", "CODE_NAME");
				
				// 차감기준(검색)
				DataTable _dt03		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B01", "", "", "", "");
				base.SetListItem(_cmbDPST_GIJUN_CD_S, _dt03, "TOTAL_CODE", "CODE_NAME", true);

				// 계산방법(검색)
				DataTable _dt04		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "B02", "", "", "", "");
				base.SetListItem(_cmbDPST_CAL_CD_S, _dt04, "TOTAL_CODE", "CODE_NAME", true);

				_dtpDPST_STRT_DT.Checked		= false;
				_dtpDPST_STRT_DT_S_S.Checked	= false;
				_dtpDPST_STRT_DT_E_S.Checked	= false;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0816_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0816_Shown(object sender, EventArgs e)
		{
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
			_txtSTR_CD.Text					= "";
			_txtSTR_NM.Text					= "";
			_dtpDPST_STRT_DT.Value			= DateTime.Now;
			_dtpDPST_STRT_DT.Checked		= false;
			_rbDPST_USE_Y.Checked			= true;
			_rbDPST_USE_N.Checked			= false;
			_cmbDPST_GIJUN_CD.SelectedIndex	= 0;
			_cmbDPST_GIJUN_CD.Enabled		= false;
			_cmbDPST_CAL_CD.SelectedIndex	= 0;
			_rbDPST_INTST_Y.Checked			= true;
			_rbDPST_INTST_N.Checked			= false;
			_txtDPST_LMT_AMT.Text			= "";
			_txtDPST_PER.Text				= "";
			_lblDPST_CAL_CD.Text			= "원";
			_txtDPST_AMT.Text				= "";
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
			_dtpDPST_STRT_DT_S_S.Enabled	= _bTrue;
			_dtpDPST_STRT_DT_E_S.Enabled	= _bTrue;
			_cmbDPST_GIJUN_CD_S.Enabled		= _bTrue;
			_cmbDPST_CAL_CD_S.Enabled		= _bTrue;
			_txtDPST_AMT_S_S.ReadOnly		= !_bTrue;
			_txtDPST_AMT_E_S.ReadOnly		= !_bTrue;
			_btnSearch.Enabled				= _bTrue;
			_btnExcel.Enabled				= _bTrue;

			gridView1.Enabled				= _bTrue;
			gridView2.Enabled				= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
			_dtpDPST_STRT_DT.Enabled	= _bTrue;
			_rbDPST_USE_Y.Enabled		= _bTrue;
			_rbDPST_USE_N.Enabled		= _bTrue;
			_cmbDPST_GIJUN_CD.Enabled	= _bTrue;
			_cmbDPST_CAL_CD.Enabled		= _bTrue;
			_rbDPST_INTST_Y.Enabled		= _bTrue;
			_rbDPST_INTST_N.Enabled		= _bTrue;
			_txtDPST_LMT_AMT.ReadOnly	= !_bTrue;
			_txtDPST_PER.ReadOnly		= !_bTrue;
			_txtDPST_AMT.ReadOnly		= !_bTrue;
			
			_btnAdd01.Enabled			= _bTrue;
			_btnSave01.Enabled			= _bTrue;
			_btnDel01.Enabled			= _bTrue;

			_btnAdd02.Enabled			= _bTrue;
			_btnDel02.Enabled			= _bTrue;
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
			panel1.Width		= 480;
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
				int? strt	= _txtDPST_AMT_S_S.Text == "" ? -1000000000 : base.GetInteger(_txtDPST_AMT_S_S);
				int? end	= _txtDPST_AMT_E_S.Text == "" ? 1000000000 : base.GetInteger(_txtDPST_AMT_E_S);

				DataTable _dt			= base.GetDataTable("PCSP_BAS0816_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_CD_S.Text
					, _txtSTR_NM_S.Text						// 가맹점명
					, base.GetDate(_dtpDPST_STRT_DT_S_S)	// 적용시작일(시작)
					, base.GetDate(_dtpDPST_STRT_DT_E_S)	// 적용시작일(종료)
					, base.GetString(_cmbDPST_GIJUN_CD_S)	// 차감기준
					, base.GetString(_cmbDPST_CAL_CD_S)		// 계산방법
					, strt									// 보증한도금액(시작)
					, end									// 보증한도금액(종료)
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
					// 스플릿바 처리
					if (collapsibleSplitter1.IsCollapsed)
					{
						collapsibleSplitter1.ToggleState();
					}

					ClearControls();

					DataSet _ds			= base.GetDataSet("PCSP_BAS0816_R2"
						, gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value
						);

					_txtSTR_CD.Text		= gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value.ToString().Trim();
					_txtSTR_NM.Text		= gridView1.Rows[e.RowIndex].Cells["STR_NM"].Value.ToString();

					// 상세정보 바인딩
					ShowDetail(_ds.Tables[0]);

					// 예외기간 바인딩
					ShowException(_ds.Tables[1]);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region ShowDetail : 상세보기
		/// <summary>
		/// 상세보기
		/// </summary>
		/// <param name="_dt"></param>
		void ShowDetail(DataTable _dt)
		{
			try
			{
				// 추가 버튼 활성화 처리
				if (_dt.Rows.Count == 0)
				{
					EnableControls2(false);

					_btnAdd01.Enabled		= true;
					_btnSave01.Enabled		= false;
					_btnDel01.Enabled		= false;

					_btnAdd02.Enabled		= false;
					_btnDel02.Enabled		= false;
				}
				else
				{
					EnableControls2(true);

					_btnAdd01.Enabled		= false;
					_btnSave01.Enabled		= true;
					_btnDel01.Enabled		= true;

					_btnAdd02.Enabled		= true;
					_btnDel02.Enabled		= false;
				}

				if (_dt.Rows.Count == 0)
				{
					return;
				}

				// 상세정보 바인딩
				_dtpDPST_STRT_DT.Value			= Convert.ToDateTime(_dt.Rows[0]["DPST_STRT_DT"]);
				_rbDPST_USE_Y.Checked			= _dt.Rows[0]["DPST_USE_YN"].ToString() == "Y" ? true : false;
				_rbDPST_USE_N.Checked			= _dt.Rows[0]["DPST_USE_YN"].ToString() == "N" ? true : false;
				_cmbDPST_GIJUN_CD.SelectedValue	= _dt.Rows[0]["DPST_GIJUN_CD"].ToString();
				_cmbDPST_CAL_CD.SelectedValue	= _dt.Rows[0]["DPST_CAL_CD"].ToString();
				_rbDPST_INTST_Y.Checked			= _dt.Rows[0]["DPST_INTST_YN"].ToString() == "Y" ? true : false;
				_rbDPST_INTST_N.Checked			= _dt.Rows[0]["DPST_INTST_YN"].ToString() == "N" ? true : false;
				_txtDPST_PER.Text				= _dt.Rows[0]["DPST_PER"].ToString();
				_txtDPST_LMT_AMT.Text			= _dt.Rows[0]["DPST_LMT_AMT"].ToString();
				_txtDPST_AMT.Text				= _dt.Rows[0]["DPST_AMT"].ToString();

				// 정액
				if (_dt.Rows[0]["DPST_CAL_CD"].ToString() == "B02001")
				{
					_lblDPST_CAL_CD.Text			= "원";
					_txtDPST_PER.ImeMode			= BANANA.Windows.Controls.ImeMode.Integer;
					_txtDPST_PER.Text				= _txtDPST_PER.Text.Replace(".", "");
					_cmbDPST_GIJUN_CD.SelectedValue	= "B01001";
					_cmbDPST_GIJUN_CD.Enabled		= false;
				}
				// 정률
				else if (_dt.Rows[0]["DPST_CAL_CD"].ToString() == "B02002")
				{
					_lblDPST_CAL_CD.Text			= "%";
					_txtDPST_PER.ImeMode			= BANANA.Windows.Controls.ImeMode.Decimal;
					_cmbDPST_GIJUN_CD.Enabled		= true;
				}
			}
			catch
			{
				throw;
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
				_dic.Add("C", "yyyy-MM-dd");
				_dic.Add("J", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("L", "yyyy-MM-dd HH:mm:ss");

				_dic.Add("I", "#,###");
				gridView1.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnAdd01_Click : 보증예치금 추가 버튼 클릭 이벤트
		/// <summary>
		/// 보증예치금 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd01_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0826 _form		= new BAS0826();
				_form.STR_CD.Text	= _txtSTR_CD.Text;
				_form.STR_NM.Text	= _txtSTR_NM.Text;
				DialogResult res	= _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					_btnSearch.PerformClick();

					DataTable _dt		= base.GetDataTable("PCSP_BAS0816_R2"
						, _txtSTR_CD.Text
						);

					ShowDetail(_dt);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnSave01_Click : 보증예치금 저장 버튼 클릭 이벤트
		/// <summary>
		/// 보증예치금 저장 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave01_Click(object sender, EventArgs e)
		{
			try
			{
				// 계산방법과 차감기준 체크
				if ((_cmbDPST_CAL_CD.SelectedValue.ToString() == "B02002")
					&& (_cmbDPST_GIJUN_CD.SelectedValue.ToString() == "B01001"))
				{
					MessageBox.Show("계산방법이 정률일 경우에는 차감기준을 선택하셔야 합니다.");
					return;
				}

				base.ExecuteNonQuery("PCSP_BAS0816_U1"
					, _txtSTR_CD.Text						// 가맹점코드
					, base.GetDate(_dtpDPST_STRT_DT)		// 적용시작일
					, _rbDPST_USE_Y.Checked ? "Y" : "N"		// 사용여부(Y/N)
					, base.GetString(_cmbDPST_GIJUN_CD)		// 차감기준(없음/승인금액/실출금액/입금예정액)
					, base.GetString(_cmbDPST_CAL_CD)		// 계산방법(정액/정률)
					, _rbDPST_INTST_Y.Checked ? "Y" : "N"	// 정액 미차감 시 이자발생 여부(Y/N)
					, base.GetDecimal(_txtDPST_PER)			// 차감수치
					, base.GetInteger(_txtDPST_AMT)			// 보증한도금액
					, base.GetInteger(_txtDPST_LMT_AMT)		// 일적립금액
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				MessageBox.Show("보증예치금을 수정 하였습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnDel01_Click : 보증예치금 삭제 버튼 클릭 이벤트
		/// <summary>
		/// 보증예치금 삭제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDel01_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0816_D1"
					, _txtSTR_CD.Text
					);

				ClearControls();

				_btnAdd01.Enabled	= true;
				_btnSave01.Enabled	= false;
				_btnDel01.Enabled	= false;
				_btnAdd02.Enabled	= false;
				_btnDel02.Enabled	= false;

				_btnSearch.PerformClick();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region ShowException : 예외기간 그리드 바인딩
		/// <summary>
		/// 예외기간 그리드 바인딩
		/// </summary>
		/// <param name="_dt"></param>
		void ShowException(DataTable _dt)
		{
			try
			{
				gridView2.DataSource	= _dt;
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region _btnAdd02_Click : 예외기간 추가 버튼 클릭 이벤트
		/// <summary>
		/// 예외기간 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd02_Click(object sender, EventArgs e)
		{
			try
			{
				BAS0827 _form		= new BAS0827();
				_form.STR_CD.Text	= _txtSTR_CD.Text;
				_form.STR_NM.Text	= _txtSTR_NM.Text;
				DialogResult res	= _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					DataSet _ds			= base.GetDataSet("PCSP_BAS0816_R2"
						, _txtSTR_CD.Text
						);
					ShowException(_ds.Tables[1]);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnDel02_Click : 예외기간 삭제 버튼 클릭 이벤트
		/// <summary>
		/// 예외기간 삭제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDel02_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0816_D2"
					, Convert.ToInt32(gridView2.Rows[gridView2.CurrentRow.Index].Cells["IDX2"].Value.ToString())
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				DataSet _ds			= base.GetDataSet("PCSP_BAS0816_R2"
					, _txtSTR_CD.Text
					);
				ShowException(_ds.Tables[1]);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				_btnDel02.Enabled	= false;
			}
		}
		#endregion

		#region _cmbDPST_CAL_CD_DropDownClosed : 계산방법 변경 이벤트
		/// <summary>
		/// 계산방법 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _cmbDPST_CAL_CD_DropDownClosed(object sender, EventArgs e)
		{
			// 정액
			if (_cmbDPST_CAL_CD.SelectedValue.ToString() == "B02001")
			{
				_lblDPST_CAL_CD.Text			= "원";
				_txtDPST_PER.ImeMode			= BANANA.Windows.Controls.ImeMode.Integer;
				_txtDPST_PER.Text				= _txtDPST_PER.Text.Replace(".", "");
				_cmbDPST_GIJUN_CD.SelectedValue	= "B01001";
				_cmbDPST_GIJUN_CD.Enabled		= false;
			}
			// 정률
			else if (_cmbDPST_CAL_CD.SelectedValue.ToString() == "B02002")
			{
				_lblDPST_CAL_CD.Text			= "%";
				_txtDPST_PER.ImeMode			= BANANA.Windows.Controls.ImeMode.Decimal;
				_cmbDPST_GIJUN_CD.Enabled		= true;
			}
		}
		#endregion

		#region gridView2_CellDoubleClick : 예외기간 그리드 더블클릭 이벤트
		/// <summary>
		/// 예외기간 그리드 더블클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				BAS0827 _form				= new BAS0827();
				_form.IDX					= Convert.ToInt32(gridView2.Rows[e.RowIndex].Cells["IDX2"].Value.ToString());
				_form.STR_CD.Text			= _txtSTR_CD.Text;
				_form.STR_NM.Text			= _txtSTR_NM.Text;
				_form.EXCPT_DT_STRT			= Convert.ToDateTime(gridView2.Rows[e.RowIndex].Cells["EXCPT_DT_STRT"].Value.ToString());
				_form.EXCPT_DT_END			= Convert.ToDateTime(gridView2.Rows[e.RowIndex].Cells["EXCPT_DT_END"].Value.ToString());
				_form.MEMO.Text				= gridView2.Rows[e.RowIndex].Cells["MEMO"].Value.ToString();
				DialogResult res	= _form.ShowDialog();
				if (res == System.Windows.Forms.DialogResult.OK)
				{
					DataSet _ds			= base.GetDataSet("PCSP_BAS0816_R2"
						, _txtSTR_CD.Text
						);
					ShowException(_ds.Tables[1]);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView2_CellClick : 예외기간 그리드 클릭 이벤트
		/// <summary>
		/// 예외기간 그리드 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_btnDel02.Enabled	= true;
		}
		#endregion
	}
}
