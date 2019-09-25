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
	/// 제  목: 메인코드등록
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-19 06:51
	/// 설  명: 메인코드를 등록하는 화면입니다.
	/// </summary>
	public partial class BAS0510 : DemoClient.Controllers.BasePopupForm
	{
		#region BAS0510 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0510()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0510_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0510_Load(object sender, EventArgs e)
		{
			try
			{
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
				if (_txtMAIN_CODE.Text == "")
				{
					MessageBox.Show("메인코드는 필수 입력 사항입니다.");
					_txtMAIN_CODE.Focus();
					return;
				}
				else if (_txtCODE_NAME.Text == "")
				{
					MessageBox.Show("코드명은 필수 입력 사항입니다.");
					_txtCODE_NAME.Focus();
					return;
				}

				base.ExecuteNonQuery("PCSP_BAS0510_C1"
					, _txtMAIN_CODE.Text
					, _txtCODE_NAME.Text
					, base.GetCookie("USRID")
					, base.GetCookie("USRNM")
					);

				MessageBox.Show("신규 메인코드를 등록하였습니다.");
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
