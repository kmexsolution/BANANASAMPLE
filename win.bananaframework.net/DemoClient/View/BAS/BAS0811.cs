using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	/// <summary>
	/// 제  목: 수수료율조정
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-16 06:24
	/// 설  명: 가맹점의 매입카드 수수료율을 조정하는 화면입니다.
	/// </summary>
	public partial class BAS0811 : DemoClient.Controllers.BasePopupForm
	{
		public string STR_CD { get; set; }

		public string STR_NM { get; set; }

		#region BAS0811 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0811()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0811_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0811_Load(object sender, EventArgs e)
		{
			try
			{
				this.Text	= string.Format("{1}({0}) {2}", this.STR_CD, this.STR_NM, this.Text);

				//// 컬럼 밴드 처리-비씨카드
				//var band01	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND01", HeaderText = "비씨카드", BackColor = Color.Azure, UseBackColor = true };
				//band01.Columns.Add(CHK_BC);
				//band01.Columns.Add(CRD_BC);
				//band01.Columns.Add(DY_BC);
				//this.gridView1.AddBand(band01);
				
				//// 컬럼 밴드 처리-롯데카드
				//var band02	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND02", HeaderText = "롯데카드", BackColor = Color.LightBlue, UseBackColor = true };
				//band02.Columns.Add(CHK_LT);
				//band02.Columns.Add(CRD_LT);
				//band02.Columns.Add(DY_LT);
				//this.gridView1.AddBand(band02);
				
				//// 컬럼 밴드 처리-삼성카드
				//var band03	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND03", HeaderText = "삼성카드", BackColor = Color.LightCoral, UseBackColor = true };
				//band03.Columns.Add(CHK_SS);
				//band03.Columns.Add(CRD_SS);
				//band03.Columns.Add(DY_SS);
				//this.gridView1.AddBand(band03);
				
				//// 컬럼 밴드 처리-신한카드
				//var band04	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND04", HeaderText = "신한카드", BackColor = Color.LightCyan, UseBackColor = true };
				//band04.Columns.Add(CHK_SH);
				//band04.Columns.Add(CRD_SH);
				//band04.Columns.Add(DY_SH);
				//this.gridView1.AddBand(band04);
				
				//// 컬럼 밴드 처리-현대카드
				//var band05	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND05", HeaderText = "현대카드", BackColor = Color.LightGoldenrodYellow, UseBackColor = true };
				//band05.Columns.Add(CHK_HD);
				//band05.Columns.Add(CRD_HD);
				//band05.Columns.Add(DY_HD);
				//this.gridView1.AddBand(band05);
				
				//// 컬럼 밴드 처리-KB국민카드
				//var band06	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND06", HeaderText = "KB국민카드", BackColor = Color.LightGray, UseBackColor = true };
				//band06.Columns.Add(CHK_KB);
				//band06.Columns.Add(CRD_KB);
				//band06.Columns.Add(DY_KB);
				//this.gridView1.AddBand(band06);
				
				//// 컬럼 밴드 처리-하나SK카드
				//var band07	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND07", HeaderText = "하나SK카드", BackColor = Color.LightGreen, UseBackColor = true };
				//band07.Columns.Add(CHK_SK);
				//band07.Columns.Add(CRD_SK);
				//band07.Columns.Add(DY_SK);
				//this.gridView1.AddBand(band07);
				
				//// 컬럼 밴드 처리-NH농협은행
				//var band08	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND08", HeaderText = "NH농협은행", BackColor = Color.LightPink, UseBackColor = true };
				//band08.Columns.Add(CHK_NH);
				//band08.Columns.Add(CRD_NH);
				//band08.Columns.Add(DY_NH);
				//this.gridView1.AddBand(band08);
				
				//// 컬럼 밴드 처리-외환카드
				//var band09	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND09", HeaderText = "외환카드", BackColor = Color.LightSalmon, UseBackColor = true };
				//band09.Columns.Add(CHK_FR);
				//band09.Columns.Add(CRD_FR);
				//band09.Columns.Add(DY_FR);
				//this.gridView1.AddBand(band09);

				Search();
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
		void ClearControls()
		{
			_txtFEE_CHK_BC.Text			= "";
			_txtFEE_CRD_BC.Text			= "";
			_txtFEE_OVR_BC.Text			= "";
			_txtBY_DAYS_BC.Text			= "";
			_rbBY_USE_Y_BC.Checked		= true;
			_rbBY_USE_N_BC.Checked		= false;

			_txtFEE_CHK_LT.Text			= "";
			_txtFEE_CRD_LT.Text			= "";
			_txtFEE_OVR_LT.Text			= "";
			_txtBY_DAYS_LT.Text			= "";
			_rbBY_USE_Y_LT.Checked		= true;
			_rbBY_USE_N_LT.Checked		= false;
						
			_txtFEE_CHK_SS.Text			= "";
			_txtFEE_CRD_SS.Text			= "";
			_txtFEE_OVR_SS.Text			= "";
			_txtBY_DAYS_SS.Text			= "";
			_rbBY_USE_Y_SS.Checked		= true;
			_rbBY_USE_N_SS.Checked		= false;
						
			_txtFEE_CHK_SH.Text			= "";
			_txtFEE_CRD_SH.Text			= "";
			_txtFEE_OVR_SH.Text			= "";
			_txtBY_DAYS_SH.Text			= "";
			_rbBY_USE_Y_SH.Checked		= true;
			_rbBY_USE_N_SH.Checked		= false;
						
			_txtFEE_CHK_HD.Text			= "";
			_txtFEE_CRD_HD.Text			= "";
			_txtFEE_OVR_HD.Text			= "";
			_txtBY_DAYS_HD.Text			= "";
			_rbBY_USE_Y_HD.Checked		= true;
			_rbBY_USE_N_HD.Checked		= false;
						
			_txtFEE_CHK_KB.Text			= "";
			_txtFEE_CRD_KB.Text			= "";
			_txtFEE_OVR_KB.Text			= "";
			_txtBY_DAYS_KB.Text			= "";
			_rbBY_USE_Y_KB.Checked		= true;
			_rbBY_USE_N_KB.Checked		= false;
						
			_txtFEE_CHK_SK.Text			= "";
			_txtFEE_CRD_SK.Text			= "";
			_txtFEE_OVR_SK.Text			= "";
			_txtBY_DAYS_SK.Text			= "";
			_rbBY_USE_Y_SK.Checked		= true;
			_rbBY_USE_N_SK.Checked		= false;
						
			_txtFEE_CHK_NH.Text			= "";
			_txtFEE_CRD_NH.Text			= "";
			_txtFEE_OVR_NH.Text			= "";
			_txtBY_DAYS_NH.Text			= "";
			_rbBY_USE_Y_NH.Checked		= true;
			_rbBY_USE_N_NH.Checked		= false;
						
			_txtFEE_CHK_FR.Text			= "";
			_txtFEE_CRD_FR.Text			= "";
			_txtFEE_OVR_FR.Text			= "";
			_txtBY_DAYS_FR.Text			= "";
			_rbBY_USE_Y_FR.Checked		= true;
			_rbBY_USE_N_FR.Checked		= false;

			_txtMEMO.Text				= "";
			_dtpBY_APP_DT.Value			= System.DateTime.Now;
			_dtpBY_APP_DT.Checked		= false;
		}
		#endregion

		#region EnableControls : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		void EnableControls(bool _bTrue)
		{
			_txtFEE_CHK_BC.ReadOnly	= !_bTrue;
			_txtFEE_CRD_BC.ReadOnly	= !_bTrue;
			_txtFEE_OVR_BC.ReadOnly	= !_bTrue;
			_txtBY_DAYS_BC.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_BC.Enabled	= _bTrue;
			_rbBY_USE_N_BC.Enabled	= _bTrue;
			
			_txtFEE_CHK_LT.ReadOnly	= !_bTrue;
			_txtFEE_CRD_LT.ReadOnly	= !_bTrue;
			_txtFEE_OVR_LT.ReadOnly	= !_bTrue;
			_txtBY_DAYS_LT.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_LT.Enabled	= _bTrue;
			_rbBY_USE_N_LT.Enabled	= _bTrue;
			
			_txtFEE_CHK_SS.ReadOnly	= !_bTrue;
			_txtFEE_CRD_SS.ReadOnly	= !_bTrue;
			_txtFEE_OVR_SS.ReadOnly	= !_bTrue;
			_txtBY_DAYS_SS.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_SS.Enabled	= _bTrue;
			_rbBY_USE_N_SS.Enabled	= _bTrue;
			
			_txtFEE_CHK_SH.ReadOnly	= !_bTrue;
			_txtFEE_CRD_SH.ReadOnly	= !_bTrue;
			_txtFEE_OVR_SH.ReadOnly	= !_bTrue;
			_txtBY_DAYS_SH.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_SH.Enabled	= _bTrue;
			_rbBY_USE_N_SH.Enabled	= _bTrue;
			
			_txtFEE_CHK_HD.ReadOnly	= !_bTrue;
			_txtFEE_CRD_HD.ReadOnly	= !_bTrue;
			_txtFEE_OVR_HD.ReadOnly	= !_bTrue;
			_txtBY_DAYS_HD.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_HD.Enabled	= _bTrue;
			_rbBY_USE_N_HD.Enabled	= _bTrue;
			
			_txtFEE_CHK_KB.ReadOnly	= !_bTrue;
			_txtFEE_CRD_KB.ReadOnly	= !_bTrue;
			_txtFEE_OVR_KB.ReadOnly	= !_bTrue;
			_txtBY_DAYS_KB.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_KB.Enabled	= _bTrue;
			_rbBY_USE_N_KB.Enabled	= _bTrue;
			
			_txtFEE_CHK_SK.ReadOnly	= !_bTrue;
			_txtFEE_CRD_SK.ReadOnly	= !_bTrue;
			_txtFEE_OVR_SK.ReadOnly	= !_bTrue;
			_txtBY_DAYS_SK.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_SK.Enabled	= _bTrue;
			_rbBY_USE_N_SK.Enabled	= _bTrue;
			
			_txtFEE_CHK_NH.ReadOnly	= !_bTrue;
			_txtFEE_CRD_NH.ReadOnly	= !_bTrue;
			_txtFEE_OVR_NH.ReadOnly	= !_bTrue;
			_txtBY_DAYS_NH.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_NH.Enabled	= _bTrue;
			_rbBY_USE_N_NH.Enabled	= _bTrue;
			
			_txtFEE_CHK_FR.ReadOnly	= !_bTrue;
			_txtFEE_CRD_FR.ReadOnly	= !_bTrue;
			_txtFEE_OVR_FR.ReadOnly	= !_bTrue;
			_txtBY_DAYS_FR.ReadOnly	= !_bTrue;
			_rbBY_USE_Y_FR.Enabled	= _bTrue;
			_rbBY_USE_N_FR.Enabled	= _bTrue;

			_dtpBY_APP_DT.Enabled	= _bTrue;
			_txtMEMO.ReadOnly		= !_bTrue;

			_btnSave.Enabled		= _bTrue;
			_btnDel.Enabled			= _bTrue;
		}
		#endregion

		#region Search : 검색 함수
		/// <summary>
		/// 검색 함수
		/// </summary>
		void Search()
		{
			try
			{
				DataTable _dt			= base.GetDataTable("PCSP_BAS0811_R1"
					, this.STR_CD
					);
				gridView1.DataSource	= _dt;
			}
			catch
			{
				throw;
			}
			finally
			{
				EnableControls(false);
			}
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
				BAS0812 _form	= new BAS0812();
				_form.STR_CD	= this.STR_CD;
				_form.STR_NM	= this.STR_NM;
				_form.ShowDialog();

				// 검색 수행
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
				// 업데이트 수행
				base.BeginTransaction();

				// 마스터 업데이트
				base.ExecuteNonQuery("PCSP_BAS0811_U1"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, base.GetDate(_dtpBY_APP_DT)
					, _txtMEMO.Text
					, ""
					, base.GetCookie("USRID")
					, base.GetCookie("USRNM")
					);
					
				// 상세 업데이트(비씨카드-A08001)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08001"
					, base.GetDecimal(_txtFEE_CHK_BC)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_BC)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_BC)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_BC)		// 입금주기
					, _rbBY_USE_Y_BC.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(롯데카드-A08002)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08002"
					, base.GetDecimal(_txtFEE_CHK_LT)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_LT)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_LT)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_LT)		// 입금주기
					, _rbBY_USE_Y_LT.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(삼성카드-A08003)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08003"
					, base.GetDecimal(_txtFEE_CHK_SS)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_SS)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_SS)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_SS)		// 입금주기
					, _rbBY_USE_Y_SS.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(신한카드-A08004)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08004"
					, base.GetDecimal(_txtFEE_CHK_SH)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_SH)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_SH)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_SH)		// 입금주기
					, _rbBY_USE_Y_SH.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(현대카드-A08005)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08005"
					, base.GetDecimal(_txtFEE_CHK_HD)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_HD)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_HD)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_HD)		// 입금주기
					, _rbBY_USE_Y_HD.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(KB국민카드-A08006)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08006"
					, base.GetDecimal(_txtFEE_CHK_KB)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_KB)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_KB)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_KB)		// 입금주기
					, _rbBY_USE_Y_KB.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(하나SK카드-A08007)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08007"
					, base.GetDecimal(_txtFEE_CHK_SK)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_SK)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_SK)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_SK)		// 입금주기
					, _rbBY_USE_Y_SK.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(NH농협은행-A08009)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08009"
					, base.GetDecimal(_txtFEE_CHK_NH)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_NH)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_NH)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_NH)		// 입금주기
					, _rbBY_USE_Y_NH.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 업데이트(외환카드-A08010)
				base.ExecuteNonQuery("PCSP_BAS0811_U2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, "A08010"
					, base.GetDecimal(_txtFEE_CHK_FR)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_FR)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_FR)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_FR)		// 입금주기
					, _rbBY_USE_Y_FR.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				base.CommitTransaction();

				MessageBox.Show("수수료율을 조정 하였습니다.");
				Search();
				ClearControls();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				base.RollbackTransaction();
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
				// 삭제 수행
				base.ExecuteNonQuery("PCSP_BAS0811_D1"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))
					, ""							// 비고
					, base.GetCookie("USRID")		// 시스템등록자ID
					, base.GetCookie("USRNM")		// 시스템등록자명
					);

				MessageBox.Show("수수료율을 삭제 하였습니다.");
				Search();
				ClearControls();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnClose_Click : 닫기 버튼 클릭 이벤트
		/// <summary>
		/// 닫기 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region 수수료 텍스트박스 처리
		private void _rbBY_USE_Y_BC_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_BC, _txtFEE_CRD_BC, _txtFEE_OVR_BC, _txtBY_DAYS_BC, _rbBY_USE_Y_BC, _rbBY_USE_N_BC);
		}

		private void _rbBY_USE_Y_LT_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_LT, _txtFEE_CRD_LT, _txtFEE_OVR_LT, _txtBY_DAYS_LT, _rbBY_USE_Y_LT, _rbBY_USE_N_LT);
		}

		private void _rbBY_USE_Y_SS_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_SS, _txtFEE_CRD_SS, _txtFEE_OVR_SS, _txtBY_DAYS_SS, _rbBY_USE_Y_SS, _rbBY_USE_N_SS);
		}

		private void _rbBY_USE_Y_SH_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_SH, _txtFEE_CRD_SH, _txtFEE_OVR_SH, _txtBY_DAYS_SH, _rbBY_USE_Y_SH, _rbBY_USE_N_SH);
		}

		private void _rbBY_USE_Y_HD_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_HD, _txtFEE_CRD_HD, _txtFEE_OVR_HD, _txtBY_DAYS_HD, _rbBY_USE_Y_HD, _rbBY_USE_N_HD);
		}

		private void _rbBY_USE_Y_KB_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_KB, _txtFEE_CRD_KB, _txtFEE_OVR_KB, _txtBY_DAYS_KB, _rbBY_USE_Y_KB, _rbBY_USE_N_KB);
		}

		private void _rbBY_USE_Y_SK_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_SK, _txtFEE_CRD_SK, _txtFEE_OVR_SK, _txtBY_DAYS_SK, _rbBY_USE_Y_SK, _rbBY_USE_N_SK);
		}

		private void _rbBY_USE_Y_NH_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_NH, _txtFEE_CRD_NH, _txtFEE_OVR_NH, _txtBY_DAYS_NH, _rbBY_USE_Y_NH, _rbBY_USE_N_NH);
		}

		private void _rbBY_USE_Y_FR_CheckedChanged(object sender, EventArgs e)
		{
			base.DetectCardRateTextBox(_txtFEE_CHK_FR, _txtFEE_CRD_FR, _txtFEE_OVR_FR, _txtBY_DAYS_FR, _rbBY_USE_Y_FR, _rbBY_USE_N_FR);
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
				EnableControls(true);

				DataTable _dt	= base.GetDataTable("PCSP_BAS0810_R2"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["IDX"].Value))
					, this.STR_CD
					);

				_dtpBY_APP_DT.Value		= _dt.Rows[0]["BY_APP_DT"].ToString().Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(_dt.Rows[0]["BY_APP_DT"].ToString());
				_dtpBY_APP_DT.Checked	= _dt.Rows[0]["BY_APP_DT"].ToString().Trim() == "" ? false : true;
				_txtMEMO.Text			= _dt.Rows[0]["MEMO"].ToString();

				for (int i = 0; i < _dt.Rows.Count; i++)
				{
					// 비씨카드(A08001)
					if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08001")
					{
						_txtFEE_CHK_BC.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_BC.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_BC.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_BC.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_BC.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_BC.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_BC, _txtFEE_CRD_BC, _txtFEE_OVR_BC, _txtBY_DAYS_BC, _rbBY_USE_Y_BC, _rbBY_USE_N_BC);
					}
					// 롯데카드(A08002)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08002")
					{
						_txtFEE_CHK_LT.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_LT.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_LT.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_LT.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_LT.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_LT.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_LT, _txtFEE_CRD_LT, _txtFEE_OVR_LT, _txtBY_DAYS_LT, _rbBY_USE_Y_LT, _rbBY_USE_N_LT);
					}
					// 삼성카드(A08003)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08003")
					{
						_txtFEE_CHK_SS.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_SS.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_SS.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_SS.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_SS.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_SS.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_SS, _txtFEE_CRD_SS, _txtFEE_OVR_SS, _txtBY_DAYS_SS, _rbBY_USE_Y_SS, _rbBY_USE_N_SS);
					}
					// 신한카드(A08004)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08004")
					{
						_txtFEE_CHK_SH.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_SH.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_SH.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_SH.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_SH.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_SH.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_SH, _txtFEE_CRD_SH, _txtFEE_OVR_SH, _txtBY_DAYS_SH, _rbBY_USE_Y_SH, _rbBY_USE_N_SH);
					}
					// 현대카드(A08005)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08005")
					{
						_txtFEE_CHK_HD.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_HD.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_HD.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_HD.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_HD.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_HD.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_HD, _txtFEE_CRD_HD, _txtFEE_OVR_HD, _txtBY_DAYS_HD, _rbBY_USE_Y_HD, _rbBY_USE_N_HD);
					}
					// KB국민카드(A08006)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08006")
					{
						_txtFEE_CHK_KB.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_KB.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_KB.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_KB.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_KB.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_KB.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_KB, _txtFEE_CRD_KB, _txtFEE_OVR_KB, _txtBY_DAYS_KB, _rbBY_USE_Y_KB, _rbBY_USE_N_KB);
					}
					// 하나SK카드(A08007)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08007")
					{
						_txtFEE_CHK_SK.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_SK.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_SK.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_SK.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_SK.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_SK.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_SK, _txtFEE_CRD_SK, _txtFEE_OVR_SK, _txtBY_DAYS_SK, _rbBY_USE_Y_SK, _rbBY_USE_N_SK);
					}
					// NH농협은행(A08009)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08009")
					{
						_txtFEE_CHK_NH.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_NH.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_NH.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_NH.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_NH.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_NH.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_NH, _txtFEE_CRD_NH, _txtFEE_OVR_NH, _txtBY_DAYS_NH, _rbBY_USE_Y_NH, _rbBY_USE_N_NH);
					}
					// 외환카드(A08010)
					else if (_dt.Rows[i]["BY_CRD_CD"].ToString() == "A08010")
					{
						_txtFEE_CHK_FR.Text		= _dt.Rows[i]["FEE_CHK"].ToString();
						_txtFEE_CRD_FR.Text		= _dt.Rows[i]["FEE_CRD"].ToString();
						_txtFEE_OVR_FR.Text		= _dt.Rows[i]["FEE_OVR"].ToString();
						_txtBY_DAYS_FR.Text		= _dt.Rows[i]["BY_DAYS"].ToString();
						_rbBY_USE_Y_FR.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "Y" ? true : false;
						_rbBY_USE_N_FR.Checked	= _dt.Rows[i]["BY_USE_YN"].ToString() == "N" ? true : false;
			
						base.DetectCardRateTextBox(_txtFEE_CHK_FR, _txtFEE_CRD_FR, _txtFEE_OVR_FR, _txtBY_DAYS_FR, _rbBY_USE_Y_FR, _rbBY_USE_N_FR);
					}
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
