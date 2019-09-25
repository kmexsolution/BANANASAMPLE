using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace DemoClient.View.Common
{
	/// <summary>
	/// 제  목: 가맹점검색 공통 화면
	/// 작성자: 한인수 (crowlead1208@devpia.com, 010-8633-2208)
	/// 작성일: 2016-08-03 14:43
	/// 설  명: 가맹점정보를 검색하는 화면입니다.
	/// </summary>
	public partial class STR_Form : DemoClient.Controllers.BasePopupForm
	{
		private Thread _thread;	// 검색 쓰레드
		public string strSTR_Data { get; set; }

		#region STR_Form : 생성자
		/// <summary>
		/// 생성자
		/// </summary>
		public STR_Form()
		{
			InitializeComponent();
		}
		#endregion

		#region _btnSearch_Click : 검색 버튼 클릭 이벤트
		/// <summary>
		/// 검색 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSearch_Click(object sender, EventArgs e)
		{
			_thread = new Thread(new ThreadStart(SearchThread));
			_thread.Start();
		}

		/// <summary>
		/// 검색 쓰레드
		/// </summary>
		void SearchThread()
		{
			try
			{
				DataTable _dt = base.GetDataTable(
					"PCSP_STR_FORM_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM.Text
					);
				gridView1.DataSource = _dt;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView1_CellDoubleClick : 그리드 더블 클릭 이벤트
		/// <summary>
		/// 그리드 더블 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (gridView1.CurrentRow == null)
					return;

				DataGridViewRow _row = gridView1.CurrentRow;
				
				string _strSTR_CD		= _row.Cells["STR_CD"].Value.ToString();		// 가맹점코드
				string _strSTR_NM		= _row.Cells["STR_NM"].Value.ToString();		// 가맹점명
				string _strPRSNT_NM		= _row.Cells["PRSNT_NM"].Value.ToString();		// 대표자명
				string _strADDR_BSC		= _row.Cells["ADDR_BSC"].Value.ToString();		// 기본주소
				string _strBI_BINF_CD	= _row.Cells["BI_BINF_CD"].Value.ToString();	// 사업자구분
				string _strBI_SAUP_NO	= _row.Cells["BI_SAUP_NO"].Value.ToString();	// 사업자등록번호
				string _strTELNO		= _row.Cells["TELNO"].Value.ToString();			// 전화번호
				string _strFAXNO		= _row.Cells["FAXNO"].Value.ToString();			// 팩스번호

				strSTR_Data = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}"
											, _strSTR_CD
											, _strSTR_NM		
											, _strPRSNT_NM		
											, _strADDR_BSC		
											, _strBI_BINF_CD	
											, _strBI_SAUP_NO	
											, _strTELNO		
											, _strFAXNO		
											);
				// OK 반환
				this.DialogResult = System.Windows.Forms.DialogResult.OK;

				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _txtSTR_NM_KeyDown : 가맹점 명 엔터 키 펀칭 이벤트
		/// <summary>
		/// 가맹점 명 엔터 키 펀칭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtSTR_NM_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnSearch.PerformClick();
			}
		}
		#endregion
	}
}
