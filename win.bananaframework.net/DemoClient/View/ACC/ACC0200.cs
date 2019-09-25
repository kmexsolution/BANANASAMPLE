using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.ACC
{
    /// <summary>
    /// 제  목: 정산마감 내역 조회
    /// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
    /// 작성일: 2014-07-29 20:43
    /// 설  명: 정산마감 내역을 조회 하는 화면입니다.
    /// </summary>
	public partial class ACC0200 : DemoClient.Controllers.BaseForm
	{
        // 검색 쓰레드
        private Thread _thread;

        #region ACC0200 : 생성자 함수
        /// <summary>
        /// 생성자 함수
        /// </summary>
        public ACC0200()
		{
			InitializeComponent();
		}

        #endregion

        #region ACC0100_Load : 폼 로드 이벤트
        /// <summary>
        /// 폼 로드 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACC0100_Load(object sender, EventArgs e)
        {
            try
            {
                //_dtpTRADEDATE_S_S.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                //_dtpTRADEDATE_E_S.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

                _dtpTRADEDATE_S_S.Value = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
                _dtpTRADEDATE_E_S.Value = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));

                gridView1.ReadOnly = false;
                //STR_NM.ReadOnly = true;
                //STR_CD.ReadOnly = true;
                
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
            _txtSTR_CD_S.ReadOnly = !_bTrue;
            //_dtpTRADEDATE_S_S.Enabled = _bTrue;
            //_dtpTRADEDATE_E_S.Enabled = _bTrue;
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
                DataSet _ds = base.GetDataSet("PCSP_ACC0200_R1"
                    , base.GetCookie("COMPANY_CD")
                    , _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd")
                    , _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd")
                    , _txtSTR_CD_S.Text
                    , _txtSTR_NM_S.Text
                    );
                gridView1.DataSource = _ds.Tables[0];

                _retValue = _ds.Tables[0].Rows.Count;
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
            
            var diffRows = gridView1.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToDecimal(row.Cells["TRAMTDIFF"].Value.ToString()) != 0)
                .Select(row => row);
            foreach (DataGridViewRow row in diffRows)
            {
                row.Cells["TRAMTDIFF"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
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
                //Dictionary<string, string> _dic = new Dictionary<string, string>();
                //_dic.Add("F", "#,###");
                //_dic.Add("G", "#,###");
                //_dic.Add("H", "#,###");
                //_dic.Add("I", "#,###");
                //_dic.Add("J", "#,###");
                //_dic.Add("K", "#,###");
                //_dic.Add("L", "#,###");
                //gridView1.ExportToExcel(_dic);

                gridView1.ExportToExcel();
            }
            catch (Exception err)
            {
                BANANA.Windows.Logger.Error(err);
                MessageBox.Show(err.Message);
            }
        }
        #endregion

	}
}
