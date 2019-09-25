using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.LRN
{
	/// <summary>
	/// 제  목: 비즈론원장관리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-27 18:38
	/// 설  명: 비즈론원장을 관리하는 화면입니다.
	/// </summary>
	public partial class LRN0100 : DemoClient.Controllers.BaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region LRN0100 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public LRN0100()
		{
			InitializeComponent();
		}
		#endregion

		#region LRN0100_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LRN0100_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpLNEXEC_S.Value		= Convert.ToDateTime("2016-07-01 00:00:00");
				_dtpLNEXEC_E.Value		= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));

				gridView1.ReadOnly			= false;

				// 대출원장상태코드
				DataTable _dt01		= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "L01", "", "Y", "", "");
				base.SetListItem(_cmbLNSTATE, _dt01, "TOTAL_CODE", "CODE_NAME", true);

				// 전체 그리드 ReadOnly 속성값 부여
				// 2016-12-01 한인수 수정
				// GridView.cs에서 하고 싶었으나 각 화면의 속성값을 최종적으로 가져가게 되어 화면단에서 처리
				foreach (DataGridViewColumn colum in gridView1.Columns)
				{
					colum.ReadOnly = true;
				}

				foreach (DataGridViewColumn colum in gridView2.Columns)
				{
					colum.ReadOnly = true;
				}

				foreach (DataGridViewColumn colum in gridView3.Columns)
				{
					colum.ReadOnly = true;
				}

				foreach (DataGridViewColumn colum in gridView4.Columns)
				{
					colum.ReadOnly = true;
				}

                // 스플릿바 처리
                if (!collapsibleSplitter1.IsCollapsed)
                {
                    collapsibleSplitter1.ToggleState();
                }
				
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
		public void ClearControls()
		{
            _rbINTRY.Checked = true;
            _rbINTRN.Checked = false;
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
            _dtpEXECDT.Enabled          = _bTrue;
            _cmbLNSTATE.Enabled		    = _bTrue;
            _txtLNAMT.Enabled           = _bTrue;
            _rbINTRY.Enabled            = _bTrue;
            _rbINTRN.Enabled            = _bTrue;
            _txtBIGO.ReadOnly           = !_bTrue;
            _btnSave.Enabled            = _bTrue;
            
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
        public void EnableControls2(bool _bTrue, string _lnstate)
		{
            

            // 대출상태 코드 분류에 따른 활성화 처리
            if (string.IsNullOrEmpty(_lnstate))
            {
                _dtpEXECDT.Enabled = _bTrue;
                _cmbLNSTATE.Enabled = _bTrue;
                _txtLNAMT.Enabled = _bTrue;
                _rbINTRY.Enabled = _bTrue;
                _rbINTRN.Enabled = _bTrue;
                _txtBIGO.ReadOnly = !_bTrue;

                _btnSave.Enabled = _bTrue;
                
            }
            else if (_lnstate.Equals("L01001") ||
                _lnstate.Equals("L01002") || 
                _lnstate.Equals("L01003"))
            {
                // 정상실행, 채권관리, 채무승계
                _dtpEXECDT.Enabled = !_bTrue;
                _cmbLNSTATE.Enabled = _bTrue;
                _txtLNAMT.Enabled = !_bTrue;
                _rbINTRY.Enabled = _bTrue;
                _rbINTRN.Enabled = _bTrue;
                _txtBIGO.ReadOnly = !_bTrue;

                _btnSave.Enabled = _bTrue;
            }
            else if (_lnstate.Equals("L01004"))
            {
                // 실행대기
                _dtpEXECDT.Enabled = _bTrue;
                _cmbLNSTATE.Enabled = _bTrue;
                _txtLNAMT.Enabled = _bTrue;
                _rbINTRY.Enabled = _bTrue;
                _rbINTRN.Enabled = _bTrue;
                _txtBIGO.ReadOnly = !_bTrue;

                _btnSave.Enabled = _bTrue;
                
            }
            else if (_lnstate.Equals("L01005"))
            {
                // 대출종료
                _btnSave.Enabled = !_bTrue;
                
                //MessageBox.Show("정보를 변경할 수 없습니다.");
                
            }
            
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
			// 스톱와치 시작
			base.MainForm.StartStopWatch();
			// 커서 기다림
			base.SetWaitCursor();
			// 컨트롤 비활성화
			EnableControls1(false);
			
			// 컨트롤 초기화
			ClearControls();

            // 스플릿바 처리
            if (!collapsibleSplitter1.IsCollapsed)
            {
                collapsibleSplitter1.ToggleState();
            }

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
				int res		= Search();
				string message	= string.Format("{0:N0}건이 검색되었습니다.", res);

				// 상태표시줄 업데이트
				base.MainForm.UpdateStatus(message);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				// 컨트롤 활성화
				EnableControls1(true);
				// 스톱와치 중지
				base.MainForm.StopStopWatch();
				// 커서 복원
				base.RestoreCursor();
			}
		}

		/// <summary>
		/// 실제 검색을 수행하는 함수이다.
		/// 작업표시줄 상태 메시지를 업데이트 하지 않기 때문에, 삭제 후 혹은 수정 후 등에 사용하면 된다.
		/// </summary>
		/// <returns></returns>
		int Search()
		{
			int _retValue	= -1;

			try
			{	
				DataTable _dt			= base.GetDataTable("PCSP_LRN0100_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
                    , _cmbLNSTATE.SelectedValue
					, _dtpLNEXEC_S.Value.ToString("yyyy-MM-dd")
					, _dtpLNEXEC_E.Value.ToString("yyyy-MM-dd")
					);
				gridView1.DataSource	= _dt;

				_retValue				= _dt.Rows.Count;

			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion

		#region gridView1_DataBindingComplete : 선택불가 Row에 대한 처리
		/// <summary>
		/// 선택불가 Row에 대한 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
            // 정산처리여부
            var lnstateRows = gridView1.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells["LNSTATENM"].Value.ToString().Trim().Equals("대출종료"))
                .Select(row => row);
            foreach (DataGridViewRow row in lnstateRows)
            {
                row.Cells["LNSTATENM"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
            }
        }
		#endregion

        #region gridView1_CellClick : 그리드 더블클릭 시, 상세정보 바인딩
        /// <summary>
        /// 그리드 클릭 시, 상세정보 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    // 스플릿바 처리
                    if (!collapsibleSplitter1.IsCollapsed)
                    {
                        collapsibleSplitter1.ToggleState();
                    }


                    // 대출원장상태코드
                    DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "L01", "", "Y", "", "");
                    base.SetListItem(_cmbLNSTATE_S1, _dt01, "TOTAL_CODE", "CODE_NAME", true);

                    DataSet _ds = base.GetDataSet("PCSP_LRN0100_R2"
                        , base.GetCookie("COMPANY_CD")
                        , gridView1.Rows[e.RowIndex].Cells["IDX"].Value
                        );

                    _txtIDX.Text = _ds.Tables[0].Rows[0]["IDX"].ToString();
                    _txtSTR_NM.Text = _ds.Tables[0].Rows[0]["STR_NM"].ToString();
                    _dtpEXECDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["EXECDT"]);
                    _cmbLNSTATE_S1.SelectedValue = _ds.Tables[0].Rows[0]["LNSTATE"].ToString();
                    _txtLNAMT.Text = _ds.Tables[0].Rows[0]["LNAMT"].ToString();
                    _rbINTRY.Checked = _ds.Tables[0].Rows[0]["INTRYN"].ToString().Equals("Y") ? true : false;
                    _rbINTRN.Checked = _ds.Tables[0].Rows[0]["INTRYN"].ToString().Equals("N") ? true : false;
                    _txtBIGO.Text = _ds.Tables[0].Rows[0]["BIGO"].ToString();

                    EnableControls2(true, _ds.Tables[0].Rows[0]["LNSTATE"].ToString());

                    #region 대출 상환 계획표 로딩

                    DataTable _dt = base.GetDataTable("PCSP_LRN0100_R3"
                        , _ds.Tables[0].Rows[0]["IDX"].ToString()
                    );
                    gridView2.DataSource = _dt;

                    #endregion

                    #region 연체이자 내역 로딩

                    //프로시져 생성 필요
                    _dt = base.GetDataTable("PCSP_LRN0100_R4"
                        , _ds.Tables[0].Rows[0]["IDX"].ToString()
                    );
                    gridView3.DataSource = _dt;

                    #endregion


                    #region 상환내역 로딩

                    _dt = base.GetDataTable("PCSP_LRN0100_R5"
                        , _ds.Tables[0].Rows[0]["IDX"].ToString()
                    );
                    gridView4.DataSource = _dt;

                    #endregion

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region gridView1_CellDoubleClick : 그리드 더블클릭 시, 상세정보 바인딩
        /// <summary>
        /// 그리드 클릭 시, 상세정보 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    // 스플릿바 처리
                    if (collapsibleSplitter1.IsCollapsed)
                    {
                        collapsibleSplitter1.ToggleState();
                    }

                    #region 대출원장 상태 바인딩

                    // 대출원장상태코드
                    DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "L01", "", "Y", "", "");
                    base.SetListItem(_cmbLNSTATE_S1, _dt01, "TOTAL_CODE", "CODE_NAME", true);

                    DataSet _ds = base.GetDataSet("PCSP_LRN0100_R2"
                        , base.GetCookie("COMPANY_CD")
                        , gridView1.Rows[e.RowIndex].Cells["IDX"].Value
                        );

                    _txtIDX.Text = _ds.Tables[0].Rows[0]["IDX"].ToString();
                    _txtSTR_NM.Text = _ds.Tables[0].Rows[0]["STR_NM"].ToString();
                    _dtpEXECDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["EXECDT"]);
                    _cmbLNSTATE_S1.SelectedValue = _ds.Tables[0].Rows[0]["LNSTATE"].ToString();
                    _txtLNAMT.Text = _ds.Tables[0].Rows[0]["LNAMT"].ToString();
                    _rbINTRY.Checked = _ds.Tables[0].Rows[0]["INTRYN"].ToString().Equals("Y") ? true : false;
                    _rbINTRN.Checked = _ds.Tables[0].Rows[0]["INTRYN"].ToString().Equals("N") ? true : false;
                    _txtBIGO.Text = _ds.Tables[0].Rows[0]["BIGO"].ToString();

                    EnableControls2(true, _ds.Tables[0].Rows[0]["LNSTATE"].ToString());

                    #endregion

                    #region 대출 상환 계획표 로딩

                    DataTable _dt = base.GetDataTable("PCSP_LRN0100_R3"
                        , _ds.Tables[0].Rows[0]["IDX"].ToString()
                    );
                    gridView2.DataSource = _dt;

                    #endregion

                    #region 연체이자 내역 로딩

                    // 프로시져 생성 필요
                    //_dt = base.GetDataTable("PCSP_LRN0100_R4"
                    //    , _ds.Tables[0].Rows[0]["IDX"].ToString()
                    //);
                    //gridView3.DataSource = _dt;

                    #endregion


                    #region 상환내역 로딩

                    _dt = base.GetDataTable("PCSP_LRN0100_R5"
                        , _ds.Tables[0].Rows[0]["IDX"].ToString()
                    );
                    gridView4.DataSource = _dt;

                    #endregion
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

		#region _btnExcel_Click : 엑셀 버튼 클릭 이벤트
		/// <summary>
		/// 엑셀 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				Dictionary<string, string> _dic = new Dictionary<string, string>();
				//_dic.Add("G", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("M", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("N", "yyyy-MM-dd HH:mm:ss");

				//_dic.Add("C", "@");
				//_dic.Add("D", "@");
				//_dic.Add("P", "@");
				//_dic.Add("R", "@");
				//_dic.Add("S", "@");

				//_dic.Add("Q", "#,###");
				gridView1.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
				MessageBox.Show(err.Message);
			}
		}
        #endregion

        #region _btn_EXCEL_LRN0120_Click : 엑셀 버튼 클릭 이벤트
        /// <summary>
        /// 엑셀 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btn_EXCEL_LRN0120_Click(object sender, EventArgs e)
        {
            try
            {
                if(gridView2.RowCount <= 0)
                {
                    MessageBox.Show("검색된 자료가 없습니다.");
                    return;
                }

                Dictionary<string, string> _dic = new Dictionary<string, string>();
                //_dic.Add("G", "yyyy-MM-dd HH:mm:ss");
                //_dic.Add("M", "yyyy-MM-dd HH:mm:ss");
                //_dic.Add("N", "yyyy-MM-dd HH:mm:ss");

                //_dic.Add("C", "@");
                //_dic.Add("D", "@");
                //_dic.Add("P", "@");
                //_dic.Add("R", "@");
                //_dic.Add("S", "@");

                //_dic.Add("Q", "#,###");
                gridView2.ExportToExcel(_dic);
            }
            catch (Exception err)
            {
                BANANA.Windows.Logger.Error(err);
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region _btnAdd_Click : 추가 버튼 이벤트
        /// <summary>
        /// 추가 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LRN0110 form = new LRN0110();
                form.ShowDialog();

                // 새로운 정보 바인딩
                Search();
                ClearControls();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region collapsibleSplitter1_DoubleClick : 스플릿바 더블 클릭 이벤트
        /// <summary>
        /// 스플릿바 더블 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collapsibleSplitter1_DoubleClick(object sender, EventArgs e)
        {
            groupBox2.Width = 698;
        }
        #endregion

        #region _btnRun_Click : 대출실행 버튼 이벤트
        /// <summary>
        /// 대출실행 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                LRN0120 form = new LRN0120();
                form.ShowDialog();

                // 새로운 정보 바인딩
                Search();
                ClearControls();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region _btnSave_Click : 대출원장변경 버튼 이벤트

        private void _btnSave_Click(object sender, EventArgs e)
        {   
            try
            {   
                base.ExecuteNonQuery("PCSP_LRN0100_U1"
                    , _txtIDX.Text					    // 대출원장번호
                    , _dtpEXECDT.Value                	// 대출일자
                    , _cmbLNSTATE_S1.SelectedValue      // 대출원장상태
                    , base.GetInteger(_txtLNAMT)	    	// 대출신청금액
                    , _rbINTRY.Checked ? "Y" : "N"			// 연체이자발생
                    , _txtBIGO.Text                         // 비고(변경사유)
                    , base.GetCookie("USRID")				// 시스템수정자ID
                    , base.GetCookie("USRNM")				// 시스템수정자명
                    );

                MessageBox.Show("비즈론 대출원장을 수정 하였습니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                EnableControls1(true);
                EnableControls2(true, string.Empty);
            }
        }

        #endregion

        #region _btnSTR_RPC_Click : 변경 버튼 클릭 이벤트(대체가맹점 변경 처리)

        private void _btnSTR_RPC_Click(object sender, EventArgs e)
        {
            try
            {
                if(gridView2.RowCount < 1)
                {
                    MessageBox.Show("변경 대상 건이 없습니다.");
                    return;
                }

                // 대출상태값 판단
                if (gridView1.Rows[gridView1.CurrentRow.Index].Cells["LNSTATENM"].Value.ToString().Equals("대출종료"))
                {
                    MessageBox.Show("대출 종료가 되었습니다. 변경할 수 없습니다.");
                    return;
                }

                // 종료여부
                var rpyynRows = gridView2.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells["LRN0120_RPYYN"].Value.ToString().Trim().Equals("아니오"))
                    .Select(row => row);
                
                if(rpyynRows.Count() < 1)
                {
                    MessageBox.Show("변경 대상 건이 없습니다.");
                    return;
                }

                LRN0122 form = new LRN0122();

                form._IDX = gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value.ToString();
                form.RPYSEQ_S = gridView2.Rows[0].Cells["LRN0120_RPYSEQ"].Value.ToString();
                form.RPYSEQ_E = gridView2.Rows[rpyynRows.Count() - 1].Cells["LRN0120_RPYSEQ"].Value.ToString();

                form.ShowDialog();

                // 새로운 정보 바인딩
                Search();
                ClearControls();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region _btnRPYAMT_Click : 상환 버튼 클릭 이벤트(대체가맹점 변경 처리)
        private void _btnRPYAMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView4.RowCount < 1)
                {
                    MessageBox.Show("변경 대상 건이 없습니다.");
                    return;
                }

                // 종료여부
                var rpyynRows = gridView2.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells["LRN0120_RPYYN"].Value.ToString().Trim().Equals("예"))
                    .Select(row => row);

                if(rpyynRows.Count() < 1)
                {
                    MessageBox.Show("처리대상을 선택하시기 바랍니다.");
                    return;
                }
                
                LRN0130 form = new LRN0130();

                form._IDX = gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value.ToString();
                //form.RPYSEQ_S = gridView2.Rows[0].Cells["LRN0120_RPYSEQ"].Value.ToString();
                //form.RPYSEQ_E = gridView2.Rows[rpyynRows.Count() - 1].Cells["LRN0120_RPYSEQ"].Value.ToString();

                form.RPYSEQ_S = "1";
                form.RPYSEQ_E = rpyynRows.Count().ToString();

                form.ShowDialog();

                // 새로운 정보 바인딩
                //Search();
                ClearControls();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region _btnCAL_Click : 정산 버튼 클릭 이벤트(상환금액 수기 처리)
        private void _btnCAL_Click(object sender, EventArgs e)
        {
            try
            {
                //if (gridView3.RowCount < 1)
                //{
                //    MessageBox.Show("변경 대상 건이 없습니다.");
                //    return;
                //}

                // 종료여부
                var rpyynRows = gridView2.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells["LRN0120_RPYYN"].Value.ToString().Trim().Equals("아니오"))
                    .Select(row => row);

                if (rpyynRows.Count() < 1)
                {
                    MessageBox.Show("처리대상을 선택하시기 바랍니다.");
                    return;
                }

                LRN0131 form = new LRN0131();

                form._IDX = gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value.ToString();
                form._LNMNT = gridView1.Rows[gridView1.CurrentRow.Index].Cells["LNMNT"].Value.ToString();
                //form.RPYSEQ_S = gridView2.Rows[0].Cells["LRN0120_RPYSEQ"].Value.ToString();
                //form.RPYSEQ_E = gridView2.Rows[rpyynRows.Count() - 1].Cells["LRN0120_RPYSEQ"].Value.ToString();

                form.RPYSEQ_S = (Convert.ToInt32(form._LNMNT) + 1 - rpyynRows.Count()).ToString();
                form.RPYSEQ_E = form._LNMNT;

                form.ShowDialog();

                // 새로운 정보 바인딩
                //Search();
                //_btnSearch_Click(null, null);
                //gridView1_CellClick(null, null);

                ClearControls();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion
    }
}
