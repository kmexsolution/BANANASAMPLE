namespace DemoClient.View.BAS
{
	partial class BAS0827
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0827));
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.MEMO = new BANANA.Windows.Controls.TextBox();
			this.label5 = new BANANA.Windows.Controls.Label();
			this._dtpEXCPT_DT_END = new BANANA.Windows.Controls.DateTimePicker();
			this.label3 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.STR_NM = new BANANA.Windows.Controls.TextBox();
			this.STR_CD = new BANANA.Windows.Controls.TextBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this.label4 = new BANANA.Windows.Controls.Label();
			this._dtpEXCPT_DT_STRT = new BANANA.Windows.Controls.DateTimePicker();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(297, 160);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 140;
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
			this._btnClose.Location = new System.Drawing.Point(378, 160);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 150;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.Controls.Add(this.MEMO, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._dtpEXCPT_DT_END, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.STR_NM, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.STR_CD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this._dtpEXCPT_DT_STRT, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 154);
			this.tableLayoutPanel1.TabIndex = 1117;
			// 
			// MEMO
			// 
			this.MEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this.MEMO, 3);
			this.MEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.MEMO.Location = new System.Drawing.Point(93, 57);
			this.MEMO.Multiline = true;
			this.MEMO.Name = "MEMO";
			this.MEMO.Size = new System.Drawing.Size(360, 94);
			this.MEMO.TabIndex = 1118;
			this.MEMO.ValidationGroup = "A";
			this.MEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this.MEMO.WaterMarkText = "";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 1118;
			this.label5.Text = "메모";
			// 
			// _dtpEXCPT_DT_END
			// 
			this._dtpEXCPT_DT_END.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpEXCPT_DT_END.Checked = false;
			this._dtpEXCPT_DT_END.Compulsory = true;
			this._dtpEXCPT_DT_END.CustomFormat = "yyyy-MM-dd";
			this._dtpEXCPT_DT_END.DelegateProperty = true;
			this._dtpEXCPT_DT_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpEXCPT_DT_END.Location = new System.Drawing.Point(323, 30);
			this._dtpEXCPT_DT_END.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpEXCPT_DT_END.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpEXCPT_DT_END.Name = "_dtpEXCPT_DT_END";
			this._dtpEXCPT_DT_END.ShowCheckBox = true;
			this._dtpEXCPT_DT_END.Size = new System.Drawing.Size(130, 21);
			this._dtpEXCPT_DT_END.TabIndex = 130;
			this._dtpEXCPT_DT_END.ValidationGroup = "A";
			this._dtpEXCPT_DT_END.Value = new System.DateTime(2014, 7, 26, 14, 16, 17, 472);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 1117;
			this.label3.Text = "예외시작일";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(250, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 1116;
			this.label2.Text = "가맹점명";
			// 
			// STR_NM
			// 
			this.STR_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.STR_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.STR_NM.Location = new System.Drawing.Point(323, 3);
			this.STR_NM.Name = "STR_NM";
			this.STR_NM.ReadOnly = true;
			this.STR_NM.Size = new System.Drawing.Size(130, 23);
			this.STR_NM.TabIndex = 110;
			this.STR_NM.ValidationGroup = null;
			this.STR_NM.WaterMarkColor = System.Drawing.Color.Empty;
			this.STR_NM.WaterMarkText = "";
			// 
			// STR_CD
			// 
			this.STR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.STR_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.STR_CD.Location = new System.Drawing.Point(93, 3);
			this.STR_CD.Name = "STR_CD";
			this.STR_CD.ReadOnly = true;
			this.STR_CD.Size = new System.Drawing.Size(130, 23);
			this.STR_CD.TabIndex = 100;
			this.STR_CD.ValidationGroup = null;
			this.STR_CD.WaterMarkColor = System.Drawing.Color.Empty;
			this.STR_CD.WaterMarkText = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 1115;
			this.label1.Text = "가맹점코드";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(235, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 15);
			this.label4.TabIndex = 1118;
			this.label4.Text = "예외종료일";
			// 
			// _dtpEXCPT_DT_STRT
			// 
			this._dtpEXCPT_DT_STRT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._dtpEXCPT_DT_STRT.Checked = false;
			this._dtpEXCPT_DT_STRT.Compulsory = true;
			this._dtpEXCPT_DT_STRT.CustomFormat = "yyyy-MM-dd";
			this._dtpEXCPT_DT_STRT.DelegateProperty = true;
			this._dtpEXCPT_DT_STRT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this._dtpEXCPT_DT_STRT.Location = new System.Drawing.Point(93, 30);
			this._dtpEXCPT_DT_STRT.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpEXCPT_DT_STRT.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpEXCPT_DT_STRT.Name = "_dtpEXCPT_DT_STRT";
			this._dtpEXCPT_DT_STRT.ShowCheckBox = true;
			this._dtpEXCPT_DT_STRT.Size = new System.Drawing.Size(130, 21);
			this._dtpEXCPT_DT_STRT.TabIndex = 120;
			this._dtpEXCPT_DT_STRT.ValidationGroup = "A";
			this._dtpEXCPT_DT_STRT.Value = new System.DateTime(2014, 7, 26, 14, 16, 17, 472);
			// 
			// BAS0827
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(462, 195);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0827";
			this.Text = "보증예치금예외기간등록:BAS0827";
			this.Load += new System.EventHandler(this.BAS0827_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnClose;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.Label label2;
		public BANANA.Windows.Controls.TextBox STR_NM;
		public BANANA.Windows.Controls.TextBox STR_CD;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.Label label4;
		private BANANA.Windows.Controls.Label label5;
		public BANANA.Windows.Controls.TextBox MEMO;
		private BANANA.Windows.Controls.DateTimePicker _dtpEXCPT_DT_STRT;
		private BANANA.Windows.Controls.DateTimePicker _dtpEXCPT_DT_END;
	}
}
