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
	/// 제  목: 로그인 화면
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-10 06:57
	/// 설  명: 이용자의 로그인을 처리하는 화면입니다.
	/// </summary>
	public partial class frmLogin : DemoClient.Controllers.BasePopupForm
	{
		string chkSaveUsrID		= string.Empty;
		string savedUserID		= string.Empty;
		string savedCompanyCode	= string.Empty;

		#region frmLogin : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public frmLogin()
		{
			InitializeComponent();

			this.ShowInTaskbar	= true;
		}
		#endregion

		#region frmLogin_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmLogin_Load(object sender, EventArgs e)
		{
			try
			{
				//string _serverUrl = base.GetEncryptTripleDES("server=211.232.104.186;uid=sa;pwd=qewr1324!;database=PowerCash;MultipleActiveResultSets=True;");
				//string enc		= base.GetEncryptTripleDES("server=218.38.12.153;uid=custom_user;pwd=fhrmdlstlsrb**$@;database=PowerCash.BUSANCU;MultipleActiveResultSets=True;");
				//string dec = base.GetDecryptTripleDES("pJjdgJi4mugWIsVVoq+j/n/GynH7nJj/ikyerPN66fboBRDZaQZuq3NpamdIRz5geqLgiPIBblCbzRgsZIxkDWT2lEeXKC7V/qNizwKkCmmtrLjrfcx2ZfHl8uc4dO5UlhZhk4LiI/nKr/9BVEhbB1rzZZl/gQnyuzwmCa5qUis=");
				//string enc = base.GetEncryptTripleDES("server=211.232.104.181;uid=sa;pwd=qewr1324!;database=PowerCash;MultipleActiveResultSets=True;");
				

				chkSaveUsrID		= base.GetCookie("ChkSaveUsrID");
				savedUserID			= base.GetCookie("SavedUserID");
				savedCompanyCode	= base.GetCookie("SavedCompanyCode");

				DataSet _dsCompany	= base.GetDataSet("PCSP_LoadCompany"
					, savedUserID
					);
				base.SetListItem(_cmbCompany, _dsCompany.Tables[0], "COMPANY_CD", "COMPANY_NM");
				
				if (!string.IsNullOrEmpty(chkSaveUsrID))
				{
					if (Convert.ToBoolean(chkSaveUsrID))
					{
						_cmbCompany.SelectedValue	= savedCompanyCode;
						_txtUSRID.Text				= savedUserID;
						_chkSaveUsrID.Checked		= true;
					}
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				this.Close();
			}
		}
		#endregion

		#region frmLogin_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmLogin_Shown(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(savedUserID))
			{
				_txtPWD.Focus();
			}
		}
		#endregion

		#region EnableControls : 컨트롤 활성화/비활성화
		/// <summary>
		/// 컨트롤 활성화/비활성화
		/// </summary>
		/// <param name="_bTrue"></param>
		void EnableControls(bool _bTrue)
		{
			_cmbCompany.Enabled		= _bTrue;
			_txtUSRID.Enabled		= _bTrue;
			_txtPWD.Enabled			= _bTrue;
			_chkSaveUsrID.Enabled	= _bTrue;
			_btnLogin.Enabled		= _bTrue;
		}
		#endregion

		#region _btnLogin_Click : 로그인 버튼 클릭 이벤트
		/// <summary>
		/// 로그인 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnLogin_Click(object sender, EventArgs e)
		{
			//EnableControls(false);
			
			try
			{
				if (_txtUSRID.Text.Trim() == "")
				{
					MessageBox.Show("아이디를 입력하세요.");
					_txtUSRID.Focus();
					return;
				}
				else if (_txtPWD.Text.Trim() == "")
				{
					MessageBox.Show("비밀번호를 입력하세요.");
					_txtPWD.Focus();
					return;
				}
				else if (_cmbCompany.SelectedValue == null)
				{
					// 원래 이러한 경우가 발생하면 안 되지만, 회사를 삭제한 경우 쿠키값 하고 맞지 않아서 간혹 발생할 수가 있다.
					MessageBox.Show("회사를 선택하세요.");
					_cmbCompany.Focus();
					return;
				}

				// 로그인 확인
				DataTable _dtLogin		= base.GetDataTable("PCSP_Login"
					, _cmbCompany.SelectedValue
					, _txtUSRID.Text
					);

				// 비밀번호 비교
				if (base.GetDecryptTripleDES(_dtLogin.Rows[0]["PWD"].ToString()) != _txtPWD.Text)
				{
					MessageBox.Show("비밀번호가 일치하지 않습니다.");
					_txtPWD.Focus();
					base.ExecuteNonQuery("PCSP_BAS0200_U2"
						, _txtUSRID.Text
						);
					return;
				}

				// 아이디 저장은 로그인이 성공하였을 때 처리한다.
				if (_chkSaveUsrID.Checked)
				{
					base.SetCookie("ChkSaveUsrID", "True");
					base.SetCookie("SavedUserID", _txtUSRID.Text);
					base.SetCookie("SavedCompanyCode", _cmbCompany.SelectedValue.ToString());
				}
				else
				{
					base.SetCookie("ChkSaveUsrID", "False");
					base.SetCookie("SavedUserID", "");
					base.SetCookie("SavedCompanyCode", "");
				}

				// 회사코드 및 아이디 저장
				base.SetCookie("USRID", _txtUSRID.Text);
				base.SetCookie("USRNM", _dtLogin.Rows[0]["USRNM"].ToString());
				base.SetCookie("DEPT_CD", _dtLogin.Rows[0]["DEPT_CD"].ToString());
				base.SetCookie("COMPANY_CD", _cmbCompany.SelectedValue.ToString());
				
				// OK 반환
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				//EnableControls(true);
			}
		}
		#endregion

		#region 엔터키 이벤트
		/// <summary>
		/// 아이디 엔터키
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtUSRID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_txtPWD.Focus();
			}
		}

		/// <summary>
		/// 비밀번호 엔터키
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtUSRPWD_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnLogin.PerformClick();
			}
		}
		#endregion

		#region _btnClose_Click : 닫기 버튼 이벤트
		/// <summary>
		/// 닫기 버튼 이벤트
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
