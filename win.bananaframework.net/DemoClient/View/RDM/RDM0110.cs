using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.RDM
{
    public partial class RDM0110 : DemoClient.Controllers.BaseForm
    {
        // 검색 쓰레드
        private Thread _thread;

        #region RDM0110 : 생성자 함수

        public RDM0110()
        {
            InitializeComponent();
        }

        #endregion

        #region RDM0110_Load : 폼 로드 이벤트

        private void RDM0110_Load(object sender, EventArgs e)
        {
            try
            {
                _dtpTRADEDATE_S_S.Value = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
                _dtpTRADEDATE_E_S.Value = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));

                // 입금구분(상세목록 바인딩)
                DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "R01", "", "", "", "");
                base.SetListItem(_cmbDEPTYPE, _dt01, "TOTAL_CODE", "CODE_NAME", true);
                
                // 정산처리여부 바인딩
                DataTable _dt02 = new DataTable();
                _dt02.Columns.Add("DisplayMember");
                _dt02.Columns.Add("ValueMember");

                _dt02.Rows.Add("전체", "");
                _dt02.Rows.Add("정산처리", "Y");
                _dt02.Rows.Add("정산미처리", "N");
                
                _cmbACCTYN.Items.Clear();
                _cmbACCTYN.DataSource = _dt02;
                _cmbACCTYN.DisplayMember = "DisplayMember";
                _cmbACCTYN.ValueMember = "ValueMember";

                _cmbACCTYN.SelectedIndex = 0;
                
                gridView1.ReadOnly = false;

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
            _txtSTR_NM_S.ReadOnly = !_bTrue;
            _dtpTRADEDATE_S_S.Enabled = _bTrue;
            _dtpTRADEDATE_E_S.Enabled = _bTrue;
            _btnSearch.Enabled = _bTrue;
            _btnExcel.Enabled = _bTrue;
        }
        #endregion

        #region EnableControls2 : 컨트롤 활성화/비활성화 처리
        /// <summary>
        /// 컨트롤 활성화/비활성화 처리
        /// </summary>
        /// <param name="_bTrue"></param>
        public void EnableControls2(bool _bTrue)
        {
            _dtpTRDT.Enabled = _bTrue;
            
            _btnSave.Enabled = _bTrue;
            _btnDel.Enabled = _bTrue;
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
                string message = string.Format("{0:N0}건이 검색되었습니다.", res);

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
            int _retValue = -1;

            try
            {
                DataTable _dt = base.GetDataTable("PCSP_RDM0110_R1"
                    , base.GetCookie("COMPANY_CD")
                    , _txtSTR_NM_S.Text
                    , _cmbACCTYN.SelectedValue
                    , _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
                    , _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
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

            // 정산처리여부
            var acctynRows = gridView1.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells["ACCTYN"].Value.ToString().Trim().Equals("N"))
                .Select(row => row);
            foreach (DataGridViewRow row in acctynRows)
            {
                row.Cells["ACCTYN"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
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
                if (e.RowIndex != -1)
                {
                    // 스플릿바 처리
                    if (collapsibleSplitter1.IsCollapsed)
                    {
                        collapsibleSplitter1.ToggleState();
                    }

                    EnableControls2(true);

                    DataSet _ds = base.GetDataSet("PCSP_RDM0110_R2"
                        , gridView1.Rows[e.RowIndex].Cells["IDX"].Value
                        );
                    _txtIDX.Text = _ds.Tables[0].Rows[0]["IDX"].ToString();
                    _txtSTR_NM.Text = _ds.Tables[0].Rows[0]["STR_NM"].ToString();
                    _dtpTRDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["TRDT"]);
                    _cmbDEPTYPE.SelectedValue = _ds.Tables[0].Rows[0]["DEPTYPE"].ToString();
                    _txtTRAMT.Text = _ds.Tables[0].Rows[0]["TRAMT"].ToString();
                    _txtRMKS.Text = _ds.Tables[0].Rows[0]["RMKS"].ToString();
                    _txtTRTXT.Text = _ds.Tables[0].Rows[0]["TRTXT"].ToString();
                    _txtTRTCD.Text = _ds.Tables[0].Rows[0]["TRTCD"].ToString();
                    _dtpACCTDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["ACCTDT"]);
                    _rbACCTY.Checked = _ds.Tables[0].Rows[0]["ACCTYN"].ToString().Equals("Y") ? true : false;
                    _rbACCTN.Checked = _ds.Tables[0].Rows[0]["ACCTYN"].ToString().Equals("N") ? true : false;
                    _txtTRANSFEE.Text = _ds.Tables[0].Rows[0]["TRANSFEE"].ToString();

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
                gridView1.ExportToExcel();
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
                RDM0120 form = new RDM0120();
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

        #region _btnSave_Click : 저장 버튼 이벤트
        /// <summary>
        /// 저장 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                base.ExecuteNonQuery("PCSP_RDM0110_U1"
                    , _txtIDX.Text					        // 입금번호
                    , _dtpTRDT.Value                	    // 입금일자
                    , _cmbDEPTYPE.SelectedValue             // 입금구분
                    , base.GetInteger(_txtTRAMT)	    	// 입금금액
                    , _txtRMKS.Text                         // 적요
                    , _txtTRTXT.Text                        // 기재내용
                    , _txtTRTCD.Text                        // 취급점
                    , base.GetInteger(_txtTRANSFEE)         // 송금수수료
                    , base.GetCookie("USRID")				// 시스템수정자ID
                    , base.GetCookie("USRNM")				// 시스템수정자명
                    );

                MessageBox.Show("입금내역을 수정 하였습니다.");

                _btnSearch_Click(null, null);
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

        #region _btnDel_Click : 삭제 버튼 이벤트
        /// <summary>
        /// 삭제 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void _btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                base.ExecuteNonQuery("PCSP_RDM0110_D1"
                    , _txtIDX.Text					    // 입금번호
                    , base.GetCookie("USRID")				// 시스템수정자ID
                    , base.GetCookie("USRNM")				// 시스템수정자명
                    );

                MessageBox.Show("입금내역을 삭제 하였습니다.");

                _btnSearch_Click(null, null);
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