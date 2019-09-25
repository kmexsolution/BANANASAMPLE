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
	/// 제  목: 가맹점.보증예치금 예외기간추가
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-12 22:34
	/// 설  명: 가맹점의 보증예치금의  예외기간을 추가하는 화면입니다.
	/// </summary>
	public partial class BAS0827 : DemoClient.Controllers.BasePopupForm
	{
		public int IDX { get; set; }
		public DateTime EXCPT_DT_STRT { get; set; }
		public DateTime EXCPT_DT_END { get; set; }

		#region BAS0827 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0827()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0827_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0827_Load(object sender, EventArgs e)
		{
			if (IDX == 0)
			{
				_dtpEXCPT_DT_STRT.Checked	= false;
				_dtpEXCPT_DT_END.Checked	= false;
			}
			else
			{
				_dtpEXCPT_DT_STRT.Value		= EXCPT_DT_STRT;
				_dtpEXCPT_DT_END.Value		= EXCPT_DT_END;
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
				if (_dtpEXCPT_DT_STRT.Value > _dtpEXCPT_DT_END.Value)
				{
					MessageBox.Show("시작일이 종료일보다 늦을 수는 없습니다.");
					return;
				}

				// 등록
				if (IDX == 0)
				{
					base.ExecuteNonQuery("PCSP_BAS0827_C1"
						, STR_CD.Text						// 가맹점코드
						, base.GetDate(_dtpEXCPT_DT_STRT)	// 예외시작일
						, base.GetDate(_dtpEXCPT_DT_END)	// 예외종료일
						, MEMO.Text							// 메모
						, ""								// 비고
						, base.GetCookie("USRID")			// 시스템등록자ID
						, base.GetCookie("USRNM")			// 시스템등록자명
						);

					MessageBox.Show("예외기간을 등록 하였습니다.");
				}
				// 수정
				else
				{
					base.ExecuteNonQuery("PCSP_BAS0827_U1"
						, IDX								// 일련번호
						, base.GetDate(_dtpEXCPT_DT_STRT)	// 예외시작일
						, base.GetDate(_dtpEXCPT_DT_END)	// 예외종료일
						, MEMO.Text							// 메모
						, ""								// 비고
						, base.GetCookie("USRID")			// 시스템등록자ID
						, base.GetCookie("USRNM")			// 시스템등록자명
						);

					MessageBox.Show("예외기간을 수정 하였습니다.");
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

		#region _btnClose_Click : 종료 버튼 클릭 이벤트
		/// <summary>
		/// 종료 버튼 클릭 이벤트
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
