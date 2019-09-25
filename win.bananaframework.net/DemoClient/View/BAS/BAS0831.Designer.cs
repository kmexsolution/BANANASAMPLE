namespace DemoClient
{
	partial class BAS0831
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.MEMO = new BANANA.Windows.Controls.TextBox();
			this.label5 = new BANANA.Windows.Controls.Label();
			this._dtpEXCPT_DT_END = new BANANA.Windows.Controls.DateTimePicker();
			this.label3 = new BANANA.Windows.Controls.Label();
			this.label4 = new BANANA.Windows.Controls.Label();
			this._dtpEXCPT_DT_STRT = new BANANA.Windows.Controls.DateTimePicker();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.Controls.Add(this.MEMO, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._dtpEXCPT_DT_END, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this._dtpEXCPT_DT_STRT, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 130);
			this.tableLayoutPanel1.TabIndex = 1120;
			// 
			// MEMO
			// 
			this.MEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this.MEMO, 3);
			this.MEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.MEMO.Location = new System.Drawing.Point(93, 31);
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
			this.label5.Location = new System.Drawing.Point(50, 71);
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
			this._dtpEXCPT_DT_END.Location = new System.Drawing.Point(323, 3);
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
			this.label3.Location = new System.Drawing.Point(5, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 1117;
			this.label3.Text = "예외시작일";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(235, 6);
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
			this._dtpEXCPT_DT_STRT.Location = new System.Drawing.Point(93, 3);
			this._dtpEXCPT_DT_STRT.MaximumSize = new System.Drawing.Size(250, 21);
			this._dtpEXCPT_DT_STRT.MinimumSize = new System.Drawing.Size(100, 21);
			this._dtpEXCPT_DT_STRT.Name = "_dtpEXCPT_DT_STRT";
			this._dtpEXCPT_DT_STRT.ShowCheckBox = true;
			this._dtpEXCPT_DT_STRT.Size = new System.Drawing.Size(130, 21);
			this._dtpEXCPT_DT_STRT.TabIndex = 120;
			this._dtpEXCPT_DT_STRT.ValidationGroup = "A";
			this._dtpEXCPT_DT_STRT.Value = new System.DateTime(2014, 7, 26, 14, 16, 17, 472);
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(297, 164);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 1118;
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
			this._btnClose.Location = new System.Drawing.Point(378, 164);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 1119;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// BAS0831
			// 
			this.ClientSize = new System.Drawing.Size(462, 195);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "BAS0831";
			this.Text = "차감예외기간등록:BAS0831";
			this.Load += new System.EventHandler(this.BAS0831_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DemoClient.Controls.BananaButton _btnSave;
		private DemoClient.Controls.BananaButton _btnClose;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public BANANA.Windows.Controls.TextBox MEMO;
		private BANANA.Windows.Controls.Label label5;
		private BANANA.Windows.Controls.DateTimePicker _dtpEXCPT_DT_END;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.Label label4;
		private BANANA.Windows.Controls.DateTimePicker _dtpEXCPT_DT_STRT;
	}
}
