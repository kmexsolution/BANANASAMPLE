namespace DemoClient.View.ACC
{
    partial class ACC0310
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACC0310));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this._btnExcel = new DemoClient.Controls.BananaButton();
			this._txtSTR_CD_S = new BANANA.Windows.Controls.TextBox();
			this._txtSTR_NM_S = new BANANA.Windows.Controls.TextBox();
			this.label35 = new BANANA.Windows.Controls.Label();
			this.label36 = new BANANA.Windows.Controls.Label();
			this.label37 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._dtpTRADEDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._dtpTRADEDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_NM_INDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TRADEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_DAILY_LMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_TOT_LMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LIVEWDRAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APPRAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CNCLAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BUYING_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDRAPPR_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAGAM_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel6);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1145, 49);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "검색 조건";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 7;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel4, 6, 0);
			this.tableLayoutPanel6.Controls.Add(this._txtSTR_CD_S, 3, 0);
			this.tableLayoutPanel6.Controls.Add(this._txtSTR_NM_S, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.label36, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.label37, 4, 0);
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 5, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1139, 25);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._btnSearch);
			this.flowLayoutPanel4.Controls.Add(this._btnExcel);
			this.flowLayoutPanel4.Location = new System.Drawing.Point(870, 0);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(250, 27);
			this.flowLayoutPanel4.TabIndex = 160;
			// 
			// _btnSearch
			// 
			this._btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnSearch.DelegateProperty = true;
			this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.Location = new System.Drawing.Point(0, 0);
			this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
			this._btnSearch.Name = "_btnSearch";
			this._btnSearch.Reserved = "      검   색";
			this._btnSearch.Size = new System.Drawing.Size(75, 27);
			this._btnSearch.TabIndex = 10;
			this._btnSearch.Text = "      검   색";
			this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.UseVisualStyleBackColor = true;
			this._btnSearch.ValidationGroup = null;
			// 
			// _btnExcel
			// 
			this._btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnExcel.DelegateProperty = true;
			this._btnExcel.Image = global::DemoClient.Properties.Resources.EXCEL_0002;
			this._btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnExcel.Location = new System.Drawing.Point(75, 0);
			this._btnExcel.Margin = new System.Windows.Forms.Padding(0);
			this._btnExcel.Name = "_btnExcel";
			this._btnExcel.Reserved = "      엑   셀";
			this._btnExcel.Size = new System.Drawing.Size(75, 27);
			this._btnExcel.TabIndex = 20;
			this._btnExcel.Text = "      엑   셀";
			this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnExcel.UseVisualStyleBackColor = true;
			this._btnExcel.ValidationGroup = null;
			// 
			// _txtSTR_CD_S
			// 
			this._txtSTR_CD_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtSTR_CD_S.AutoTab = false;
			this._txtSTR_CD_S.DelegateProperty = true;
			this._txtSTR_CD_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_CD_S.Location = new System.Drawing.Point(313, 3);
			this._txtSTR_CD_S.Name = "_txtSTR_CD_S";
			this._txtSTR_CD_S.Size = new System.Drawing.Size(120, 23);
			this._txtSTR_CD_S.TabIndex = 110;
			this._txtSTR_CD_S.ValidationGroup = null;
			this._txtSTR_CD_S.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSTR_CD_S.WaterMarkText = "";
			// 
			// _txtSTR_NM_S
			// 
			this._txtSTR_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtSTR_NM_S.AutoTab = false;
			this._txtSTR_NM_S.DelegateProperty = true;
			this._txtSTR_NM_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_NM_S.Location = new System.Drawing.Point(93, 3);
			this._txtSTR_NM_S.Name = "_txtSTR_NM_S";
			this._txtSTR_NM_S.Size = new System.Drawing.Size(120, 23);
			this._txtSTR_NM_S.TabIndex = 100;
			this._txtSTR_NM_S.ValidationGroup = null;
			this._txtSTR_NM_S.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSTR_NM_S.WaterMarkText = "";
			// 
			// label35
			// 
			this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(20, 6);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(67, 15);
			this.label35.TabIndex = 1114;
			this.label35.Text = "가맹점명";
			// 
			// label36
			// 
			this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(225, 6);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(82, 15);
			this.label36.TabIndex = 1115;
			this.label36.Text = "가맹점코드";
			// 
			// label37
			// 
			this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(460, 6);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(67, 15);
			this.label37.TabIndex = 1116;
			this.label37.Text = "거래일자";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._dtpTRADEDATE_S_S);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._dtpTRADEDATE_E_S);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(530, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 27);
			this.flowLayoutPanel1.TabIndex = 120;
			// 
			// _dtpTRADEDATE_S_S
			// 
			this._dtpTRADEDATE_S_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpTRADEDATE_S_S.Checked = false;
			this._dtpTRADEDATE_S_S.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpTRADEDATE_S_S.DelegateProperty = true;
			this._dtpTRADEDATE_S_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpTRADEDATE_S_S.Location = new System.Drawing.Point(3, 5);
			this._dtpTRADEDATE_S_S.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpTRADEDATE_S_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpTRADEDATE_S_S.Name = "_dtpTRADEDATE_S_S";
			this._dtpTRADEDATE_S_S.Size = new System.Drawing.Size(150, 21);
			this._dtpTRADEDATE_S_S.TabIndex = 25;
			this._dtpTRADEDATE_S_S.ValidationGroup = null;
			this._dtpTRADEDATE_S_S.Value = new System.DateTime(2014, 7, 26, 13, 51, 32, 431);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "~";
			// 
			// _dtpTRADEDATE_E_S
			// 
			this._dtpTRADEDATE_E_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpTRADEDATE_E_S.Checked = false;
			this._dtpTRADEDATE_E_S.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpTRADEDATE_E_S.DelegateProperty = true;
			this._dtpTRADEDATE_E_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpTRADEDATE_E_S.Location = new System.Drawing.Point(183, 3);
			this._dtpTRADEDATE_E_S.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpTRADEDATE_E_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpTRADEDATE_E_S.Name = "_dtpTRADEDATE_E_S";
			this._dtpTRADEDATE_E_S.Size = new System.Drawing.Size(150, 21);
			this._dtpTRADEDATE_E_S.TabIndex = 26;
			this._dtpTRADEDATE_E_S.ValidationGroup = null;
			this._dtpTRADEDATE_E_S.Value = new System.DateTime(2014, 7, 26, 13, 51, 32, 431);
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
            this.CHK,
            this.STR_NM,
            this.STR_CD,
            this.STR_NM_INDEX,
            this.TRADEDATE,
            this.CI_DAILY_LMT,
            this.CI_TOT_LMT,
            this.LIVEWDRAMT,
            this.APPRAMT,
            this.CNCLAMT,
            this.BUYING_FEE,
            this.SUB_TOTAL,
            this.WDRAPPR_MEMO,
            this.MAGAM_YN,
            this.SYSMODDATE,
            this.SYSMODNAME,
            this.STATUS});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.DefaultCellStyle = dataGridViewCellStyle9;
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 21);
			this.gridView1.MultiSelect = false;
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.ShowHeaderCheckBox = true;
			this.gridView1.Size = new System.Drawing.Size(1139, 597);
			this.gridView1.TabIndex = 0;
			// 
			// CHK
			// 
			this.CHK.DataPropertyName = "CHK";
			this.CHK.FalseValue = "N";
			this.CHK.Frozen = true;
			this.CHK.HeaderText = "";
			this.CHK.IndeterminateValue = "";
			this.CHK.MinimumWidth = 20;
			this.CHK.Name = "CHK";
			this.CHK.ReadOnly = true;
			this.CHK.TrueValue = "Y";
			this.CHK.Width = 20;
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
			this.STR_CD.Frozen = true;
			this.STR_CD.HeaderText = "가맹점코드";
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Width = 108;
			// 
			// STR_NM_INDEX
			// 
			this.STR_NM_INDEX.DataPropertyName = "STR_NM_INDEX";
			this.STR_NM_INDEX.HeaderText = "인덱스용 가맹점명";
			this.STR_NM_INDEX.Name = "STR_NM_INDEX";
			this.STR_NM_INDEX.ReadOnly = true;
			this.STR_NM_INDEX.Visible = false;
			this.STR_NM_INDEX.Width = 155;
			// 
			// TRADEDATE
			// 
			this.TRADEDATE.DataPropertyName = "TRADEDATE";
			this.TRADEDATE.HeaderText = "거래일자";
			this.TRADEDATE.MinimumWidth = 120;
			this.TRADEDATE.Name = "TRADEDATE";
			this.TRADEDATE.ReadOnly = true;
			this.TRADEDATE.Width = 120;
			// 
			// CI_DAILY_LMT
			// 
			this.CI_DAILY_LMT.DataPropertyName = "CI_DAILY_LMT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "0";
			this.CI_DAILY_LMT.DefaultCellStyle = dataGridViewCellStyle2;
			this.CI_DAILY_LMT.HeaderText = "1일";
			this.CI_DAILY_LMT.Name = "CI_DAILY_LMT";
			this.CI_DAILY_LMT.ReadOnly = true;
			this.CI_DAILY_LMT.Width = 60;
			// 
			// CI_TOT_LMT
			// 
			this.CI_TOT_LMT.DataPropertyName = "CI_TOT_LMT";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			this.CI_TOT_LMT.DefaultCellStyle = dataGridViewCellStyle3;
			this.CI_TOT_LMT.HeaderText = "총한도";
			this.CI_TOT_LMT.Name = "CI_TOT_LMT";
			this.CI_TOT_LMT.ReadOnly = true;
			this.CI_TOT_LMT.Width = 80;
			// 
			// LIVEWDRAMT
			// 
			this.LIVEWDRAMT.DataPropertyName = "LIVEWDRAMT";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			this.LIVEWDRAMT.DefaultCellStyle = dataGridViewCellStyle4;
			this.LIVEWDRAMT.HeaderText = "잔여한도";
			this.LIVEWDRAMT.Name = "LIVEWDRAMT";
			this.LIVEWDRAMT.ReadOnly = true;
			this.LIVEWDRAMT.Width = 94;
			// 
			// APPRAMT
			// 
			this.APPRAMT.DataPropertyName = "APPRAMT";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N0";
			this.APPRAMT.DefaultCellStyle = dataGridViewCellStyle5;
			this.APPRAMT.HeaderText = "승인금액";
			this.APPRAMT.Name = "APPRAMT";
			this.APPRAMT.ReadOnly = true;
			this.APPRAMT.Width = 94;
			// 
			// CNCLAMT
			// 
			this.CNCLAMT.DataPropertyName = "CNCLAMT";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.Format = "N0";
			this.CNCLAMT.DefaultCellStyle = dataGridViewCellStyle6;
			this.CNCLAMT.HeaderText = "취소금액";
			this.CNCLAMT.Name = "CNCLAMT";
			this.CNCLAMT.ReadOnly = true;
			this.CNCLAMT.Width = 94;
			// 
			// BUYING_FEE
			// 
			this.BUYING_FEE.DataPropertyName = "BUYING_FEE";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "N0";
			this.BUYING_FEE.DefaultCellStyle = dataGridViewCellStyle7;
			this.BUYING_FEE.HeaderText = "매입카드수수료";
			this.BUYING_FEE.Name = "BUYING_FEE";
			this.BUYING_FEE.ReadOnly = true;
			this.BUYING_FEE.Width = 136;
			// 
			// SUB_TOTAL
			// 
			this.SUB_TOTAL.DataPropertyName = "SUB_TOTAL";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N0";
			this.SUB_TOTAL.DefaultCellStyle = dataGridViewCellStyle8;
			this.SUB_TOTAL.HeaderText = "소계";
			this.SUB_TOTAL.Name = "SUB_TOTAL";
			this.SUB_TOTAL.ReadOnly = true;
			this.SUB_TOTAL.Width = 66;
			// 
			// WDRAPPR_MEMO
			// 
			this.WDRAPPR_MEMO.DataPropertyName = "WDRAPPR_MEMO";
			this.WDRAPPR_MEMO.HeaderText = "출금승인상태메모";
			this.WDRAPPR_MEMO.Name = "WDRAPPR_MEMO";
			this.WDRAPPR_MEMO.ReadOnly = true;
			this.WDRAPPR_MEMO.Width = 150;
			// 
			// MAGAM_YN
			// 
			this.MAGAM_YN.DataPropertyName = "MAGAM_YN";
			this.MAGAM_YN.HeaderText = "정산마감여부";
			this.MAGAM_YN.Name = "MAGAM_YN";
			this.MAGAM_YN.ReadOnly = true;
			this.MAGAM_YN.Width = 122;
			// 
			// SYSMODDATE
			// 
			this.SYSMODDATE.DataPropertyName = "SYSMODDATE";
			this.SYSMODDATE.HeaderText = "시스템수정일";
			this.SYSMODDATE.Name = "SYSMODDATE";
			this.SYSMODDATE.ReadOnly = true;
			this.SYSMODDATE.Width = 122;
			// 
			// SYSMODNAME
			// 
			this.SYSMODNAME.DataPropertyName = "SYSMODNAME";
			this.SYSMODNAME.HeaderText = "시스템수정자";
			this.SYSMODNAME.Name = "SYSMODNAME";
			this.SYSMODNAME.ReadOnly = true;
			this.SYSMODNAME.Width = 122;
			// 
			// STATUS
			// 
			this.STATUS.DataPropertyName = "STATUS";
			this.STATUS.HeaderText = "처리결과";
			this.STATUS.Name = "STATUS";
			this.STATUS.ReadOnly = true;
			this.STATUS.Width = 94;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridView1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 49);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1145, 621);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "검색 결과";
			// 
			// ACC0310
			// 
			this.ClientSize = new System.Drawing.Size(1145, 670);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ACC0310";
			this.Text = "정산마감이력조회:ACC0310";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private DemoClient.Controls.BananaButton _btnSearch;
        private DemoClient.Controls.BananaButton _btnExcel;
        private BANANA.Windows.Controls.TextBox _txtSTR_CD_S;
        private BANANA.Windows.Controls.TextBox _txtSTR_NM_S;
        private BANANA.Windows.Controls.Label label35;
        private BANANA.Windows.Controls.Label label36;
        private BANANA.Windows.Controls.Label label37;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BANANA.Windows.Controls.DateTimePicker _dtpTRADEDATE_S_S;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.DateTimePicker _dtpTRADEDATE_E_S;
        private DemoClient.Controls.GridView gridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM_INDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRADEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI_DAILY_LMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI_TOT_LMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIVEWDRAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPRAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNCLAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUYING_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDRAPPR_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGAM_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private BANANA.Windows.Controls.GroupBox groupBox3;



    }
}
