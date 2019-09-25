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
	/// 제  목: PowerVAN 로그인정보 화면
	/// 작성자: 한인수 (crowlead1208@devpia.com, 010-8633-2208)
	/// 작성일: 2016-10-06 09:47
	/// 설  명: 
	/// </summary>
	public partial class BAS0829 : DemoClient.Controllers.BasePopupForm
	{
		public int IDX { get; set; }
		public string STR_CD { get; set; }

		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0829()
		{
			InitializeComponent();
		}

		#region BAS0829_Shown : 폼 보이기
		/// <summary>
		/// 폼 보이기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0829_Shown(object sender, EventArgs e)
		{
			try
			{
				DataTable _dtVAN = base.GetDataTable("CHP_AJAX_CODEHELPER"
					, "Common"
					, "V01"
					, ""
					, ""
					, ""
					, ""
					);
				base.SetListItem(_cmbVAN_CD
					, _dtVAN
					, "TOTAL_CODE"
					, "CODE_NAME"
					);

				// ⊙
				// 등록
				if (this.IDX == 0)
				{
					_chkSYSUSEYN.Checked = true;
					//_dtpCALL_DT_STRT.Value = System.DateTime.Now;
				}
				// 수정
				else
				{
					DataTable _dt = base.GetDataTable("PCSP_BAS0800_R8"
						, this.IDX
						);

					_cmbVAN_CD.SelectedValue	= _dt.Rows[0]["VAN_CD"].ToString();
					_txtUSER_ID.Text			= _dt.Rows[0]["USER_ID"].ToString();
					_txtUSER_PW.Text			= _dt.Rows[0]["USER_PW"].ToString();
					_chkSYSUSEYN.Checked		= _dt.Rows[0]["SYSUSEYN"].ToString() == "Y" ? true : false;
				}

				_cmbVAN_CD.Focus();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		private void BAS0829_Load(object sender, EventArgs e)
		{

		}

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
					base.ExecuteNonQuery("PCSP_BAS0829_C1"
						, this.STR_CD												// 가맹점코드
						, _cmbVAN_CD.SelectedValue									// VAN코드
						, _txtUSER_ID.Text											// 로그인 아이디
						, _txtUSER_PW.Text											// 로그인 비밀번호
						, _chkSYSUSEYN.Checked ? "Y" : "N"
						, ""														// 비고
						, base.GetCookie("USRID")									// 시스템수정자ID
						, base.GetCookie("USRNM")									// 시스템수정자명
						);
				}
				// 수정
				else
				{
					base.ExecuteNonQuery("PCSP_BAS0829_U1"
						, this.IDX													// 일련번호
						, _cmbVAN_CD.SelectedValue									// VAN코드
						, _txtUSER_ID.Text											// 로그인 아이디
						, _txtUSER_PW.Text											// 로그인 비밀번호
						, _chkSYSUSEYN.Checked ? "Y" : "N"
						, ""														// 비고
						, base.GetCookie("USRID")									// 시스템수정자ID
						, base.GetCookie("USRNM")									// 시스템수정자명
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
