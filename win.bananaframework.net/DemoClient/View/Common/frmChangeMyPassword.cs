using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.Common
{
	/// <summary>
	/// 비밀번호 변경
	/// </summary>
	public partial class frmChangeMyPassword : DemoClient.Controllers.BasePopupForm
	{
		#region frmChangeMyPassword : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public frmChangeMyPassword()
		{
			InitializeComponent();
		}
		#endregion

		#region KeyDown 이벤트
		private void _txtPWD01_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_txtPWD02.Focus();
			}
		}

		private void _txtPWD02_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_txtPWD03.Focus();
			}
		}

		private void _txtPWD03_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnChange.PerformClick();
			}
		}
		#endregion

		#region _btnChange_Click : 변경 버튼 클릭 이벤트
		/// <summary>
		/// 변경 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnChange_Click(object sender, EventArgs e)
		{
			try
			{
				if (_txtPWD01.Text.Trim() == "")
				{
					MessageBox.Show("기존 비밀번호를 입력하세요.");
					return;
				}
				else if (_txtPWD02.Text.Trim() == "")
				{
					MessageBox.Show("신규 비밀번호를 입력하세요.");
					return;
				}
				else if (_txtPWD03.Text.Trim() == "")
				{
					MessageBox.Show("비밀번호 확인을 입력하세요.");
					return;
				}

				// DB 처리

				MessageBox.Show("비밀번호가 변경되었습니다.");
				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
