namespace DemoClient.View.LRN
{
    partial class LRN0110
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LRN0110));
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.collapsibleSplitter1 = new DemoClient.Controls.CollapsibleSplitter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._txtSTR_NM_S1 = new BANANA.Windows.Controls.TextBox();
			this.label5 = new BANANA.Windows.Controls.Label();
			this._txtSTR_CD = new BANANA.Windows.Controls.TextBox();
			this.label4 = new BANANA.Windows.Controls.Label();
			this._dtpLNSTDT = new BANANA.Windows.Controls.DateTimePicker();
			this._dtpEXECDT = new BANANA.Windows.Controls.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this._cmbLNR_CD = new BANANA.Windows.Controls.ComboBox();
			this._txtBIGO = new BANANA.Windows.Controls.TextBox();
			this._txtINTRRTYEAR = new BANANA.Windows.Controls.TextBox();
			this._txtLNAMT = new BANANA.Windows.Controls.TextBox();
			this.label101 = new BANANA.Windows.Controls.Label();
			this.lblUSR_ID = new BANANA.Windows.Controls.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this._txtLNMNT = new BANANA.Windows.Controls.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRSNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BI_SAUP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this._txtPRSNT_NM = new BANANA.Windows.Controls.TextBox();
			this._txtSTR_NM = new BANANA.Windows.Controls.TextBox();
			this.label35 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label37 = new BANANA.Windows.Controls.Label();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.collapsibleSplitter1);
			this.groupBox3.Controls.Add(this.gridView1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 57);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(447, 613);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "입금거래목록";
			// 
			// collapsibleSplitter1
			// 
			this.collapsibleSplitter1.AnimationDelay = 20;
			this.collapsibleSplitter1.AnimationStep = 20;
			this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
			this.collapsibleSplitter1.ControlToHide = this.groupBox2;
			this.collapsibleSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.collapsibleSplitter1.ExpandParentForm = false;
			this.collapsibleSplitter1.Location = new System.Drawing.Point(436, 21);
			this.collapsibleSplitter1.Name = "collapsibleSplitter1";
			this.collapsibleSplitter1.TabIndex = 1115;
			this.collapsibleSplitter1.TabStop = false;
			this.collapsibleSplitter1.UseAnimations = false;
			this.collapsibleSplitter1.VisualStyle = DemoClient.Controls.VisualStyles.Mozilla;
			this.collapsibleSplitter1.DoubleClick += new System.EventHandler(this.collapsibleSplitter1_DoubleClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this._btnSave);
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox2.Location = new System.Drawing.Point(447, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(698, 613);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "상세 정보";
			// 
			// _btnSave
			// 
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Enabled = false;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(611, 260);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Reserved = "      저   장";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 1112;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
			this.tableLayoutPanel1.Controls.Add(this._txtSTR_NM_S1, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtSTR_CD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._dtpLNSTDT, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this._dtpEXECDT, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label13, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this._cmbLNR_CD, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtBIGO, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this._txtINTRRTYEAR, 5, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtLNAMT, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label101, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblUSR_ID, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtLNMNT, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 233);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// _txtSTR_NM_S1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this._txtSTR_NM_S1, 3);
			this._txtSTR_NM_S1.DelegateProperty = true;
			this._txtSTR_NM_S1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txtSTR_NM_S1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_NM_S1.Location = new System.Drawing.Point(344, 3);
			this._txtSTR_NM_S1.Name = "_txtSTR_NM_S1";
			this._txtSTR_NM_S1.ReadOnly = true;
			this._txtSTR_NM_S1.Size = new System.Drawing.Size(345, 23);
			this._txtSTR_NM_S1.TabIndex = 1126;
			this._txtSTR_NM_S1.ValidationGroup = "a";
			this._txtSTR_NM_S1.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSTR_NM_S1.WaterMarkText = "";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(271, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 1125;
			this.label5.Text = "가맹점명";
			// 
			// _txtSTR_CD
			// 
			this._txtSTR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtSTR_CD.DelegateProperty = true;
			this._txtSTR_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_CD.Location = new System.Drawing.Point(110, 3);
			this._txtSTR_CD.Name = "_txtSTR_CD";
			this._txtSTR_CD.ReadOnly = true;
			this._txtSTR_CD.Size = new System.Drawing.Size(113, 23);
			this._txtSTR_CD.TabIndex = 1124;
			this._txtSTR_CD.ValidationGroup = "a";
			this._txtSTR_CD.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSTR_CD.WaterMarkText = "";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 15);
			this.label4.TabIndex = 1123;
			this.label4.Text = "가맹점코드";
			// 
			// _dtpLNSTDT
			// 
			this._dtpLNSTDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpLNSTDT.Checked = false;
			this._dtpLNSTDT.CustomFormat = "yyyy-MM-dd";
			this._dtpLNSTDT.DelegateProperty = true;
			this._dtpLNSTDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpLNSTDT.Location = new System.Drawing.Point(344, 57);
			this._dtpLNSTDT.MaximumSize = new System.Drawing.Size(250, 20);
			this._dtpLNSTDT.MinimumSize = new System.Drawing.Size(100, 20);
			this._dtpLNSTDT.Name = "_dtpLNSTDT";
			this._dtpLNSTDT.Size = new System.Drawing.Size(113, 20);
			this._dtpLNSTDT.TabIndex = 1116;
			this._dtpLNSTDT.ValidationGroup = "a";
			this._dtpLNSTDT.Value = new System.DateTime(2014, 7, 25, 10, 20, 16, 341);
			// 
			// _dtpEXECDT
			// 
			this._dtpEXECDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpEXECDT.Checked = false;
			this._dtpEXECDT.CustomFormat = "yyyy-MM-dd";
			this._dtpEXECDT.DelegateProperty = true;
			this._dtpEXECDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpEXECDT.Location = new System.Drawing.Point(110, 57);
			this._dtpEXECDT.MaximumSize = new System.Drawing.Size(250, 20);
			this._dtpEXECDT.MinimumSize = new System.Drawing.Size(100, 20);
			this._dtpEXECDT.Name = "_dtpEXECDT";
			this._dtpEXECDT.Size = new System.Drawing.Size(117, 20);
			this._dtpEXECDT.TabIndex = 1115;
			this._dtpEXECDT.ValidationGroup = "a";
			this._dtpEXECDT.Value = new System.DateTime(2014, 7, 25, 10, 20, 16, 341);
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(468, 60);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 15);
			this.label13.TabIndex = 1114;
			this.label13.Text = "대출연이율(%)";
			// 
			// _cmbLNR_CD
			// 
			this._cmbLNR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbLNR_CD.Compulsory = true;
			this._cmbLNR_CD.DataSource = null;
			this._cmbLNR_CD.DelegateProperty = true;
			this._cmbLNR_CD.DroppedDown = false;
			this._cmbLNR_CD.Location = new System.Drawing.Point(110, 30);
			this._cmbLNR_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbLNR_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbLNR_CD.Name = "_cmbLNR_CD";
			this._cmbLNR_CD.SelectedIndex = -1;
			this._cmbLNR_CD.SelectedItem = null;
			this._cmbLNR_CD.SelectedValue = null;
			this._cmbLNR_CD.Size = new System.Drawing.Size(113, 23);
			this._cmbLNR_CD.TabIndex = 1114;
			this._cmbLNR_CD.ValidationGroup = "a";
			// 
			// _txtBIGO
			// 
			this.tableLayoutPanel1.SetColumnSpan(this._txtBIGO, 5);
			this._txtBIGO.DelegateProperty = true;
			this._txtBIGO.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txtBIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtBIGO.Location = new System.Drawing.Point(110, 84);
			this._txtBIGO.Multiline = true;
			this._txtBIGO.Name = "_txtBIGO";
			this._txtBIGO.Size = new System.Drawing.Size(579, 131);
			this._txtBIGO.TabIndex = 1051;
			this._txtBIGO.ValidationGroup = null;
			this._txtBIGO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtBIGO.WaterMarkText = "";
			// 
			// _txtINTRRTYEAR
			// 
			this._txtINTRRTYEAR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtINTRRTYEAR.Compulsory = true;
			this._txtINTRRTYEAR.DelegateProperty = true;
			this._txtINTRRTYEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtINTRRTYEAR.ImeMode = BANANA.Windows.Controls.ImeMode.Decimal;
			this._txtINTRRTYEAR.Location = new System.Drawing.Point(579, 57);
			this._txtINTRRTYEAR.Name = "_txtINTRRTYEAR";
			this._txtINTRRTYEAR.Size = new System.Drawing.Size(110, 23);
			this._txtINTRRTYEAR.TabIndex = 1071;
			this._txtINTRRTYEAR.Text = "27.5";
			this._txtINTRRTYEAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtINTRRTYEAR.ValidationGroup = null;
			this._txtINTRRTYEAR.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtINTRRTYEAR.WaterMarkText = "";
			// 
			// _txtLNAMT
			// 
			this._txtLNAMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtLNAMT.Compulsory = true;
			this._txtLNAMT.DelegateProperty = true;
			this._txtLNAMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtLNAMT.ImeMode = BANANA.Windows.Controls.ImeMode.Decimal;
			this._txtLNAMT.Location = new System.Drawing.Point(344, 30);
			this._txtLNAMT.Name = "_txtLNAMT";
			this._txtLNAMT.Size = new System.Drawing.Size(113, 23);
			this._txtLNAMT.TabIndex = 1010;
			this._txtLNAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtLNAMT.ValidationGroup = "a";
			this._txtLNAMT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtLNAMT.WaterMarkText = "";
			// 
			// label101
			// 
			this.label101.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label101.AutoSize = true;
			this.label101.Location = new System.Drawing.Point(52, 33);
			this.label101.Name = "label101";
			this.label101.Size = new System.Drawing.Size(52, 15);
			this.label101.TabIndex = 0;
			this.label101.Text = "여신사";
			// 
			// lblUSR_ID
			// 
			this.lblUSR_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblUSR_ID.AutoSize = true;
			this.lblUSR_ID.Location = new System.Drawing.Point(37, 60);
			this.lblUSR_ID.Name = "lblUSR_ID";
			this.lblUSR_ID.Size = new System.Drawing.Size(67, 15);
			this.lblUSR_ID.TabIndex = 2;
			this.lblUSR_ID.Text = "대출일자";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(271, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "신청금액";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(506, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 15);
			this.label7.TabIndex = 10;
			this.label7.Text = "대출일수";
			// 
			// _txtLNMNT
			// 
			this._txtLNMNT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtLNMNT.Compulsory = true;
			this._txtLNMNT.DelegateProperty = true;
			this._txtLNMNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtLNMNT.ImeMode = BANANA.Windows.Controls.ImeMode.Decimal;
			this._txtLNMNT.Location = new System.Drawing.Point(579, 30);
			this._txtLNMNT.Name = "_txtLNMNT";
			this._txtLNMNT.Size = new System.Drawing.Size(110, 23);
			this._txtLNMNT.TabIndex = 1000;
			this._txtLNMNT.Text = "100";
			this._txtLNMNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtLNMNT.ValidationGroup = "a";
			this._txtLNMNT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtLNMNT.WaterMarkText = "";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(241, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 15);
			this.label11.TabIndex = 34;
			this.label11.Text = "상환시작일자";
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(67, 142);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(37, 15);
			this.label14.TabIndex = 32;
			this.label14.Text = "비고";
			// 
			// gridView1
			// 
			this.gridView1.AutoSelectRowWithRightButton = false;
			this.gridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView1.ColumnHeadersHeight = 50;
			this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STR_NM,
            this.STR_CD,
            this.PRSNT_NM,
            this.BI_SAUP_NO});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 21);
			this.gridView1.MultiSelect = false;
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(441, 589);
			this.gridView1.TabIndex = 0;
			this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
			this.gridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridView1_DataBindingComplete);
			// 
			// STR_NM
			// 
			this.STR_NM.DataPropertyName = "STR_NM";
			this.STR_NM.Frozen = true;
			this.STR_NM.HeaderText = "가맹점명";
			this.STR_NM.Name = "STR_NM";
			this.STR_NM.ReadOnly = true;
			this.STR_NM.Width = 94;
			// 
			// STR_CD
			// 
			this.STR_CD.DataPropertyName = "STR_CD";
			this.STR_CD.HeaderText = "가맹점코드";
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Width = 108;
			// 
			// PRSNT_NM
			// 
			this.PRSNT_NM.HeaderText = "대표자명";
			this.PRSNT_NM.Name = "PRSNT_NM";
			this.PRSNT_NM.ReadOnly = true;
			this.PRSNT_NM.Width = 94;
			// 
			// BI_SAUP_NO
			// 
			this.BI_SAUP_NO.DataPropertyName = "BI_SAUP_NO";
			this.BI_SAUP_NO.HeaderText = "사업자번호";
			this.BI_SAUP_NO.MinimumWidth = 100;
			this.BI_SAUP_NO.Name = "BI_SAUP_NO";
			this.BI_SAUP_NO.ReadOnly = true;
			this.BI_SAUP_NO.Width = 108;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel6);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1145, 57);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "검색 조건";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 11;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 508F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Controls.Add(this._txtPRSNT_NM, 3, 0);
			this.tableLayoutPanel6.Controls.Add(this._txtSTR_NM, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel4, 9, 0);
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 8, 0);
			this.tableLayoutPanel6.Controls.Add(this.label37, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this._btnSearch, 6, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1139, 33);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// _txtPRSNT_NM
			// 
			this._txtPRSNT_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtPRSNT_NM.AutoTab = false;
			this._txtPRSNT_NM.DelegateProperty = true;
			this._txtPRSNT_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtPRSNT_NM.Location = new System.Drawing.Point(331, 3);
			this._txtPRSNT_NM.Name = "_txtPRSNT_NM";
			this._txtPRSNT_NM.Size = new System.Drawing.Size(103, 23);
			this._txtPRSNT_NM.TabIndex = 1118;
			this._txtPRSNT_NM.ValidationGroup = null;
			this._txtPRSNT_NM.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtPRSNT_NM.WaterMarkText = "";
			// 
			// _txtSTR_NM
			// 
			this._txtSTR_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtSTR_NM.AutoTab = false;
			this._txtSTR_NM.DelegateProperty = true;
			this._txtSTR_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_NM.Location = new System.Drawing.Point(93, 3);
			this._txtSTR_NM.Name = "_txtSTR_NM";
			this._txtSTR_NM.Size = new System.Drawing.Size(120, 23);
			this._txtSTR_NM.TabIndex = 100;
			this._txtSTR_NM.ValidationGroup = null;
			this._txtSTR_NM.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSTR_NM.WaterMarkText = "";
			// 
			// label35
			// 
			this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(20, 7);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(67, 15);
			this.label35.TabIndex = 1114;
			this.label35.Text = "가맹점명";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(1228, 0);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(55, 30);
			this.flowLayoutPanel4.TabIndex = 160;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(720, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 30);
			this.flowLayoutPanel1.TabIndex = 120;
			// 
			// label37
			// 
			this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(258, 7);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(67, 15);
			this.label37.TabIndex = 1116;
			this.label37.Text = "대표자명";
			// 
			// _btnSearch
			// 
			this._btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnSearch.DelegateProperty = true;
			this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.Location = new System.Drawing.Point(567, 1);
			this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
			this._btnSearch.Name = "_btnSearch";
			this._btnSearch.Reserved = "      검   색";
			this._btnSearch.Size = new System.Drawing.Size(75, 27);
			this._btnSearch.TabIndex = 1117;
			this._btnSearch.Text = "      검   색";
			this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.UseVisualStyleBackColor = true;
			this._btnSearch.ValidationGroup = null;
			this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
			// 
			// LRN0110
			// 
			this.ClientSize = new System.Drawing.Size(1145, 670);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LRN0110";
			this.Text = "비즈론원장등록:LRN0110";
			this.Load += new System.EventHandler(this.LRN0110_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private BANANA.Windows.Controls.TextBox _txtSTR_NM;
        private BANANA.Windows.Controls.Label label35;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BANANA.Windows.Controls.Label label37;
        private BANANA.Windows.Controls.GroupBox groupBox3;
        private DemoClient.Controls.GridView gridView1;
        private DemoClient.Controls.BananaButton _btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private DemoClient.Controls.BananaButton _btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BANANA.Windows.Controls.DateTimePicker _dtpLNSTDT;
        private BANANA.Windows.Controls.DateTimePicker _dtpEXECDT;
        private System.Windows.Forms.Label label13;
        private BANANA.Windows.Controls.ComboBox _cmbLNR_CD;
        private BANANA.Windows.Controls.TextBox _txtBIGO;
        private BANANA.Windows.Controls.TextBox _txtINTRRTYEAR;
        private BANANA.Windows.Controls.TextBox _txtLNAMT;
        private BANANA.Windows.Controls.Label label101;
        private BANANA.Windows.Controls.Label lblUSR_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BANANA.Windows.Controls.TextBox _txtLNMNT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private DemoClient.Controls.CollapsibleSplitter collapsibleSplitter1;
        private BANANA.Windows.Controls.TextBox _txtSTR_NM_S1;
        private BANANA.Windows.Controls.Label label5;
        private BANANA.Windows.Controls.TextBox _txtSTR_CD;
        private BANANA.Windows.Controls.Label label4;
        private BANANA.Windows.Controls.TextBox _txtPRSNT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRSNT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI_SAUP_NO;



    }
}
