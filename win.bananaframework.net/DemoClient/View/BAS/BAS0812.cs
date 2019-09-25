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
	/// 제  목: 수수료율등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-16 06:24
	/// 설  명: 가맹점의 매입카드 수수료율을 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0812 : DemoClient.Controllers.BasePopupForm
	{
		public string STR_CD { get; set; }

		public string STR_NM { get; set; }

		#region BAS0812 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0812()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0812_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0812_Load(object sender, EventArgs e)
		{
		}
		#endregion

		#region BAS0812_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0812_Shown(object sender, EventArgs e)
		{
			_txtFEE_CHK_BC.Focus();
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
				base.BeginTransaction();

				// 마스터 등록
				DataTable _dt		= base.GetDataTable("PCSP_BAS0810_C1"
					, this.STR_CD					// 가맹점코드
					, base.GetDate(_dtpBY_APP_DT)	// 적용시작일
					, _txtMEMO.Text					// 메모
					, ""							// 비고
					, base.GetCookie("USRID")		// 시스템등록자ID
					, base.GetCookie("USRNM")		// 시스템등록자명
					);
					
					
				// 상세 등록(비씨카드-A08001)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08001"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_BC)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_BC)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_BC)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_BC)		// 입금주기
					, _rbBY_USE_Y_BC.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(롯데카드-A08002)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08002"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_LT)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_LT)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_LT)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_LT)		// 입금주기
					, _rbBY_USE_Y_LT.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(삼성카드-A08003)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08003"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_SS)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_SS)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_SS)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_SS)		// 입금주기
					, _rbBY_USE_Y_SS.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(신한카드-A08004)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08004"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_SH)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_SH)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_SH)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_SH)		// 입금주기
					, _rbBY_USE_Y_SH.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(현대카드-A08005)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08005"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_HD)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_HD)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_HD)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_HD)		// 입금주기
					, _rbBY_USE_Y_HD.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(KB국민카드-A08006)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08006"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_KB)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_KB)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_KB)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_KB)		// 입금주기
					, _rbBY_USE_Y_KB.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(하나SK카드-A08007)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08007"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_SK)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_SK)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_SK)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_SK)		// 입금주기
					, _rbBY_USE_Y_SK.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(NH농협은행-A08009)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08009"								// 매입카드사코드
					, base.GetDecimal(_txtFEE_CHK_NH)		// 체크카드수수료율
					, base.GetDecimal(_txtFEE_CRD_NH)		// 신용카드수수료율
					, base.GetDecimal(_txtFEE_OVR_NH)		// 해외카드수수료율
					, base.GetDecimal(_txtBY_DAYS_NH)		// 입금주기
					, _rbBY_USE_Y_NH.Checked ? "Y" : "N"	// 매입여부
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				// 상세 등록(외환카드-A08010)
				base.ExecuteNonQuery("PCSP_BAS0810_C2"
					, Convert.ToInt32(_dt.Rows[0]["IDX"].ToString())
					, "A08010"								// 매입카드사코드
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

				MessageBox.Show("수수료율을 등록 하였습니다.");
				//MessageBox.Show("수수료율을 등록 하였습니다.\r\n카드사수수료를 변경하게 되면 출금승인 전의 데이터가 변경 될 수도 있습니다.");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				base.RollbackTransaction();
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
