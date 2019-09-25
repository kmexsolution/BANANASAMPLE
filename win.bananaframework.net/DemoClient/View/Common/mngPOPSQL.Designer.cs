namespace DemoClient.View.Common
{
    partial class mngPOPSQL
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
            this.s_txtPOPCD = new BANANA.Windows.Controls.TextBox();
            this.lblUSR_NM_S = new BANANA.Windows.Controls.Label();
            this.s_txtPOPSQL = new BANANA.Windows.Controls.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnSave = new DemoClient.Controls.BananaButton();
            this.lblUSR_ID_S = new BANANA.Windows.Controls.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.g10 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pop_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pop_sql = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribMDL_CD = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.rilUNIT_BC = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel2 = new DemoClient.Controls.TableLayoutPanel();
            this.txt_SQL = new BANANA.Windows.Controls.TextBox();
            this.label1 = new BANANA.Windows.Controls.Label();
            this.label2 = new BANANA.Windows.Controls.Label();
            this.txt_CD = new BANANA.Windows.Controls.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribMDL_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilUNIT_BC)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1399, 53);
            this.groupBox1.TabIndex = 4;
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
            this.tableLayoutPanel1.Controls.Add(this.s_txtPOPCD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_NM_S, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.s_txtPOPSQL, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUSR_ID_S, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1393, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // s_txtPOPCD
            // 
            this.s_txtPOPCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_txtPOPCD.AutoTab = false;
            this.s_txtPOPCD.DelegateProperty = true;
            this.s_txtPOPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.s_txtPOPCD.Location = new System.Drawing.Point(95, 4);
            this.s_txtPOPCD.Name = "s_txtPOPCD";
            this.s_txtPOPCD.Size = new System.Drawing.Size(130, 23);
            this.s_txtPOPCD.TabIndex = 100;
            this.s_txtPOPCD.ValidationGroup = null;
            this.s_txtPOPCD.WaterMarkColor = System.Drawing.Color.Empty;
            this.s_txtPOPCD.WaterMarkText = "";
            // 
            // lblUSR_NM_S
            // 
            this.lblUSR_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_NM_S.AutoSize = true;
            this.lblUSR_NM_S.Location = new System.Drawing.Point(33, 7);
            this.lblUSR_NM_S.Name = "lblUSR_NM_S";
            this.lblUSR_NM_S.Size = new System.Drawing.Size(55, 17);
            this.lblUSR_NM_S.TabIndex = 9;
            this.lblUSR_NM_S.Text = "pop_cd";
            // 
            // s_txtPOPSQL
            // 
            this.s_txtPOPSQL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_txtPOPSQL.AutoTab = false;
            this.s_txtPOPSQL.DelegateProperty = true;
            this.s_txtPOPSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.s_txtPOPSQL.Location = new System.Drawing.Point(327, 4);
            this.s_txtPOPSQL.Name = "s_txtPOPSQL";
            this.s_txtPOPSQL.Size = new System.Drawing.Size(194, 23);
            this.s_txtPOPSQL.TabIndex = 110;
            this.s_txtPOPSQL.ValidationGroup = null;
            this.s_txtPOPSQL.WaterMarkColor = System.Drawing.Color.Empty;
            this.s_txtPOPSQL.WaterMarkText = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this._btnSearch);
            this.flowLayoutPanel1.Controls.Add(this._btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(827, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 30);
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
            // lblUSR_ID_S
            // 
            this.lblUSR_ID_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_ID_S.AutoSize = true;
            this.lblUSR_ID_S.Location = new System.Drawing.Point(262, 7);
            this.lblUSR_ID_S.Name = "lblUSR_ID_S";
            this.lblUSR_ID_S.Size = new System.Drawing.Size(58, 17);
            this.lblUSR_ID_S.TabIndex = 7;
            this.lblUSR_ID_S.Text = "pop_sql";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1399, 759);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.g10);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 759);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 결과";
            // 
            // g10
            // 
            this.g10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g10.Location = new System.Drawing.Point(3, 18);
            this.g10.MainView = this.gridView1;
            this.g10.Name = "g10";
            this.g10.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribMDL_CD,
            this.rilUNIT_BC});
            this.g10.Size = new System.Drawing.Size(417, 738);
            this.g10.TabIndex = 0;
            this.g10.UseEmbeddedNavigator = true;
            this.g10.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pop_cd,
            this.pop_sql});
            this.gridView1.GridControl = this.g10;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // pop_cd
            // 
            this.pop_cd.Caption = "PopUp Code";
            this.pop_cd.FieldName = "pop_cd";
            this.pop_cd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.pop_cd.MinWidth = 25;
            this.pop_cd.Name = "pop_cd";
            this.pop_cd.Visible = true;
            this.pop_cd.VisibleIndex = 0;
            this.pop_cd.Width = 129;
            // 
            // pop_sql
            // 
            this.pop_sql.Caption = "PopUp Query";
            this.pop_sql.FieldName = "pop_sql";
            this.pop_sql.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.pop_sql.MinWidth = 25;
            this.pop_sql.Name = "pop_sql";
            this.pop_sql.Visible = true;
            this.pop_sql.VisibleIndex = 1;
            this.pop_sql.Width = 240;
            // 
            // ribMDL_CD
            // 
            this.ribMDL_CD.AutoHeight = false;
            this.ribMDL_CD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ribMDL_CD.Name = "ribMDL_CD";
            // 
            // rilUNIT_BC
            // 
            this.rilUNIT_BC.AutoHeight = false;
            this.rilUNIT_BC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilUNIT_BC.Name = "rilUNIT_BC";
            this.rilUNIT_BC.NullText = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_SQL, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_CD, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 759);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txt_SQL
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_SQL, 2);
            this.txt_SQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_SQL.Location = new System.Drawing.Point(4, 53);
            this.txt_SQL.Multiline = true;
            this.txt_SQL.Name = "txt_SQL";
            this.txt_SQL.Size = new System.Drawing.Size(964, 702);
            this.txt_SQL.TabIndex = 0;
            this.txt_SQL.ValidationGroup = null;
            this.txt_SQL.WaterMarkColor = System.Drawing.Color.Empty;
            this.txt_SQL.WaterMarkText = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "PopUp Code";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PopUp Sql";
            // 
            // txt_CD
            // 
            this.txt_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txt_CD.Location = new System.Drawing.Point(125, 4);
            this.txt_CD.MaxLength = 15;
            this.txt_CD.Name = "txt_CD";
            this.txt_CD.Size = new System.Drawing.Size(273, 22);
            this.txt_CD.TabIndex = 2;
            this.txt_CD.ValidationGroup = null;
            this.txt_CD.WaterMarkColor = System.Drawing.Color.Empty;
            this.txt_CD.WaterMarkText = "";
            this.txt_CD.TextChanged += new System.EventHandler(this.txt_CD_TextChanged);
            // 
            // mngPOPSQL
            // 
            this.ClientSize = new System.Drawing.Size(1399, 812);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "mngPOPSQL";
            this.Load += new System.EventHandler(this.mngPOPSQL_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribMDL_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilUNIT_BC)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel1;
        private BANANA.Windows.Controls.TextBox s_txtPOPCD;
        private BANANA.Windows.Controls.Label lblUSR_NM_S;
        private BANANA.Windows.Controls.TextBox s_txtPOPSQL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.BananaButton _btnSearch;
        private Controls.BananaButton _btnSave;
        private BANANA.Windows.Controls.Label lblUSR_ID_S;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl g10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn pop_cd;
        private DevExpress.XtraGrid.Columns.GridColumn pop_sql;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilUNIT_BC;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribMDL_CD;
        private BANANA.Windows.Controls.TextBox txt_SQL;
        private Controls.TableLayoutPanel tableLayoutPanel2;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.Label label2;
        private BANANA.Windows.Controls.TextBox txt_CD;
    }
}
