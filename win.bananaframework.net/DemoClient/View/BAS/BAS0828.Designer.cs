namespace DemoClient.View.BAS
{
	partial class BAS0828
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0828));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._dtpMNS_APP_DT = new BANANA.Windows.Controls.DateTimePicker();
			this.label15 = new BANANA.Windows.Controls.Label();
			this.label4 = new BANANA.Windows.Controls.Label();
			this.label1 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._rbMNS_USE_Y = new BANANA.Windows.Controls.RadioButton();
			this._rbMNS_USE_N = new BANANA.Windows.Controls.RadioButton();
			this.label6 = new BANANA.Windows.Controls.Label();
			this._txtMEMO = new BANANA.Windows.Controls.TextBox();
			this.label3 = new BANANA.Windows.Controls.Label();
			this._cmbMNS_GUBUN_CD = new BANANA.Windows.Controls.ComboBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.STR_NM = new BANANA.Windows.Controls.TextBox();
			this.STR_CD = new BANANA.Windows.Controls.TextBox();
			this._btnSTR_Search = new DemoClient.Controls.BananaButton();
			this._gb1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._txtMNS_REG_MEMO = new BANANA.Windows.Controls.TextBox();
			this._cmbMNS_REG_CD = new BANANA.Windows.Controls.ComboBox();
			this._txtMNS_AMT_1 = new BANANA.Windows.Controls.TextBox();
			this.label5 = new BANANA.Windows.Controls.Label();
			this.label7 = new BANANA.Windows.Controls.Label();
			this.label8 = new BANANA.Windows.Controls.Label();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._gb2 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this._cmbMNS_ACCOUNT_CD = new BANANA.Windows.Controls.ComboBox();
			this.label16 = new BANANA.Windows.Controls.Label();
			this._txtMNS_AMT_2 = new BANANA.Windows.Controls.TextBox();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this._rbMNS_INTST_Y = new BANANA.Windows.Controls.RadioButton();
			this._rbMNS_INTST_N = new BANANA.Windows.Controls.RadioButton();
			this._btnComplete = new DemoClient.Controls.BananaButton();
			this._cmbMNS_REG_CD2 = new BANANA.Windows.Controls.ComboBox();
			this.label14 = new BANANA.Windows.Controls.Label();
			this.label11 = new BANANA.Windows.Controls.Label();
			this.label12 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtMNS_PER = new BANANA.Windows.Controls.TextBox();
			this._lblDPST_CAL_CD = new BANANA.Windows.Controls.Label();
			this._cmbMNS_CAL_CD = new BANANA.Windows.Controls.ComboBox();
			this.label10 = new BANANA.Windows.Controls.Label();
			this._cmbMNS_GIJUN_CD = new BANANA.Windows.Controls.ComboBox();
			this.label9 = new BANANA.Windows.Controls.Label();
			this.label13 = new BANANA.Windows.Controls.Label();
			this._txtMNS_REG_MEMO2 = new BANANA.Windows.Controls.TextBox();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this._gb1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this._gb2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(699, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "기본정보";
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
			this.tableLayoutPanel1.Controls.Add(this._dtpMNS_APP_DT, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label15, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this._cmbMNS_GUBUN_CD, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 152);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _dtpMNS_APP_DT
			// 
			this._dtpMNS_APP_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpMNS_APP_DT.Checked = false;
			this._dtpMNS_APP_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpMNS_APP_DT.DelegateProperty = true;
			this._dtpMNS_APP_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpMNS_APP_DT.Location = new System.Drawing.Point(323, 33);
			this._dtpMNS_APP_DT.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpMNS_APP_DT.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpMNS_APP_DT.Name = "_dtpMNS_APP_DT";
			this._dtpMNS_APP_DT.Size = new System.Drawing.Size(130, 21);
			this._dtpMNS_APP_DT.TabIndex = 1002;
			this._dtpMNS_APP_DT.ValidationGroup = "a";
			this._dtpMNS_APP_DT.Value = new System.DateTime(2016, 8, 17, 0, 0, 0, 0);
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(250, 36);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 15);
			this.label15.TabIndex = 1119;
			this.label15.Text = "적용일자";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 1122;
			this.label4.Text = "사용여부";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 1116;
			this.label1.Text = "가맹점정보";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._rbMNS_USE_Y);
			this.flowLayoutPanel1.Controls.Add(this._rbMNS_USE_N);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 30);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 27);
			this.flowLayoutPanel1.TabIndex = 130;
			// 
			// _rbMNS_USE_Y
			// 
			this._rbMNS_USE_Y.AutoSize = true;
			this._rbMNS_USE_Y.Checked = true;
			this._rbMNS_USE_Y.Location = new System.Drawing.Point(3, 5);
			this._rbMNS_USE_Y.Name = "_rbMNS_USE_Y";
			this._rbMNS_USE_Y.Size = new System.Drawing.Size(36, 19);
			this._rbMNS_USE_Y.TabIndex = 10;
			this._rbMNS_USE_Y.TabStop = true;
			this._rbMNS_USE_Y.Text = "Y";
			this._rbMNS_USE_Y.UseVisualStyleBackColor = true;
			// 
			// _rbMNS_USE_N
			// 
			this._rbMNS_USE_N.AutoSize = true;
			this._rbMNS_USE_N.Location = new System.Drawing.Point(45, 5);
			this._rbMNS_USE_N.Name = "_rbMNS_USE_N";
			this._rbMNS_USE_N.Size = new System.Drawing.Size(37, 19);
			this._rbMNS_USE_N.TabIndex = 20;
			this._rbMNS_USE_N.Text = "N";
			this._rbMNS_USE_N.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(50, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 1124;
			this.label6.Text = "메모";
			// 
			// _txtMEMO
			// 
			this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this._txtMEMO, 5);
			this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMEMO.Location = new System.Drawing.Point(93, 60);
			this._txtMEMO.Multiline = true;
			this._txtMEMO.Name = "_txtMEMO";
			this._txtMEMO.Size = new System.Drawing.Size(590, 94);
			this._txtMEMO.TabIndex = 140;
			this._txtMEMO.ValidationGroup = null;
			this._txtMEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMEMO.WaterMarkText = "";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(474, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 27);
			this.label3.TabIndex = 1120;
			this.label3.Text = "출금/차감구분";
			// 
			// _cmbMNS_GUBUN_CD
			// 
			this._cmbMNS_GUBUN_CD.DataSource = null;
			this._cmbMNS_GUBUN_CD.DelegateProperty = true;
			this._cmbMNS_GUBUN_CD.Location = new System.Drawing.Point(553, 33);
			this._cmbMNS_GUBUN_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_GUBUN_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_GUBUN_CD.Name = "_cmbMNS_GUBUN_CD";
			this._cmbMNS_GUBUN_CD.SelectedIndex = -1;
			this._cmbMNS_GUBUN_CD.SelectedItem = null;
			this._cmbMNS_GUBUN_CD.SelectedValue = null;
			this._cmbMNS_GUBUN_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_GUBUN_CD.TabIndex = 120;
			this._cmbMNS_GUBUN_CD.ValidationGroup = null;
			this._cmbMNS_GUBUN_CD.DropDownClosed += new System.EventHandler(this._cmbMNS_GUBUN_CD_DropDownClosed);
			// 
			// flowLayoutPanel2
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 5);
			this.flowLayoutPanel2.Controls.Add(this.STR_NM);
			this.flowLayoutPanel2.Controls.Add(this.STR_CD);
			this.flowLayoutPanel2.Controls.Add(this._btnSTR_Search);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(90, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel2.Size = new System.Drawing.Size(603, 30);
			this.flowLayoutPanel2.TabIndex = 252;
			// 
			// STR_NM
			// 
			this.STR_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.STR_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.STR_NM.Location = new System.Drawing.Point(3, 4);
			this.STR_NM.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.STR_NM.Name = "STR_NM";
			this.STR_NM.ReadOnly = true;
			this.STR_NM.Size = new System.Drawing.Size(224, 23);
			this.STR_NM.TabIndex = 110;
			this.STR_NM.ValidationGroup = null;
			this.STR_NM.WaterMarkColor = System.Drawing.Color.Empty;
			this.STR_NM.WaterMarkText = "";
			// 
			// STR_CD
			// 
			this.STR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.STR_CD.Compulsory = true;
			this.STR_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.STR_CD.Location = new System.Drawing.Point(227, 4);
			this.STR_CD.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Size = new System.Drawing.Size(130, 23);
			this.STR_CD.TabIndex = 100;
			this.STR_CD.ValidationGroup = "A";
			this.STR_CD.WaterMarkColor = System.Drawing.Color.Empty;
			this.STR_CD.WaterMarkText = "";
			// 
			// _btnSTR_Search
			// 
			this._btnSTR_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSTR_Search.DelegateProperty = true;
			this._btnSTR_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSTR_Search.Location = new System.Drawing.Point(363, 2);
			this._btnSTR_Search.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this._btnSTR_Search.Name = "_btnSTR_Search";
			this._btnSTR_Search.Size = new System.Drawing.Size(96, 27);
			this._btnSTR_Search.TabIndex = 252;
			this._btnSTR_Search.Text = "가맹점검색";
			this._btnSTR_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSTR_Search.UseVisualStyleBackColor = true;
			this._btnSTR_Search.ValidationGroup = null;
			this._btnSTR_Search.Click += new System.EventHandler(this._btnSTR_Search_Click);
			// 
			// _gb1
			// 
			this._gb1.Controls.Add(this.tableLayoutPanel2);
			this._gb1.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb1.Location = new System.Drawing.Point(0, 176);
			this._gb1.Name = "_gb1";
			this._gb1.Size = new System.Drawing.Size(699, 58);
			this._gb1.TabIndex = 1;
			this._gb1.TabStop = false;
			this._gb1.Text = "강제출금정보";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel2.Controls.Add(this._txtMNS_REG_MEMO, 5, 0);
			this.tableLayoutPanel2.Controls.Add(this._cmbMNS_REG_CD, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this._txtMNS_AMT_1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label8, 4, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(693, 34);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// _txtMNS_REG_MEMO
			// 
			this._txtMNS_REG_MEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMNS_REG_MEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMNS_REG_MEMO.Location = new System.Drawing.Point(553, 5);
			this._txtMNS_REG_MEMO.Name = "_txtMNS_REG_MEMO";
			this._txtMNS_REG_MEMO.Size = new System.Drawing.Size(130, 23);
			this._txtMNS_REG_MEMO.TabIndex = 170;
			this._txtMNS_REG_MEMO.ValidationGroup = "A";
			this._txtMNS_REG_MEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMNS_REG_MEMO.WaterMarkText = "";
			// 
			// _cmbMNS_REG_CD
			// 
			this._cmbMNS_REG_CD.DataSource = null;
			this._cmbMNS_REG_CD.DelegateProperty = true;
			this._cmbMNS_REG_CD.Location = new System.Drawing.Point(323, 3);
			this._cmbMNS_REG_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_REG_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_REG_CD.Name = "_cmbMNS_REG_CD";
			this._cmbMNS_REG_CD.SelectedIndex = -1;
			this._cmbMNS_REG_CD.SelectedItem = null;
			this._cmbMNS_REG_CD.SelectedValue = null;
			this._cmbMNS_REG_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_REG_CD.TabIndex = 160;
			this._cmbMNS_REG_CD.ValidationGroup = null;
			// 
			// _txtMNS_AMT_1
			// 
			this._txtMNS_AMT_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMNS_AMT_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMNS_AMT_1.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtMNS_AMT_1.Location = new System.Drawing.Point(93, 5);
			this._txtMNS_AMT_1.Name = "_txtMNS_AMT_1";
			this._txtMNS_AMT_1.Size = new System.Drawing.Size(130, 23);
			this._txtMNS_AMT_1.TabIndex = 150;
			this._txtMNS_AMT_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtMNS_AMT_1.ValidationGroup = "A";
			this._txtMNS_AMT_1.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMNS_AMT_1.WaterMarkText = "";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 1119;
			this.label5.Text = "출금금액";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(250, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 15);
			this.label7.TabIndex = 1120;
			this.label7.Text = "출금사유";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(480, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 15);
			this.label8.TabIndex = 1121;
			this.label8.Text = "상세사유";
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(531, 350);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 240;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "A";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _btnClose
			// 
			this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(612, 350);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 250;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// _gb2
			// 
			this._gb2.Controls.Add(this.tableLayoutPanel3);
			this._gb2.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb2.Location = new System.Drawing.Point(0, 234);
			this._gb2.Name = "_gb2";
			this._gb2.Size = new System.Drawing.Size(699, 110);
			this._gb2.TabIndex = 2;
			this._gb2.TabStop = false;
			this._gb2.Text = "자동차감정보";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 6;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.Controls.Add(this._cmbMNS_ACCOUNT_CD, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label16, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this._txtMNS_AMT_2, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this._btnComplete, 5, 2);
			this.tableLayoutPanel3.Controls.Add(this._cmbMNS_REG_CD2, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label11, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.label12, 4, 1);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 5, 1);
			this.tableLayoutPanel3.Controls.Add(this._cmbMNS_CAL_CD, 5, 0);
			this.tableLayoutPanel3.Controls.Add(this.label10, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this._cmbMNS_GIJUN_CD, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label13, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this._txtMNS_REG_MEMO2, 3, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(693, 86);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// _cmbMNS_ACCOUNT_CD
			// 
			this._cmbMNS_ACCOUNT_CD.DataSource = null;
			this._cmbMNS_ACCOUNT_CD.DelegateProperty = true;
			this._cmbMNS_ACCOUNT_CD.Location = new System.Drawing.Point(93, 57);
			this._cmbMNS_ACCOUNT_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_ACCOUNT_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_ACCOUNT_CD.Name = "_cmbMNS_ACCOUNT_CD";
			this._cmbMNS_ACCOUNT_CD.SelectedIndex = -1;
			this._cmbMNS_ACCOUNT_CD.SelectedItem = null;
			this._cmbMNS_ACCOUNT_CD.SelectedValue = null;
			this._cmbMNS_ACCOUNT_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_ACCOUNT_CD.TabIndex = 251;
			this._cmbMNS_ACCOUNT_CD.ValidationGroup = null;
			this._cmbMNS_ACCOUNT_CD.DropDownClosed += new System.EventHandler(this._cmbMNS_ACCOUNT_CD_DropDownClosed);
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(20, 62);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 15);
			this.label16.TabIndex = 1125;
			this.label16.Text = "회계구분";
			// 
			// _txtMNS_AMT_2
			// 
			this._txtMNS_AMT_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMNS_AMT_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMNS_AMT_2.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtMNS_AMT_2.Location = new System.Drawing.Point(93, 3);
			this._txtMNS_AMT_2.Name = "_txtMNS_AMT_2";
			this._txtMNS_AMT_2.Size = new System.Drawing.Size(130, 23);
			this._txtMNS_AMT_2.TabIndex = 1127;
			this._txtMNS_AMT_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtMNS_AMT_2.ValidationGroup = "A";
			this._txtMNS_AMT_2.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMNS_AMT_2.WaterMarkText = "";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1126;
			this.label2.Text = "차감금액";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this._rbMNS_INTST_Y);
			this.flowLayoutPanel3.Controls.Add(this._rbMNS_INTST_N);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(90, 27);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel3.Size = new System.Drawing.Size(140, 27);
			this.flowLayoutPanel3.TabIndex = 210;
			// 
			// _rbMNS_INTST_Y
			// 
			this._rbMNS_INTST_Y.AutoSize = true;
			this._rbMNS_INTST_Y.Checked = true;
			this._rbMNS_INTST_Y.Enabled = false;
			this._rbMNS_INTST_Y.Location = new System.Drawing.Point(3, 5);
			this._rbMNS_INTST_Y.Name = "_rbMNS_INTST_Y";
			this._rbMNS_INTST_Y.Size = new System.Drawing.Size(36, 19);
			this._rbMNS_INTST_Y.TabIndex = 10;
			this._rbMNS_INTST_Y.TabStop = true;
			this._rbMNS_INTST_Y.Text = "Y";
			this._rbMNS_INTST_Y.UseVisualStyleBackColor = true;
			// 
			// _rbMNS_INTST_N
			// 
			this._rbMNS_INTST_N.AutoSize = true;
			this._rbMNS_INTST_N.Enabled = false;
			this._rbMNS_INTST_N.Location = new System.Drawing.Point(45, 5);
			this._rbMNS_INTST_N.Name = "_rbMNS_INTST_N";
			this._rbMNS_INTST_N.Size = new System.Drawing.Size(37, 19);
			this._rbMNS_INTST_N.TabIndex = 20;
			this._rbMNS_INTST_N.Text = "N";
			this._rbMNS_INTST_N.UseVisualStyleBackColor = true;
			// 
			// _btnComplete
			// 
			this._btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnComplete.DelegateProperty = true;
			this._btnComplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnComplete.Location = new System.Drawing.Point(594, 54);
			this._btnComplete.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this._btnComplete.Name = "_btnComplete";
			this._btnComplete.Size = new System.Drawing.Size(96, 27);
			this._btnComplete.TabIndex = 253;
			this._btnComplete.Text = "차감완료";
			this._btnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnComplete.UseVisualStyleBackColor = true;
			this._btnComplete.ValidationGroup = null;
			this._btnComplete.Click += new System.EventHandler(this._btnComplete_Click);
			// 
			// _cmbMNS_REG_CD2
			// 
			this._cmbMNS_REG_CD2.DataSource = null;
			this._cmbMNS_REG_CD2.DelegateProperty = true;
			this._cmbMNS_REG_CD2.Enabled = false;
			this._cmbMNS_REG_CD2.Location = new System.Drawing.Point(323, 30);
			this._cmbMNS_REG_CD2.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_REG_CD2.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_REG_CD2.Name = "_cmbMNS_REG_CD2";
			this._cmbMNS_REG_CD2.SelectedIndex = -1;
			this._cmbMNS_REG_CD2.SelectedItem = null;
			this._cmbMNS_REG_CD2.SelectedValue = null;
			this._cmbMNS_REG_CD2.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_REG_CD2.TabIndex = 220;
			this._cmbMNS_REG_CD2.ValidationGroup = null;
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(5, 33);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(82, 15);
			this.label14.TabIndex = 1125;
			this.label14.Text = "미차감이자";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(250, 33);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 15);
			this.label11.TabIndex = 1122;
			this.label11.Text = "차감사유";
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(480, 33);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 15);
			this.label12.TabIndex = 1123;
			this.label12.Text = "차감수치";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._txtMNS_PER);
			this.flowLayoutPanel4.Controls.Add(this._lblDPST_CAL_CD);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(550, 27);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(143, 27);
			this.flowLayoutPanel4.TabIndex = 200;
			// 
			// _txtMNS_PER
			// 
			this._txtMNS_PER.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMNS_PER.Enabled = false;
			this._txtMNS_PER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMNS_PER.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtMNS_PER.Location = new System.Drawing.Point(3, 3);
			this._txtMNS_PER.Name = "_txtMNS_PER";
			this._txtMNS_PER.Size = new System.Drawing.Size(100, 23);
			this._txtMNS_PER.TabIndex = 10;
			this._txtMNS_PER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtMNS_PER.ValidationGroup = "A";
			this._txtMNS_PER.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMNS_PER.WaterMarkText = "";
			// 
			// _lblDPST_CAL_CD
			// 
			this._lblDPST_CAL_CD.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._lblDPST_CAL_CD.AutoSize = true;
			this._lblDPST_CAL_CD.Location = new System.Drawing.Point(109, 7);
			this._lblDPST_CAL_CD.Name = "_lblDPST_CAL_CD";
			this._lblDPST_CAL_CD.Size = new System.Drawing.Size(22, 15);
			this._lblDPST_CAL_CD.TabIndex = 1119;
			this._lblDPST_CAL_CD.Text = "원";
			// 
			// _cmbMNS_CAL_CD
			// 
			this._cmbMNS_CAL_CD.DataSource = null;
			this._cmbMNS_CAL_CD.DelegateProperty = true;
			this._cmbMNS_CAL_CD.Enabled = false;
			this._cmbMNS_CAL_CD.Location = new System.Drawing.Point(553, 3);
			this._cmbMNS_CAL_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_CAL_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_CAL_CD.Name = "_cmbMNS_CAL_CD";
			this._cmbMNS_CAL_CD.SelectedIndex = -1;
			this._cmbMNS_CAL_CD.SelectedItem = null;
			this._cmbMNS_CAL_CD.SelectedValue = null;
			this._cmbMNS_CAL_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_CAL_CD.TabIndex = 190;
			this._cmbMNS_CAL_CD.ValidationGroup = null;
			this._cmbMNS_CAL_CD.DropDownClosed += new System.EventHandler(this._cmbMNS_CAL_CD_DropDownClosed);
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(480, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 1121;
			this.label10.Text = "계산방법";
			// 
			// _cmbMNS_GIJUN_CD
			// 
			this._cmbMNS_GIJUN_CD.DataSource = null;
			this._cmbMNS_GIJUN_CD.DelegateProperty = true;
			this._cmbMNS_GIJUN_CD.Enabled = false;
			this._cmbMNS_GIJUN_CD.Location = new System.Drawing.Point(323, 3);
			this._cmbMNS_GIJUN_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_GIJUN_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_GIJUN_CD.Name = "_cmbMNS_GIJUN_CD";
			this._cmbMNS_GIJUN_CD.SelectedIndex = -1;
			this._cmbMNS_GIJUN_CD.SelectedItem = null;
			this._cmbMNS_GIJUN_CD.SelectedValue = null;
			this._cmbMNS_GIJUN_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_GIJUN_CD.TabIndex = 180;
			this._cmbMNS_GIJUN_CD.ValidationGroup = null;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(250, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 15);
			this.label9.TabIndex = 1120;
			this.label9.Text = "차감기준";
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(250, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 15);
			this.label13.TabIndex = 1124;
			this.label13.Text = "상세사유";
			// 
			// _txtMNS_REG_MEMO2
			// 
			this._txtMNS_REG_MEMO2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMNS_REG_MEMO2.Enabled = false;
			this._txtMNS_REG_MEMO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMNS_REG_MEMO2.Location = new System.Drawing.Point(323, 58);
			this._txtMNS_REG_MEMO2.Name = "_txtMNS_REG_MEMO2";
			this._txtMNS_REG_MEMO2.Size = new System.Drawing.Size(130, 23);
			this._txtMNS_REG_MEMO2.TabIndex = 230;
			this._txtMNS_REG_MEMO2.ValidationGroup = "A";
			this._txtMNS_REG_MEMO2.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMNS_REG_MEMO2.WaterMarkText = "";
			// 
			// BAS0828
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(699, 386);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._gb2);
			this.Controls.Add(this._gb1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0828";
			this.Text = "가맹점.강제출금/자동차감등록:BAS0828";
			this.Load += new System.EventHandler(this.BAS0828_Load);
			this.Shown += new System.EventHandler(this.BAS0828_Shown);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this._gb1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this._gb2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private BANANA.Windows.Controls.GroupBox _gb1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnClose;
		private BANANA.Windows.Controls.Label label1;
		public BANANA.Windows.Controls.TextBox STR_CD;
		public BANANA.Windows.Controls.TextBox STR_NM;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_GUBUN_CD;
		private BANANA.Windows.Controls.Label label4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private BANANA.Windows.Controls.RadioButton _rbMNS_USE_Y;
		private BANANA.Windows.Controls.RadioButton _rbMNS_USE_N;
		private BANANA.Windows.Controls.Label label5;
		private BANANA.Windows.Controls.Label label6;
		public BANANA.Windows.Controls.TextBox _txtMEMO;
		private BANANA.Windows.Controls.Label label7;
		private BANANA.Windows.Controls.Label label8;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_REG_CD;
		private BANANA.Windows.Controls.TextBox _txtMNS_AMT_1;
		private BANANA.Windows.Controls.TextBox _txtMNS_REG_MEMO;
		private BANANA.Windows.Controls.Label label15;
		private BANANA.Windows.Controls.DateTimePicker _dtpMNS_APP_DT;
		private BANANA.Windows.Controls.GroupBox _gb2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private BANANA.Windows.Controls.TextBox _txtMNS_REG_MEMO2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private BANANA.Windows.Controls.RadioButton _rbMNS_INTST_Y;
		private BANANA.Windows.Controls.RadioButton _rbMNS_INTST_N;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_GIJUN_CD;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_CAL_CD;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private BANANA.Windows.Controls.TextBox _txtMNS_PER;
		private BANANA.Windows.Controls.Label _lblDPST_CAL_CD;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_REG_CD2;
		private BANANA.Windows.Controls.Label label14;
		private BANANA.Windows.Controls.Label label9;
		private BANANA.Windows.Controls.Label label10;
		private BANANA.Windows.Controls.Label label11;
		private BANANA.Windows.Controls.Label label12;
		private BANANA.Windows.Controls.Label label13;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private DemoClient.Controls.BananaButton _btnSTR_Search;
		private BANANA.Windows.Controls.TextBox _txtMNS_AMT_2;
		private BANANA.Windows.Controls.Label label2;
		private DemoClient.Controls.BananaButton _btnComplete;
		private BANANA.Windows.Controls.Label label16;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_ACCOUNT_CD;
	}
}
