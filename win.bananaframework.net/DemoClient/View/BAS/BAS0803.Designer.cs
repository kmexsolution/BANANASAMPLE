namespace DemoClient.View.BAS
{
	partial class BAS0803
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0803));
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._txtMEMO = new BANANA.Windows.Controls.TextBox();
			this.label4 = new BANANA.Windows.Controls.Label();
			this.label3 = new BANANA.Windows.Controls.Label();
			this._dtpCALL_DT_END = new BANANA.Windows.Controls.DateTimePicker();
			this._dtpCALL_DT_STRT = new BANANA.Windows.Controls.DateTimePicker();
			this.label1 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this._txtCALL_NM = new BANANA.Windows.Controls.TextBox();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
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
			this.groupBox1.Size = new System.Drawing.Size(508, 200);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "구비서류";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._dtpCALL_DT_END, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this._dtpCALL_DT_STRT, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtCALL_NM, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 176);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _txtMEMO
			// 
			this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this._txtMEMO, 3);
			this._txtMEMO.Compulsory = true;
			this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMEMO.Location = new System.Drawing.Point(93, 57);
			this._txtMEMO.Multiline = true;
			this._txtMEMO.Name = "_txtMEMO";
			this._txtMEMO.Size = new System.Drawing.Size(400, 121);
			this._txtMEMO.TabIndex = 40;
			this._txtMEMO.ValidationGroup = "a";
			this._txtMEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMEMO.WaterMarkText = "";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "통화내용";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "통화대상";
			// 
			// _dtpCALL_DT_END
			// 
			this._dtpCALL_DT_END.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpCALL_DT_END.Checked = false;
			this._dtpCALL_DT_END.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpCALL_DT_END.DelegateProperty = true;
			this._dtpCALL_DT_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpCALL_DT_END.Location = new System.Drawing.Point(343, 3);
			this._dtpCALL_DT_END.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpCALL_DT_END.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpCALL_DT_END.Name = "_dtpCALL_DT_END";
			this._dtpCALL_DT_END.Size = new System.Drawing.Size(150, 21);
			this._dtpCALL_DT_END.TabIndex = 20;
			this._dtpCALL_DT_END.ValidationGroup = null;
			this._dtpCALL_DT_END.Value = new System.DateTime(2014, 8, 6, 13, 26, 47, 243);
			// 
			// _dtpCALL_DT_STRT
			// 
			this._dtpCALL_DT_STRT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpCALL_DT_STRT.Checked = false;
			this._dtpCALL_DT_STRT.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this._dtpCALL_DT_STRT.DelegateProperty = true;
			this._dtpCALL_DT_STRT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpCALL_DT_STRT.Location = new System.Drawing.Point(93, 3);
			this._dtpCALL_DT_STRT.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpCALL_DT_STRT.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpCALL_DT_STRT.Name = "_dtpCALL_DT_STRT";
			this._dtpCALL_DT_STRT.Size = new System.Drawing.Size(150, 21);
			this._dtpCALL_DT_STRT.TabIndex = 10;
			this._dtpCALL_DT_STRT.ValidationGroup = null;
			this._dtpCALL_DT_STRT.Value = new System.DateTime(2014, 8, 6, 13, 26, 47, 246);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "시작시각";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(270, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "종료시각";
			// 
			// _txtCALL_NM
			// 
			this._txtCALL_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCALL_NM.Compulsory = true;
			this._txtCALL_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCALL_NM.Location = new System.Drawing.Point(93, 30);
			this._txtCALL_NM.Name = "_txtCALL_NM";
			this._txtCALL_NM.Size = new System.Drawing.Size(150, 23);
			this._txtCALL_NM.TabIndex = 30;
			this._txtCALL_NM.ValidationGroup = "a";
			this._txtCALL_NM.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtCALL_NM.WaterMarkText = "";
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
			this._btnClose.TabIndex = 60;
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
			this._btnSave.TabIndex = 50;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// BAS0803
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(508, 245);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0803";
			this.Text = "통화내역추가:BAS0803";
			this.Shown += new System.EventHandler(this.BAS0803_Shown);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.DateTimePicker _dtpCALL_DT_STRT;
		private BANANA.Windows.Controls.DateTimePicker _dtpCALL_DT_END;
		private BANANA.Windows.Controls.TextBox _txtMEMO;
		private BANANA.Windows.Controls.Label label4;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.TextBox _txtCALL_NM;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
		private System.Windows.Forms.Timer timer1;
	}
}
