using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DemoClient.View.LRN
{
	public partial class LRN0200 : DemoClient.Controllers.BasePopupForm
    {
        private DataTable ReturnData { get; set; }

        #region LRN0200 : 생성자 함수

        public LRN0200()
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

        #region LRN0200_Load : 폼 로드 이벤트
        private void LRN0200_Load(object sender, EventArgs e)
        {
            try
            {
                _dtpEXECDT.Value = DateTime.Today;
                _dtpLNSTDT.Value = DateTime.Today.AddDays(1);
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
        
        #region Validation Check_Cal : 게산 시뮬레이션 버튼 클릭시 validation check

        private bool validation_chk_cal()
        {
            // 신청금액
            if (string.IsNullOrEmpty(_txtLNAMT.Text.Trim()))
            {
                MessageBox.Show("신청금액이 입력 되지 않았습니다. 신청금액을 입력하세요.");
                return false;
            }
            else
            {
                if (Convert.ToDecimal(_txtLNAMT.Text.Trim()) <= 0)
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

        
    }
}
