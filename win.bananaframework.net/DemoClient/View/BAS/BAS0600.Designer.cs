namespace DemoClient.View.BAS
{
	partial class BAS0600
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0600));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new BANANA.Windows.Controls.Label();
            this._cmbYear_S = new BANANA.Windows.Controls.ComboBox();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lblPRE_WKDAY = new BANANA.Windows.Controls.Label();
            this._btnSave = new DemoClient.Controls.BananaButton();
            this._btnDel = new DemoClient.Controls.BananaButton();
            this._btnAdd = new DemoClient.Controls.BananaButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._txtWKMEMO = new BANANA.Windows.Controls.TextBox();
            this.label1 = new BANANA.Windows.Controls.Label();
            this._dtpWKDAY = new BANANA.Windows.Controls.DateTimePicker();
            this.label11 = new BANANA.Windows.Controls.Label();
            this.collapsibleSplitter1 = new DemoClient.Controls.CollapsibleSplitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DemoClient.Controls.GridView();
            this.WKDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WKMEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1135, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this._cmbYear_S, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this._btnSearch, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1129, 34);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(34, 11);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 12);
            this.label35.TabIndex = 1114;
            this.label35.Text = "기준년도";
            // 
            // _cmbYear_S
            // 
            this._cmbYear_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._cmbYear_S.DataSource = null;
            this._cmbYear_S.DelegateProperty = true;
            this._cmbYear_S.DroppedDown = false;
            this._cmbYear_S.Location = new System.Drawing.Point(93, 6);
            this._cmbYear_S.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbYear_S.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbYear_S.Name = "_cmbYear_S";
            this._cmbYear_S.SelectedIndex = -1;
            this._cmbYear_S.SelectedItem = null;
            this._cmbYear_S.SelectedValue = null;
            this._cmbYear_S.Size = new System.Drawing.Size(120, 21);
            this._cmbYear_S.TabIndex = 100;
            this._cmbYear_S.ValidationGroup = null;
            // 
            // _btnSearch
            // 
            this._btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnSearch.DelegateProperty = true;
            this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
            this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.Location = new System.Drawing.Point(223, 5);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Reserved = "      검   색";
            this._btnSearch.Size = new System.Drawing.Size(75, 24);
            this._btnSearch.TabIndex = 160;
            this._btnSearch.Text = "      검   색";
            this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.ValidationGroup = null;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lblPRE_WKDAY);
            this.groupBox2.Controls.Add(this._btnSave);
            this.groupBox2.Controls.Add(this._btnDel);
            this.groupBox2.Controls.Add(this._btnAdd);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(586, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 569);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상세 정보";
            // 
            // _lblPRE_WKDAY
            // 
            this._lblPRE_WKDAY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblPRE_WKDAY.AutoSize = true;
            this._lblPRE_WKDAY.Location = new System.Drawing.Point(6, 56);
            this._lblPRE_WKDAY.Name = "_lblPRE_WKDAY";
            this._lblPRE_WKDAY.Size = new System.Drawing.Size(65, 12);
            this._lblPRE_WKDAY.TabIndex = 1114;
            this._lblPRE_WKDAY.Text = "이전공휴일";
            this._lblPRE_WKDAY.Visible = false;
            // 
            // _btnSave
            // 
            this._btnSave.ButtonConfirm = true;
            this._btnSave.DelegateProperty = true;
            this._btnSave.Enabled = false;
            this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
            this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSave.Location = new System.Drawing.Point(380, 49);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Reserved = "      저   장";
            this._btnSave.Size = new System.Drawing.Size(75, 27);
            this._btnSave.TabIndex = 1112;
            this._btnSave.Text = "      저   장";
            this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.ValidationGroup = "a";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnDel
            // 
            this._btnDel.ButtonConfirm = true;
            this._btnDel.DelegateProperty = true;
            this._btnDel.Enabled = false;
            this._btnDel.Image = global::DemoClient.Properties.Resources.red_62690;
            this._btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDel.Location = new System.Drawing.Point(461, 49);
            this._btnDel.Name = "_btnDel";
            this._btnDel.Reserved = "      삭   제";
            this._btnDel.Size = new System.Drawing.Size(75, 27);
            this._btnDel.TabIndex = 1113;
            this._btnDel.Text = "      삭   제";
            this._btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDel.UseVisualStyleBackColor = true;
            this._btnDel.ValidationGroup = null;
            this._btnDel.Click += new System.EventHandler(this._btnDel_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.DelegateProperty = true;
            this._btnAdd.Image = global::DemoClient.Properties.Resources._1377801089_62655;
            this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAdd.Location = new System.Drawing.Point(299, 49);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Reserved = "      추   가";
            this._btnAdd.Size = new System.Drawing.Size(75, 27);
            this._btnAdd.TabIndex = 1111;
            this._btnAdd.Text = "      추   가";
            this._btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.ValidationGroup = null;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Controls.Add(this._txtWKMEMO, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._dtpWKDAY, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _txtWKMEMO
            // 
            this._txtWKMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtWKMEMO.DelegateProperty = true;
            this._txtWKMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtWKMEMO.Location = new System.Drawing.Point(323, 3);
            this._txtWKMEMO.Name = "_txtWKMEMO";
            this._txtWKMEMO.ReadOnly = true;
            this._txtWKMEMO.Size = new System.Drawing.Size(210, 20);
            this._txtWKMEMO.TabIndex = 1010;
            this._txtWKMEMO.ValidationGroup = null;
            this._txtWKMEMO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtWKMEMO.WaterMarkText = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1114;
            this.label1.Text = "메모";
            // 
            // _dtpWKDAY
            // 
            this._dtpWKDAY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._dtpWKDAY.Checked = false;
            this._dtpWKDAY.Compulsory = true;
            this._dtpWKDAY.CustomFormat = "yyyy-MM-dd";
            this._dtpWKDAY.DelegateProperty = true;
            this._dtpWKDAY.Enabled = false;
            this._dtpWKDAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpWKDAY.Location = new System.Drawing.Point(93, 3);
            this._dtpWKDAY.MaximumSize = new System.Drawing.Size(250, 20);
            this._dtpWKDAY.MinimumSize = new System.Drawing.Size(100, 20);
            this._dtpWKDAY.Name = "_dtpWKDAY";
            this._dtpWKDAY.ShowCheckBox = true;
            this._dtpWKDAY.Size = new System.Drawing.Size(130, 20);
            this._dtpWKDAY.TabIndex = 1000;
            this._dtpWKDAY.ValidationGroup = "a";
            this._dtpWKDAY.Value = new System.DateTime(2014, 7, 25, 10, 20, 16, 341);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "공휴일";
            // 
            // collapsibleSplitter1
            // 
            this.collapsibleSplitter1.AnimationDelay = 20;
            this.collapsibleSplitter1.AnimationStep = 20;
            this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
            this.collapsibleSplitter1.ControlToHide = this.groupBox2;
            this.collapsibleSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.collapsibleSplitter1.ExpandParentForm = false;
            this.collapsibleSplitter1.Location = new System.Drawing.Point(578, 54);
            this.collapsibleSplitter1.Name = "collapsibleSplitter1";
            this.collapsibleSplitter1.TabIndex = 4;
            this.collapsibleSplitter1.TabStop = false;
            this.collapsibleSplitter1.UseAnimations = false;
            this.collapsibleSplitter1.VisualStyle = DemoClient.Controls.VisualStyles.Mozilla;
            this.collapsibleSplitter1.DoubleClick += new System.EventHandler(this.collapsibleSplitter1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 569);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 결과";
            // 
            // gridView1
            // 
            this.gridView1.AutoSelectRowWithRightButton = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView1.ColumnHeadersHeight = 25;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WKDAY,
            this.WKMEMO,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
            this.gridView1.DelegateProperty = true;
            this.gridView1.Location = new System.Drawing.Point(3, 17);
            this.gridView1.MultiSelect = false;
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.Size = new System.Drawing.Size(572, 549);
            this.gridView1.TabIndex = 0;
            this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
            // 
            // WKDAY
            // 
            this.WKDAY.DataPropertyName = "WKDAY";
            this.WKDAY.HeaderText = "공휴일자";
            this.WKDAY.Name = "WKDAY";
            this.WKDAY.ReadOnly = true;
            this.WKDAY.Width = 76;
            // 
            // WKMEMO
            // 
            this.WKMEMO.DataPropertyName = "WKMEMO";
            this.WKMEMO.HeaderText = "메모";
            this.WKMEMO.Name = "WKMEMO";
            this.WKMEMO.ReadOnly = true;
            this.WKMEMO.Width = 54;
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
            // BAS0600
            // 
            this.ClientSize = new System.Drawing.Size(1135, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.collapsibleSplitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BAS0600";
            this.Text = "공휴일관리:BAS0600";
            this.Load += new System.EventHandler(this.BAS0600_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private DemoClient.Controls.BananaButton _btnSearch;
		private BANANA.Windows.Controls.Label label35;
		private System.Windows.Forms.GroupBox groupBox2;
		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnDel;
		private DemoClient.Controls.BananaButton _btnAdd;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.Label label11;
		private DemoClient.Controls.CollapsibleSplitter collapsibleSplitter1;
		private System.Windows.Forms.GroupBox groupBox3;
		private DemoClient.Controls.GridView gridView1;
		private BANANA.Windows.Controls.DateTimePicker _dtpWKDAY;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.TextBox _txtWKMEMO;
		private BANANA.Windows.Controls.ComboBox _cmbYear_S;
		private BANANA.Windows.Controls.Label _lblPRE_WKDAY;
		private System.Windows.Forms.DataGridViewTextBoxColumn WKDAY;
		private System.Windows.Forms.DataGridViewTextBoxColumn WKMEMO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;
	}
}
