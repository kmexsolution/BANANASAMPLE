namespace DemoClient.View.BAS
{
	partial class BAS0826
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0826));
			this._btnClose = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._txtDPST_LMT_AMT = new BANANA.Windows.Controls.TextBox();
			this.label12 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtDPST_PER = new BANANA.Windows.Controls.TextBox();
			this._lblDPST_CAL_CD = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this._rbDPST_INTST_Y = new BANANA.Windows.Controls.RadioButton();
			this._rbDPST_INTST_N = new BANANA.Windows.Controls.RadioButton();
			this._cmbDPST_CAL_CD = new BANANA.Windows.Controls.ComboBox();
			this._cmbDPST_GIJUN_CD = new BANANA.Windows.Controls.ComboBox();
			this.label5 = new BANANA.Windows.Controls.Label();
			this.label3 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.STR_NM = new BANANA.Windows.Controls.TextBox();
			this.STR_CD = new BANANA.Windows.Controls.TextBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this.label4 = new BANANA.Windows.Controls.Label();
			this.label6 = new BANANA.Windows.Controls.Label();
			this.label7 = new BANANA.Windows.Controls.Label();
			this.label8 = new BANANA.Windows.Controls.Label();
			this._dtpDPST_STRT_DT = new BANANA.Windows.Controls.DateTimePicker();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._rbDPST_USE_Y = new BANANA.Windows.Controls.RadioButton();
			this._rbDPST_USE_N = new BANANA.Windows.Controls.RadioButton();
			this.label9 = new BANANA.Windows.Controls.Label();
			this._txtDPST_AMT = new BANANA.Windows.Controls.TextBox();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnClose
			// 
			this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(378, 141);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 200;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.Controls.Add(this._txtDPST_LMT_AMT, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this._cmbDPST_CAL_CD, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this._cmbDPST_GIJUN_CD, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.STR_NM, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.STR_CD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this._dtpDPST_STRT_DT, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label9, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this._txtDPST_AMT, 3, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 135);
			this.tableLayoutPanel1.TabIndex = 1114;
			// 
			// _txtDPST_LMT_AMT
			// 
			this._txtDPST_LMT_AMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtDPST_LMT_AMT.Compulsory = true;
			this._txtDPST_LMT_AMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtDPST_LMT_AMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtDPST_LMT_AMT.Location = new System.Drawing.Point(93, 111);
			this._txtDPST_LMT_AMT.Name = "_txtDPST_LMT_AMT";
			this._txtDPST_LMT_AMT.Size = new System.Drawing.Size(130, 23);
			this._txtDPST_LMT_AMT.TabIndex = 1115;
			this._txtDPST_LMT_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtDPST_LMT_AMT.ValidationGroup = "A";
			this._txtDPST_LMT_AMT.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtDPST_LMT_AMT.WaterMarkText = "";
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(5, 114);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 15);
			this.label12.TabIndex = 1123;
			this.label12.Text = "일적립한도";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._txtDPST_PER);
			this.flowLayoutPanel4.Controls.Add(this._lblDPST_CAL_CD);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(320, 81);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(142, 27);
			this.flowLayoutPanel4.TabIndex = 170;
			// 
			// _txtDPST_PER
			// 
			this._txtDPST_PER.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtDPST_PER.Compulsory = true;
			this._txtDPST_PER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtDPST_PER.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtDPST_PER.Location = new System.Drawing.Point(3, 3);
			this._txtDPST_PER.Name = "_txtDPST_PER";
			this._txtDPST_PER.Size = new System.Drawing.Size(100, 23);
			this._txtDPST_PER.TabIndex = 130;
			this._txtDPST_PER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtDPST_PER.ValidationGroup = "A";
			this._txtDPST_PER.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtDPST_PER.WaterMarkText = "";
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
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this._rbDPST_INTST_Y);
			this.flowLayoutPanel3.Controls.Add(this._rbDPST_INTST_N);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(90, 81);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel3.Size = new System.Drawing.Size(140, 27);
			this.flowLayoutPanel3.TabIndex = 160;
			// 
			// _rbDPST_INTST_Y
			// 
			this._rbDPST_INTST_Y.AutoSize = true;
			this._rbDPST_INTST_Y.Checked = true;
			this._rbDPST_INTST_Y.Location = new System.Drawing.Point(3, 5);
			this._rbDPST_INTST_Y.Name = "_rbDPST_INTST_Y";
			this._rbDPST_INTST_Y.Size = new System.Drawing.Size(36, 19);
			this._rbDPST_INTST_Y.TabIndex = 10;
			this._rbDPST_INTST_Y.TabStop = true;
			this._rbDPST_INTST_Y.Text = "Y";
			this._rbDPST_INTST_Y.UseVisualStyleBackColor = true;
			// 
			// _rbDPST_INTST_N
			// 
			this._rbDPST_INTST_N.AutoSize = true;
			this._rbDPST_INTST_N.Location = new System.Drawing.Point(45, 5);
			this._rbDPST_INTST_N.Name = "_rbDPST_INTST_N";
			this._rbDPST_INTST_N.Size = new System.Drawing.Size(37, 19);
			this._rbDPST_INTST_N.TabIndex = 20;
			this._rbDPST_INTST_N.Text = "N";
			this._rbDPST_INTST_N.UseVisualStyleBackColor = true;
			// 
			// _cmbDPST_CAL_CD
			// 
			this._cmbDPST_CAL_CD.DataSource = null;
			this._cmbDPST_CAL_CD.DelegateProperty = true;
			this._cmbDPST_CAL_CD.Location = new System.Drawing.Point(323, 57);
			this._cmbDPST_CAL_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbDPST_CAL_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbDPST_CAL_CD.Name = "_cmbDPST_CAL_CD";
			this._cmbDPST_CAL_CD.SelectedIndex = -1;
			this._cmbDPST_CAL_CD.SelectedItem = null;
			this._cmbDPST_CAL_CD.SelectedValue = null;
			this._cmbDPST_CAL_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbDPST_CAL_CD.TabIndex = 150;
			this._cmbDPST_CAL_CD.ValidationGroup = null;
			this._cmbDPST_CAL_CD.DropDownClosed += new System.EventHandler(this._cmbDPST_CAL_CD_DropDownClosed);
			// 
			// _cmbDPST_GIJUN_CD
			// 
			this._cmbDPST_GIJUN_CD.DataSource = null;
			this._cmbDPST_GIJUN_CD.DelegateProperty = true;
			this._cmbDPST_GIJUN_CD.Enabled = false;
			this._cmbDPST_GIJUN_CD.Location = new System.Drawing.Point(93, 57);
			this._cmbDPST_GIJUN_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbDPST_GIJUN_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbDPST_GIJUN_CD.Name = "_cmbDPST_GIJUN_CD";
			this._cmbDPST_GIJUN_CD.SelectedIndex = -1;
			this._cmbDPST_GIJUN_CD.SelectedItem = null;
			this._cmbDPST_GIJUN_CD.SelectedValue = null;
			this._cmbDPST_GIJUN_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbDPST_GIJUN_CD.TabIndex = 140;
			this._cmbDPST_GIJUN_CD.ValidationGroup = null;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 1118;
			this.label5.Text = "차감기준";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 1117;
			this.label3.Text = "적용시작일";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(250, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1116;
			this.label2.Text = "가맹점명";
			// 
			// STR_NM
			// 
			this.STR_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.STR_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.STR_NM.Location = new System.Drawing.Point(323, 3);
			this.STR_NM.Name = "STR_NM";
			this.STR_NM.ReadOnly = true;
			this.STR_NM.Size = new System.Drawing.Size(130, 23);
			this.STR_NM.TabIndex = 110;
			this.STR_NM.ValidationGroup = null;
			this.STR_NM.WaterMarkColor = System.Drawing.Color.Empty;
			this.STR_NM.WaterMarkText = "";
			// 
			// STR_CD
			// 
			this.STR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.STR_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.STR_CD.Location = new System.Drawing.Point(93, 3);
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Size = new System.Drawing.Size(130, 23);
			this.STR_CD.TabIndex = 100;
			this.STR_CD.ValidationGroup = null;
			this.STR_CD.WaterMarkColor = System.Drawing.Color.Empty;
			this.STR_CD.WaterMarkText = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 1115;
			this.label1.Text = "가맹점코드";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(250, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 1118;
			this.label4.Text = "사용여부";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(250, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 15);
			this.label6.TabIndex = 1119;
			this.label6.Text = "계산방법";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 87);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 1120;
			this.label7.Text = "미차감이자";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(250, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 15);
			this.label8.TabIndex = 1121;
			this.label8.Text = "차감수치";
			// 
			// _dtpDPST_STRT_DT
			// 
			this._dtpDPST_STRT_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpDPST_STRT_DT.Checked = false;
			this._dtpDPST_STRT_DT.Compulsory = true;
			this._dtpDPST_STRT_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpDPST_STRT_DT.DelegateProperty = true;
			this._dtpDPST_STRT_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpDPST_STRT_DT.Location = new System.Drawing.Point(93, 30);
			this._dtpDPST_STRT_DT.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpDPST_STRT_DT.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpDPST_STRT_DT.Name = "_dtpDPST_STRT_DT";
			this._dtpDPST_STRT_DT.ShowCheckBox = true;
			this._dtpDPST_STRT_DT.Size = new System.Drawing.Size(130, 21);
			this._dtpDPST_STRT_DT.TabIndex = 120;
			this._dtpDPST_STRT_DT.ValidationGroup = "A";
			this._dtpDPST_STRT_DT.Value = new System.DateTime(2014, 7, 26, 14, 16, 17, 472);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._rbDPST_USE_Y);
			this.flowLayoutPanel1.Controls.Add(this._rbDPST_USE_N);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(320, 27);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(142, 27);
			this.flowLayoutPanel1.TabIndex = 130;
			// 
			// _rbDPST_USE_Y
			// 
			this._rbDPST_USE_Y.AutoSize = true;
			this._rbDPST_USE_Y.Checked = true;
			this._rbDPST_USE_Y.Location = new System.Drawing.Point(3, 5);
			this._rbDPST_USE_Y.Name = "_rbDPST_USE_Y";
			this._rbDPST_USE_Y.Size = new System.Drawing.Size(36, 19);
			this._rbDPST_USE_Y.TabIndex = 10;
			this._rbDPST_USE_Y.TabStop = true;
			this._rbDPST_USE_Y.Text = "Y";
			this._rbDPST_USE_Y.UseVisualStyleBackColor = true;
			// 
			// _rbDPST_USE_N
			// 
			this._rbDPST_USE_N.AutoSize = true;
			this._rbDPST_USE_N.Location = new System.Drawing.Point(45, 5);
			this._rbDPST_USE_N.Name = "_rbDPST_USE_N";
			this._rbDPST_USE_N.Size = new System.Drawing.Size(37, 19);
			this._rbDPST_USE_N.TabIndex = 20;
			this._rbDPST_USE_N.Text = "N";
			this._rbDPST_USE_N.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(235, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 27);
			this.label9.TabIndex = 1122;
			this.label9.Text = "보증한도금액";
			// 
			// _txtDPST_AMT
			// 
			this._txtDPST_AMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtDPST_AMT.Compulsory = true;
			this._txtDPST_AMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtDPST_AMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtDPST_AMT.Location = new System.Drawing.Point(323, 111);
			this._txtDPST_AMT.Name = "_txtDPST_AMT";
			this._txtDPST_AMT.Size = new System.Drawing.Size(130, 23);
			this._txtDPST_AMT.TabIndex = 180;
			this._txtDPST_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtDPST_AMT.ValidationGroup = "A";
			this._txtDPST_AMT.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtDPST_AMT.WaterMarkText = "";
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(297, 141);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 190;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "A";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// BAS0826
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(462, 177);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0826";
			this.Text = "가맹점.보증예치금등록:BAS0826";
			this.Load += new System.EventHandler(this.BAS0826_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DemoClient.Controls.BananaButton _btnClose;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.TextBox _txtDPST_AMT;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private BANANA.Windows.Controls.TextBox _txtDPST_PER;
		private BANANA.Windows.Controls.Label _lblDPST_CAL_CD;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private BANANA.Windows.Controls.RadioButton _rbDPST_INTST_Y;
		private BANANA.Windows.Controls.RadioButton _rbDPST_INTST_N;
		private BANANA.Windows.Controls.ComboBox _cmbDPST_CAL_CD;
		private BANANA.Windows.Controls.ComboBox _cmbDPST_GIJUN_CD;
		private BANANA.Windows.Controls.Label label5;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.Label label4;
		private BANANA.Windows.Controls.Label label6;
		private BANANA.Windows.Controls.Label label7;
		private BANANA.Windows.Controls.Label label8;
		private BANANA.Windows.Controls.Label label9;
		private BANANA.Windows.Controls.DateTimePicker _dtpDPST_STRT_DT;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private BANANA.Windows.Controls.RadioButton _rbDPST_USE_Y;
		private BANANA.Windows.Controls.RadioButton _rbDPST_USE_N;
		private DemoClient.Controls.BananaButton _btnSave;
		public BANANA.Windows.Controls.TextBox STR_NM;
		public BANANA.Windows.Controls.TextBox STR_CD;
		private BANANA.Windows.Controls.Label label12;
		private BANANA.Windows.Controls.TextBox _txtDPST_LMT_AMT;

	}
}
