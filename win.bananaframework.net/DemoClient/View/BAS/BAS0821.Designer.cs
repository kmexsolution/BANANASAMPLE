namespace DemoClient.View.BAS
{
	partial class BAS0821
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0821));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new DemoClient.Controls.TableLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker1 = new BANANA.Windows.Controls.DateTimePicker();
            this.label11 = new BANANA.Windows.Controls.Label();
            this.dateTimePicker2 = new BANANA.Windows.Controls.DateTimePicker();
            this._txtSYSREGNAME_S = new BANANA.Windows.Controls.TextBox();
            this._txtSTR_CD_S = new BANANA.Windows.Controls.TextBox();
            this._txtSTR_NM_S = new BANANA.Windows.Controls.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new BANANA.Windows.Controls.ComboBox();
            this.label4 = new BANANA.Windows.Controls.Label();
            this.label1 = new BANANA.Windows.Controls.Label();
            this.label2 = new BANANA.Windows.Controls.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnExcel = new DemoClient.Controls.BananaButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._cmbDPST_GIJUN_CD_S = new BANANA.Windows.Controls.ComboBox();
            this.label35 = new BANANA.Windows.Controls.Label();
            this.label39 = new BANANA.Windows.Controls.Label();
            this.label36 = new BANANA.Windows.Controls.Label();
            this._dtpSYSMODDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
            this._dtpSYSMODDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
            this.MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSDELDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSDELNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridView1 = new DemoClient.Controls.GridView();
            this.STR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_STRT_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_USE_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_GIJUN_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_CAL_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_INTST_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_PER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUL_MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUL_CALC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUL_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPST_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1095, 80);
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
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this._cmbDPST_GIJUN_CD_S, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel8, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtSYSREGNAME_S, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this._txtSTR_NM_S, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel4, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel2, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label39, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1089, 60);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // flowLayoutPanel8
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.flowLayoutPanel8, 2);
            this.flowLayoutPanel8.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel8.Controls.Add(this.label11);
            this.flowLayoutPanel8.Controls.Add(this.dateTimePicker2);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(646, 29);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(352, 27);
            this.flowLayoutPanel8.TabIndex = 170;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.DelegateProperty = true;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 5);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(250, 21);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(100, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 21);
            this.dateTimePicker1.TabIndex = 1122;
            this.dateTimePicker1.ValidationGroup = null;
            this.dateTimePicker1.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 635);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.DelegateProperty = true;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 5);
            this.dateTimePicker2.MaximumSize = new System.Drawing.Size(250, 21);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(100, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 21);
            this.dateTimePicker2.TabIndex = 1123;
            this.dateTimePicker2.ValidationGroup = null;
            this.dateTimePicker2.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 638);
            // 
            // _txtSYSREGNAME_S
            // 
            this._txtSYSREGNAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtSYSREGNAME_S.AutoTab = false;
            this._txtSYSREGNAME_S.DelegateProperty = true;
            this._txtSYSREGNAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtSYSREGNAME_S.Location = new System.Drawing.Point(649, 4);
            this._txtSYSREGNAME_S.Name = "_txtSYSREGNAME_S";
            this._txtSYSREGNAME_S.Size = new System.Drawing.Size(124, 20);
            this._txtSYSREGNAME_S.TabIndex = 130;
            this._txtSYSREGNAME_S.ValidationGroup = null;
            this._txtSYSREGNAME_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtSYSREGNAME_S.WaterMarkText = "";
            // 
            // _txtSTR_CD_S
            // 
            this._txtSTR_CD_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtSTR_CD_S.AutoTab = false;
            this._txtSTR_CD_S.DelegateProperty = true;
            this._txtSTR_CD_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtSTR_CD_S.Location = new System.Drawing.Point(3, 3);
            this._txtSTR_CD_S.Name = "_txtSTR_CD_S";
            this._txtSTR_CD_S.Size = new System.Drawing.Size(124, 20);
            this._txtSTR_CD_S.TabIndex = 140;
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
            this._txtSTR_NM_S.Size = new System.Drawing.Size(124, 20);
            this._txtSTR_NM_S.TabIndex = 100;
            this._txtSTR_NM_S.ValidationGroup = null;
            this._txtSTR_NM_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtSTR_NM_S.WaterMarkText = "";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.comboBox1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(314, 29);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(240, 30);
            this.flowLayoutPanel4.TabIndex = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = null;
            this.comboBox1.DelegateProperty = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.MaximumSize = new System.Drawing.Size(500, 60);
            this.comboBox1.MinimumSize = new System.Drawing.Size(100, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.SelectedItem = null;
            this.comboBox1.SelectedValue = null;
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 131;
            this.comboBox1.ValidationGroup = null;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1118;
            this.label4.Text = "처리기간";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1118;
            this.label1.Text = "차감기준";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1121;
            this.label2.Text = "처리자";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this._btnSearch);
            this.flowLayoutPanel2.Controls.Add(this._btnExcel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(777, 1);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 27);
            this.flowLayoutPanel2.TabIndex = 200;
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
            this._btnExcel.Size = new System.Drawing.Size(75, 23);
            this._btnExcel.TabIndex = 20;
            this._btnExcel.Text = "      엑   셀";
            this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.UseVisualStyleBackColor = true;
            this._btnExcel.ValidationGroup = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this._txtSTR_CD_S);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(314, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 27);
            this.flowLayoutPanel1.TabIndex = 110;
            // 
            // _cmbDPST_GIJUN_CD_S
            // 
            this._cmbDPST_GIJUN_CD_S.DataSource = null;
            this._cmbDPST_GIJUN_CD_S.DelegateProperty = true;
            this._cmbDPST_GIJUN_CD_S.Location = new System.Drawing.Point(95, 32);
            this._cmbDPST_GIJUN_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbDPST_GIJUN_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbDPST_GIJUN_CD_S.Name = "_cmbDPST_GIJUN_CD_S";
            this._cmbDPST_GIJUN_CD_S.SelectedIndex = -1;
            this._cmbDPST_GIJUN_CD_S.SelectedItem = null;
            this._cmbDPST_GIJUN_CD_S.SelectedValue = null;
            this._cmbDPST_GIJUN_CD_S.Size = new System.Drawing.Size(124, 21);
            this._cmbDPST_GIJUN_CD_S.TabIndex = 131;
            this._cmbDPST_GIJUN_CD_S.ValidationGroup = null;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(35, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 12);
            this.label35.TabIndex = 1114;
            this.label35.Text = "가맹점명";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(257, 38);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 12);
            this.label39.TabIndex = 1118;
            this.label39.Text = "출금기준";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(245, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 12);
            this.label36.TabIndex = 1115;
            this.label36.Text = "가맹점코드";
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
            this._dtpSYSMODDATE_S_S.TabIndex = 26;
            this._dtpSYSMODDATE_S_S.ValidationGroup = null;
            this._dtpSYSMODDATE_S_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 635);
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
            this._dtpSYSMODDATE_E_S.TabIndex = 27;
            this._dtpSYSMODDATE_E_S.ValidationGroup = null;
            this._dtpSYSMODDATE_E_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 638);
            // 
            // MONEY
            // 
            this.MONEY.HeaderText = "출근/차감 금액";
            this.MONEY.Name = "MONEY";
            // 
            // SYSREGDATE
            // 
            this.SYSREGDATE.DataPropertyName = "SYSREGDATE";
            this.SYSREGDATE.HeaderText = "시스템등록일";
            this.SYSREGDATE.MinimumWidth = 140;
            this.SYSREGDATE.Name = "SYSREGDATE";
            this.SYSREGDATE.ReadOnly = true;
            this.SYSREGDATE.Width = 140;
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
            this.SYSMODDATE.MinimumWidth = 140;
            this.SYSMODDATE.Name = "SYSMODDATE";
            this.SYSMODDATE.ReadOnly = true;
            this.SYSMODDATE.Width = 140;
            // 
            // SYSMODNAME
            // 
            this.SYSMODNAME.DataPropertyName = "SYSMODNAME";
            this.SYSMODNAME.HeaderText = "시스템수정자";
            this.SYSMODNAME.Name = "SYSMODNAME";
            this.SYSMODNAME.ReadOnly = true;
            this.SYSMODNAME.Width = 98;
            // 
            // SYSDELDATE
            // 
            this.SYSDELDATE.DataPropertyName = "SYSDELDATE";
            this.SYSDELDATE.HeaderText = "시스템삭제일";
            this.SYSDELDATE.MinimumWidth = 140;
            this.SYSDELDATE.Name = "SYSDELDATE";
            this.SYSDELDATE.ReadOnly = true;
            this.SYSDELDATE.Width = 140;
            // 
            // SYSDELNAME
            // 
            this.SYSDELNAME.DataPropertyName = "SYSDELNAME";
            this.SYSDELNAME.HeaderText = "시스템삭제자";
            this.SYSDELNAME.Name = "SYSDELNAME";
            this.SYSDELNAME.ReadOnly = true;
            this.SYSDELNAME.Width = 98;
            // 
            // gridView1
            // 
            this.gridView1.AllowUserToAddRows = false;
            this.gridView1.AutoSelectRowWithRightButton = false;
            this.gridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.CUL_MONEY,
            this.CUL_CALC,
            this.CUL_VAL,
            this.DPST_AMT,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gridView1.DelegateProperty = true;
            this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView1.Location = new System.Drawing.Point(0, 80);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.RowTemplate.Height = 23;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.Size = new System.Drawing.Size(1095, 653);
            this.gridView1.TabIndex = 29;
            this.gridView1.ShowHeaderCheckBox = false;
            // 
            // STR_CD
            // 
            this.STR_CD.DataPropertyName = "STR_CD";
            this.STR_CD.HeaderText = "가맹점코드";
            this.STR_CD.Name = "STR_CD";
            this.STR_CD.ReadOnly = true;
            this.STR_CD.Width = 90;
            // 
            // STR_NM
            // 
            this.STR_NM.DataPropertyName = "STR_NM";
            this.STR_NM.HeaderText = "가맹점명";
            this.STR_NM.Name = "STR_NM";
            this.STR_NM.ReadOnly = true;
            this.STR_NM.Width = 78;
            // 
            // DPST_STRT_DT
            // 
            this.DPST_STRT_DT.DataPropertyName = "DPST_STRT_DT";
            this.DPST_STRT_DT.HeaderText = "적용시작일";
            this.DPST_STRT_DT.Name = "DPST_STRT_DT";
            this.DPST_STRT_DT.ReadOnly = true;
            this.DPST_STRT_DT.Width = 90;
            // 
            // DPST_USE_YN
            // 
            this.DPST_USE_YN.DataPropertyName = "DPST_USE_YN";
            this.DPST_USE_YN.HeaderText = "사용여부";
            this.DPST_USE_YN.Name = "DPST_USE_YN";
            this.DPST_USE_YN.ReadOnly = true;
            this.DPST_USE_YN.Width = 78;
            // 
            // DPST_GIJUN_NM
            // 
            this.DPST_GIJUN_NM.DataPropertyName = "DPST_GIJUN_NM";
            this.DPST_GIJUN_NM.HeaderText = "차감기준";
            this.DPST_GIJUN_NM.Name = "DPST_GIJUN_NM";
            this.DPST_GIJUN_NM.ReadOnly = true;
            this.DPST_GIJUN_NM.Width = 78;
            // 
            // DPST_CAL_NM
            // 
            this.DPST_CAL_NM.DataPropertyName = "DPST_CAL_NM";
            this.DPST_CAL_NM.HeaderText = "계산방법";
            this.DPST_CAL_NM.Name = "DPST_CAL_NM";
            this.DPST_CAL_NM.ReadOnly = true;
            this.DPST_CAL_NM.Width = 78;
            // 
            // DPST_INTST_YN
            // 
            this.DPST_INTST_YN.DataPropertyName = "DPST_INTST_YN";
            this.DPST_INTST_YN.HeaderText = "미차감이자";
            this.DPST_INTST_YN.Name = "DPST_INTST_YN";
            this.DPST_INTST_YN.ReadOnly = true;
            this.DPST_INTST_YN.Width = 90;
            // 
            // DPST_PER
            // 
            this.DPST_PER.DataPropertyName = "DPST_PER";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DPST_PER.DefaultCellStyle = dataGridViewCellStyle2;
            this.DPST_PER.HeaderText = "차감수치";
            this.DPST_PER.Name = "DPST_PER";
            this.DPST_PER.ReadOnly = true;
            this.DPST_PER.Width = 78;
            // 
            // CUL_MONEY
            // 
            this.CUL_MONEY.HeaderText = "출금기준";
            this.CUL_MONEY.Name = "CUL_MONEY";
            this.CUL_MONEY.ReadOnly = true;
            this.CUL_MONEY.Width = 78;
            // 
            // CUL_CALC
            // 
            this.CUL_CALC.HeaderText = "계산방법";
            this.CUL_CALC.Name = "CUL_CALC";
            this.CUL_CALC.ReadOnly = true;
            this.CUL_CALC.Width = 78;
            // 
            // CUL_VAL
            // 
            this.CUL_VAL.HeaderText = "출금수치";
            this.CUL_VAL.Name = "CUL_VAL";
            this.CUL_VAL.ReadOnly = true;
            this.CUL_VAL.Width = 78;
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
            this.DPST_AMT.Width = 102;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SYSREGDATE";
            this.dataGridViewTextBoxColumn1.HeaderText = "시스템등록일";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 102;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SYSREGNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "시스템등록자";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 102;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SYSMODDATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "시스템수정일";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SYSMODNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "시스템수정자";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // BAS0821
            // 
            this.ClientSize = new System.Drawing.Size(1095, 733);
            this.Controls.Add(this.gridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dtpSYSMODDATE_S_S);
            this.Controls.Add(this._dtpSYSMODDATE_E_S);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAS0821";
            this.Text = "가맹점.강제출금/자동차감이력조회:BAS0821";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private BANANA.Windows.Controls.Label label11;
        private BANANA.Windows.Controls.TextBox _txtSYSREGNAME_S;
        private BANANA.Windows.Controls.TextBox _txtSTR_CD_S;
        private BANANA.Windows.Controls.TextBox _txtSTR_NM_S;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private BANANA.Windows.Controls.Label label4;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DemoClient.Controls.BananaButton _btnSearch;
        private DemoClient.Controls.BananaButton _btnExcel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BANANA.Windows.Controls.Label label35;
        private BANANA.Windows.Controls.Label label39;
        private BANANA.Windows.Controls.Label label36;
        private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_S_S;
        private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_E_S;
        private BANANA.Windows.Controls.DateTimePicker dateTimePicker1;
        private BANANA.Windows.Controls.DateTimePicker dateTimePicker2;
        private BANANA.Windows.Controls.ComboBox comboBox1;
        private BANANA.Windows.Controls.ComboBox _cmbDPST_GIJUN_CD_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSDELDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSDELNAME;
        private DemoClient.Controls.GridView gridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_STRT_DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_USE_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_GIJUN_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_CAL_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_INTST_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_PER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUL_MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUL_CALC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUL_VAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPST_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
	}
}
