using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DemoClient.View.LRN
{
    /// <summary>
    /// 제  목: 비즈론상환내역관리
    /// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
    /// 작성일: 2014-07-27 18:38
    /// 설  명: 비즈론원장을 등록하는 화면입니다.
    /// </summary>
    public partial class LRN0130 : DemoClient.Controllers.BasePopupForm
    {
        // 검색 쓰레드
        private Thread _thread;
        
        public string _IDX { get; set; }
        public string RPYSEQ_S { get; set; }
        public string RPYSEQ_E { get; set; }

        #region LRN0130 : 생성자 함수

        public LRN0130()
        {
            InitializeComponent();

        }

        #endregion

        #region LRN0130_Load : 폼 로드 이벤트
        private void LRN0130_Load(object sender, EventArgs e)
        {
            try
            {
                _txtRPYSEQ_S.Text = RPYSEQ_S;
                _txtRPYSEQ_E.Text = RPYSEQ_E;
                
                gridView1.ReadOnly = false;

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
        }
        #endregion

        #region EnableControls1 : 컨트롤 활성화/비활성화 처리
        /// <summary>
        /// 컨트롤 활성화/비활성화 처리
        /// </summary>
        /// <param name="_bTrue"></param>
        public void EnableControls1(bool _bTrue)
        {
            _btnSave.Enabled = _bTrue;
        }
        #endregion

        #region EnableControls2 : 컨트롤 활성화/비활성화 처리
        /// <summary>
        /// 컨트롤 활성화/비활성화 처리
        /// </summary>
        /// <param name="_bTrue"></param>
        public void EnableControls2(bool _bTrue)
        {
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
            // 커서 기다림
            base.SetWaitCursor();
            // 컨트롤 비활성화
            EnableControls1(false);
            EnableControls2(false);

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
                int res = Search();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                // 컨트롤 활성화
                EnableControls1(true);
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
            int _retValue = -1;

            try
            {

                DataTable _dt = base.GetDataTable("PCSP_LRN0130_R1"
                    , Convert.ToInt32(_IDX)
                    , _txtRPYSEQ_S.Text
                    , _txtRPYSEQ_E.Text
                    );
                gridView1.DataSource = _dt;

                _retValue = _dt.Rows.Count;
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
            //foreach (DataGridViewRow row in gridView1.Rows)
            //{
            //    // 체크박스 및 선택불가 처리
            //    if (gridView1.Rows[row.Index].Cells["CHK2"].Value.ToString() == "X")
            //    {
            //        gridView1.Rows[row.Index].Cells["CHK"].ReadOnly = true;
            //        gridView1.Rows[row.Index].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.LightGray };
            //    }
            //    else
            //    {
            //        gridView1.Rows[row.Index].Cells["CHK"].ReadOnly = false;
            //    }
            //}

            //// 중복
            //var duplRows	= gridView1.Rows.Cast<DataGridViewRow>()
            //    .Where(row => row.Cells["IS_DUPL"].Value.ToString().Trim().Equals("Y"))
            //    .Select(row => row);
            //foreach (DataGridViewRow row in duplRows)
            //{
            //    row.Cells["IS_DUPL"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
            //}

            //// 건별한도
            //var indvRows	= gridView1.Rows.Cast<DataGridViewRow>()
            //    .Where(row => row.Cells["IS_UNIT_LIMITED"].Value.ToString().Trim().Equals("Y"))
            //    .Select(row => row);
            //foreach (DataGridViewRow row in indvRows)
            //{
            //    row.Cells["IS_UNIT_LIMITED"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
            //}

            //// 1일한도
            //var dailyRows	= gridView1.Rows.Cast<DataGridViewRow>()
            //    .Where(row => row.Cells["IS_DAILY_LIMITED"].Value.ToString().Trim().Equals("Y"))
            //    .Select(row => row);
            //foreach (DataGridViewRow row in dailyRows)
            //{
            //    row.Cells["IS_DAILY_LIMITED"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
            //}

            //// 총한도
            //var totRows		= gridView1.Rows.Cast<DataGridViewRow>()
            //    .Where(row => row.Cells["IS_TOT_LIMITED"].Value.ToString().Trim().Equals("Y"))
            //    .Select(row => row);
            //foreach (DataGridViewRow row in totRows)
            //{
            //    row.Cells["IS_TOT_LIMITED"].Style	= new DataGridViewCellStyle() { ForeColor = Color.Red };
            //}

            //// 취소
            //var cnclRows	= gridView1.Rows.Cast<DataGridViewRow>()
            //    .Where(row => row.Cells["SUCCESSRES_CD"].Value.ToString().Trim().Equals("V02002"))
            //    .Select(row => row);
            //foreach (DataGridViewRow row in cnclRows)
            //{
            //    row.DefaultCellStyle	= new DataGridViewCellStyle() { ForeColor = Color.Red };
            //}
        }
        #endregion

        #region gridView1_CellDoubleClick : 그리드 더블클릭 시, 상세정보 바인딩
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
                    if (collapsibleSplitter1.IsCollapsed)
                    {
                        collapsibleSplitter1.ToggleState();
                    }

                    EnableControls2(true);

                    DataSet _ds = base.GetDataSet("PCSP_LRN0111_R2"
                        , base.GetCookie("COMPANY_CD")
                        , gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value
                        );

                    _txtIDX.Text = _ds.Tables[0].Rows[0]["STR_CD"].ToString();
                    _txtRPYSEQ.Text = _ds.Tables[0].Rows[0]["STR_NM"].ToString();

                    // 상환처리방법
                    DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "L02", "", "Y", "", "");
                    base.SetListItem(_cmbMETHOD, _dt01, "TOTAL_CODE", "CODE_NAME", true);

                    //_dtpLNSTDT.Value = DateTime.Today.AddDays(1);
                    
                    
                    //_dtpTRDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["TRDT"]);
                    //_cmbDEPTYPE.SelectedValue = _ds.Tables[0].Rows[0]["DEPTYPE"].ToString();
                    //_txtTRAMT.Text = _ds.Tables[0].Rows[0]["TRAMT"].ToString();
                    //_txtRMKS.Text = _ds.Tables[0].Rows[0]["RMKS"].ToString();
                    //_txtTRTXT.Text = _ds.Tables[0].Rows[0]["TRTXT"].ToString();
                    //_txtTRTCD.Text = _ds.Tables[0].Rows[0]["TRTCD"].ToString();
                    //_dtpACCTDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["ACCTDT"]);
                    //_cmbACCTFLAG.SelectedValue = _ds.Tables[0].Rows[0]["ACCTFLAG"].ToString();
                    //_txtTRANSFEE.Text = _ds.Tables[0].Rows[0]["TRANSFEE"].ToString();

                }
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

        #region _btnSave_Click : 저장 버튼 클릭 이벤트
        private void _btnSave_Click(object sender, EventArgs e)
        {   
            try
            {
                base.ExecuteNonQuery("PCSP_LRN0130_U1"
                    , _txtIDX.Text					    // 가맹점코드
                    , _cmbMETHOD.SelectedValue          	// 여신사코드
                    , base.GetInteger(_txtINTEREST)	    	// 대출신청금액
                    , base.GetDecimal(_txtDLYINTST)		// 대출연이율
                    , _dtpRPYDT.Value      				// 대출일자
                    , base.GetCookie("USRID")				// 시스템수정자ID
                    , base.GetCookie("USRNM")				// 시스템수정자명
                    );

                MessageBox.Show("비즈론 상환내역을 변경 하였습니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                EnableControls1(true);
            }
        }

        #endregion

    }
}