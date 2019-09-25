using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	public partial class BAS0830 : DemoClient.Controllers.BasePopupForm
	{
		public int BAS0830_IDX { get; set; }
		public int BAS0831_IDX { get; set; }

		#region BAS0830 : 생성자
		/// <summary>
		/// 생성자
		/// </summary>
		public BAS0830()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0830_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0830_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpMNS_DT.Value = DateTime.Now;
				// 출금/차감구분
				DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "C04", "", "", "", "");
				base.SetListItem(_cmbMNS_PROCESS_CD, _dt01, "TOTAL_CODE", "CODE_NAME");
				_cmbMNS_PROCESS_CD.Enabled = false;

				if (BAS0831_IDX == 0)
				{
					_cmbMNS_PROCESS_CD.SelectedValue = "C04003";
				}
				else
				{
					DataTable _dt = base.GetDataTable(
						"PCSP_BAS0830_R1"
						, this.BAS0831_IDX
						);

					_dtpMNS_DT.Value					= DateTime.Parse(_dt.Rows[0]["MNS_DT"].ToString());
					_txtMNS_ACTN_AMT.Text				= _dt.Rows[0]["MNS_ACTN_AMT"].ToString();
					_cmbMNS_PROCESS_CD.SelectedValue	= _dt.Rows[0]["MNS_PROCESS_CD"].ToString();
					MEMO.Text							= _dt.Rows[0]["MEMO"].ToString();

					_btnSave.Visible = false;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		private void _btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				// 등록
				if (this.BAS0831_IDX == 0)
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0830_C1"
						, BAS0830_IDX										// 마스터일련번호
						, 0													// 출금정산일련번호
						, 0													// 출금원장일련번호
						, _dtpMNS_DT.Value.ToString("yyyy-MM-dd")			// 실행일자
						, base.GetDecimal(_txtMNS_ACTN_AMT)					// 실행금액
						, _cmbMNS_PROCESS_CD.SelectedValue					// 처리방법
						, MEMO.Text											// 메모
						, ""												// 비고
						, base.GetCookie("USRID")							// 시스템등록자ID
						, base.GetCookie("USRNM")							// 시스템등록자명
						);
				}
				// 수정
				else
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0830_U1"
						//, this.IDX									// 일련번호
						////, _dtpMNS_APP_DT.Value.ToString("yyyy-MM-dd")		// 적용시작일
						//, _rbMNS_USE_Y.Checked ? "Y" : "N"					// 사용여부(Y/N)
						////, _cmbMNS_GUBUN_CD.SelectedValue					// 출금/차감구분
						////, PLS_IDX											// 상환일련번호
						//, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? base.GetDecimal(_txtMNS_AMT_1) : base.GetDecimal(_txtMNS_AMT_2)	// 출금금액
						////, MNS_ACTN_YN										// 실행여부(Y/N)
						//, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? _cmbMNS_REG_CD.SelectedValue : _cmbMNS_REG_CD2.SelectedValue		// 출금/차감사유코드
						//, _cmbMNS_GUBUN_CD.SelectedValue.ToString() == "C01001" ? _txtMNS_REG_MEMO.Text : _txtMNS_REG_MEMO2.Text					// 출금/차감상세사유
						//, _cmbMNS_GIJUN_CD.SelectedValue					// 차감기준(없음/승인금액/실출금액/입금예정액)
						//, _cmbMNS_CAL_CD.SelectedValue						// 계산방법(정액/정률)
						//, _rbMNS_INTST_Y.Checked ? "Y" : "N"				// 정액 미차감 시 이자발생 여부(Y/N)
						//, base.GetDecimal(_txtMNS_PER)						// 차감수치
						////, ISSYSTEM										// 시스템등록여부(Y/N)
						//, _txtMEMO.Text										// 메모
						, ""										// 비고
						, base.GetCookie("USRID")					// 시스템수정자ID
						, base.GetCookie("USRNM")					// 시스템수정자명
						);
				}

				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void _btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
