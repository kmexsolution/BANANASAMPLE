namespace DemoClient.View.BAS
{
	partial class BAS0510
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0510));
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this._txtCODE_NAME = new BANANA.Windows.Controls.TextBox();
			this._txtMAIN_CODE = new BANANA.Windows.Controls.TextBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this.label18 = new BANANA.Windows.Controls.Label();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this._txtCODE_NAME, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this._txtMAIN_CODE, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 56);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// _txtCODE_NAME
			// 
			this._txtCODE_NAME.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCODE_NAME.AutoTab = false;
			this._txtCODE_NAME.Compulsory = true;
			this._txtCODE_NAME.DelegateProperty = true;
			this._txtCODE_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCODE_NAME.Location = new System.Drawing.Point(93, 31);
			this._txtCODE_NAME.Name = "_txtCODE_NAME";
			this._txtCODE_NAME.Size = new System.Drawing.Size(130, 20);
			this._txtCODE_NAME.TabIndex = 110;
			this._txtCODE_NAME.ValidationGroup = "a";
			this._txtCODE_NAME.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtCODE_NAME.WaterMarkText = "";
			// 
			// _txtMAIN_CODE
			// 
			this._txtMAIN_CODE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtMAIN_CODE.AutoTab = false;
			this._txtMAIN_CODE.Compulsory = true;
			this._txtMAIN_CODE.DelegateProperty = true;
			this._txtMAIN_CODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMAIN_CODE.Location = new System.Drawing.Point(93, 3);
			this._txtMAIN_CODE.MaxLength = 3;
			this._txtMAIN_CODE.Name = "_txtMAIN_CODE";
			this._txtMAIN_CODE.Size = new System.Drawing.Size(130, 20);
			this._txtMAIN_CODE.TabIndex = 100;
			this._txtMAIN_CODE.ValidationGroup = "a";
			this._txtMAIN_CODE.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtMAIN_CODE.WaterMarkText = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "메인코드";
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(47, 35);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(40, 13);
			this.label18.TabIndex = 303;
			this.label18.Text = "코드명";
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(148, 62);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 503;
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
			this._btnSave.Location = new System.Drawing.Point(67, 62);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 502;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// BAS0510
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(234, 100);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0510";
			this.Text = "메인코드등록:BAS0510";
			this.Load += new System.EventHandler(this.BAS0510_Load);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private BANANA.Windows.Controls.TextBox _txtCODE_NAME;
		private BANANA.Windows.Controls.TextBox _txtMAIN_CODE;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.Label label18;
		private DemoClient.Controls.BananaButton _btnClose;
		private DemoClient.Controls.BananaButton _btnSave;
	}
}
