namespace DemoClient.View.HLP
{
	partial class HLP0310
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP0310));
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this._txtTITLE = new BANANA.Windows.Controls.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._cmbGUBUN = new BANANA.Windows.Controls.ComboBox();
			this._txtIDX = new BANANA.Windows.Controls.TextBox();
			this._chkDISPLAY_YN = new BANANA.Windows.Controls.CheckBox();
			this.lblCOMPANY_CD = new BANANA.Windows.Controls.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblUSR_PASS = new BANANA.Windows.Controls.Label();
			this.labelmemo = new System.Windows.Forms.Label();
			this._txtMEMO = new BANANA.Windows.Controls.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._lblSYSREGINFO = new System.Windows.Forms.Label();
			this._lblSYSMODINFO = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(609, 562);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Reserved = "      닫   기";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 1014;
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
			this._btnSave.Location = new System.Drawing.Point(528, 562);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Reserved = "      저   장";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 1013;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 545);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "기본정보";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._txtTITLE, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._cmbGUBUN, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtIDX, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._chkDISPLAY_YN, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCOMPANY_CD, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblUSR_PASS, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelmemo, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this._lblSYSREGINFO, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this._lblSYSMODINFO, 1, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 403F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 518);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 464);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 1017;
			this.label3.Text = "등록자";
			// 
			// _txtTITLE
			// 
			this._txtTITLE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this._txtTITLE, 5);
			this._txtTITLE.DelegateProperty = true;
			this._txtTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtTITLE.Location = new System.Drawing.Point(93, 30);
			this._txtTITLE.Name = "_txtTITLE";
			this._txtTITLE.Size = new System.Drawing.Size(590, 23);
			this._txtTITLE.TabIndex = 1016;
			this._txtTITLE.ValidationGroup = null;
			this._txtTITLE.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtTITLE.WaterMarkText = "";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 39;
			this.label2.Text = "내용";
			// 
			// _cmbGUBUN
			// 
			this._cmbGUBUN.DataSource = null;
			this._cmbGUBUN.DelegateProperty = true;
			this._cmbGUBUN.DroppedDown = false;
			this._cmbGUBUN.Location = new System.Drawing.Point(323, 3);
			this._cmbGUBUN.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbGUBUN.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbGUBUN.Name = "_cmbGUBUN";
			this._cmbGUBUN.SelectedIndex = -1;
			this._cmbGUBUN.SelectedItem = null;
			this._cmbGUBUN.SelectedValue = null;
			this._cmbGUBUN.Size = new System.Drawing.Size(130, 23);
			this._cmbGUBUN.TabIndex = 1015;
			this._cmbGUBUN.ValidationGroup = null;
			// 
			// _txtIDX
			// 
			this._txtIDX.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtIDX.DelegateProperty = true;
			this._txtIDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtIDX.Location = new System.Drawing.Point(93, 3);
			this._txtIDX.MaxLength = 10;
			this._txtIDX.Name = "_txtIDX";
			this._txtIDX.ReadOnly = true;
			this._txtIDX.Size = new System.Drawing.Size(130, 23);
			this._txtIDX.TabIndex = 100;
			this._txtIDX.ValidationGroup = null;
			this._txtIDX.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtIDX.WaterMarkText = "";
			// 
			// _chkDISPLAY_YN
			// 
			this._chkDISPLAY_YN.AutoSize = true;
			this._chkDISPLAY_YN.Checked = true;
			this._chkDISPLAY_YN.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkDISPLAY_YN.Location = new System.Drawing.Point(553, 3);
			this._chkDISPLAY_YN.Name = "_chkDISPLAY_YN";
			this._chkDISPLAY_YN.Size = new System.Drawing.Size(18, 17);
			this._chkDISPLAY_YN.TabIndex = 110;
			this._chkDISPLAY_YN.UseVisualStyleBackColor = true;
			// 
			// lblCOMPANY_CD
			// 
			this.lblCOMPANY_CD.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblCOMPANY_CD.AutoSize = true;
			this.lblCOMPANY_CD.Location = new System.Drawing.Point(20, 6);
			this.lblCOMPANY_CD.Name = "lblCOMPANY_CD";
			this.lblCOMPANY_CD.Size = new System.Drawing.Size(67, 15);
			this.lblCOMPANY_CD.TabIndex = 0;
			this.lblCOMPANY_CD.Text = "일련번호";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(280, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "구분";
			// 
			// lblUSR_PASS
			// 
			this.lblUSR_PASS.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblUSR_PASS.AutoSize = true;
			this.lblUSR_PASS.Location = new System.Drawing.Point(480, 6);
			this.lblUSR_PASS.Name = "lblUSR_PASS";
			this.lblUSR_PASS.Size = new System.Drawing.Size(67, 15);
			this.lblUSR_PASS.TabIndex = 8;
			this.lblUSR_PASS.Text = "출력여부";
			// 
			// labelmemo
			// 
			this.labelmemo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelmemo.AutoSize = true;
			this.labelmemo.Location = new System.Drawing.Point(50, 33);
			this.labelmemo.Name = "labelmemo";
			this.labelmemo.Size = new System.Drawing.Size(37, 15);
			this.labelmemo.TabIndex = 38;
			this.labelmemo.Text = "제목";
			// 
			// _txtMEMO
			// 
			this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this._txtMEMO, 5);
			this._txtMEMO.DelegateProperty = true;
			this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMEMO.Location = new System.Drawing.Point(93, 61);
			this._txtMEMO.Multiline = true;
			this._txtMEMO.Name = "_txtMEMO";
			this._txtMEMO.Size = new System.Drawing.Size(590, 389);
			this._txtMEMO.TabIndex = 200;
			this._txtMEMO.ValidationGroup = null;
			this._txtMEMO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtMEMO.WaterMarkText = "";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 495);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 15);
			this.label4.TabIndex = 1018;
			this.label4.Text = "수정자";
			// 
			// _lblSYSREGINFO
			// 
			this._lblSYSREGINFO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._lblSYSREGINFO.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this._lblSYSREGINFO, 5);
			this._lblSYSREGINFO.Location = new System.Drawing.Point(93, 464);
			this._lblSYSREGINFO.Name = "_lblSYSREGINFO";
			this._lblSYSREGINFO.Size = new System.Drawing.Size(0, 15);
			this._lblSYSREGINFO.TabIndex = 1019;
			// 
			// _lblSYSMODINFO
			// 
			this._lblSYSMODINFO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._lblSYSMODINFO.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this._lblSYSMODINFO, 5);
			this._lblSYSMODINFO.Location = new System.Drawing.Point(93, 495);
			this._lblSYSMODINFO.Name = "_lblSYSMODINFO";
			this._lblSYSMODINFO.Size = new System.Drawing.Size(0, 15);
			this._lblSYSMODINFO.TabIndex = 1020;
			// 
			// HLP0310
			// 
			this.ClientSize = new System.Drawing.Size(696, 601);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HLP0310";
			this.Text = "공지사항 추가/수정:HLP3010";
			this.Load += new System.EventHandler(this.HLP0310_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.TextBox _txtIDX;
		private BANANA.Windows.Controls.CheckBox _chkDISPLAY_YN;
		private BANANA.Windows.Controls.Label lblCOMPANY_CD;
		private System.Windows.Forms.Label label1;
		private BANANA.Windows.Controls.Label lblUSR_PASS;
		private BANANA.Windows.Controls.ComboBox _cmbGUBUN;
		private BANANA.Windows.Controls.TextBox _txtTITLE;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelmemo;
		private BANANA.Windows.Controls.TextBox _txtMEMO;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
		private System.Windows.Forms.Label _lblSYSREGINFO;
		private System.Windows.Forms.Label _lblSYSMODINFO;
	}
}
