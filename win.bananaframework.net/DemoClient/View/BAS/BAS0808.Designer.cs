namespace DemoClient.View.BAS
{
	partial class BAS0808
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0808));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this._btnDel = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnAdd = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this._dtpCI_LMT_APP_DT = new BANANA.Windows.Controls.DateTimePicker();
			this._txtCI_TOT_LMT = new BANANA.Windows.Controls.TextBox();
			this.label19 = new BANANA.Windows.Controls.Label();
			this.label21 = new BANANA.Windows.Controls.Label();
			this.label25 = new BANANA.Windows.Controls.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._txtCI_DAILY_LMT = new BANANA.Windows.Controls.TextBox();
			this._txtCI_UNIT_LMT = new BANANA.Windows.Controls.TextBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_LMT_APP_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_UNIT_LMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_DAILY_LMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CI_TOT_LMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._btnDel);
			this.groupBox1.Controls.Add(this._btnClose);
			this.groupBox1.Controls.Add(this._btnSave);
			this.groupBox1.Controls.Add(this._btnAdd);
			this.groupBox1.Controls.Add(this.tableLayoutPanel4);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 175);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(700, 117);
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
			this._btnDel.Location = new System.Drawing.Point(530, 76);
			this._btnDel.Name = "_btnDel";
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
			this._btnClose.Location = new System.Drawing.Point(611, 76);
			this._btnClose.Name = "_btnClose";
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
			this._btnSave.Location = new System.Drawing.Point(449, 76);
			this._btnSave.Name = "_btnSave";
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
			this._btnAdd.Location = new System.Drawing.Point(368, 76);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(75, 27);
			this._btnAdd.TabIndex = 140;
			this._btnAdd.Text = "      추   가";
			this._btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.ValidationGroup = null;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 6;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.Controls.Add(this._dtpCI_LMT_APP_DT, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this._txtCI_TOT_LMT, 5, 0);
			this.tableLayoutPanel4.Controls.Add(this.label19, 4, 0);
			this.tableLayoutPanel4.Controls.Add(this.label21, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.label25, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this._txtCI_DAILY_LMT, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this._txtCI_UNIT_LMT, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(694, 54);
			this.tableLayoutPanel4.TabIndex = 4;
			// 
			// _dtpCI_LMT_APP_DT
			// 
			this._dtpCI_LMT_APP_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpCI_LMT_APP_DT.Checked = false;
			this._dtpCI_LMT_APP_DT.Compulsory = true;
			this._dtpCI_LMT_APP_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpCI_LMT_APP_DT.DelegateProperty = true;
			this._dtpCI_LMT_APP_DT.Enabled = false;
			this._dtpCI_LMT_APP_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpCI_LMT_APP_DT.Location = new System.Drawing.Point(93, 30);
			this._dtpCI_LMT_APP_DT.Name = "_dtpCI_LMT_APP_DT";
			this._dtpCI_LMT_APP_DT.ShowCheckBox = true;
			this._dtpCI_LMT_APP_DT.Size = new System.Drawing.Size(130, 20);
			this._dtpCI_LMT_APP_DT.TabIndex = 130;
			this._dtpCI_LMT_APP_DT.ValidationGroup = "a";
			// 
			// _txtCI_TOT_LMT
			// 
			this._txtCI_TOT_LMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_TOT_LMT.Compulsory = true;
			this._txtCI_TOT_LMT.DelegateProperty = true;
			this._txtCI_TOT_LMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_TOT_LMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtCI_TOT_LMT.Location = new System.Drawing.Point(553, 3);
			this._txtCI_TOT_LMT.Name = "_txtCI_TOT_LMT";
			this._txtCI_TOT_LMT.ReadOnly = true;
			this._txtCI_TOT_LMT.Size = new System.Drawing.Size(130, 20);
			this._txtCI_TOT_LMT.TabIndex = 120;
			this._txtCI_TOT_LMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_TOT_LMT.ValidationGroup = "a";
			this._txtCI_TOT_LMT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_TOT_LMT.WaterMarkText = "";
			// 
			// label19
			// 
			this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(485, 7);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(62, 13);
			this.label19.TabIndex = 10;
			this.label19.Text = "총대출한도";
			// 
			// label21
			// 
			this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(14, 7);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(73, 13);
			this.label21.TabIndex = 9;
			this.label21.Text = "건별대출한도";
			// 
			// label25
			// 
			this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(25, 34);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(62, 13);
			this.label25.TabIndex = 0;
			this.label25.Text = "적용시작일";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(249, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "1일대출한도";
			// 
			// _txtCI_DAILY_LMT
			// 
			this._txtCI_DAILY_LMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_DAILY_LMT.Compulsory = true;
			this._txtCI_DAILY_LMT.DelegateProperty = true;
			this._txtCI_DAILY_LMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_DAILY_LMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtCI_DAILY_LMT.Location = new System.Drawing.Point(323, 3);
			this._txtCI_DAILY_LMT.Name = "_txtCI_DAILY_LMT";
			this._txtCI_DAILY_LMT.ReadOnly = true;
			this._txtCI_DAILY_LMT.Size = new System.Drawing.Size(130, 20);
			this._txtCI_DAILY_LMT.TabIndex = 110;
			this._txtCI_DAILY_LMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_DAILY_LMT.ValidationGroup = "a";
			this._txtCI_DAILY_LMT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_DAILY_LMT.WaterMarkText = "";
			// 
			// _txtCI_UNIT_LMT
			// 
			this._txtCI_UNIT_LMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_UNIT_LMT.Compulsory = true;
			this._txtCI_UNIT_LMT.DelegateProperty = true;
			this._txtCI_UNIT_LMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_UNIT_LMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtCI_UNIT_LMT.Location = new System.Drawing.Point(93, 3);
			this._txtCI_UNIT_LMT.Name = "_txtCI_UNIT_LMT";
			this._txtCI_UNIT_LMT.ReadOnly = true;
			this._txtCI_UNIT_LMT.Size = new System.Drawing.Size(130, 20);
			this._txtCI_UNIT_LMT.TabIndex = 100;
			this._txtCI_UNIT_LMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_UNIT_LMT.ValidationGroup = "a";
			this._txtCI_UNIT_LMT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_UNIT_LMT.WaterMarkText = "";
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
            this.IDX,
            this.CI_LMT_APP_DT,
            this.CI_UNIT_LMT,
            this.CI_DAILY_LMT,
            this.CI_TOT_LMT,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridView1.Location = new System.Drawing.Point(0, 0);
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(700, 175);
			this.gridView1.TabIndex = 101;
			this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
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
			// CI_LMT_APP_DT
			// 
			this.CI_LMT_APP_DT.DataPropertyName = "CI_LMT_APP_DT";
			this.CI_LMT_APP_DT.HeaderText = "적용시작일";
			this.CI_LMT_APP_DT.Name = "CI_LMT_APP_DT";
			this.CI_LMT_APP_DT.ReadOnly = true;
			this.CI_LMT_APP_DT.Width = 87;
			// 
			// CI_UNIT_LMT
			// 
			this.CI_UNIT_LMT.DataPropertyName = "CI_UNIT_LMT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "0";
			this.CI_UNIT_LMT.DefaultCellStyle = dataGridViewCellStyle2;
			this.CI_UNIT_LMT.HeaderText = "건별대출한도";
			this.CI_UNIT_LMT.Name = "CI_UNIT_LMT";
			this.CI_UNIT_LMT.ReadOnly = true;
			this.CI_UNIT_LMT.Width = 98;
			// 
			// CI_DAILY_LMT
			// 
			this.CI_DAILY_LMT.DataPropertyName = "CI_DAILY_LMT";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = "0";
			this.CI_DAILY_LMT.DefaultCellStyle = dataGridViewCellStyle3;
			this.CI_DAILY_LMT.HeaderText = "1일대출한도";
			this.CI_DAILY_LMT.Name = "CI_DAILY_LMT";
			this.CI_DAILY_LMT.ReadOnly = true;
			this.CI_DAILY_LMT.Width = 93;
			// 
			// CI_TOT_LMT
			// 
			this.CI_TOT_LMT.DataPropertyName = "CI_TOT_LMT";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = "0";
			this.CI_TOT_LMT.DefaultCellStyle = dataGridViewCellStyle4;
			this.CI_TOT_LMT.HeaderText = "총대출한도";
			this.CI_TOT_LMT.Name = "CI_TOT_LMT";
			this.CI_TOT_LMT.ReadOnly = true;
			this.CI_TOT_LMT.Width = 87;
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
			// BAS0808
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(700, 292);
			this.Controls.Add(this.gridView1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0808";
			this.Text = "대출한도조정:BAS0808";
			this.Load += new System.EventHandler(this.BAS0808_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private BANANA.Windows.Controls.DateTimePicker _dtpCI_LMT_APP_DT;
		private BANANA.Windows.Controls.TextBox _txtCI_TOT_LMT;
		private BANANA.Windows.Controls.Label label19;
		private BANANA.Windows.Controls.Label label21;
		private BANANA.Windows.Controls.Label label25;
		private System.Windows.Forms.Label label4;
		private BANANA.Windows.Controls.TextBox _txtCI_DAILY_LMT;
		private BANANA.Windows.Controls.TextBox _txtCI_UNIT_LMT;
		private DemoClient.Controls.BananaButton _btnDel;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnAdd;
		private DemoClient.Controls.GridView gridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_LMT_APP_DT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_UNIT_LMT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_DAILY_LMT;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI_TOT_LMT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
	}
}
