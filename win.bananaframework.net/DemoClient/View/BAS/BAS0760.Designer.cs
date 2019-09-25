namespace DemoClient.View.BAS
{
	partial class BAS0760
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0760));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new DemoClient.Controls.TableLayoutPanel();
            this._txtCI_ACCT_NM_S = new BANANA.Windows.Controls.TextBox();
            this._txtSYSREGNAME_S = new BANANA.Windows.Controls.TextBox();
            this.label40 = new BANANA.Windows.Controls.Label();
            this.label2 = new BANANA.Windows.Controls.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._dtpSYSMODDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
            this.label1 = new BANANA.Windows.Controls.Label();
            this._dtpSYSMODDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnExcel = new DemoClient.Controls.BananaButton();
            this.label37 = new BANANA.Windows.Controls.Label();
            this._txtAGT_CD_S = new BANANA.Windows.Controls.TextBox();
            this._txtAGT_NM_S = new BANANA.Windows.Controls.TextBox();
            this.label35 = new BANANA.Windows.Controls.Label();
            this.label36 = new BANANA.Windows.Controls.Label();
            this.label38 = new BANANA.Windows.Controls.Label();
            this._cmbCI_BNK_CD_S = new BANANA.Windows.Controls.ComboBox();
            this.label39 = new BANANA.Windows.Controls.Label();
            this._txtCI_ACCT_NO_S = new BANANA.Windows.Controls.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DemoClient.Controls.GridView();
            this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HST_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CI_CNTR_STRT_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CI_CNTR_END_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CI_BNK_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CI_ACCT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CI_ACCT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI_CNTR_STRT_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI_CNTR_END_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI_BNK_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI_ACCT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI_ACCT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 9;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this._txtCI_ACCT_NM_S, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtSYSREGNAME_S, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.label40, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel2, 8, 0);
            this.tableLayoutPanel6.Controls.Add(this.label37, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtAGT_CD_S, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this._txtAGT_NM_S, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label38, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this._cmbCI_BNK_CD_S, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.label39, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this._txtCI_ACCT_NO_S, 7, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1278, 56);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // _txtCI_ACCT_NM_S
            // 
            this._txtCI_ACCT_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtCI_ACCT_NM_S.DelegateProperty = true;
            this._txtCI_ACCT_NM_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtCI_ACCT_NM_S.Location = new System.Drawing.Point(95, 32);
            this._txtCI_ACCT_NM_S.Name = "_txtCI_ACCT_NM_S";
            this._txtCI_ACCT_NM_S.Size = new System.Drawing.Size(124, 20);
            this._txtCI_ACCT_NM_S.TabIndex = 160;
            this._txtCI_ACCT_NM_S.ValidationGroup = null;
            this._txtCI_ACCT_NM_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtCI_ACCT_NM_S.WaterMarkText = "";
            // 
            // _txtSYSREGNAME_S
            // 
            this._txtSYSREGNAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtSYSREGNAME_S.DelegateProperty = true;
            this._txtSYSREGNAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtSYSREGNAME_S.Location = new System.Drawing.Point(317, 32);
            this._txtSYSREGNAME_S.Name = "_txtSYSREGNAME_S";
            this._txtSYSREGNAME_S.Size = new System.Drawing.Size(124, 20);
            this._txtSYSREGNAME_S.TabIndex = 170;
            this._txtSYSREGNAME_S.ValidationGroup = null;
            this._txtSYSREGNAME_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtSYSREGNAME_S.WaterMarkText = "";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(47, 36);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 12);
            this.label40.TabIndex = 1119;
            this.label40.Text = "예금주";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1120;
            this.label2.Text = "처리자";
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this._dtpSYSMODDATE_S_S);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this._dtpSYSMODDATE_E_S);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(536, 29);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 27);
            this.flowLayoutPanel1.TabIndex = 1121;
            // 
            // _dtpSYSMODDATE_S_S
            // 
            this._dtpSYSMODDATE_S_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._dtpSYSMODDATE_S_S.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this._dtpSYSMODDATE_S_S.DelegateProperty = true;
            this._dtpSYSMODDATE_S_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpSYSMODDATE_S_S.Location = new System.Drawing.Point(3, 5);
            this._dtpSYSMODDATE_S_S.MaximumSize = new System.Drawing.Size(250, 21);
            this._dtpSYSMODDATE_S_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._dtpSYSMODDATE_S_S.Name = "_dtpSYSMODDATE_S_S";
            this._dtpSYSMODDATE_S_S.Size = new System.Drawing.Size(150, 21);
            this._dtpSYSMODDATE_S_S.TabIndex = 22;
            this._dtpSYSMODDATE_S_S.ValidationGroup = null;
            this._dtpSYSMODDATE_S_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 635);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "~";
            // 
            // _dtpSYSMODDATE_E_S
            // 
            this._dtpSYSMODDATE_E_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._dtpSYSMODDATE_E_S.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this._dtpSYSMODDATE_E_S.DelegateProperty = true;
            this._dtpSYSMODDATE_E_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpSYSMODDATE_E_S.Location = new System.Drawing.Point(179, 5);
            this._dtpSYSMODDATE_E_S.MaximumSize = new System.Drawing.Size(250, 21);
            this._dtpSYSMODDATE_E_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._dtpSYSMODDATE_E_S.Name = "_dtpSYSMODDATE_E_S";
            this._dtpSYSMODDATE_E_S.Size = new System.Drawing.Size(150, 21);
            this._dtpSYSMODDATE_E_S.TabIndex = 23;
            this._dtpSYSMODDATE_E_S.ValidationGroup = null;
            this._dtpSYSMODDATE_E_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 638);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this._btnSearch);
            this.flowLayoutPanel2.Controls.Add(this._btnExcel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(889, 1);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(449, 27);
            this.flowLayoutPanel2.TabIndex = 325;
            // 
            // _btnSearch
            // 
            this._btnSearch.DelegateProperty = true;
            this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
            this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.Location = new System.Drawing.Point(0, 2);
            this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 160;
            this._btnSearch.Text = "      검   색";
            this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.ValidationGroup = null;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _btnExcel
            // 
            this._btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnExcel.DelegateProperty = true;
            this._btnExcel.Image = global::DemoClient.Properties.Resources.EXCEL_0002;
            this._btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.Location = new System.Drawing.Point(75, 2);
            this._btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this._btnExcel.Name = "_btnExcel";
            this._btnExcel.Size = new System.Drawing.Size(75, 23);
            this._btnExcel.TabIndex = 162;
            this._btnExcel.Text = "      엑   셀";
            this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.UseVisualStyleBackColor = true;
            this._btnExcel.ValidationGroup = null;
            this._btnExcel.Click += new System.EventHandler(this._btnExcel_Click);
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(479, 36);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 12);
            this.label37.TabIndex = 1116;
            this.label37.Text = "처리기간";
            // 
            // _txtAGT_CD_S
            // 
            this._txtAGT_CD_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtAGT_CD_S.DelegateProperty = true;
            this._txtAGT_CD_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtAGT_CD_S.Location = new System.Drawing.Point(317, 4);
            this._txtAGT_CD_S.Name = "_txtAGT_CD_S";
            this._txtAGT_CD_S.Size = new System.Drawing.Size(124, 20);
            this._txtAGT_CD_S.TabIndex = 110;
            this._txtAGT_CD_S.ValidationGroup = null;
            this._txtAGT_CD_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtAGT_CD_S.WaterMarkText = "";
            // 
            // _txtAGT_NM_S
            // 
            this._txtAGT_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtAGT_NM_S.DelegateProperty = true;
            this._txtAGT_NM_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtAGT_NM_S.Location = new System.Drawing.Point(95, 4);
            this._txtAGT_NM_S.Name = "_txtAGT_NM_S";
            this._txtAGT_NM_S.Size = new System.Drawing.Size(124, 20);
            this._txtAGT_NM_S.TabIndex = 100;
            this._txtAGT_NM_S.ValidationGroup = null;
            this._txtAGT_NM_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtAGT_NM_S.WaterMarkText = "";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(35, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 12);
            this.label35.TabIndex = 1114;
            this.label35.Text = "대리점명";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(245, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 12);
            this.label36.TabIndex = 1115;
            this.label36.Text = "대리점코드";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(479, 8);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 12);
            this.label38.TabIndex = 1117;
            this.label38.Text = "입금은행";
            // 
            // _cmbCI_BNK_CD_S
            // 
            this._cmbCI_BNK_CD_S.DataSource = null;
            this._cmbCI_BNK_CD_S.DelegateProperty = true;
            this._cmbCI_BNK_CD_S.Location = new System.Drawing.Point(539, 4);
            this._cmbCI_BNK_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbCI_BNK_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbCI_BNK_CD_S.Name = "_cmbCI_BNK_CD_S";
            this._cmbCI_BNK_CD_S.SelectedIndex = -1;
            this._cmbCI_BNK_CD_S.SelectedItem = null;
            this._cmbCI_BNK_CD_S.SelectedValue = null;
            this._cmbCI_BNK_CD_S.Size = new System.Drawing.Size(124, 21);
            this._cmbCI_BNK_CD_S.TabIndex = 140;
            this._cmbCI_BNK_CD_S.ValidationGroup = null;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(701, 8);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 12);
            this.label39.TabIndex = 1118;
            this.label39.Text = "계좌번호";
            // 
            // _txtCI_ACCT_NO_S
            // 
            this._txtCI_ACCT_NO_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtCI_ACCT_NO_S.DelegateProperty = true;
            this._txtCI_ACCT_NO_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtCI_ACCT_NO_S.Location = new System.Drawing.Point(761, 4);
            this._txtCI_ACCT_NO_S.Name = "_txtCI_ACCT_NO_S";
            this._txtCI_ACCT_NO_S.Size = new System.Drawing.Size(124, 20);
            this._txtCI_ACCT_NO_S.TabIndex = 150;
            this._txtCI_ACCT_NO_S.ValidationGroup = null;
            this._txtCI_ACCT_NO_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtCI_ACCT_NO_S.WaterMarkText = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 657);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 결과";
            // 
            // gridView1
            // 
            this.gridView1.AllowUserToAddRows = false;
            this.gridView1.AutoSelectRowWithRightButton = false;
            this.gridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView1.ColumnHeadersHeight = 50;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDX,
            this.HST_TYPE,
            this.AGT_CD,
            this.AGT_NM,
            this._CI_CNTR_STRT_DT,
            this._CI_CNTR_END_DT,
            this._CI_BNK_NM,
            this._CI_ACCT_NO,
            this._CI_ACCT_NM,
            this.CI_CNTR_STRT_DT,
            this.CI_CNTR_END_DT,
            this.CI_BNK_NM,
            this.CI_ACCT_NO,
            this.CI_ACCT_NM,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
            this.gridView1.DelegateProperty = true;
            this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView1.Location = new System.Drawing.Point(3, 17);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.Size = new System.Drawing.Size(1278, 637);
            this.gridView1.TabIndex = 0;
            this.gridView1.ShowHeaderCheckBox = false;
            // 
            // IDX
            // 
            this.IDX.DataPropertyName = "IDX";
            this.IDX.HeaderText = "일련번호";
            this.IDX.Name = "IDX";
            this.IDX.ReadOnly = true;
            this.IDX.Width = 76;
            // 
            // HST_TYPE
            // 
            this.HST_TYPE.DataPropertyName = "HST_TYPE";
            this.HST_TYPE.HeaderText = "이력구분";
            this.HST_TYPE.Name = "HST_TYPE";
            this.HST_TYPE.ReadOnly = true;
            this.HST_TYPE.Width = 76;
            // 
            // AGT_CD
            // 
            this.AGT_CD.DataPropertyName = "AGT_CD";
            this.AGT_CD.HeaderText = "대리점코드";
            this.AGT_CD.Name = "AGT_CD";
            this.AGT_CD.ReadOnly = true;
            this.AGT_CD.Width = 87;
            // 
            // AGT_NM
            // 
            this.AGT_NM.DataPropertyName = "AGT_NM";
            this.AGT_NM.HeaderText = "대리점명";
            this.AGT_NM.Name = "AGT_NM";
            this.AGT_NM.ReadOnly = true;
            this.AGT_NM.Width = 76;
            // 
            // _CI_CNTR_STRT_DT
            // 
            this._CI_CNTR_STRT_DT.DataPropertyName = "_CI_CNTR_STRT_DT";
            this._CI_CNTR_STRT_DT.HeaderText = "계약일자";
            this._CI_CNTR_STRT_DT.Name = "_CI_CNTR_STRT_DT";
            this._CI_CNTR_STRT_DT.ReadOnly = true;
            this._CI_CNTR_STRT_DT.Width = 76;
            // 
            // _CI_CNTR_END_DT
            // 
            this._CI_CNTR_END_DT.HeaderText = "해지일자";
            this._CI_CNTR_END_DT.Name = "_CI_CNTR_END_DT";
            this._CI_CNTR_END_DT.ReadOnly = true;
            this._CI_CNTR_END_DT.Width = 76;
            // 
            // _CI_BNK_NM
            // 
            this._CI_BNK_NM.DataPropertyName = "_CI_BNK_NM";
            this._CI_BNK_NM.HeaderText = "입금은행명";
            this._CI_BNK_NM.Name = "_CI_BNK_NM";
            this._CI_BNK_NM.ReadOnly = true;
            this._CI_BNK_NM.Width = 87;
            // 
            // _CI_ACCT_NO
            // 
            this._CI_ACCT_NO.DataPropertyName = "_CI_ACCT_NO";
            this._CI_ACCT_NO.HeaderText = "계좌번호";
            this._CI_ACCT_NO.Name = "_CI_ACCT_NO";
            this._CI_ACCT_NO.ReadOnly = true;
            this._CI_ACCT_NO.Width = 76;
            // 
            // _CI_ACCT_NM
            // 
            this._CI_ACCT_NM.DataPropertyName = "_CI_ACCT_NM";
            this._CI_ACCT_NM.HeaderText = "예금주";
            this._CI_ACCT_NM.Name = "_CI_ACCT_NM";
            this._CI_ACCT_NM.ReadOnly = true;
            this._CI_ACCT_NM.Width = 65;
            // 
            // CI_CNTR_STRT_DT
            // 
            this.CI_CNTR_STRT_DT.DataPropertyName = "CI_CNTR_STRT_DT";
            this.CI_CNTR_STRT_DT.HeaderText = "계약일자";
            this.CI_CNTR_STRT_DT.Name = "CI_CNTR_STRT_DT";
            this.CI_CNTR_STRT_DT.ReadOnly = true;
            this.CI_CNTR_STRT_DT.Width = 76;
            // 
            // CI_CNTR_END_DT
            // 
            this.CI_CNTR_END_DT.DataPropertyName = "CI_CNTR_END_DT";
            this.CI_CNTR_END_DT.HeaderText = "해지일자";
            this.CI_CNTR_END_DT.Name = "CI_CNTR_END_DT";
            this.CI_CNTR_END_DT.ReadOnly = true;
            this.CI_CNTR_END_DT.Width = 76;
            // 
            // CI_BNK_NM
            // 
            this.CI_BNK_NM.DataPropertyName = "CI_BNK_NM";
            this.CI_BNK_NM.HeaderText = "입금은행명";
            this.CI_BNK_NM.Name = "CI_BNK_NM";
            this.CI_BNK_NM.ReadOnly = true;
            this.CI_BNK_NM.Width = 87;
            // 
            // CI_ACCT_NO
            // 
            this.CI_ACCT_NO.DataPropertyName = "CI_ACCT_NO";
            this.CI_ACCT_NO.HeaderText = "계좌번호";
            this.CI_ACCT_NO.Name = "CI_ACCT_NO";
            this.CI_ACCT_NO.ReadOnly = true;
            this.CI_ACCT_NO.Width = 76;
            // 
            // CI_ACCT_NM
            // 
            this.CI_ACCT_NM.DataPropertyName = "CI_ACCT_NM";
            this.CI_ACCT_NM.HeaderText = "예금주";
            this.CI_ACCT_NM.Name = "CI_ACCT_NM";
            this.CI_ACCT_NM.ReadOnly = true;
            this.CI_ACCT_NM.Width = 65;
            // 
            // SYSREGDATE
            // 
            this.SYSREGDATE.DataPropertyName = "SYSREGDATE";
            this.SYSREGDATE.HeaderText = "시스템등록일";
            this.SYSREGDATE.Name = "SYSREGDATE";
            this.SYSREGDATE.ReadOnly = true;
            this.SYSREGDATE.Width = 98;
            // 
            // SYSREGNAME
            // 
            this.SYSREGNAME.DataPropertyName = "SYSREGNAME";
            this.SYSREGNAME.HeaderText = "시스템등록자";
            this.SYSREGNAME.Name = "SYSREGNAME";
            this.SYSREGNAME.ReadOnly = true;
            this.SYSREGNAME.Width = 98;
            // 
            // SYSMODDATE
            // 
            this.SYSMODDATE.DataPropertyName = "SYSMODDATE";
            this.SYSMODDATE.HeaderText = "시스템수정일";
            this.SYSMODDATE.Name = "SYSMODDATE";
            this.SYSMODDATE.ReadOnly = true;
            this.SYSMODDATE.Width = 98;
            // 
            // SYSMODNAME
            // 
            this.SYSMODNAME.DataPropertyName = "SYSMODNAME";
            this.SYSMODNAME.HeaderText = "시스템수정자";
            this.SYSMODNAME.Name = "SYSMODNAME";
            this.SYSMODNAME.ReadOnly = true;
            this.SYSMODNAME.Width = 98;
            // 
            // BAS0760
            // 
            this.ClientSize = new System.Drawing.Size(1284, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAS0760";
            this.Text = "대리점.정산/계약정보이력조회:BAS0760";
            this.Load += new System.EventHandler(this.BAS0760_Load);
            this.Shown += new System.EventHandler(this.BAS0760_Shown);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Controls.TableLayoutPanel tableLayoutPanel6;
		private BANANA.Windows.Controls.ComboBox _cmbCI_BNK_CD_S;
		private BANANA.Windows.Controls.TextBox _txtCI_ACCT_NM_S;
		private BANANA.Windows.Controls.TextBox _txtAGT_CD_S;
		private BANANA.Windows.Controls.TextBox _txtAGT_NM_S;
		private BANANA.Windows.Controls.Label label40;
		private BANANA.Windows.Controls.Label label35;
		private BANANA.Windows.Controls.Label label39;
		private BANANA.Windows.Controls.Label label36;
		private BANANA.Windows.Controls.Label label38;
		private BANANA.Windows.Controls.Label label37;
		private System.Windows.Forms.GroupBox groupBox2;
		private DemoClient.Controls.GridView gridView1;
		private BANANA.Windows.Controls.TextBox _txtSYSREGNAME_S;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.TextBox _txtCI_ACCT_NO_S;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private DemoClient.Controls.BananaButton _btnSearch;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_S_S;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_E_S;
		private DemoClient.Controls.BananaButton _btnExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
		private System.Windows.Forms.DataGridViewTextBoxColumn HST_TYPE;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGT_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn _CI_CNTR_STRT_DT;
		private System.Windows.Forms.DataGridViewTextBoxColumn _CI_CNTR_END_DT;
		private System.Windows.Forms.DataGridViewTextBoxColumn _CI_BNK_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn _CI_ACCT_NO;
		private System.Windows.Forms.DataGridViewTextBoxColumn _CI_ACCT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_CNTR_STRT_DT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_CNTR_END_DT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_BNK_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_ACCT_NO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_ACCT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
	}
}
