namespace DemoClient.View.Common
{
	partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this._txtUSRID = new BANANA.Windows.Controls.TextBox();
            this.label1 = new BANANA.Windows.Controls.Label();
            this.label2 = new BANANA.Windows.Controls.Label();
            this._txtPWD = new BANANA.Windows.Controls.TextBox();
            this.label3 = new BANANA.Windows.Controls.Label();
            this._chkSaveUsrID = new BANANA.Windows.Controls.CheckBox();
            this._btnClose = new DemoClient.Controls.BananaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnLogin = new DemoClient.Controls.BananaButton();
            this._cmbCompany = new BANANA.Windows.Controls.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtUSRID
            // 
            this._txtUSRID.AutoTab = false;
            this._txtUSRID.DelegateProperty = true;
            this._txtUSRID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._txtUSRID.Location = new System.Drawing.Point(147, 133);
            this._txtUSRID.Name = "_txtUSRID";
            this._txtUSRID.Size = new System.Drawing.Size(254, 29);
            this._txtUSRID.TabIndex = 10;
            this._txtUSRID.ValidationGroup = null;
            this._txtUSRID.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtUSRID.WaterMarkText = "";
            this._txtUSRID.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtUSRID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(83, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(67, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "비밀번호";
            // 
            // _txtPWD
            // 
            this._txtPWD.AutoTab = false;
            this._txtPWD.DelegateProperty = true;
            this._txtPWD.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this._txtPWD.Location = new System.Drawing.Point(147, 168);
            this._txtPWD.Name = "_txtPWD";
            this._txtPWD.PasswordChar = '⊙';
            this._txtPWD.Size = new System.Drawing.Size(254, 29);
            this._txtPWD.TabIndex = 20;
            this._txtPWD.ValidationGroup = null;
            this._txtPWD.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtPWD.WaterMarkText = "";
            this._txtPWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtUSRPWD_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(67, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "운영회사";
            this.label3.Visible = false;
            // 
            // _chkSaveUsrID
            // 
            this._chkSaveUsrID.AutoSize = true;
            this._chkSaveUsrID.DelegateProperty = true;
            this._chkSaveUsrID.Location = new System.Drawing.Point(147, 208);
            this._chkSaveUsrID.Name = "_chkSaveUsrID";
            this._chkSaveUsrID.Size = new System.Drawing.Size(88, 16);
            this._chkSaveUsrID.TabIndex = 34;
            this._chkSaveUsrID.Text = "아이디 저장";
            this._chkSaveUsrID.UseVisualStyleBackColor = true;
            // 
            // _btnClose
            // 
            this._btnClose.DelegateProperty = true;
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._btnClose.Image = global::DemoClient.Properties.Resources._1404721120_211650;
            this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClose.Location = new System.Drawing.Point(297, 231);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Reserved = "      닫  기";
            this._btnClose.Size = new System.Drawing.Size(104, 43);
            this._btnClose.TabIndex = 35;
            this._btnClose.Text = "      닫  기";
            this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.ValidationGroup = null;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DemoClient.Properties.Resources.파워캐쉬;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 80);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // _btnLogin
            // 
            this._btnLogin.DelegateProperty = true;
            this._btnLogin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._btnLogin.Image = global::DemoClient.Properties.Resources._1404566867_175135;
            this._btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnLogin.Location = new System.Drawing.Point(147, 231);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Reserved = "      로  그  인";
            this._btnLogin.Size = new System.Drawing.Size(144, 43);
            this._btnLogin.TabIndex = 30;
            this._btnLogin.Text = "      로  그  인";
            this._btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.ValidationGroup = null;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // _cmbCompany
            // 
            this._cmbCompany.DataSource = null;
            this._cmbCompany.DroppedDown = false;
            this._cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this._cmbCompany.Location = new System.Drawing.Point(147, 99);
            this._cmbCompany.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbCompany.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbCompany.Name = "_cmbCompany";
            this._cmbCompany.SelectedIndex = -1;
            this._cmbCompany.SelectedItem = null;
            this._cmbCompany.SelectedValue = null;
            this._cmbCompany.Size = new System.Drawing.Size(254, 28);
            this._cmbCompany.TabIndex = 36;
            this._cmbCompany.ValidationGroup = null;
            this._cmbCompany.Visible = false;
            // 
            // frmLogin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this._btnClose;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this._cmbCompany);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._chkSaveUsrID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtPWD);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtUSRID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "ERP Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private BANANA.Windows.Controls.TextBox _txtUSRID;
		private BANANA.Windows.Controls.Label label1;
		private DemoClient.Controls.BananaButton _btnLogin;
		private BANANA.Windows.Controls.Label label2;
		private BANANA.Windows.Controls.TextBox _txtPWD;
		private BANANA.Windows.Controls.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private BANANA.Windows.Controls.CheckBox _chkSaveUsrID;
		private DemoClient.Controls.BananaButton _btnClose;
		private BANANA.Windows.Controls.ComboBox _cmbCompany;
	}
}
