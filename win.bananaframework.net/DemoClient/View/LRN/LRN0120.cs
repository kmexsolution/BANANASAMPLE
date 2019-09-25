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
    /// 제  목: 비즈론원장등록
    /// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
    /// 작성일: 2014-07-27 18:38
    /// 설  명: 비즈론원장을 등록하는 화면입니다.
    /// </summary>
    public partial class LRN0120 : DemoClient.Controllers.BasePopupForm
    {
        // 검색 쓰레드
        private Thread _thread;
        private DataTable ReturnData { get; set; }

        #region LRN0120 : 생성자 함수

        public LRN0120()
        {
            InitializeComponent();

            this.ReturnData = new DataTable("상환테이블");
            this.ReturnData.Columns.Add("ORD", typeof(int));
            this.ReturnData.Columns.Add("RDT", typeof(DateTime));
            this.ReturnData.Columns.Add("PRC", typeof(decimal));
            this.ReturnData.Columns.Add("INT", typeof(decimal));
            this.ReturnData.Columns.Add("PNI", typeof(decimal));
            this.ReturnData.Columns.Add("RST", typeof(decimal));
            this.ReturnData.AcceptChanges();

            this.gridView2.DataSource = this.ReturnData;
        }

        #endregion

        #region LRN0120_Load : 폼 로드 이벤트
        private void LRN0120_Load(object sender, EventArgs e)
        {
            try
            {   
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

                DataTable _dt = base.GetDataTable("PCSP_LRN0120_R1"
                    , base.GetCookie("COMPANY_CD")
                    , _txtSTR_NM.Text
                    , _txtPRSNT_NM.Text
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

        #region _btnCAL_Click : 계산[시뮬레이션] 버튼 클릭 이벤트
        private void _btnCAL_Click(object sender, EventArgs e)
        {
            try
            {
                _dtpLNSTDT.Value = _dtpEXECDT.Value.AddDays(1);

                if (validation_chk_cal())
                {
                    var loanamt = Convert.ToDecimal(this._txtLNAMT.Text.Trim());
                    var lst = CalculateLoanList(loanamt, Convert.ToDecimal(_txtINTRRTYEAR.Text.Trim()), Convert.ToInt32(_txtLNMNT.Text.Trim()));
                    var dr = null as DataRow;
                    var ord = 0;

                    foreach (Dictionary<string, decimal> curRetInfo in lst)
                    {
                        ord = (int)curRetInfo["ORD"];

                        dr = ReturnData.NewRow();
                        dr["ORD"] = ord;
                        dr["RDT"] = this._dtpLNSTDT.Value.AddDays(ord - 1).Date;
                        dr["PRC"] = curRetInfo["PRC"];
                        dr["INT"] = curRetInfo["INT"];
                        dr["PNI"] = curRetInfo["PNI"];
                        dr["RST"] = curRetInfo["RST"];
                        
                        ReturnData.Rows.Add(dr);
                    }

                    ReturnData.AcceptChanges();

                    if (ReturnData.Rows.Count > 0)
                    {
                        this._txtTOTAMT.Text = ReturnData.Sum("PNI").ToString("#,##0");
                        this._txtTOTINTR.Text = ReturnData.Sum("INT").ToString("#,##0");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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

                    DataSet _ds = base.GetDataSet("PCSP_LRN0120_R2"
                        , gridView1.Rows[e.RowIndex].Cells["IDX"].Value
                        );

                    _txtSTR_CD.Text = _ds.Tables[0].Rows[0]["STR_CD"].ToString();
                    _txtSTR_NM_S1.Text = _ds.Tables[0].Rows[0]["STR_NM"].ToString();

                    // 여신사코드
                    DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "Loaner", "", "", "Y", "", "");
                    base.SetListItem(_cmbLNR_CD, _dt01, "TOTAL_CODE", "CODE_NAME", true);

                    _cmbLNR_CD.SelectedValue = _ds.Tables[0].Rows[0]["LNCD"].ToString();
                    _txtLNAMT.Text = _ds.Tables[0].Rows[0]["LNAMT"].ToString();
                    _txtLNMNT.Text = _ds.Tables[0].Rows[0]["LNMNT"].ToString();

                    _dtpEXECDT.Value = Convert.ToDateTime(_ds.Tables[0].Rows[0]["EXECDT"]);
                    _dtpLNSTDT.Value = _dtpEXECDT.Value.AddDays(1);
                    _txtINTRRTYEAR.Text = _ds.Tables[0].Rows[0]["INTRRTYEAR"].ToString();
                    
                    _txtBIGO.Text = _ds.Tables[0].Rows[0]["BIGO"].ToString();
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

        #region Validation Check_Cal : 계산 시뮬레이션 버튼 클릭시 validation check

        private bool validation_chk_cal()
        {
            // 가맹점 코드
            if (string.IsNullOrEmpty(_txtSTR_CD.Text.Trim()))
            {
                MessageBox.Show("가맹점 코드가 입력 되지 않았습니다. 가맹점을 선택하세요.");
                return false;
            }

            // 가맹점명
            if (string.IsNullOrEmpty(_txtSTR_NM_S1.Text.Trim()))
            {
                MessageBox.Show("가맹점명이 입력 되지 않았습니다. 가맹점을 선택하세요.");
                return false;
            }

            // 여신사코드
            if (_cmbLNR_CD.SelectedIndex < 1)
            {
                MessageBox.Show("여신사가 입력 되지 않았습니다. 여신사를 선택하세요.");
                return false;
            }

            // 신청금액
            if (string.IsNullOrEmpty(_txtLNAMT.Text.Trim()))
            {
                MessageBox.Show("신청금액이 입력 되지 않았습니다. 신청금액을 입력하세요.");
                return false;
            }
            else
            {
                if(Convert.ToDecimal(_txtLNAMT.Text.Trim()) <= 0)
                {
                    MessageBox.Show("신청금액을 잘못 입력 하셨습니다. 신청금액을 다시 입력하세요.");
                    return false;
                }

            }

            // 대출일수
            if (string.IsNullOrEmpty(_txtLNMNT.Text.Trim()))
            {
                MessageBox.Show("대출일수가 입력 되지 않았습니다. 대출일수를 입력하세요.");
                return false;
            }
            else
            {
                if (Convert.ToDecimal(_txtLNMNT.Text.Trim()) <= 0)
                {
                    MessageBox.Show("대출일수를 잘못 입력 하셨습니다. 대출일수를 다시 입력하세요.");
                    return false;
                }

            }

            // 대출연이율
            if (string.IsNullOrEmpty(_txtINTRRTYEAR.Text.Trim()))
            {
                MessageBox.Show("대출연이율이 입력 되지 않았습니다. 대출연이율을 입력하세요.");
                return false;
            }
            else
            {
                if (Convert.ToDecimal(_txtLNMNT.Text.Trim()) <= 0)
                {
                    MessageBox.Show("대출연이율을 잘못 입력 하셨습니다. 대출연이율을 다시 입력하세요.");
                    return false;
                }

            }

            return true;
        }

        #endregion

        #region 시뮬레이션 처리값

        /// <summary>
        /// 대출 상환계획표를 반환합니다.
        /// </summary>
        /// <param name="pv"></param>
        /// <param name="percentage"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        private static List<Dictionary<string, decimal>> CalculateLoanList(decimal pv, decimal percentage, int period)
        {
            var tmp = 0m;
            var rate = percentage / 100m / 365m; // 하루치 이자율(퍼센티지)       
            var interest = 0m;
            var pmt = 0m;
            var principle = pv;
            var balance = principle;

            var lst = new List<Dictionary<string, decimal>>(period);
            var dayInfo = null as Dictionary<string, decimal>;

            pmt = (decimal)Math.Floor(Financial.Pmt((double)rate, (double)period, (double)-pv, 1)); // 상환원리금(하루)

            for (int i = 0; i < period - 1; i++)
            {
                interest = Math.Floor(balance * rate); // 첫날 이자
                principle = pmt - interest; // 첫날 원금
                balance = balance - principle; // 첫날 상환 후, 대출잔액
                
                dayInfo = new Dictionary<string, decimal>();
                dayInfo.Add("ORD", (i + 1));
                dayInfo.Add("PRC", principle);
                dayInfo.Add("INT", interest);
                dayInfo.Add("PNI", pmt);
                dayInfo.Add("RST", balance);
                
                lst.Add(dayInfo);
            }

            dayInfo = new Dictionary<string, decimal>();
            dayInfo.Add("ORD", period);
            dayInfo.Add("PRC", balance);
            dayInfo.Add("INT", (pmt - balance));
            dayInfo.Add("PNI", pmt);
            dayInfo.Add("RST", 0);
            
            lst.Add(dayInfo);

            return lst;
        }

        #endregion

        #region _btnSave_Click : 저장 버튼 클릭 이벤트
        private void _btnSave_Click(object sender, EventArgs e)
        {   
            try
            {
                EnableControls1(false);

                List<string> _ord = new List<string>();
                //List<string> _str_cd = new List<string>();
                List<string> _gijun_dt = new List<string>();

                List<string> _prc = new List<string>();
                List<string> _int = new List<string>();
                List<string> _pni = new List<string>();
                

                // 선택된 행
                var selRows = gridView2.Rows.Cast<DataGridViewRow>();

                    //.Where(row => row.Cells["ORD"].Value.ToString().Trim().Equals("Y"))
                    //.Select(row => row);

                

                //return;

                foreach (DataGridViewRow row in selRows)
                {
                    //MessageBox.Show(row.Cells["ORD"].Value.ToString().Trim());

                    // 회차
                    _ord.Add(row.Cells["ORD"].Value.ToString().Trim());

                    // 상환일자
                    string[] temp = row.Cells["RDT"].Value.ToString().Split(' ');
                    _gijun_dt.Add(temp[0]);

                    // 원금
                    _prc.Add(row.Cells["PRC"].Value.ToString().Trim());

                    // 이자
                    _int.Add(row.Cells["INT"].Value.ToString().Trim());

                    // 원리금
                    _pni.Add(row.Cells["PNI"].Value.ToString().Trim());

                    //// 가맹점코드
                    //_str_cd.Add(row.Cells["STR_CD"].Value.ToString().Trim() + "^" + row.Cells["STR_NM"].Value.ToString().Trim());

                    
                }

                //return;

                LRN0121 _form = new LRN0121();
                _form._IDX = gridView1.Rows[gridView1.CurrentRow.Index].Cells["IDX"].Value.ToString();
                _form._STR_CD = _txtSTR_CD.Text;
                _form._RPYSEQ = _ord;
                _form._RPYDT = _gijun_dt;
                _form._RPYAMT = _pni;
                _form._INTEREST = _int;
                _form._PRINCIPAL = _prc;
                
                _form._RPYDT = _gijun_dt;
                //_form.StoreInfo = _str_cd;
                
                DialogResult res = _form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("비즈론 상환계획표 등록을 완료 하였습니다.");

                    this.Close();
                }
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