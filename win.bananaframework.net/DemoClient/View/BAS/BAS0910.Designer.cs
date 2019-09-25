namespace DemoClient.View.BAS
{
    partial class BAS0910
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
            this._txtBI_ADDR_BSC = new BANANA.Windows.Controls.TextBox();
            this._txtBI_BUBIN_NO = new BANANA.Windows.Controls.TextBox();
            this._txtBI_SAUP_NO = new BANANA.Windows.Controls.TextBox();
            this._txtBI_PRSNT_NM = new BANANA.Windows.Controls.TextBox();
            this.label6 = new BANANA.Windows.Controls.Label();
            this.label7 = new BANANA.Windows.Controls.Label();
            this.label8 = new BANANA.Windows.Controls.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new BANANA.Windows.Controls.Label();
            this._txtBI_COMPANY_NM = new BANANA.Windows.Controls.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtBI_ADDR_DTL = new BANANA.Windows.Controls.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this._txtBI_EMAIL = new BANANA.Windows.Controls.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnFindZipCode02 = new DemoClient.Controls.BananaButton();
            this._txtBI_ZIP_NO = new BANANA.Windows.Controls.TextBox();
            this._txtBI_JONGMOK = new BANANA.Windows.Controls.TextBox();
            this._cmbBI_BINF_CD = new BANANA.Windows.Controls.ComboBox();
            this._txtBI_UPTE = new BANANA.Windows.Controls.TextBox();
            this.label13 = new BANANA.Windows.Controls.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._chkAuto = new BANANA.Windows.Controls.CheckBox();
            this._txtLNR_CD = new BANANA.Windows.Controls.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCOMPANY_CD = new BANANA.Windows.Controls.Label();
            this.lblUSR_ID = new BANANA.Windows.Controls.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUSR_PASS = new BANANA.Windows.Controls.Label();
            this.lblUSR_ROLL = new BANANA.Windows.Controls.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnFindZipCode01 = new DemoClient.Controls.BananaButton();
            this._txtZIP_NO = new BANANA.Windows.Controls.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTELNO = new BANANA.Windows.Controls.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtLNR_NM = new BANANA.Windows.Controls.TextBox();
            this._txtPRSNT_NM = new BANANA.Windows.Controls.TextBox();
            this._txtADDR_BSC = new BANANA.Windows.Controls.TextBox();
            this._txtADDR_DTL = new BANANA.Windows.Controls.TextBox();
            this._txtFAXNO = new BANANA.Windows.Controls.TextBox();
            this._txtMEMO = new BANANA.Windows.Controls.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnClose = new DemoClient.Controls.BananaButton();
            this._btnSave = new DemoClient.Controls.BananaButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtBI_ADDR_BSC
            // 
            this._txtBI_ADDR_BSC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_ADDR_BSC.DelegateProperty = true;
            this._txtBI_ADDR_BSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_ADDR_BSC.Location = new System.Drawing.Point(333, 57);
            this._txtBI_ADDR_BSC.Name = "_txtBI_ADDR_BSC";
            this._txtBI_ADDR_BSC.Size = new System.Drawing.Size(130, 20);
            this._txtBI_ADDR_BSC.TabIndex = 360;
            this._txtBI_ADDR_BSC.ValidationGroup = null;
            this._txtBI_ADDR_BSC.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_ADDR_BSC.WaterMarkText = "";
            // 
            // _txtBI_BUBIN_NO
            // 
            this._txtBI_BUBIN_NO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_BUBIN_NO.DelegateProperty = true;
            this._txtBI_BUBIN_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_BUBIN_NO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtBI_BUBIN_NO.Location = new System.Drawing.Point(333, 30);
            this._txtBI_BUBIN_NO.Name = "_txtBI_BUBIN_NO";
            this._txtBI_BUBIN_NO.Size = new System.Drawing.Size(130, 20);
            this._txtBI_BUBIN_NO.TabIndex = 340;
            this._txtBI_BUBIN_NO.ValidationGroup = null;
            this._txtBI_BUBIN_NO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_BUBIN_NO.WaterMarkText = "(숫자와 -기호만 사용)";
            // 
            // _txtBI_SAUP_NO
            // 
            this._txtBI_SAUP_NO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_SAUP_NO.DelegateProperty = true;
            this._txtBI_SAUP_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_SAUP_NO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtBI_SAUP_NO.Location = new System.Drawing.Point(103, 30);
            this._txtBI_SAUP_NO.Name = "_txtBI_SAUP_NO";
            this._txtBI_SAUP_NO.Size = new System.Drawing.Size(130, 20);
            this._txtBI_SAUP_NO.TabIndex = 330;
            this._txtBI_SAUP_NO.ValidationGroup = null;
            this._txtBI_SAUP_NO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_SAUP_NO.WaterMarkText = "(숫자와 -기호만 사용)";
            // 
            // _txtBI_PRSNT_NM
            // 
            this._txtBI_PRSNT_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_PRSNT_NM.DelegateProperty = true;
            this._txtBI_PRSNT_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_PRSNT_NM.Location = new System.Drawing.Point(333, 3);
            this._txtBI_PRSNT_NM.Name = "_txtBI_PRSNT_NM";
            this._txtBI_PRSNT_NM.Size = new System.Drawing.Size(130, 20);
            this._txtBI_PRSNT_NM.TabIndex = 310;
            this._txtBI_PRSNT_NM.ValidationGroup = null;
            this._txtBI_PRSNT_NM.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_PRSNT_NM.WaterMarkText = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "법인명";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "사업자등록번호";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "우편번호";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "대표자명";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "법인등록번호";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "기본주소";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(492, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "사업자구분";
            // 
            // _txtBI_COMPANY_NM
            // 
            this._txtBI_COMPANY_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_COMPANY_NM.DelegateProperty = true;
            this._txtBI_COMPANY_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_COMPANY_NM.Location = new System.Drawing.Point(103, 3);
            this._txtBI_COMPANY_NM.Name = "_txtBI_COMPANY_NM";
            this._txtBI_COMPANY_NM.Size = new System.Drawing.Size(130, 20);
            this._txtBI_COMPANY_NM.TabIndex = 300;
            this._txtBI_COMPANY_NM.ValidationGroup = null;
            this._txtBI_COMPANY_NM.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_COMPANY_NM.WaterMarkText = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "상세주소";
            // 
            // _txtBI_ADDR_DTL
            // 
            this._txtBI_ADDR_DTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_ADDR_DTL.DelegateProperty = true;
            this._txtBI_ADDR_DTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_ADDR_DTL.Location = new System.Drawing.Point(563, 57);
            this._txtBI_ADDR_DTL.Name = "_txtBI_ADDR_DTL";
            this._txtBI_ADDR_DTL.Size = new System.Drawing.Size(130, 20);
            this._txtBI_ADDR_DTL.TabIndex = 370;
            this._txtBI_ADDR_DTL.ValidationGroup = null;
            this._txtBI_ADDR_DTL.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_ADDR_DTL.WaterMarkText = "";
            this._txtBI_ADDR_DTL.Leave += new System.EventHandler(this._txtBI_ADDR_DTL_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "종목";
            // 
            // _txtBI_EMAIL
            // 
            this._txtBI_EMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_EMAIL.DelegateProperty = true;
            this._txtBI_EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_EMAIL.Location = new System.Drawing.Point(563, 84);
            this._txtBI_EMAIL.Name = "_txtBI_EMAIL";
            this._txtBI_EMAIL.Size = new System.Drawing.Size(130, 20);
            this._txtBI_EMAIL.TabIndex = 400;
            this._txtBI_EMAIL.ValidationGroup = null;
            this._txtBI_EMAIL.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_EMAIL.WaterMarkText = "";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(476, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "계산서 이메일";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnFindZipCode02);
            this.panel1.Controls.Add(this._txtBI_ZIP_NO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 27);
            this.panel1.TabIndex = 350;
            this.panel1.TabStop = true;
            // 
            // _btnFindZipCode02
            // 
            this._btnFindZipCode02.DelegateProperty = true;
            this._btnFindZipCode02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFindZipCode02.Location = new System.Drawing.Point(79, 3);
            this._btnFindZipCode02.Name = "_btnFindZipCode02";
            this._btnFindZipCode02.Size = new System.Drawing.Size(54, 21);
            this._btnFindZipCode02.TabIndex = 401;
            this._btnFindZipCode02.TabStop = false;
            this._btnFindZipCode02.Text = "검   색";
            this._btnFindZipCode02.UseVisualStyleBackColor = true;
            this._btnFindZipCode02.ValidationGroup = null;
            this._btnFindZipCode02.Click += new System.EventHandler(this._btnFindZipCode02_Click);
            // 
            // _txtBI_ZIP_NO
            // 
            this._txtBI_ZIP_NO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_ZIP_NO.DelegateProperty = true;
            this._txtBI_ZIP_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_ZIP_NO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtBI_ZIP_NO.Location = new System.Drawing.Point(3, 4);
            this._txtBI_ZIP_NO.Name = "_txtBI_ZIP_NO";
            this._txtBI_ZIP_NO.Size = new System.Drawing.Size(70, 20);
            this._txtBI_ZIP_NO.TabIndex = 350;
            this._txtBI_ZIP_NO.ValidationGroup = null;
            this._txtBI_ZIP_NO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_ZIP_NO.WaterMarkText = "";
            // 
            // _txtBI_JONGMOK
            // 
            this._txtBI_JONGMOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_JONGMOK.DelegateProperty = true;
            this._txtBI_JONGMOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_JONGMOK.Location = new System.Drawing.Point(333, 84);
            this._txtBI_JONGMOK.Name = "_txtBI_JONGMOK";
            this._txtBI_JONGMOK.Size = new System.Drawing.Size(130, 20);
            this._txtBI_JONGMOK.TabIndex = 390;
            this._txtBI_JONGMOK.ValidationGroup = null;
            this._txtBI_JONGMOK.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_JONGMOK.WaterMarkText = "";
            // 
            // _cmbBI_BINF_CD
            // 
            this._cmbBI_BINF_CD.DataSource = null;
            this._cmbBI_BINF_CD.Location = new System.Drawing.Point(563, 3);
            this._cmbBI_BINF_CD.MaximumSize = new System.Drawing.Size(500, 60);
            this._cmbBI_BINF_CD.MinimumSize = new System.Drawing.Size(100, 21);
            this._cmbBI_BINF_CD.Name = "_cmbBI_BINF_CD";
            this._cmbBI_BINF_CD.SelectedIndex = -1;
            this._cmbBI_BINF_CD.SelectedItem = null;
            this._cmbBI_BINF_CD.SelectedValue = null;
            this._cmbBI_BINF_CD.Size = new System.Drawing.Size(130, 21);
            this._cmbBI_BINF_CD.TabIndex = 320;
            this._cmbBI_BINF_CD.ValidationGroup = "A";
            // 
            // _txtBI_UPTE
            // 
            this._txtBI_UPTE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtBI_UPTE.DelegateProperty = true;
            this._txtBI_UPTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtBI_UPTE.Location = new System.Drawing.Point(103, 84);
            this._txtBI_UPTE.Name = "_txtBI_UPTE";
            this._txtBI_UPTE.Size = new System.Drawing.Size(130, 20);
            this._txtBI_UPTE.TabIndex = 380;
            this._txtBI_UPTE.ValidationGroup = null;
            this._txtBI_UPTE.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtBI_UPTE.WaterMarkText = "";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "업태";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.Controls.Add(this._txtBI_ADDR_BSC, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_BUBIN_NO, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_SAUP_NO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_PRSNT_NM, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_COMPANY_NM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_JONGMOK, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_ADDR_DTL, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_EMAIL, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this._cmbBI_BINF_CD, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this._txtBI_UPTE, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(700, 108);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 247);
            this.groupBox1.TabIndex = 502;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기본 정보";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCOMPANY_CD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_ID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_PASS, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_ROLL, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtTELNO, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtLNR_NM, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._txtPRSNT_NM, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this._txtADDR_BSC, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this._txtADDR_DTL, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this._txtFAXNO, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this._txtMEMO, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 220);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._chkAuto);
            this.panel3.Controls.Add(this._txtLNR_CD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 27);
            this.panel3.TabIndex = 100;
            // 
            // _chkAuto
            // 
            this._chkAuto.AutoSize = true;
            this._chkAuto.Checked = true;
            this._chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkAuto.Location = new System.Drawing.Point(67, 6);
            this._chkAuto.Name = "_chkAuto";
            this._chkAuto.Size = new System.Drawing.Size(72, 16);
            this._chkAuto.TabIndex = 110;
            this._chkAuto.Text = "자동채번";
            this._chkAuto.UseVisualStyleBackColor = true;
            this._chkAuto.CheckedChanged += new System.EventHandler(this._chkAuto_CheckedChanged);
            // 
            // _txtLNR_CD
            // 
            this._txtLNR_CD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtLNR_CD.DelegateProperty = true;
            this._txtLNR_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtLNR_CD.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtLNR_CD.Location = new System.Drawing.Point(3, 4);
            this._txtLNR_CD.MaxLength = 10;
            this._txtLNR_CD.Name = "_txtLNR_CD";
            this._txtLNR_CD.ReadOnly = true;
            this._txtLNR_CD.Size = new System.Drawing.Size(60, 20);
            this._txtLNR_CD.TabIndex = 100;
            this._txtLNR_CD.ValidationGroup = null;
            this._txtLNR_CD.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtLNR_CD.WaterMarkText = "";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 167;
            this.label16.Text = "메모";
            // 
            // lblCOMPANY_CD
            // 
            this.lblCOMPANY_CD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCOMPANY_CD.AutoSize = true;
            this.lblCOMPANY_CD.Location = new System.Drawing.Point(44, 7);
            this.lblCOMPANY_CD.Name = "lblCOMPANY_CD";
            this.lblCOMPANY_CD.Size = new System.Drawing.Size(53, 12);
            this.lblCOMPANY_CD.TabIndex = 0;
            this.lblCOMPANY_CD.Text = "회사코드";
            // 
            // lblUSR_ID
            // 
            this.lblUSR_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ID.AutoSize = true;
            this.lblUSR_ID.Location = new System.Drawing.Point(44, 34);
            this.lblUSR_ID.Name = "lblUSR_ID";
            this.lblUSR_ID.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_ID.TabIndex = 2;
            this.lblUSR_ID.Text = "우편번호";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "여신사명";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "기본주소";
            // 
            // lblUSR_PASS
            // 
            this.lblUSR_PASS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_PASS.AutoSize = true;
            this.lblUSR_PASS.Location = new System.Drawing.Point(504, 7);
            this.lblUSR_PASS.Name = "lblUSR_PASS";
            this.lblUSR_PASS.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_PASS.TabIndex = 8;
            this.lblUSR_PASS.Text = "대표자명";
            // 
            // lblUSR_ROLL
            // 
            this.lblUSR_ROLL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ROLL.AutoSize = true;
            this.lblUSR_ROLL.Location = new System.Drawing.Point(504, 34);
            this.lblUSR_ROLL.Name = "lblUSR_ROLL";
            this.lblUSR_ROLL.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_ROLL.TabIndex = 7;
            this.lblUSR_ROLL.Text = "상세주소";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnFindZipCode01);
            this.panel2.Controls.Add(this._txtZIP_NO);
            this.panel2.Location = new System.Drawing.Point(100, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 27);
            this.panel2.TabIndex = 140;
            this.panel2.TabStop = true;
            // 
            // _btnFindZipCode01
            // 
            this._btnFindZipCode01.DelegateProperty = true;
            this._btnFindZipCode01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFindZipCode01.Location = new System.Drawing.Point(79, 3);
            this._btnFindZipCode01.Name = "_btnFindZipCode01";
            this._btnFindZipCode01.Size = new System.Drawing.Size(54, 21);
            this._btnFindZipCode01.TabIndex = 401;
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
            this._txtZIP_NO.TabIndex = 140;
            this._txtZIP_NO.ValidationGroup = null;
            this._txtZIP_NO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtZIP_NO.WaterMarkText = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "전화번호";
            // 
            // _txtTELNO
            // 
            this._txtTELNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtTELNO.DelegateProperty = true;
            this._txtTELNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtTELNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtTELNO.Location = new System.Drawing.Point(103, 57);
            this._txtTELNO.Name = "_txtTELNO";
            this._txtTELNO.Size = new System.Drawing.Size(130, 20);
            this._txtTELNO.TabIndex = 170;
            this._txtTELNO.ValidationGroup = null;
            this._txtTELNO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtTELNO.WaterMarkText = "(숫자와 -기호만 사용)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "팩스번호";
            // 
            // _txtLNR_NM
            // 
            this._txtLNR_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtLNR_NM.Compulsory = true;
            this._txtLNR_NM.DelegateProperty = true;
            this._txtLNR_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtLNR_NM.Location = new System.Drawing.Point(333, 3);
            this._txtLNR_NM.Name = "_txtLNR_NM";
            this._txtLNR_NM.Size = new System.Drawing.Size(130, 20);
            this._txtLNR_NM.TabIndex = 120;
            this._txtLNR_NM.ValidationGroup = "A";
            this._txtLNR_NM.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtLNR_NM.WaterMarkText = "";
            // 
            // _txtPRSNT_NM
            // 
            this._txtPRSNT_NM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtPRSNT_NM.Compulsory = true;
            this._txtPRSNT_NM.DelegateProperty = true;
            this._txtPRSNT_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtPRSNT_NM.Location = new System.Drawing.Point(563, 3);
            this._txtPRSNT_NM.Name = "_txtPRSNT_NM";
            this._txtPRSNT_NM.Size = new System.Drawing.Size(130, 20);
            this._txtPRSNT_NM.TabIndex = 130;
            this._txtPRSNT_NM.ValidationGroup = "A";
            this._txtPRSNT_NM.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtPRSNT_NM.WaterMarkText = "";
            // 
            // _txtADDR_BSC
            // 
            this._txtADDR_BSC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtADDR_BSC.DelegateProperty = true;
            this._txtADDR_BSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtADDR_BSC.Location = new System.Drawing.Point(333, 30);
            this._txtADDR_BSC.Name = "_txtADDR_BSC";
            this._txtADDR_BSC.Size = new System.Drawing.Size(130, 20);
            this._txtADDR_BSC.TabIndex = 150;
            this._txtADDR_BSC.ValidationGroup = null;
            this._txtADDR_BSC.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtADDR_BSC.WaterMarkText = "";
            // 
            // _txtADDR_DTL
            // 
            this._txtADDR_DTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtADDR_DTL.DelegateProperty = true;
            this._txtADDR_DTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtADDR_DTL.Location = new System.Drawing.Point(563, 30);
            this._txtADDR_DTL.Name = "_txtADDR_DTL";
            this._txtADDR_DTL.Size = new System.Drawing.Size(130, 20);
            this._txtADDR_DTL.TabIndex = 160;
            this._txtADDR_DTL.ValidationGroup = null;
            this._txtADDR_DTL.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtADDR_DTL.WaterMarkText = "";
            this._txtADDR_DTL.Leave += new System.EventHandler(this._txtADDR_DTL_Leave);
            // 
            // _txtFAXNO
            // 
            this._txtFAXNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtFAXNO.DelegateProperty = true;
            this._txtFAXNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtFAXNO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtFAXNO.Location = new System.Drawing.Point(333, 57);
            this._txtFAXNO.Name = "_txtFAXNO";
            this._txtFAXNO.Size = new System.Drawing.Size(130, 20);
            this._txtFAXNO.TabIndex = 180;
            this._txtFAXNO.ValidationGroup = null;
            this._txtFAXNO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtFAXNO.WaterMarkText = "(숫자와 -기호만 사용)";
            // 
            // _txtMEMO
            // 
            this._txtMEMO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this._txtMEMO, 5);
            this._txtMEMO.DelegateProperty = true;
            this._txtMEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtMEMO.Location = new System.Drawing.Point(103, 86);
            this._txtMEMO.Multiline = true;
            this._txtMEMO.Name = "_txtMEMO";
            this._txtMEMO.Size = new System.Drawing.Size(590, 129);
            this._txtMEMO.TabIndex = 190;
            this._txtMEMO.ValidationGroup = null;
            this._txtMEMO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtMEMO.WaterMarkText = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 135);
            this.groupBox2.TabIndex = 503;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사업자등록정보";
            // 
            // _btnClose
            // 
            this._btnClose.DelegateProperty = true;
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.Image = global::DemoClient.Properties.Resources.red_62690;
            this._btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClose.Location = new System.Drawing.Point(611, 393);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 27);
            this._btnClose.TabIndex = 505;
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
            this._btnSave.Location = new System.Drawing.Point(530, 393);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 27);
            this._btnSave.TabIndex = 504;
            this._btnSave.Text = "      저   장";
            this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.ValidationGroup = "A";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // BAS0910
            // 
            this.ClientSize = new System.Drawing.Size(706, 424);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.groupBox2);
            this.Name = "BAS0910";
            this.Text = "여신사정보등록:BAS0910";
            this.Load += new System.EventHandler(this.BAS0910_Load);
            this.Shown += new System.EventHandler(this.BAS0910_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BANANA.Windows.Controls.TextBox _txtBI_ADDR_BSC;
        private BANANA.Windows.Controls.TextBox _txtBI_BUBIN_NO;
        private BANANA.Windows.Controls.TextBox _txtBI_SAUP_NO;
        private BANANA.Windows.Controls.TextBox _txtBI_PRSNT_NM;
        private BANANA.Windows.Controls.Label label6;
        private BANANA.Windows.Controls.Label label7;
        private BANANA.Windows.Controls.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private BANANA.Windows.Controls.Label label12;
        private BANANA.Windows.Controls.TextBox _txtBI_COMPANY_NM;
        private System.Windows.Forms.Label label5;
        private BANANA.Windows.Controls.TextBox _txtBI_ADDR_DTL;
        private System.Windows.Forms.Label label15;
        private BANANA.Windows.Controls.TextBox _txtBI_EMAIL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private DemoClient.Controls.BananaButton _btnFindZipCode02;
        private BANANA.Windows.Controls.TextBox _txtBI_ZIP_NO;
        private BANANA.Windows.Controls.TextBox _txtBI_JONGMOK;
        private BANANA.Windows.Controls.ComboBox _cmbBI_BINF_CD;
        private BANANA.Windows.Controls.TextBox _txtBI_UPTE;
        private BANANA.Windows.Controls.Label label13;
        private DemoClient.Controls.BananaButton _btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private BANANA.Windows.Controls.CheckBox _chkAuto;
        private BANANA.Windows.Controls.TextBox _txtLNR_CD;
        private System.Windows.Forms.Label label16;
        private BANANA.Windows.Controls.Label lblCOMPANY_CD;
        private BANANA.Windows.Controls.Label lblUSR_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BANANA.Windows.Controls.Label lblUSR_PASS;
        private BANANA.Windows.Controls.Label lblUSR_ROLL;
        private System.Windows.Forms.Panel panel2;
        private DemoClient.Controls.BananaButton _btnFindZipCode01;
        private BANANA.Windows.Controls.TextBox _txtZIP_NO;
        private System.Windows.Forms.Label label3;
        private BANANA.Windows.Controls.TextBox _txtTELNO;
        private System.Windows.Forms.Label label4;
        private BANANA.Windows.Controls.TextBox _txtLNR_NM;
        private BANANA.Windows.Controls.TextBox _txtPRSNT_NM;
        private BANANA.Windows.Controls.TextBox _txtADDR_BSC;
        private BANANA.Windows.Controls.TextBox _txtADDR_DTL;
        private BANANA.Windows.Controls.TextBox _txtFAXNO;
        private BANANA.Windows.Controls.TextBox _txtMEMO;
        private DemoClient.Controls.BananaButton _btnSave;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}
