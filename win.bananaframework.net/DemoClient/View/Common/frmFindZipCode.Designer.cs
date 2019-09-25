namespace DemoClient.View.Common
{
	partial class frmFindZipCode
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindZipCode));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this._txtAddress = new BANANA.Windows.Controls.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._pnlLoading = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressDoro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressJibun = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._flpArea = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this._pnlLoading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this._btnSearch);
			this.groupBox1.Controls.Add(this._txtAddress);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(744, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "우편번호 검색";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(468, 26);
			this.label1.TabIndex = 402;
			this.label1.Text = "지역명에 번지수/건물번호/건물명을 붙여서 검색하면, 보다 빠르게 결과를 확인할 수 있습니다.\r\n검색결과를 더블 클릭하면, 적용이 됩니다.";
			// 
			// _btnSearch
			// 
			this._btnSearch.DelegateProperty = true;
			this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.Location = new System.Drawing.Point(521, 19);
			this._btnSearch.Name = "_btnSearch";
			this._btnSearch.Size = new System.Drawing.Size(75, 27);
			this._btnSearch.TabIndex = 401;
			this._btnSearch.Text = "      검   색";
			this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.UseVisualStyleBackColor = true;
			this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
			// 
			// _txtAddress
			// 
			this._txtAddress.AutoTab = false;
			this._txtAddress.DelegateProperty = true;
			this._txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this._txtAddress.Location = new System.Drawing.Point(133, 20);
			this._txtAddress.Name = "_txtAddress";
			this._txtAddress.Size = new System.Drawing.Size(382, 26);
			this._txtAddress.TabIndex = 1;
			this._txtAddress.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtAddress.WaterMarkText = "";
			this._txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtAddress_KeyDown);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this._pnlLoading);
			this.groupBox2.Controls.Add(this.gridView1);
			this.groupBox2.Controls.Add(this._flpArea);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(744, 361);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "검색 결과";
			// 
			// _pnlLoading
			// 
			this._pnlLoading.BackColor = System.Drawing.Color.White;
			this._pnlLoading.Controls.Add(this.label2);
			this._pnlLoading.Controls.Add(this.pictureBox1);
			this._pnlLoading.Location = new System.Drawing.Point(284, 120);
			this._pnlLoading.Name = "_pnlLoading";
			this._pnlLoading.Size = new System.Drawing.Size(200, 48);
			this._pnlLoading.TabIndex = 3;
			this._pnlLoading.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "검색 중입니다. 잠시만 기다려 주세요.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DemoClient.Properties.Resources.ajax_loader;
			this.pictureBox1.Location = new System.Drawing.Point(35, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(126, 22);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
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
            this.ZipCode,
            this.AddressDoro,
            this.AddressJibun});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridView1.Location = new System.Drawing.Point(3, 46);
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(738, 312);
			this.gridView1.TabIndex = 1;
			this.gridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellDoubleClick);
			// 
			// ZipCode
			// 
			this.ZipCode.DataPropertyName = "ZipCode";
			this.ZipCode.HeaderText = "우편번호";
			this.ZipCode.Name = "ZipCode";
			this.ZipCode.ReadOnly = true;
			this.ZipCode.Width = 76;
			// 
			// AddressDoro
			// 
			this.AddressDoro.DataPropertyName = "AddressDoro";
			this.AddressDoro.HeaderText = "도로명";
			this.AddressDoro.Name = "AddressDoro";
			this.AddressDoro.ReadOnly = true;
			this.AddressDoro.Width = 65;
			// 
			// AddressJibun
			// 
			this.AddressJibun.DataPropertyName = "AddressJibun";
			this.AddressJibun.HeaderText = "지번";
			this.AddressJibun.Name = "AddressJibun";
			this.AddressJibun.ReadOnly = true;
			this.AddressJibun.Width = 54;
			// 
			// _flpArea
			// 
			this._flpArea.Dock = System.Windows.Forms.DockStyle.Top;
			this._flpArea.Location = new System.Drawing.Point(3, 16);
			this._flpArea.Name = "_flpArea";
			this._flpArea.Size = new System.Drawing.Size(738, 30);
			this._flpArea.TabIndex = 0;
			// 
			// frmFindZipCode
			// 
			this.ClientSize = new System.Drawing.Size(744, 461);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmFindZipCode";
			this.Text = "우편번호검색:frmFindZipCode";
			this.Load += new System.EventHandler(this.frmFindZipCode_Load);
			this.Shown += new System.EventHandler(this.frmFindZipCode_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this._pnlLoading.ResumeLayout(false);
			this._pnlLoading.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private BANANA.Windows.Controls.TextBox _txtAddress;
		private DemoClient.Controls.BananaButton _btnSearch;
		private System.Windows.Forms.Label label1;
		private DemoClient.Controls.GridView gridView1;
		private System.Windows.Forms.FlowLayoutPanel _flpArea;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel _pnlLoading;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressDoro;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressJibun;
	}
}
