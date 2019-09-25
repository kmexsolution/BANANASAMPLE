namespace DemoClient.View.RDM
{
    partial class RDM0120
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDM0120));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.label35 = new BANANA.Windows.Controls.Label();
			this._txtFile = new BANANA.Windows.Controls.TextBox();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnInsert = new DemoClient.Controls.BananaButton();
			this._cmbBANK_CD = new BANANA.Windows.Controls.ComboBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._btnFindFile = new DemoClient.Controls.BananaButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox2 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new DemoClient.Controls.TableLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this._btnCheckAll = new DemoClient.Controls.BananaButton();
			this._btnUnCheckAll = new DemoClient.Controls.BananaButton();
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_STR = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PRSNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BI_SAUP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BI_BINF_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DUEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUM_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ABSTRACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_CONTENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_BRANCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SENDFEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
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
			this.tableLayoutPanel6.ColumnCount = 7;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this._txtFile, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this._btnSave, 6, 0);
			this.tableLayoutPanel6.Controls.Add(this._btnInsert, 5, 0);
			this.tableLayoutPanel6.Controls.Add(this._cmbBANK_CD, 4, 0);
			this.tableLayoutPanel6.Controls.Add(this.label1, 3, 0);
			this.tableLayoutPanel6.Controls.Add(this._btnFindFile, 2, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1139, 37);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// label35
			// 
			this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(46, 12);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(41, 12);
			this.label35.TabIndex = 1114;
			this.label35.Text = "파일명";
			// 
			// _txtFile
			// 
			this._txtFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtFile.AutoTab = false;
			this._txtFile.DelegateProperty = true;
			this._txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtFile.Location = new System.Drawing.Point(93, 8);
			this._txtFile.Name = "_txtFile";
			this._txtFile.ReadOnly = true;
			this._txtFile.Size = new System.Drawing.Size(294, 20);
			this._txtFile.TabIndex = 100;
			this._txtFile.ValidationGroup = null;
			this._txtFile.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtFile.WaterMarkText = "";
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(785, 5);
			this._btnSave.Margin = new System.Windows.Forms.Padding(0);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Reserved = "      저   장";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 1118;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = null;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _btnInsert
			// 
			this._btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnInsert.DelegateProperty = true;
			this._btnInsert.Image = global::DemoClient.Properties.Resources._1377801089_62655;
			this._btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnInsert.Location = new System.Drawing.Point(708, 5);
			this._btnInsert.Margin = new System.Windows.Forms.Padding(0);
			this._btnInsert.Name = "_btnInsert";
			this._btnInsert.Reserved = "      적   용";
			this._btnInsert.Size = new System.Drawing.Size(75, 27);
			this._btnInsert.TabIndex = 1117;
			this._btnInsert.Text = "      적   용";
			this._btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnInsert.UseVisualStyleBackColor = true;
			this._btnInsert.ValidationGroup = null;
			this._btnInsert.Click += new System.EventHandler(this._btnInsert_Click);
			// 
			// _cmbBANK_CD
			// 
			this._cmbBANK_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbBANK_CD.DataSource = null;
			this._cmbBANK_CD.DelegateProperty = true;
			this._cmbBANK_CD.DroppedDown = false;
			this._cmbBANK_CD.Location = new System.Drawing.Point(591, 8);
			this._cmbBANK_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbBANK_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbBANK_CD.Name = "_cmbBANK_CD";
			this._cmbBANK_CD.SelectedIndex = -1;
			this._cmbBANK_CD.SelectedItem = null;
			this._cmbBANK_CD.SelectedValue = null;
			this._cmbBANK_CD.Size = new System.Drawing.Size(114, 21);
			this._cmbBANK_CD.TabIndex = 1151;
			this._cmbBANK_CD.ValidationGroup = null;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(556, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 1120;
			this.label1.Text = "은행";
			// 
			// _btnFindFile
			// 
			this._btnFindFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnFindFile.DelegateProperty = true;
			this._btnFindFile.Location = new System.Drawing.Point(390, 5);
			this._btnFindFile.Margin = new System.Windows.Forms.Padding(0);
			this._btnFindFile.Name = "_btnFindFile";
			this._btnFindFile.Reserved = "파일 찾기";
			this._btnFindFile.Size = new System.Drawing.Size(81, 27);
			this._btnFindFile.TabIndex = 1119;
			this._btnFindFile.Text = "파일 찾기";
			this._btnFindFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnFindFile.UseVisualStyleBackColor = true;
			this._btnFindFile.ValidationGroup = null;
			this._btnFindFile.Click += new System.EventHandler(this._btnFindFile_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 616);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1145, 54);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "명령 처리";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.9434F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.0566F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 34);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel3
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 2);
			this.flowLayoutPanel3.Controls.Add(this._btnCheckAll);
			this.flowLayoutPanel3.Controls.Add(this._btnUnCheckAll);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(1, 1);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(923, 32);
			this.flowLayoutPanel3.TabIndex = 165;
			// 
			// _btnCheckAll
			// 
			this._btnCheckAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnCheckAll.DelegateProperty = true;
			this._btnCheckAll.Image = global::DemoClient.Properties.Resources._1377801059_62678;
			this._btnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnCheckAll.Location = new System.Drawing.Point(3, 3);
			this._btnCheckAll.Name = "_btnCheckAll";
			this._btnCheckAll.Reserved = "      전체체크";
			this._btnCheckAll.Size = new System.Drawing.Size(91, 27);
			this._btnCheckAll.TabIndex = 162;
			this._btnCheckAll.Text = "      전체체크";
			this._btnCheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnCheckAll.UseVisualStyleBackColor = true;
			this._btnCheckAll.ValidationGroup = null;
			this._btnCheckAll.Click += new System.EventHandler(this._btnCheckAll_Click);
			// 
			// _btnUnCheckAll
			// 
			this._btnUnCheckAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnUnCheckAll.DelegateProperty = true;
			this._btnUnCheckAll.Image = global::DemoClient.Properties.Resources._1377801059_62678;
			this._btnUnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnUnCheckAll.Location = new System.Drawing.Point(100, 3);
			this._btnUnCheckAll.Name = "_btnUnCheckAll";
			this._btnUnCheckAll.Reserved = "      전체해제";
			this._btnUnCheckAll.Size = new System.Drawing.Size(91, 27);
			this._btnUnCheckAll.TabIndex = 163;
			this._btnUnCheckAll.Text = "      전체해제";
			this._btnUnCheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnUnCheckAll.UseVisualStyleBackColor = true;
			this._btnUnCheckAll.ValidationGroup = null;
			this._btnUnCheckAll.Click += new System.EventHandler(this._btnUnCheckAll_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridView1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 57);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1145, 559);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "입금거래목록";
			// 
			// gridView1
			// 
			this.gridView1.AutoSelectRowWithRightButton = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView1.ColumnHeadersHeight = 50;
			this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHK,
            this.STR_NM,
            this.btn_STR,
            this.PRSNT_NM,
            this.BI_SAUP_NO,
            this.BI_BINF_CD,
            this.DUEDATE,
            this.AMOUNT,
            this.SUM_AMOUNT,
            this.ABSTRACT,
            this.STR_CONTENT,
            this.STR_BRANCH,
            this.STR_CD,
            this.SENDFEE});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.DefaultCellStyle = dataGridViewCellStyle7;
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 17);
			this.gridView1.MultiSelect = false;
			this.gridView1.Name = "gridView1";
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(1139, 539);
			this.gridView1.TabIndex = 0;
			this.gridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellContentClick);
			// 
			// CHK
			// 
			this.CHK.DataPropertyName = "CHK";
			this.CHK.FalseValue = "N";
			this.CHK.Frozen = true;
			this.CHK.HeaderText = "적용";
			this.CHK.MinimumWidth = 20;
			this.CHK.Name = "CHK";
			this.CHK.TrueValue = "Y";
			this.CHK.Width = 35;
			// 
			// STR_NM
			// 
			this.STR_NM.DataPropertyName = "STR_NM";
			this.STR_NM.Frozen = true;
			this.STR_NM.HeaderText = "가맹점명";
			this.STR_NM.Name = "STR_NM";
			this.STR_NM.Width = 76;
			// 
			// btn_STR
			// 
			this.btn_STR.DataPropertyName = "btn_STR";
			this.btn_STR.Frozen = true;
			this.btn_STR.HeaderText = "가맹점";
			this.btn_STR.Name = "btn_STR";
			this.btn_STR.Text = "";
			this.btn_STR.Width = 46;
			// 
			// PRSNT_NM
			// 
			this.PRSNT_NM.DataPropertyName = "PRSNT_NM";
			this.PRSNT_NM.Frozen = true;
			this.PRSNT_NM.HeaderText = "대표자명";
			this.PRSNT_NM.Name = "PRSNT_NM";
			this.PRSNT_NM.Width = 76;
			// 
			// BI_SAUP_NO
			// 
			this.BI_SAUP_NO.DataPropertyName = "BI_SAUP_NO";
			this.BI_SAUP_NO.Frozen = true;
			this.BI_SAUP_NO.HeaderText = "사업자등록번호";
			this.BI_SAUP_NO.Name = "BI_SAUP_NO";
			this.BI_SAUP_NO.Width = 109;
			// 
			// BI_BINF_CD
			// 
			this.BI_BINF_CD.DataPropertyName = "BI_BINF_CD";
			this.BI_BINF_CD.Frozen = true;
			this.BI_BINF_CD.HeaderText = "사업자구분";
			this.BI_BINF_CD.Name = "BI_BINF_CD";
			this.BI_BINF_CD.Width = 87;
			// 
			// DUEDATE
			// 
			this.DUEDATE.DataPropertyName = "DUEDATE";
			this.DUEDATE.Frozen = true;
			this.DUEDATE.HeaderText = "거래일자";
			this.DUEDATE.Name = "DUEDATE";
			this.DUEDATE.Width = 76;
			// 
			// AMOUNT
			// 
			this.AMOUNT.DataPropertyName = "AMOUNT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			this.AMOUNT.DefaultCellStyle = dataGridViewCellStyle2;
			this.AMOUNT.Frozen = true;
			this.AMOUNT.HeaderText = "거래금액";
			this.AMOUNT.MinimumWidth = 100;
			this.AMOUNT.Name = "AMOUNT";
			// 
			// SUM_AMOUNT
			// 
			this.SUM_AMOUNT.DataPropertyName = "SUM_AMOUNT";
			this.SUM_AMOUNT.Frozen = true;
			this.SUM_AMOUNT.HeaderText = "거래후잔액";
			this.SUM_AMOUNT.Name = "SUM_AMOUNT";
			this.SUM_AMOUNT.Width = 87;
			// 
			// ABSTRACT
			// 
			this.ABSTRACT.DataPropertyName = "ABSTRACT";
			dataGridViewCellStyle3.Format = "N0";
			this.ABSTRACT.DefaultCellStyle = dataGridViewCellStyle3;
			this.ABSTRACT.HeaderText = "적요";
			this.ABSTRACT.MinimumWidth = 100;
			this.ABSTRACT.Name = "ABSTRACT";
			// 
			// STR_CONTENT
			// 
			this.STR_CONTENT.DataPropertyName = "STR_CONTENT";
			dataGridViewCellStyle4.Format = "N0";
			this.STR_CONTENT.DefaultCellStyle = dataGridViewCellStyle4;
			this.STR_CONTENT.HeaderText = "기재내용";
			this.STR_CONTENT.MinimumWidth = 100;
			this.STR_CONTENT.Name = "STR_CONTENT";
			// 
			// STR_BRANCH
			// 
			this.STR_BRANCH.DataPropertyName = "STR_BRANCH";
			dataGridViewCellStyle5.Format = "N0";
			this.STR_BRANCH.DefaultCellStyle = dataGridViewCellStyle5;
			this.STR_BRANCH.HeaderText = "취급점";
			this.STR_BRANCH.MinimumWidth = 100;
			this.STR_BRANCH.Name = "STR_BRANCH";
			// 
			// STR_CD
			// 
			this.STR_CD.DataPropertyName = "STR_CD";
			this.STR_CD.HeaderText = "가맹점코드";
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.Visible = false;
			this.STR_CD.Width = 87;
			// 
			// SENDFEE
			// 
			this.SENDFEE.DataPropertyName = "SENDFEE";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.Format = "N0";
			dataGridViewCellStyle6.NullValue = "0";
			this.SENDFEE.DefaultCellStyle = dataGridViewCellStyle6;
			this.SENDFEE.HeaderText = "송금수수료";
			this.SENDFEE.Name = "SENDFEE";
			this.SENDFEE.Width = 87;
			// 
			// RDM0120
			// 
			this.ClientSize = new System.Drawing.Size(1145, 670);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RDM0120";
			this.Text = "상환마감처리등록:RDM0120";
			this.Load += new System.EventHandler(this.RDM0120_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private BANANA.Windows.Controls.TextBox _txtFile;
		private BANANA.Windows.Controls.Label label35;
		private DemoClient.Controls.BananaButton _btnInsert;
		private DemoClient.Controls.BananaButton _btnFindFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private DemoClient.Controls.BananaButton _btnSave;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.ComboBox _cmbBANK_CD;
		private BANANA.Windows.Controls.GroupBox groupBox2;
		private Controls.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private DemoClient.Controls.BananaButton _btnCheckAll;
		private DemoClient.Controls.BananaButton _btnUnCheckAll;
		private BANANA.Windows.Controls.GroupBox groupBox3;
		private DemoClient.Controls.GridView gridView1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
		private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
		private System.Windows.Forms.DataGridViewButtonColumn btn_STR;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRSNT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn BI_SAUP_NO;
		private System.Windows.Forms.DataGridViewTextBoxColumn BI_BINF_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn DUEDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUM_AMOUNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ABSTRACT;
		private System.Windows.Forms.DataGridViewTextBoxColumn STR_CONTENT;
		private System.Windows.Forms.DataGridViewTextBoxColumn STR_BRANCH;
		private System.Windows.Forms.DataGridViewTextBoxColumn STR_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn SENDFEE;
    }
}
