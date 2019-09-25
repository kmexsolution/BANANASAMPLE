namespace DemoClient.View.BAS
{
	partial class BAS0610
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0610));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._txtWKMEMO = new BANANA.Windows.Controls.TextBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._dtpWKDAY = new BANANA.Windows.Controls.DateTimePicker();
			this.label11 = new BANANA.Windows.Controls.Label();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(551, 57);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "상세 정보";
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 27);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// _txtWKMEMO
			// 
			this._txtWKMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtWKMEMO.DelegateProperty = true;
			this._txtWKMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtWKMEMO.Location = new System.Drawing.Point(323, 3);
			this._txtWKMEMO.Name = "_txtWKMEMO";
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
			this.label1.Size = new System.Drawing.Size(29, 13);
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
			this.label11.Location = new System.Drawing.Point(47, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "공휴일";
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(461, 63);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 1012;
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
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(380, 63);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 1011;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// BAS0610
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(551, 105);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0610";
			this.Text = "공휴일추가:BAS0610";
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.TextBox _txtWKMEMO;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.DateTimePicker _dtpWKDAY;
		private BANANA.Windows.Controls.Label label11;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
	}
}
