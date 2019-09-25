namespace DemoClient.View.Common
{
	partial class frmChangeMyPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeMyPassword));
			this.label3 = new BANANA.Windows.Controls.Label();
			this.label2 = new BANANA.Windows.Controls.Label();
			this._txtPWD02 = new BANANA.Windows.Controls.TextBox();
			this._btnChange = new DemoClient.Controls.BananaButton();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._txtPWD01 = new BANANA.Windows.Controls.TextBox();
			this._txtPWD03 = new BANANA.Windows.Controls.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(60, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 21);
			this.label3.TabIndex = 37;
			this.label3.Text = "기존 비밀번호";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(60, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 21);
			this.label2.TabIndex = 33;
			this.label2.Text = "비밀번호 확인";
			// 
			// _txtPWD02
			// 
			this._txtPWD02.DelegateProperty = true;
			this._txtPWD02.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this._txtPWD02.Location = new System.Drawing.Point(178, 67);
			this._txtPWD02.Name = "_txtPWD02";
			this._txtPWD02.PasswordChar = '⊙';
			this._txtPWD02.Size = new System.Drawing.Size(247, 29);
			this._txtPWD02.TabIndex = 20;
			this._txtPWD02.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtPWD02.WaterMarkText = "";
			this._txtPWD02.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtPWD02_KeyDown);
			// 
			// _btnChange
			// 
			this._btnChange.DelegateProperty = true;
			this._btnChange.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this._btnChange.Image = global::DemoClient.Properties.Resources._1377802975_32495;
			this._btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnChange.Location = new System.Drawing.Point(281, 142);
			this._btnChange.Name = "_btnChange";
			this._btnChange.Size = new System.Drawing.Size(144, 43);
			this._btnChange.TabIndex = 40;
			this._btnChange.Text = "      변     경";
			this._btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnChange.UseVisualStyleBackColor = true;
			this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(60, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 21);
			this.label1.TabIndex = 32;
			this.label1.Text = "신규 비밀번호";
			// 
			// _txtPWD01
			// 
			this._txtPWD01.DelegateProperty = true;
			this._txtPWD01.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this._txtPWD01.Location = new System.Drawing.Point(178, 32);
			this._txtPWD01.Name = "_txtPWD01";
			this._txtPWD01.PasswordChar = '⊙';
			this._txtPWD01.Size = new System.Drawing.Size(247, 29);
			this._txtPWD01.TabIndex = 10;
			this._txtPWD01.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtPWD01.WaterMarkText = "";
			this._txtPWD01.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtPWD01_KeyDown);
			// 
			// _txtPWD03
			// 
			this._txtPWD03.DelegateProperty = true;
			this._txtPWD03.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this._txtPWD03.Location = new System.Drawing.Point(178, 102);
			this._txtPWD03.Name = "_txtPWD03";
			this._txtPWD03.PasswordChar = '⊙';
			this._txtPWD03.Size = new System.Drawing.Size(247, 29);
			this._txtPWD03.TabIndex = 30;
			this._txtPWD03.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtPWD03.WaterMarkText = "";
			this._txtPWD03.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtPWD03_KeyDown);
			// 
			// frmChangeMyPassword
			// 
			this.ClientSize = new System.Drawing.Size(484, 218);
			this.Controls.Add(this._txtPWD03);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._txtPWD02);
			this.Controls.Add(this._btnChange);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._txtPWD01);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangeMyPassword";
			this.Text = "비밀번호 변경:frmChangeMyPassword";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.TextBox _txtPWD02;
		private DemoClient.Controls.BananaButton _btnChange;
		private BANANA.Windows.Controls.Label label1;
		private BANANA.Windows.Controls.TextBox _txtPWD01;
		private BANANA.Windows.Controls.TextBox _txtPWD03;
	}
}
