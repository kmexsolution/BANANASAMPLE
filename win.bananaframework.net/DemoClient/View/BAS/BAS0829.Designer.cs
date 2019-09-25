namespace DemoClient.View.BAS
{
	partial class BAS0829
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0829));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._cmbVAN_CD = new BANANA.Windows.Controls.ComboBox();
			this.label4 = new BANANA.Windows.Controls.Label();
			this.label3 = new BANANA.Windows.Controls.Label();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._txtUSER_ID = new BANANA.Windows.Controls.TextBox();
			this._txtUSER_PW = new BANANA.Windows.Controls.TextBox();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.label2 = new BANANA.Windows.Controls.Label();
			this._chkSYSUSEYN = new BANANA.Windows.Controls.CheckBox();
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
			this.groupBox1.Size = new System.Drawing.Size(508, 153);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "로그인 정보";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel1.Controls.Add(this._chkSYSUSEYN, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._cmbVAN_CD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtUSER_ID, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtUSER_PW, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 129);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _cmbVAN_CD
			// 
			this._cmbVAN_CD.DataSource = null;
			this._cmbVAN_CD.DroppedDown = false;
			this._cmbVAN_CD.Location = new System.Drawing.Point(93, 3);
			this._cmbVAN_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbVAN_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbVAN_CD.Name = "_cmbVAN_CD";
			this._cmbVAN_CD.SelectedIndex = -1;
			this._cmbVAN_CD.SelectedItem = null;
			this._cmbVAN_CD.SelectedValue = null;
			this._cmbVAN_CD.Size = new System.Drawing.Size(130, 23);
			this._cmbVAN_CD.TabIndex = 1141;
			this._cmbVAN_CD.ValidationGroup = null;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "비밀번호";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "로그인 ID";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Van";
			// 
			// _txtUSER_ID
			// 
			this._txtUSER_ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtUSER_ID.Compulsory = true;
			this._txtUSER_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtUSER_ID.Location = new System.Drawing.Point(93, 30);
			this._txtUSER_ID.Name = "_txtUSER_ID";
			this._txtUSER_ID.Size = new System.Drawing.Size(150, 23);
			this._txtUSER_ID.TabIndex = 30;
			this._txtUSER_ID.ValidationGroup = "a";
			this._txtUSER_ID.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtUSER_ID.WaterMarkText = "";
			// 
			// _txtUSER_PW
			// 
			this._txtUSER_PW.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtUSER_PW.Compulsory = true;
			this._txtUSER_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtUSER_PW.Location = new System.Drawing.Point(93, 57);
			this._txtUSER_PW.Name = "_txtUSER_PW";
			this._txtUSER_PW.Size = new System.Drawing.Size(150, 23);
			this._txtUSER_PW.TabIndex = 31;
			this._txtUSER_PW.ValidationGroup = "a";
			this._txtUSER_PW.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtUSER_PW.WaterMarkText = "";
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(421, 206);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Reserved = "      닫   기";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 62;
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
			this._btnSave.Location = new System.Drawing.Point(340, 206);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Reserved = "      저   장";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 61;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1142;
			this.label2.Text = "사용여부";
			// 
			// _chkSYSUSEYN
			// 
			this._chkSYSUSEYN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._chkSYSUSEYN.AutoSize = true;
			this._chkSYSUSEYN.Location = new System.Drawing.Point(93, 97);
			this._chkSYSUSEYN.Name = "_chkSYSUSEYN";
			this._chkSYSUSEYN.Size = new System.Drawing.Size(18, 17);
			this._chkSYSUSEYN.TabIndex = 1431;
			this._chkSYSUSEYN.UseVisualStyleBackColor = true;
			// 
			// BAS0829
			// 
			this.ClientSize = new System.Drawing.Size(508, 245);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0829";
			this.Text = "Van로그인정보추가:BAS0829";
			this.Load += new System.EventHandler(this.BAS0829_Load);
			this.Shown += new System.EventHandler(this.BAS0829_Shown);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.Label label4;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.TextBox _txtUSER_ID;
		private BANANA.Windows.Controls.TextBox _txtUSER_PW;
		private BANANA.Windows.Controls.ComboBox _cmbVAN_CD;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.CheckBox _chkSYSUSEYN;
	}
}
