namespace DemoClient.View.WDR
{
    partial class WDR1010
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WDR1010));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new DemoClient.Controls.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this._btnExcel = new DemoClient.Controls.BananaButton();
			this._cmbCREDIT_CD_S = new BANANA.Windows.Controls.ComboBox();
			this.label2 = new BANANA.Windows.Controls.Label();
			this._txtSTR_CD_S = new BANANA.Windows.Controls.TextBox();
			this._txtSTR_NM_S = new BANANA.Windows.Controls.TextBox();
			this.label35 = new BANANA.Windows.Controls.Label();
			this.label36 = new BANANA.Windows.Controls.Label();
			this.label37 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._dtpTRADEDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._dtpTRADEDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
			this.label3 = new BANANA.Windows.Controls.Label();
			this._cmbBUYING_CD_S = new BANANA.Windows.Controls.ComboBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.STR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_STRT_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_USE_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_GIJUN_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_CAL_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_INTST_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_PER = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DPST_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel6);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1145, 76);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "검색 조건";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel6.ColumnCount = 7;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel2, 5, 1);
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel4, 6, 0);
			this.tableLayoutPanel6.Controls.Add(this._cmbCREDIT_CD_S, 3, 1);
			this.tableLayoutPanel6.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this._txtSTR_CD_S, 3, 0);
			this.tableLayoutPanel6.Controls.Add(this._txtSTR_NM_S, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.label36, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.label37, 4, 0);
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 5, 0);
			this.tableLayoutPanel6.Controls.Add(this.label3, 2, 1);
			this.tableLayoutPanel6.Controls.Add(this._cmbBUYING_CD_S, 1, 1);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1139, 52);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(536, 29);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(340, 27);
			this.flowLayoutPanel2.TabIndex = 150;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._btnSearch);
			this.flowLayoutPanel4.Controls.Add(this._btnExcel);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(877, 1);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel4.Size = new System.Drawing.Size(543, 27);
			this.flowLayoutPanel4.TabIndex = 160;
			// 
			// _btnSearch
			// 
			this._btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnSearch.DelegateProperty = true;
			this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.Location = new System.Drawing.Point(0, 2);
			this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
			this._btnSearch.Name = "_btnSearch";
			this._btnSearch.Reserved = "      검   색";
			this._btnSearch.Size = new System.Drawing.Size(75, 23);
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
			this._btnExcel.Location = new System.Drawing.Point(75, 2);
			this._btnExcel.Margin = new System.Windows.Forms.Padding(0);
			this._btnExcel.Name = "_btnExcel";
			this._btnExcel.Reserved = "      엑   셀";
			this._btnExcel.Size = new System.Drawing.Size(75, 23);
			this._btnExcel.TabIndex = 20;
			this._btnExcel.Text = "      엑   셀";
			this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnExcel.UseVisualStyleBackColor = true;
			this._btnExcel.ValidationGroup = null;
			// 
			// _cmbCREDIT_CD_S
			// 
			this._cmbCREDIT_CD_S.DataSource = null;
			this._cmbCREDIT_CD_S.DelegateProperty = true;
			this._cmbCREDIT_CD_S.DroppedDown = false;
			this._cmbCREDIT_CD_S.Location = new System.Drawing.Point(317, 32);
			this._cmbCREDIT_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbCREDIT_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbCREDIT_CD_S.Name = "_cmbCREDIT_CD_S";
			this._cmbCREDIT_CD_S.SelectedIndex = -1;
			this._cmbCREDIT_CD_S.SelectedItem = null;
			this._cmbCREDIT_CD_S.SelectedValue = null;
			this._cmbCREDIT_CD_S.Size = new System.Drawing.Size(120, 23);
			this._cmbCREDIT_CD_S.TabIndex = 140;
			this._cmbCREDIT_CD_S.ValidationGroup = null;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1115;
			this.label2.Text = "차감기준";
			// 
			// _txtSTR_CD_S
			// 
			this._txtSTR_CD_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtSTR_CD_S.AutoTab = false;
			this._txtSTR_CD_S.DelegateProperty = true;
			this._txtSTR_CD_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_CD_S.Location = new System.Drawing.Point(317, 4);
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
			this._txtSTR_NM_S.Location = new System.Drawing.Point(95, 4);
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
			this.label35.Location = new System.Drawing.Point(21, 7);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(67, 15);
			this.label35.TabIndex = 1114;
			this.label35.Text = "가맹점명";
			// 
			// label36
			// 
			this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(228, 7);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(82, 15);
			this.label36.TabIndex = 1115;
			this.label36.Text = "가맹점코드";
			// 
			// label37
			// 
			this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(465, 7);
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
			this.flowLayoutPanel1.Location = new System.Drawing.Point(536, 1);
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
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(243, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 1117;
			this.label3.Text = "계산방법";
			// 
			// _cmbBUYING_CD_S
			// 
			this._cmbBUYING_CD_S.DataSource = null;
			this._cmbBUYING_CD_S.DelegateProperty = true;
			this._cmbBUYING_CD_S.DroppedDown = false;
			this._cmbBUYING_CD_S.Location = new System.Drawing.Point(95, 32);
			this._cmbBUYING_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbBUYING_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbBUYING_CD_S.Name = "_cmbBUYING_CD_S";
			this._cmbBUYING_CD_S.SelectedIndex = -1;
			this._cmbBUYING_CD_S.SelectedItem = null;
			this._cmbBUYING_CD_S.SelectedValue = null;
			this._cmbBUYING_CD_S.Size = new System.Drawing.Size(120, 23);
			this._cmbBUYING_CD_S.TabIndex = 130;
			this._cmbBUYING_CD_S.ValidationGroup = null;
			// 
			// gridView1
			// 
			this.gridView1.AutoSelectRowWithRightButton = false;
			this.gridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STR_CD,
            this.STR_NM,
            this.DPST_STRT_DT,
            this.DPST_USE_YN,
            this.DPST_GIJUN_NM,
            this.DPST_CAL_NM,
            this.DPST_INTST_YN,
            this.DPST_PER,
            this.DPST_AMT,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(0, 76);
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(1145, 594);
			this.gridView1.TabIndex = 25;
			// 
			// STR_CD
			// 
			this.STR_CD.DataPropertyName = "STR_CD";
			this.STR_CD.HeaderText = "가맹점코드";
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Width = 111;
			// 
			// STR_NM
			// 
			this.STR_NM.DataPropertyName = "STR_NM";
			this.STR_NM.HeaderText = "가맹점명";
			this.STR_NM.Name = "STR_NM";
			this.STR_NM.ReadOnly = true;
			this.STR_NM.Width = 96;
			// 
			// DPST_STRT_DT
			// 
			this.DPST_STRT_DT.DataPropertyName = "DPST_STRT_DT";
			this.DPST_STRT_DT.HeaderText = "적용시작일";
			this.DPST_STRT_DT.Name = "DPST_STRT_DT";
			this.DPST_STRT_DT.ReadOnly = true;
			this.DPST_STRT_DT.Width = 111;
			// 
			// DPST_USE_YN
			// 
			this.DPST_USE_YN.DataPropertyName = "DPST_USE_YN";
			this.DPST_USE_YN.HeaderText = "사용여부";
			this.DPST_USE_YN.Name = "DPST_USE_YN";
			this.DPST_USE_YN.ReadOnly = true;
			this.DPST_USE_YN.Width = 96;
			// 
			// DPST_GIJUN_NM
			// 
			this.DPST_GIJUN_NM.DataPropertyName = "DPST_GIJUN_NM";
			this.DPST_GIJUN_NM.HeaderText = "차감기준";
			this.DPST_GIJUN_NM.Name = "DPST_GIJUN_NM";
			this.DPST_GIJUN_NM.ReadOnly = true;
			this.DPST_GIJUN_NM.Width = 96;
			// 
			// DPST_CAL_NM
			// 
			this.DPST_CAL_NM.DataPropertyName = "DPST_CAL_NM";
			this.DPST_CAL_NM.HeaderText = "계산방법";
			this.DPST_CAL_NM.Name = "DPST_CAL_NM";
			this.DPST_CAL_NM.ReadOnly = true;
			this.DPST_CAL_NM.Width = 96;
			// 
			// DPST_INTST_YN
			// 
			this.DPST_INTST_YN.DataPropertyName = "DPST_INTST_YN";
			this.DPST_INTST_YN.HeaderText = "미차감이자";
			this.DPST_INTST_YN.Name = "DPST_INTST_YN";
			this.DPST_INTST_YN.ReadOnly = true;
			this.DPST_INTST_YN.Width = 111;
			// 
			// DPST_PER
			// 
			this.DPST_PER.DataPropertyName = "DPST_PER";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.DPST_PER.DefaultCellStyle = dataGridViewCellStyle2;
			this.DPST_PER.HeaderText = "차감수치";
			this.DPST_PER.Name = "DPST_PER";
			this.DPST_PER.ReadOnly = true;
			this.DPST_PER.Width = 96;
			// 
			// DPST_AMT
			// 
			this.DPST_AMT.DataPropertyName = "DPST_AMT";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.DPST_AMT.DefaultCellStyle = dataGridViewCellStyle3;
			this.DPST_AMT.HeaderText = "보증한도금액";
			this.DPST_AMT.Name = "DPST_AMT";
			this.DPST_AMT.ReadOnly = true;
			this.DPST_AMT.Width = 126;
			// 
			// SYSREGDATE
			// 
			this.SYSREGDATE.DataPropertyName = "SYSREGDATE";
			this.SYSREGDATE.HeaderText = "시스템등록일";
			this.SYSREGDATE.Name = "SYSREGDATE";
			this.SYSREGDATE.ReadOnly = true;
			this.SYSREGDATE.Width = 126;
			// 
			// SYSREGNAME
			// 
			this.SYSREGNAME.DataPropertyName = "SYSREGNAME";
			this.SYSREGNAME.HeaderText = "시스템등록자";
			this.SYSREGNAME.Name = "SYSREGNAME";
			this.SYSREGNAME.ReadOnly = true;
			this.SYSREGNAME.Width = 126;
			// 
			// SYSMODDATE
			// 
			this.SYSMODDATE.DataPropertyName = "SYSMODDATE";
			this.SYSMODDATE.HeaderText = "시스템수정일";
			this.SYSMODDATE.Name = "SYSMODDATE";
			this.SYSMODDATE.ReadOnly = true;
			this.SYSMODDATE.Width = 126;
			// 
			// SYSMODNAME
			// 
			this.SYSMODNAME.DataPropertyName = "SYSMODNAME";
			this.SYSMODNAME.HeaderText = "시스템수정자";
			this.SYSMODNAME.Name = "SYSMODNAME";
			this.SYSMODNAME.ReadOnly = true;
			this.SYSMODNAME.Width = 126;
			// 
			// WDR1010
			// 
			this.ClientSize = new System.Drawing.Size(1145, 670);
			this.Controls.Add(this.gridView1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WDR1010";
			this.Text = "기타수수료차감내역조회:WDR1010";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private DemoClient.Controls.BananaButton _btnSearch;
        private DemoClient.Controls.BananaButton _btnExcel;
        private BANANA.Windows.Controls.ComboBox _cmbCREDIT_CD_S;
        private BANANA.Windows.Controls.Label label2;
        private BANANA.Windows.Controls.TextBox _txtSTR_CD_S;
        private BANANA.Windows.Controls.TextBox _txtSTR_NM_S;
        private BANANA.Windows.Controls.Label label35;
        private BANANA.Windows.Controls.Label label36;
        private BANANA.Windows.Controls.Label label37;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BANANA.Windows.Controls.DateTimePicker _dtpTRADEDATE_S_S;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.DateTimePicker _dtpTRADEDATE_E_S;
        private BANANA.Windows.Controls.Label label3;
        private BANANA.Windows.Controls.ComboBox _cmbBUYING_CD_S;
        private DemoClient.Controls.GridView gridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_STRT_DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_USE_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_GIJUN_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_CAL_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_INTST_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_PER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;





    }
}
