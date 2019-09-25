using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.HLP
{
	public partial class HLP0310 : DemoClient.Controllers.BasePopupForm
	{
		public int IDX { get; set; }

		#region 생성자 : HLP0310
		/// <summary>
		/// 생성자
		/// </summary>
		public HLP0310()
		{
			InitializeComponent();
		}
		#endregion

		#region HLP0310_Load : 폼 로드
		/// <summary>
		/// 폼 로드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HLP0310_Load(object sender, EventArgs e)
		{
			try
			{
				// 구분
				DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "A12"
					, ""
					, ""
					, ""
					, ""
					);
				base.SetListItem(_cmbGUBUN
					, _dt01
					, "TOTAL_CODE"
					, "CODE_NAME"
					);

				// 등록
				if (this.IDX == 0)
				{
					//_cmbCALCUL_AGT_CD.SelectedValue = this.AGT_CD;
					//_cmbINTEREST_AGT_CD.SelectedValue = this.AGT_CD;
				}
				// 수정
				else
				{
					DataTable _dt = base.GetDataTable(
						"PCSP_HLP0310_R1"
						, this.IDX
						);

					_txtIDX.Text				= _dt.Rows[0]["IDX"].ToString();								// 일련번호
					_cmbGUBUN.SelectedValue		= _dt.Rows[0]["GUBUN"].ToString();								// 구분(A12)
					_chkDISPLAY_YN.Checked		= _dt.Rows[0]["DISPLAY_YN"].ToString() == "Y" ? true : false;	// 출력여부
					_txtTITLE.Text				= _dt.Rows[0]["TITLE"].ToString();								// 제목
					_txtMEMO.Text				= _dt.Rows[0]["MEMO"].ToString();								// 내용
					_lblSYSREGINFO.Text			= _dt.Rows[0]["SYSREGNAME"].ToString() + "  " + _dt.Rows[0]["SYSREGDATE"].ToString();
					_lblSYSMODINFO.Text			= _dt.Rows[0]["SYSMODNAME"].ToString() + "  " + _dt.Rows[0]["SYSMODDATE"].ToString();
				}

				_txtTITLE.Focus();
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
				// 등록
				if (this.IDX == 0)
				{
					base.ExecuteNonQuery(
						"PCSP_HLP0310_C1"
						, _txtTITLE.Text						// 제목
						, _cmbGUBUN.SelectedValue				// 구분(A12)
						, _chkDISPLAY_YN.Checked ? "Y" : "N"	// 출력여부
						, _txtMEMO.Text							// 내용
						, ""									// 비고
						, base.GetCookie("USRID")				// 시스템등록자ID
						, base.GetCookie("USRNM")				// 시스템등록자명
						);
				}
				// 수정
				else
				{
					base.ExecuteNonQuery(
						"PCSP_HLP0310_U1"
						, this.IDX								// 일련번호
						, _txtTITLE.Text						// 제목
						, _cmbGUBUN.SelectedValue				// 구분(A12)
						, _chkDISPLAY_YN.Checked ? "Y" : "N"	// 출력여부
						, _txtMEMO.Text							// 내용
						, ""									// 비고
						, base.GetCookie("USRID")				// 시스템수정자ID
						, base.GetCookie("USRNM")				// 시스템수정자명
						);
				}

				MessageBox.Show("자장 완료 했습니다.");
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
