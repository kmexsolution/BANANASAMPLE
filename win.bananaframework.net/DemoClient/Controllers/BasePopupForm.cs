using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient.Controllers
{
	public class BasePopupForm : BANANA.Windows.BaseForm
	{
		public frmMain MainForm	= null;

		#region BaseForm : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BasePopupForm()
		{
			// 화면을 모니터 중앙으로 설정
			this.StartPosition		= System.Windows.Forms.FormStartPosition.CenterScreen;

			// 
			this.FormBorderStyle	= System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox		= false;
			this.MinimizeBox		= false;

			// 작업표시줄에서 숨김
			this.ShowInTaskbar		= false;
		}
		#endregion

		#region OnShown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="e"></param>
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			// 메인폼 지정
			MainForm	= (frmMain)this.MdiParent;
		}
		#endregion

		#region SetWaitCursor : 커서 기다림 처리
		/// <summary>
		/// 커서 기다림 처리
		/// </summary>
		public void SetWaitCursor()
		{
			this.Invoke((MethodInvoker)delegate()
			{
				this.Cursor		= Cursors.WaitCursor;
			});
		}
		#endregion

		#region RestoreCursor : 기본 커서 복원
		/// <summary>
		/// 기본 커서 복원
		/// </summary>
		public void RestoreCursor()
		{
			this.Invoke((MethodInvoker)delegate()
			{
				this.Cursor		= Cursors.Default;
			});
		}
		#endregion

		#region SendGmail : Gmail통해서 메일 전송
		/// <summary>
		/// Gmail통해서 메일 전송
		/// </summary>
		/// <param name="Sender"></param>
		/// <param name="Receiver"></param>
		/// <param name="Subject"></param>
		/// <param name="Content"></param>
		public void SendGmail(string Sender, string Receiver, string Subject, string Content)
		{
			try
			{
				var fromAddress			= new MailAddress(Sender, "AppManager");
				var toAddress			= new MailAddress(Receiver, "Joshua Son");
				string fromPassword		= base.GetDecryptTripleDES("xxxxxxxxxxxxxxxxxxxxxxxx");

				var smtp = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(toAddress.Address, fromPassword)
				};
				using (var message = new MailMessage(fromAddress, toAddress)
				{
					Subject = Subject,
					Body = Content,
					IsBodyHtml	= true
				})
				{
					smtp.Send(message);
				}
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
			}
		}
		#endregion

		#region ValidateFormat : ####-#### 형태의 문자열 검증
		/// <summary>
		/// ####-#### 형태의 문자열 검증
		/// </summary>
		/// <param name="_textBox"></param>
		/// <param name="_format"></param>
		/// <returns></returns>
		public bool ValidateFormat(BANANA.Windows.Controls.TextBox _textBox, string _format, out string _result)
		{
			int count	= _format.Count(f => f == '#');
				
			if (_textBox.Text.Trim() != "")
			{
				string input = _textBox.Text.Trim().Replace("-", "");
				if (input.Length != count)
				{
					MessageBox.Show("길이가 맞지 않습니다.");
					_textBox.Focus();
					_textBox.Select();

					_result		= "";
					return false;
				}
				long n;
				bool isNumeric = long.TryParse(input, out n);
				if (!isNumeric)
				{
					MessageBox.Show("형식이 맞지 않습니다.");
					_textBox.Focus();
					_textBox.Select();

					_result		= "";
					return false;
				}

				_result	= string.Format(_format, n);
				return true;
			}

			_result		= "";
			return true;
		}
		#endregion

		#region GetInteger : 정수형 반환
		/// <summary>
		/// 정수형 반환
		/// </summary>
		/// <param name="_textBox"></param>
		/// <returns></returns>
		public int? GetInteger(BANANA.Windows.Controls.TextBox _textBox)
		{
			if (_textBox.Text.Trim() == "")
			{
				return null;
			}
			else
			{
				return Convert.ToInt32(_textBox.Text.Trim());
			}
		}
		#endregion

		#region GetDecimal : 소수형 반환
		/// <summary>
		/// 소수형 반환
		/// </summary>
		/// <param name="_textBox"></param>
		/// <returns></returns>
		public decimal? GetDecimal(BANANA.Windows.Controls.TextBox _textBox)
		{
			if (_textBox.Text.Trim() == "")
			{
				return null;
			}
			else
			{
				return Convert.ToDecimal(_textBox.Text.Trim());
			}
		}
		#endregion

		#region GetString : 문자형 반환
		/// <summary>
		/// 문자형 반환
		/// </summary>
		/// <param name="_comboBox"></param>
		/// <returns></returns>
		public string GetString(BANANA.Windows.Controls.ComboBox _comboBox)
		{
			if (_comboBox.SelectedValue == null)
			{
				return null;
			}
			else
			{
				if (_comboBox.SelectedValue.ToString() == "")
				{
					return null;
				}
				else if (_comboBox.SelectedValue.ToString() == null)
				{
					return null;
				}
				else
				{
					return _comboBox.SelectedValue.ToString();
				}
			}
		}
		#endregion

		#region GetDate : 날짜형 반환
		/// <summary>
		/// 날짜형 반환
		/// </summary>
		/// <param name="_dateTimePicker"></param>
		/// <returns></returns>
		public string GetDate(BANANA.Windows.Controls.DateTimePicker _dateTimePicker)
		{
			if (_dateTimePicker.Checked)
			{
				return _dateTimePicker.Value.ToString("yyyy-MM-dd");
			}
			else
			{
				return "";
			}
		}
		#endregion

		#region DetectCardRateTextBox : 매입카드 수수료율 텍스트박스 활성화/비활성화 처리
		/// <summary>
		/// 매입카드 수수료율 텍스트박스 활성화/비활성화 처리
		/// </summary>
		/// <param name="_textBox1"></param>
		/// <param name="_textBox2"></param>
		/// <param name="_textBox3"></param>
		/// <param name="_textBox4"></param>
		/// <param name="_radioButton1"></param>
		/// <param name="_radioButton2"></param>
		public void DetectCardRateTextBox(BANANA.Windows.Controls.TextBox _textBox1, BANANA.Windows.Controls.TextBox _textBox2, BANANA.Windows.Controls.TextBox _textBox3, BANANA.Windows.Controls.TextBox _textBox4, BANANA.Windows.Controls.RadioButton _radioButton1, BANANA.Windows.Controls.RadioButton _radioButton2)
		{
			if (_radioButton1.Checked)
			{
				_textBox1.ReadOnly	= false;
				_textBox2.ReadOnly	= false;
				_textBox3.ReadOnly	= false;
				_textBox4.ReadOnly	= false;
			}
			else
			{
				_textBox1.ReadOnly	= true;
				_textBox2.ReadOnly	= true;
				_textBox3.ReadOnly	= true;
				_textBox4.ReadOnly	= true;
			}
		}
		#endregion
	}
}
