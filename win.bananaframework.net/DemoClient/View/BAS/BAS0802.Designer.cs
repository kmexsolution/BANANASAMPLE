namespace DemoClient.View.BAS
{
	partial class BAS0802
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0802));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._cmbDOC_GUBUN_CD = new BANANA.Windows.Controls.ComboBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._txtFile = new BANANA.Windows.Controls.TextBox();
			this._btnFindFiles = new DemoClient.Controls.BananaButton();
			this._btnViewFile = new DemoClient.Controls.BananaButton();
			this._txtMEMO = new BANANA.Windows.Controls.TextBox();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this._lblStatus = new BANANA.Windows.Controls.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(566, 103);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "구비서류";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._cmbDOC_GUBUN_CD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 79);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 1016;
			this.label3.Text = "메모";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "파일선택";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "서류종류";
			// 
			// _cmbDOC_GUBUN_CD
			// 
			this._cmbDOC_GUBUN_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbDOC_GUBUN_CD.DataSource = null;
			this._cmbDOC_GUBUN_CD.DelegateProperty = true;
			this._cmbDOC_GUBUN_CD.Location = new System.Drawing.Point(93, 3);
			this._cmbDOC_GUBUN_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbDOC_GUBUN_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbDOC_GUBUN_CD.Name = "_cmbDOC_GUBUN_CD";
			this._cmbDOC_GUBUN_CD.SelectedIndex = -1;
			this._cmbDOC_GUBUN_CD.SelectedItem = null;
			this._cmbDOC_GUBUN_CD.SelectedValue = null;
			this._cmbDOC_GUBUN_CD.Size = new System.Drawing.Size(160, 21);
			this._cmbDOC_GUBUN_CD.TabIndex = 10;
			this._cmbDOC_GUBUN_CD.Text = "comboBox1";
			this._cmbDOC_GUBUN_CD.ValidationGroup = null;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._txtFile);
			this.flowLayoutPanel1.Controls.Add(this._btnFindFiles);
			this.flowLayoutPanel1.Controls.Add(this._btnViewFile);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 27);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 27);
			this.flowLayoutPanel1.TabIndex = 20;
			// 
			// _txtFile
			// 
			this._txtFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtFile.DelegateProperty = true;
			this._txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtFile.Location = new System.Drawing.Point(3, 5);
			this._txtFile.Name = "_txtFile";
			this._txtFile.ReadOnly = true;
			this._txtFile.Size = new System.Drawing.Size(340, 23);
			this._txtFile.TabIndex = 10;
			this._txtFile.ValidationGroup = null;
			this._txtFile.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtFile.WaterMarkText = "";
			// 
			// _btnFindFiles
			// 
			this._btnFindFiles.DelegateProperty = true;
			this._btnFindFiles.Location = new System.Drawing.Point(349, 5);
			this._btnFindFiles.Name = "_btnFindFiles";
			this._btnFindFiles.Size = new System.Drawing.Size(75, 23);
			this._btnFindFiles.TabIndex = 20;
			this._btnFindFiles.Text = "파일 찾기";
			this._btnFindFiles.UseVisualStyleBackColor = true;
			this._btnFindFiles.ValidationGroup = null;
			this._btnFindFiles.Click += new System.EventHandler(this._btnFindFiles_Click);
			// 
			// _btnViewFile
			// 
			this._btnViewFile.DelegateProperty = true;
			this._btnViewFile.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnViewFile.Location = new System.Drawing.Point(430, 5);
			this._btnViewFile.Name = "_btnViewFile";
			this._btnViewFile.Size = new System.Drawing.Size(27, 23);
			this._btnViewFile.TabIndex = 30;
			this._btnViewFile.UseVisualStyleBackColor = true;
			this._btnViewFile.ValidationGroup = null;
			this._btnViewFile.Visible = false;
			this._btnViewFile.Click += new System.EventHandler(this._btnViewFile_Click);
			// 
			// _txtMEMO
			// 
			this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMEMO.Location = new System.Drawing.Point(93, 57);
			this._txtMEMO.Name = "_txtMEMO";
			this._txtMEMO.Size = new System.Drawing.Size(458, 23);
			this._txtMEMO.TabIndex = 30;
			this._txtMEMO.ValidationGroup = null;
			this._txtMEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMEMO.WaterMarkText = "";
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(479, 109);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 50;
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
			this._btnSave.Location = new System.Drawing.Point(398, 109);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 40;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "구비서류 파일|*.doc;*.docx;*.ppt;*.pptx;*.xls;*.xlsx;*.pdf;*.hwp;*.jpg;*.jpeg;*.gif;*.p" +
    "ng;*.bmp;";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.Title = "구비서류 파일선택";
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBar1.Location = new System.Drawing.Point(0, 0);
			this.progressBar1.MarqueeAnimationSpeed = 10;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(328, 17);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this._lblStatus);
			this.panel1.Controls.Add(this.progressBar1);
			this.panel1.Location = new System.Drawing.Point(12, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 39);
			this.panel1.TabIndex = 1015;
			this.panel1.Visible = false;
			// 
			// _lblStatus
			// 
			this._lblStatus.AutoSize = true;
			this._lblStatus.DelegateProperty = true;
			this._lblStatus.Location = new System.Drawing.Point(290, 20);
			this._lblStatus.Name = "_lblStatus";
			this._lblStatus.Size = new System.Drawing.Size(45, 15);
			this._lblStatus.TabIndex = 6;
			this._lblStatus.Text = "label3";
			this._lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// BAS0802
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(566, 146);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0802";
			this.Text = "구비서류추가:BAS0802";
			this.Load += new System.EventHandler(this.BAS0802_Load);
			this.Shown += new System.EventHandler(this.BAS0802_Shown);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.ComboBox _cmbDOC_GUBUN_CD;
		private BANANA.Windows.Controls.TextBox _txtFile;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private DemoClient.Controls.BananaButton _btnFindFiles;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Panel panel1;
		private BANANA.Windows.Controls.Label _lblStatus;
		private System.Windows.Forms.Timer timer1;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.TextBox _txtMEMO;
		private DemoClient.Controls.BananaButton _btnViewFile;
	}
}
