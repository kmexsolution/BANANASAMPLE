namespace DemoClient.View.BAS
{
	partial class BAS0210
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0210));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label13 = new System.Windows.Forms.Label();
			this._cmbDEPT_CD = new BANANA.Windows.Controls.ComboBox();
			this._cmbUSR_GUBUN = new BANANA.Windows.Controls.ComboBox();
			this._txtADDR_DTL = new BANANA.Windows.Controls.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this._btnFindZipCode01 = new DemoClient.Controls.BananaButton();
			this._txtZIP_NO = new BANANA.Windows.Controls.TextBox();
			this._txtADDR_BSC = new BANANA.Windows.Controls.TextBox();
			this._txtEMAIL = new BANANA.Windows.Controls.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this._txtHPNO = new BANANA.Windows.Controls.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this._txtPWD1 = new BANANA.Windows.Controls.TextBox();
			this._txtUSRNM = new BANANA.Windows.Controls.TextBox();
			this.lblCOMPANY_CD = new BANANA.Windows.Controls.Label();
			this.lblUSR_ID = new BANANA.Windows.Controls.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUSR_PASS = new BANANA.Windows.Controls.Label();
			this.lblUSR_ROLL = new BANANA.Windows.Controls.Label();
			this._txtUSRID = new BANANA.Windows.Controls.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._txtTELNO = new BANANA.Windows.Controls.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._txtPWD2 = new BANANA.Windows.Controls.TextBox();
			this._txtFAXNO = new BANANA.Windows.Controls.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this._txtMEMO = new BANANA.Windows.Controls.TextBox();
			this.labelmemo = new System.Windows.Forms.Label();
			this._clbCompany = new System.Windows.Forms.CheckedListBox();
			this._btnSave = new DemoClient.Controls.BananaButton();
			this._btnClose = new DemoClient.Controls.BananaButton();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(697, 354);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "기본 정보";
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
			this.tableLayoutPanel1.Controls.Add(this.label13, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this._cmbDEPT_CD, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this._cmbUSR_GUBUN, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtADDR_DTL, 5, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this._txtADDR_BSC, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this._txtEMAIL, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._txtHPNO, 5, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtPWD1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtUSRNM, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCOMPANY_CD, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblUSR_ID, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblUSR_PASS, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblUSR_ROLL, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtUSRID, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtTELNO, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtPWD2, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this._txtFAXNO, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelmemo, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this._clbCompany, 1, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 335);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(36, 178);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(51, 13);
			this.label13.TabIndex = 1114;
			this.label13.Text = "소속회사";
			// 
			// _cmbDEPT_CD
			// 
			this._cmbDEPT_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbDEPT_CD.DataSource = null;
			this._cmbDEPT_CD.DelegateProperty = true;
			this._cmbDEPT_CD.Location = new System.Drawing.Point(553, 30);
			this._cmbDEPT_CD.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbDEPT_CD.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbDEPT_CD.Name = "_cmbDEPT_CD";
			this._cmbDEPT_CD.SelectedIndex = -1;
			this._cmbDEPT_CD.SelectedItem = null;
			this._cmbDEPT_CD.SelectedValue = null;
			this._cmbDEPT_CD.Size = new System.Drawing.Size(130, 21);
			this._cmbDEPT_CD.TabIndex = 1050;
			this._cmbDEPT_CD.ValidationGroup = null;
			// 
			// _cmbUSR_GUBUN
			// 
			this._cmbUSR_GUBUN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._cmbUSR_GUBUN.DataSource = null;
			this._cmbUSR_GUBUN.DelegateProperty = true;
			this._cmbUSR_GUBUN.Location = new System.Drawing.Point(553, 3);
			this._cmbUSR_GUBUN.MaximumSize = new System.Drawing.Size(500, 60);
			this._cmbUSR_GUBUN.MinimumSize = new System.Drawing.Size(100, 21);
			this._cmbUSR_GUBUN.Name = "_cmbUSR_GUBUN";
			this._cmbUSR_GUBUN.SelectedIndex = -1;
			this._cmbUSR_GUBUN.SelectedItem = null;
			this._cmbUSR_GUBUN.SelectedValue = null;
			this._cmbUSR_GUBUN.Size = new System.Drawing.Size(130, 21);
			this._cmbUSR_GUBUN.TabIndex = 1020;
			this._cmbUSR_GUBUN.ValidationGroup = null;
			// 
			// _txtADDR_DTL
			// 
			this._txtADDR_DTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtADDR_DTL.DelegateProperty = true;
			this._txtADDR_DTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtADDR_DTL.Location = new System.Drawing.Point(553, 84);
			this._txtADDR_DTL.Name = "_txtADDR_DTL";
			this._txtADDR_DTL.Size = new System.Drawing.Size(130, 20);
			this._txtADDR_DTL.TabIndex = 1110;
			this._txtADDR_DTL.ValidationGroup = null;
			this._txtADDR_DTL.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtADDR_DTL.WaterMarkText = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this._btnFindZipCode01);
			this.panel2.Controls.Add(this._txtZIP_NO);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(90, 81);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(140, 27);
			this.panel2.TabIndex = 1090;
			this.panel2.TabStop = true;
			// 
			// _btnFindZipCode01
			// 
			this._btnFindZipCode01.DelegateProperty = true;
			this._btnFindZipCode01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnFindZipCode01.Location = new System.Drawing.Point(79, 3);
			this._btnFindZipCode01.Name = "_btnFindZipCode01";
			this._btnFindZipCode01.Size = new System.Drawing.Size(54, 21);
			this._btnFindZipCode01.TabIndex = 20;
			this._btnFindZipCode01.TabStop = false;
			this._btnFindZipCode01.Text = "검   색";
			this._btnFindZipCode01.UseVisualStyleBackColor = true;
			this._btnFindZipCode01.ValidationGroup = null;
			this._btnFindZipCode01.Click += new System.EventHandler(this._btnFindZipCode01_Click);
			// 
			// _txtZIP_NO
			// 
			this._txtZIP_NO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtZIP_NO.DelegateProperty = true;
			this._txtZIP_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtZIP_NO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
			this._txtZIP_NO.Location = new System.Drawing.Point(3, 4);
			this._txtZIP_NO.MaxLength = 7;
			this._txtZIP_NO.Name = "_txtZIP_NO";
			this._txtZIP_NO.Size = new System.Drawing.Size(70, 20);
			this._txtZIP_NO.TabIndex = 10;
			this._txtZIP_NO.ValidationGroup = null;
			this._txtZIP_NO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtZIP_NO.WaterMarkText = "";
			// 
			// _txtADDR_BSC
			// 
			this._txtADDR_BSC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtADDR_BSC.DelegateProperty = true;
			this._txtADDR_BSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtADDR_BSC.Location = new System.Drawing.Point(323, 84);
			this._txtADDR_BSC.Name = "_txtADDR_BSC";
			this._txtADDR_BSC.Size = new System.Drawing.Size(130, 20);
			this._txtADDR_BSC.TabIndex = 1100;
			this._txtADDR_BSC.ValidationGroup = null;
			this._txtADDR_BSC.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtADDR_BSC.WaterMarkText = "";
			// 
			// _txtEMAIL
			// 
			this._txtEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this._txtEMAIL, 5);
			this._txtEMAIL.DelegateProperty = true;
			this._txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtEMAIL.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
			this._txtEMAIL.Location = new System.Drawing.Point(93, 111);
			this._txtEMAIL.Name = "_txtEMAIL";
			this._txtEMAIL.Size = new System.Drawing.Size(590, 20);
			this._txtEMAIL.TabIndex = 1120;
			this._txtEMAIL.ValidationGroup = null;
			this._txtEMAIL.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtEMAIL.WaterMarkText = "";
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(47, 115);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 13);
			this.label12.TabIndex = 39;
			this.label12.Text = "이메일";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(496, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "상세주소";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(36, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "우편번호";
			// 
			// _txtHPNO
			// 
			this._txtHPNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtHPNO.DelegateProperty = true;
			this._txtHPNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtHPNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
			this._txtHPNO.Location = new System.Drawing.Point(553, 57);
			this._txtHPNO.Name = "_txtHPNO";
			this._txtHPNO.Size = new System.Drawing.Size(130, 20);
			this._txtHPNO.TabIndex = 1080;
			this._txtHPNO.ValidationGroup = null;
			this._txtHPNO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtHPNO.WaterMarkText = "";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(485, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "휴대폰번호";
			// 
			// _txtPWD1
			// 
			this._txtPWD1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtPWD1.Compulsory = true;
			this._txtPWD1.DelegateProperty = true;
			this._txtPWD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtPWD1.Location = new System.Drawing.Point(93, 30);
			this._txtPWD1.Name = "_txtPWD1";
			this._txtPWD1.PasswordChar = '⊙';
			this._txtPWD1.Size = new System.Drawing.Size(130, 20);
			this._txtPWD1.TabIndex = 1030;
			this._txtPWD1.ValidationGroup = "a";
			this._txtPWD1.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtPWD1.WaterMarkText = "";
			// 
			// _txtUSRNM
			// 
			this._txtUSRNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtUSRNM.Compulsory = true;
			this._txtUSRNM.DelegateProperty = true;
			this._txtUSRNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtUSRNM.Location = new System.Drawing.Point(323, 3);
			this._txtUSRNM.Name = "_txtUSRNM";
			this._txtUSRNM.Size = new System.Drawing.Size(130, 20);
			this._txtUSRNM.TabIndex = 1010;
			this._txtUSRNM.ValidationGroup = "a";
			this._txtUSRNM.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtUSRNM.WaterMarkText = "";
			// 
			// lblCOMPANY_CD
			// 
			this.lblCOMPANY_CD.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblCOMPANY_CD.AutoSize = true;
			this.lblCOMPANY_CD.Location = new System.Drawing.Point(36, 7);
			this.lblCOMPANY_CD.Name = "lblCOMPANY_CD";
			this.lblCOMPANY_CD.Size = new System.Drawing.Size(51, 13);
			this.lblCOMPANY_CD.TabIndex = 0;
			this.lblCOMPANY_CD.Text = "이용자ID";
			// 
			// lblUSR_ID
			// 
			this.lblUSR_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblUSR_ID.AutoSize = true;
			this.lblUSR_ID.Location = new System.Drawing.Point(36, 34);
			this.lblUSR_ID.Name = "lblUSR_ID";
			this.lblUSR_ID.Size = new System.Drawing.Size(51, 13);
			this.lblUSR_ID.TabIndex = 2;
			this.lblUSR_ID.Text = "비밀번호";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(266, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "이용자명";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "비밀번호 확인";
			// 
			// lblUSR_PASS
			// 
			this.lblUSR_PASS.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblUSR_PASS.AutoSize = true;
			this.lblUSR_PASS.Location = new System.Drawing.Point(485, 7);
			this.lblUSR_PASS.Name = "lblUSR_PASS";
			this.lblUSR_PASS.Size = new System.Drawing.Size(62, 13);
			this.lblUSR_PASS.TabIndex = 8;
			this.lblUSR_PASS.Text = "이용자구분";
			// 
			// lblUSR_ROLL
			// 
			this.lblUSR_ROLL.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblUSR_ROLL.AutoSize = true;
			this.lblUSR_ROLL.Location = new System.Drawing.Point(496, 34);
			this.lblUSR_ROLL.Name = "lblUSR_ROLL";
			this.lblUSR_ROLL.Size = new System.Drawing.Size(51, 13);
			this.lblUSR_ROLL.TabIndex = 7;
			this.lblUSR_ROLL.Text = "소속부서";
			// 
			// _txtUSRID
			// 
			this._txtUSRID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtUSRID.Compulsory = true;
			this._txtUSRID.DelegateProperty = true;
			this._txtUSRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtUSRID.Location = new System.Drawing.Point(93, 3);
			this._txtUSRID.Name = "_txtUSRID";
			this._txtUSRID.Size = new System.Drawing.Size(130, 20);
			this._txtUSRID.TabIndex = 1000;
			this._txtUSRID.ValidationGroup = "a";
			this._txtUSRID.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtUSRID.WaterMarkText = "";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "전화번호";
			// 
			// _txtTELNO
			// 
			this._txtTELNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtTELNO.DelegateProperty = true;
			this._txtTELNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtTELNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
			this._txtTELNO.Location = new System.Drawing.Point(93, 57);
			this._txtTELNO.Name = "_txtTELNO";
			this._txtTELNO.Size = new System.Drawing.Size(130, 20);
			this._txtTELNO.TabIndex = 1060;
			this._txtTELNO.ValidationGroup = null;
			this._txtTELNO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtTELNO.WaterMarkText = "";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(266, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "팩스번호";
			// 
			// _txtPWD2
			// 
			this._txtPWD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtPWD2.Compulsory = true;
			this._txtPWD2.DelegateProperty = true;
			this._txtPWD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtPWD2.Location = new System.Drawing.Point(323, 30);
			this._txtPWD2.Name = "_txtPWD2";
			this._txtPWD2.PasswordChar = '⊙';
			this._txtPWD2.Size = new System.Drawing.Size(130, 20);
			this._txtPWD2.TabIndex = 1040;
			this._txtPWD2.ValidationGroup = "a";
			this._txtPWD2.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtPWD2.WaterMarkText = "";
			// 
			// _txtFAXNO
			// 
			this._txtFAXNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtFAXNO.DelegateProperty = true;
			this._txtFAXNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtFAXNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
			this._txtFAXNO.Location = new System.Drawing.Point(323, 57);
			this._txtFAXNO.Name = "_txtFAXNO";
			this._txtFAXNO.Size = new System.Drawing.Size(130, 20);
			this._txtFAXNO.TabIndex = 1070;
			this._txtFAXNO.ValidationGroup = null;
			this._txtFAXNO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtFAXNO.WaterMarkText = "";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(266, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 33;
			this.label7.Text = "기본주소";
			// 
			// _txtMEMO
			// 
			this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel1.SetColumnSpan(this._txtMEMO, 5);
			this._txtMEMO.DelegateProperty = true;
			this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtMEMO.Location = new System.Drawing.Point(93, 238);
			this._txtMEMO.Multiline = true;
			this._txtMEMO.Name = "_txtMEMO";
			this._txtMEMO.Size = new System.Drawing.Size(590, 94);
			this._txtMEMO.TabIndex = 1140;
			this._txtMEMO.ValidationGroup = null;
			this._txtMEMO.WaterMarkColor = System.Drawing.Color.Silver;
			this._txtMEMO.WaterMarkText = "";
			// 
			// labelmemo
			// 
			this.labelmemo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelmemo.AutoSize = true;
			this.labelmemo.Location = new System.Drawing.Point(58, 278);
			this.labelmemo.Name = "labelmemo";
			this.labelmemo.Size = new System.Drawing.Size(29, 13);
			this.labelmemo.TabIndex = 38;
			this.labelmemo.Text = "메모";
			// 
			// _clbCompany
			// 
			this._clbCompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._clbCompany.CheckOnClick = true;
			this.tableLayoutPanel1.SetColumnSpan(this._clbCompany, 5);
			this._clbCompany.FormattingEnabled = true;
			this._clbCompany.Location = new System.Drawing.Point(93, 145);
			this._clbCompany.Name = "_clbCompany";
			this._clbCompany.Size = new System.Drawing.Size(590, 79);
			this._clbCompany.TabIndex = 1130;
			// 
			// _btnSave
			// 
			this._btnSave.ButtonConfirm = true;
			this._btnSave.DelegateProperty = true;
			this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.Location = new System.Drawing.Point(530, 360);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 27);
			this._btnSave.TabIndex = 1150;
			this._btnSave.Text = "      저   장";
			this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.ValidationGroup = "a";
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _btnClose
			// 
			this._btnClose.DelegateProperty = true;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
			this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.Location = new System.Drawing.Point(611, 360);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Size = new System.Drawing.Size(75, 27);
			this._btnClose.TabIndex = 1160;
			this._btnClose.Text = "      닫   기";
			this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.ValidationGroup = null;
			this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
			// 
			// BAS0210
			// 
			this.CancelButton = this._btnClose;
			this.ClientSize = new System.Drawing.Size(697, 396);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._btnClose);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0210";
			this.Text = "이용자정보등록:BAS0210";
			this.Load += new System.EventHandler(this.BAS0210_Load);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private DemoClient.Controls.BananaButton _btnSave;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label13;
		private BANANA.Windows.Controls.ComboBox _cmbDEPT_CD;
		private BANANA.Windows.Controls.ComboBox _cmbUSR_GUBUN;
		private BANANA.Windows.Controls.TextBox _txtADDR_DTL;
		private System.Windows.Forms.Panel panel2;
		private DemoClient.Controls.BananaButton _btnFindZipCode01;
		private BANANA.Windows.Controls.TextBox _txtZIP_NO;
		private BANANA.Windows.Controls.TextBox _txtADDR_BSC;
		private BANANA.Windows.Controls.TextBox _txtEMAIL;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private BANANA.Windows.Controls.TextBox _txtHPNO;
		private System.Windows.Forms.Label label5;
		private BANANA.Windows.Controls.TextBox _txtPWD1;
		private BANANA.Windows.Controls.TextBox _txtUSRNM;
		private BANANA.Windows.Controls.Label lblCOMPANY_CD;
		private BANANA.Windows.Controls.Label lblUSR_ID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private BANANA.Windows.Controls.Label lblUSR_PASS;
		private BANANA.Windows.Controls.Label lblUSR_ROLL;
		private BANANA.Windows.Controls.TextBox _txtUSRID;
		private System.Windows.Forms.Label label3;
		private BANANA.Windows.Controls.TextBox _txtTELNO;
		private System.Windows.Forms.Label label4;
		private BANANA.Windows.Controls.TextBox _txtPWD2;
		private BANANA.Windows.Controls.TextBox _txtFAXNO;
		private System.Windows.Forms.Label label7;
		private BANANA.Windows.Controls.TextBox _txtMEMO;
		private System.Windows.Forms.Label labelmemo;
		private System.Windows.Forms.CheckedListBox _clbCompany;
		private DemoClient.Controls.BananaButton _btnClose;

	}
}
