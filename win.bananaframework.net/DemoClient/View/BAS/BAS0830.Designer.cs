namespace DemoClient.View.BAS
{
	partial class BAS0830
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0830));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new BANANA.Windows.Controls.Label();
			this._cmbMNS_PROCESS_CD = new BANANA.Windows.Controls.ComboBox();
			this.label3 = new BANANA.Windows.Controls.Label();
			this._txtMNS_ACTN_AMT = new BANANA.Windows.Controls.TextBox();
			this._dtpMNS_DT = new BANANA.Windows.Controls.DateTimePicker();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.label1 = new BANANA.Windows.Controls.Label();
			this.MEMO = new BANANA.Windows.Controls.TextBox();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 209);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "차감내역";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._cmbMNS_PROCESS_CD, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtMNS_ACTN_AMT, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._dtpMNS_DT, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.MEMO, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 185);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 1119;
			this.label5.Text = "메모";
			// 
			// _cmbMNS_PROCESS_CD
			// 
			this._cmbMNS_PROCESS_CD.DataSource = null;
			this._cmbMNS_PROCESS_CD.DelegateProperty = true;
			this._cmbMNS_PROCESS_CD.Location = new System.Drawing.Point(93, 57);
			this._cmbMNS_PROCESS_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbMNS_PROCESS_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbMNS_PROCESS_CD.Name = "_cmbMNS_PROCESS_CD";
			this._cmbMNS_PROCESS_CD.SelectedIndex = -1;
			this._cmbMNS_PROCESS_CD.SelectedItem = null;
			this._cmbMNS_PROCESS_CD.SelectedValue = null;
			this._cmbMNS_PROCESS_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbMNS_PROCESS_CD.TabIndex = 253;
			this._cmbMNS_PROCESS_CD.ValidationGroup = null;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 1004;
			this.label3.Text = "처리방법";
			// 
			// _txtMNS_ACTN_AMT
			// 
			this._txtMNS_ACTN_AMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMNS_ACTN_AMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMNS_ACTN_AMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtMNS_ACTN_AMT.Location = new System.Drawing.Point(93, 30);
			this._txtMNS_ACTN_AMT.Name = "_txtMNS_ACTN_AMT";
			this._txtMNS_ACTN_AMT.Size = new System.Drawing.Size(130, 23);
			this._txtMNS_ACTN_AMT.TabIndex = 151;
			this._txtMNS_ACTN_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtMNS_ACTN_AMT.ValidationGroup = "A";
			this._txtMNS_ACTN_AMT.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMNS_ACTN_AMT.WaterMarkText = "";
			// 
			// _dtpMNS_DT
			// 
			this._dtpMNS_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpMNS_DT.Checked = false;
			this._dtpMNS_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpMNS_DT.DelegateProperty = true;
			this._dtpMNS_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpMNS_DT.Location = new System.Drawing.Point(93, 3);
			this._dtpMNS_DT.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpMNS_DT.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpMNS_DT.Name = "_dtpMNS_DT";
			this._dtpMNS_DT.Size = new System.Drawing.Size(130, 21);
			this._dtpMNS_DT.TabIndex = 1003;
			this._dtpMNS_DT.ValidationGroup = "a";
			this._dtpMNS_DT.Value = new System.DateTime(2016, 8, 17, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "처리금액";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "처리일자";
			// 
			// MEMO
			// 
			this.MEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.MEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.MEMO.Location = new System.Drawing.Point(93, 86);
			this.MEMO.Multiline = true;
			this.MEMO.Name = "MEMO";
			this.MEMO.Size = new System.Drawing.Size(262, 94);
			this.MEMO.TabIndex = 1119;
			this.MEMO.ValidationGroup = "A";
			this.MEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this.MEMO.WaterMarkText = "";
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(202, 215);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 251;
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
			this._btnClose.Location = new System.Drawing.Point(283, 215);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 252;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// BAS0830
			// 
			this.ClientSize = new System.Drawing.Size(370, 250);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0830";
			this.Text = "차감수기입력 : BAS0830";
			this.Load += new System.EventHandler(this.BAS0830_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.DateTimePicker _dtpMNS_DT;
		private BANANA.Windows.Controls.TextBox _txtMNS_ACTN_AMT;
		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnClose;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.ComboBox _cmbMNS_PROCESS_CD;
		private BANANA.Windows.Controls.Label label5;
		public BANANA.Windows.Controls.TextBox MEMO;
	}
}
