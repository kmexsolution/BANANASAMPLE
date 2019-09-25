using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	public partial class BAS0741 : DemoClient.Controllers.BasePopupForm
	{
		public int IDX { get; set; }
		public string AGT_CD { get; set; }

		#region BAS0741 : 생성자
		/// <summary>
		/// 생성자
		/// </summary>
		public BAS0741()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0741_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0741_Load(object sender, EventArgs e)
		{
			try
			{
				// 정산수수료 대리점
				DataTable _dtCALCUL_AGT_CD = base.GetDataTable("CHP_AJAX_CODEHELPER", "Agent", "", "", base.GetCookie("COMPANY_CD"), "", "");
				base.SetListItem(_cmbCALCUL_AGT_CD, _dtCALCUL_AGT_CD, "TOTAL_CODE", "CODE_NAME", false);

				// 대출이자 수수료 대리점
				DataTable _dtINTEREST_AGT_CD = base.GetDataTable("CHP_AJAX_CODEHELPER", "Agent", "", "", base.GetCookie("COMPANY_CD"), "", "");
				base.SetListItem(_cmbINTEREST_AGT_CD, _dtINTEREST_AGT_CD, "TOTAL_CODE", "CODE_NAME", false);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0741_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0741_Shown(object sender, EventArgs e)
		{
			try
			{
				// 등록
				if (this.IDX == 0)
				{
					_cmbCALCUL_AGT_CD.SelectedValue		= this.AGT_CD;
					_cmbINTEREST_AGT_CD.SelectedValue	= this.AGT_CD;
				}
				// 수정
				else
				{
					DataTable _dt = base.GetDataTable(
						"PCSP_BAS0741_R1"
						, this.IDX
						);

					_dtpSTRT_DT.Value					= DateTime.Parse(_dt.Rows[0]["STRT_DT"].ToString());
					_txtCALCUL_CHRG1.Text				= _dt.Rows[0]["CALCUL_CHRG1"].ToString();
					_txtCALCUL_CHRG2.Text				= _dt.Rows[0]["CALCUL_CHRG2"].ToString();
					_txtCALCUL_CHRG3.Text				= _dt.Rows[0]["CALCUL_CHRG3"].ToString();
					_txtCALCUL_CHRG4.Text				= _dt.Rows[0]["CALCUL_CHRG4"].ToString();
					_txtCALCUL_CHRG5.Text				= _dt.Rows[0]["CALCUL_CHRG5"].ToString();
					_txtCALCUL_CHRG6.Text				= _dt.Rows[0]["CALCUL_CHRG6"].ToString();
					_cmbCALCUL_AGT_CD.SelectedValue		= _dt.Rows[0]["CALCUL_AGT_CD"].ToString();
					_txtLOAN_INTEREST.Text				= _dt.Rows[0]["LOAN_INTEREST"].ToString();
					_txtINTEREST1.Text					= _dt.Rows[0]["INTEREST1"].ToString();
					_txtINTEREST2.Text					= _dt.Rows[0]["INTEREST2"].ToString();
					_txtINTEREST3.Text					= _dt.Rows[0]["INTEREST3"].ToString();
					_txtINTEREST4.Text					= _dt.Rows[0]["INTEREST4"].ToString();
					_txtINTEREST5.Text					= _dt.Rows[0]["INTEREST5"].ToString();
					_txtINTEREST6.Text					= _dt.Rows[0]["INTEREST6"].ToString();
					_cmbINTEREST_AGT_CD.SelectedValue	= _dt.Rows[0]["INTEREST_AGT_CD"].ToString();
				}

				_dtpSTRT_DT.Focus();
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
				//timer1.Enabled = false;

				// 등록
				if (this.IDX == 0)
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0741_C1"
						, this.AGT_CD								// 대리점코드
						, _dtpSTRT_DT.Value.ToString("yyyy-MM-dd")	// 등록일자
						, _cmbCALCUL_AGT_CD.SelectedValue			// 정산수수료 대리점코드
						, base.GetDecimal(_txtCALCUL_CHRG1)			// 정산수수료(5억이하)
						, base.GetDecimal(_txtCALCUL_CHRG2)			// 정산수수료(5억초과)
						, base.GetDecimal(_txtCALCUL_CHRG3)			// 정산수수료(10억초과)
						, base.GetDecimal(_txtCALCUL_CHRG4)			// 정산수수료(15억초과)
						, base.GetDecimal(_txtCALCUL_CHRG5)			// 정산수수료(20억초과)
						, base.GetDecimal(_txtCALCUL_CHRG6)			// 정산수수료(30억초과)
						, base.GetDecimal(_txtLOAN_INTEREST)		// 비즈론이자
						, _cmbINTEREST_AGT_CD.SelectedValue			// 대출이자 수수료 대리점
						, base.GetDecimal(_txtINTEREST1)			// 대출이자(5억이하)
						, base.GetDecimal(_txtINTEREST2)			// 대출이자(5억초과)
						, base.GetDecimal(_txtINTEREST3)			// 대출이자(10억초과)
						, base.GetDecimal(_txtINTEREST4)			// 대출이자(15억초과)
						, base.GetDecimal(_txtINTEREST5)			// 대출이자(20억초과)
						, base.GetDecimal(_txtINTEREST6)			// 대출이자(30억초과)
						, ""										// 비고
						, base.GetCookie("USRID")					// 시스템등록자ID
						, base.GetCookie("USRNM")					// 시스템등록자명
						);
				}
				// 수정
				else
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0741_U1"
						, this.IDX									// 일련번호
						//, _dtpSTRT_DT.Value.ToString("yyyy-MM-dd")	// 등록일자
						, _cmbCALCUL_AGT_CD.SelectedValue			// 정산수수료 대리점코드
						, base.GetDecimal(_txtCALCUL_CHRG1)			// 정산수수료(5억이하)
						, base.GetDecimal(_txtCALCUL_CHRG2)			// 정산수수료(5억초과)
						, base.GetDecimal(_txtCALCUL_CHRG3)			// 정산수수료(10억초과)
						, base.GetDecimal(_txtCALCUL_CHRG4)			// 정산수수료(15억초과)
						, base.GetDecimal(_txtCALCUL_CHRG5)			// 정산수수료(20억초과)
						, base.GetDecimal(_txtCALCUL_CHRG6)			// 정산수수료(30억초과)
						, base.GetDecimal(_txtLOAN_INTEREST)		// 비즈론이자
						, _cmbINTEREST_AGT_CD.SelectedValue			// 대출이자 수수료 대리점
						, base.GetDecimal(_txtINTEREST1)			// 대출이자(5억이하)
						, base.GetDecimal(_txtINTEREST2)			// 대출이자(5억초과)
						, base.GetDecimal(_txtINTEREST3)			// 대출이자(10억초과)
						, base.GetDecimal(_txtINTEREST4)			// 대출이자(15억초과)
						, base.GetDecimal(_txtINTEREST5)			// 대출이자(20억초과)
						, base.GetDecimal(_txtINTEREST6)			// 대출이자(30억초과)
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
	}
}
