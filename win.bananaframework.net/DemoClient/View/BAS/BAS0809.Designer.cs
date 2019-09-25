namespace DemoClient.View.BAS
{
	partial class BAS0809
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0809));
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label21 = new BANANA.Windows.Controls.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._txtCI_DAILY_LMT = new BANANA.Windows.Controls.TextBox();
			this._txtCI_UNIT_LMT = new BANANA.Windows.Controls.TextBox();
			this._dtpCI_LMT_APP_DT = new BANANA.Windows.Controls.DateTimePicker();
			this.label25 = new BANANA.Windows.Controls.Label();
			this.label19 = new BANANA.Windows.Controls.Label();
			this._txtCI_TOT_LMT = new BANANA.Windows.Controls.TextBox();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Controls.Add(this.label21, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this._txtCI_DAILY_LMT, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this._txtCI_UNIT_LMT, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this._dtpCI_LMT_APP_DT, 3, 1);
			this.tableLayoutPanel4.Controls.Add(this.label25, 2, 1);
			this.tableLayoutPanel4.Controls.Add(this.label19, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this._txtCI_TOT_LMT, 1, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(465, 54);
			this.tableLayoutPanel4.TabIndex = 5;
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
			this._txtCI_UNIT_LMT.Size = new System.Drawing.Size(130, 20);
			this._txtCI_UNIT_LMT.TabIndex = 100;
			this._txtCI_UNIT_LMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_UNIT_LMT.ValidationGroup = "a";
			this._txtCI_UNIT_LMT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_UNIT_LMT.WaterMarkText = "";
			// 
			// _dtpCI_LMT_APP_DT
			// 
			this._dtpCI_LMT_APP_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpCI_LMT_APP_DT.Checked = false;
			this._dtpCI_LMT_APP_DT.Compulsory = true;
			this._dtpCI_LMT_APP_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpCI_LMT_APP_DT.DelegateProperty = true;
			this._dtpCI_LMT_APP_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpCI_LMT_APP_DT.Location = new System.Drawing.Point(323, 30);
			this._dtpCI_LMT_APP_DT.Name = "_dtpCI_LMT_APP_DT";
			this._dtpCI_LMT_APP_DT.ShowCheckBox = true;
			this._dtpCI_LMT_APP_DT.Size = new System.Drawing.Size(130, 20);
			this._dtpCI_LMT_APP_DT.TabIndex = 130;
			this._dtpCI_LMT_APP_DT.ValidationGroup = "a";
			// 
			// label25
			// 
			this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(255, 34);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(62, 13);
			this.label25.TabIndex = 0;
			this.label25.Text = "적용시작일";
			// 
			// label19
			// 
			this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(25, 34);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(62, 13);
			this.label19.TabIndex = 10;
			this.label19.Text = "총대출한도";
			// 
			// _txtCI_TOT_LMT
			// 
			this._txtCI_TOT_LMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCI_TOT_LMT.Compulsory = true;
			this._txtCI_TOT_LMT.DelegateProperty = true;
			this._txtCI_TOT_LMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCI_TOT_LMT.ImeMode = BANANA.Windows.Controls.ImeMode.Integer;
			this._txtCI_TOT_LMT.Location = new System.Drawing.Point(93, 30);
			this._txtCI_TOT_LMT.Name = "_txtCI_TOT_LMT";
			this._txtCI_TOT_LMT.Size = new System.Drawing.Size(130, 20);
			this._txtCI_TOT_LMT.TabIndex = 120;
			this._txtCI_TOT_LMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_TOT_LMT.ValidationGroup = "a";
			this._txtCI_TOT_LMT.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_TOT_LMT.WaterMarkText = "";
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(378, 60);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 172;
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
			this._btnSave.Location = new System.Drawing.Point(297, 60);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 171;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// BAS0809
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(465, 97);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0809";
			this.Text = "대출한도등록:BAS0809";
			this.Load += new System.EventHandler(this.BAS0809_Load);
			this.Shown += new System.EventHandler(this.BAS0809_Shown);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private BANANA.Windows.Controls.Label label21;
		private System.Windows.Forms.Label label4;
		private BANANA.Windows.Controls.TextBox _txtCI_DAILY_LMT;
		private BANANA.Windows.Controls.TextBox _txtCI_UNIT_LMT;
		private BANANA.Windows.Controls.DateTimePicker _dtpCI_LMT_APP_DT;
		private BANANA.Windows.Controls.Label label25;
		private BANANA.Windows.Controls.Label label19;
		private BANANA.Windows.Controls.TextBox _txtCI_TOT_LMT;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
	}
}
