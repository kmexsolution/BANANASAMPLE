namespace DemoClient.View.BAS
{
    partial class mngWHSMST
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new DemoClient.Controls.TableLayoutPanel();
            this.label1 = new BANANA.Windows.Controls.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.s_rbALL = new BANANA.Windows.Controls.RadioButton();
            this.s_rbUSE = new BANANA.Windows.Controls.RadioButton();
            this.s_rbEND = new BANANA.Windows.Controls.RadioButton();
            this.s_txtWHCD = new BANANA.Windows.Controls.TextBox();
            this.lblUSR_NM_S = new BANANA.Windows.Controls.Label();
            this.s_txtWHNM = new BANANA.Windows.Controls.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnSave = new DemoClient.Controls.BananaButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lblUSR_ID_S = new BANANA.Windows.Controls.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.wh_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wh_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritWHNM = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.str_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ridSTR_DT = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.end_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ridEND_DT = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.use_yn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricUSE_YN = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wh_cd_old = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritWHNM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridSTR_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridSTR_DT.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridEND_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridEND_DT.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricUSE_YN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1329, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.s_txtWHCD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_NM_S, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.s_txtWHNM, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_ID_S, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 33);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 328;
            this.label1.Text = "사용구분";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.s_rbALL);
            this.flowLayoutPanel2.Controls.Add(this.s_rbUSE);
            this.flowLayoutPanel2.Controls.Add(this.s_rbEND);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(626, 1);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 31);
            this.flowLayoutPanel2.TabIndex = 327;
            // 
            // s_rbALL
            // 
            this.s_rbALL.AutoSize = true;
            this.s_rbALL.Checked = true;
            this.s_rbALL.Location = new System.Drawing.Point(3, 5);
            this.s_rbALL.Name = "s_rbALL";
            this.s_rbALL.Size = new System.Drawing.Size(47, 16);
            this.s_rbALL.TabIndex = 5;
            this.s_rbALL.TabStop = true;
            this.s_rbALL.Text = "전체";
            this.s_rbALL.UseVisualStyleBackColor = true;
            // 
            // s_rbUSE
            // 
            this.s_rbUSE.AutoSize = true;
            this.s_rbUSE.Location = new System.Drawing.Point(56, 5);
            this.s_rbUSE.Name = "s_rbUSE";
            this.s_rbUSE.Size = new System.Drawing.Size(47, 16);
            this.s_rbUSE.TabIndex = 6;
            this.s_rbUSE.Text = "사용";
            this.s_rbUSE.UseVisualStyleBackColor = true;
            // 
            // s_rbEND
            // 
            this.s_rbEND.AutoSize = true;
            this.s_rbEND.Location = new System.Drawing.Point(109, 5);
            this.s_rbEND.Name = "s_rbEND";
            this.s_rbEND.Size = new System.Drawing.Size(47, 16);
            this.s_rbEND.TabIndex = 7;
            this.s_rbEND.Text = "종료";
            this.s_rbEND.UseVisualStyleBackColor = true;
            // 
            // s_txtWHCD
            // 
            this.s_txtWHCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_txtWHCD.AutoTab = false;
            this.s_txtWHCD.DelegateProperty = true;
            this.s_txtWHCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.s_txtWHCD.Location = new System.Drawing.Point(95, 6);
            this.s_txtWHCD.Name = "s_txtWHCD";
            this.s_txtWHCD.Size = new System.Drawing.Size(130, 20);
            this.s_txtWHCD.TabIndex = 100;
            this.s_txtWHCD.ValidationGroup = null;
            this.s_txtWHCD.WaterMarkColor = System.Drawing.Color.Empty;
            this.s_txtWHCD.WaterMarkText = "";
            // 
            // lblUSR_NM_S
            // 
            this.lblUSR_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_NM_S.AutoSize = true;
            this.lblUSR_NM_S.Location = new System.Drawing.Point(35, 10);
            this.lblUSR_NM_S.Name = "lblUSR_NM_S";
            this.lblUSR_NM_S.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_NM_S.TabIndex = 9;
            this.lblUSR_NM_S.Text = "창고코드";
            // 
            // s_txtWHNM
            // 
            this.s_txtWHNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_txtWHNM.AutoTab = false;
            this.s_txtWHNM.DelegateProperty = true;
            this.s_txtWHNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.s_txtWHNM.Location = new System.Drawing.Point(327, 6);
            this.s_txtWHNM.Name = "s_txtWHNM";
            this.s_txtWHNM.Size = new System.Drawing.Size(194, 20);
            this.s_txtWHNM.TabIndex = 110;
            this.s_txtWHNM.ValidationGroup = null;
            this.s_txtWHNM.WaterMarkColor = System.Drawing.Color.Empty;
            this.s_txtWHNM.WaterMarkText = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this._btnSearch);
            this.flowLayoutPanel1.Controls.Add(this._btnSave);
            this.flowLayoutPanel1.Controls.Add(this.dateEdit1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(827, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 31);
            this.flowLayoutPanel1.TabIndex = 323;
            // 
            // _btnSearch
            // 
            this._btnSearch.DelegateProperty = true;
            this._btnSearch.Image = global::DemoClient.Properties.Resources._1377801181_62668;
            this._btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.Location = new System.Drawing.Point(0, 2);
            this._btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Reserved = "      검   색";
            this._btnSearch.Size = new System.Drawing.Size(92, 24);
            this._btnSearch.TabIndex = 160;
            this._btnSearch.Tag = "";
            this._btnSearch.Text = "      검   색";
            this._btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.ValidationGroup = null;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _btnSave
            // 
            this._btnSave.ButtonConfirm = true;
            this._btnSave.ButtonImage = DemoClient.Controls.ButtonImage.Save;
            this._btnSave.DelegateProperty = true;
            this._btnSave.Image = global::DemoClient.Properties.Resources._1377801124_62679;
            this._btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSave.Location = new System.Drawing.Point(92, 2);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Reserved = "      저   장";
            this._btnSave.Size = new System.Drawing.Size(92, 24);
            this._btnSave.TabIndex = 1101;
            this._btnSave.Text = "      저   장";
            this._btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.ValidationGroup = "A";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(187, 5);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(174, 20);
            this.dateEdit1.TabIndex = 1102;
            // 
            // lblUSR_ID_S
            // 
            this.lblUSR_ID_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ID_S.AutoSize = true;
            this.lblUSR_ID_S.Location = new System.Drawing.Point(279, 10);
            this.lblUSR_ID_S.Name = "lblUSR_ID_S";
            this.lblUSR_ID_S.Size = new System.Drawing.Size(41, 12);
            this.lblUSR_ID_S.TabIndex = 7;
            this.lblUSR_ID_S.Text = "창고명";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1329, 410);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 결과";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ridSTR_DT,
            this.ridEND_DT,
            this.ricUSE_YN,
            this.ritWHNM});
            this.gridControl1.Size = new System.Drawing.Size(1323, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.wh_cd,
            this.wh_nm,
            this.str_dt,
            this.end_dt,
            this.use_yn,
            this.cid,
            this.cdt,
            this.mid,
            this.mdt,
            this.wh_cd_old});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowCsvFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowRtfFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowTxtFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsClipboard.CopyCollapsedData = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // wh_cd
            // 
            this.wh_cd.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.wh_cd.AppearanceHeader.Options.UseForeColor = true;
            this.wh_cd.Caption = "창고코드";
            this.wh_cd.FieldName = "wh_cd";
            this.wh_cd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.wh_cd.MinWidth = 25;
            this.wh_cd.Name = "wh_cd";
            this.wh_cd.Visible = true;
            this.wh_cd.VisibleIndex = 0;
            this.wh_cd.Width = 129;
            // 
            // wh_nm
            // 
            this.wh_nm.Caption = "창고명";
            this.wh_nm.ColumnEdit = this.ritWHNM;
            this.wh_nm.FieldName = "wh_nm";
            this.wh_nm.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.wh_nm.MinWidth = 25;
            this.wh_nm.Name = "wh_nm";
            this.wh_nm.Visible = true;
            this.wh_nm.VisibleIndex = 1;
            this.wh_nm.Width = 240;
            // 
            // ritWHNM
            // 
            this.ritWHNM.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ritWHNM.AutoHeight = false;
            this.ritWHNM.Name = "ritWHNM";
            this.ritWHNM.ShowNullValuePromptWhenFocused = true;
            // 
            // str_dt
            // 
            this.str_dt.Caption = "적용시작일";
            this.str_dt.ColumnEdit = this.ridSTR_DT;
            this.str_dt.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.str_dt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.str_dt.FieldName = "str_dt";
            this.str_dt.MinWidth = 25;
            this.str_dt.Name = "str_dt";
            this.str_dt.Visible = true;
            this.str_dt.VisibleIndex = 2;
            this.str_dt.Width = 126;
            // 
            // ridSTR_DT
            // 
            this.ridSTR_DT.AutoHeight = false;
            this.ridSTR_DT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridSTR_DT.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridSTR_DT.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.ridSTR_DT.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ridSTR_DT.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.ridSTR_DT.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ridSTR_DT.CalendarTimeProperties.Mask.EditMask = "d";
            this.ridSTR_DT.CalendarTimeProperties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.ridSTR_DT.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.ridSTR_DT.MinValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ridSTR_DT.Name = "ridSTR_DT";
            this.ridSTR_DT.NullDate = "1900-01-01";
            this.ridSTR_DT.NullDateCalendarValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ridSTR_DT.NullText = "1900-01-01";
            // 
            // end_dt
            // 
            this.end_dt.AppearanceCell.Options.UseTextOptions = true;
            this.end_dt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.end_dt.Caption = "적용종료일";
            this.end_dt.ColumnEdit = this.ridEND_DT;
            this.end_dt.DisplayFormat.FormatString = "d";
            this.end_dt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.end_dt.FieldName = "end_dt";
            this.end_dt.MinWidth = 25;
            this.end_dt.Name = "end_dt";
            this.end_dt.Visible = true;
            this.end_dt.VisibleIndex = 3;
            this.end_dt.Width = 119;
            // 
            // ridEND_DT
            // 
            this.ridEND_DT.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ridEND_DT.AutoHeight = false;
            this.ridEND_DT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridEND_DT.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.ridEND_DT.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ridEND_DT.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridEND_DT.CalendarTimeProperties.TouchUIMaxValue = new System.DateTime(((long)(0)));
            this.ridEND_DT.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.ridEND_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ridEND_DT.EditFormat.FormatString = "yyyy-MM-dd";
            this.ridEND_DT.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ridEND_DT.Mask.EditMask = "yyyy-MM-dd";
            this.ridEND_DT.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.ridEND_DT.MinValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ridEND_DT.Name = "ridEND_DT";
            this.ridEND_DT.NullDate = "";
            // 
            // use_yn
            // 
            this.use_yn.Caption = "사용여부";
            this.use_yn.ColumnEdit = this.ricUSE_YN;
            this.use_yn.FieldName = "use_yn";
            this.use_yn.MinWidth = 25;
            this.use_yn.Name = "use_yn";
            this.use_yn.OptionsColumn.ReadOnly = true;
            this.use_yn.Visible = true;
            this.use_yn.VisibleIndex = 4;
            this.use_yn.Width = 107;
            // 
            // ricUSE_YN
            // 
            this.ricUSE_YN.AutoHeight = false;
            this.ricUSE_YN.Name = "ricUSE_YN";
            this.ricUSE_YN.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.ricUSE_YN.NullText = "N";
            this.ricUSE_YN.ValueChecked = "Y";
            this.ricUSE_YN.ValueUnchecked = "N";
            // 
            // cid
            // 
            this.cid.AppearanceCell.Options.UseTextOptions = true;
            this.cid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cid.Caption = "등록자";
            this.cid.FieldName = "cid";
            this.cid.MinWidth = 25;
            this.cid.Name = "cid";
            this.cid.OptionsColumn.AllowEdit = false;
            this.cid.OptionsColumn.ReadOnly = true;
            this.cid.Visible = true;
            this.cid.VisibleIndex = 5;
            this.cid.Width = 117;
            // 
            // cdt
            // 
            this.cdt.AppearanceCell.Options.UseTextOptions = true;
            this.cdt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cdt.Caption = "등록일시";
            this.cdt.DisplayFormat.FormatString = "yyyy-MM-dd HH:MM:ss";
            this.cdt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cdt.FieldName = "cdt";
            this.cdt.MinWidth = 25;
            this.cdt.Name = "cdt";
            this.cdt.OptionsColumn.AllowEdit = false;
            this.cdt.OptionsColumn.ReadOnly = true;
            this.cdt.Visible = true;
            this.cdt.VisibleIndex = 6;
            this.cdt.Width = 214;
            // 
            // mid
            // 
            this.mid.AppearanceCell.Options.UseTextOptions = true;
            this.mid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mid.Caption = "수정자";
            this.mid.FieldName = "mid";
            this.mid.MinWidth = 25;
            this.mid.Name = "mid";
            this.mid.OptionsColumn.AllowEdit = false;
            this.mid.OptionsColumn.ReadOnly = true;
            this.mid.Visible = true;
            this.mid.VisibleIndex = 7;
            this.mid.Width = 131;
            // 
            // mdt
            // 
            this.mdt.AppearanceCell.Options.UseTextOptions = true;
            this.mdt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mdt.Caption = "수정일시";
            this.mdt.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss";
            this.mdt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.mdt.FieldName = "mdt";
            this.mdt.MinWidth = 25;
            this.mdt.Name = "mdt";
            this.mdt.OptionsColumn.AllowEdit = false;
            this.mdt.OptionsColumn.ReadOnly = true;
            this.mdt.Visible = true;
            this.mdt.VisibleIndex = 8;
            this.mdt.Width = 222;
            // 
            // wh_cd_old
            // 
            this.wh_cd_old.Caption = "gridColumn1";
            this.wh_cd_old.FieldName = "wh_cd_old";
            this.wh_cd_old.MinWidth = 25;
            this.wh_cd_old.Name = "wh_cd_old";
            this.wh_cd_old.Width = 94;
            // 
            // mngWHSMST
            // 
            this.ClientSize = new System.Drawing.Size(1329, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "mngWHSMST";
            this.Text = "창고 관리";
            this.Load += new System.EventHandler(this.mngWHSMST_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritWHNM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridSTR_DT.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridSTR_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridEND_DT.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridEND_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricUSE_YN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel1;
        private BANANA.Windows.Controls.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private BANANA.Windows.Controls.RadioButton s_rbALL;
        private BANANA.Windows.Controls.RadioButton s_rbUSE;
        private BANANA.Windows.Controls.RadioButton s_rbEND;
        private BANANA.Windows.Controls.TextBox s_txtWHCD;
        private BANANA.Windows.Controls.Label lblUSR_NM_S;
        private BANANA.Windows.Controls.TextBox s_txtWHNM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.BananaButton _btnSearch;
        private Controls.BananaButton _btnSave;
        private BANANA.Windows.Controls.Label lblUSR_ID_S;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn wh_cd;
        private DevExpress.XtraGrid.Columns.GridColumn wh_nm;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ridSTR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn end_dt;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ridEND_DT;
        private DevExpress.XtraGrid.Columns.GridColumn use_yn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricUSE_YN;
        private DevExpress.XtraGrid.Columns.GridColumn cid;
        private DevExpress.XtraGrid.Columns.GridColumn cdt;
        private DevExpress.XtraGrid.Columns.GridColumn mid;
        private DevExpress.XtraGrid.Columns.GridColumn mdt;
        private DevExpress.XtraGrid.Columns.GridColumn wh_cd_old;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritWHNM;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn str_dt;
    }
}
