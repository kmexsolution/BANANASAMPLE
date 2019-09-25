namespace DemoClient.View.BAS
{
	partial class BAS0807
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0807));
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtCI_LN_OVD = new BANANA.Windows.Controls.TextBox();
			this.label18 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.label13 = new BANANA.Windows.Controls.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtCI_LN_RATE = new BANANA.Windows.Controls.TextBox();
			this.label6 = new BANANA.Windows.Controls.Label();
			this.label11 = new BANANA.Windows.Controls.Label();
			this._dtpCI_APP_DT = new BANANA.Windows.Controls.DateTimePicker();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this._rbCI_LN_GUBUN01 = new BANANA.Windows.Controls.RadioButton();
			this._rbCI_LN_GUBUN02 = new BANANA.Windows.Controls.RadioButton();
			this.label10 = new BANANA.Windows.Controls.Label();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._cmbCI_LNR_CD = new BANANA.Windows.Controls.ComboBox();
			this.label12 = new BANANA.Windows.Controls.Label();
			this._cmbCI_AGT_CD = new BANANA.Windows.Controls.ComboBox();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this._dtpCI_APP_DT, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 3, 2);
			this.tableLayoutPanel3.Controls.Add(this.label10, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this._cmbCI_LNR_CD, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label12, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this._cmbCI_AGT_CD, 3, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 81);
			this.tableLayoutPanel3.TabIndex = 1106;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this._txtCI_LN_OVD);
			this.flowLayoutPanel4.Controls.Add(this.label18);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(320, 0);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(155, 27);
			this.flowLayoutPanel4.TabIndex = 110;
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
			this._txtCI_LN_OVD.Size = new System.Drawing.Size(90, 23);
			this._txtCI_LN_OVD.TabIndex = 20;
			this._txtCI_LN_OVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._txtCI_LN_OVD.ValidationGroup = "a";
			this._txtCI_LN_OVD.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCI_LN_OVD.WaterMarkText = "";
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(96, 7);
			this.label18.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(49, 15);
			this.label18.TabIndex = 10;
			this.label18.Text = "% / 년";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(235, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 1430;
			this.label2.Text = "연체이자율";
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
			this.flowLayoutPanel2.TabIndex = 100;
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
			this._txtCI_LN_RATE.Size = new System.Drawing.Size(90, 23);
			this._txtCI_LN_RATE.TabIndex = 10;
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
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(5, 33);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 15);
			this.label11.TabIndex = 10;
			this.label11.Text = "적용시작일";
			// 
			// _dtpCI_APP_DT
			// 
			this._dtpCI_APP_DT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpCI_APP_DT.Checked = false;
			this._dtpCI_APP_DT.Compulsory = true;
			this._dtpCI_APP_DT.CustomFormat = "yyyy-MM-dd";
			this._dtpCI_APP_DT.DelegateProperty = true;
			this._dtpCI_APP_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpCI_APP_DT.Location = new System.Drawing.Point(93, 30);
			this._dtpCI_APP_DT.Name = "_dtpCI_APP_DT";
			this._dtpCI_APP_DT.ShowCheckBox = true;
			this._dtpCI_APP_DT.Size = new System.Drawing.Size(130, 20);
			this._dtpCI_APP_DT.TabIndex = 30;
			this._dtpCI_APP_DT.ValidationGroup = "a";
			this._dtpCI_APP_DT.Value = new System.DateTime(2016, 9, 2, 10, 21, 21, 296);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this._rbCI_LN_GUBUN01);
			this.flowLayoutPanel3.Controls.Add(this._rbCI_LN_GUBUN02);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(320, 54);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.flowLayoutPanel3.Size = new System.Drawing.Size(155, 27);
			this.flowLayoutPanel3.TabIndex = 60;
			// 
			// _rbCI_LN_GUBUN01
			// 
			this._rbCI_LN_GUBUN01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._rbCI_LN_GUBUN01.AutoSize = true;
			this._rbCI_LN_GUBUN01.Checked = true;
			this._rbCI_LN_GUBUN01.DelegateProperty = true;
			this._rbCI_LN_GUBUN01.Location = new System.Drawing.Point(3, 6);
			this._rbCI_LN_GUBUN01.Name = "_rbCI_LN_GUBUN01";
			this._rbCI_LN_GUBUN01.Size = new System.Drawing.Size(88, 19);
			this._rbCI_LN_GUBUN01.TabIndex = 10;
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
			this._rbCI_LN_GUBUN02.Location = new System.Drawing.Point(3, 31);
			this._rbCI_LN_GUBUN02.Name = "_rbCI_LN_GUBUN02";
			this._rbCI_LN_GUBUN02.Size = new System.Drawing.Size(88, 19);
			this._rbCI_LN_GUBUN02.TabIndex = 20;
			this._rbCI_LN_GUBUN02.Text = "희망대출";
			this._rbCI_LN_GUBUN02.UseVisualStyleBackColor = true;
			this._rbCI_LN_GUBUN02.Visible = false;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(250, 60);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 1107;
			this.label10.Text = "대출구분";
			this.label10.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 1106;
			this.label1.Text = "여신사";
			// 
			// _cmbCI_LNR_CD
			// 
			this._cmbCI_LNR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbCI_LNR_CD.Compulsory = true;
			this._cmbCI_LNR_CD.DataSource = null;
			this._cmbCI_LNR_CD.DelegateProperty = true;
			this._cmbCI_LNR_CD.DroppedDown = false;
			this._cmbCI_LNR_CD.Location = new System.Drawing.Point(93, 57);
			this._cmbCI_LNR_CD.Name = "_cmbCI_LNR_CD";
			this._cmbCI_LNR_CD.SelectedIndex = -1;
			this._cmbCI_LNR_CD.SelectedItem = null;
			this._cmbCI_LNR_CD.SelectedValue = null;
			this._cmbCI_LNR_CD.Size = new System.Drawing.Size(130, 23);
			this._cmbCI_LNR_CD.TabIndex = 50;
			this._cmbCI_LNR_CD.ValidationGroup = "a";
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(235, 33);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 15);
			this.label12.TabIndex = 10;
			this.label12.Text = "수익대리점";
			// 
			// _cmbCI_AGT_CD
			// 
			this._cmbCI_AGT_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbCI_AGT_CD.DataSource = null;
			this._cmbCI_AGT_CD.DelegateProperty = true;
			this._cmbCI_AGT_CD.DroppedDown = false;
			this._cmbCI_AGT_CD.Location = new System.Drawing.Point(323, 30);
			this._cmbCI_AGT_CD.Name = "_cmbCI_AGT_CD";
			this._cmbCI_AGT_CD.SelectedIndex = -1;
			this._cmbCI_AGT_CD.SelectedItem = null;
			this._cmbCI_AGT_CD.SelectedValue = null;
			this._cmbCI_AGT_CD.Size = new System.Drawing.Size(130, 23);
			this._cmbCI_AGT_CD.TabIndex = 40;
			this._cmbCI_AGT_CD.ValidationGroup = null;
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(392, 87);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Reserved = "      닫   기";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 80;
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
			this._btnSave.Location = new System.Drawing.Point(311, 87);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Reserved = "      저   장";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 70;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// BAS0807
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(475, 125);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0807";
			this.Text = "대출이자율등록:BAS0807";
			this.Load += new System.EventHandler(this.BAS0807_Load);
			this.Shown += new System.EventHandler(this.BAS0807_Shown);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private BANANA.Windows.Controls.RadioButton _rbCI_LN_GUBUN01;
		private BANANA.Windows.Controls.RadioButton _rbCI_LN_GUBUN02;
		private BANANA.Windows.Controls.Label label10;
		private BANANA.Windows.Controls.ComboBox _cmbCI_LNR_CD;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.ComboBox _cmbCI_AGT_CD;
		private BANANA.Windows.Controls.Label label12;
		private BANANA.Windows.Controls.Label label13;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private BANANA.Windows.Controls.TextBox _txtCI_LN_RATE;
		private BANANA.Windows.Controls.Label label6;
		private BANANA.Windows.Controls.DateTimePicker _dtpCI_APP_DT;
		private BANANA.Windows.Controls.Label label11;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
		private BANANA.Windows.Controls.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private BANANA.Windows.Controls.TextBox _txtCI_LN_OVD;
		private BANANA.Windows.Controls.Label label18;
	}
}
