using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClient
{
	public partial class frmMain : Controllers.BaseForm
	{
		string _historyFileUrl		= string.Empty;

		#region #About AppManager
		AppManager.Notice _notice;
		AppManager.Feedback _feed;
		AppManager.Usage _usage;
		AppManager.LiveUpdate _live;
		AppManager.Pay _pay;

		// 디자이너 Dispose에 _usage.ShutDown(); 처리 필요
		#region SetNoticeUnread : 읽지않은 공지사항의 수 설정
		/// <summary>
		/// 읽지않은 공지사항의 수 설정
		/// </summary>
		void SetNoticeUnread()
		{
			try
			{
				_notice = new AppManager.Notice();
				int unread	= _notice.UnreadCount;
				if (unread > 0)
				{
					statusStrip.Invoke((MethodInvoker)delegate()
					{
						TsslNotice.Text = string.Format("공지: {0:N0}건", unread);
					});
				}
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
			}
		}
		#endregion

		#region SetFeedbackUnread : 읽지않은 피드백의 수 설정
		/// <summary>
		/// 읽지않은 피드백의 수 설정
		/// </summary>
		void SetFeedbackUnread()
		{
			try
			{
				_feed = new AppManager.Feedback();
				int unread = _feed.UnreadCount;
				if (unread > 0)
				{
					statusStrip.Invoke((MethodInvoker)delegate()
					{
						TsslFeedback.Text = string.Format("의견: {0:N0}건", unread);
					});
				}
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
			}
		}
		#endregion

		#region EnableMenus : 메뉴 활성화/비활성화 처리
		/// <summary>
		/// 메뉴 활성화/비활성화 처리
		/// </summary>
		/// <param name="bTrue">활성화/비활성화 여부</param>
		void EnableMenus(bool bTrue)
		{
			기초정보ToolStripMenuItem.Enabled	= bTrue;
			출금관리ToolStripMenuItem.Enabled	= bTrue;
			정산관리ToolStripMenuItem.Enabled	= bTrue;
			상환관리ToolStripMenuItem.Enabled	= bTrue;
			대출관리ToolStripMenuItem.Enabled	= bTrue;
			채권관리ToolStripMenuItem.Enabled	= bTrue;
			리스크관리ToolStripMenuItem.Enabled	= bTrue;

			_tscbCompany.Enabled				= bTrue;
			_tsbAffiliate.Enabled				= bTrue;
			_tsbSalesRowData.Enabled			= bTrue;
			_tsbIncomingAmount.Enabled			= bTrue;
			_tsbConfig.Enabled					= bTrue;
		}
		#endregion
		#endregion

		#region #About Clock
		System.Timers.Timer _tmrClock		= new System.Timers.Timer();

		#region _tmrClock_Elapsed : 시계 틱 이벤트
		/// <summary>
		/// 시계 틱 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void _tmrClock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			base.DelegateToolStripStatusLabelUpdate(_tsslClock, System.DateTime.Now.ToString("yyyy-MM-dd (ddd) HH:mm:ss"));
		}
		#endregion
		#endregion

		#region #About StopWatch
		System.Timers.Timer _tmrStopWatch		= new System.Timers.Timer();
		System.Diagnostics.Stopwatch stopWatch	= new System.Diagnostics.Stopwatch();

		#region _tmrStopWatch_Elapsed : 스탑와치 타이머 틱 이벤트
		/// <summary>
		/// 스탑와치 타이머 틱 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void _tmrStopWatch_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			string stopwatch	= string.Format("{0:00}:{1:00}:{2:00}.{3:000}"
				, stopWatch.Elapsed.Hours
				, stopWatch.Elapsed.Minutes
				, stopWatch.Elapsed.Seconds
				, stopWatch.Elapsed.Milliseconds
				);
			base.DelegateToolStripStatusLabelUpdate(_tsslStopwatch, stopwatch);
		}
		#endregion

		#region StartStopWatch : 스탑와치 시작
		/// <summary>
		/// 스탑와치 시작
		/// </summary>
		public void StartStopWatch()
		{
			_tmrStopWatch.Enabled	= true;
			stopWatch.Reset();
			stopWatch.Start();
		}
		#endregion

		#region StopStopWatch : 스탑와치 종료
		/// <summary>
		/// 스탑와치 종료
		/// </summary>
		public void StopStopWatch()
		{
			stopWatch.Stop();
			_tmrStopWatch.Enabled	= false;
		}
		#endregion

		#region StopWatchElapsed : 스탑와치 결과 반환
		/// <summary>
		/// 스탑와치 결과 반환
		/// </summary>
		public string StopWatchElapsedTime
		{
			get { return _tsslStopwatch.Text; }
		}
		#endregion
		#endregion

		#region #About StatusBar
		/// <summary>
		/// 작업 표시줄에 메시지 표시
		/// </summary>
		/// <param name="Message"></param>
		public void UpdateStatus(string Message)
		{
			base.DelegateToolStripStatusLabelUpdate(TsslStatus, Message);
		}
		#endregion

		#region Properties
		public DateTime ValidDate	{ get; set; }
		public int ValidCount		{ get; set; }
		#endregion

		#region frmMain : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public frmMain()
		{
			InitializeComponent();
		}
		
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public frmMain(string HistoryFileUrl)
		{
			InitializeComponent();

			// 업데이트 내역 파일 경로 지정
			_historyFileUrl		= HistoryFileUrl;
		}
		#endregion

		#region frmMain_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmMain_Load(object sender, EventArgs e)
		{
			try
			{
                기초정보ToolStripMenuItem.Visible = false;
                출금관리ToolStripMenuItem.Visible = false;
                정산관리ToolStripMenuItem.Visible = false;
                상환관리ToolStripMenuItem.Visible = false;
                대출관리ToolStripMenuItem.Visible = false;
                채권관리ToolStripMenuItem.Visible = false;
                리스크관리ToolStripMenuItem.Visible = false;
                toolStripWindow.Visible = false;
                도움말ToolStripMenuItem.Visible = false;


                this.Text			+= string.Format(" v{0}", this.GetAppVersion());

				//string _serverUrl = base.GetEncryptTripleDES("server=210.180.118.108;uid=sa;pwd=gam6644**;database=PowerCash;MultipleActiveResultSets=True;");
				string _dec = base.GetDecryptTripleDES("pJjdgJi4muiJh9d00Ns1/iRZKRWabIeSWNYEo2eZrS+EJ8jp0Jzb17VQSuI5GMGRl673v0f95HnXEqB1v5q5RgveyOS2+t3AnVmY9b26PIauP1lpASbJ9qbgLpJDX4TW2bE6PkzDz2xGfflGGcu3Cw==");
				//string _dec2 = base.GetDecryptTripleDES("EJUQo5WhTsw+030/Au5P6shrTGSg786W4mP2b4+yXR4cWbDnTjSxzg==");

				_tbMain.SizeChanged += _tbMain_SizeChanged;
				
				// 사용하지 않는 메뉴 제거(2016-07-26 by 한인수)
				_tsbAffiliate.Visible			= false;
				_tsbWithdrawRowData.Visible		= false;
				_tsbSalesRowData.Visible		= false;
				_tsbIncomingAmount.Visible		= false;
				_tsbCalMagam.Visible			= false;
				_tsbReturnMagam.Visible			= false;
				_tsbConfig.Visible				= false;

				// ComboBox에 회사정보 바인딩
				LoadCompany();

				// DB 정보 조회
				List<BANANA.Common.Configuration.Connection> config = new List<BANANA.Common.Configuration.Connection>();
				foreach (BANANA.Common.Configuration.Connection _connConfig in BANANA.Common.WinConfiguration.Settings.Connections)
				{
					config.Add(_connConfig);
				}
				// Priority 순으로 정렬
				var newList			= config.OrderBy(x => x.Priority).ToList();
				string conn			= base.GetDecryptTripleDES(newList[0].ConnectionString);
				string prov			= newList[0].ProviderName;
				string serverType	= string.Empty;
				string serverInfo	= string.Empty;
				switch (prov)
				{
					case "System.Data.SqlClient":
						serverType	= "SQL Server";
						serverInfo	= string.Format("{0}({1})"
							, base.GetValue(conn, "server")
							, base.GetValue(conn, "database")
							);
						break;
					case "Oracle.DataAccess":
						serverType	= "Oracle";
						serverInfo	= string.Format("{0}({1})"
							, base.GetValue2(conn, "HOST")
							, base.GetValue2(conn, "SERVICE_NAME")
							);
						break;
					case "SQLite":
						serverType	= "SQLite";
						serverInfo	= base.GetValue(conn, "Data Source");
						break;
					case "Mdb":
						serverType	= "Mdb";
						serverInfo	= base.GetValue(conn, "Data Source");
						break;
				}
				_tsslDB.Text	= string.Format("{0}: {1}", serverType, serverInfo);

				Menu_Auth();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
				this.Close();
			}

			// 핫키 설정===========================================================================================================================================================================================
			this.KeyPreview = true;
			this.KeyDown	+= frmMain_KeyDown;
		}

		void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			// 1024 * 768 해상도 조정
			if (e.Control && e.Shift && e.KeyCode == Keys.W)		// Ctrl + Shift + W
			{
				this.WindowState	= FormWindowState.Normal;
				this.Size			= new Size(1024, 768);
				this.Left			= 0;
				this.Top			= 0;

				e.SuppressKeyPress = true;  // stops bing! also sets handeled which stop event bubbling
			}
			else if (e.Control && e.Shift && e.KeyCode == Keys.T)	// Ctrl + Shift + T
			{
				_Test.Form1 _form	= new _Test.Form1();
				_form.ShowDialog();
			}
		}
		#endregion

		#region frmMain_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmMain_Shown(object sender, EventArgs e)
		{
			try
			{
				#region #About Clock
				_tmrClock.Enabled		= true;
				_tmrClock.Interval		= 500;
				_tmrClock.AutoReset		= true;
				_tmrClock.Elapsed		+= _tmrClock_Elapsed;
				base.DelegateToolStripStatusLabelUpdate(_tsslClock, System.DateTime.Now.ToString("yyyy-MM-dd (ddd) HH:mm:ss"));
				#endregion

				#region #About StopWatch
				_tmrStopWatch.Enabled		= true;
				_tmrStopWatch.Interval		= 100;
				_tmrStopWatch.AutoReset		= true;
				_tmrStopWatch.Elapsed		+= _tmrStopWatch_Elapsed;
				#endregion
				
				#region #About AppManager
#if DEBUG
#else
				// 업데이트 내역 보기 및 컴퓨터 셋업 및 사용로그
				try
				{
					// 업데이트 내역 확인
					 _live		= new AppManager.LiveUpdate();
					if (!string.IsNullOrEmpty(_historyFileUrl))
					{
						_live.ShowHistory(_historyFileUrl);
					}

					// 사용로그 기록
					_usage = new AppManager.Usage();
					_usage.StartLog();	// 사용로그를 남긴다.
					_usage.StartPing();	// Ping 시작
				}
				catch (Exception err)
				{
					string msg = string.Format("AppManager 실행 중 오류가 발생하였습니다.\r\n\r\n오류 메시지: {0}", err.Message);
					base.Error(new ArgumentException(msg));
				}
#endif
				#endregion

				// 매년 연말에 잊어버릴 수도 있으니 내년 공휴일 등록 팝업창을 페이지 로드 할 때 띄우자
				//if (DateTime.Now.ToString("MM") == "12")
				//{
				//	if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 15 || Convert.ToInt32(DateTime.Now.ToString("dd")) <= 31)
				//	{
				//		if (MessageBox.Show(string.Format("{0}년 공휴일을 등록하셔야 합니다.\r\n공휴일등록 화면으로 바로가시겠습니까?", DateTime.Now.AddYears(1).ToString("yyyy")), "공휴일 등록", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				//		{
				//			View.BAS.BAS0600 _childForm = new View.BAS.BAS0600();
				//			AddToWindow(_childForm);
				//		}
				//	}
				//}
			}
			catch (Exception err)
			{
				string msg = string.Format("프로그램 시작 중 오류가 발생하였습니다.\r\n프로그램을 시작하지 못 하고 종료합니다.\r\n\r\n오류 메시지: {0}", err.Message);
				MessageBox.Show(msg);
				this.Close();
			}
		}
		#endregion

		#region Menu_Auth : 그룹별 화면 권한 처리 부분
		/// <summary>
		/// 그룹별 화면 권한 처리 부분
		/// </summary>
		private void Menu_Auth()
		{
			try
			{
				DataTable dt = base.GetDataTable(
					"PCSP_USER_ROLL_R1"
					, base.GetCookie("DEPT_CD")
					);

				for (int i = 0; i < menuStrip.Items.Count; i++)
				{
					if (menuStrip.Items[i].Tag == null) 
						continue;

					menuStrip.Items[i].Visible = CompareToPID(menuStrip.Items[i].Tag.ToString().Trim(), dt);


					ToolStripMenuItem menuItem = (ToolStripMenuItem)menuStrip.Items[i];
					if (!menuItem.HasDropDownItems)
					{
						continue;
					}
					else
					{
						for (int j = 0; j < menuItem.DropDownItems.Count; j++)
						{
							if (menuItem.DropDownItems[j].Tag == null)
								continue;
							menuItem.DropDownItems[j].Visible = CompareToPID(menuItem.DropDownItems[j].Tag.ToString().Trim(), dt);

							ToolStripMenuItem innerMenuItem = (ToolStripMenuItem)menuItem.DropDownItems[j];
							if (!innerMenuItem.HasDropDownItems)
							{
								continue;
							}
							else
							{
								for (int k = 0; k < innerMenuItem.DropDownItems.Count; k++)
								{
									if (innerMenuItem.DropDownItems[k].Tag == null)
										continue;
									innerMenuItem.DropDownItems[k].Visible = CompareToPID(innerMenuItem.DropDownItems[k].Tag.ToString().Trim(), dt);

								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				base.Error(ex);
			}
		}

		private bool CompareToPID(string Tag, DataTable dt)
		{
			bool result = false;

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (dt.Rows[i]["PRG_ID"].ToString().Trim() == Tag.ToUpper())
					return true;
			}

			return result;
		}
		#endregion

		#region 창 핸들
		#region _tbMain_SizeChanged : 탭 컨트롤 사이즈 변경 이벤트
		/// <summary>
		/// 탭 컨트롤 사이즈 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void _tbMain_SizeChanged(object sender, EventArgs e)
		{
			for (int i = 1; i < _tbMain.TabCount; i++)
			{
				TabPage _tabPage	= _tbMain.TabPages[i];
				Form _form			= (Form)_tabPage.Controls[0];
				_form.WindowState	= FormWindowState.Normal;
				_form.WindowState	= FormWindowState.Maximized;
			}
		}
		#endregion

		#region IsWindowExists : 자식창이 이미 생성되었는지를 체크
		/// <summary>
		/// 자식창이 이미 생성되었는지를 체크
		/// </summary>
		/// <param name="_form"></param>
		/// <returns></returns>
		private bool IsWindowExists(Form _form)
		{
			bool _exist			= false;
			string _formName	= _form.Name;

			//foreach (Form childForm in MdiChildren)
			//{
			//	if (childForm.Name == _formName)
			//	{
			//		childForm.Show();
			//		childForm.BringToFront();
			//		_exist = true;
			//		break;
			//	}
			//}
			for (int i = 0; i < _tbMain.TabPages.Count; i++)
			{
				if (_tbMain.TabPages[i].Name == _formName)
				{
					_tbMain.SelectedTab	= _tbMain.TabPages[i];
					_exist				= true;
					break;
				}
			}

			return _exist;
		}
		#endregion

		#region CloseWindow : 창 닫기
		/// <summary>
		/// 창 닫기
		/// </summary>
		/// <param name="_form"></param>
		private void CloseWindow(Form _form)
		{
			for (int i = _tbMain.TabPages.Count - 1; i > 0; i--)
			{
				if (_tbMain.TabPages[i].Name == _form.Name)
				{
					CleanWindow(_tbMain.TabPages[i].Name);
					_tbMain.TabPages.Remove(_tbMain.TabPages[i]);
				}
			}
		}
		#endregion

		#region AddToWindow : 자식창을 "창" 리스트에 추가
		/// <summary>
		/// 자식창을 "창" 리스트에 추가
		/// </summary>
		/// <param name="_form"></param>
		private void AddToWindow(Form _form)
		{
			if (!IsWindowExists(_form))
			{
				//_form.MdiParent = this;
				//_form.Show();

				_form.TopLevel			= false;
				_form.FormBorderStyle	= FormBorderStyle.None;
				TabPage _tabPage		= new TabPage();
				_tbMain.TabPages.Add(_tabPage);
				_tabPage.Name			= _form.Name;
				_tabPage.Text			= _form.Text;
				_tabPage.Controls.Add(_form);
				_form.Show();
				_tbMain.SelectedTab		= _tabPage;


				ToolStripMenuItem newItem = new ToolStripMenuItem();
				newItem.Name = _form.Name;
				newItem.Text = _form.Text;
				newItem.Click += new EventHandler(newItem_Click);
				toolStripWindow.DropDownItems.Add(newItem);
			}
		}
		#endregion

		#region CleanWindow : "창"에서 자식창명을 삭제하기
		/// <summary>
		/// "창"에서 자식창명을 삭제하기
		/// </summary>
		/// <param name="_strWindowName"></param>
		public void CleanWindow(string _strWindowName)
		{
			for (int i = 0; i < toolStripWindow.DropDownItems.Count; i++)
			{
				if (toolStripWindow.DropDownItems[i].Name == _strWindowName)
				{
					toolStripWindow.DropDownItems.RemoveAt(i);
				}
			}
		}
		#endregion

		#region newItem_Click : 윈도우 이름을 클릭
		/// <summary>
		/// 윈도우 이름을 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void newItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem _menu = (ToolStripMenuItem)sender;
			//foreach (Form childForm in MdiChildren)
			//{
			//	if (childForm.Name == _menu.Name)
			//	{
			//		childForm.BringToFront();
			//		break;
			//	}
			//}
			for (int i = 0; i < _tbMain.TabPages.Count; i++)
			{
				if (_tbMain.TabPages[i].Name == _menu.Name)
				{
					_tbMain.SelectedTab	= _tbMain.TabPages[i];
					break;
				}
			}
		}
		#endregion

		#region toolStrip계단식배열_Click : 계단식 배열
		/// <summary>
		/// 계단식 배열
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStrip계단식배열_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}
		#endregion

		#region toolStrip세로바둑판식배열_Click : 세로 바둑판식 배열
		/// <summary>
		/// 세로 바둑판식 배열
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStrip세로바둑판식배열_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}
		#endregion

		#region toolStrip가로바둑판식배열_Click : 가로 바둑판식 배열
		/// <summary>
		/// 가로 바둑판식 배열
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStrip가로바둑판식배열_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}
		#endregion

		#region toolStrip모두닫기_Click : 모두 닫기
		/// <summary>
		/// 모두 닫기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStrip모두닫기_Click(object sender, EventArgs e)
		{
			for (int i = _tbMain.TabPages.Count - 1; i > 0; i--)
			{
				if (_tbMain.TabPages[i].Name != "_tpHOME")
				{
					CleanWindow(_tbMain.TabPages[i].Name);
					_tbMain.TabPages.Remove(_tbMain.TabPages[i]);
				}
			}
		}
		#endregion

		#region toolStrip아이콘정렬_Click : 아이콘 정렬
		/// <summary>
		/// 아이콘 정렬
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStrip아이콘정렬_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}
		#endregion

		#region MenuStrip_ItemAdded : 좌측의 메뉴 아이콘 없애기
		/// <summary>
		/// 좌측의 메뉴 아이콘 없애기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
		{
			if (e.Item.Text == "")
			{
				e.Item.Visible = false;
			}
		}
		#endregion
		#endregion
		
		#region LoadCompany : 선택 가능한 회사 로드
		/// <summary>
		/// 선택 가능한 회사 로드
		/// </summary>
		public void LoadCompany()
		{
			try
			{
				// 회사 로드
				DataSet _dsCompany				= base.GetDataSet("PCSP_LoadCompany"
					, base.GetCookie("USRID")
					);
				_tscbCompany.ComboBox.ValueMember	= "COMPANY_CD";
				_tscbCompany.ComboBox.DisplayMember	= "COMPANY_NM";
				_tscbCompany.ComboBox.DataSource	= _dsCompany.Tables[0];

				_tscbCompany.ComboBox.SelectedValue	= base.GetCookie("COMPANY_CD");

				if (_dsCompany.Tables[1].Rows.Count > 1)
				{
					_tscbCompany.Enabled	= true;
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion
        
		#region _tscbCompany_DropDownClosed : 회사 변경 이벤트
		/// <summary>
		/// 회사 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tscbCompany_DropDownClosed(object sender, EventArgs e)
		{
			string currCompanyCode	= base.GetCookie("COMPANY_CD");
			if (currCompanyCode != _tscbCompany.ComboBox.SelectedValue.ToString())
			{
				// 현재 자식창 숫자
				int curChildren	= _tbMain.TabCount;
				
				if (curChildren > 1)
				{
					DialogResult res	= MessageBox.Show("운영회사를 변경하시면, 현재 열려있는 모든 창들이 닫히게 됩니다.\r\n\r\n계속 하시겠습니까?", "기준회사 변경", MessageBoxButtons.YesNo);
					if (res == System.Windows.Forms.DialogResult.Yes)
					{
						for (int i = _tbMain.TabPages.Count - 1; i > 0; i--)
						{
							if (_tbMain.TabPages[i].Name != "_tpHOME")
							{
								CleanWindow(_tbMain.TabPages[i].Name);
								_tbMain.TabPages.Remove(_tbMain.TabPages[i]);
							}
						}
					}
					else
					{
						_tscbCompany.ComboBox.SelectedValue	= currCompanyCode;
						return;
					}
				}
				base.SetCookie("COMPANY_CD", _tscbCompany.ComboBox.SelectedValue.ToString());
			}
		}
		#endregion

		#region frmMain_Resize : 창 크기 변경 이벤트
		/// <summary>
		/// 창 크기 변경 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmMain_Resize(object sender, EventArgs e)
		{
			try
			{
				string temp		= string.Format("Width: {0}; Height: {1};", this.Width, this.Height);
				base.DelegateToolStripStatusLabelUpdate(TsslStatus, temp);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region 메뉴

		// 툴바 메뉴
		#region _tsbAffiliate_Click : 가맹점정보관리
		/// <summary>
		/// 가맹점정보관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbAffiliate_Click(object sender, EventArgs e)
		{
			공정별품목등록ToolStripMenuItem.PerformClick();
		}
		#endregion

		#region _tsbWithdrawRowData_Click : 출금원장조회
		/// <summary>
		/// 출금원장조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbWithdrawRowData_Click(object sender, EventArgs e)
		{
			출금원장조회ToolStripMenuItem.PerformClick();
		}
		#endregion

		#region _tsbSalesRowData_Click : 거래원장조회
		/// <summary>
		/// 거래원장조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbSalesRowData_Click(object sender, EventArgs e)
		{
			거래원장조회ToolStripMenuItem.PerformClick();
		}
		#endregion

		#region _tsbCalMagam_Click : 정산마감처리
		/// <summary>
		/// 정산마감처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbCalMagam_Click(object sender, EventArgs e)
		{
			정산마감처리ToolStripMenuItem.PerformClick();
		}
		#endregion

		#region _tsbReturnMagam_Click : 상환마감처리
		/// <summary>
		/// 상환마감처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbReturnMagam_Click(object sender, EventArgs e)
		{
			상환마감처리ToolStripMenuItem.PerformClick();
		}
		#endregion
		
		#region _tsbExit_Click : 종료 버튼 클릭 이벤트
		/// <summary>
		/// 종료 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region _tsbChangePwd_Click : 비밀번호 변경
		/// <summary>
		/// 비밀번호 변경
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsbChangePwd_Click(object sender, EventArgs e)
		{
			View.Common.frmChangeMyPassword _childForm	= new View.Common.frmChangeMyPassword();
			_childForm.ShowDialog();
		}
        #endregion

        //기준정보
        #region 사용자등록ToolStripMenuItem_Click : 사용자등록
        /// <summary>
        /// 이용자정보관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 사용자등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.BAS.BAS0200 _childForm = new View.BAS.BAS0200();
            AddToWindow(_childForm);
        }
        #endregion
        //생산
        #region 사용자등록ToolStripMenuItem_Click : 사용자등록
        /// <summary>
        /// 이용자정보관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 거래처등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.BAS.BAS0200 _childForm = new View.BAS.BAS0200();
            AddToWindow(_childForm);
        }
        #endregion
        //설비
        #region 등록ToolStripMenuItem_Click : 사용자등록
        /// <summary>
        /// 이용자정보관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 창고등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.HLP.testpage _childForm = new View.HLP.testpage();
            AddToWindow(_childForm);
        }
        #endregion
        //금형
        //물류







        // 기초정보
        #region 회사정보관리ToolStripMenuItem_Click : 회사정보관리
        /// <summary>
        /// 회사정보관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 회사정보관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0100 _childForm	= new View.BAS.BAS0100();
			AddToWindow(_childForm);
		}
		#endregion

		#region 이용자관리ToolStripMenuItem_Click : 이용자정보관리
		/// <summary>
		/// 이용자정보관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 이용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0200 _childForm	= new View.BAS.BAS0200();
			AddToWindow(_childForm);
		}
		#endregion

		#region 시스템권한관리ToolStripMenuItem_Click : 시스템권한관리
		/// <summary>
		/// 시스템권한관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 시스템권한관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0400 _childForm	= new View.BAS.BAS0400();
			AddToWindow(_childForm);
		}
		#endregion

		#region 공통코드관리ToolStripMenuItem_Click : 공통코드관리
		/// <summary>
		/// 공통코드관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 공통코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0500 _childForm	= new View.BAS.BAS0500();
			AddToWindow(_childForm);
		}
		#endregion

		#region 공휴일관리ToolStripMenuItem_Click : 공휴일관리
		/// <summary>
		/// 공휴일관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 공휴일관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0600 _childForm	= new View.BAS.BAS0600();
			AddToWindow(_childForm);
		}
        #endregion

        #region 테스트페이지
        private void testpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.HLP.testpage _childForm = new View.HLP.testpage();
            _childForm.ShowDialog();
        }

        #endregion

        // 대리점관리
        #region 대리점정보관리ToolStripMenuItem_Click : 대리점정보관리
        /// <summary>
        /// 대리점정보관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 작업장관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.mngLINMST _childForm	= new View.BAS.mngLINMST();
			AddToWindow(_childForm);
		}
		#endregion

		#region 영업수수료관리ToolStripMenuItem_Click : 영업수수료관리
		/// <summary>
		/// 영업수수료관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 영업수수료관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0740 _childForm	= new View.BAS.BAS0740();
			AddToWindow(_childForm);
		}
        #endregion
        
        #region 공정관리ToolStripMenuItem_Click : 공정관리
        /// <summary>
        /// 공정관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 공정관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.BAS.mngPRCMST _childForm = new View.BAS.mngPRCMST();
            AddToWindow(_childForm);
        }
        #endregion

        #region 작업장별공정등록ToolStripMenuItem1_Click : 작업장별공정등록
        /// <summary>
        /// 작업장별공정등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 작업장별공정등록ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			View.BAS.mngLINPRC _childForm	= new View.BAS.mngLINPRC();
			AddToWindow(_childForm);
		}
		#endregion

		#region 보증예치금관리ToolStripMenuItem1_Click : 보증예치금관리
		/// <summary>
		/// 보증예치금관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증예치금관리ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0750 _childForm	= new View.BAS.BAS0750();
			AddToWindow(_childForm);
		}
		#endregion

		#region 보증보험관리ToolStripMenuItem1_Click : 보증보험관리
		/// <summary>
		/// 보증보험관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증보험관리ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0755 _childForm	= new View.BAS.BAS0755();
			AddToWindow(_childForm);
		}
		#endregion

		#region 정산계약정보이력조회ToolStripMenuItem_Click : 정산/계약정보이력조회
		/// <summary>
		/// 정산/계약정보이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 정산계약정보이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0760 _childForm	= new View.BAS.BAS0760();
			AddToWindow(_childForm);
		}
		#endregion

		#region 구비서류이력조회ToolStripMenuItem_Click : 구비서류이력조회
		/// <summary>
		/// 구비서류이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 구비서류이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.mngLOCMST _childForm	= new View.BAS.mngLOCMST();
			AddToWindow(_childForm);
		}
        #endregion

        // 가맹점관리
        #region 공정별품목등록ToolStripMenuItem_Click : 가맹점정보관리
        /// <summary>
        /// 가맹점정보관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 공정별품목등록ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.mngPRCPNO _childForm	= new View.BAS.mngPRCPNO();
			AddToWindow(_childForm);
		}
		#endregion

		#region 정산계약정보관리ToolStripMenuItem_Click : 정산/계약정보관리
		/// <summary>
		/// 정산/계약정보관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 정산계약정보관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0805 _childForm	= new View.BAS.BAS0805();
			AddToWindow(_childForm);
		}
		#endregion

		#region 매입카드관리ToolStripMenuItem_Click : 매입카드관리
		/// <summary>
		/// 매입카드관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 매입카드관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0810 _childForm	= new View.BAS.BAS0810();
			AddToWindow(_childForm);
		}
		#endregion

		#region 기타수수료관리ToolStripMenuItem_Click : 기타수수료관리
		/// <summary>
		/// 기타수수료관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 기타수수료관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0813 _childForm	= new View.BAS.BAS0813();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 강제출금자동차감관리ToolStripMenuItem_Click : 강제출금/자동차감관리
		/// <summary>
		/// 강제출금/자동차감관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 강제출금자동차감관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0814 _childForm	= new View.BAS.BAS0814();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 보증보험관리ToolStripMenuItem_Click : 보증보험관리
		/// <summary>
		/// 보증보험관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증보험관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0815 _childForm	= new View.BAS.BAS0815();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 보증예치금관리ToolStripMenuItem_Click : 보증예치금관리
		/// <summary>
		/// 보증예치금관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증예치금관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0816 _childForm	= new View.BAS.BAS0816();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 연대보증인관리ToolStripMenuItem_Click : 연대보증인관리
		/// <summary>
		/// 연대보증인관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 연대보증인관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0817 _childForm	= new View.BAS.BAS0817();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 정산계약정보이력조회ToolStripMenuItem1_Click : 정산/계약정보이력조회
		/// <summary>
		/// 정산/계약정보이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 정산계약정보이력조회ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0818 _childForm	= new View.BAS.BAS0818();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 매입카드이력조회ToolStripMenuItem_Click : 매입카드이력조회
		/// <summary>
		/// 매입카드이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 매입카드이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0819 _childForm	= new View.BAS.BAS0819();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 기타수수료이력조회ToolStripMenuItem_Click : 기타수수료이력조회
		/// <summary>
		/// 기타수수료이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 기타수수료이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0820 _childForm	= new View.BAS.BAS0820();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 강제출금자동차감이력조회ToolStripMenuItem_Click : 강제출금/자동차감이력조회
		/// <summary>
		/// 강제출금/자동차감이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 강제출금자동차감이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0821 _childForm	= new View.BAS.BAS0821();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 보증예치금이력조회ToolStripMenuItem_Click : 보증예치금이력조회
		/// <summary>
		/// 보증예치금이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증예치금이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0822 _childForm	= new View.BAS.BAS0822();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 보증보험이력조회ToolStripMenuItem_Click : 보증보험이력조회
		/// <summary>
		/// 보증보험이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증보험이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0823 _childForm	= new View.BAS.BAS0823();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 연대보증인이력조회ToolStripMenuItem_Click : 연대보증인이력조회
		/// <summary>
		/// 연대보증인이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 연대보증인이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0824 _childForm	= new View.BAS.BAS0824();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 구비서류이력조회ToolStripMenuItem1_Click : 구비서류이력조회
		/// <summary>
		/// 구비서류이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 구비서류이력조회ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			View.BAS.BAS0825 _childForm	= new View.BAS.BAS0825();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 여신사정보관리ToolStripMenuItem_Click : 여신사정보관리
		/// <summary>
		/// 여신사정보관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 팝업SQL관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.Common.mngPOPSQL _childForm	= new View.Common.mngPOPSQL();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 채권사정보관리ToolStripMenuItem_Click : 채권사정보관리
		/// <summary>
		/// 채권사정보관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 채권사정보관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.BAS1000 _childForm	= new View.BAS.BAS1000();
			AddToWindow(_childForm);
		}
		#endregion

		// 금형
		#region 금형관리ToolStripMenuItem_Click : 금형관리
		/// <summary>
		/// 중복예상거래관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 금형관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.mngMOLMST _childForm	= new View.BAS.mngMOLMST();
			AddToWindow(_childForm);
		}
		#endregion

		#region 미요청거래관리ToolStripMenuItem_Click : 미요청거래관리
		/// <summary>
		/// 미요청거래관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 미요청거래관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.BAS.mngWHSMST _childForm	= new View.BAS.mngWHSMST();
			AddToWindow(_childForm);
		}
		#endregion

		#region 한도초과거래관리ToolStripMenuItem_Click : 한도초과거래관리
		/// <summary>
		/// 한도초과거래관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 한도초과거래관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0300 _childForm	= new View.WDR.WDR0300();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금요청관리ToolStripMenuItem_Click : 출금요청관리
		/// <summary>
		/// 출금요청관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금요청관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0400 _childForm	= new View.WDR.WDR0400();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금요청사용자취소관리toolStripMenuItem_Click : 출금요청사용자취소관리
		/// <summary>
		/// 출금요청사용자취소관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금요청사용자취소관리toolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0450 _childForm = new View.WDR.WDR0450();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금후취소관리ToolStripMenuItem_Click : 출금후취소관리
		/// <summary>
		/// 출금후취소관리ToolStripMenuItem_Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금후취소관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0480 _childForm = new View.WDR.WDR0480();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금승인관리ToolStripMenuItem_Click : 출금승인관리
		/// <summary>
		/// 출금승인관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금승인관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0500 _childForm	= new View.WDR.WDR0500();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금원장조회ToolStripMenuItem_Click : 출금원장조회
		/// <summary>
		/// 출금원장조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금원장조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0600 _childForm	= new View.WDR.WDR0600();
			AddToWindow(_childForm);
		}
		#endregion

		#region 거래원장조회ToolStripMenuItem_Click : 거래원장조회
		/// <summary>
		/// 거래원장조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 거래원장조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0700 _childForm	= new View.WDR.WDR0700();
			AddToWindow(_childForm);
		}
		#endregion

		#region 강제출금관리ToolStripMenuItem_Click : 강제출금관리
		/// <summary>
		/// 강제출금관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 강제출금관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0810 _childForm = new View.WDR.WDR0810();
			AddToWindow(_childForm);
		}
		#endregion

		#region 보증예치금적립내역조회toolStripMenuItem_Click : 보증예치금적립내역조회
		/// <summary>
		/// 보증예치금적립내역조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 보증예치금적립내역조회toolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR0910 _childForm = new View.WDR.WDR0910();
			AddToWindow(_childForm);
		}
		#endregion

		#region 기타수수료차감내역조회ToolStripMenuItem_Click : 기타수수료차감내역조회
		/// <summary>
		/// 기타수수료차감내역조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 기타수수료차감내역조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR1010 _childForm = new View.WDR.WDR1010();
			AddToWindow(_childForm);
		}
		#endregion

		#region 중복해제이력조회ToolStripMenuItem_Click : 중복해제이력조회
		/// <summary>
		/// 중복해제이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 중복해제이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR1110 _childForm = new View.WDR.WDR1110();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금요청이력조회ToolStripMenuItem_Click : 출금요청이력조회
		/// <summary>
		/// 출금요청이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금요청이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR1210 _childForm = new View.WDR.WDR1210();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금실패이력조회ToolStripMenuItem_Click : 출금실패이력조회
		/// <summary>
		/// 출금실패이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금실패이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR1310 _childForm = new View.WDR.WDR1310();
			AddToWindow(_childForm);
		}
		#endregion

		#region 출금승인이력조회ToolStripMenuItem_Click : 출금승인이력조회
		/// <summary>
		/// 출금승인이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 출금승인이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.WDR.WDR1410 _childForm = new View.WDR.WDR1410();
			AddToWindow(_childForm);
		}
		#endregion

		// 정산관리
		#region 정산마감처리ToolStripMenuItem_Click : 정산마감처리
		/// <summary>
		/// 정산마감처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 정산마감처리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.ACC.ACC0100 _childForm	= new View.ACC.ACC0100();
			AddToWindow(_childForm);
		}
		#endregion

		#region 정산내역조회ToolStripMenuItem_Click : 정산내역조회
		/// <summary>
		/// 정산내역조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 정산내역조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.ACC.ACC0200 _childForm	= new View.ACC.ACC0200();
			AddToWindow(_childForm);
		}
		#endregion

		#region 정산마감이력조회ToolStripMenuItem_Click : 정산마감이력조회
		/// <summary>
		/// 정산마감이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 정산마감이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.ACC.ACC0310 _childForm = new View.ACC.ACC0310();
			AddToWindow(_childForm);
		}
		#endregion

		#region 세금계산서관리ToolStripMenuItem_Click : 세금계산서관리
		/// <summary>
		/// 세금계산서관리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 세금계산서관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.ACC.ACC0410 _childForm = new View.ACC.ACC0410();
			AddToWindow(_childForm);
		}
		#endregion

		//  상환관리
		#region 상환마감처리ToolStripMenuItem_Click : 상환마감처리
		/// <summary>
		/// 상환마감처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 상환마감처리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.RDM.RDM0110 _childForm = new View.RDM.RDM0110();
			AddToWindow(_childForm);
		}
		#endregion

		//  대출관리
		#region 대출원장관리ToolStripMenuItem_Click : 대출원장관리
		private void 대출원장관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.LRN.LRN0100 _childForm = new View.LRN.LRN0100();
			AddToWindow(_childForm);

		}
		#endregion

		#region 비즈론계산기ToolStripMenuItem_Click : 비즈론계산기
		private void 비즈론계산기ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //View.LRN.LRN0200 _childForm = new View.LRN.LRN0200();
            View.LRN.CHK100 _childForm = new View.LRN.CHK100();
            _childForm.ShowDialog();
			//AddToWindow(_childForm);
		}
		#endregion

		#region 카드사별입금내역조회ToolStripMenuItem_Click : 카드사별입금내역조회
		/// <summary>
		/// 카드사별입금내역조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 카드사별입금내역조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.RDM.RDM0210 _childForm = new View.RDM.RDM0210();
			AddToWindow(_childForm);
		}
		#endregion

		#region 상환예정내역조회ToolStripMenuItem_Click : 상환예정내역조회
		/// <summary>
		/// 상환예정내역조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 상환예정내역조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.RDM.RDM0310 _childForm = new View.RDM.RDM0310();
			AddToWindow(_childForm);
		}
		#endregion

		#region 상환마감이력조회ToolStripMenuItem_Click : 상환마감이력조회
		/// <summary>
		/// 상환마감이력조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 상환마감이력조회ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.RDM.RDM0410 _childForm = new View.RDM.RDM0410();
			AddToWindow(_childForm);
		}
		#endregion

		// 도움말
		#region 프로그램정보ToolStripMenuItem_Click : 프로그램정보
		/// <summary>
		/// 프로그램정보
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.HLP.HLP0100 _childForm	= new View.HLP.HLP0100();
			_childForm.ShowDialog();
		}
		#endregion
		
		#region 프로그램사용법ToolStripMenuItem_Click : 프로그램사용법
		/// <summary>
		/// 프로그램사용법
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 프로그램사용법ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.HLP.HLP0200 _childForm	= new View.HLP.HLP0200();
			AddToWindow(_childForm);
		}
		#endregion
		
		#region 사용의견보내기ToolStripMenuItem_Click : 사용의견보내기
		/// <summary>
		/// 사용의견보내기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 사용의견보내기ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_feed	= new AppManager.Feedback();
			_feed.Show();
		}
		#endregion
		
		#region 공지사항ToolStripMenuItem_Click : 공지사항
		/// <summary>
		/// 공지사항
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void 공지사항ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			View.HLP.HLP0300 _childForm = new View.HLP.HLP0300();
			AddToWindow(_childForm);
		}
		#endregion

		#region _tsslNotice_Click : 공지 클릭
		/// <summary>
		/// 공지 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsslNotice_Click(object sender, EventArgs e)
		{
			try
			{
				_notice = new AppManager.Notice();
				_notice.Show();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _tsslFeedback_Click : 답변 클릭
		/// <summary>
		/// 답변 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _tsslFeedback_Click(object sender, EventArgs e)
		{
			try
			{
				_feed = new AppManager.Feedback();
				_feed.Show();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		private void 정산관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}


        #endregion
    }
}
