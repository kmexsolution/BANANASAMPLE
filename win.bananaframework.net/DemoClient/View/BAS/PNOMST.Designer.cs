namespace DemoClient.View.BAS
{
    partial class PNOMST
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new DemoClient.Controls.TableLayoutPanel();
            this._txtADDR_BSC = new BANANA.Windows.Controls.TextBox();
            this._txtZIP_NO = new BANANA.Windows.Controls.TextBox();
            this.s_txtPNO = new BANANA.Windows.Controls.TextBox();
            this.s_lupPGB = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUSR_NM_S = new BANANA.Windows.Controls.Label();
            this.s_txtPNM = new BANANA.Windows.Controls.TextBox();
            this.label16 = new BANANA.Windows.Controls.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnSearch = new DemoClient.Controls.BananaButton();
            this._btnSave = new DemoClient.Controls.BananaButton();
            this.lblUSR_ID_S = new BANANA.Windows.Controls.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_lupPGB.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this._txtADDR_BSC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._txtZIP_NO, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.s_txtPNO, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.s_lupPGB, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUSR_NM_S, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.s_txtPNM, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUSR_ID_S, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1262, 56);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _txtADDR_BSC
            // 
            this._txtADDR_BSC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtADDR_BSC.DelegateProperty = true;
            this._txtADDR_BSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtADDR_BSC.Location = new System.Drawing.Point(4, 32);
            this._txtADDR_BSC.Name = "_txtADDR_BSC";
            this._txtADDR_BSC.ReadOnly = true;
            this._txtADDR_BSC.Size = new System.Drawing.Size(84, 20);
            this._txtADDR_BSC.TabIndex = 1041;
            this._txtADDR_BSC.ValidationGroup = null;
            this._txtADDR_BSC.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtADDR_BSC.WaterMarkText = "";
            // 
            // _txtZIP_NO
            // 
            this._txtZIP_NO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._txtZIP_NO.DelegateProperty = true;
            this._txtZIP_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._txtZIP_NO.ImeMode = BANANA.Windows.Controls.ImeMode.DashNumeric;
            this._txtZIP_NO.Location = new System.Drawing.Point(95, 32);
            this._txtZIP_NO.MaxLength = 7;
            this._txtZIP_NO.Name = "_txtZIP_NO";
            this._txtZIP_NO.ReadOnly = true;
            this._txtZIP_NO.Size = new System.Drawing.Size(70, 20);
            this._txtZIP_NO.TabIndex = 1031;
            this._txtZIP_NO.ValidationGroup = null;
            this._txtZIP_NO.WaterMarkColor = System.Drawing.Color.Silver;
            this._txtZIP_NO.WaterMarkText = "";
            // 
            // s_txtPNO
            // 
            this.s_txtPNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_txtPNO.AutoTab = false;
            this.s_txtPNO.DelegateProperty = true;
            this.s_txtPNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.s_txtPNO.Location = new System.Drawing.Point(95, 4);
            this.s_txtPNO.Name = "s_txtPNO";
            this.s_txtPNO.Size = new System.Drawing.Size(130, 20);
            this.s_txtPNO.TabIndex = 100;
            this.s_txtPNO.ValidationGroup = null;
            this.s_txtPNO.WaterMarkColor = System.Drawing.Color.Empty;
            this.s_txtPNO.WaterMarkText = "";
            // 
            // s_lupPGB
            // 
            this.s_lupPGB.EditValue = "";
            this.s_lupPGB.Location = new System.Drawing.Point(569, 4);
            this.s_lupPGB.Name = "s_lupPGB";
            this.s_lupPGB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.s_lupPGB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.s_lupPGB.Size = new System.Drawing.Size(125, 20);
            this.s_lupPGB.TabIndex = 325;
            // 
            // lblUSR_NM_S
            // 
            this.lblUSR_NM_S.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSR_NM_S.AutoSize = true;
            this.lblUSR_NM_S.Location = new System.Drawing.Point(35, 8);
            this.lblUSR_NM_S.Name = "lblUSR_NM_S";
            this.lblUSR_NM_S.Size = new System.Drawing.Size(53, 12);
            this.lblUSR_NM_S.TabIndex = 9;
            this.lblUSR_NM_S.Text = "품번코드";
            // 
            // s_txtPNM
            // 
            this.s_txtPNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_txtPNM.AutoTab = false;
            this.s_txtPNM.DelegateProperty = true;
            this.s_txtPNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.s_txtPNM.Location = new System.Drawing.Point(327, 4);
            this.s_txtPNM.Name = "s_txtPNM";
            this.s_txtPNM.Size = new System.Drawing.Size(130, 20);
            this.s_txtPNM.TabIndex = 110;
            this.s_txtPNM.ValidationGroup = null;
            this.s_txtPNM.WaterMarkColor = System.Drawing.Color.Empty;
            this.s_txtPNM.WaterMarkText = "";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(509, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 301;
            this.label16.Text = "품번구분";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this._btnSearch);
            this.flowLayoutPanel1.Controls.Add(this._btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(707, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 27);
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
            this._btnSearch.Size = new System.Drawing.Size(88, 23);
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
            this._btnSave.Location = new System.Drawing.Point(88, 2);
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
            this.lblUSR_ID_S.Location = new System.Drawing.Point(279, 8);
            this.lblUSR_ID_S.Name = "lblUSR_ID_S";
            this.lblUSR_ID_S.Size = new System.Drawing.Size(41, 12);
            this.lblUSR_ID_S.TabIndex = 7;
            this.lblUSR_ID_S.Text = "품번명";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeList1);
            this.groupBox3.Controls.Add(this.gridControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 456);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 결과";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(830, 106);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(165, 37);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            null}, 3);
            this.treeList1.AppendNode(new object[] {
            null}, 3);
            this.treeList1.AppendNode(new object[] {
            null}, 3);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 2;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // PNOMST
            // 
            this.ClientSize = new System.Drawing.Size(1268, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PNOMST";
            this.Load += new System.EventHandler(this.PNOMST_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_lupPGB.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.TableLayoutPanel tableLayoutPanel3;
        private BANANA.Windows.Controls.TextBox s_txtPNO;
        private BANANA.Windows.Controls.Label lblUSR_NM_S;
        private BANANA.Windows.Controls.TextBox s_txtPNM;
        private BANANA.Windows.Controls.Label lblUSR_ID_S;
        private BANANA.Windows.Controls.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.BananaButton _btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LookUpEdit s_lupPGB;
        private Controls.BananaButton _btnSave;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private BANANA.Windows.Controls.TextBox _txtZIP_NO;
        private BANANA.Windows.Controls.TextBox _txtADDR_BSC;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
