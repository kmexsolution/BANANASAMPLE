namespace DemoClient.View.ACC
{
	partial class ACC0110
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACC0110));
			this._pgBar = new BANANA.Windows.Controls.ProgressBar();
			this._lblStatus = new BANANA.Windows.Controls.Label();
			this.SuspendLayout();
			// 
			// _pgBar
			// 
			this._pgBar.DelegateProperty = true;
			this._pgBar.Location = new System.Drawing.Point(12, 22);
			this._pgBar.Name = "_pgBar";
			this._pgBar.Size = new System.Drawing.Size(460, 23);
			this._pgBar.TabIndex = 0;
			this._pgBar.Text = "progressBar1";
			// 
			// _lblStatus
			// 
			this._lblStatus.AutoSize = true;
			this._lblStatus.Location = new System.Drawing.Point(12, 55);
			this._lblStatus.Name = "_lblStatus";
			this._lblStatus.Size = new System.Drawing.Size(35, 13);
			this._lblStatus.TabIndex = 1;
			this._lblStatus.Text = "label1";
			// 
			// ACC0110
			// 
			this.ClientSize = new System.Drawing.Size(484, 89);
			this.ControlBox = false;
			this.Controls.Add(this._lblStatus);
			this.Controls.Add(this._pgBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ACC0110";
			this.Text = "정산마감처리중:ACC0110";
			this.Shown += new System.EventHandler(this.ACC0110_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BANANA.Windows.Controls.ProgressBar _pgBar;
		private BANANA.Windows.Controls.Label _lblStatus;
	}
}
