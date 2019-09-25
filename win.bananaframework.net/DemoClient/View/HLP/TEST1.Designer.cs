namespace DemoClient.View.HLP
{
    partial class TEST1
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
            this.treeView1 = new BANANA.Windows.Controls.TreeView();
            this.richTextBox1 = new BANANA.Windows.Controls.RichTextBox();
            this.listView1 = new BANANA.Windows.Controls.ListView();
            this.listBox1 = new BANANA.Windows.Controls.ListBox();
            this.groupBox1 = new BANANA.Windows.Controls.GroupBox();
            this.dateTimePicker1 = new BANANA.Windows.Controls.DateTimePicker();
            this.textBox1 = new BANANA.Windows.Controls.TextBox();
            this.radioButton2 = new BANANA.Windows.Controls.RadioButton();
            this.radioButton1 = new BANANA.Windows.Controls.RadioButton();
            this.label1 = new BANANA.Windows.Controls.Label();
            this._btnSearch = new BANANA.Windows.Controls.Button();
            this.comboBox1 = new BANANA.Windows.Controls.ComboBox();
            this.checkBox1 = new BANANA.Windows.Controls.CheckBox();
            this.textBox2 = new BANANA.Windows.Controls.TextBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(610, 304);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(208, 97);
            this.treeView1.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(610, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(208, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(610, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 97);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(610, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 16);
            this.listBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._btnSearch);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValidationGroup = null;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 18, 8, 56, 33, 51);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 9F);
            this.textBox1.Location = new System.Drawing.Point(671, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.ValidationGroup = null;
            this.textBox1.WaterMarkColor = System.Drawing.Color.Empty;
            this.textBox1.WaterMarkText = "";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(573, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(573, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(334, 20);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Reserved = "button1";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 0;
            this._btnSearch.Text = "button1";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.ValidationGroup = null;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = null;
            this.comboBox1.DroppedDown = false;
            this.comboBox1.Location = new System.Drawing.Point(149, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox1.SelectedItem = null;
            this.comboBox1.SelectedValue = null;
            this.comboBox1.Size = new System.Drawing.Size(75, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValidationGroup = null;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(230, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 9F);
            this.textBox2.Location = new System.Drawing.Point(16, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(566, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.ValidationGroup = null;
            this.textBox2.WaterMarkColor = System.Drawing.Color.Empty;
            this.textBox2.WaterMarkText = "";
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowAddNew = true;
            this.c1FlexGrid1.AllowDelete = true;
            this.c1FlexGrid1.ColumnInfo = "13,1,0,0,0,0,Columns:0{Width:20;}\t1{Width:100;}\t2{Width:100;}\t3{Width:100;}\t4{Wid" +
    "th:100;}\t5{Width:100;}\t";
            this.c1FlexGrid1.Location = new System.Drawing.Point(12, 77);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 18;
            this.c1FlexGrid1.Size = new System.Drawing.Size(570, 221);
            this.c1FlexGrid1.TabIndex = 16;
            // 
            // TEST1
            // 
            this.ClientSize = new System.Drawing.Size(832, 412);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TEST1";
            this.Text = "test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BANANA.Windows.Controls.CheckBox checkBox1;
        private BANANA.Windows.Controls.TreeView treeView1;
        private BANANA.Windows.Controls.RadioButton radioButton1;
        private BANANA.Windows.Controls.Label label1;
        private BANANA.Windows.Controls.Button _btnSearch;
        private BANANA.Windows.Controls.RichTextBox richTextBox1;
        private BANANA.Windows.Controls.TextBox textBox1;
        private BANANA.Windows.Controls.RadioButton radioButton2;
        private BANANA.Windows.Controls.ListView listView1;
        private BANANA.Windows.Controls.ComboBox comboBox1;
        private BANANA.Windows.Controls.ListBox listBox1;
        private BANANA.Windows.Controls.DateTimePicker dateTimePicker1;
        private BANANA.Windows.Controls.GroupBox groupBox1;
        private BANANA.Windows.Controls.TextBox textBox2;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}
