using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient
{
	public partial class BAS0831 : DemoClient.Controllers.BasePopupForm
	{
		public int BAS0830_IDX { get; set; }
		public int BAS0832_IDX { get; set; }
		public DateTime EXCPT_DT_STRT { get; set; }
		public DateTime EXCPT_DT_END { get; set; }

		public BAS0831()
		{
			InitializeComponent();
		}

		private void BAS0831_Load(object sender, EventArgs e)
		{
			if (BAS0832_IDX == 0)
			{
				_dtpEXCPT_DT_STRT.Checked	= false;
				_dtpEXCPT_DT_END.Checked	= false;
			}
			else
			{
				_dtpEXCPT_DT_STRT.Value		= EXCPT_DT_STRT;
				_dtpEXCPT_DT_END.Value		= EXCPT_DT_END;
			}
		}

		private void _btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (_dtpEXCPT_DT_STRT.Value > _dtpEXCPT_DT_END.Value)
				{
					MessageBox.Show("시작일이 종료일보다 늦을 수는 없습니다.");
					return;
				}

				// 등록
				if (this.BAS0832_IDX == 0)
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0831_C1"
						, BAS0830_IDX											// 마스터일련번호
						, _dtpEXCPT_DT_STRT.Value.ToString("yyyy-MM-dd")		// 예외시작일
						, _dtpEXCPT_DT_END.Value.ToString("yyyy-MM-dd")			// 예외종료일
						, MEMO.Text												// 메모
						, ""													// 비고
						, base.GetCookie("USRID")								// 시스템등록자ID
						, base.GetCookie("USRNM")								// 시스템등록자명
						);

					MessageBox.Show("예외기간을 등록 하였습니다.");
				}
				// 수정
				else
				{
					base.ExecuteNonQuery(
						"PCSP_BAS0831_U1"
						, this.BAS0832_IDX										// 일련번호
						, _dtpEXCPT_DT_STRT.Value.ToString("yyyy-MM-dd")		// 예외시작일
						, _dtpEXCPT_DT_END.Value.ToString("yyyy-MM-dd")			// 예외종료일
						, MEMO.Text												// 메모
						, ""													// 비고
						, base.GetCookie("USRID")								// 시스템수정자ID
						, base.GetCookie("USRNM")								// 시스템수정자명
						);

					MessageBox.Show("예외기간을 수정 하였습니다.");
				}

				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void _btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
