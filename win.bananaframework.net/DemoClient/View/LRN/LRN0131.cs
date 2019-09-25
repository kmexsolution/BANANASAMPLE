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
    /// 제  목: 비즈론상환내역 수기입금처리
    /// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
    /// 작성일: 2014-07-27 18:38
    /// 설  명: 비즈론원장을 등록하는 화면입니다.
    /// </summary>
    public partial class LRN0131 : DemoClient.Controllers.BasePopupForm
    {
        // 검색 쓰레드
        private Thread _thread;
        
        public string _IDX { get; set; }
        public string _LNMNT { get; set; }
        public string RPYSEQ_S { get; set; }
        public string RPYSEQ_E { get; set; }

        #region LRN0131 : 생성자 함수

        public LRN0131()
        {
            InitializeComponent();

        }

        #endregion

        #region LRN0131_Load : 폼 로드 이벤트
        private void LRN0131_Load(object sender, EventArgs e)
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

                DataTable _dt = base.GetDataTable("PCSP_LRN0131_R1"
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

                    DataSet _ds = base.GetDataSet("PCSP_LRN0131_R2"
                        , Convert.ToInt32(_IDX)
                        , Convert.ToInt32(_txtRPYSEQ_S.Text)
                        , Convert.ToInt32(_txtRPYSEQ_E.Text)
                        );

                    _txtIDX.Text = _IDX;
                    _txtLNMNT.Text = _LNMNT;
                    _txtPRINCIPAL.Text = _ds.Tables[0].Rows[0]["PRINCIPAL"].ToString();
                    _txtINTEREST.Text = _ds.Tables[0].Rows[0]["INTEREST"].ToString();
                    _txtTOTAMT.Text = _ds.Tables[0].Rows[0]["TOTAMT"].ToString();

                    _txtRTNPRCP.Text = _ds.Tables[0].Rows[0]["RTNPRCP"].ToString();
                    _txtRTNINTST.Text = _ds.Tables[0].Rows[0]["RTNINTST"].ToString();
                    _txtDLYINTST.Text = _ds.Tables[0].Rows[0]["DLYINTST"].ToString();

                    _txtNONPRCP.Text = _ds.Tables[0].Rows[0]["NONPRCP"].ToString();
                    _txtNONINTST.Text = _ds.Tables[0].Rows[0]["NONINTST"].ToString();
                    _txtCDLYINTST.Text = _ds.Tables[0].Rows[0]["CDLYINTST"].ToString();
                    
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
                var inamt = 0m;
                var tmpamt = 0m;

                inamt = Convert.ToDecimal(_txtINAMT.Text);

                if (inamt < 1)
                {
                    MessageBox.Show("입금금액을 다시 입력하세요.");
                    return;
                }

                base.BeginTransaction();

                #region 입력금액 처리

                //var calRows = gridView1.Rows.Cast<DataGridViewRow>();
                //foreach (DataGridViewRow row in calRows)
                //{

                    

                //    // 연체이자 처리
                //    if (Convert.ToDecimal(row.Cells["CDLYINTST"].Value) > 0)
                //    {
                //        inamt = inamt - Convert.ToDecimal(row.Cells["CDLYINTST"].Value);

                //        if (inamt <= 0)
                //        {
                //            // DB호출

                            
                //            break;
                //        }
                //    }


                //    // 이자처리
                //    if (Convert.ToDecimal(row.Cells["NONINTST"].Value) > 0)
                //    {
                //        inamt = inamt - Convert.ToDecimal(row.Cells["NONINTST"].Value);

                //        if (inamt <= 0)
                //        {
                //            // DB호출


                //            break;
                //        }
                //    }

                //    // 원금 처리
                //    if (Convert.ToDecimal(row.Cells["NONPRCP"].Value) > 0)
                //    {
                //        inamt = inamt - Convert.ToDecimal(row.Cells["NONPRCP"].Value);

                //        if (inamt <= 0)
                //        {
                //            // DB호출


                //            break;
                //        }
                //    }

                    
                //    // DB호출



                //}

                #endregion

                #region 상환처리

                var drLOAN = null as DataRow;

                #region 비즈론정보

                var dt = null as DataTable;
                dt = new DataTable("비즈론상환정보");
                dt.Columns.Add("STR_NM", typeof(string));	// 가맹점명	
                dt.Columns.Add("STR_CD", typeof(string));	// 가맹점코드	
                dt.Columns.Add("IDX", typeof(Int32));	    // 대출원장번호
                dt.Columns.Add("RPYSEQ", typeof(string));	// 회차
                dt.Columns.Add("RPYDT", typeof(string));	// 상환일자
                dt.Columns.Add("PRINCIPAL", typeof(decimal));	// 원금
                dt.Columns.Add("INTEREST", typeof(decimal));	// 이자
                dt.Columns.Add("RPYYN", typeof(string));	// 완료여부
                dt.Columns.Add("RTNPRCP", typeof(decimal));	// 상환원금
                dt.Columns.Add("RTNINTST", typeof(decimal));	// 상환이자
                dt.Columns.Add("ODLYINTST", typeof(decimal));	// 누적연체이자
                dt.Columns.Add("NONPRCP", typeof(decimal));	// 미수원금
                dt.Columns.Add("NONINTST", typeof(decimal));	// 미수이자
                dt.Columns.Add("CDLYINTST", typeof(decimal));	// 남은연체이자

                // 상환된 정보 필드입니다.
                dt.Columns.Add("R_LRN0100_IDX", typeof(string));	// 대출원장번호		
                dt.Columns.Add("R_RPYSEQ", typeof(int));		// 회차
                dt.Columns.Add("R_RPYDT", typeof(string));	// 상환일자
                dt.Columns.Add("R_PRINCIPAL", typeof(decimal));	// 상환원금
                dt.Columns.Add("R_INTEREST", typeof(decimal));	// 상환이자
                dt.Columns.Add("R_DLYINTST", typeof(decimal));	// 상환연체이자
                dt.Columns.Add("R_TOTAMT", typeof(decimal));	// 합계
                dt.Columns.Add("R_METHOD", typeof(string));	// 상환방법
            
                dt.Columns.Add("RSTR_CD", typeof(string));			// 대체차감 가맹점코드
                dt.Columns.Add("R_BAS0700_AGT_CD", typeof(string));	// 대리점 코드
                dt.Columns.Add("DDTTYPEYN", typeof(string));		// 대체차감구분코드
                
                #endregion

                DataSet ds = base.GetDataSet("PCSP_LRN0131_R3"
                        , Convert.ToInt32(_IDX)
                        , Convert.ToInt32(_txtRPYSEQ_S.Text)
                        , Convert.ToInt32(_txtRPYSEQ_E.Text)
                        );


                for (var i = 0; i < gridView1.RowCount; i++)
                {
                    drLOAN = dt.NewRow();
                    
                    drLOAN["STR_CD"] = ds.Tables[0].Rows[i]["STR_CD"].ToString();
                    drLOAN["IDX"] = ds.Tables[0].Rows[i]["IDX"].ToString();
                    drLOAN["RPYSEQ"] = ds.Tables[0].Rows[i]["RPYSEQ"].ToString();
                    drLOAN["RPYDT"] = ds.Tables[0].Rows[i]["RPYDT"].ToString();
                    drLOAN["PRINCIPAL"] = ds.Tables[0].Rows[i]["PRINCIPAL"].ToString();
                    drLOAN["INTEREST"] = ds.Tables[0].Rows[i]["INTEREST"].ToString();
                    drLOAN["RPYYN"] = ds.Tables[0].Rows[i]["RPYYN"].ToString();
                    drLOAN["RTNPRCP"] = ds.Tables[0].Rows[i]["RTNPRCP"].ToString();

                    drLOAN["RTNINTST"] = ds.Tables[0].Rows[i]["RTNINTST"].ToString();
                    drLOAN["ODLYINTST"] = ds.Tables[0].Rows[i]["ODLYINTST"].ToString();
                    drLOAN["NONPRCP"] = ds.Tables[0].Rows[i]["NONPRCP"].ToString();
                    drLOAN["NONINTST"] = ds.Tables[0].Rows[i]["NONINTST"].ToString();
                    drLOAN["CDLYINTST"] = ds.Tables[0].Rows[i]["CDLYINTST"].ToString();
                    
                    //drLOAN["R_IDX"] = string.Empty;
                    drLOAN["R_LRN0100_IDX"] = _IDX;
                    drLOAN["R_RPYSEQ"] = drLOAN["RPYSEQ"];
                    drLOAN["R_RPYDT"] = DateTime.Now;
                    drLOAN["R_PRINCIPAL"] = 0m;
                    drLOAN["R_INTEREST"] = 0m;
                    drLOAN["R_DLYINTST"] = 0m;
                    drLOAN["R_TOTAMT"] = 0m;
                    drLOAN["R_METHOD"] = "L02002"; // 수기
                    
                    drLOAN["RSTR_CD"] = ds.Tables[0].Rows[i]["STR_CD"].ToString();
                    drLOAN["R_BAS0700_AGT_CD"] = ds.Tables[0].Rows[i]["BAS0700_AGT_CD"].ToString();
                    drLOAN["DDTTYPEYN"] = ds.Tables[0].Rows[i]["DDTTYPEYN"].ToString();

                    dt.Rows.Add(drLOAN);
                }

                // 비즈론 연체 상환은 상환처리만 합니다.
                for (var i = 0; i < gridView1.RowCount; i++)
                {
                    drLOAN = dt.Rows[i];

                    if (inamt == 0m) break;

                    // 연체이자 상환
                    tmpamt = inamt - Convert.ToDecimal(drLOAN["CDLYINTST"]);
                    if (tmpamt >= 0m)
                    {
                        drLOAN["R_DLYINTST"] = drLOAN["CDLYINTST"];
                        drLOAN["CDLYINTST"] = 0m;
                        inamt = tmpamt;

                    }
                    else
                    {
                        drLOAN["R_DLYINTST"] = inamt;
                        drLOAN["CDLYINTST"] = Math.Abs(tmpamt);
                        inamt = 0m;

                    }

                    // 이자 상환
                    tmpamt = inamt - Convert.ToDecimal(drLOAN["NONINTST"]);
                    if (tmpamt >= 0m)
                    {
                        drLOAN["R_INTEREST"] = drLOAN["NONINTST"];
                        drLOAN["NONINTST"] = 0m;
                        drLOAN["RTNINTST"] = Convert.ToDecimal(drLOAN["RTNINTST"]) + Convert.ToDecimal(drLOAN["R_INTEREST"]);
                        inamt = tmpamt;

                    }
                    else
                    {
                        drLOAN["R_INTEREST"] = inamt;
                        drLOAN["NONINTST"] = Math.Abs(tmpamt);
                        drLOAN["RTNINTST"] = Convert.ToDecimal(drLOAN["RTNINTST"]) + Convert.ToDecimal(drLOAN["R_INTEREST"]);
                        inamt = 0m;

                    }

                    // 원금 상환
                    tmpamt = inamt - Convert.ToDecimal(drLOAN["NONPRCP"]);

                    if (tmpamt >= 0m)
                    {
                        drLOAN["R_PRINCIPAL"] = drLOAN["NONPRCP"];
                        drLOAN["NONPRCP"] = 0m;
                        drLOAN["RTNPRCP"] = Convert.ToDecimal(drLOAN["RTNPRCP"]) + Convert.ToDecimal(drLOAN["R_PRINCIPAL"]);
                        inamt = tmpamt;

                    }
                    else
                    {
                        drLOAN["R_PRINCIPAL"] = inamt;
                        drLOAN["NONPRCP"] = Math.Abs(tmpamt);
                        drLOAN["RTNPRCP"] = Convert.ToDecimal(drLOAN["RTNPRCP"]) + Convert.ToDecimal(drLOAN["R_PRINCIPAL"]);
                        inamt = 0m;

                    }

                    drLOAN["R_TOTAMT"] = Convert.ToDecimal(drLOAN["R_PRINCIPAL"]) + Convert.ToDecimal(drLOAN["R_INTEREST"]) + Convert.ToDecimal(drLOAN["R_DLYINTST"]);

                    // 대상 비즈론 회차의 완료여부를 재설정합니다.
                    drLOAN["RPYYN"] = Convert.ToDecimal(drLOAN["NONPRCP"]) == 0m ? "Y" : "N";

                    

                    #region 비즈론 연체 상환 DB 처리

                    // 비즈론 상환처리
                    DataSet ds1 = base.GetDataSet("PCSP_LRN0131_C1"
                        , Convert.ToInt32(_IDX)
                        , drLOAN["R_RPYSEQ"]
                        , drLOAN["R_PRINCIPAL"]
                        , drLOAN["R_INTEREST"]
                        , drLOAN["R_DLYINTST"]
                        , drLOAN["R_TOTAMT"]
                        , drLOAN["R_METHOD"]
                        , drLOAN["RSTR_CD"]
                        , drLOAN["R_BAS0700_AGT_CD"]
                        , drLOAN["DDTTYPEYN"]
                        , base.GetCookie("USRID")				// 시스템등록자ID
                        , base.GetCookie("USRNM")				// 시스템등록자명
                        );

                    // 비즈론 상환계획표 변경
                    DataSet ds2 = base.GetDataSet("PCSP_LRN0131_U1"
                        , Convert.ToInt32(_IDX)
                        , drLOAN["RPYSEQ"]
                        , drLOAN["RTNPRCP"]
                        , drLOAN["RTNINTST"]
                        , drLOAN["NONPRCP"]
                        , drLOAN["NONINTST"]
                        , drLOAN["CDLYINTST"]
                        , drLOAN["RPYYN"]
                        );

                    // 비즈론 원장 완료 체크
                    if(_txtLNMNT.Text.Equals(drLOAN["R_RPYSEQ"]) &&
                        drLOAN["RPYYN"].Equals("Y"))
                    {
                        DataSet ds3 = base.GetDataSet("PCSP_LRN0131_U2"
                       , Convert.ToInt32(_IDX)
                       );
                    }

                    // 강제출금 자료 생성 체크
                    if(drLOAN["RPYYN"].Equals("Y") &&
                        inamt > 0m)
                    {

                        MessageBox.Show("추후 강제 출금 자료 등록 처리 구현 필요");
                        // DataSet ds3 = base.GetDataSet("PCSP_LRN0131_C2"
                       //, Convert.ToInt32(_IDX)
                       //);
                    }

                    #endregion

                }

                #endregion

                //base.ExecuteNonQuery("PCSP_LRN0131_U1"
                //    , _txtIDX.Text					    // 가맹점코드
                //    , base.GetInteger(_txtINTEREST)	    	// 대출신청금액
                //    , base.GetDecimal(_txtDLYINTST)		// 대출연이율
                //    , base.GetCookie("USRID")				// 시스템수정자ID
                //    , base.GetCookie("USRNM")				// 시스템수정자명
                //    );

                base.CommitTransaction();

                MessageBox.Show("비즈론 수기입금 처리를 완료 하였습니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                base.RollbackTransaction();
            }
            finally
            {
                EnableControls1(true);

                
            }
        }

        #endregion

    }
}