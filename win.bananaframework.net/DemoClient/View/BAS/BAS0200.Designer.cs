namespace DemoClient.View.BAS
{
	partial class BAS0200
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0200));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DemoClient.Controls.GridView();
            this.USRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USRNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USR_GUBUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAXNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_BSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LST_LGN_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WRNG_PWD_CNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCK_ACCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collapsibleSplitter1 = new DemoClient.Controls.CollapsibleSplitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this._cmbDEPT_CD = new BANANA.Windows.Controls.ComboBox();
            this._cmbUSR_GUBUN = new BANANA.Windows.Controls.ComboBox();
            this._lblLCK_ACCT = new System.Windows.Forms.Label();
            this._lblWRNG_PWD_CNT = new System.Windows.Forms.Label();
            this._lblLST_LGN_TIME = new System.Windows.Forms.Label();
            this._txtADDR_DTL = new BANANA.Windows.Controls.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnFindZipCode01 = new DemoClient.Controls.BananaButton();
            this._txtZIP_NO = new BANANA.Windows.Controls.TextBox();
            this._txtADDR_BSC = new BANANA.Windows.Controls.TextBox();
            this._txtEMAIL = new BANANA.Windows.Controls.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtHPNO = new BANANA.Windows.Controls.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtPWD1 = new BANANA.Windows.Controls.TextBox();
            this._txtUSRNM = new BANANA.Windows.Controls.TextBox();
            this.label101 = new BANANA.Windows.Controls.Label();
            this.lblUSR_ID = new BANANA.Windows.Controls.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUSR_PASS = new BANANA.Windows.Controls.Label();
            this.lblUSR_ROLL = new BANANA.Windows.Controls.Label();
            this._txtUSRID = new BANANA.Windows.Controls.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTELNO = new BANANA.Windows.Controls.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtPWD2 = new BANANA.Windows.Controls.TextBox();
            this._txtFAXNO = new BANANA.Windows.Controls.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtMEMO = new BANANA.Windows.Controls.TextBox();
            this.labelmemo = new System.Windows.Forms.Label();
            this._clbCompany = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new DemoClient.Controls.TableLayoutPanel();
            this._txtUSRNM_S = new BANANA.Windows.Controls.TextBox();
            this.lblUSR_NM_S = new BANANA.Windows.Controls.Label();
            this.lblUSR_ID_S = new BANANA.Windows.Controls.Label();
            this.label18 = new BANANA.Windows.Controls.Label();
            this._txtUSRID_S = new BANANA.Windows.Controls.TextBox();
            this.label19 = new BANANA.Windows.Controls.Label();
            this.label16 = new BANANA.Windows.Controls.Label();
            this._cmbUSR_GUBUN_S = new BANANA.Windows.Controls.ComboBox();
            this._cmbDEPT_CD_S = new BANANA.Windows.Controls.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._rbLCK_ACCT_A = new BANANA.Windows.Controls.RadioButton();
            this._rbLCK_ACCT_Y = new BANANA.Windows.Controls.RadioButton();
            this._rbLCK_ACCT_N = new BANANA.Windows.Controls.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnSave = new BANANA.Windows.Controls.Button();
            this._btnDel = new BANANA.Windows.Controls.Button();
            this._btnExcel = new DemoClient.Controls.BananaButton();
            this._btnPrint = new BANANA.Windows.Controls.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 530);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 결과";
            // 
            // gridView1
            // 
            this.gridView1.AutoSelectRowWithRightButton = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USRID,
            this.USRNM,
            this.USR_GUBUN,
            this.DEPT_NM,
            this.TELNO,
            this.FAXNO,
            this.EMAIL,
            this.ZIP_NO,
            this.ADDR_BSC,
            this.LST_LGN_TIME,
            this.WRNG_PWD_CNT,
            this.LCK_ACCT,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
            this.gridView1.DelegateProperty = true;
            this.gridView1.Location = new System.Drawing.Point(3, 17);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.RowTemplate.Height = 23;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.Size = new System.Drawing.Size(476, 510);
            this.gridView1.TabIndex = 0;
            this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
            // 
            // USRID
            // 
            this.USRID.DataPropertyName = "USRID";
            this.USRID.HeaderText = "이용자ID";
            this.USRID.Name = "USRID";
            this.USRID.ReadOnly = true;
            this.USRID.Width = 77;
            // 
            // USRNM
            // 
            this.USRNM.DataPropertyName = "USRNM";
            this.USRNM.HeaderText = "이용자명";
            this.USRNM.Name = "USRNM";
            this.USRNM.ReadOnly = true;
            this.USRNM.Width = 78;
            // 
            // USR_GUBUN
            // 
            this.USR_GUBUN.DataPropertyName = "USR_GUBUN";
            this.USR_GUBUN.HeaderText = "이용자구분";
            this.USR_GUBUN.Name = "USR_GUBUN";
            this.USR_GUBUN.ReadOnly = true;
            this.USR_GUBUN.Width = 90;
            // 
            // DEPT_NM
            // 
            this.DEPT_NM.DataPropertyName = "DEPT_NM";
            this.DEPT_NM.HeaderText = "소속부서";
            this.DEPT_NM.Name = "DEPT_NM";
            this.DEPT_NM.ReadOnly = true;
            this.DEPT_NM.Width = 78;
            // 
            // TELNO
            // 
            this.TELNO.DataPropertyName = "TELNO";
            this.TELNO.HeaderText = "전화번호";
            this.TELNO.Name = "TELNO";
            this.TELNO.ReadOnly = true;
            this.TELNO.Width = 78;
            // 
            // FAXNO
            // 
            this.FAXNO.DataPropertyName = "FAXNO";
            this.FAXNO.HeaderText = "팩스번호";
            this.FAXNO.Name = "FAXNO";
            this.FAXNO.ReadOnly = true;
            this.FAXNO.Width = 78;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "이메일";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 66;
            // 
            // ZIP_NO
            // 
            this.ZIP_NO.DataPropertyName = "ZIP_NO";
            this.ZIP_NO.HeaderText = "우편번호";
            this.ZIP_NO.Name = "ZIP_NO";
            this.ZIP_NO.ReadOnly = true;
            this.ZIP_NO.Width = 78;
            // 
            // ADDR_BSC
            // 
            this.ADDR_BSC.DataPropertyName = "ADDR_BSC";
            this.ADDR_BSC.HeaderText = "기본주소";
            this.ADDR_BSC.Name = "ADDR_BSC";
            this.ADDR_BSC.ReadOnly = true;
            this.ADDR_BSC.Width = 78;
            // 
            // LST_LGN_TIME
            // 
            this.LST_LGN_TIME.DataPropertyName = "LST_LGN_TIME";
            this.LST_LGN_TIME.HeaderText = "최근 로그인 시각";
            this.LST_LGN_TIME.Name = "LST_LGN_TIME";
            this.LST_LGN_TIME.ReadOnly = true;
            this.LST_LGN_TIME.Width = 122;
            // 
            // WRNG_PWD_CNT
            // 
            this.WRNG_PWD_CNT.DataPropertyName = "WRNG_PWD_CNT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.WRNG_PWD_CNT.DefaultCellStyle = dataGridViewCellStyle2;
            this.WRNG_PWD_CNT.HeaderText = "비밀번호 오류횟수";
            this.WRNG_PWD_CNT.Name = "WRNG_PWD_CNT";
            this.WRNG_PWD_CNT.ReadOnly = true;
            this.WRNG_PWD_CNT.Width = 130;
            // 
            // LCK_ACCT
            // 
            this.LCK_ACCT.DataPropertyName = "LCK_ACCT";
            this.LCK_ACCT.HeaderText = "계정잠김여부";
            this.LCK_ACCT.Name = "LCK_ACCT";
            this.LCK_ACCT.ReadOnly = true;
            this.LCK_ACCT.Width = 102;
            // 
            // SYSREGDATE
            // 
            this.SYSREGDATE.DataPropertyName = "SYSREGDATE";
            this.SYSREGDATE.HeaderText = "시스템등록일";
            this.SYSREGDATE.Name = "SYSREGDATE";
            this.SYSREGDATE.ReadOnly = true;
            this.SYSREGDATE.Width = 102;
            // 
            // SYSREGNAME
            // 
            this.SYSREGNAME.DataPropertyName = "SYSREGNAME";
            this.SYSREGNAME.HeaderText = "시스템등록자";
            this.SYSREGNAME.Name = "SYSREGNAME";
            this.SYSREGNAME.ReadOnly = true;
            this.SYSREGNAME.Width = 102;
            // 
            // SYSMODDATE
            // 
            this.SYSMODDATE.DataPropertyName = "SYSMODDATE";
            this.SYSMODDATE.HeaderText = "시스템수정일";
            this.SYSMODDATE.Name = "SYSMODDATE";
            this.SYSMODDATE.ReadOnly = true;
            this.SYSMODDATE.Width = 102;
            // 
            // SYSMODNAME
            // 
            this.SYSMODNAME.DataPropertyName = "SYSMODNAME";
            this.SYSMODNAME.HeaderText = "시스템수정자";
            this.SYSMODNAME.Name = "SYSMODNAME";
            this.SYSMODNAME.ReadOnly = true;
            this.SYSMODNAME.Width = 102;
            // 
            // collapsibleSplitter1
            // 
            this.collapsibleSplitter1.AnimationDelay = 20;
            this.collapsibleSplitter1.AnimationStep = 20;
            this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
            this.collapsibleSplitter1.ControlToHide = this.groupBox2;
            this.collapsibleSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.collapsibleSplitter1.ExpandParentForm = false;
            this.collapsibleSplitter1.Location = new System.Drawing.Point(482, 76);
            this.collapsibleSplitter1.Name = "collapsibleSplitter1";
            this.collapsibleSplitter1.TabIndex = 4;
            this.collapsibleSplitter1.TabStop = false;
            this.collapsibleSplitter1.UseAnimations = false;
            this.collapsibleSplitter1.VisualStyle = DemoClient.Controls.VisualStyles.Mozilla;
            this.collapsibleSplitter1.DoubleClick += new System.EventHandler(this.collapsibleSplitter1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(490, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 530);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상세 정보";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this._cmbDEPT_CD, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this._cmbUSR_GUBUN, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this._lblLCK_ACCT, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this._lblWRNG_PWD_CNT, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this._lblLST_LGN_TIME, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._txtADDR_DTL, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._txtADDR_BSC, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this._txtEMAIL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._txtHPNO, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtPWD1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._txtUSRNM, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label101, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_ID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_PASS, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_ROLL, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this._txtUSRID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtTELNO, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtPWD2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this._txtFAXNO, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelmemo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this._clbCompany, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 362);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 1114;
            this.label13.Text = "소속회사";
            // 
            // _cmbDEPT_CD
            // 
            this._cmbDEPT_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._cmbDEPT_CD.DataSource = null;
            this._cmbDEPT_CD.DelegateProperty = true;
            this._cmbDEPT_CD.DroppedDown = false;
            this._cmbDEPT_CD.Enabled = false;
            this._cmbDEPT_CD.Location = new System.Drawing.Point(553, 30);
            this._cmbDEPT_CD.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbDEPT_CD.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbDEPT_CD.Name = "_cmbDEPT_CD";
            this._cmbDEPT_CD.SelectedIndex = -1;
            this._cmbDEPT_CD.SelectedItem = null;
            this._cmbDEPT_CD.SelectedValue = null;
            this._cmbDEPT_CD.Size = new System.Drawing.Size(130, 21);
            this._cmbDEPT_CD.TabIndex = 1114;
            this._cmbDEPT_CD.ValidationGroup = null;
            // 
            // _cmbUSR_GUBUN
            // 
            this._cmbUSR_GUBUN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._cmbUSR_GUBUN.DataSource = null;
            this._cmbUSR_GUBUN.DelegateProperty = true;
            this._cmbUSR_GUBUN.DroppedDown = false;
            this._cmbUSR_GUBUN.Enabled = false;
            this._cmbUSR_GUBUN.Location = new System.Drawing.Point(553, 3);
            this._cmbUSR_GUBUN.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbUSR_GUBUN.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbUSR_GUBUN.Name = "_cmbUSR_GUBUN";
            this._cmbUSR_GUBUN.SelectedIndex = -1;
            this._cmbUSR_GUBUN.SelectedItem = null;
            this._cmbUSR_GUBUN.SelectedValue = null;
            this._cmbUSR_GUBUN.Size = new System.Drawing.Size(130, 21);
            this._cmbUSR_GUBUN.TabIndex = 1114;
            this._cmbUSR_GUBUN.ValidationGroup = null;
            // 
            // _lblLCK_ACCT
            // 
            this._lblLCK_ACCT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lblLCK_ACCT.AutoSize = true;
            this._lblLCK_ACCT.Location = new System.Drawing.Point(553, 142);
            this._lblLCK_ACCT.Name = "_lblLCK_ACCT";
            this._lblLCK_ACCT.Size = new System.Drawing.Size(53, 12);
            this._lblLCK_ACCT.TabIndex = 1114;
            this._lblLCK_ACCT.Text = "계정잠김";
            // 
            // _lblWRNG_PWD_CNT
            // 
            this._lblWRNG_PWD_CNT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lblWRNG_PWD_CNT.AutoSize = true;
            this._lblWRNG_PWD_CNT.Location = new System.Drawing.Point(323, 142);
            this._lblWRNG_PWD_CNT.Name = "_lblWRNG_PWD_CNT";
            this._lblWRNG_PWD_CNT.Size = new System.Drawing.Size(69, 12);
            this._lblWRNG_PWD_CNT.TabIndex = 1114;
            this._lblWRNG_PWD_CNT.Text = "로그인 오류";
            // 
            // _lblLST_LGN_TIME
            // 
            this._lblLST_LGN_TIME.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lblLST_LGN_TIME.AutoSize = true;
            this._lblLST_LGN_TIME.Location = new System.Drawing.Point(93, 142);
            this._lblLST_LGN_TIME.Name = "_lblLST_LGN_TIME";
            this._lblLST_LGN_TIME.Size = new System.Drawing.Size(69, 12);
            this._lblLST_LGN_TIME.TabIndex = 1114;
            this._lblLST_LGN_TIME.Text = "최근 로그인";
            // 
            // _txtADDR_DTL
            // 
            this._txtADDR_DTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtADDR_DTL.DelegateProperty = true;
            this._txtADDR_DTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtADDR_DTL.Location = new System.Drawing.Point(553, 84);
            this._txtADDR_DTL.Name = "_txtADDR_DTL";
            this._txtADDR_DTL.ReadOnly = true;
            this._txtADDR_DTL.Size = new System.Drawing.Size(130, 20);
            this._txtADDR_DTL.TabIndex = 1052;
            this._txtADDR_DTL.ValidationGroup = null;
            this._txtADDR_DTL.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtADDR_DTL.WaterMarkText = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnFindZipCode01);
            this.panel2.Controls.Add(this._txtZIP_NO);
            this.panel2.Location = new System.Drawing.Point(90, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 27);
            this.panel2.TabIndex = 1031;
            this.panel2.TabStop = true;
            // 
            // _btnFindZipCode01
            // 
            this._btnFindZipCode01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnFindZipCode01.DelegateProperty = true;
            this._btnFindZipCode01.Image = global::DemoClient.Properties.Resources._1377801181_62668;
            this._btnFindZipCode01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFindZipCode01.Location = new System.Drawing.Point(76, 4);
            this._btnFindZipCode01.Margin = new System.Windows.Forms.Padding(0);
            this._btnFindZipCode01.Name = "_btnFindZipCode01";
            this._btnFindZipCode01.Reserved = "Search";
            this._btnFindZipCode01.Size = new System.Drawing.Size(57, 20);
            this._btnFindZipCode01.TabIndex = 1031;
            this._btnFindZipCode01.Text = "Search";
            this._btnFindZipCode01.UseVisualStyleBackColor = true;
            this._btnFindZipCode01.ValidationGroup = null;
            // 
            // _txtZIP_NO
            // 
            this._txtZIP_NO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtZIP_NO.DelegateProperty = true;
            this._txtZIP_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtZIP_NO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtZIP_NO.Location = new System.Drawing.Point(3, 4);
            this._txtZIP_NO.MaxLength = 7;
            this._txtZIP_NO.Name = "_txtZIP_NO";
            this._txtZIP_NO.ReadOnly = true;
            this._txtZIP_NO.Size = new System.Drawing.Size(70, 20);
            this._txtZIP_NO.TabIndex = 1030;
            this._txtZIP_NO.ValidationGroup = null;
            this._txtZIP_NO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtZIP_NO.WaterMarkText = "";
            // 
            // _txtADDR_BSC
            // 
            this._txtADDR_BSC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtADDR_BSC.DelegateProperty = true;
            this._txtADDR_BSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtADDR_BSC.Location = new System.Drawing.Point(323, 84);
            this._txtADDR_BSC.Name = "_txtADDR_BSC";
            this._txtADDR_BSC.ReadOnly = true;
            this._txtADDR_BSC.Size = new System.Drawing.Size(130, 20);
            this._txtADDR_BSC.TabIndex = 1051;
            this._txtADDR_BSC.ValidationGroup = null;
            this._txtADDR_BSC.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtADDR_BSC.WaterMarkText = "";
            // 
            // _txtEMAIL
            // 
            this._txtEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this._txtEMAIL, 5);
            this._txtEMAIL.DelegateProperty = true;
            this._txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtEMAIL.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtEMAIL.Location = new System.Drawing.Point(93, 111);
            this._txtEMAIL.Name = "_txtEMAIL";
            this._txtEMAIL.ReadOnly = true;
            this._txtEMAIL.Size = new System.Drawing.Size(590, 20);
            this._txtEMAIL.TabIndex = 1061;
            this._txtEMAIL.ValidationGroup = null;
            this._txtEMAIL.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtEMAIL.WaterMarkText = "";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "이메일";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "상세주소";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "우편번호";
            // 
            // _txtHPNO
            // 
            this._txtHPNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtHPNO.DelegateProperty = true;
            this._txtHPNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtHPNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtHPNO.Location = new System.Drawing.Point(553, 57);
            this._txtHPNO.Name = "_txtHPNO";
            this._txtHPNO.ReadOnly = true;
            this._txtHPNO.Size = new System.Drawing.Size(130, 20);
            this._txtHPNO.TabIndex = 1071;
            this._txtHPNO.ValidationGroup = null;
            this._txtHPNO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtHPNO.WaterMarkText = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "휴대폰번호";
            // 
            // _txtPWD1
            // 
            this._txtPWD1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtPWD1.Compulsory = true;
            this._txtPWD1.DelegateProperty = true;
            this._txtPWD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtPWD1.Location = new System.Drawing.Point(93, 30);
            this._txtPWD1.Name = "_txtPWD1";
            this._txtPWD1.PasswordChar = '⊙';
            this._txtPWD1.ReadOnly = true;
            this._txtPWD1.Size = new System.Drawing.Size(130, 20);
            this._txtPWD1.TabIndex = 1081;
            this._txtPWD1.ValidationGroup = null;
            this._txtPWD1.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtPWD1.WaterMarkText = "";
            // 
            // _txtUSRNM
            // 
            this._txtUSRNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtUSRNM.Compulsory = true;
            this._txtUSRNM.DelegateProperty = true;
            this._txtUSRNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtUSRNM.Location = new System.Drawing.Point(323, 3);
            this._txtUSRNM.Name = "_txtUSRNM";
            this._txtUSRNM.ReadOnly = true;
            this._txtUSRNM.Size = new System.Drawing.Size(130, 20);
            this._txtUSRNM.TabIndex = 1010;
            this._txtUSRNM.ValidationGroup = "a";
            this._txtUSRNM.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtUSRNM.WaterMarkText = "";
            // 
            // label101
            // 
            this.label101.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(35, 7);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(52, 12);
            this.label101.TabIndex = 0;
            this.label101.Text = "이용자ID";
            // 
            // lblUSR_ID
            // 
            this.lblUSR_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ID.AutoSize = true;
            this.lblUSR_ID.Location = new System.Drawing.Point(34, 34);
            this.lblUSR_ID.Name = "lblUSR_ID";
            this.lblUSR_ID.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_ID.TabIndex = 2;
            this.lblUSR_ID.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "이용자명";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "비밀번호 확인";
            // 
            // lblUSR_PASS
            // 
            this.lblUSR_PASS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_PASS.AutoSize = true;
            this.lblUSR_PASS.Location = new System.Drawing.Point(482, 7);
            this.lblUSR_PASS.Name = "lblUSR_PASS";
            this.lblUSR_PASS.Size = new System.Drawing.Size(65, 12);
            this.lblUSR_PASS.TabIndex = 8;
            this.lblUSR_PASS.Text = "이용자구분";
            // 
            // lblUSR_ROLL
            // 
            this.lblUSR_ROLL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ROLL.AutoSize = true;
            this.lblUSR_ROLL.Location = new System.Drawing.Point(494, 34);
            this.lblUSR_ROLL.Name = "lblUSR_ROLL";
            this.lblUSR_ROLL.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_ROLL.TabIndex = 7;
            this.lblUSR_ROLL.Text = "소속부서";
            // 
            // _txtUSRID
            // 
            this._txtUSRID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtUSRID.DelegateProperty = true;
            this._txtUSRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtUSRID.Location = new System.Drawing.Point(93, 3);
            this._txtUSRID.Name = "_txtUSRID";
            this._txtUSRID.ReadOnly = true;
            this._txtUSRID.Size = new System.Drawing.Size(130, 20);
            this._txtUSRID.TabIndex = 1000;
            this._txtUSRID.ValidationGroup = "a";
            this._txtUSRID.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtUSRID.WaterMarkText = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "전화번호";
            // 
            // _txtTELNO
            // 
            this._txtTELNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtTELNO.DelegateProperty = true;
            this._txtTELNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtTELNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtTELNO.Location = new System.Drawing.Point(93, 57);
            this._txtTELNO.Name = "_txtTELNO";
            this._txtTELNO.ReadOnly = true;
            this._txtTELNO.Size = new System.Drawing.Size(130, 20);
            this._txtTELNO.TabIndex = 1060;
            this._txtTELNO.ValidationGroup = null;
            this._txtTELNO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtTELNO.WaterMarkText = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "팩스번호";
            // 
            // _txtPWD2
            // 
            this._txtPWD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtPWD2.Compulsory = true;
            this._txtPWD2.DelegateProperty = true;
            this._txtPWD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtPWD2.Location = new System.Drawing.Point(323, 30);
            this._txtPWD2.Name = "_txtPWD2";
            this._txtPWD2.PasswordChar = '⊙';
            this._txtPWD2.ReadOnly = true;
            this._txtPWD2.Size = new System.Drawing.Size(130, 20);
            this._txtPWD2.TabIndex = 1040;
            this._txtPWD2.ValidationGroup = null;
            this._txtPWD2.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtPWD2.WaterMarkText = "";
            // 
            // _txtFAXNO
            // 
            this._txtFAXNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtFAXNO.DelegateProperty = true;
            this._txtFAXNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtFAXNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtFAXNO.Location = new System.Drawing.Point(323, 57);
            this._txtFAXNO.Name = "_txtFAXNO";
            this._txtFAXNO.ReadOnly = true;
            this._txtFAXNO.Size = new System.Drawing.Size(130, 20);
            this._txtFAXNO.TabIndex = 1070;
            this._txtFAXNO.ValidationGroup = null;
            this._txtFAXNO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtFAXNO.WaterMarkText = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "기본주소";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "최근 로그인";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "로그인 오류";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "계정잠김";
            // 
            // _txtMEMO
            // 
            this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this._txtMEMO, 5);
            this._txtMEMO.DelegateProperty = true;
            this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtMEMO.Location = new System.Drawing.Point(93, 265);
            this._txtMEMO.Multiline = true;
            this._txtMEMO.Name = "_txtMEMO";
            this._txtMEMO.ReadOnly = true;
            this._txtMEMO.Size = new System.Drawing.Size(590, 94);
            this._txtMEMO.TabIndex = 1080;
            this._txtMEMO.ValidationGroup = null;
            this._txtMEMO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtMEMO.WaterMarkText = "";
            // 
            // labelmemo
            // 
            this.labelmemo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelmemo.AutoSize = true;
            this.labelmemo.Location = new System.Drawing.Point(58, 306);
            this.labelmemo.Name = "labelmemo";
            this.labelmemo.Size = new System.Drawing.Size(29, 12);
            this.labelmemo.TabIndex = 38;
            this.labelmemo.Text = "메모";
            // 
            // _clbCompany
            // 
            this._clbCompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._clbCompany.CheckOnClick = true;
            this.tableLayoutPanel1.SetColumnSpan(this._clbCompany, 5);
            this._clbCompany.Enabled = false;
            this._clbCompany.FormattingEnabled = true;
            this._clbCompany.Location = new System.Drawing.Point(93, 194);
            this._clbCompany.Name = "_clbCompany";
            this._clbCompany.Size = new System.Drawing.Size(590, 36);
            this._clbCompany.TabIndex = 1115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this._txtUSRNM_S, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUSR_NM_S, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUSR_ID_S, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._txtUSRID_S, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label19, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this._cmbUSR_GUBUN_S, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this._cmbDEPT_CD_S, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1182, 56);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _txtUSRNM_S
            // 
            this._txtUSRNM_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtUSRNM_S.AutoTab = false;
            this._txtUSRNM_S.DelegateProperty = true;
            this._txtUSRNM_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtUSRNM_S.Location = new System.Drawing.Point(95, 4);
            this._txtUSRNM_S.Name = "_txtUSRNM_S";
            this._txtUSRNM_S.Size = new System.Drawing.Size(130, 20);
            this._txtUSRNM_S.TabIndex = 100;
            this._txtUSRNM_S.ValidationGroup = null;
            this._txtUSRNM_S.WaterMarkColor = System.Drawing.Color.Empty;
            this._txtUSRNM_S.WaterMarkText = "";
            this._txtUSRNM_S.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtUSRNM_S_KeyDown);
            // 
            // lblUSR_NM_S
            // 
            this.lblUSR_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_NM_S.AutoSize = true;
            this.lblUSR_NM_S.Location = new System.Drawing.Point(35, 8);
            this.lblUSR_NM_S.Name = "lblUSR_NM_S";
            this.lblUSR_NM_S.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_NM_S.TabIndex = 9;
            this.lblUSR_NM_S.Text = "이용자명";
            // 
            // lblUSR_ID_S
            // 
            this.lblUSR_ID_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ID_S.AutoSize = true;
            this.lblUSR_ID_S.Location = new System.Drawing.Point(255, 8);
            this.lblUSR_ID_S.Name = "lblUSR_ID_S";
            this.lblUSR_ID_S.Size = new System.Drawing.Size(65, 12);
            this.lblUSR_ID_S.TabIndex = 7;
            this.lblUSR_ID_S.Text = "이용자구분";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 12);
            this.label18.TabIndex = 303;
            this.label18.Text = "이용자ID";
            // 
            // _txtUSRID_S
            // 
            this._txtUSRID_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtUSRID_S.AutoTab = false;
            this._txtUSRID_S.DelegateProperty = true;
            this._txtUSRID_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtUSRID_S.Location = new System.Drawing.Point(95, 32);
            this._txtUSRID_S.Name = "_txtUSRID_S";
            this._txtUSRID_S.Size = new System.Drawing.Size(130, 20);
            this._txtUSRID_S.TabIndex = 130;
            this._txtUSRID_S.ValidationGroup = null;
            this._txtUSRID_S.WaterMarkColor = System.Drawing.Color.Empty;
            this._txtUSRID_S.WaterMarkText = "";
            this._txtUSRID_S.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtUSRNM_S_KeyDown);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(243, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 305;
            this.label19.Text = "계정잠김여부";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(509, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 301;
            this.label16.Text = "소속부서";
            // 
            // _cmbUSR_GUBUN_S
            // 
            this._cmbUSR_GUBUN_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._cmbUSR_GUBUN_S.DataSource = null;
            this._cmbUSR_GUBUN_S.DelegateProperty = true;
            this._cmbUSR_GUBUN_S.DroppedDown = false;
            this._cmbUSR_GUBUN_S.Location = new System.Drawing.Point(327, 4);
            this._cmbUSR_GUBUN_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbUSR_GUBUN_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbUSR_GUBUN_S.Name = "_cmbUSR_GUBUN_S";
            this._cmbUSR_GUBUN_S.SelectedIndex = -1;
            this._cmbUSR_GUBUN_S.SelectedItem = null;
            this._cmbUSR_GUBUN_S.SelectedValue = null;
            this._cmbUSR_GUBUN_S.Size = new System.Drawing.Size(130, 21);
            this._cmbUSR_GUBUN_S.TabIndex = 110;
            this._cmbUSR_GUBUN_S.ValidationGroup = null;
            this._cmbUSR_GUBUN_S.DropDownClosed += new System.EventHandler(this._cmbUSR_GUBUN_S_DropDownClosed);
            // 
            // _cmbDEPT_CD_S
            // 
            this._cmbDEPT_CD_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._cmbDEPT_CD_S.DataSource = null;
            this._cmbDEPT_CD_S.DelegateProperty = true;
            this._cmbDEPT_CD_S.DroppedDown = false;
            this._cmbDEPT_CD_S.Location = new System.Drawing.Point(569, 4);
            this._cmbDEPT_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbDEPT_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbDEPT_CD_S.Name = "_cmbDEPT_CD_S";
            this._cmbDEPT_CD_S.SelectedIndex = -1;
            this._cmbDEPT_CD_S.SelectedItem = null;
            this._cmbDEPT_CD_S.SelectedValue = null;
            this._cmbDEPT_CD_S.Size = new System.Drawing.Size(130, 21);
            this._cmbDEPT_CD_S.TabIndex = 120;
            this._cmbDEPT_CD_S.ValidationGroup = null;
            this._cmbDEPT_CD_S.DropDownClosed += new System.EventHandler(this._cmbUSR_GUBUN_S_DropDownClosed);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this._rbLCK_ACCT_A);
            this.flowLayoutPanel1.Controls.Add(this._rbLCK_ACCT_Y);
            this.flowLayoutPanel1.Controls.Add(this._rbLCK_ACCT_N);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 29);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 27);
            this.flowLayoutPanel1.TabIndex = 140;
            // 
            // _rbLCK_ACCT_A
            // 
            this._rbLCK_ACCT_A.AutoSize = true;
            this._rbLCK_ACCT_A.Checked = true;
            this._rbLCK_ACCT_A.DelegateProperty = true;
            this._rbLCK_ACCT_A.Location = new System.Drawing.Point(3, 6);
            this._rbLCK_ACCT_A.Name = "_rbLCK_ACCT_A";
            this._rbLCK_ACCT_A.Size = new System.Drawing.Size(47, 16);
            this._rbLCK_ACCT_A.TabIndex = 10;
            this._rbLCK_ACCT_A.TabStop = true;
            this._rbLCK_ACCT_A.Text = "전체";
            this._rbLCK_ACCT_A.UseVisualStyleBackColor = true;
            this._rbLCK_ACCT_A.CheckedChanged += new System.EventHandler(this._rbLCK_ACCT_A_CheckedChanged);
            // 
            // _rbLCK_ACCT_Y
            // 
            this._rbLCK_ACCT_Y.AutoSize = true;
            this._rbLCK_ACCT_Y.DelegateProperty = true;
            this._rbLCK_ACCT_Y.Location = new System.Drawing.Point(56, 6);
            this._rbLCK_ACCT_Y.Name = "_rbLCK_ACCT_Y";
            this._rbLCK_ACCT_Y.Size = new System.Drawing.Size(31, 16);
            this._rbLCK_ACCT_Y.TabIndex = 20;
            this._rbLCK_ACCT_Y.Text = "Y";
            this._rbLCK_ACCT_Y.UseVisualStyleBackColor = true;
            this._rbLCK_ACCT_Y.CheckedChanged += new System.EventHandler(this._rbLCK_ACCT_A_CheckedChanged);
            // 
            // _rbLCK_ACCT_N
            // 
            this._rbLCK_ACCT_N.AutoSize = true;
            this._rbLCK_ACCT_N.DelegateProperty = true;
            this._rbLCK_ACCT_N.Location = new System.Drawing.Point(93, 6);
            this._rbLCK_ACCT_N.Name = "_rbLCK_ACCT_N";
            this._rbLCK_ACCT_N.Size = new System.Drawing.Size(32, 16);
            this._rbLCK_ACCT_N.TabIndex = 30;
            this._rbLCK_ACCT_N.Text = "N";
            this._rbLCK_ACCT_N.UseVisualStyleBackColor = true;
            this._rbLCK_ACCT_N.CheckedChanged += new System.EventHandler(this._rbLCK_ACCT_A_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this._btnSearch);
            this.flowLayoutPanel2.Controls.Add(this._btnSave);
            this.flowLayoutPanel2.Controls.Add(this._btnDel);
            this.flowLayoutPanel2.Controls.Add(this._btnExcel);
            this.flowLayoutPanel2.Controls.Add(this._btnPrint);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(707, 1);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(474, 27);
            this.flowLayoutPanel2.TabIndex = 324;
            // 
            // _btnSearch
            // 
            this._btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnSearch.DelegateProperty = true;
            this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
            this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.Location = new System.Drawing.Point(0, 5);
            this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Reserved = "Search";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 24;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.ValidationGroup = null;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
            this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSave.Location = new System.Drawing.Point(78, 5);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Reserved = "save";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 26;
            this._btnSave.Text = "save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.ValidationGroup = null;
            // 
            // _btnDel
            // 
            this._btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnDel.Image = global::DemoClient.Properties.Resources.red_62690;
            this._btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDel.Location = new System.Drawing.Point(159, 5);
            this._btnDel.Name = "_btnDel";
            this._btnDel.Reserved = "delete";
            this._btnDel.Size = new System.Drawing.Size(75, 23);
            this._btnDel.TabIndex = 27;
            this._btnDel.Text = "delete";
            this._btnDel.UseVisualStyleBackColor = true;
            this._btnDel.ValidationGroup = null;
            // 
            // _btnExcel
            // 
            this._btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnExcel.DelegateProperty = true;
            this._btnExcel.Image = global::DemoClient.Properties.Resources.EXCEL_0002;
            this._btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.Location = new System.Drawing.Point(237, 5);
            this._btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this._btnExcel.Name = "_btnExcel";
            this._btnExcel.Reserved = "      엑   셀";
            this._btnExcel.Size = new System.Drawing.Size(75, 23);
            this._btnExcel.TabIndex = 25;
            this._btnExcel.Text = "      엑   셀";
            this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.UseVisualStyleBackColor = true;
            this._btnExcel.ValidationGroup = null;
            // 
            // _btnPrint
            // 
            this._btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnPrint.Image = null;
            this._btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPrint.Location = new System.Drawing.Point(315, 5);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Reserved = "print";
            this._btnPrint.Size = new System.Drawing.Size(75, 23);
            this._btnPrint.TabIndex = 28;
            this._btnPrint.Text = "print";
            this._btnPrint.UseVisualStyleBackColor = true;
            this._btnPrint.ValidationGroup = null;
            // 
            // BAS0200
            // 
            this.ClientSize = new System.Drawing.Size(1188, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.collapsibleSplitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAS0200";
            this.Text = "이용자정보관리:BAS0200";
            this.Load += new System.EventHandler(this.BAS0200_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private DemoClient.Controls.CollapsibleSplitter collapsibleSplitter1;
		private System.Windows.Forms.GroupBox groupBox3;
		private DemoClient.Controls.GridView gridView1;
		private Controls.TableLayoutPanel tableLayoutPanel3;
		private BANANA.Windows.Controls.TextBox _txtUSRNM_S;
		private BANANA.Windows.Controls.Label lblUSR_NM_S;
		private BANANA.Windows.Controls.Label lblUSR_ID_S;
		private BANANA.Windows.Controls.Label label18;
		private BANANA.Windows.Controls.TextBox _txtUSRID_S;
		private BANANA.Windows.Controls.Label label19;
		private BANANA.Windows.Controls.ComboBox _cmbUSR_GUBUN_S;
		private BANANA.Windows.Controls.Label label16;
		private BANANA.Windows.Controls.ComboBox _cmbDEPT_CD_S;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private BANANA.Windows.Controls.RadioButton _rbLCK_ACCT_A;
		private BANANA.Windows.Controls.RadioButton _rbLCK_ACCT_Y;
		private BANANA.Windows.Controls.RadioButton _rbLCK_ACCT_N;
		private System.Windows.Forms.DataGridViewTextBoxColumn USRID;
		private System.Windows.Forms.DataGridViewTextBoxColumn USRNM;
		private System.Windows.Forms.DataGridViewTextBoxColumn USR_GUBUN;
		private System.Windows.Forms.DataGridViewTextBoxColumn DEPT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FAXNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZIP_NO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_BSC;
		private System.Windows.Forms.DataGridViewTextBoxColumn LST_LGN_TIME;
		private System.Windows.Forms.DataGridViewTextBoxColumn WRNG_PWD_CNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn LCK_ACCT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelmemo;
		private BANANA.Windows.Controls.TextBox _txtUSRNM;
		private BANANA.Windows.Controls.Label label101;
		private BANANA.Windows.Controls.Label lblUSR_ID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private BANANA.Windows.Controls.Label lblUSR_PASS;
		private BANANA.Windows.Controls.Label lblUSR_ROLL;
		private BANANA.Windows.Controls.TextBox _txtUSRID;
		private BANANA.Windows.Controls.TextBox _txtMEMO;
		private System.Windows.Forms.Label label3;
		private BANANA.Windows.Controls.TextBox _txtTELNO;
		private System.Windows.Forms.Label label4;
		private BANANA.Windows.Controls.TextBox _txtPWD2;
		private BANANA.Windows.Controls.TextBox _txtFAXNO;
		private BANANA.Windows.Controls.TextBox _txtPWD1;
		private BANANA.Windows.Controls.TextBox _txtHPNO;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private BANANA.Windows.Controls.TextBox _txtEMAIL;
		private System.Windows.Forms.Panel panel2;
		private BANANA.Windows.Controls.TextBox _txtZIP_NO;
		private BANANA.Windows.Controls.TextBox _txtADDR_DTL;
		private BANANA.Windows.Controls.TextBox _txtADDR_BSC;
		private System.Windows.Forms.Label _lblLCK_ACCT;
		private System.Windows.Forms.Label _lblWRNG_PWD_CNT;
		private System.Windows.Forms.Label _lblLST_LGN_TIME;
		private BANANA.Windows.Controls.ComboBox _cmbUSR_GUBUN;
		private BANANA.Windows.Controls.ComboBox _cmbDEPT_CD;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckedListBox _clbCompany;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Controls.BananaButton _btnSearch;
        private BANANA.Windows.Controls.Button _btnSave;
        private BANANA.Windows.Controls.Button _btnDel;
        private Controls.BananaButton _btnExcel;
        private BANANA.Windows.Controls.Button _btnPrint;
        private Controls.BananaButton _btnFindZipCode01;
    }
}
