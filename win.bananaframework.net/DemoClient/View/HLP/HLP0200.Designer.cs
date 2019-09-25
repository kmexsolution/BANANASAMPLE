namespace DemoClient.View.HLP
{
	partial class HLP0200
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP0200));
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._wbLeft = new System.Windows.Forms.WebBrowser();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._wbRight = new System.Windows.Forms.WebBrowser();
			this.collapsibleSplitter1 = new DemoClient.Controls.CollapsibleSplitter();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.panel1.Size = new System.Drawing.Size(408, 842);
			this.panel1.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._wbLeft);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(7, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(394, 830);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "목차";
			// 
			// _wbLeft
			// 
			this._wbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this._wbLeft.IsWebBrowserContextMenuEnabled = false;
			this._wbLeft.Location = new System.Drawing.Point(3, 22);
			this._wbLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this._wbLeft.MinimumSize = new System.Drawing.Size(26, 22);
			this._wbLeft.Name = "_wbLeft";
			this._wbLeft.ScriptErrorsSuppressed = true;
			this._wbLeft.Size = new System.Drawing.Size(388, 804);
			this._wbLeft.TabIndex = 0;
			this._wbLeft.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this._wbLeft_DocumentCompleted);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(416, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.panel2.Size = new System.Drawing.Size(928, 842);
			this.panel2.TabIndex = 7;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this._wbRight);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(7, 6);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(914, 830);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "사용법";
			// 
			// _wbRight
			// 
			this._wbRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this._wbRight.IsWebBrowserContextMenuEnabled = false;
			this._wbRight.Location = new System.Drawing.Point(3, 22);
			this._wbRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this._wbRight.MinimumSize = new System.Drawing.Size(26, 22);
			this._wbRight.Name = "_wbRight";
			this._wbRight.ScriptErrorsSuppressed = true;
			this._wbRight.Size = new System.Drawing.Size(908, 804);
			this._wbRight.TabIndex = 1;
			this._wbRight.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this._wbRight_DocumentCompleted);
			// 
			// collapsibleSplitter1
			// 
			this.collapsibleSplitter1.AnimationDelay = 20;
			this.collapsibleSplitter1.AnimationStep = 20;
			this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.collapsibleSplitter1.ControlToHide = this.panel1;
			this.collapsibleSplitter1.ExpandParentForm = true;
			this.collapsibleSplitter1.Location = new System.Drawing.Point(408, 0);
			this.collapsibleSplitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.collapsibleSplitter1.Name = "collapsibleSplitter1";
			this.collapsibleSplitter1.TabIndex = 8;
			this.collapsibleSplitter1.TabStop = false;
			this.collapsibleSplitter1.UseAnimations = true;
			this.collapsibleSplitter1.VisualStyle = DemoClient.Controls.VisualStyles.DoubleDots;
			// 
			// HLP0200
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1344, 842);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.collapsibleSplitter1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "HLP0200";
			this.Text = "프로그램 사용법:HLP0200";
			this.Load += new System.EventHandler(this.HLP200_Load);
			this.Shown += new System.EventHandler(this.HLP200_Shown);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private DemoClient.Controls.CollapsibleSplitter collapsibleSplitter1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.WebBrowser _wbLeft;
		public System.Windows.Forms.WebBrowser _wbRight;


	}
}