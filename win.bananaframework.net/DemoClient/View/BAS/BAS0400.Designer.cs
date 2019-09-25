namespace DemoClient.View.BAS
{
	partial class BAS0400
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS0400));
			this.groupBox5 = new BANANA.Windows.Controls.GroupBox();
			this.gridView2 = new DemoClient.Controls.GridView();
			this.PRG_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_Screen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Search = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_List = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Save = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Excel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_New = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Modify = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Apply = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Send = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Next = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Previous = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Cancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Top = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Bottom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Left = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Right = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Grid_Etc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox3 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this._btnSearch2 = new DemoClient.Controls.BananaButton();
			this._btnSave2 = new DemoClient.Controls.BananaButton();
			this._txtCODE_NAME_S2 = new BANANA.Windows.Controls.TextBox();
			this.label2 = new BANANA.Windows.Controls.Label();
			this.label3 = new BANANA.Windows.Controls.Label();
			this._txtPRG_NAME_S = new BANANA.Windows.Controls.TextBox();
			this.panel1 = new BANANA.Windows.Controls.Panel();
			this.groupBox2 = new BANANA.Windows.Controls.GroupBox();
			this.gridView1 = new DemoClient.Controls.GridView();
			this.TOTAL_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CODE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this._txtCODE_NAME_S = new BANANA.Windows.Controls.TextBox();
			this.label1 = new BANANA.Windows.Controls.Label();
			this._btnSearch = new DemoClient.Controls.BananaButton();
			this.collapsibleSplitter2 = new DemoClient.Controls.CollapsibleSplitter();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.gridView2);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox5.Location = new System.Drawing.Point(336, 57);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(889, 610);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "상세코드 검색 결과";
			// 
			// gridView2
			// 
			this.gridView2.AutoSelectRowWithRightButton = false;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRG_ID,
            this.NAME,
            this.Grid_Screen,
            this.Grid_Search,
            this.Grid_List,
            this.Grid_Save,
            this.Grid_Delete,
            this.Grid_Print,
            this.Grid_Excel,
            this.Grid_New,
            this.Grid_Modify,
            this.Grid_Add,
            this.Grid_Apply,
            this.Grid_Send,
            this.Grid_Next,
            this.Grid_Previous,
            this.Grid_OK,
            this.Grid_Cancel,
            this.Grid_Top,
            this.Grid_Bottom,
            this.Grid_Left,
            this.Grid_Right,
            this.Grid_Etc});
			this.gridView2.DelegateProperty = true;
			this.gridView2.Location = new System.Drawing.Point(3, 21);
			this.gridView2.MultiSelect = false;
			this.gridView2.Name = "gridView2";
			this.gridView2.RowTemplate.Height = 23;
			this.gridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView2.Size = new System.Drawing.Size(883, 586);
			this.gridView2.TabIndex = 1;
			// 
			// PRG_ID
			// 
			this.PRG_ID.DataPropertyName = "PRG_ID";
			this.PRG_ID.Frozen = true;
			this.PRG_ID.HeaderText = "프로그램ID";
			this.PRG_ID.Name = "PRG_ID";
			this.PRG_ID.ReadOnly = true;
			this.PRG_ID.Width = 109;
			// 
			// NAME
			// 
			this.NAME.DataPropertyName = "NAME";
			this.NAME.Frozen = true;
			this.NAME.HeaderText = "프로그램명";
			this.NAME.Name = "NAME";
			this.NAME.ReadOnly = true;
			this.NAME.Width = 111;
			// 
			// Grid_Screen
			// 
			this.Grid_Screen.DataPropertyName = "Screen";
			this.Grid_Screen.FalseValue = "0";
			this.Grid_Screen.HeaderText = "Screen";
			this.Grid_Screen.Name = "Grid_Screen";
			this.Grid_Screen.TrueValue = "1";
			this.Grid_Screen.Width = 59;
			// 
			// Grid_Search
			// 
			this.Grid_Search.DataPropertyName = "Search";
			this.Grid_Search.FalseValue = "0";
			this.Grid_Search.HeaderText = "Search";
			this.Grid_Search.Name = "Grid_Search";
			this.Grid_Search.TrueValue = "1";
			this.Grid_Search.Width = 59;
			// 
			// Grid_List
			// 
			this.Grid_List.DataPropertyName = "List";
			this.Grid_List.FalseValue = "0";
			this.Grid_List.HeaderText = "List";
			this.Grid_List.Name = "Grid_List";
			this.Grid_List.TrueValue = "1";
			this.Grid_List.Width = 36;
			// 
			// Grid_Save
			// 
			this.Grid_Save.DataPropertyName = "Save";
			this.Grid_Save.FalseValue = "0";
			this.Grid_Save.HeaderText = "Save";
			this.Grid_Save.Name = "Grid_Save";
			this.Grid_Save.TrueValue = "1";
			this.Grid_Save.Width = 47;
			// 
			// Grid_Delete
			// 
			this.Grid_Delete.DataPropertyName = "Delete";
			this.Grid_Delete.FalseValue = "0";
			this.Grid_Delete.HeaderText = "Delete";
			this.Grid_Delete.Name = "Grid_Delete";
			this.Grid_Delete.TrueValue = "1";
			this.Grid_Delete.Width = 54;
			// 
			// Grid_Print
			// 
			this.Grid_Print.DataPropertyName = "Print";
			this.Grid_Print.FalseValue = "0";
			this.Grid_Print.HeaderText = "Print";
			this.Grid_Print.Name = "Grid_Print";
			this.Grid_Print.TrueValue = "1";
			this.Grid_Print.Width = 42;
			// 
			// Grid_Excel
			// 
			this.Grid_Excel.DataPropertyName = "Excel";
			this.Grid_Excel.FalseValue = "0";
			this.Grid_Excel.HeaderText = "Excel";
			this.Grid_Excel.Name = "Grid_Excel";
			this.Grid_Excel.TrueValue = "1";
			this.Grid_Excel.Width = 50;
			// 
			// Grid_New
			// 
			this.Grid_New.DataPropertyName = "New";
			this.Grid_New.FalseValue = "0";
			this.Grid_New.HeaderText = "New";
			this.Grid_New.Name = "Grid_New";
			this.Grid_New.TrueValue = "1";
			this.Grid_New.Width = 40;
			// 
			// Grid_Modify
			// 
			this.Grid_Modify.DataPropertyName = "Modify";
			this.Grid_Modify.FalseValue = "0";
			this.Grid_Modify.HeaderText = "Modify";
			this.Grid_Modify.Name = "Grid_Modify";
			this.Grid_Modify.TrueValue = "1";
			this.Grid_Modify.Width = 57;
			// 
			// Grid_Add
			// 
			this.Grid_Add.DataPropertyName = "Add";
			this.Grid_Add.FalseValue = "0";
			this.Grid_Add.HeaderText = "Add";
			this.Grid_Add.Name = "Grid_Add";
			this.Grid_Add.TrueValue = "1";
			this.Grid_Add.Width = 38;
			// 
			// Grid_Apply
			// 
			this.Grid_Apply.DataPropertyName = "Apply";
			this.Grid_Apply.FalseValue = "0";
			this.Grid_Apply.HeaderText = "Apply";
			this.Grid_Apply.Name = "Grid_Apply";
			this.Grid_Apply.TrueValue = "1";
			this.Grid_Apply.Width = 49;
			// 
			// Grid_Send
			// 
			this.Grid_Send.DataPropertyName = "Send";
			this.Grid_Send.FalseValue = "0";
			this.Grid_Send.HeaderText = "Send";
			this.Grid_Send.Name = "Grid_Send";
			this.Grid_Send.TrueValue = "1";
			this.Grid_Send.Width = 47;
			// 
			// Grid_Next
			// 
			this.Grid_Next.DataPropertyName = "Next";
			this.Grid_Next.FalseValue = "0";
			this.Grid_Next.HeaderText = "Next";
			this.Grid_Next.Name = "Grid_Next";
			this.Grid_Next.TrueValue = "1";
			this.Grid_Next.Width = 43;
			// 
			// Grid_Previous
			// 
			this.Grid_Previous.DataPropertyName = "Previous";
			this.Grid_Previous.FalseValue = "0";
			this.Grid_Previous.HeaderText = "Previous";
			this.Grid_Previous.Name = "Grid_Previous";
			this.Grid_Previous.TrueValue = "1";
			this.Grid_Previous.Width = 71;
			// 
			// Grid_OK
			// 
			this.Grid_OK.DataPropertyName = "OK";
			this.Grid_OK.FalseValue = "0";
			this.Grid_OK.HeaderText = "OK";
			this.Grid_OK.Name = "Grid_OK";
			this.Grid_OK.TrueValue = "1";
			this.Grid_OK.Width = 33;
			// 
			// Grid_Cancel
			// 
			this.Grid_Cancel.DataPropertyName = "Cancel";
			this.Grid_Cancel.FalseValue = "0";
			this.Grid_Cancel.HeaderText = "Cancel";
			this.Grid_Cancel.Name = "Grid_Cancel";
			this.Grid_Cancel.TrueValue = "1";
			this.Grid_Cancel.Width = 58;
			// 
			// Grid_Top
			// 
			this.Grid_Top.DataPropertyName = "Top";
			this.Grid_Top.FalseValue = "0";
			this.Grid_Top.HeaderText = "Top";
			this.Grid_Top.Name = "Grid_Top";
			this.Grid_Top.TrueValue = "1";
			this.Grid_Top.Width = 38;
			// 
			// Grid_Bottom
			// 
			this.Grid_Bottom.DataPropertyName = "Bottom";
			this.Grid_Bottom.FalseValue = "0";
			this.Grid_Bottom.HeaderText = "Bottom";
			this.Grid_Bottom.Name = "Grid_Bottom";
			this.Grid_Bottom.TrueValue = "1";
			this.Grid_Bottom.Width = 60;
			// 
			// Grid_Left
			// 
			this.Grid_Left.DataPropertyName = "Left";
			this.Grid_Left.FalseValue = "0";
			this.Grid_Left.HeaderText = "Left";
			this.Grid_Left.Name = "Grid_Left";
			this.Grid_Left.TrueValue = "1";
			this.Grid_Left.Width = 37;
			// 
			// Grid_Right
			// 
			this.Grid_Right.DataPropertyName = "Right";
			this.Grid_Right.FalseValue = "0";
			this.Grid_Right.HeaderText = "Right";
			this.Grid_Right.Name = "Grid_Right";
			this.Grid_Right.TrueValue = "1";
			this.Grid_Right.Width = 46;
			// 
			// Grid_Etc
			// 
			this.Grid_Etc.DataPropertyName = "Etc";
			this.Grid_Etc.FalseValue = "0";
			this.Grid_Etc.HeaderText = "Etc";
			this.Grid_Etc.Name = "Grid_Etc";
			this.Grid_Etc.TrueValue = "1";
			this.Grid_Etc.Width = 34;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(336, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(889, 57);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "상세코드 검색 조건";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtCODE_NAME_S2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this._txtPRG_NAME_S, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 33);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this._btnSearch2);
			this.flowLayoutPanel2.Controls.Add(this._btnSave2);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(460, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 33);
			this.flowLayoutPanel2.TabIndex = 1120;
			// 
			// _btnSearch2
			// 
			this._btnSearch2.DelegateProperty = true;
			this._btnSearch2.Enabled = false;
			this._btnSearch2.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch2.Location = new System.Drawing.Point(0, 4);
			this._btnSearch2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this._btnSearch2.Name = "_btnSearch2";
			this._btnSearch2.Reserved = "      검   색";
			this._btnSearch2.Size = new System.Drawing.Size(75, 23);
			this._btnSearch2.TabIndex = 120;
			this._btnSearch2.Text = "      검   색";
			this._btnSearch2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch2.UseVisualStyleBackColor = true;
			this._btnSearch2.ValidationGroup = null;
			this._btnSearch2.Click += new System.EventHandler(this._btnSearch2_Click);
			// 
			// _btnSave2
			// 
			this._btnSave2.DelegateProperty = true;
			this._btnSave2.Enabled = false;
			this._btnSave2.Image = global::DemoClient.Properties.Resources._1377801124_62679;
			this._btnSave2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave2.Location = new System.Drawing.Point(75, 4);
			this._btnSave2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this._btnSave2.Name = "_btnSave2";
			this._btnSave2.Reserved = "      저   장";
			this._btnSave2.Size = new System.Drawing.Size(75, 23);
			this._btnSave2.TabIndex = 121;
			this._btnSave2.Text = "      저   장";
			this._btnSave2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSave2.UseVisualStyleBackColor = true;
			this._btnSave2.ValidationGroup = null;
			this._btnSave2.Click += new System.EventHandler(this._btnSave2_Click);
			// 
			// _txtCODE_NAME_S2
			// 
			this._txtCODE_NAME_S2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCODE_NAME_S2.AutoTab = false;
			this._txtCODE_NAME_S2.DelegateProperty = true;
			this._txtCODE_NAME_S2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCODE_NAME_S2.Location = new System.Drawing.Point(93, 5);
			this._txtCODE_NAME_S2.Name = "_txtCODE_NAME_S2";
			this._txtCODE_NAME_S2.ReadOnly = true;
			this._txtCODE_NAME_S2.Size = new System.Drawing.Size(130, 23);
			this._txtCODE_NAME_S2.TabIndex = 100;
			this._txtCODE_NAME_S2.ValidationGroup = null;
			this._txtCODE_NAME_S2.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtCODE_NAME_S2.WaterMarkText = "";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "부서명";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(235, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 121;
			this.label3.Text = "프로그램명";
			// 
			// _txtPRG_NAME_S
			// 
			this._txtPRG_NAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtPRG_NAME_S.AutoTab = false;
			this._txtPRG_NAME_S.DelegateProperty = true;
			this._txtPRG_NAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtPRG_NAME_S.Location = new System.Drawing.Point(323, 5);
			this._txtPRG_NAME_S.Name = "_txtPRG_NAME_S";
			this._txtPRG_NAME_S.ReadOnly = true;
			this._txtPRG_NAME_S.Size = new System.Drawing.Size(130, 23);
			this._txtPRG_NAME_S.TabIndex = 122;
			this._txtPRG_NAME_S.ValidationGroup = null;
			this._txtPRG_NAME_S.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtPRG_NAME_S.WaterMarkText = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 667);
			this.panel1.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gridView1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(10, 62);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(308, 600);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "메인코드 검색 결과";
			// 
			// gridView1
			// 
			this.gridView1.AutoSelectRowWithRightButton = false;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOTAL_CODE,
            this.CODE_NAME});
			this.gridView1.DelegateProperty = true;
			this.gridView1.Location = new System.Drawing.Point(3, 21);
			this.gridView1.Name = "gridView1";
			this.gridView1.ReadOnly = true;
			this.gridView1.RowTemplate.Height = 23;
			this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridView1.Size = new System.Drawing.Size(302, 576);
			this.gridView1.TabIndex = 0;
			this.gridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView1_CellClick);
			// 
			// TOTAL_CODE
			// 
			this.TOTAL_CODE.DataPropertyName = "TOTAL_CODE";
			this.TOTAL_CODE.HeaderText = "부서코드";
			this.TOTAL_CODE.Name = "TOTAL_CODE";
			this.TOTAL_CODE.ReadOnly = true;
			this.TOTAL_CODE.Width = 96;
			// 
			// CODE_NAME
			// 
			this.CODE_NAME.DataPropertyName = "CODE_NAME";
			this.CODE_NAME.HeaderText = "부서명";
			this.CODE_NAME.Name = "CODE_NAME";
			this.CODE_NAME.ReadOnly = true;
			this.CODE_NAME.Width = 81;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(10, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 57);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "메인코드 검색 조건";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this._txtCODE_NAME_S, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this._btnSearch, 2, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(302, 33);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// _txtCODE_NAME_S
			// 
			this._txtCODE_NAME_S.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._txtCODE_NAME_S.AutoTab = false;
			this._txtCODE_NAME_S.DelegateProperty = true;
			this._txtCODE_NAME_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this._txtCODE_NAME_S.Location = new System.Drawing.Point(93, 5);
			this._txtCODE_NAME_S.Name = "_txtCODE_NAME_S";
			this._txtCODE_NAME_S.Size = new System.Drawing.Size(130, 23);
			this._txtCODE_NAME_S.TabIndex = 100;
			this._txtCODE_NAME_S.ValidationGroup = null;
			this._txtCODE_NAME_S.WaterMarkColor = System.Drawing.Color.Empty;
			this._txtCODE_NAME_S.WaterMarkText = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "부서명";
			// 
			// _btnSearch
			// 
			this._btnSearch.DelegateProperty = true;
			this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
			this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.Location = new System.Drawing.Point(230, 2);
			this._btnSearch.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this._btnSearch.Name = "_btnSearch";
			this._btnSearch.Reserved = "      검   색";
			this._btnSearch.Size = new System.Drawing.Size(75, 23);
			this._btnSearch.TabIndex = 120;
			this._btnSearch.Text = "      검   색";
			this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnSearch.UseVisualStyleBackColor = true;
			this._btnSearch.ValidationGroup = null;
			this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
			// 
			// collapsibleSplitter2
			// 
			this.collapsibleSplitter2.AnimationDelay = 20;
			this.collapsibleSplitter2.AnimationStep = 20;
			this.collapsibleSplitter2.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
			this.collapsibleSplitter2.ControlToHide = this.panel1;
			this.collapsibleSplitter2.ExpandParentForm = false;
			this.collapsibleSplitter2.Location = new System.Drawing.Point(328, 0);
			this.collapsibleSplitter2.Name = "collapsibleSplitter2";
			this.collapsibleSplitter2.TabIndex = 7;
			this.collapsibleSplitter2.TabStop = false;
			this.collapsibleSplitter2.UseAnimations = false;
			this.collapsibleSplitter2.VisualStyle = DemoClient.Controls.VisualStyles.Mozilla;
			this.collapsibleSplitter2.DoubleClick += new System.EventHandler(this.collapsibleSplitter2_DoubleClick);
			// 
			// BAS0400
			// 
			this.ClientSize = new System.Drawing.Size(1225, 667);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.collapsibleSplitter2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BAS0400";
			this.Text = "시스템권한관리:BAS0400";
			this.Load += new System.EventHandler(this.BAS0400_Load);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BANANA.Windows.Controls.Panel panel1;
		private BANANA.Windows.Controls.GroupBox groupBox2;
		private DemoClient.Controls.GridView gridView1;
		private BANANA.Windows.Controls.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private BANANA.Windows.Controls.TextBox _txtCODE_NAME_S;
		private BANANA.Windows.Controls.Label label1;
		private DemoClient.Controls.BananaButton _btnSearch;
		private DemoClient.Controls.CollapsibleSplitter collapsibleSplitter2;
		private BANANA.Windows.Controls.GroupBox groupBox5;
		private DemoClient.Controls.GridView gridView2;
		private BANANA.Windows.Controls.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private BANANA.Windows.Controls.TextBox _txtCODE_NAME_S2;
		private BANANA.Windows.Controls.Label label2;
		private DemoClient.Controls.BananaButton _btnSearch2;
		private BANANA.Windows.Controls.Label label3;
		private BANANA.Windows.Controls.TextBox _txtPRG_NAME_S;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_CODE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CODE_NAME;
		private DemoClient.Controls.BananaButton _btnSave2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRG_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Screen;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Search;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_List;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Save;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Delete;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Print;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Excel;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_New;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Modify;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Add;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Apply;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Send;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Next;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Previous;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_OK;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Cancel;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Top;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Bottom;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Left;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Right;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Grid_Etc;


	}
}
