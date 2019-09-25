namespace DemoClient.View.HLP
{
	partial class HLP0300
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP0300));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new DemoClient.Controls.TableLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this._btnAdd = new DemoClient.Controls.BananaButton();
			this._btnExcel = new DemoClient.Controls.BananaButton();
			this.label37 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._dtpREGDATE_S_S = new BANANA.Windows.Controls.DateTimePicker();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._dtpREGDATE_E_S = new BANANA.Windows.Controls.DateTimePicker();
			this.label35 = new BANANA.Windows.Controls.Label();
			this._txtTITLE_S = new BANANA.Windows.Controls.TextBox();
			this.label2 = new BANANA.Windows.Controls.Label();
			this._cmbGUBUN_S = new BANANA.Windows.Controls.ComboBox();
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.IDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLICK_CNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GUBUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISPLAY_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSREGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SYSMODNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(1354, 53);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "검색 조건";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel6.ColumnCount = 7;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel4, 6, 0);
			this.tableLayoutPanel6.Controls.Add(this.label37, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.label35, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this._txtTITLE_S, 3, 0);
			this.tableLayoutPanel6.Controls.Add(this.label2, 4, 0);
			this.tableLayoutPanel6.Controls.Add(this._cmbGUBUN_S, 5, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1348, 29);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._btnSearch);
			this.flowLayoutPanel4.Controls.Add(this._btnAdd);
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
			this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
			// 
			// _btnAdd
			// 
			this._btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnAdd.DelegateProperty = true;
			this._btnAdd.Image = global::DemoClient.Properties.Resources._1377801089_62655;
			this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnAdd.Location = new System.Drawing.Point(75, 2);
			this._btnAdd.Margin = new System.Windows.Forms.Padding(0);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Reserved = "      추   가";
			this._btnAdd.Size = new System.Drawing.Size(75, 23);
			this._btnAdd.TabIndex = 21;
			this._btnAdd.Text = "      추   가";
			this._btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.ValidationGroup = null;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// _btnExcel
			// 
			this._btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnExcel.DelegateProperty = true;
			this._btnExcel.Image = global::DemoClient.Properties.Resources.EXCEL_0002;
			this._btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnExcel.Location = new System.Drawing.Point(150, 2);
			this._btnExcel.Margin = new System.Windows.Forms.Padding(0);
			this._btnExcel.Name = "_btnExcel";
			this._btnExcel.Reserved = "      엑   셀";
			this._btnExcel.Size = new System.Drawing.Size(75, 23);
			this._btnExcel.TabIndex = 20;
			this._btnExcel.Text = "      엑   셀";
			this._btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnExcel.UseVisualStyleBackColor = true;
			this._btnExcel.ValidationGroup = null;
			this._btnExcel.Click += new System.EventHandler(this._btnExcel_Click);
			// 
			// label37
			// 
			this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(21, 7);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(67, 15);
			this.label37.TabIndex = 1116;
			this.label37.Text = "등록일자";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._dtpREGDATE_S_S);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._dtpREGDATE_E_S);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(92, 1);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 27);
			this.flowLayoutPanel1.TabIndex = 120;
			// 
			// _dtpREGDATE_S_S
			// 
			this._dtpREGDATE_S_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpREGDATE_S_S.Checked = false;
			this._dtpREGDATE_S_S.CustomFormat = "yyyy-MM-dd";
			this._dtpREGDATE_S_S.DelegateProperty = true;
			this._dtpREGDATE_S_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpREGDATE_S_S.Location = new System.Drawing.Point(3, 3);
			this._dtpREGDATE_S_S.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpREGDATE_S_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpREGDATE_S_S.Name = "_dtpREGDATE_S_S";
			this._dtpREGDATE_S_S.Size = new System.Drawing.Size(150, 21);
			this._dtpREGDATE_S_S.TabIndex = 10;
			this._dtpREGDATE_S_S.ValidationGroup = null;
			this._dtpREGDATE_S_S.Value = new System.DateTime(2014, 7, 26, 13, 51, 32, 431);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "~";
			// 
			// _dtpREGDATE_E_S
			// 
			this._dtpREGDATE_E_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpREGDATE_E_S.Checked = false;
			this._dtpREGDATE_E_S.CustomFormat = "yyyy-MM-dd";
			this._dtpREGDATE_E_S.DelegateProperty = true;
			this._dtpREGDATE_E_S.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpREGDATE_E_S.Location = new System.Drawing.Point(183, 3);
			this._dtpREGDATE_E_S.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpREGDATE_E_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpREGDATE_E_S.Name = "_dtpREGDATE_E_S";
			this._dtpREGDATE_E_S.Size = new System.Drawing.Size(150, 21);
			this._dtpREGDATE_E_S.TabIndex = 20;
			this._dtpREGDATE_E_S.ValidationGroup = null;
			this._dtpREGDATE_E_S.Value = new System.DateTime(2014, 7, 26, 13, 51, 32, 431);
			// 
			// label35
			// 
			this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(483, 7);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(37, 15);
			this.label35.TabIndex = 1114;
			this.label35.Text = "제목";
			// 
			// _txtTITLE_S
			// 
			this._txtTITLE_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtTITLE_S.AutoTab = false;
			this._txtTITLE_S.DelegateProperty = true;
			this._txtTITLE_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtTITLE_S.Location = new System.Drawing.Point(527, 4);
			this._txtTITLE_S.Name = "_txtTITLE_S";
			this._txtTITLE_S.Size = new System.Drawing.Size(120, 23);
			this._txtTITLE_S.TabIndex = 100;
			this._txtTITLE_S.ValidationGroup = null;
			this._txtTITLE_S.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtTITLE_S.WaterMarkText = "";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(705, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 1115;
			this.label2.Text = "구분";
			// 
			// _cmbGUBUN_S
			// 
			this._cmbGUBUN_S.DataSource = null;
			this._cmbGUBUN_S.DelegateProperty = true;
			this._cmbGUBUN_S.DroppedDown = false;
			this._cmbGUBUN_S.Location = new System.Drawing.Point(749, 4);
			this._cmbGUBUN_S.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbGUBUN_S.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbGUBUN_S.Name = "_cmbGUBUN_S";
			this._cmbGUBUN_S.SelectedIndex = -1;
			this._cmbGUBUN_S.SelectedItem = null;
			this._cmbGUBUN_S.SelectedValue = null;
			this._cmbGUBUN_S.Size = new System.Drawing.Size(120, 23);
			this._cmbGUBUN_S.TabIndex = 130;
			this._cmbGUBUN_S.ValidationGroup = null;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridView1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 53);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1354, 680);
			this.groupBox3.TabIndex = 4;
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
            this.IDX,
            this.TITLE,
            this.CLICK_CNT,
            this.GUBUN,
            this.DISPLAY_YN,
            this.SYSREGDATE,
            this.SYSREGNAME,
            this.SYSMODDATE,
            this.SYSMODNAME});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 21);
			this.gridView1.MultiSelect = false;
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(1348, 656);
			this.gridView1.TabIndex = 0;
			this.gridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellDoubleClick);
			// 
			// IDX
			// 
			this.IDX.DataPropertyName = "IDX";
			this.IDX.Frozen = true;
			this.IDX.HeaderText = "일련번호";
			this.IDX.Name = "IDX";
			this.IDX.ReadOnly = true;
			this.IDX.Width = 94;
			// 
			// TITLE
			// 
			this.TITLE.DataPropertyName = "TITLE";
			this.TITLE.Frozen = true;
			this.TITLE.HeaderText = "제목";
			this.TITLE.Name = "TITLE";
			this.TITLE.ReadOnly = true;
			this.TITLE.Width = 66;
			// 
			// CLICK_CNT
			// 
			this.CLICK_CNT.DataPropertyName = "CLICK_CNT";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			this.CLICK_CNT.DefaultCellStyle = dataGridViewCellStyle2;
			this.CLICK_CNT.HeaderText = "조회수";
			this.CLICK_CNT.Name = "CLICK_CNT";
			this.CLICK_CNT.ReadOnly = true;
			this.CLICK_CNT.Width = 80;
			// 
			// GUBUN
			// 
			this.GUBUN.DataPropertyName = "GUBUN";
			this.GUBUN.HeaderText = "구분";
			this.GUBUN.Name = "GUBUN";
			this.GUBUN.ReadOnly = true;
			this.GUBUN.Width = 66;
			// 
			// DISPLAY_YN
			// 
			this.DISPLAY_YN.DataPropertyName = "DISPLAY_YN";
			this.DISPLAY_YN.HeaderText = "출력여부";
			this.DISPLAY_YN.Name = "DISPLAY_YN";
			this.DISPLAY_YN.ReadOnly = true;
			this.DISPLAY_YN.Width = 94;
			// 
			// SYSREGDATE
			// 
			this.SYSREGDATE.DataPropertyName = "SYSREGDATE";
			this.SYSREGDATE.HeaderText = "등록일";
			this.SYSREGDATE.Name = "SYSREGDATE";
			this.SYSREGDATE.ReadOnly = true;
			this.SYSREGDATE.Width = 80;
			// 
			// SYSREGNAME
			// 
			this.SYSREGNAME.DataPropertyName = "SYSREGNAME";
			this.SYSREGNAME.HeaderText = "등록자";
			this.SYSREGNAME.Name = "SYSREGNAME";
			this.SYSREGNAME.ReadOnly = true;
			this.SYSREGNAME.Width = 80;
			// 
			// SYSMODDATE
			// 
			this.SYSMODDATE.DataPropertyName = "SYSMODDATE";
			this.SYSMODDATE.HeaderText = "수정일";
			this.SYSMODDATE.Name = "SYSMODDATE";
			this.SYSMODDATE.ReadOnly = true;
			this.SYSMODDATE.Width = 80;
			// 
			// SYSMODNAME
			// 
			this.SYSMODNAME.DataPropertyName = "SYSMODNAME";
			this.SYSMODNAME.HeaderText = "수정자";
			this.SYSMODNAME.Name = "SYSMODNAME";
			this.SYSMODNAME.ReadOnly = true;
			this.SYSMODNAME.Width = 80;
			// 
			// HLP0300
			// 
			this.ClientSize = new System.Drawing.Size(1354, 733);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HLP0300";
			this.Text = "공지사항:HPL0300";
			this.Load += new System.EventHandler(this.HLP0300_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Controls.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private DemoClient.Controls.BananaButton _btnSearch;
		private DemoClient.Controls.BananaButton _btnExcel;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.TextBox _txtTITLE_S;
		private BANANA.Windows.Controls.Label label35;
		private BANANA.Windows.Controls.Label label37;
		private BANANA.Windows.Controls.ComboBox _cmbGUBUN_S;
		private BANANA.Windows.Controls.GroupBox groupBox3;
		private DemoClient.Controls.GridView gridView1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private BANANA.Windows.Controls.DateTimePicker _dtpREGDATE_S_S;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.DateTimePicker _dtpREGDATE_E_S;
		private DemoClient.Controls.BananaButton _btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDX;
		private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLICK_CNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn GUBUN;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISPLAY_YN;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSREGNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODDATE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SYSMODNAME;

	}
}
