namespace DemoClient.View.WDR
{
    partial class WDR1310
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WDR1310));
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
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VAN_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TRADEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUCCESSRES_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUCCESSRES_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BUYING_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CREDIT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.METHOD_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANCELDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DUEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CARDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APPRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APPRAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AFFNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BUSINESSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IS_DUPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DUPL_RLS_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IS_UNIT_LIMITED = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IS_DAILY_LIMITED = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IS_TOT_LIMITED = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LMT_RLS_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDRREQ_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDRREQFAIL_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDRREQ_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDRAPPR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDRAPPR_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDREXEC_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WDREXEC_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AUTO_REQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AUTO_MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(1145, 76);
			this.groupBox1.TabIndex = 30;
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
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1139, 52);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// _txtCI_ACCT_NM_S
			// 
			this._txtCI_ACCT_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_ACCT_NM_S.DelegateProperty = true;
			this._txtCI_ACCT_NM_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_ACCT_NM_S.Location = new System.Drawing.Point(95, 32);
			this._txtCI_ACCT_NM_S.Name = "_txtCI_ACCT_NM_S";
			this._txtCI_ACCT_NM_S.Size = new System.Drawing.Size(124, 23);
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
			this._txtSYSREGNAME_S.Size = new System.Drawing.Size(124, 23);
			this._txtSYSREGNAME_S.TabIndex = 170;
			this._txtSYSREGNAME_S.ValidationGroup = null;
			this._txtSYSREGNAME_S.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSYSREGNAME_S.WaterMarkText = "";
			// 
			// label40
			// 
			this.label40.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(36, 35);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(52, 15);
			this.label40.TabIndex = 1119;
			this.label40.Text = "예금주";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(258, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
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
			this._dtpSYSMODDATE_S_S.Checked = false;
			this._dtpSYSMODDATE_S_S.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpSYSMODDATE_S_S.DelegateProperty = true;
			this._dtpSYSMODDATE_S_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpSYSMODDATE_S_S.Location = new System.Drawing.Point(3, 5);
			this._dtpSYSMODDATE_S_S.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpSYSMODDATE_S_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpSYSMODDATE_S_S.Name = "_dtpSYSMODDATE_S_S";
			this._dtpSYSMODDATE_S_S.Size = new System.Drawing.Size(150, 21);
			this._dtpSYSMODDATE_S_S.TabIndex = 31;
			this._dtpSYSMODDATE_S_S.ValidationGroup = null;
			this._dtpSYSMODDATE_S_S.Value = new System.DateTime(2014, 8, 8, 14, 1, 19, 635);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 15);
			this.label1.TabIndex = 27;
			this.label1.Text = "~";
			// 
			// _dtpSYSMODDATE_E_S
			// 
			this._dtpSYSMODDATE_E_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpSYSMODDATE_E_S.Checked = false;
			this._dtpSYSMODDATE_E_S.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpSYSMODDATE_E_S.DelegateProperty = true;
			this._dtpSYSMODDATE_E_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpSYSMODDATE_E_S.Location = new System.Drawing.Point(183, 7);
			this._dtpSYSMODDATE_E_S.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpSYSMODDATE_E_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpSYSMODDATE_E_S.Name = "_dtpSYSMODDATE_E_S";
			this._dtpSYSMODDATE_E_S.Size = new System.Drawing.Size(150, 21);
			this._dtpSYSMODDATE_E_S.TabIndex = 32;
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
			this._btnSearch.Reserved = "      검   색";
			this._btnSearch.Size = new System.Drawing.Size(75, 23);
			this._btnSearch.TabIndex = 160;
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
			this._btnExcel.TabIndex = 162;
			this._btnExcel.Text = "      엑   셀";
			this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnExcel.UseVisualStyleBackColor = true;
			this._btnExcel.ValidationGroup = null;
			// 
			// label37
			// 
			this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(465, 35);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(67, 15);
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
			this._txtAGT_CD_S.Size = new System.Drawing.Size(124, 23);
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
			this._txtAGT_NM_S.Size = new System.Drawing.Size(124, 23);
			this._txtAGT_NM_S.TabIndex = 100;
			this._txtAGT_NM_S.ValidationGroup = null;
			this._txtAGT_NM_S.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtAGT_NM_S.WaterMarkText = "";
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
			// label38
			// 
			this.label38.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(465, 7);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(67, 15);
			this.label38.TabIndex = 1117;
			this.label38.Text = "출금은행";
			// 
			// _cmbCI_BNK_CD_S
			// 
			this._cmbCI_BNK_CD_S.DataSource = null;
			this._cmbCI_BNK_CD_S.DelegateProperty = true;
			this._cmbCI_BNK_CD_S.DroppedDown = false;
			this._cmbCI_BNK_CD_S.Location = new System.Drawing.Point(539, 4);
			this._cmbCI_BNK_CD_S.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbCI_BNK_CD_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbCI_BNK_CD_S.Name = "_cmbCI_BNK_CD_S";
			this._cmbCI_BNK_CD_S.SelectedIndex = -1;
			this._cmbCI_BNK_CD_S.SelectedItem = null;
			this._cmbCI_BNK_CD_S.SelectedValue = null;
			this._cmbCI_BNK_CD_S.Size = new System.Drawing.Size(124, 23);
			this._cmbCI_BNK_CD_S.TabIndex = 140;
			this._cmbCI_BNK_CD_S.ValidationGroup = null;
			// 
			// label39
			// 
			this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(687, 7);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(67, 15);
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
			this._txtCI_ACCT_NO_S.Size = new System.Drawing.Size(124, 23);
			this._txtCI_ACCT_NO_S.TabIndex = 150;
			this._txtCI_ACCT_NO_S.ValidationGroup = null;
			this._txtCI_ACCT_NO_S.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_ACCT_NO_S.WaterMarkText = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridView1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 76);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1145, 594);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "검색 결과";
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
            this.IDX,
            this.TIDX,
            this.VAN_NM,
            this.STR_NM,
            this.TRADEDATE,
            this.SUCCESSRES_CD,
            this.SUCCESSRES_NM,
            this.BUYING_NM,
            this.CREDIT_NM,
            this.METHOD_NM,
            this.CANCELDATE,
            this.DUEDATE,
            this.CARDNO,
            this.APPRNO,
            this.APPRAMT,
            this.AFFNO,
            this.BUSINESSNO,
            this.IS_DUPL,
            this.DUPL_RLS_MEMO,
            this.IS_UNIT_LIMITED,
            this.IS_DAILY_LIMITED,
            this.IS_TOT_LIMITED,
            this.LMT_RLS_MEMO,
            this.WDRREQ_NM,
            this.WDRREQFAIL_NM,
            this.WDRREQ_MEMO,
            this.WDRAPPR_NM,
            this.WDRAPPR_MEMO,
            this.WDREXEC_NM,
            this.WDREXEC_MEMO,
            this.AUTO_REQ,
            this.AUTO_MEMO,
            this.STATUS});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 21);
			this.gridView1.MultiSelect = false;
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(1139, 570);
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
			// IDX
			// 
			this.IDX.DataPropertyName = "IDX";
			this.IDX.Frozen = true;
			this.IDX.HeaderText = "출금원장번호";
			this.IDX.Name = "IDX";
			this.IDX.ReadOnly = true;
			this.IDX.Width = 122;
			// 
			// TIDX
			// 
			this.TIDX.DataPropertyName = "TIDX";
			this.TIDX.Frozen = true;
			this.TIDX.HeaderText = "거래원장번호";
			this.TIDX.Name = "TIDX";
			this.TIDX.ReadOnly = true;
			this.TIDX.Width = 122;
			// 
			// VAN_NM
			// 
			this.VAN_NM.DataPropertyName = "VAN_NM";
			this.VAN_NM.Frozen = true;
			this.VAN_NM.HeaderText = "VAN명";
			this.VAN_NM.Name = "VAN_NM";
			this.VAN_NM.ReadOnly = true;
			this.VAN_NM.Width = 82;
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
			// TRADEDATE
			// 
			this.TRADEDATE.DataPropertyName = "TRADEDATE";
			this.TRADEDATE.HeaderText = "거래일자";
			this.TRADEDATE.Name = "TRADEDATE";
			this.TRADEDATE.ReadOnly = true;
			this.TRADEDATE.Width = 94;
			// 
			// SUCCESSRES_CD
			// 
			this.SUCCESSRES_CD.DataPropertyName = "SUCCESSRES_CD";
			this.SUCCESSRES_CD.HeaderText = "승인결과코드";
			this.SUCCESSRES_CD.Name = "SUCCESSRES_CD";
			this.SUCCESSRES_CD.ReadOnly = true;
			this.SUCCESSRES_CD.Visible = false;
			this.SUCCESSRES_CD.Width = 122;
			// 
			// SUCCESSRES_NM
			// 
			this.SUCCESSRES_NM.DataPropertyName = "SUCCESSRES_NM";
			this.SUCCESSRES_NM.HeaderText = "승인결과";
			this.SUCCESSRES_NM.Name = "SUCCESSRES_NM";
			this.SUCCESSRES_NM.ReadOnly = true;
			this.SUCCESSRES_NM.Width = 94;
			// 
			// BUYING_NM
			// 
			this.BUYING_NM.DataPropertyName = "BUYING_NM";
			this.BUYING_NM.HeaderText = "매입카드사";
			this.BUYING_NM.Name = "BUYING_NM";
			this.BUYING_NM.ReadOnly = true;
			this.BUYING_NM.Width = 108;
			// 
			// CREDIT_NM
			// 
			this.CREDIT_NM.DataPropertyName = "CREDIT_NM";
			this.CREDIT_NM.HeaderText = "카드종류";
			this.CREDIT_NM.Name = "CREDIT_NM";
			this.CREDIT_NM.ReadOnly = true;
			this.CREDIT_NM.Width = 94;
			// 
			// METHOD_NM
			// 
			this.METHOD_NM.DataPropertyName = "METHOD_NM";
			this.METHOD_NM.HeaderText = "승인방법";
			this.METHOD_NM.Name = "METHOD_NM";
			this.METHOD_NM.ReadOnly = true;
			this.METHOD_NM.Width = 94;
			// 
			// CANCELDATE
			// 
			this.CANCELDATE.DataPropertyName = "CANCELDATE";
			this.CANCELDATE.HeaderText = "승인취소일/원거래일";
			this.CANCELDATE.Name = "CANCELDATE";
			this.CANCELDATE.ReadOnly = true;
			this.CANCELDATE.Width = 170;
			// 
			// DUEDATE
			// 
			this.DUEDATE.DataPropertyName = "DUEDATE";
			this.DUEDATE.HeaderText = "입금예정일/입금일";
			this.DUEDATE.Name = "DUEDATE";
			this.DUEDATE.ReadOnly = true;
			this.DUEDATE.Width = 156;
			// 
			// CARDNO
			// 
			this.CARDNO.DataPropertyName = "CARDNO";
			this.CARDNO.HeaderText = "카드번호";
			this.CARDNO.Name = "CARDNO";
			this.CARDNO.ReadOnly = true;
			this.CARDNO.Width = 94;
			// 
			// APPRNO
			// 
			this.APPRNO.DataPropertyName = "APPRNO";
			this.APPRNO.HeaderText = "승인번호";
			this.APPRNO.Name = "APPRNO";
			this.APPRNO.ReadOnly = true;
			this.APPRNO.Width = 94;
			// 
			// APPRAMT
			// 
			this.APPRAMT.DataPropertyName = "APPRAMT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "0";
			this.APPRAMT.DefaultCellStyle = dataGridViewCellStyle2;
			this.APPRAMT.HeaderText = "승인금액";
			this.APPRAMT.Name = "APPRAMT";
			this.APPRAMT.ReadOnly = true;
			this.APPRAMT.Width = 94;
			// 
			// AFFNO
			// 
			this.AFFNO.DataPropertyName = "AFFNO";
			this.AFFNO.HeaderText = "가맹점번호";
			this.AFFNO.Name = "AFFNO";
			this.AFFNO.ReadOnly = true;
			this.AFFNO.Width = 108;
			// 
			// BUSINESSNO
			// 
			this.BUSINESSNO.DataPropertyName = "BUSINESSNO";
			this.BUSINESSNO.HeaderText = "사업자등록번호";
			this.BUSINESSNO.Name = "BUSINESSNO";
			this.BUSINESSNO.ReadOnly = true;
			this.BUSINESSNO.Width = 136;
			// 
			// IS_DUPL
			// 
			this.IS_DUPL.DataPropertyName = "IS_DUPL";
			this.IS_DUPL.HeaderText = "중복";
			this.IS_DUPL.Name = "IS_DUPL";
			this.IS_DUPL.ReadOnly = true;
			this.IS_DUPL.Width = 66;
			// 
			// DUPL_RLS_MEMO
			// 
			this.DUPL_RLS_MEMO.DataPropertyName = "DUPL_RLS_MEMO";
			this.DUPL_RLS_MEMO.HeaderText = "해제사유";
			this.DUPL_RLS_MEMO.Name = "DUPL_RLS_MEMO";
			this.DUPL_RLS_MEMO.ReadOnly = true;
			this.DUPL_RLS_MEMO.Width = 94;
			// 
			// IS_UNIT_LIMITED
			// 
			this.IS_UNIT_LIMITED.DataPropertyName = "IS_UNIT_LIMITED";
			this.IS_UNIT_LIMITED.HeaderText = "건별";
			this.IS_UNIT_LIMITED.Name = "IS_UNIT_LIMITED";
			this.IS_UNIT_LIMITED.ReadOnly = true;
			this.IS_UNIT_LIMITED.Width = 66;
			// 
			// IS_DAILY_LIMITED
			// 
			this.IS_DAILY_LIMITED.DataPropertyName = "IS_DAILY_LIMITED";
			this.IS_DAILY_LIMITED.HeaderText = "1일";
			this.IS_DAILY_LIMITED.Name = "IS_DAILY_LIMITED";
			this.IS_DAILY_LIMITED.ReadOnly = true;
			this.IS_DAILY_LIMITED.Width = 60;
			// 
			// IS_TOT_LIMITED
			// 
			this.IS_TOT_LIMITED.DataPropertyName = "IS_TOT_LIMITED";
			this.IS_TOT_LIMITED.HeaderText = "총한도";
			this.IS_TOT_LIMITED.Name = "IS_TOT_LIMITED";
			this.IS_TOT_LIMITED.ReadOnly = true;
			this.IS_TOT_LIMITED.Width = 80;
			// 
			// LMT_RLS_MEMO
			// 
			this.LMT_RLS_MEMO.DataPropertyName = "LMT_RLS_MEMO";
			this.LMT_RLS_MEMO.HeaderText = "해제사유";
			this.LMT_RLS_MEMO.Name = "LMT_RLS_MEMO";
			this.LMT_RLS_MEMO.ReadOnly = true;
			this.LMT_RLS_MEMO.Width = 94;
			// 
			// WDRREQ_NM
			// 
			this.WDRREQ_NM.DataPropertyName = "WDRREQ_NM";
			this.WDRREQ_NM.HeaderText = "상태";
			this.WDRREQ_NM.Name = "WDRREQ_NM";
			this.WDRREQ_NM.ReadOnly = true;
			this.WDRREQ_NM.Width = 66;
			// 
			// WDRREQFAIL_NM
			// 
			this.WDRREQFAIL_NM.DataPropertyName = "WDRREQFAIL_NM";
			this.WDRREQFAIL_NM.HeaderText = "실패사유";
			this.WDRREQFAIL_NM.Name = "WDRREQFAIL_NM";
			this.WDRREQFAIL_NM.ReadOnly = true;
			this.WDRREQFAIL_NM.Width = 94;
			// 
			// WDRREQ_MEMO
			// 
			this.WDRREQ_MEMO.DataPropertyName = "WDRREQ_MEMO";
			this.WDRREQ_MEMO.HeaderText = "메모";
			this.WDRREQ_MEMO.Name = "WDRREQ_MEMO";
			this.WDRREQ_MEMO.ReadOnly = true;
			this.WDRREQ_MEMO.Width = 66;
			// 
			// WDRAPPR_NM
			// 
			this.WDRAPPR_NM.DataPropertyName = "WDRAPPR_NM";
			this.WDRAPPR_NM.HeaderText = "상태";
			this.WDRAPPR_NM.Name = "WDRAPPR_NM";
			this.WDRAPPR_NM.ReadOnly = true;
			this.WDRAPPR_NM.Width = 66;
			// 
			// WDRAPPR_MEMO
			// 
			this.WDRAPPR_MEMO.DataPropertyName = "WDRAPPR_MEMO";
			this.WDRAPPR_MEMO.HeaderText = "메모";
			this.WDRAPPR_MEMO.Name = "WDRAPPR_MEMO";
			this.WDRAPPR_MEMO.ReadOnly = true;
			this.WDRAPPR_MEMO.Width = 66;
			// 
			// WDREXEC_NM
			// 
			this.WDREXEC_NM.DataPropertyName = "WDREXEC_NM";
			this.WDREXEC_NM.HeaderText = "상태";
			this.WDREXEC_NM.Name = "WDREXEC_NM";
			this.WDREXEC_NM.ReadOnly = true;
			this.WDREXEC_NM.Width = 66;
			// 
			// WDREXEC_MEMO
			// 
			this.WDREXEC_MEMO.DataPropertyName = "WDREXEC_MEMO";
			this.WDREXEC_MEMO.HeaderText = "메모";
			this.WDREXEC_MEMO.Name = "WDREXEC_MEMO";
			this.WDREXEC_MEMO.ReadOnly = true;
			this.WDREXEC_MEMO.Width = 66;
			// 
			// AUTO_REQ
			// 
			this.AUTO_REQ.DataPropertyName = "AUTO_REQ";
			this.AUTO_REQ.HeaderText = "자동";
			this.AUTO_REQ.Name = "AUTO_REQ";
			this.AUTO_REQ.ReadOnly = true;
			this.AUTO_REQ.Width = 66;
			// 
			// AUTO_MEMO
			// 
			this.AUTO_MEMO.DataPropertyName = "AUTO_MEMO";
			this.AUTO_MEMO.HeaderText = "요청사유";
			this.AUTO_MEMO.Name = "AUTO_MEMO";
			this.AUTO_MEMO.ReadOnly = true;
			this.AUTO_MEMO.Width = 94;
			// 
			// STATUS
			// 
			this.STATUS.DataPropertyName = "STATUS";
			this.STATUS.HeaderText = "처리결과";
			this.STATUS.Name = "STATUS";
			this.STATUS.ReadOnly = true;
			this.STATUS.Width = 94;
			// 
			// WDR1310
			// 
			this.ClientSize = new System.Drawing.Size(1145, 670);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WDR1310";
			this.Text = "출금실패이력조회:WDR1310";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel6;
        private BANANA.Windows.Controls.TextBox _txtCI_ACCT_NM_S;
        private BANANA.Windows.Controls.TextBox _txtSYSREGNAME_S;
        private BANANA.Windows.Controls.Label label40;
        private BANANA.Windows.Controls.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_S_S;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.DateTimePicker _dtpSYSMODDATE_E_S;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DemoClient.Controls.BananaButton _btnSearch;
        private DemoClient.Controls.BananaButton _btnExcel;
        private BANANA.Windows.Controls.Label label37;
        private BANANA.Windows.Controls.TextBox _txtAGT_CD_S;
        private BANANA.Windows.Controls.TextBox _txtAGT_NM_S;
        private BANANA.Windows.Controls.Label label35;
        private BANANA.Windows.Controls.Label label36;
        private BANANA.Windows.Controls.Label label38;
        private BANANA.Windows.Controls.ComboBox _cmbCI_BNK_CD_S;
        private BANANA.Windows.Controls.Label label39;
        private BANANA.Windows.Controls.TextBox _txtCI_ACCT_NO_S;
        private BANANA.Windows.Controls.GroupBox groupBox3;
        private DemoClient.Controls.GridView gridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAN_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRADEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCCESSRES_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCCESSRES_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUYING_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn METHOD_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANCELDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPRAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFFNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUSINESSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_DUPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUPL_RLS_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_UNIT_LIMITED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_DAILY_LIMITED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_TOT_LIMITED;
        private System.Windows.Forms.DataGridViewTextBoxColumn LMT_RLS_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDRREQ_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDRREQFAIL_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDRREQ_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDRAPPR_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDRAPPR_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDREXEC_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn WDREXEC_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTO_REQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTO_MEMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;



    }
}
