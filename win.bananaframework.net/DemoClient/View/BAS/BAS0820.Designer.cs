namespace DemoClient.View.BAS
{
	partial class BAS0820
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0820));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new DemoClient.Controls.TableLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this._dtpSYSMODDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
            this.label11 = new BANANA.Windows.Controls.Label();
            this._dtpSYSMODDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
            this._txtSYSREGNAME_S = new BANANA.Windows.Controls.TextBox();
            this._txtSTR_CD_S = new BANANA.Windows.Controls.TextBox();
            this._txtSTR_NM_S = new BANANA.Windows.Controls.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new BANANA.Windows.Controls.Label();
            this.label2 = new BANANA.Windows.Controls.Label();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnExcel = new DemoClient.Controls.BananaButton();
            this.label35 = new BANANA.Windows.Controls.Label();
            this.label36 = new BANANA.Windows.Controls.Label();
            this.label1 = new BANANA.Windows.Controls.Label();
            this._cmbBI_BINF_CD_S = new BANANA.Windows.Controls.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DemoClient.Controls.GridView();
            this.AGT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRSNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_BSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAXNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BI_COMPANY_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BI_PRSNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BI_BINF_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BI_SAUP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI_PRSNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI_TELNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI_CELLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEE_ETC_GUBUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGE_PER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1115, 79);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtSTR_NM_S, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel6, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this._txtSTR_CD_S, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel8, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this._cmbBI_BINF_CD_S, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1109, 59);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this._dtpSYSMODDATE_S_S);
            this.flowLayoutPanel8.Controls.Add(this.label11);
            this.flowLayoutPanel8.Controls.Add(this._dtpSYSMODDATE_E_S);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(707, 1);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(352, 27);
            this.flowLayoutPanel8.TabIndex = 170;
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
            this._dtpSYSMODDATE_S_S.TabIndex = 25;
            this._dtpSYSMODDATE_S_S.ValidationGroup = null;
            this._dtpSYSMODDATE_S_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 635);
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
            this._dtpSYSMODDATE_E_S.TabIndex = 26;
            this._dtpSYSMODDATE_E_S.ValidationGroup = null;
            this._dtpSYSMODDATE_E_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 638);
            // 
            // _txtSYSREGNAME_S
            // 
            this._txtSYSREGNAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtSYSREGNAME_S.AutoTab = false;
            this._txtSYSREGNAME_S.DelegateProperty = true;
            this._txtSYSREGNAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtSYSREGNAME_S.Location = new System.Drawing.Point(3, 3);
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
            this._txtSTR_CD_S.Location = new System.Drawing.Point(367, 4);
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
            this._txtSTR_NM_S.Location = new System.Drawing.Point(114, 4);
            this._txtSTR_NM_S.Name = "_txtSTR_NM_S";
            this._txtSTR_NM_S.Size = new System.Drawing.Size(124, 20);
            this._txtSTR_NM_S.TabIndex = 100;
            this._txtSTR_NM_S.ValidationGroup = null;
            this._txtSTR_NM_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtSTR_NM_S.WaterMarkText = "";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this._txtSYSREGNAME_S);
            this.flowLayoutPanel6.Controls.Add(this._btnSearch);
            this.flowLayoutPanel6.Controls.Add(this._btnExcel);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(707, 29);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(401, 29);
            this.flowLayoutPanel6.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1118;
            this.label4.Text = "처리기간";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1121;
            this.label2.Text = "처리자";
            // 
            // _btnSearch
            // 
            this._btnSearch.DelegateProperty = true;
            this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
            this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.Location = new System.Drawing.Point(130, 0);
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
            this._btnExcel.Location = new System.Drawing.Point(205, 1);
            this._btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this._btnExcel.Name = "_btnExcel";
            this._btnExcel.Size = new System.Drawing.Size(75, 23);
            this._btnExcel.TabIndex = 20;
            this._btnExcel.Text = "      엑   셀";
            this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.UseVisualStyleBackColor = true;
            this._btnExcel.ValidationGroup = null;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(54, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 12);
            this.label35.TabIndex = 1114;
            this.label35.Text = "가맹점명";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(295, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 12);
            this.label36.TabIndex = 1115;
            this.label36.Text = "가맹점코드";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1122;
            this.label1.Text = "기타수수료구분";
            // 
            // _cmbBI_BINF_CD_S
            // 
            this._cmbBI_BINF_CD_S.DataSource = null;
            this._cmbBI_BINF_CD_S.DelegateProperty = true;
            this._cmbBI_BINF_CD_S.Location = new System.Drawing.Point(114, 32);
            this._cmbBI_BINF_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbBI_BINF_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbBI_BINF_CD_S.Name = "_cmbBI_BINF_CD_S";
            this._cmbBI_BINF_CD_S.SelectedIndex = -1;
            this._cmbBI_BINF_CD_S.SelectedItem = null;
            this._cmbBI_BINF_CD_S.SelectedValue = null;
            this._cmbBI_BINF_CD_S.Size = new System.Drawing.Size(124, 21);
            this._cmbBI_BINF_CD_S.TabIndex = 1123;
            this._cmbBI_BINF_CD_S.ValidationGroup = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1115, 654);
            this.groupBox2.TabIndex = 25;
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
            this.AGT_CD,
            this.AGT_NM,
            this.PRSNT_NM,
            this.ADDR_BSC,
            this.TELNO,
            this.FAXNO,
            this.BI_COMPANY_NM,
            this.BI_PRSNT_NM,
            this.BI_BINF_NM,
            this.BI_SAUP_NO,
            this.PI_PRSNT_NM,
            this.PI_TELNO,
            this.PI_CELLNO,
            this.FEE_ETC_GUBUN,
            this.CHARGE_PER,
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
            this.gridView1.Size = new System.Drawing.Size(1109, 634);
            this.gridView1.TabIndex = 0;
            this.gridView1.ShowHeaderCheckBox = false;
            // 
            // AGT_CD
            // 
            this.AGT_CD.DataPropertyName = "AGT_CD";
            this.AGT_CD.Frozen = true;
            this.AGT_CD.HeaderText = "가맹점코드";
            this.AGT_CD.Name = "AGT_CD";
            this.AGT_CD.ReadOnly = true;
            this.AGT_CD.Width = 87;
            // 
            // AGT_NM
            // 
            this.AGT_NM.DataPropertyName = "AGT_NM";
            this.AGT_NM.Frozen = true;
            this.AGT_NM.HeaderText = "가맹점명";
            this.AGT_NM.Name = "AGT_NM";
            this.AGT_NM.ReadOnly = true;
            this.AGT_NM.Width = 76;
            // 
            // PRSNT_NM
            // 
            this.PRSNT_NM.DataPropertyName = "PRSNT_NM";
            this.PRSNT_NM.Frozen = true;
            this.PRSNT_NM.HeaderText = "대표자명";
            this.PRSNT_NM.Name = "PRSNT_NM";
            this.PRSNT_NM.ReadOnly = true;
            this.PRSNT_NM.Width = 76;
            // 
            // ADDR_BSC
            // 
            this.ADDR_BSC.DataPropertyName = "ADDR_BSC";
            this.ADDR_BSC.HeaderText = "기본주소";
            this.ADDR_BSC.Name = "ADDR_BSC";
            this.ADDR_BSC.ReadOnly = true;
            this.ADDR_BSC.Width = 76;
            // 
            // TELNO
            // 
            this.TELNO.DataPropertyName = "TELNO";
            this.TELNO.HeaderText = "전화번호";
            this.TELNO.Name = "TELNO";
            this.TELNO.ReadOnly = true;
            this.TELNO.Width = 76;
            // 
            // FAXNO
            // 
            this.FAXNO.DataPropertyName = "FAXNO";
            this.FAXNO.HeaderText = "팩스번호";
            this.FAXNO.Name = "FAXNO";
            this.FAXNO.ReadOnly = true;
            this.FAXNO.Width = 76;
            // 
            // BI_COMPANY_NM
            // 
            this.BI_COMPANY_NM.DataPropertyName = "BI_COMPANY_NM";
            this.BI_COMPANY_NM.HeaderText = "법인명";
            this.BI_COMPANY_NM.Name = "BI_COMPANY_NM";
            this.BI_COMPANY_NM.ReadOnly = true;
            this.BI_COMPANY_NM.Width = 65;
            // 
            // BI_PRSNT_NM
            // 
            this.BI_PRSNT_NM.DataPropertyName = "BI_PRSNT_NM";
            this.BI_PRSNT_NM.HeaderText = "대표자명";
            this.BI_PRSNT_NM.Name = "BI_PRSNT_NM";
            this.BI_PRSNT_NM.ReadOnly = true;
            this.BI_PRSNT_NM.Width = 76;
            // 
            // BI_BINF_NM
            // 
            this.BI_BINF_NM.DataPropertyName = "BI_BINF_NM";
            this.BI_BINF_NM.HeaderText = "사업자구분";
            this.BI_BINF_NM.Name = "BI_BINF_NM";
            this.BI_BINF_NM.ReadOnly = true;
            this.BI_BINF_NM.Width = 87;
            // 
            // BI_SAUP_NO
            // 
            this.BI_SAUP_NO.DataPropertyName = "BI_SAUP_NO";
            this.BI_SAUP_NO.HeaderText = "사업자등록번호";
            this.BI_SAUP_NO.Name = "BI_SAUP_NO";
            this.BI_SAUP_NO.ReadOnly = true;
            this.BI_SAUP_NO.Width = 109;
            // 
            // PI_PRSNT_NM
            // 
            this.PI_PRSNT_NM.DataPropertyName = "PI_PRSNT_NM";
            this.PI_PRSNT_NM.HeaderText = "대표자명";
            this.PI_PRSNT_NM.Name = "PI_PRSNT_NM";
            this.PI_PRSNT_NM.ReadOnly = true;
            this.PI_PRSNT_NM.Width = 76;
            // 
            // PI_TELNO
            // 
            this.PI_TELNO.DataPropertyName = "PI_TELNO";
            this.PI_TELNO.HeaderText = "자택번호";
            this.PI_TELNO.Name = "PI_TELNO";
            this.PI_TELNO.ReadOnly = true;
            this.PI_TELNO.Width = 76;
            // 
            // PI_CELLNO
            // 
            this.PI_CELLNO.DataPropertyName = "PI_CELLNO";
            this.PI_CELLNO.HeaderText = "휴대폰번호";
            this.PI_CELLNO.Name = "PI_CELLNO";
            this.PI_CELLNO.ReadOnly = true;
            this.PI_CELLNO.Width = 87;
            // 
            // FEE_ETC_GUBUN
            // 
            this.FEE_ETC_GUBUN.HeaderText = "기타수수료구분";
            this.FEE_ETC_GUBUN.Name = "FEE_ETC_GUBUN";
            this.FEE_ETC_GUBUN.ReadOnly = true;
            this.FEE_ETC_GUBUN.Width = 109;
            // 
            // CHARGE_PER
            // 
            this.CHARGE_PER.HeaderText = "수수료";
            this.CHARGE_PER.Name = "CHARGE_PER";
            this.CHARGE_PER.ReadOnly = true;
            this.CHARGE_PER.Width = 65;
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
            // BAS0820
            // 
            this.ClientSize = new System.Drawing.Size(1115, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAS0820";
            this.Text = "가맹점.기타수수료이력조회:BAS0820";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_S_S;
        private BANANA.Windows.Controls.Label label11;
        private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_E_S;
        private BANANA.Windows.Controls.TextBox _txtSYSREGNAME_S;
        private BANANA.Windows.Controls.TextBox _txtSTR_CD_S;
        private BANANA.Windows.Controls.TextBox _txtSTR_NM_S;
        private BANANA.Windows.Controls.Label label4;
        private BANANA.Windows.Controls.Label label2;
        private DemoClient.Controls.BananaButton _btnSearch;
        private DemoClient.Controls.BananaButton _btnExcel;
        private BANANA.Windows.Controls.Label label35;
        private BANANA.Windows.Controls.Label label36;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.ComboBox _cmbBI_BINF_CD_S;
        private System.Windows.Forms.GroupBox groupBox2;
        private DemoClient.Controls.GridView gridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGT_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRSNT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_BSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAXNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI_COMPANY_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI_PRSNT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI_BINF_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI_SAUP_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PI_PRSNT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PI_TELNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PI_CELLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEE_ETC_GUBUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGE_PER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;

    }
}
