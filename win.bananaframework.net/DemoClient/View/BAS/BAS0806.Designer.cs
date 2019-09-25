namespace DemoClient.View.BAS
{
	partial class BAS0806
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0806));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this._btnDel = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnAdd = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label13 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtCI_LN_RATE = new BANANA.Windows.Controls.TextBox();
			this.label6 = new BANANA.Windows.Controls.Label();
			this._dtpCI_APP_DT = new BANANA.Windows.Controls.DateTimePicker();
			this.label11 = new BANANA.Windows.Controls.Label();
			this.label10 = new BANANA.Windows.Controls.Label();
			this._cmbCI_LNR_CD = new BANANA.Windows.Controls.ComboBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._cmbCI_AGT_CD = new BANANA.Windows.Controls.ComboBox();
			this.label12 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtCI_LN_OVD = new BANANA.Windows.Controls.TextBox();
			this.label18 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this._rbCI_LN_GUBUN01 = new BANANA.Windows.Controls.RadioButton();
			this._rbCI_LN_GUBUN02 = new BANANA.Windows.Controls.RadioButton();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.CI_APP_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LN_RATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LN_OVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_AGT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_AGT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LNR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LNR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LN_GUBUN_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LN_GUBUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._btnDel);
			this.groupBox1.Controls.Add(this._btnClose);
			this.groupBox1.Controls.Add(this._btnSave);
			this.groupBox1.Controls.Add(this._btnAdd);
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 280);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(713, 116);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "상세 정보";
			// 
			// _btnDel
			// 
			this._btnDel.ButtonConfirm = true;
			this._btnDel.DelegateProperty = true;
			this._btnDel.Enabled = false;
			this._btnDel.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnDel.Location = new System.Drawing.Point(544, 76);
			this._btnDel.Name = "_btnDel";
			this._btnDel.Reserved = "      삭   제";
			this._btnDel.Size = new System.Drawing.Size(75, 27);
			this._btnDel.TabIndex = 160;
			this._btnDel.Text = "      삭   제";
			this._btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnDel.UseVisualStyleBackColor = true;
			this._btnDel.ValidationGroup = null;
			this._btnDel.Click += new System.EventHandler(this._btnDel_Click);
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(625, 76);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Reserved = "      닫   기";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 170;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// _btnSave
			// 
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Enabled = false;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(463, 76);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Reserved = "      저   장";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 150;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _btnAdd
			// 
			this._btnAdd.DelegateProperty = true;
			this._btnAdd.Image = global::DemoClient.Properties.Resources._1377801089_62655;
			this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnAdd.Location = new System.Drawing.Point(382, 76);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Reserved = "      추   가";
			this._btnAdd.Size = new System.Drawing.Size(75, 27);
			this._btnAdd.TabIndex = 140;
			this._btnAdd.Text = "      추   가";
			this._btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.ValidationGroup = null;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
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
			this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this._dtpCI_APP_DT, 5, 0);
			this.tableLayoutPanel3.Controls.Add(this.label11, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.label10, 4, 1);
			this.tableLayoutPanel3.Controls.Add(this._cmbCI_LNR_CD, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.label1, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this._cmbCI_AGT_CD, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.label12, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 5, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(707, 54);
			this.tableLayoutPanel3.TabIndex = 1105;
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(5, 6);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 15);
			this.label13.TabIndex = 9;
			this.label13.Text = "대출이자율";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this._txtCI_LN_RATE);
			this.flowLayoutPanel2.Controls.Add(this.label6);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(90, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(140, 27);
			this.flowLayoutPanel2.TabIndex = 1428;
			// 
			// _txtCI_LN_RATE
			// 
			this._txtCI_LN_RATE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_LN_RATE.Compulsory = true;
			this._txtCI_LN_RATE.DelegateProperty = true;
			this._txtCI_LN_RATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_LN_RATE.ImeMode = BANANA.Windows.Controls.ImeMode.Decimal;
			this._txtCI_LN_RATE.Location = new System.Drawing.Point(3, 3);
			this._txtCI_LN_RATE.Name = "_txtCI_LN_RATE";
			this._txtCI_LN_RATE.ReadOnly = true;
			this._txtCI_LN_RATE.Size = new System.Drawing.Size(90, 23);
			this._txtCI_LN_RATE.TabIndex = 110;
			this._txtCI_LN_RATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_LN_RATE.ValidationGroup = "a";
			this._txtCI_LN_RATE.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_LN_RATE.WaterMarkText = "";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(0, 29);
			this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "% / 년";
			// 
			// _dtpCI_APP_DT
			// 
			this._dtpCI_APP_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpCI_APP_DT.Checked = false;
			this._dtpCI_APP_DT.Compulsory = true;
			this._dtpCI_APP_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpCI_APP_DT.DelegateProperty = true;
			this._dtpCI_APP_DT.Enabled = false;
			this._dtpCI_APP_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpCI_APP_DT.Location = new System.Drawing.Point(553, 3);
			this._dtpCI_APP_DT.MaximumSize = new System.Drawing.Size(250, 20);
			this._dtpCI_APP_DT.MinimumSize = new System.Drawing.Size(100, 20);
			this._dtpCI_APP_DT.Name = "_dtpCI_APP_DT";
			this._dtpCI_APP_DT.ShowCheckBox = true;
			this._dtpCI_APP_DT.Size = new System.Drawing.Size(130, 20);
			this._dtpCI_APP_DT.TabIndex = 130;
			this._dtpCI_APP_DT.ValidationGroup = "a";
			this._dtpCI_APP_DT.Value = new System.DateTime(2014, 7, 25, 10, 20, 16, 341);
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(465, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 15);
			this.label11.TabIndex = 10;
			this.label11.Text = "적용시작일";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(480, 33);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 1107;
			this.label10.Text = "대출구분";
			this.label10.Visible = false;
			// 
			// _cmbCI_LNR_CD
			// 
			this._cmbCI_LNR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbCI_LNR_CD.Compulsory = true;
			this._cmbCI_LNR_CD.DataSource = null;
			this._cmbCI_LNR_CD.DelegateProperty = true;
			this._cmbCI_LNR_CD.DroppedDown = false;
			this._cmbCI_LNR_CD.Enabled = false;
			this._cmbCI_LNR_CD.Location = new System.Drawing.Point(323, 30);
			this._cmbCI_LNR_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbCI_LNR_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbCI_LNR_CD.Name = "_cmbCI_LNR_CD";
			this._cmbCI_LNR_CD.SelectedIndex = -1;
			this._cmbCI_LNR_CD.SelectedItem = null;
			this._cmbCI_LNR_CD.SelectedValue = null;
			this._cmbCI_LNR_CD.Size = new System.Drawing.Size(130, 23);
			this._cmbCI_LNR_CD.TabIndex = 135;
			this._cmbCI_LNR_CD.ValidationGroup = "a";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(265, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 1106;
			this.label1.Text = "여신사";
			// 
			// _cmbCI_AGT_CD
			// 
			this._cmbCI_AGT_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbCI_AGT_CD.DataSource = null;
			this._cmbCI_AGT_CD.DelegateProperty = true;
			this._cmbCI_AGT_CD.DroppedDown = false;
			this._cmbCI_AGT_CD.Enabled = false;
			this._cmbCI_AGT_CD.Location = new System.Drawing.Point(93, 30);
			this._cmbCI_AGT_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbCI_AGT_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbCI_AGT_CD.Name = "_cmbCI_AGT_CD";
			this._cmbCI_AGT_CD.SelectedIndex = -1;
			this._cmbCI_AGT_CD.SelectedItem = null;
			this._cmbCI_AGT_CD.SelectedValue = null;
			this._cmbCI_AGT_CD.Size = new System.Drawing.Size(130, 23);
			this._cmbCI_AGT_CD.TabIndex = 120;
			this._cmbCI_AGT_CD.ValidationGroup = null;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(5, 33);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 15);
			this.label12.TabIndex = 10;
			this.label12.Text = "수익대리점";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(235, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 1429;
			this.label2.Text = "연체이자율";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._txtCI_LN_OVD);
			this.flowLayoutPanel4.Controls.Add(this.label18);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(320, 0);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(140, 27);
			this.flowLayoutPanel4.TabIndex = 1433;
			// 
			// _txtCI_LN_OVD
			// 
			this._txtCI_LN_OVD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_LN_OVD.Compulsory = true;
			this._txtCI_LN_OVD.DelegateProperty = true;
			this._txtCI_LN_OVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_LN_OVD.ImeMode = BANANA.Windows.Controls.ImeMode.Decimal;
			this._txtCI_LN_OVD.Location = new System.Drawing.Point(3, 3);
			this._txtCI_LN_OVD.Name = "_txtCI_LN_OVD";
			this._txtCI_LN_OVD.ReadOnly = true;
			this._txtCI_LN_OVD.Size = new System.Drawing.Size(90, 23);
			this._txtCI_LN_OVD.TabIndex = 1427;
			this._txtCI_LN_OVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_LN_OVD.ValidationGroup = "a";
			this._txtCI_LN_OVD.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_LN_OVD.WaterMarkText = "";
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(0, 29);
			this.label18.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(49, 15);
			this.label18.TabIndex = 10;
			this.label18.Text = "% / 년";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this._rbCI_LN_GUBUN01);
			this.flowLayoutPanel3.Controls.Add(this._rbCI_LN_GUBUN02);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(550, 27);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.flowLayoutPanel3.Size = new System.Drawing.Size(157, 27);
			this.flowLayoutPanel3.TabIndex = 136;
			// 
			// _rbCI_LN_GUBUN01
			// 
			this._rbCI_LN_GUBUN01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._rbCI_LN_GUBUN01.AutoSize = true;
			this._rbCI_LN_GUBUN01.Checked = true;
			this._rbCI_LN_GUBUN01.DelegateProperty = true;
			this._rbCI_LN_GUBUN01.Enabled = false;
			this._rbCI_LN_GUBUN01.Location = new System.Drawing.Point(3, 6);
			this._rbCI_LN_GUBUN01.Name = "_rbCI_LN_GUBUN01";
			this._rbCI_LN_GUBUN01.Size = new System.Drawing.Size(88, 19);
			this._rbCI_LN_GUBUN01.TabIndex = 136;
			this._rbCI_LN_GUBUN01.TabStop = true;
			this._rbCI_LN_GUBUN01.Text = "자동대출";
			this._rbCI_LN_GUBUN01.UseVisualStyleBackColor = true;
			this._rbCI_LN_GUBUN01.Visible = false;
			// 
			// _rbCI_LN_GUBUN02
			// 
			this._rbCI_LN_GUBUN02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._rbCI_LN_GUBUN02.AutoSize = true;
			this._rbCI_LN_GUBUN02.DelegateProperty = true;
			this._rbCI_LN_GUBUN02.Enabled = false;
			this._rbCI_LN_GUBUN02.Location = new System.Drawing.Point(3, 31);
			this._rbCI_LN_GUBUN02.Name = "_rbCI_LN_GUBUN02";
			this._rbCI_LN_GUBUN02.Size = new System.Drawing.Size(88, 19);
			this._rbCI_LN_GUBUN02.TabIndex = 137;
			this._rbCI_LN_GUBUN02.Text = "희망대출";
			this._rbCI_LN_GUBUN02.UseVisualStyleBackColor = true;
			this._rbCI_LN_GUBUN02.Visible = false;
			// 
			// gridView1
			// 
			this.gridView1.AutoSelectRowWithRightButton = false;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI_APP_DT,
            this.IDX,
            this.CI_LN_RATE,
            this.CI_LN_OVD,
            this.CI_AGT_CD,
            this.CI_AGT_NM,
            this.CI_LNR_CD,
            this.CI_LNR_NM,
            this.CI_LN_GUBUN_CD,
            this.CI_LN_GUBUN,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(0, 0);
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(713, 280);
			this.gridView1.TabIndex = 100;
			this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
			// 
			// CI_APP_DT
			// 
			this.CI_APP_DT.DataPropertyName = "CI_APP_DT";
			this.CI_APP_DT.HeaderText = "적용시작일";
			this.CI_APP_DT.Name = "CI_APP_DT";
			this.CI_APP_DT.ReadOnly = true;
			this.CI_APP_DT.Width = 111;
			// 
			// IDX
			// 
			this.IDX.DataPropertyName = "IDX";
			this.IDX.HeaderText = "일련번호";
			this.IDX.Name = "IDX";
			this.IDX.ReadOnly = true;
			this.IDX.Visible = false;
			this.IDX.Width = 76;
			// 
			// CI_LN_RATE
			// 
			this.CI_LN_RATE.DataPropertyName = "CI_LN_RATE";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.NullValue = "0";
			this.CI_LN_RATE.DefaultCellStyle = dataGridViewCellStyle2;
			this.CI_LN_RATE.HeaderText = "대출이자율";
			this.CI_LN_RATE.Name = "CI_LN_RATE";
			this.CI_LN_RATE.ReadOnly = true;
			this.CI_LN_RATE.Width = 111;
			// 
			// CI_LN_OVD
			// 
			this.CI_LN_OVD.DataPropertyName = "CI_LN_OVD";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.NullValue = "0";
			this.CI_LN_OVD.DefaultCellStyle = dataGridViewCellStyle3;
			this.CI_LN_OVD.HeaderText = "연체이자율";
			this.CI_LN_OVD.Name = "CI_LN_OVD";
			this.CI_LN_OVD.ReadOnly = true;
			this.CI_LN_OVD.Width = 111;
			// 
			// CI_AGT_CD
			// 
			this.CI_AGT_CD.DataPropertyName = "CI_AGT_CD";
			this.CI_AGT_CD.HeaderText = "수익대리점코드";
			this.CI_AGT_CD.Name = "CI_AGT_CD";
			this.CI_AGT_CD.ReadOnly = true;
			this.CI_AGT_CD.Visible = false;
			this.CI_AGT_CD.Width = 109;
			// 
			// CI_AGT_NM
			// 
			this.CI_AGT_NM.DataPropertyName = "CI_AGT_NM";
			this.CI_AGT_NM.HeaderText = "수익대리점";
			this.CI_AGT_NM.Name = "CI_AGT_NM";
			this.CI_AGT_NM.ReadOnly = true;
			this.CI_AGT_NM.Width = 111;
			// 
			// CI_LNR_CD
			// 
			this.CI_LNR_CD.DataPropertyName = "CI_LNR_CD";
			this.CI_LNR_CD.HeaderText = "여신사코드";
			this.CI_LNR_CD.Name = "CI_LNR_CD";
			this.CI_LNR_CD.ReadOnly = true;
			this.CI_LNR_CD.Visible = false;
			this.CI_LNR_CD.Width = 87;
			// 
			// CI_LNR_NM
			// 
			this.CI_LNR_NM.DataPropertyName = "CI_LNR_NM";
			this.CI_LNR_NM.HeaderText = "여신사";
			this.CI_LNR_NM.Name = "CI_LNR_NM";
			this.CI_LNR_NM.ReadOnly = true;
			this.CI_LNR_NM.Width = 81;
			// 
			// CI_LN_GUBUN_CD
			// 
			this.CI_LN_GUBUN_CD.DataPropertyName = "CI_LN_GUBUN_CD";
			this.CI_LN_GUBUN_CD.HeaderText = "즉시결제대출구분코드";
			this.CI_LN_GUBUN_CD.Name = "CI_LN_GUBUN_CD";
			this.CI_LN_GUBUN_CD.ReadOnly = true;
			this.CI_LN_GUBUN_CD.Visible = false;
			this.CI_LN_GUBUN_CD.Width = 142;
			// 
			// CI_LN_GUBUN
			// 
			this.CI_LN_GUBUN.DataPropertyName = "CI_LN_GUBUN";
			this.CI_LN_GUBUN.HeaderText = "대출구분";
			this.CI_LN_GUBUN.Name = "CI_LN_GUBUN";
			this.CI_LN_GUBUN.ReadOnly = true;
			this.CI_LN_GUBUN.Width = 96;
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
			// BAS0806
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(713, 396);
			this.Controls.Add(this.gridView1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0806";
			this.Text = "대출이자율조정:BAS0806";
			this.Load += new System.EventHandler(this.BAS0806_Load);
			this.Shown += new System.EventHandler(this.BAS0806_Shown);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private BANANA.Windows.Controls.DateTimePicker _dtpCI_APP_DT;
		private BANANA.Windows.Controls.Label label11;
		private BANANA.Windows.Controls.ComboBox _cmbCI_AGT_CD;
		private BANANA.Windows.Controls.Label label12;
		private BANANA.Windows.Controls.Label label13;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private BANANA.Windows.Controls.TextBox _txtCI_LN_RATE;
		private BANANA.Windows.Controls.Label label6;
		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnAdd;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.GridView gridView1;
		private DemoClient.Controls.BananaButton _btnDel;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.ComboBox _cmbCI_LNR_CD;
		private BANANA.Windows.Controls.Label label10;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private BANANA.Windows.Controls.RadioButton _rbCI_LN_GUBUN01;
		private BANANA.Windows.Controls.RadioButton _rbCI_LN_GUBUN02;
		private BANANA.Windows.Controls.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private BANANA.Windows.Controls.TextBox _txtCI_LN_OVD;
		private BANANA.Windows.Controls.Label label18;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_APP_DT;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LN_RATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LN_OVD;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_AGT_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_AGT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LNR_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LNR_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LN_GUBUN_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LN_GUBUN;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
	}
}
