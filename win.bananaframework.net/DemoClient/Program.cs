using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient
{
	static class Program
	{
		#region Main : 메인 함수
		/// <summary>
		/// 메인 함수
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// 영문 오류 처리
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

			// 글로벌 오류 처리
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			Application.ThreadException += Application_ThreadException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			try
			{
				string _historyFileUrl	= string.Empty;
				if (args.Length > 0)
				{
					_historyFileUrl		= args[0];
				}
				
				RunApp(_historyFileUrl);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				Application.Exit();
			}
		}
		#endregion

		#region RemoveAttribute : 파일의 특정 속성 제거
		/// <summary>
		/// 파일의 특정 속성 제거
		/// </summary>
		/// <param name="attributes"></param>
		/// <param name="attributesToRemove"></param>
		/// <returns></returns>
		private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
		{
			return attributes & ~attributesToRemove;
		}
		#endregion

		#region RunApp : 비밀번호 체크 후, 응용 프로그램 실행
		/// <summary>
		/// 비밀번호 체크 후, 응용 프로그램 실행
		/// </summary>
		static void RunApp(string HistoryFileUrl)
		{
			try
			{
				try
				{
					AppManager.LiveUpdate _live = new AppManager.LiveUpdate();
					bool _userAction = _live.Update();
					if (!_userAction)
					{
						MessageBox.Show("사용자가 라이브 업데이트를 취소 하셨습니다.");
					}
				}
				catch (Exception err)
				{
					MessageBox.Show(err.Message);
				}
				View.Common.frmLogin _frmLogin = new View.Common.frmLogin();
				if (_frmLogin.ShowDialog() == DialogResult.OK)
				{
					Application.Run(new frmMain(HistoryFileUrl));
				}
				else
				{
					Application.Exit();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				Application.Exit();
			}
		}
		#endregion

		#region Application_ThreadException : 쓰레드 오류 처리
		/// <summary>
		/// 쓰레드 오류 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			BANANA.Windows.Logger.Error(e.Exception);
		}
		#endregion

		#region CurrentDomain_UnhandledException : 예기치 않은 오류 처리
		/// <summary>
		/// 예기치 않은 오류 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			//string error = string.Format("sender: {0}, ExceptionObject: {1}", sender, e.ExceptionObject);
			//Exception err = new Exception(error);
			Exception err = (Exception)e.ExceptionObject;
			BANANA.Windows.Logger.Error(err);
		}
		#endregion
	}
}
