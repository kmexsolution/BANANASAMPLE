using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	/// <summary>
	/// 제  목: 대출한도조정
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-21 19:32
	/// 설  명: 가맹점의 대출한도를 관리하는 화면입니다.
	/// </summary>
	public partial class BAS0808 : DemoClient.Controllers.BasePopupForm
	{
		public string STR_CD { get; set; }
		public string STR_NM { get; set; }

		#region BAS0808 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0808()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0808_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0808_Load(object sender, EventArgs e)
		{
			try
			{
				this.Text	= string.Format("{1}({0}) {2}", this.STR_CD, this.STR_NM, this.Text);

				Search();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		void ClearControls()
		{
			_txtCI_UNIT_LMT.Text		= "";
			_txtCI_DAILY_LMT.Text		= "";
			_txtCI_TOT_LMT.Text			= "";
			_dtpCI_LMT_APP_DT.Value		= System.DateTime.Now;
			_dtpCI_LMT_APP_DT.Checked	= false;

			_btnSave.Enabled			= false;
			_btnDel.Enabled				= false;
		}
		#endregion

		#region Search : 검색 함수
		/// <summary>
		/// 검색 함수
		/// </summary>
		void Search()
		{
			try
			{
				DataTable _dt			= base.GetDataTable("PCSP_BAS0808_R1"
					, this.STR_CD
					);
				gridView1.DataSource	= _dt;
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region _btnAdd_Click : 추가 버튼 클릭 이벤트
		/// <summary>
		/// 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnAdd_Click(object sender, EventArgs e)
		{
			BAS0809 _form	= new BAS0809();
			_form.STR_CD	= this.STR_CD;
			_form.STR_NM	= this.STR_NM;
			_form.ShowDialog();

			Search();
			ClearControls();
		}
		#endregion

		#region _btnSave_Click : 저장 버튼 클릭 이벤트
		/// <summary>
		/// 저장 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0808_U1"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))	// 일련번호
					, this.STR_CD							// 가맹점코드
					, base.GetDate(_dtpCI_LMT_APP_DT)		// 적용시작일
					, base.GetInteger(_txtCI_UNIT_LMT)		// 건별대출한도
					, base.GetInteger(_txtCI_DAILY_LMT)		// 1일대출한도
					, base.GetInteger(_txtCI_TOT_LMT)		// 총대출한도
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				MessageBox.Show("대출한도를 조정 하였습니다.");
				Search();
				ClearControls();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnClose_Click : 닫기 버튼 클릭 이벤트
		/// <summary>
		/// 닫기 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region _btnDel_Click : 삭제 버튼 클릭 이벤트
		/// <summary>
		/// 삭제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				base.ExecuteNonQuery("PCSP_BAS0808_D1"
					, Convert.ToInt32(string.Format("{0}", gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value))	// 일련번호
					, this.STR_CD							// 가맹점코드
					, ""									// 비고
					, base.GetCookie("USRID")				// 시스템수정자ID
					, base.GetCookie("USRNM")				// 시스템수정자명
					);

				MessageBox.Show("대출한도를 삭제 하였습니다.");

				Search();
				ClearControls();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView1_CellClick : 그리드 클릭 시, 상세정보 바인딩
		/// <summary>
		/// 그리드 클릭 시, 상세정보 바인딩
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex > -1)
				{
					_txtCI_UNIT_LMT.Text		= string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["CI_UNIT_LMT"].Value);
					_txtCI_UNIT_LMT.ReadOnly	= false;

					_txtCI_DAILY_LMT.Text		= string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["CI_DAILY_LMT"].Value);
					_txtCI_DAILY_LMT.ReadOnly	= false;

					_txtCI_TOT_LMT.Text			= string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["CI_TOT_LMT"].Value);
					_txtCI_TOT_LMT.ReadOnly		= false;

					_dtpCI_LMT_APP_DT.Value		= string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["CI_LMT_APP_DT"].Value).Trim() == "" ? System.DateTime.Now : Convert.ToDateTime(string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["CI_LMT_APP_DT"].Value).Trim());
					_dtpCI_LMT_APP_DT.Checked	= string.Format("{0}", gridView1.Rows[e.RowIndex].Cells["CI_LMT_APP_DT"].Value).Trim() == "" ? false : true;
					_dtpCI_LMT_APP_DT.Enabled	= true;

					_btnSave.Enabled			= true;
					_btnDel.Enabled				= true;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
