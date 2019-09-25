using DemoClient.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace DemoClient.Controllers
{
	public class BaseForm : BANANA.Windows.BaseForm
	{
		public frmMain MainForm	= null;
		
		#region delegate 상태표시줄 라벨
		public delegate void DelegateToolStripStatusLabelUpdateCallback(ToolStripStatusLabel label, string _message);
		public void DelegateToolStripStatusLabelUpdate(ToolStripStatusLabel label, string _message)
		{
			if (label.GetCurrentParent() != null)
			{
				if (label.GetCurrentParent().InvokeRequired)
				{
					DelegateToolStripStatusLabelUpdateCallback d = new DelegateToolStripStatusLabelUpdateCallback(DelegateToolStripStatusLabelUpdate);
					label.GetCurrentParent().Invoke(d, new object[] { label, _message });
				}
				else
				{
					label.Text = _message;

					Application.DoEvents();
					System.Threading.Thread.Sleep(1);
				}
			}
		}
		#endregion

		#region delegate 상태표시줄 프로그레스바 증분
		public delegate void DelegateToolStripProgressBarUpdateCallback(ToolStripProgressBar _toolStripProgressBar);
		public void DelegateToolStripProgressBarUpdate(ToolStripProgressBar _toolStripProgressBar)
		{
			if (_toolStripProgressBar.GetCurrentParent() != null)
			{
				if (_toolStripProgressBar.GetCurrentParent().InvokeRequired)
				{
					DelegateToolStripProgressBarUpdateCallback d = new DelegateToolStripProgressBarUpdateCallback(DelegateToolStripProgressBarUpdate);
					try
					{
						_toolStripProgressBar.GetCurrentParent().Invoke(d, new object[] { _toolStripProgressBar });
					}
					catch
					{
					}
				}
				else
				{
					_toolStripProgressBar.Value++;

					Application.DoEvents();
					System.Threading.Thread.Sleep(1);
				}
			}
		}

		public delegate void DelegateToolStripProgressBarUpdateCallback2(ToolStripProgressBar _toolStripProgressBar, int value, int max);
		public void DelegateToolStripProgressBarUpdate2(ToolStripProgressBar _toolStripProgressBar, int value, int max)
		{
			if (_toolStripProgressBar.GetCurrentParent() != null)
			{
				if (_toolStripProgressBar.GetCurrentParent().InvokeRequired)
				{
					DelegateToolStripProgressBarUpdateCallback2 d = new DelegateToolStripProgressBarUpdateCallback2(DelegateToolStripProgressBarUpdate2);
					try
					{
						_toolStripProgressBar.GetCurrentParent().Invoke(d, new object[] { _toolStripProgressBar, value, max });
					}
					catch
					{
					}
				}
				else
				{
					_toolStripProgressBar.Maximum = max;
					_toolStripProgressBar.Value = value;

					Application.DoEvents();
					System.Threading.Thread.Sleep(1);
				}
			}
		}
		#endregion

		#region delegate 상태표시줄 프로그레스바 초기화
		public delegate void DelegateToolStripProgressBarResetCallback(ToolStripProgressBar _toolStripProgressBar);
		public void DelegateToolStripProgressBarReset(ToolStripProgressBar _toolStripProgressBar)
		{
			if (_toolStripProgressBar.GetCurrentParent() != null)
			{
				if (_toolStripProgressBar.GetCurrentParent().InvokeRequired)
				{
					DelegateToolStripProgressBarResetCallback d = new DelegateToolStripProgressBarResetCallback(DelegateToolStripProgressBarReset);
					_toolStripProgressBar.GetCurrentParent().Invoke(d, new object[] { _toolStripProgressBar });
				}
				else
				{
					_toolStripProgressBar.Value = 0;

					Application.DoEvents();
					System.Threading.Thread.Sleep(1);
				}
			}
		}
		#endregion

		#region BaseForm : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BaseForm()
		{
			// 화면을 모니터 중앙으로 설정
			this.StartPosition	= System.Windows.Forms.FormStartPosition.CenterScreen;
            
            // Create a new object, representing the German culture.  
            CultureInfo culture = CultureInfo.CreateSpecificCulture("ko-KO");

            // The following line provides localization for the application's user interface.  
            Thread.CurrentThread.CurrentUICulture = culture;

            // The following line provides localization for data formats.  
            Thread.CurrentThread.CurrentCulture = culture;

            // Set this culture as the default culture for all threads in this application.  
            // Note: The following properties are supported in the .NET Framework 4.5+ 
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
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

			// 화면 최대화
			if (!this.DesignMode)
			{
				this.WindowState	= System.Windows.Forms.FormWindowState.Maximized;
			}
			
			// frmMain에서 호출된 경우
			if (this.GetType() == typeof(frmMain))
			{
				MainForm	= (frmMain)this;
			}
			// 탭 페이지에서 호출된 경우
			else if (this.Parent.GetType() == typeof(System.Windows.Forms.TabPage))
			{
				MainForm	= (frmMain)this.Parent.Parent.Parent;
			}
			// 일반 폼에서 호출된 경우
			else
			{
				MainForm	= (frmMain)this.MdiParent;
			}
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

			// 그리드뷰
			var _controls	= this.Descendants<DemoClient.Controls.GridView>().OfType<DemoClient.Controls.GridView>().ToList();
			for (int i = 0; i < _controls.Count; i++)
			{
				_controls[i].Invoke((MethodInvoker)delegate()
				{
					_controls[i].Cursor		= Cursors.WaitCursor;
				});
			}
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

			// 그리드뷰
			var _controls	= this.Descendants<DemoClient.Controls.GridView>().OfType<DemoClient.Controls.GridView>().ToList();
			for (int i = 0; i < _controls.Count; i++)
			{
				_controls[i].Invoke((MethodInvoker)delegate()
				{
					_controls[i].Cursor		= Cursors.Default;
				});
			}
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
		public string GetDate(BANANA.Windows.Controls.DateTimePicker DateTimePicker)
		{
			return GetDate(DateTimePicker, "yyyy-MM-dd");
		}
		#endregion
		
		#region GetDate : 날짜형 반환
		/// <summary>
		/// 날짜형 반환
		/// </summary>
		/// <param name="DateTimePicker"></param>
		/// <param name="Format"></param>
		/// <returns></returns>
		public string GetDate(BANANA.Windows.Controls.DateTimePicker DateTimePicker, string Format)
		{
			if (DateTimePicker.Checked)
			{
				return DateTimePicker.Value.ToString(Format);
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

		#region DataTableYorN : Y/N 데이터테이블 생성
		/// <summary>
		/// Y/N 데이터테이블 생성
		/// </summary>
		/// <param name="BlankName"></param>
		/// <returns></returns>
		public DataTable DataTableYorN(string BlankName)
		{
			DataTable _retValue	= new DataTable();

			_retValue.Columns.Add("TOTAL_CODE");
			_retValue.Columns.Add("CODE_NAME");

			DataRow _dr			= _retValue.NewRow();
			_dr["TOTAL_CODE"]	= "";
			_dr["CODE_NAME"]	= BlankName;
			_retValue.Rows.Add(_dr);

			_dr					= _retValue.NewRow();
			_dr["TOTAL_CODE"]	= "Y";
			_dr["CODE_NAME"]	= "Y";
			_retValue.Rows.Add(_dr);

			_dr					= _retValue.NewRow();
			_dr["TOTAL_CODE"]	= "N";
			_dr["CODE_NAME"]	= "N";
			_retValue.Rows.Add(_dr);

			return _retValue;
		}
		#endregion

		#region GetValue : 키에 해당하는 값 반환
		/// <summary>
		/// 키에 해당하는 값 반환
		/// DB 문자열 파싱에 사용됨
		/// </summary>
		/// <param name="_val"></param>
		/// <param name="_key"></param>
		/// <returns></returns>
		public string GetValue(string _val, string _key)
		{
			string _retValue = string.Empty;

			int _intStrt = 0, _intEnd = 0;
			_intStrt	= _val.IndexOf(_key);
			_intEnd		= _val.IndexOf(";", _intStrt);
			_retValue	= _val.Substring(_intStrt + _key.Length + 1, _intEnd - _intStrt - (_key.Length + 1));

			return _retValue.Trim();
		}
		#endregion

		#region GetValue2 : 키에 해당하는 값 반환
		/// <summary>
		/// 키에 해당하는 값 반환
		/// DB 문자열 파싱에 사용됨
		/// 오라클은 형시이 달라서 따로 사용함
		/// </summary>
		/// <param name="_val"></param>
		/// <param name="_key"></param>
		/// <returns></returns>
		public string GetValue2(string _val, string _key)
		{
			string _retValue = string.Empty;

			int _intStrt = 0, _intEnd = 0;
			_intStrt	= _val.IndexOf(_key);
			_intEnd		= _val.IndexOf(")", _intStrt);
			_retValue	= _val.Substring(_intStrt + _key.Length + 1, _intEnd - _intStrt - (_key.Length + 1));

			return _retValue.Trim();
		}
		#endregion

		#region
		public bool isScreen = false;
		public bool isSearch = false;
		public bool isList = false;
		public bool isSave = false;
		public bool isDelete = false;
		public bool isPrint = false;
		public bool isExcel = false;
		public bool isNew = false;
		public bool isModify = false;
		public bool isAdd = false;
		public bool isApply = false;
		public bool isSend = false;
		public bool isNext = false;
		public bool isPrevious = false;
		public bool isOK = false;
		public bool isCancel = false;
		public bool isTop = false;
		public bool isBottom = false;
		public bool isLeft = false;
		public bool isRight = false;
		DataTable _dtButtonAuth = null;

		private void ButtonAuth()
		{
			if (!DesignMode)
			{
				_dtButtonAuth = base.GetDataTable(
					"WSP_MAIN_AUTH_R2"
					, this.Name
					, GetCookie("USRID")
				);

				foreach (DataRow dr in _dtButtonAuth.Rows)
				{
					if (dr["BTN_TYPE"] == null)
						continue;

					if (dr["BTN_TYPE"].ToString().Trim() == "Screen")
					{
						isScreen = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Search")
					{
						isSearch = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "List")
					{
						isList = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Save")
					{
						isSave = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Delete")
					{
						isDelete = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Print")
					{
						isPrint = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Excel")
					{
						isExcel = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "New")
					{
						isNew = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Modify")
					{
						isModify = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Add")
					{
						isAdd = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "isApply")
					{
						isApply = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Modify")
					{
						isModify = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Send")
					{
						isSend = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Next")
					{
						isNext = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Previous")
					{
						isPrevious = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "OK")
					{
						isOK = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Cancel")
					{
						isCancel = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Top")
					{
						isTop = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Bottom")
					{
						isBottom = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Left")
					{
						isLeft = true;
					}

					if (dr["BTN_TYPE"].ToString().Trim() == "Right")
					{
						isRight = true;
					}
				}

				List<BananaButton> buttons = new List<BananaButton>();
				ButtonAuth(this);
			}
		}

		private void ButtonAuth(System.Windows.Forms.Control control)
		{
			for (int i = 0; i < control.Controls.Count; i++)
			{
				if (control.Controls[i].HasChildren)
				{
					ButtonAuth(control.Controls[i]);
				}

				if (control.Controls[i] is BananaButton)
				{
					((BananaButton)control.Controls[i]).Enabled = false;

					for (int k = 0; k < _dtButtonAuth.Rows.Count; k++)
					{
						if (((BananaButton)control.Controls[i]).Tag.ToString() == _dtButtonAuth.Rows[k]["BTN_TYPE"].ToString().Trim())
						{
							((BananaButton)control.Controls[i]).Enabled = true;
							break;
						}
					}
				}
			}
		}
		#endregion
	}
}
