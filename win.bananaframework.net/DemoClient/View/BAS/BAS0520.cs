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
	/// 제  목: 상세코드등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-19 06:51
	/// 설  명: 상세코드를 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0520 : DemoClient.Controllers.BasePopupForm
	{
		public string MAIN_CODE { get; set; }

		#region BAS0520 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0520()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0520_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0520_Load(object sender, EventArgs e)
		{
			try
			{
				_txtMAIN_CODE.Text		= this.MAIN_CODE;
				DataTable _dt			= base.GetDataTable("PCSP_BAS0520_R1"
					, this.MAIN_CODE
					);
				_txtORDERBY.Text		= _dt.Rows[0]["ORDERBY"].ToString();
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
				if (_txtCODE_NAME.Text == "")
				{
					MessageBox.Show("코드명은 필수 입력 사항입니다.");
					_txtCODE_NAME.Focus();
					return;
				}

				base.ExecuteNonQuery("PCSP_BAS0520_C1"
					, _txtMAIN_CODE.Text					// 메인코드
					, _txtCODE_NAME.Text					// 코드명
					, _rbDISPLAYY.Checked ? true : false	// 사용여부
					, _txtORDERBY.Text						// 순서
					, _txtBIGO1.Text						// 비고1
					, _txtBIGO2.Text						// 비고2
					, _txtBIGO3.Text						// 비고3
					, base.GetDecimal(_txtBIGO4)			// 비고4
					, base.GetDecimal(_txtBIGO5)			// 비고5
					, base.GetDecimal(_txtBIGO6)			// 비고6
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				MessageBox.Show("신규 상세코드를 등록하였습니다.");
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
