namespace DemoClient.View.BAS
{
	partial class BAS0780
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0780));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new DemoClient.Controls.TableLayoutPanel();
            this._txtSYSREGNAME_S = new BANANA.Windows.Controls.TextBox();
            this.label2 = new BANANA.Windows.Controls.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._dtpSYSMODDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
            this.label1 = new BANANA.Windows.Controls.Label();
            this._dtpSYSMODDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
            this._txtMEMO_S = new BANANA.Windows.Controls.TextBox();
            this._txtDOC_FILE_NAME_S = new BANANA.Windows.Controls.TextBox();
            this._txtAGT_CD_S = new BANANA.Windows.Controls.TextBox();
            this._txtAGT_NM_S = new BANANA.Windows.Controls.TextBox();
            this.label40 = new BANANA.Windows.Controls.Label();
            this.label35 = new BANANA.Windows.Controls.Label();
            this.label39 = new BANANA.Windows.Controls.Label();
            this.label36 = new BANANA.Windows.Controls.Label();
            this.label38 = new BANANA.Windows.Controls.Label();
            this.label37 = new BANANA.Windows.Controls.Label();
            this._cmbDOC_GUBUN_CD_S = new BANANA.Windows.Controls.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnExcel = new DemoClient.Controls.BananaButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DemoClient.Controls.GridView();
            this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HST_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DOC_GUBUN_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DOC_FILE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DOC_FILE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DOC_FILE_SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DOC_FILE_DOWNLOAD = new System.Windows.Forms.DataGridViewImageColumn();
            this.DOC_GUBUN_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOC_FILE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOC_FILE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOC_FILE_SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOC_FILE_DOWNLOAD = new System.Windows.Forms.DataGridViewImageColumn();
            this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSDELDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSDELNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._iglDocuments = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.groupBox1.Size = new System.Drawing.Size(1199, 76);
            this.groupBox1.TabIndex = 3;
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
            this.tableLayoutPanel6.Controls.Add(this.progressBar1, 8, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtSYSREGNAME_S, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtMEMO_S, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtDOC_FILE_NAME_S, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this._txtAGT_CD_S, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this._txtAGT_NM_S, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label40, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label39, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label38, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label37, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this._cmbDOC_GUBUN_CD_S, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel2, 8, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1193, 56);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // _txtSYSREGNAME_S
            // 
            this._txtSYSREGNAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtSYSREGNAME_S.DelegateProperty = true;
            this._txtSYSREGNAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtSYSREGNAME_S.Location = new System.Drawing.Point(761, 4);
            this._txtSYSREGNAME_S.Name = "_txtSYSREGNAME_S";
            this._txtSYSREGNAME_S.Size = new System.Drawing.Size(124, 20);
            this._txtSYSREGNAME_S.TabIndex = 125;
            this._txtSYSREGNAME_S.ValidationGroup = null;
            this._txtSYSREGNAME_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtSYSREGNAME_S.WaterMarkText = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1122;
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
            this.flowLayoutPanel1.TabIndex = 150;
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
            // _txtMEMO_S
            // 
            this._txtMEMO_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtMEMO_S.AutoTab = false;
            this._txtMEMO_S.DelegateProperty = true;
            this._txtMEMO_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtMEMO_S.Location = new System.Drawing.Point(317, 32);
            this._txtMEMO_S.Name = "_txtMEMO_S";
            this._txtMEMO_S.Size = new System.Drawing.Size(124, 20);
            this._txtMEMO_S.TabIndex = 140;
            this._txtMEMO_S.ValidationGroup = null;
            this._txtMEMO_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtMEMO_S.WaterMarkText = "";
            // 
            // _txtDOC_FILE_NAME_S
            // 
            this._txtDOC_FILE_NAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtDOC_FILE_NAME_S.AutoTab = false;
            this._txtDOC_FILE_NAME_S.DelegateProperty = true;
            this._txtDOC_FILE_NAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtDOC_FILE_NAME_S.Location = new System.Drawing.Point(95, 32);
            this._txtDOC_FILE_NAME_S.Name = "_txtDOC_FILE_NAME_S";
            this._txtDOC_FILE_NAME_S.Size = new System.Drawing.Size(124, 20);
            this._txtDOC_FILE_NAME_S.TabIndex = 130;
            this._txtDOC_FILE_NAME_S.ValidationGroup = null;
            this._txtDOC_FILE_NAME_S.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtDOC_FILE_NAME_S.WaterMarkText = "";
            // 
            // _txtAGT_CD_S
            // 
            this._txtAGT_CD_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtAGT_CD_S.AutoTab = false;
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
            this._txtAGT_NM_S.AutoTab = false;
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
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(479, 36);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 12);
            this.label40.TabIndex = 1119;
            this.label40.Text = "처리기간";
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
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(281, 36);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 12);
            this.label39.TabIndex = 1118;
            this.label39.Text = "메모";
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
            this.label38.Location = new System.Drawing.Point(47, 36);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 12);
            this.label38.TabIndex = 1117;
            this.label38.Text = "파일명";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(455, 8);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 12);
            this.label37.TabIndex = 1116;
            this.label37.Text = "구비서류항목";
            // 
            // _cmbDOC_GUBUN_CD_S
            // 
            this._cmbDOC_GUBUN_CD_S.DataSource = null;
            this._cmbDOC_GUBUN_CD_S.DelegateProperty = true;
            this._cmbDOC_GUBUN_CD_S.Location = new System.Drawing.Point(539, 4);
            this._cmbDOC_GUBUN_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbDOC_GUBUN_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbDOC_GUBUN_CD_S.Name = "_cmbDOC_GUBUN_CD_S";
            this._cmbDOC_GUBUN_CD_S.SelectedIndex = -1;
            this._cmbDOC_GUBUN_CD_S.SelectedItem = null;
            this._cmbDOC_GUBUN_CD_S.SelectedValue = null;
            this._cmbDOC_GUBUN_CD_S.Size = new System.Drawing.Size(124, 21);
            this._cmbDOC_GUBUN_CD_S.TabIndex = 120;
            this._cmbDOC_GUBUN_CD_S.ValidationGroup = null;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this._btnSearch);
            this.flowLayoutPanel2.Controls.Add(this._btnExcel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(889, 1);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 27);
            this.flowLayoutPanel2.TabIndex = 160;
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
            this._btnExcel.TabIndex = 161;
            this._btnExcel.Text = "      엑   셀";
            this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExcel.UseVisualStyleBackColor = true;
            this._btnExcel.ValidationGroup = null;
            this._btnExcel.Click += new System.EventHandler(this._btnExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1199, 629);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 결과";
            // 
            // gridView1
            // 
            this.gridView1.AllowUserToAddRows = false;
            this.gridView1.AutoSelectRowWithRightButton = false;
            this.gridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView1.ColumnHeadersHeight = 50;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDX,
            this.HST_TYPE,
            this.AGT_CD,
            this.AGT_NM,
            this._DOC_GUBUN_NM,
            this._DOC_FILE_NAME,
            this._DOC_FILE_TYPE,
            this._DOC_FILE_SIZE,
            this._MEMO,
            this._DOC_FILE_DOWNLOAD,
            this.DOC_GUBUN_NM,
            this.DOC_FILE_NAME,
            this.DOC_FILE_TYPE,
            this.DOC_FILE_SIZE,
            this.MEMO,
            this.DOC_FILE_DOWNLOAD,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME,
            this.SYSDELDATE,
            this.SYSDELNAME});
            this.gridView1.DelegateProperty = true;
            this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView1.Location = new System.Drawing.Point(3, 17);
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.Size = new System.Drawing.Size(1193, 609);
            this.gridView1.TabIndex = 1;
            this.gridView1.ShowHeaderCheckBox = false;
            this.gridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellContentClick);
            this.gridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridView1_DataBindingComplete);
            // 
            // IDX
            // 
            this.IDX.DataPropertyName = "IDX";
            this.IDX.Frozen = true;
            this.IDX.HeaderText = "일련번호";
            this.IDX.Name = "IDX";
            this.IDX.ReadOnly = true;
            this.IDX.Width = 76;
            // 
            // HST_TYPE
            // 
            this.HST_TYPE.DataPropertyName = "HST_TYPE";
            this.HST_TYPE.Frozen = true;
            this.HST_TYPE.HeaderText = "이력구분";
            this.HST_TYPE.Name = "HST_TYPE";
            this.HST_TYPE.ReadOnly = true;
            this.HST_TYPE.Width = 76;
            // 
            // AGT_CD
            // 
            this.AGT_CD.DataPropertyName = "AGT_CD";
            this.AGT_CD.Frozen = true;
            this.AGT_CD.HeaderText = "대리점코드";
            this.AGT_CD.Name = "AGT_CD";
            this.AGT_CD.ReadOnly = true;
            this.AGT_CD.Width = 87;
            // 
            // AGT_NM
            // 
            this.AGT_NM.DataPropertyName = "AGT_NM";
            this.AGT_NM.Frozen = true;
            this.AGT_NM.HeaderText = "대리점명";
            this.AGT_NM.Name = "AGT_NM";
            this.AGT_NM.ReadOnly = true;
            this.AGT_NM.Width = 76;
            // 
            // _DOC_GUBUN_NM
            // 
            this._DOC_GUBUN_NM.DataPropertyName = "_DOC_GUBUN_NM";
            this._DOC_GUBUN_NM.HeaderText = "구비서류항목";
            this._DOC_GUBUN_NM.Name = "_DOC_GUBUN_NM";
            this._DOC_GUBUN_NM.ReadOnly = true;
            this._DOC_GUBUN_NM.Width = 98;
            // 
            // _DOC_FILE_NAME
            // 
            this._DOC_FILE_NAME.DataPropertyName = "_DOC_FILE_NAME";
            this._DOC_FILE_NAME.HeaderText = "파일명";
            this._DOC_FILE_NAME.Name = "_DOC_FILE_NAME";
            this._DOC_FILE_NAME.ReadOnly = true;
            this._DOC_FILE_NAME.Width = 65;
            // 
            // _DOC_FILE_TYPE
            // 
            this._DOC_FILE_TYPE.DataPropertyName = "_DOC_FILE_TYPE";
            this._DOC_FILE_TYPE.HeaderText = "파일종류";
            this._DOC_FILE_TYPE.Name = "_DOC_FILE_TYPE";
            this._DOC_FILE_TYPE.ReadOnly = true;
            this._DOC_FILE_TYPE.Visible = false;
            this._DOC_FILE_TYPE.Width = 76;
            // 
            // _DOC_FILE_SIZE
            // 
            this._DOC_FILE_SIZE.DataPropertyName = "_DOC_FILE_SIZE";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this._DOC_FILE_SIZE.DefaultCellStyle = dataGridViewCellStyle5;
            this._DOC_FILE_SIZE.HeaderText = "파일크기";
            this._DOC_FILE_SIZE.Name = "_DOC_FILE_SIZE";
            this._DOC_FILE_SIZE.ReadOnly = true;
            this._DOC_FILE_SIZE.Width = 76;
            // 
            // _MEMO
            // 
            this._MEMO.DataPropertyName = "_MEMO";
            this._MEMO.HeaderText = "메모";
            this._MEMO.Name = "_MEMO";
            this._MEMO.ReadOnly = true;
            this._MEMO.Width = 54;
            // 
            // _DOC_FILE_DOWNLOAD
            // 
            this._DOC_FILE_DOWNLOAD.HeaderText = "다운로드";
            this._DOC_FILE_DOWNLOAD.Name = "_DOC_FILE_DOWNLOAD";
            this._DOC_FILE_DOWNLOAD.ReadOnly = true;
            this._DOC_FILE_DOWNLOAD.Width = 57;
            // 
            // DOC_GUBUN_NM
            // 
            this.DOC_GUBUN_NM.DataPropertyName = "DOC_GUBUN_NM";
            this.DOC_GUBUN_NM.HeaderText = "구비서류항목";
            this.DOC_GUBUN_NM.Name = "DOC_GUBUN_NM";
            this.DOC_GUBUN_NM.ReadOnly = true;
            this.DOC_GUBUN_NM.Width = 98;
            // 
            // DOC_FILE_NAME
            // 
            this.DOC_FILE_NAME.DataPropertyName = "DOC_FILE_NAME";
            this.DOC_FILE_NAME.HeaderText = "파일명";
            this.DOC_FILE_NAME.Name = "DOC_FILE_NAME";
            this.DOC_FILE_NAME.ReadOnly = true;
            this.DOC_FILE_NAME.Width = 65;
            // 
            // DOC_FILE_TYPE
            // 
            this.DOC_FILE_TYPE.DataPropertyName = "DOC_FILE_TYPE";
            this.DOC_FILE_TYPE.HeaderText = "파일종류";
            this.DOC_FILE_TYPE.Name = "DOC_FILE_TYPE";
            this.DOC_FILE_TYPE.ReadOnly = true;
            this.DOC_FILE_TYPE.Visible = false;
            this.DOC_FILE_TYPE.Width = 76;
            // 
            // DOC_FILE_SIZE
            // 
            this.DOC_FILE_SIZE.DataPropertyName = "DOC_FILE_SIZE";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.DOC_FILE_SIZE.DefaultCellStyle = dataGridViewCellStyle6;
            this.DOC_FILE_SIZE.HeaderText = "파일크기";
            this.DOC_FILE_SIZE.Name = "DOC_FILE_SIZE";
            this.DOC_FILE_SIZE.ReadOnly = true;
            this.DOC_FILE_SIZE.Width = 76;
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "메모";
            this.MEMO.Name = "MEMO";
            this.MEMO.ReadOnly = true;
            this.MEMO.Width = 54;
            // 
            // DOC_FILE_DOWNLOAD
            // 
            this.DOC_FILE_DOWNLOAD.HeaderText = "다운로드";
            this.DOC_FILE_DOWNLOAD.Name = "DOC_FILE_DOWNLOAD";
            this.DOC_FILE_DOWNLOAD.ReadOnly = true;
            this.DOC_FILE_DOWNLOAD.Width = 57;
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
            // SYSDELDATE
            // 
            this.SYSDELDATE.DataPropertyName = "SYSDELDATE";
            this.SYSDELDATE.HeaderText = "시스템삭제일";
            this.SYSDELDATE.Name = "SYSDELDATE";
            this.SYSDELDATE.ReadOnly = true;
            this.SYSDELDATE.Width = 98;
            // 
            // SYSDELNAME
            // 
            this.SYSDELNAME.DataPropertyName = "SYSDELNAME";
            this.SYSDELNAME.HeaderText = "시스템삭제자";
            this.SYSDELNAME.Name = "SYSDELNAME";
            this.SYSDELNAME.ReadOnly = true;
            this.SYSDELNAME.Width = 98;
            // 
            // _iglDocuments
            // 
            this._iglDocuments.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_iglDocuments.ImageStream")));
            this._iglDocuments.TransparentColor = System.Drawing.Color.Transparent;
            this._iglDocuments.Images.SetKeyName(0, "EXCEL_257.ico");
            this._iglDocuments.Images.SetKeyName(1, "POWERPNT_1300.ico");
            this._iglDocuments.Images.SetKeyName(2, "WINWORD_1.ico");
            this._iglDocuments.Images.SetKeyName(3, "Hwp_1228.ico");
            this._iglDocuments.Images.SetKeyName(4, "Acrobat_1.ico");
            this._iglDocuments.Images.SetKeyName(5, "JPG.ico");
            this._iglDocuments.Images.SetKeyName(6, "PNG.ico");
            this._iglDocuments.Images.SetKeyName(7, "GIF.ico");
            this._iglDocuments.Images.SetKeyName(8, "BMP.ico");
            this._iglDocuments.Images.SetKeyName(9, "blank.png");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(892, 32);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // BAS0780
            // 
            this.ClientSize = new System.Drawing.Size(1199, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAS0780";
            this.Text = "대리점.구비서류이력조회:BAS0780";
            this.Load += new System.EventHandler(this.BAS0780_Load);
            this.Shown += new System.EventHandler(this.BAS0780_Shown);
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
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_S_S;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_E_S;
		private BANANA.Windows.Controls.TextBox _txtMEMO_S;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private DemoClient.Controls.BananaButton _btnSearch;
		private DemoClient.Controls.BananaButton _btnExcel;
		private BANANA.Windows.Controls.TextBox _txtDOC_FILE_NAME_S;
		private BANANA.Windows.Controls.TextBox _txtAGT_CD_S;
		private BANANA.Windows.Controls.TextBox _txtAGT_NM_S;
		private BANANA.Windows.Controls.Label label40;
		private BANANA.Windows.Controls.Label label35;
		private BANANA.Windows.Controls.Label label39;
		private BANANA.Windows.Controls.Label label36;
		private BANANA.Windows.Controls.Label label38;
		private BANANA.Windows.Controls.Label label37;
		private BANANA.Windows.Controls.ComboBox _cmbDOC_GUBUN_CD_S;
        private System.Windows.Forms.GroupBox groupBox2;
		private DemoClient.Controls.GridView gridView1;
		private System.Windows.Forms.ImageList _iglDocuments;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
		private System.Windows.Forms.DataGridViewTextBoxColumn HST_TYPE;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGT_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn _DOC_GUBUN_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn _DOC_FILE_NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn _DOC_FILE_TYPE;
		private System.Windows.Forms.DataGridViewTextBoxColumn _DOC_FILE_SIZE;
		private System.Windows.Forms.DataGridViewTextBoxColumn _MEMO;
		private System.Windows.Forms.DataGridViewImageColumn _DOC_FILE_DOWNLOAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOC_GUBUN_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOC_FILE_NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOC_FILE_TYPE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOC_FILE_SIZE;
		private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
		private System.Windows.Forms.DataGridViewImageColumn DOC_FILE_DOWNLOAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSDELDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSDELNAME;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.TextBox _txtSYSREGNAME_S;
        private System.Windows.Forms.ProgressBar progressBar1;
	}
}
