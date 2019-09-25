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
	/// 제  목: 통화내역추가
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-05 21:01
	/// 설  명: 가맹점의 통화내역을 추가하는 화면입니다.
	/// </summary>
	public partial class BAS0803 : DemoClient.Controllers.BasePopupForm
	{
		public int IDX { get; set; }
		public string STR_CD { get; set; }

		#region BAS0803 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0803()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0803_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0803_Shown(object sender, EventArgs e)
		{
			try
			{
				// 등록
				if (this.IDX == 0)
				{
					timer1.Enabled			= true;
					_dtpCALL_DT_STRT.Value	= System.DateTime.Now;
				}
				// 수정
				else
				{
					DataTable _dt	= base.GetDataTable("PCSP_BAS0800_R6"
						, this.IDX
						);
						
					_dtpCALL_DT_STRT.Value	= (DateTime)_dt.Rows[0]["CALL_DT_STRT"];
					_dtpCALL_DT_END.Value	= (DateTime)_dt.Rows[0]["CALL_DT_END"];
					_txtCALL_NM.Text		= _dt.Rows[0]["CALL_NM"].ToString();
					_txtMEMO.Text			= _dt.Rows[0]["MEMO"].ToString();
				}

				_txtCALL_NM.Focus();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region timer1_Tick : 종료시각 업데이트
		/// <summary>
		/// 종료시각 업데이트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			_dtpCALL_DT_END.Value	= System.DateTime.Now;
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
				timer1.Enabled			= false;

				// 등록
				if (this.IDX == 0)
				{
					base.ExecuteNonQuery("PCSP_BAS0803_C1"
						, this.STR_CD												// 가맹점코드
						, _txtCALL_NM.Text											// 통화상대명
						, _dtpCALL_DT_STRT.Value.ToString("yyyy-MM-dd HH:mm:ss")	// 통화시작시각
						, _dtpCALL_DT_END.Value.ToString("yyyy-MM-dd HH:mm:ss")		// 통화종료시각
						, _txtMEMO.Text												// 메모
						, ""														// 비고
						, base.GetCookie("USRID")									// 시스템수정자ID
						, base.GetCookie("USRNM")									// 시스템수정자명
						);
				}
				// 수정
				else
				{
					base.ExecuteNonQuery("PCSP_BAS0803_U1"
						, this.IDX													// 일련번호
						, _txtCALL_NM.Text											// 통화상대명
						, _dtpCALL_DT_STRT.Value.ToString("yyyy-MM-dd HH:mm:ss")	// 통화시작시각
						, _dtpCALL_DT_END.Value.ToString("yyyy-MM-dd HH:mm:ss")		// 통화종료시각
						, _txtMEMO.Text												// 메모
						, ""														// 비고
						, base.GetCookie("USRID")									// 시스템수정자ID
						, base.GetCookie("USRNM")									// 시스템수정자명
						);
				}

				this.DialogResult	= System.Windows.Forms.DialogResult.OK;
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
