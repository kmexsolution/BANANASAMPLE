namespace DemoClient
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			// 응용 프로그램 종료
			try
			{
				_usage	= new AppManager.Usage();
				_usage.ShutDown();
			}
			catch (System.Exception err)
			{
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this._tbMain = new BANANA.Windows.Controls.TabControl();
            this._tpHOME = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._tsbAffiliate = new System.Windows.Forms.ToolStripButton();
            this._tsbWithdrawRowData = new System.Windows.Forms.ToolStripButton();
            this._tsbSalesRowData = new System.Windows.Forms.ToolStripButton();
            this._tsbIncomingAmount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this._tsbCalMagam = new System.Windows.Forms.ToolStripButton();
            this._tsbReturnMagam = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._tsbConfig = new System.Windows.Forms.ToolStripButton();
            this._tsbChangePwd = new System.Windows.Forms.ToolStripButton();
            this._tsbExit = new System.Windows.Forms.ToolStripButton();
            this._tscbCompany = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._tsslDB = new System.Windows.Forms.ToolStripStatusLabel();
            this._tsslPeriod = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslNotice = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslFeedback = new System.Windows.Forms.ToolStripStatusLabel();
            this._tsslStopwatch = new System.Windows.Forms.ToolStripStatusLabel();
            this._tsslClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.기초정보ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.품목등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목등록ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM등록ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.생산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작업장등록ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.작업장등록ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.공정등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공정별품번등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설비ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설비관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설비등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.금형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.금형관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.금형관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.물류ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.단가관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매입단가등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출단가등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기준정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창고등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.location등ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램사용법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.사용의견보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공지사항ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기초정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회사정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시스템권한관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.공통코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공휴일관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타수수료관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.대리점관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대리점정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공정관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작업장1별공정등록ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.보증예치금관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.보증보험관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.작업장별공정등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구비서류이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가맹점관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공정별품목등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정산계약정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매입카드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.강제출금자동차감관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보증예치금관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보증보험관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연대보증인관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.정산계약정보이력조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.매입카드이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타수수료이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강제출금자동차감이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보증예치금이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보증보험이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연대보증인이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구비서류이력조회ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.팝업SQL관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.채권사정보관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중복예상거래관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.미요청거래관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.한도초과거래관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.출금요청관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금요청사용자취소관리toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금후취소관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금승인관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.출금원장조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래원장조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강제출금관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보증예치금적립내역조회toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타수수료차감내역조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.출금관리이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금요청이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금실패이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출금승인이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정산관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정산마감처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정산내역조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정산마감이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.세금계산서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상환관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상환마감처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.카드사별입금내역조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상환예정내역조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.상환마감이력조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대출원장관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비즈론계산기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.채권관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확정채권회수관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리스크관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.모든창닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this._tbMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tbMain
            // 
            this._tbMain.Controls.Add(this._tpHOME);
            this._tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbMain.Location = new System.Drawing.Point(0, 55);
            this._tbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbMain.Name = "_tbMain";
            this._tbMain.SelectedIndex = 0;
            this._tbMain.ShowCloseButton = true;
            this._tbMain.Size = new System.Drawing.Size(1547, 708);
            this._tbMain.TabIndex = 6;
            // 
            // _tpHOME
            // 
            this._tpHOME.BackColor = System.Drawing.SystemColors.Control;
            this._tpHOME.Location = new System.Drawing.Point(4, 25);
            this._tpHOME.Margin = new System.Windows.Forms.Padding(0);
            this._tpHOME.Name = "_tpHOME";
            this._tpHOME.Size = new System.Drawing.Size(1539, 679);
            this._tpHOME.TabIndex = 0;
            this._tpHOME.Text = "HOME";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbAffiliate,
            this._tsbWithdrawRowData,
            this._tsbSalesRowData,
            this._tsbIncomingAmount,
            this.toolStripSeparator13,
            this._tsbCalMagam,
            this._tsbReturnMagam,
            this.toolStripSeparator3,
            this._tsbConfig,
            this._tsbChangePwd,
            this._tsbExit,
            this._tscbCompany});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1547, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _tsbAffiliate
            // 
            this._tsbAffiliate.Image = global::DemoClient.Properties.Resources._1404480988_shop;
            this._tsbAffiliate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsbAffiliate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbAffiliate.Name = "_tsbAffiliate";
            this._tsbAffiliate.Size = new System.Drawing.Size(138, 24);
            this._tsbAffiliate.Text = "가맹점정보관리";
            this._tsbAffiliate.Click += new System.EventHandler(this._tsbAffiliate_Click);
            // 
            // _tsbWithdrawRowData
            // 
            this._tsbWithdrawRowData.Image = global::DemoClient.Properties.Resources._1404481232_View_Details;
            this._tsbWithdrawRowData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbWithdrawRowData.Name = "_tsbWithdrawRowData";
            this._tsbWithdrawRowData.Size = new System.Drawing.Size(123, 24);
            this._tsbWithdrawRowData.Text = "출금원장조회";
            this._tsbWithdrawRowData.Click += new System.EventHandler(this._tsbWithdrawRowData_Click);
            // 
            // _tsbSalesRowData
            // 
            this._tsbSalesRowData.Image = global::DemoClient.Properties.Resources._1404481232_View_Details;
            this._tsbSalesRowData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsbSalesRowData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbSalesRowData.Name = "_tsbSalesRowData";
            this._tsbSalesRowData.Size = new System.Drawing.Size(123, 24);
            this._tsbSalesRowData.Text = "거래원장조회";
            this._tsbSalesRowData.Click += new System.EventHandler(this._tsbSalesRowData_Click);
            // 
            // _tsbIncomingAmount
            // 
            this._tsbIncomingAmount.Image = global::DemoClient.Properties.Resources._1404481235_checked_checkbox;
            this._tsbIncomingAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsbIncomingAmount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbIncomingAmount.Name = "_tsbIncomingAmount";
            this._tsbIncomingAmount.Size = new System.Drawing.Size(183, 24);
            this._tsbIncomingAmount.Text = "카드사별입금내역조회";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // _tsbCalMagam
            // 
            this._tsbCalMagam.Image = global::DemoClient.Properties.Resources._1404451698_274904;
            this._tsbCalMagam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbCalMagam.Name = "_tsbCalMagam";
            this._tsbCalMagam.Size = new System.Drawing.Size(123, 24);
            this._tsbCalMagam.Text = "정산마감처리";
            this._tsbCalMagam.Click += new System.EventHandler(this._tsbCalMagam_Click);
            // 
            // _tsbReturnMagam
            // 
            this._tsbReturnMagam.Enabled = false;
            this._tsbReturnMagam.Image = global::DemoClient.Properties.Resources._1404451698_274904;
            this._tsbReturnMagam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbReturnMagam.Name = "_tsbReturnMagam";
            this._tsbReturnMagam.Size = new System.Drawing.Size(123, 24);
            this._tsbReturnMagam.Text = "상환마감처리";
            this._tsbReturnMagam.Click += new System.EventHandler(this._tsbReturnMagam_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // _tsbConfig
            // 
            this._tsbConfig.Enabled = false;
            this._tsbConfig.Image = global::DemoClient.Properties.Resources._1382517304_22560;
            this._tsbConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsbConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbConfig.Name = "_tsbConfig";
            this._tsbConfig.Size = new System.Drawing.Size(93, 24);
            this._tsbConfig.Text = "환경설정";
            // 
            // _tsbChangePwd
            // 
            this._tsbChangePwd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._tsbChangePwd.Image = global::DemoClient.Properties.Resources._1377802975_32495;
            this._tsbChangePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsbChangePwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbChangePwd.Name = "_tsbChangePwd";
            this._tsbChangePwd.Size = new System.Drawing.Size(128, 24);
            this._tsbChangePwd.Text = "비밀번호 변경";
            this._tsbChangePwd.Click += new System.EventHandler(this._tsbChangePwd_Click);
            // 
            // _tsbExit
            // 
            this._tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._tsbExit.Image = global::DemoClient.Properties.Resources._1377802977_32565;
            this._tsbExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbExit.Name = "_tsbExit";
            this._tsbExit.Size = new System.Drawing.Size(63, 24);
            this._tsbExit.Text = "종료";
            this._tsbExit.Click += new System.EventHandler(this._tsbExit_Click);
            // 
            // _tscbCompany
            // 
            this._tscbCompany.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._tscbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._tscbCompany.Enabled = false;
            this._tscbCompany.Name = "_tscbCompany";
            this._tscbCompany.Size = new System.Drawing.Size(205, 28);
            this._tscbCompany.Visible = false;
            this._tscbCompany.DropDownClosed += new System.EventHandler(this._tscbCompany_DropDownClosed);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslStatus,
            this._tsslDB,
            this._tsslPeriod,
            this.TsslNotice,
            this.TsslFeedback,
            this._tsslStopwatch,
            this._tsslClock});
            this.statusStrip.Location = new System.Drawing.Point(0, 763);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(1547, 29);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // TsslStatus
            // 
            this.TsslStatus.Name = "TsslStatus";
            this.TsslStatus.Size = new System.Drawing.Size(897, 24);
            this.TsslStatus.Spring = true;
            this.TsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _tsslDB
            // 
            this._tsslDB.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._tsslDB.Name = "_tsslDB";
            this._tsslDB.Size = new System.Drawing.Size(4, 24);
            // 
            // _tsslPeriod
            // 
            this._tsslPeriod.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._tsslPeriod.Name = "_tsslPeriod";
            this._tsslPeriod.Size = new System.Drawing.Size(211, 24);
            this._tsslPeriod.Text = "0000년 0월 0일까지 사용가능";
            // 
            // TsslNotice
            // 
            this.TsslNotice.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsslNotice.IsLink = true;
            this.TsslNotice.Name = "TsslNotice";
            this.TsslNotice.Size = new System.Drawing.Size(74, 24);
            this.TsslNotice.Text = "공지: 0건";
            this.TsslNotice.Click += new System.EventHandler(this._tsslNotice_Click);
            // 
            // TsslFeedback
            // 
            this.TsslFeedback.IsLink = true;
            this.TsslFeedback.Name = "TsslFeedback";
            this.TsslFeedback.Size = new System.Drawing.Size(70, 24);
            this.TsslFeedback.Text = "의견: 0건";
            this.TsslFeedback.Click += new System.EventHandler(this._tsslFeedback_Click);
            // 
            // _tsslStopwatch
            // 
            this._tsslStopwatch.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._tsslStopwatch.Name = "_tsslStopwatch";
            this._tsslStopwatch.Size = new System.Drawing.Size(94, 24);
            this._tsslStopwatch.Text = "00:00:00.000";
            // 
            // _tsslClock
            // 
            this._tsslClock.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._tsslClock.Name = "_tsslClock";
            this._tsslClock.Size = new System.Drawing.Size(178, 24);
            this._tsslClock.Text = "2013-10-27 (일) 00:00:00";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기초정보ToolStripMenuItem1,
            this.생산ToolStripMenuItem,
            this.설비ToolStripMenuItem,
            this.금형ToolStripMenuItem,
            this.물류ToolStripMenuItem,
            this.기준정보ToolStripMenuItem,
            this.도움말ToolStripMenuItem,
            this.기초정보ToolStripMenuItem,
            this.출금관리ToolStripMenuItem,
            this.정산관리ToolStripMenuItem,
            this.상환관리ToolStripMenuItem,
            this.대출관리ToolStripMenuItem,
            this.채권관리ToolStripMenuItem,
            this.리스크관리ToolStripMenuItem,
            this.toolStripWindow});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1547, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.MenuStrip_ItemAdded);
            // 
            // 기초정보ToolStripMenuItem1
            // 
            this.기초정보ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목등록ToolStripMenuItem});
            this.기초정보ToolStripMenuItem1.Name = "기초정보ToolStripMenuItem1";
            this.기초정보ToolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.기초정보ToolStripMenuItem1.Text = "개발";
            // 
            // 품목등록ToolStripMenuItem
            // 
            this.품목등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.품목등록ToolStripMenuItem1,
            this.bOM등록ToolStripMenuItem1});
            this.품목등록ToolStripMenuItem.Name = "품목등록ToolStripMenuItem";
            this.품목등록ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.품목등록ToolStripMenuItem.Text = "품목관리";
            // 
            // 품목등록ToolStripMenuItem1
            // 
            this.품목등록ToolStripMenuItem1.Name = "품목등록ToolStripMenuItem1";
            this.품목등록ToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.품목등록ToolStripMenuItem1.Text = "품목등록";
            // 
            // bOM등록ToolStripMenuItem1
            // 
            this.bOM등록ToolStripMenuItem1.Name = "bOM등록ToolStripMenuItem1";
            this.bOM등록ToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.bOM등록ToolStripMenuItem1.Text = "BOM등록";
            // 
            // 생산ToolStripMenuItem
            // 
            this.생산ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.작업장등록ToolStripMenuItem1});
            this.생산ToolStripMenuItem.Name = "생산ToolStripMenuItem";
            this.생산ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.생산ToolStripMenuItem.Text = "생산";
            // 
            // 작업장등록ToolStripMenuItem1
            // 
            this.작업장등록ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.작업장등록ToolStripMenuItem2,
            this.공정등록ToolStripMenuItem,
            this.공정별품번등록ToolStripMenuItem});
            this.작업장등록ToolStripMenuItem1.Name = "작업장등록ToolStripMenuItem1";
            this.작업장등록ToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.작업장등록ToolStripMenuItem1.Text = "작업장관리";
            // 
            // 작업장등록ToolStripMenuItem2
            // 
            this.작업장등록ToolStripMenuItem2.Name = "작업장등록ToolStripMenuItem2";
            this.작업장등록ToolStripMenuItem2.Size = new System.Drawing.Size(204, 26);
            this.작업장등록ToolStripMenuItem2.Text = "작업장등록";
            // 
            // 공정등록ToolStripMenuItem
            // 
            this.공정등록ToolStripMenuItem.Name = "공정등록ToolStripMenuItem";
            this.공정등록ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.공정등록ToolStripMenuItem.Text = "작업장별공정등록";
            // 
            // 공정별품번등록ToolStripMenuItem
            // 
            this.공정별품번등록ToolStripMenuItem.Name = "공정별품번등록ToolStripMenuItem";
            this.공정별품번등록ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.공정별품번등록ToolStripMenuItem.Text = "공정별품번등록";
            // 
            // 설비ToolStripMenuItem
            // 
            this.설비ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설비관리ToolStripMenuItem});
            this.설비ToolStripMenuItem.Name = "설비ToolStripMenuItem";
            this.설비ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.설비ToolStripMenuItem.Text = "설비";
            // 
            // 설비관리ToolStripMenuItem
            // 
            this.설비관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설비등록ToolStripMenuItem});
            this.설비관리ToolStripMenuItem.Name = "설비관리ToolStripMenuItem";
            this.설비관리ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.설비관리ToolStripMenuItem.Text = "설비관리";
            // 
            // 설비등록ToolStripMenuItem
            // 
            this.설비등록ToolStripMenuItem.Name = "설비등록ToolStripMenuItem";
            this.설비등록ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.설비등록ToolStripMenuItem.Text = "설비등록";
            // 
            // 금형ToolStripMenuItem
            // 
            this.금형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.금형관리ToolStripMenuItem});
            this.금형ToolStripMenuItem.Name = "금형ToolStripMenuItem";
            this.금형ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.금형ToolStripMenuItem.Text = "금형";
            // 
            // 금형관리ToolStripMenuItem
            // 
            this.금형관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.금형관리ToolStripMenuItem1});
            this.금형관리ToolStripMenuItem.Name = "금형관리ToolStripMenuItem";
            this.금형관리ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.금형관리ToolStripMenuItem.Text = "금형관리";
            // 
            // 금형관리ToolStripMenuItem1
            // 
            this.금형관리ToolStripMenuItem1.Name = "금형관리ToolStripMenuItem1";
            this.금형관리ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.금형관리ToolStripMenuItem1.Text = "금형관리";
            // 
            // 물류ToolStripMenuItem
            // 
            this.물류ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.단가관리ToolStripMenuItem});
            this.물류ToolStripMenuItem.Name = "물류ToolStripMenuItem";
            this.물류ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.물류ToolStripMenuItem.Text = "물류";
            // 
            // 단가관리ToolStripMenuItem
            // 
            this.단가관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매입단가등록ToolStripMenuItem,
            this.매출단가등록ToolStripMenuItem});
            this.단가관리ToolStripMenuItem.Name = "단가관리ToolStripMenuItem";
            this.단가관리ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.단가관리ToolStripMenuItem.Text = "단가관리";
            // 
            // 매입단가등록ToolStripMenuItem
            // 
            this.매입단가등록ToolStripMenuItem.Name = "매입단가등록ToolStripMenuItem";
            this.매입단가등록ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.매입단가등록ToolStripMenuItem.Text = "매입단가등록";
            // 
            // 매출단가등록ToolStripMenuItem
            // 
            this.매출단가등록ToolStripMenuItem.Name = "매출단가등록ToolStripMenuItem";
            this.매출단가등록ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.매출단가등록ToolStripMenuItem.Text = "매출단가등록";
            // 
            // 기준정보ToolStripMenuItem
            // 
            this.기준정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자관리ToolStripMenuItem,
            this.거래처관리ToolStripMenuItem,
            this.창고관리ToolStripMenuItem,
            this.testpageToolStripMenuItem});
            this.기준정보ToolStripMenuItem.Name = "기준정보ToolStripMenuItem";
            this.기준정보ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.기준정보ToolStripMenuItem.Text = "기준정보";
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자등록ToolStripMenuItem});
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.사용자관리ToolStripMenuItem.Text = "사용자관리";
            // 
            // 사용자등록ToolStripMenuItem
            // 
            this.사용자등록ToolStripMenuItem.Name = "사용자등록ToolStripMenuItem";
            this.사용자등록ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.사용자등록ToolStripMenuItem.Text = "사용자등록";
            this.사용자등록ToolStripMenuItem.Click += new System.EventHandler(this.사용자등록ToolStripMenuItem_Click);
            // 
            // 거래처관리ToolStripMenuItem
            // 
            this.거래처관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.거래처등록ToolStripMenuItem});
            this.거래처관리ToolStripMenuItem.Name = "거래처관리ToolStripMenuItem";
            this.거래처관리ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.거래처관리ToolStripMenuItem.Text = "거래처관리";
            // 
            // 거래처등록ToolStripMenuItem
            // 
            this.거래처등록ToolStripMenuItem.Name = "거래처등록ToolStripMenuItem";
            this.거래처등록ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.거래처등록ToolStripMenuItem.Text = "거래처등록";
            // 
            // 창고관리ToolStripMenuItem
            // 
            this.창고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.창고등록ToolStripMenuItem,
            this.location등ToolStripMenuItem});
            this.창고관리ToolStripMenuItem.Name = "창고관리ToolStripMenuItem";
            this.창고관리ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.창고관리ToolStripMenuItem.Text = "창고관리";
            // 
            // 창고등록ToolStripMenuItem
            // 
            this.창고등록ToolStripMenuItem.Name = "창고등록ToolStripMenuItem";
            this.창고등록ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.창고등록ToolStripMenuItem.Text = "창고등록";
            this.창고등록ToolStripMenuItem.Click += new System.EventHandler(this.창고등록ToolStripMenuItem_Click);
            // 
            // location등ToolStripMenuItem
            // 
            this.location등ToolStripMenuItem.Name = "location등ToolStripMenuItem";
            this.location등ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.location등ToolStripMenuItem.Text = "Location등록";
            // 
            // testpageToolStripMenuItem
            // 
            this.testpageToolStripMenuItem.Name = "testpageToolStripMenuItem";
            this.testpageToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.testpageToolStripMenuItem.Text = "testpage";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보ToolStripMenuItem,
            this.프로그램사용법ToolStripMenuItem,
            this.toolStripSeparator4,
            this.사용의견보내기ToolStripMenuItem,
            this.공지사항ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // 프로그램사용법ToolStripMenuItem
            // 
            this.프로그램사용법ToolStripMenuItem.Name = "프로그램사용법ToolStripMenuItem";
            this.프로그램사용법ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.프로그램사용법ToolStripMenuItem.Text = "프로그램 사용법";
            this.프로그램사용법ToolStripMenuItem.Visible = false;
            this.프로그램사용법ToolStripMenuItem.Click += new System.EventHandler(this.프로그램사용법ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // 사용의견보내기ToolStripMenuItem
            // 
            this.사용의견보내기ToolStripMenuItem.Name = "사용의견보내기ToolStripMenuItem";
            this.사용의견보내기ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.사용의견보내기ToolStripMenuItem.Text = "사용의견 보내기";
            this.사용의견보내기ToolStripMenuItem.Visible = false;
            this.사용의견보내기ToolStripMenuItem.Click += new System.EventHandler(this.사용의견보내기ToolStripMenuItem_Click);
            // 
            // 공지사항ToolStripMenuItem
            // 
            this.공지사항ToolStripMenuItem.Name = "공지사항ToolStripMenuItem";
            this.공지사항ToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.공지사항ToolStripMenuItem.Text = "공지사항";
            this.공지사항ToolStripMenuItem.Click += new System.EventHandler(this.공지사항ToolStripMenuItem_Click);
            // 
            // 기초정보ToolStripMenuItem
            // 
            this.기초정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회사정보관리ToolStripMenuItem,
            this.이용자관리ToolStripMenuItem,
            this.시스템권한관리ToolStripMenuItem,
            this.toolStripSeparator1,
            this.공통코드관리ToolStripMenuItem,
            this.공휴일관리ToolStripMenuItem,
            this.기타수수료관리ToolStripMenuItem,
            this.toolStripSeparator2,
            this.대리점관리ToolStripMenuItem,
            this.가맹점관리ToolStripMenuItem,
            this.팝업SQL관리ToolStripMenuItem,
            this.채권사정보관리ToolStripMenuItem});
            this.기초정보ToolStripMenuItem.Name = "기초정보ToolStripMenuItem";
            this.기초정보ToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.기초정보ToolStripMenuItem.Tag = "BAS0000";
            this.기초정보ToolStripMenuItem.Text = "기초정보(&B)";
            // 
            // 회사정보관리ToolStripMenuItem
            // 
            this.회사정보관리ToolStripMenuItem.Name = "회사정보관리ToolStripMenuItem";
            this.회사정보관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.회사정보관리ToolStripMenuItem.Tag = "BAS0100";
            this.회사정보관리ToolStripMenuItem.Text = "운영회사정보관리";
            this.회사정보관리ToolStripMenuItem.Click += new System.EventHandler(this.회사정보관리ToolStripMenuItem_Click);
            // 
            // 이용자관리ToolStripMenuItem
            // 
            this.이용자관리ToolStripMenuItem.Name = "이용자관리ToolStripMenuItem";
            this.이용자관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.이용자관리ToolStripMenuItem.Tag = "BAS0200";
            this.이용자관리ToolStripMenuItem.Text = "이용자정보관리";
            this.이용자관리ToolStripMenuItem.Click += new System.EventHandler(this.이용자관리ToolStripMenuItem_Click);
            // 
            // 시스템권한관리ToolStripMenuItem
            // 
            this.시스템권한관리ToolStripMenuItem.Name = "시스템권한관리ToolStripMenuItem";
            this.시스템권한관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.시스템권한관리ToolStripMenuItem.Tag = "BAS0400";
            this.시스템권한관리ToolStripMenuItem.Text = "시스템권한관리";
            this.시스템권한관리ToolStripMenuItem.Click += new System.EventHandler(this.시스템권한관리ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // 공통코드관리ToolStripMenuItem
            // 
            this.공통코드관리ToolStripMenuItem.Name = "공통코드관리ToolStripMenuItem";
            this.공통코드관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.공통코드관리ToolStripMenuItem.Tag = "BAS0500";
            this.공통코드관리ToolStripMenuItem.Text = "공통코드관리";
            this.공통코드관리ToolStripMenuItem.Click += new System.EventHandler(this.공통코드관리ToolStripMenuItem_Click);
            // 
            // 공휴일관리ToolStripMenuItem
            // 
            this.공휴일관리ToolStripMenuItem.Name = "공휴일관리ToolStripMenuItem";
            this.공휴일관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.공휴일관리ToolStripMenuItem.Tag = "BAS0600";
            this.공휴일관리ToolStripMenuItem.Text = "공휴일관리";
            this.공휴일관리ToolStripMenuItem.Click += new System.EventHandler(this.공휴일관리ToolStripMenuItem_Click);
            // 
            // 기타수수료관리ToolStripMenuItem
            // 
            this.기타수수료관리ToolStripMenuItem.Name = "기타수수료관리ToolStripMenuItem";
            this.기타수수료관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.기타수수료관리ToolStripMenuItem.Tag = "BAS0813";
            this.기타수수료관리ToolStripMenuItem.Text = "기타수수료관리";
            this.기타수수료관리ToolStripMenuItem.Click += new System.EventHandler(this.기타수수료관리ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // 대리점관리ToolStripMenuItem
            // 
            this.대리점관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.대리점정보관리ToolStripMenuItem,
            this.공정관리ToolStripMenuItem,
            this.작업장1별공정등록ToolStripMenuItem1,
            this.보증예치금관리ToolStripMenuItem1,
            this.보증보험관리ToolStripMenuItem1,
            this.toolStripSeparator7,
            this.작업장별공정등록ToolStripMenuItem,
            this.구비서류이력조회ToolStripMenuItem});
            this.대리점관리ToolStripMenuItem.Name = "대리점관리ToolStripMenuItem";
            this.대리점관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.대리점관리ToolStripMenuItem.Tag = "BAS7000";
            this.대리점관리ToolStripMenuItem.Text = "대리점관리";
            // 
            // 대리점정보관리ToolStripMenuItem
            // 
            this.대리점정보관리ToolStripMenuItem.Name = "대리점정보관리ToolStripMenuItem";
            this.대리점정보관리ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.대리점정보관리ToolStripMenuItem.Tag = "BAS0700";
            this.대리점정보관리ToolStripMenuItem.Text = "작업장관리";
            this.대리점정보관리ToolStripMenuItem.Click += new System.EventHandler(this.작업장관리ToolStripMenuItem_Click);
            // 
            // 공정관리ToolStripMenuItem
            // 
            this.공정관리ToolStripMenuItem.Name = "공정관리ToolStripMenuItem";
            this.공정관리ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.공정관리ToolStripMenuItem.Tag = "BAS0740";
            this.공정관리ToolStripMenuItem.Text = "공정관리";
            this.공정관리ToolStripMenuItem.Click += new System.EventHandler(this.공정관리ToolStripMenuItem_Click);
            // 
            // 작업장1별공정등록ToolStripMenuItem1
            // 
            this.작업장1별공정등록ToolStripMenuItem1.Name = "작업장1별공정등록ToolStripMenuItem1";
            this.작업장1별공정등록ToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.작업장1별공정등록ToolStripMenuItem1.Tag = "BAS0770";
            this.작업장1별공정등록ToolStripMenuItem1.Text = "작업장1별공정등록";
            // 
            // 보증예치금관리ToolStripMenuItem1
            // 
            this.보증예치금관리ToolStripMenuItem1.Name = "보증예치금관리ToolStripMenuItem1";
            this.보증예치금관리ToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.보증예치금관리ToolStripMenuItem1.Tag = "BAS0750";
            this.보증예치금관리ToolStripMenuItem1.Text = "보증예치금관리";
            this.보증예치금관리ToolStripMenuItem1.Click += new System.EventHandler(this.보증예치금관리ToolStripMenuItem1_Click);
            // 
            // 보증보험관리ToolStripMenuItem1
            // 
            this.보증보험관리ToolStripMenuItem1.Name = "보증보험관리ToolStripMenuItem1";
            this.보증보험관리ToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.보증보험관리ToolStripMenuItem1.Tag = "BAS0755";
            this.보증보험관리ToolStripMenuItem1.Text = "보증보험관리";
            this.보증보험관리ToolStripMenuItem1.Click += new System.EventHandler(this.보증보험관리ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(209, 6);
            // 
            // 작업장별공정등록ToolStripMenuItem
            // 
            this.작업장별공정등록ToolStripMenuItem.Name = "작업장별공정등록ToolStripMenuItem";
            this.작업장별공정등록ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.작업장별공정등록ToolStripMenuItem.Text = "작업장별공정등록";
            this.작업장별공정등록ToolStripMenuItem.Click += new System.EventHandler(this.작업장별공정등록ToolStripMenuItem1_Click);
            // 
            // 구비서류이력조회ToolStripMenuItem
            // 
            this.구비서류이력조회ToolStripMenuItem.Name = "구비서류이력조회ToolStripMenuItem";
            this.구비서류이력조회ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.구비서류이력조회ToolStripMenuItem.Tag = "BAS0780";
            this.구비서류이력조회ToolStripMenuItem.Text = "구비서류이력조회";
            this.구비서류이력조회ToolStripMenuItem.Click += new System.EventHandler(this.구비서류이력조회ToolStripMenuItem_Click);
            // 
            // 가맹점관리ToolStripMenuItem
            // 
            this.가맹점관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공정별품목등록ToolStripMenuItem,
            this.정산계약정보관리ToolStripMenuItem,
            this.매입카드관리ToolStripMenuItem,
            this.toolStripSeparator8,
            this.강제출금자동차감관리ToolStripMenuItem,
            this.보증예치금관리ToolStripMenuItem,
            this.보증보험관리ToolStripMenuItem,
            this.연대보증인관리ToolStripMenuItem,
            this.toolStripSeparator9,
            this.정산계약정보이력조회ToolStripMenuItem1,
            this.매입카드이력조회ToolStripMenuItem,
            this.기타수수료이력조회ToolStripMenuItem,
            this.강제출금자동차감이력조회ToolStripMenuItem,
            this.보증예치금이력조회ToolStripMenuItem,
            this.보증보험이력조회ToolStripMenuItem,
            this.연대보증인이력조회ToolStripMenuItem,
            this.구비서류이력조회ToolStripMenuItem1});
            this.가맹점관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.가맹점관리ToolStripMenuItem.Name = "가맹점관리ToolStripMenuItem";
            this.가맹점관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.가맹점관리ToolStripMenuItem.Tag = "BAS8000";
            this.가맹점관리ToolStripMenuItem.Text = "가맹점관리";
            // 
            // 공정별품목등록ToolStripMenuItem
            // 
            this.공정별품목등록ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.공정별품목등록ToolStripMenuItem.Name = "공정별품목등록ToolStripMenuItem";
            this.공정별품목등록ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.공정별품목등록ToolStripMenuItem.Tag = "BAS0800";
            this.공정별품목등록ToolStripMenuItem.Text = "공정별품목등록";
            this.공정별품목등록ToolStripMenuItem.Click += new System.EventHandler(this.공정별품목등록ToolStripMenuItem_Click);
            // 
            // 정산계약정보관리ToolStripMenuItem
            // 
            this.정산계약정보관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.정산계약정보관리ToolStripMenuItem.Name = "정산계약정보관리ToolStripMenuItem";
            this.정산계약정보관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.정산계약정보관리ToolStripMenuItem.Tag = "BAS0805";
            this.정산계약정보관리ToolStripMenuItem.Text = "정산/계약정보관리";
            this.정산계약정보관리ToolStripMenuItem.Click += new System.EventHandler(this.정산계약정보관리ToolStripMenuItem_Click);
            // 
            // 매입카드관리ToolStripMenuItem
            // 
            this.매입카드관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.매입카드관리ToolStripMenuItem.Name = "매입카드관리ToolStripMenuItem";
            this.매입카드관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.매입카드관리ToolStripMenuItem.Tag = "BAS0810";
            this.매입카드관리ToolStripMenuItem.Text = "매입카드관리";
            this.매입카드관리ToolStripMenuItem.Click += new System.EventHandler(this.매입카드관리ToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(267, 6);
            // 
            // 강제출금자동차감관리ToolStripMenuItem
            // 
            this.강제출금자동차감관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.강제출금자동차감관리ToolStripMenuItem.Name = "강제출금자동차감관리ToolStripMenuItem";
            this.강제출금자동차감관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.강제출금자동차감관리ToolStripMenuItem.Tag = "BAS0814";
            this.강제출금자동차감관리ToolStripMenuItem.Text = "강제출금/자동차감관리";
            this.강제출금자동차감관리ToolStripMenuItem.Click += new System.EventHandler(this.강제출금자동차감관리ToolStripMenuItem_Click);
            // 
            // 보증예치금관리ToolStripMenuItem
            // 
            this.보증예치금관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.보증예치금관리ToolStripMenuItem.Name = "보증예치금관리ToolStripMenuItem";
            this.보증예치금관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.보증예치금관리ToolStripMenuItem.Tag = "BAS0816";
            this.보증예치금관리ToolStripMenuItem.Text = "보증예치금관리";
            this.보증예치금관리ToolStripMenuItem.Click += new System.EventHandler(this.보증예치금관리ToolStripMenuItem_Click);
            // 
            // 보증보험관리ToolStripMenuItem
            // 
            this.보증보험관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.보증보험관리ToolStripMenuItem.Name = "보증보험관리ToolStripMenuItem";
            this.보증보험관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.보증보험관리ToolStripMenuItem.Tag = "BAS0815";
            this.보증보험관리ToolStripMenuItem.Text = "보증보험관리";
            this.보증보험관리ToolStripMenuItem.Click += new System.EventHandler(this.보증보험관리ToolStripMenuItem_Click);
            // 
            // 연대보증인관리ToolStripMenuItem
            // 
            this.연대보증인관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.연대보증인관리ToolStripMenuItem.Name = "연대보증인관리ToolStripMenuItem";
            this.연대보증인관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.연대보증인관리ToolStripMenuItem.Tag = "BAS0817";
            this.연대보증인관리ToolStripMenuItem.Text = "연대보증인관리";
            this.연대보증인관리ToolStripMenuItem.Click += new System.EventHandler(this.연대보증인관리ToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(267, 6);
            // 
            // 정산계약정보이력조회ToolStripMenuItem1
            // 
            this.정산계약정보이력조회ToolStripMenuItem1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.정산계약정보이력조회ToolStripMenuItem1.Name = "정산계약정보이력조회ToolStripMenuItem1";
            this.정산계약정보이력조회ToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.정산계약정보이력조회ToolStripMenuItem1.Tag = "BAS0818";
            this.정산계약정보이력조회ToolStripMenuItem1.Text = "정산/계약정보이력조회";
            this.정산계약정보이력조회ToolStripMenuItem1.Click += new System.EventHandler(this.정산계약정보이력조회ToolStripMenuItem1_Click);
            // 
            // 매입카드이력조회ToolStripMenuItem
            // 
            this.매입카드이력조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.매입카드이력조회ToolStripMenuItem.Name = "매입카드이력조회ToolStripMenuItem";
            this.매입카드이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.매입카드이력조회ToolStripMenuItem.Tag = "BAS0819";
            this.매입카드이력조회ToolStripMenuItem.Text = "매입카드이력조회";
            this.매입카드이력조회ToolStripMenuItem.Click += new System.EventHandler(this.매입카드이력조회ToolStripMenuItem_Click);
            // 
            // 기타수수료이력조회ToolStripMenuItem
            // 
            this.기타수수료이력조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.기타수수료이력조회ToolStripMenuItem.Name = "기타수수료이력조회ToolStripMenuItem";
            this.기타수수료이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.기타수수료이력조회ToolStripMenuItem.Tag = "BAS0820";
            this.기타수수료이력조회ToolStripMenuItem.Text = "기타수수료이력조회";
            this.기타수수료이력조회ToolStripMenuItem.Click += new System.EventHandler(this.기타수수료이력조회ToolStripMenuItem_Click);
            // 
            // 강제출금자동차감이력조회ToolStripMenuItem
            // 
            this.강제출금자동차감이력조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.강제출금자동차감이력조회ToolStripMenuItem.Name = "강제출금자동차감이력조회ToolStripMenuItem";
            this.강제출금자동차감이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.강제출금자동차감이력조회ToolStripMenuItem.Tag = "BAS0821";
            this.강제출금자동차감이력조회ToolStripMenuItem.Text = "강제출금/자동차감이력조회";
            this.강제출금자동차감이력조회ToolStripMenuItem.Click += new System.EventHandler(this.강제출금자동차감이력조회ToolStripMenuItem_Click);
            // 
            // 보증예치금이력조회ToolStripMenuItem
            // 
            this.보증예치금이력조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.보증예치금이력조회ToolStripMenuItem.Name = "보증예치금이력조회ToolStripMenuItem";
            this.보증예치금이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.보증예치금이력조회ToolStripMenuItem.Tag = "BAS0822";
            this.보증예치금이력조회ToolStripMenuItem.Text = "보증예치금이력조회";
            this.보증예치금이력조회ToolStripMenuItem.Click += new System.EventHandler(this.보증예치금이력조회ToolStripMenuItem_Click);
            // 
            // 보증보험이력조회ToolStripMenuItem
            // 
            this.보증보험이력조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.보증보험이력조회ToolStripMenuItem.Name = "보증보험이력조회ToolStripMenuItem";
            this.보증보험이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.보증보험이력조회ToolStripMenuItem.Tag = "BAS0823";
            this.보증보험이력조회ToolStripMenuItem.Text = "보증보험이력조회";
            this.보증보험이력조회ToolStripMenuItem.Click += new System.EventHandler(this.보증보험이력조회ToolStripMenuItem_Click);
            // 
            // 연대보증인이력조회ToolStripMenuItem
            // 
            this.연대보증인이력조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.연대보증인이력조회ToolStripMenuItem.Name = "연대보증인이력조회ToolStripMenuItem";
            this.연대보증인이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.연대보증인이력조회ToolStripMenuItem.Tag = "BAS0824";
            this.연대보증인이력조회ToolStripMenuItem.Text = "연대보증인이력조회";
            this.연대보증인이력조회ToolStripMenuItem.Click += new System.EventHandler(this.연대보증인이력조회ToolStripMenuItem_Click);
            // 
            // 구비서류이력조회ToolStripMenuItem1
            // 
            this.구비서류이력조회ToolStripMenuItem1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.구비서류이력조회ToolStripMenuItem1.Name = "구비서류이력조회ToolStripMenuItem1";
            this.구비서류이력조회ToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.구비서류이력조회ToolStripMenuItem1.Tag = "BAS0825";
            this.구비서류이력조회ToolStripMenuItem1.Text = "구비서류이력조회";
            this.구비서류이력조회ToolStripMenuItem1.Click += new System.EventHandler(this.구비서류이력조회ToolStripMenuItem1_Click);
            // 
            // 팝업SQL관리ToolStripMenuItem
            // 
            this.팝업SQL관리ToolStripMenuItem.Name = "팝업SQL관리ToolStripMenuItem";
            this.팝업SQL관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.팝업SQL관리ToolStripMenuItem.Tag = "BAS0900";
            this.팝업SQL관리ToolStripMenuItem.Text = "팝업SQL관리";
            this.팝업SQL관리ToolStripMenuItem.Click += new System.EventHandler(this.팝업SQL관리ToolStripMenuItem_Click);
            // 
            // 채권사정보관리ToolStripMenuItem
            // 
            this.채권사정보관리ToolStripMenuItem.Enabled = false;
            this.채권사정보관리ToolStripMenuItem.Name = "채권사정보관리ToolStripMenuItem";
            this.채권사정보관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.채권사정보관리ToolStripMenuItem.Text = "채권사정보관리";
            this.채권사정보관리ToolStripMenuItem.Visible = false;
            this.채권사정보관리ToolStripMenuItem.Click += new System.EventHandler(this.채권사정보관리ToolStripMenuItem_Click);
            // 
            // 출금관리ToolStripMenuItem
            // 
            this.출금관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.중복예상거래관리ToolStripMenuItem,
            this.미요청거래관리ToolStripMenuItem,
            this.한도초과거래관리ToolStripMenuItem,
            this.toolStripSeparator12,
            this.출금요청관리ToolStripMenuItem,
            this.출금요청사용자취소관리toolStripMenuItem,
            this.출금후취소관리ToolStripMenuItem,
            this.출금승인관리ToolStripMenuItem,
            this.toolStripSeparator5,
            this.출금원장조회ToolStripMenuItem,
            this.거래원장조회ToolStripMenuItem,
            this.강제출금관리ToolStripMenuItem,
            this.보증예치금적립내역조회toolStripMenuItem,
            this.기타수수료차감내역조회ToolStripMenuItem,
            this.toolStripSeparator10,
            this.출금관리이력조회ToolStripMenuItem,
            this.출금요청이력조회ToolStripMenuItem,
            this.출금실패이력조회ToolStripMenuItem,
            this.출금승인이력조회ToolStripMenuItem});
            this.출금관리ToolStripMenuItem.Name = "출금관리ToolStripMenuItem";
            this.출금관리ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.출금관리ToolStripMenuItem.Tag = "WDR0000";
            this.출금관리ToolStripMenuItem.Text = "금형(&W)";
            // 
            // 중복예상거래관리ToolStripMenuItem
            // 
            this.중복예상거래관리ToolStripMenuItem.Name = "중복예상거래관리ToolStripMenuItem";
            this.중복예상거래관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.중복예상거래관리ToolStripMenuItem.Tag = "WDR0100";
            this.중복예상거래관리ToolStripMenuItem.Text = "금형등록";
            this.중복예상거래관리ToolStripMenuItem.Click += new System.EventHandler(this.금형관리ToolStripMenuItem_Click);
            // 
            // 미요청거래관리ToolStripMenuItem
            // 
            this.미요청거래관리ToolStripMenuItem.Name = "미요청거래관리ToolStripMenuItem";
            this.미요청거래관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.미요청거래관리ToolStripMenuItem.Tag = "WDR0200";
            this.미요청거래관리ToolStripMenuItem.Text = "미요청거래관리";
            this.미요청거래관리ToolStripMenuItem.Click += new System.EventHandler(this.미요청거래관리ToolStripMenuItem_Click);
            // 
            // 한도초과거래관리ToolStripMenuItem
            // 
            this.한도초과거래관리ToolStripMenuItem.Name = "한도초과거래관리ToolStripMenuItem";
            this.한도초과거래관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.한도초과거래관리ToolStripMenuItem.Tag = "WDR0300";
            this.한도초과거래관리ToolStripMenuItem.Text = "한도초과거래관리";
            this.한도초과거래관리ToolStripMenuItem.Click += new System.EventHandler(this.한도초과거래관리ToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(267, 6);
            // 
            // 출금요청관리ToolStripMenuItem
            // 
            this.출금요청관리ToolStripMenuItem.Name = "출금요청관리ToolStripMenuItem";
            this.출금요청관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금요청관리ToolStripMenuItem.Tag = "WDR0400";
            this.출금요청관리ToolStripMenuItem.Text = "출금요청관리";
            this.출금요청관리ToolStripMenuItem.Click += new System.EventHandler(this.출금요청관리ToolStripMenuItem_Click);
            // 
            // 출금요청사용자취소관리toolStripMenuItem
            // 
            this.출금요청사용자취소관리toolStripMenuItem.Name = "출금요청사용자취소관리toolStripMenuItem";
            this.출금요청사용자취소관리toolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금요청사용자취소관리toolStripMenuItem.Tag = "WDR0450";
            this.출금요청사용자취소관리toolStripMenuItem.Text = "출금요청실패관리";
            this.출금요청사용자취소관리toolStripMenuItem.Click += new System.EventHandler(this.출금요청사용자취소관리toolStripMenuItem_Click);
            // 
            // 출금후취소관리ToolStripMenuItem
            // 
            this.출금후취소관리ToolStripMenuItem.Name = "출금후취소관리ToolStripMenuItem";
            this.출금후취소관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금후취소관리ToolStripMenuItem.Tag = "WDR0480";
            this.출금후취소관리ToolStripMenuItem.Text = "출금후취소관리";
            this.출금후취소관리ToolStripMenuItem.Click += new System.EventHandler(this.출금후취소관리ToolStripMenuItem_Click);
            // 
            // 출금승인관리ToolStripMenuItem
            // 
            this.출금승인관리ToolStripMenuItem.Name = "출금승인관리ToolStripMenuItem";
            this.출금승인관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금승인관리ToolStripMenuItem.Tag = "WDR0500";
            this.출금승인관리ToolStripMenuItem.Text = "출금승인관리";
            this.출금승인관리ToolStripMenuItem.Click += new System.EventHandler(this.출금승인관리ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
            // 
            // 출금원장조회ToolStripMenuItem
            // 
            this.출금원장조회ToolStripMenuItem.Name = "출금원장조회ToolStripMenuItem";
            this.출금원장조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금원장조회ToolStripMenuItem.Tag = "WDR0600";
            this.출금원장조회ToolStripMenuItem.Text = "출금원장조회";
            this.출금원장조회ToolStripMenuItem.Click += new System.EventHandler(this.출금원장조회ToolStripMenuItem_Click);
            // 
            // 거래원장조회ToolStripMenuItem
            // 
            this.거래원장조회ToolStripMenuItem.Name = "거래원장조회ToolStripMenuItem";
            this.거래원장조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.거래원장조회ToolStripMenuItem.Tag = "WDR0700";
            this.거래원장조회ToolStripMenuItem.Text = "거래원장조회";
            this.거래원장조회ToolStripMenuItem.Click += new System.EventHandler(this.거래원장조회ToolStripMenuItem_Click);
            // 
            // 강제출금관리ToolStripMenuItem
            // 
            this.강제출금관리ToolStripMenuItem.Name = "강제출금관리ToolStripMenuItem";
            this.강제출금관리ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.강제출금관리ToolStripMenuItem.Tag = "WDR0810";
            this.강제출금관리ToolStripMenuItem.Text = "강제출금/자동차감내역조회";
            this.강제출금관리ToolStripMenuItem.Click += new System.EventHandler(this.강제출금관리ToolStripMenuItem_Click);
            // 
            // 보증예치금적립내역조회toolStripMenuItem
            // 
            this.보증예치금적립내역조회toolStripMenuItem.Name = "보증예치금적립내역조회toolStripMenuItem";
            this.보증예치금적립내역조회toolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.보증예치금적립내역조회toolStripMenuItem.Tag = "WDR0910";
            this.보증예치금적립내역조회toolStripMenuItem.Text = "보증예치금적립내역조회";
            this.보증예치금적립내역조회toolStripMenuItem.Click += new System.EventHandler(this.보증예치금적립내역조회toolStripMenuItem_Click);
            // 
            // 기타수수료차감내역조회ToolStripMenuItem
            // 
            this.기타수수료차감내역조회ToolStripMenuItem.Name = "기타수수료차감내역조회ToolStripMenuItem";
            this.기타수수료차감내역조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.기타수수료차감내역조회ToolStripMenuItem.Tag = "WDR1010";
            this.기타수수료차감내역조회ToolStripMenuItem.Text = "기타수수료차감내역조회";
            this.기타수수료차감내역조회ToolStripMenuItem.Click += new System.EventHandler(this.기타수수료차감내역조회ToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(267, 6);
            // 
            // 출금관리이력조회ToolStripMenuItem
            // 
            this.출금관리이력조회ToolStripMenuItem.Name = "출금관리이력조회ToolStripMenuItem";
            this.출금관리이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금관리이력조회ToolStripMenuItem.Tag = "WDR1110";
            this.출금관리이력조회ToolStripMenuItem.Text = "출금관리이력조회";
            this.출금관리이력조회ToolStripMenuItem.Click += new System.EventHandler(this.중복해제이력조회ToolStripMenuItem_Click);
            // 
            // 출금요청이력조회ToolStripMenuItem
            // 
            this.출금요청이력조회ToolStripMenuItem.Name = "출금요청이력조회ToolStripMenuItem";
            this.출금요청이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금요청이력조회ToolStripMenuItem.Tag = "WDR1210";
            this.출금요청이력조회ToolStripMenuItem.Text = "출금요청이력조회";
            this.출금요청이력조회ToolStripMenuItem.Click += new System.EventHandler(this.출금요청이력조회ToolStripMenuItem_Click);
            // 
            // 출금실패이력조회ToolStripMenuItem
            // 
            this.출금실패이력조회ToolStripMenuItem.Name = "출금실패이력조회ToolStripMenuItem";
            this.출금실패이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금실패이력조회ToolStripMenuItem.Tag = "WDR1310";
            this.출금실패이력조회ToolStripMenuItem.Text = "출금실패이력조회";
            this.출금실패이력조회ToolStripMenuItem.Click += new System.EventHandler(this.출금실패이력조회ToolStripMenuItem_Click);
            // 
            // 출금승인이력조회ToolStripMenuItem
            // 
            this.출금승인이력조회ToolStripMenuItem.Name = "출금승인이력조회ToolStripMenuItem";
            this.출금승인이력조회ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.출금승인이력조회ToolStripMenuItem.Tag = "WDR1410";
            this.출금승인이력조회ToolStripMenuItem.Text = "출금승인이력조회";
            this.출금승인이력조회ToolStripMenuItem.Click += new System.EventHandler(this.출금승인이력조회ToolStripMenuItem_Click);
            // 
            // 정산관리ToolStripMenuItem
            // 
            this.정산관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정산마감처리ToolStripMenuItem,
            this.정산내역조회ToolStripMenuItem,
            this.정산마감이력조회ToolStripMenuItem,
            this.세금계산서관리ToolStripMenuItem});
            this.정산관리ToolStripMenuItem.Name = "정산관리ToolStripMenuItem";
            this.정산관리ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.정산관리ToolStripMenuItem.Tag = "ACC0000";
            this.정산관리ToolStripMenuItem.Text = "정산관리(&A)";
            this.정산관리ToolStripMenuItem.Click += new System.EventHandler(this.정산관리ToolStripMenuItem_Click);
            // 
            // 정산마감처리ToolStripMenuItem
            // 
            this.정산마감처리ToolStripMenuItem.Name = "정산마감처리ToolStripMenuItem";
            this.정산마감처리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.정산마감처리ToolStripMenuItem.Tag = "ACC0100";
            this.정산마감처리ToolStripMenuItem.Text = "정산마감처리";
            this.정산마감처리ToolStripMenuItem.Click += new System.EventHandler(this.정산마감처리ToolStripMenuItem_Click);
            // 
            // 정산내역조회ToolStripMenuItem
            // 
            this.정산내역조회ToolStripMenuItem.Name = "정산내역조회ToolStripMenuItem";
            this.정산내역조회ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.정산내역조회ToolStripMenuItem.Tag = "ACC0200";
            this.정산내역조회ToolStripMenuItem.Text = "정산내역조회";
            this.정산내역조회ToolStripMenuItem.Click += new System.EventHandler(this.정산내역조회ToolStripMenuItem_Click);
            // 
            // 정산마감이력조회ToolStripMenuItem
            // 
            this.정산마감이력조회ToolStripMenuItem.Name = "정산마감이력조회ToolStripMenuItem";
            this.정산마감이력조회ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.정산마감이력조회ToolStripMenuItem.Tag = "ACC0310";
            this.정산마감이력조회ToolStripMenuItem.Text = "정산마감이력조회";
            this.정산마감이력조회ToolStripMenuItem.Click += new System.EventHandler(this.정산마감이력조회ToolStripMenuItem_Click);
            // 
            // 세금계산서관리ToolStripMenuItem
            // 
            this.세금계산서관리ToolStripMenuItem.Name = "세금계산서관리ToolStripMenuItem";
            this.세금계산서관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.세금계산서관리ToolStripMenuItem.Tag = "ACC0410";
            this.세금계산서관리ToolStripMenuItem.Text = "세금계산서관리";
            this.세금계산서관리ToolStripMenuItem.Click += new System.EventHandler(this.세금계산서관리ToolStripMenuItem_Click);
            // 
            // 상환관리ToolStripMenuItem
            // 
            this.상환관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상환마감처리ToolStripMenuItem,
            this.카드사별입금내역조회ToolStripMenuItem,
            this.상환예정내역조회ToolStripMenuItem,
            this.toolStripSeparator15,
            this.상환마감이력조회ToolStripMenuItem});
            this.상환관리ToolStripMenuItem.Name = "상환관리ToolStripMenuItem";
            this.상환관리ToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.상환관리ToolStripMenuItem.Tag = "RDM0000";
            this.상환관리ToolStripMenuItem.Text = "상환관리(&R)";
            // 
            // 상환마감처리ToolStripMenuItem
            // 
            this.상환마감처리ToolStripMenuItem.Name = "상환마감처리ToolStripMenuItem";
            this.상환마감처리ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.상환마감처리ToolStripMenuItem.Tag = "RDM0110";
            this.상환마감처리ToolStripMenuItem.Text = "상환마감처리";
            this.상환마감처리ToolStripMenuItem.Click += new System.EventHandler(this.상환마감처리ToolStripMenuItem_Click);
            // 
            // 카드사별입금내역조회ToolStripMenuItem
            // 
            this.카드사별입금내역조회ToolStripMenuItem.Name = "카드사별입금내역조회ToolStripMenuItem";
            this.카드사별입금내역조회ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.카드사별입금내역조회ToolStripMenuItem.Tag = "RDM0210";
            this.카드사별입금내역조회ToolStripMenuItem.Text = "카드사별입금내역조회";
            this.카드사별입금내역조회ToolStripMenuItem.Click += new System.EventHandler(this.카드사별입금내역조회ToolStripMenuItem_Click);
            // 
            // 상환예정내역조회ToolStripMenuItem
            // 
            this.상환예정내역조회ToolStripMenuItem.Name = "상환예정내역조회ToolStripMenuItem";
            this.상환예정내역조회ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.상환예정내역조회ToolStripMenuItem.Tag = "RDM0310";
            this.상환예정내역조회ToolStripMenuItem.Text = "상환예정내역조회";
            this.상환예정내역조회ToolStripMenuItem.Click += new System.EventHandler(this.상환예정내역조회ToolStripMenuItem_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(231, 6);
            // 
            // 상환마감이력조회ToolStripMenuItem
            // 
            this.상환마감이력조회ToolStripMenuItem.Name = "상환마감이력조회ToolStripMenuItem";
            this.상환마감이력조회ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.상환마감이력조회ToolStripMenuItem.Tag = "RDM0410";
            this.상환마감이력조회ToolStripMenuItem.Text = "상환마감이력조회";
            this.상환마감이력조회ToolStripMenuItem.Click += new System.EventHandler(this.상환마감이력조회ToolStripMenuItem_Click);
            // 
            // 대출관리ToolStripMenuItem
            // 
            this.대출관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.대출원장관리ToolStripMenuItem,
            this.비즈론계산기ToolStripMenuItem});
            this.대출관리ToolStripMenuItem.Name = "대출관리ToolStripMenuItem";
            this.대출관리ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.대출관리ToolStripMenuItem.Tag = "LRN0000";
            this.대출관리ToolStripMenuItem.Text = "비즈론관리(&L)";
            // 
            // 대출원장관리ToolStripMenuItem
            // 
            this.대출원장관리ToolStripMenuItem.Name = "대출원장관리ToolStripMenuItem";
            this.대출원장관리ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.대출원장관리ToolStripMenuItem.Tag = "LRN0100";
            this.대출원장관리ToolStripMenuItem.Text = "비즈론원장관리";
            this.대출원장관리ToolStripMenuItem.Click += new System.EventHandler(this.대출원장관리ToolStripMenuItem_Click);
            // 
            // 비즈론계산기ToolStripMenuItem
            // 
            this.비즈론계산기ToolStripMenuItem.Name = "비즈론계산기ToolStripMenuItem";
            this.비즈론계산기ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.비즈론계산기ToolStripMenuItem.Tag = "LRN0200";
            this.비즈론계산기ToolStripMenuItem.Text = "비즈론계산기";
            this.비즈론계산기ToolStripMenuItem.Click += new System.EventHandler(this.비즈론계산기ToolStripMenuItem_Click);
            // 
            // 채권관리ToolStripMenuItem
            // 
            this.채권관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확정채권회수관리ToolStripMenuItem});
            this.채권관리ToolStripMenuItem.Name = "채권관리ToolStripMenuItem";
            this.채권관리ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.채권관리ToolStripMenuItem.Tag = "BND0000";
            this.채권관리ToolStripMenuItem.Text = "채권관리(&D)";
            // 
            // 확정채권회수관리ToolStripMenuItem
            // 
            this.확정채권회수관리ToolStripMenuItem.Name = "확정채권회수관리ToolStripMenuItem";
            this.확정채권회수관리ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.확정채권회수관리ToolStripMenuItem.Tag = "BND0100";
            this.확정채권회수관리ToolStripMenuItem.Text = "확정채권회수관리";
            // 
            // 리스크관리ToolStripMenuItem
            // 
            this.리스크관리ToolStripMenuItem.Enabled = false;
            this.리스크관리ToolStripMenuItem.Name = "리스크관리ToolStripMenuItem";
            this.리스크관리ToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.리스크관리ToolStripMenuItem.Tag = "RSK0000";
            this.리스크관리ToolStripMenuItem.Text = "리스크관리(&R)";
            // 
            // toolStripWindow
            // 
            this.toolStripWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모든창닫기ToolStripMenuItem,
            this.toolStripSeparator11});
            this.toolStripWindow.Name = "toolStripWindow";
            this.toolStripWindow.Size = new System.Drawing.Size(60, 24);
            this.toolStripWindow.Text = "창(&W)";
            // 
            // 모든창닫기ToolStripMenuItem
            // 
            this.모든창닫기ToolStripMenuItem.Name = "모든창닫기ToolStripMenuItem";
            this.모든창닫기ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.모든창닫기ToolStripMenuItem.Text = "모든 창 닫기";
            this.모든창닫기ToolStripMenuItem.Click += new System.EventHandler(this.toolStrip모두닫기_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(166, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 792);
            this.Controls.Add(this._tbMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "ESUNG_ERP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this._tbMain.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripMenuItem 기초정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripWindow;
		private System.Windows.Forms.ToolStripMenuItem 이용자관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 시스템권한관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 공통코드관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 대리점관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 가맹점관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton _tsbAffiliate;
		private System.Windows.Forms.ToolStripButton _tsbSalesRowData;
		private System.Windows.Forms.ToolStripButton _tsbIncomingAmount;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton _tsbConfig;
		private System.Windows.Forms.ToolStripButton _tsbExit;
		private System.Windows.Forms.ToolStripMenuItem 공휴일관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 대리점정보관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 공정별품목등록ToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox _tscbCompany;
		private System.Windows.Forms.ToolStripMenuItem 출금관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 거래원장조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상환관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 카드사별입금내역조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 대출관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 정산관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 채권관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 공정관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 정산마감처리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 강제출금관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상환예정내역조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 대출원장관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 정산내역조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 회사정보관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 프로그램사용법ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem 사용의견보내기ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 공지사항ToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton _tsbChangePwd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripStatusLabel _tsslStopwatch;
		private System.Windows.Forms.ToolStripStatusLabel _tsslClock;
		private System.Windows.Forms.ToolStripMenuItem 리스크관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 보증예치금관리ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 매입카드관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 보증예치금관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 세금계산서관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem 작업장별공정등록ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 구비서류이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem 보증보험관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 연대보증인관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 정산계약정보관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem 정산계약정보이력조회ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 매입카드이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 보증예치금이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 보증보험이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 연대보증인이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 구비서류이력조회ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 강제출금자동차감관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 확정채권회수관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 팝업SQL관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 채권사정보관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 중복예상거래관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 작업장1별공정등록ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 출금요청관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 출금승인관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 출금원장조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상환마감처리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripMenuItem 출금관리이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 모든창닫기ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripMenuItem 미요청거래관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 한도초과거래관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		public System.Windows.Forms.ToolStripStatusLabel TsslNotice;
		private System.Windows.Forms.ToolStripStatusLabel TsslFeedback;
		private System.Windows.Forms.ToolStripStatusLabel _tsslPeriod;
		private System.Windows.Forms.ToolStripButton _tsbWithdrawRowData;
		private BANANA.Windows.Controls.TabControl _tbMain;
		private System.Windows.Forms.TabPage _tpHOME;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.ToolStripButton _tsbCalMagam;
		private System.Windows.Forms.ToolStripButton _tsbReturnMagam;
		private System.Windows.Forms.ToolStripMenuItem 출금요청사용자취소관리toolStripMenuItem;
		public System.Windows.Forms.ToolStripStatusLabel TsslStatus;
		private System.Windows.Forms.ToolStripMenuItem 보증예치금적립내역조회toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 기타수수료차감내역조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 출금요청이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 출금실패이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 출금승인이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 정산마감이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
		private System.Windows.Forms.ToolStripMenuItem 상환마감이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 기타수수료이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 강제출금자동차감이력조회ToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel _tsslDB;
		private System.Windows.Forms.ToolStripMenuItem 보증보험관리ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 기타수수료관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 비즈론계산기ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 출금후취소관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기초정보ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 품목등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목등록ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bOM등록ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 생산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작업장등록ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 작업장등록ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 공정등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공정별품번등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설비ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설비관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설비등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 금형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 금형관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 금형관리ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 기준정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래처관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래처등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창고등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem location등ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 물류ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 단가관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매입단가등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출단가등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testpageToolStripMenuItem;
    }
}



