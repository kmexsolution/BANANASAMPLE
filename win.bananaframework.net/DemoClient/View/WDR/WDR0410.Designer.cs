namespace DemoClient.View.WDR
{
	partial class WDR0410
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WDR0410));
			this._btnSave = new DemoClient.Controls.BananaButton();
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this._txtMEMO = new BANANA.Windows.Controls.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(391, 228);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(90, 27);
			this._btnSave.TabIndex = 166;
			this._btnSave.Text = "      사유입력";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = null;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._txtMEMO);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(484, 222);
			this.groupBox1.TabIndex = 165;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "사유 입력";
			// 
			// _txtMEMO
			// 
			this._txtMEMO.AutoTab = false;
			this._txtMEMO.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMEMO.Location = new System.Drawing.Point(3, 16);
			this._txtMEMO.Multiline = true;
			this._txtMEMO.Name = "_txtMEMO";
			this._txtMEMO.Size = new System.Drawing.Size(478, 203);
			this._txtMEMO.TabIndex = 0;
			this._txtMEMO.ValidationGroup = null;
			this._txtMEMO.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtMEMO.WaterMarkText = "";
			// 
			// WDR0410
			// 
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WDR0410";
			this.Text = "출금요청실패처리사유:BAS0410";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DemoClient.Controls.BananaButton _btnSave;
		private BANANA.Windows.Controls.GroupBox groupBox1;
		private BANANA.Windows.Controls.TextBox _txtMEMO;
	}
}
