namespace DemoClient.View.Common
{
	partial class STR_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STR_Form));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this._txtSTR_NM = new BANANA.Windows.Controls.TextBox();
			this.label35 = new BANANA.Windows.Controls.Label();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.STR_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STR_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRSNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ADDR_BSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BI_BINF_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BI_SAUP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FAXNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(982, 47);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "검색 조건";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Controls.Add(this._txtSTR_NM, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this._btnSearch, 2, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(976, 23);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// _txtSTR_NM
			// 
			this._txtSTR_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtSTR_NM.AutoTab = false;
			this._txtSTR_NM.DelegateProperty = true;
			this._txtSTR_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtSTR_NM.Location = new System.Drawing.Point(93, 3);
			this._txtSTR_NM.Name = "_txtSTR_NM";
			this._txtSTR_NM.Size = new System.Drawing.Size(120, 23);
			this._txtSTR_NM.TabIndex = 100;
			this._txtSTR_NM.ValidationGroup = null;
			this._txtSTR_NM.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtSTR_NM.WaterMarkText = "";
			this._txtSTR_NM.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtSTR_NM_KeyDown);
			// 
			// label35
			// 
			this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(20, 7);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(67, 15);
			this.label35.TabIndex = 1114;
			this.label35.Text = "가맹점명";
			// 
			// _btnSearch
			// 
			this._btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnSearch.DelegateProperty = true;
			this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.Location = new System.Drawing.Point(220, 1);
			this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
			this._btnSearch.Name = "_btnSearch";
			this._btnSearch.Reserved = "      검   색";
			this._btnSearch.Size = new System.Drawing.Size(75, 27);
			this._btnSearch.TabIndex = 1117;
			this._btnSearch.Text = "      검   색";
			this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.UseVisualStyleBackColor = true;
			this._btnSearch.ValidationGroup = null;
			this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridView1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 47);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(982, 406);
			this.groupBox3.TabIndex = 32;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "가맹점목록";
			// 
			// gridView1
			// 
			this.gridView1.AutoSelectRowWithRightButton = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView1.ColumnHeadersHeight = 50;
			this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STR_CD,
            this.STR_NM,
            this.PRSNT_NM,
            this.ADDR_BSC,
            this.BI_BINF_CD,
            this.BI_SAUP_NO,
            this.TELNO,
            this.FAXNO});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 21);
			this.gridView1.MultiSelect = false;
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(976, 382);
			this.gridView1.TabIndex = 0;
			this.gridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellDoubleClick);
			// 
			// STR_CD
			// 
			this.STR_CD.DataPropertyName = "STR_CD";
			this.STR_CD.Frozen = true;
			this.STR_CD.HeaderText = "가맹점코드";
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Width = 108;
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
			// PRSNT_NM
			// 
			this.PRSNT_NM.DataPropertyName = "PRSNT_NM";
			this.PRSNT_NM.Frozen = true;
			this.PRSNT_NM.HeaderText = "대표자명";
			this.PRSNT_NM.Name = "PRSNT_NM";
			this.PRSNT_NM.ReadOnly = true;
			this.PRSNT_NM.Width = 94;
			// 
			// ADDR_BSC
			// 
			this.ADDR_BSC.DataPropertyName = "ADDR_BSC";
			this.ADDR_BSC.Frozen = true;
			this.ADDR_BSC.HeaderText = "기본주소";
			this.ADDR_BSC.Name = "ADDR_BSC";
			this.ADDR_BSC.ReadOnly = true;
			this.ADDR_BSC.Width = 94;
			// 
			// BI_BINF_CD
			// 
			this.BI_BINF_CD.DataPropertyName = "BI_BINF_CD";
			this.BI_BINF_CD.Frozen = true;
			this.BI_BINF_CD.HeaderText = "사업자구분";
			this.BI_BINF_CD.Name = "BI_BINF_CD";
			this.BI_BINF_CD.ReadOnly = true;
			this.BI_BINF_CD.Width = 108;
			// 
			// BI_SAUP_NO
			// 
			this.BI_SAUP_NO.DataPropertyName = "BI_SAUP_NO";
			this.BI_SAUP_NO.Frozen = true;
			this.BI_SAUP_NO.HeaderText = "사업자등록번호";
			this.BI_SAUP_NO.Name = "BI_SAUP_NO";
			this.BI_SAUP_NO.ReadOnly = true;
			this.BI_SAUP_NO.Width = 136;
			// 
			// TELNO
			// 
			this.TELNO.DataPropertyName = "TELNO";
			this.TELNO.Frozen = true;
			this.TELNO.HeaderText = "전화번호";
			this.TELNO.Name = "TELNO";
			this.TELNO.ReadOnly = true;
			this.TELNO.Width = 94;
			// 
			// FAXNO
			// 
			this.FAXNO.DataPropertyName = "FAXNO";
			this.FAXNO.Frozen = true;
			this.FAXNO.HeaderText = "팩스번호";
			this.FAXNO.Name = "FAXNO";
			this.FAXNO.ReadOnly = true;
			this.FAXNO.Width = 94;
			// 
			// STR_Form
			// 
			this.ClientSize = new System.Drawing.Size(982, 453);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "STR_Form";
			this.Text = "가맹점검색";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private BANANA.Windows.Controls.TextBox _txtSTR_NM;
		private BANANA.Windows.Controls.Label label35;
		private DemoClient.Controls.BananaButton _btnSearch;
		private BANANA.Windows.Controls.GroupBox groupBox3;
		private DemoClient.Controls.GridView gridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn STR_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn STR_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRSNT_NM;
		private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_BSC;
		private System.Windows.Forms.DataGridViewTextBoxColumn BI_BINF_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn BI_SAUP_NO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FAXNO;
	}
}
