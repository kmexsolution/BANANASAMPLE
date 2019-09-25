using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
    public partial class mngWHSMST : DemoClient.Controllers.BaseForm
    {
        private Thread _thread;
        public mngWHSMST()
        {
            InitializeComponent();
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }

        private void mngWHSMST_Load(object sender, EventArgs e)
        {
            try
            {
                
                //검색을 미리 해야지 저장행위가 됨.
                int res = Search();
                string message = string.Format("{0:N0}건이 검색되었습니다.", res);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void EnableControls1(bool _bTrue)
        {

        }

        public void EnableControls2(bool _bTrue)
        {

        }

        public void ClearControls()
        {

        }

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

        int Search()
        {
            int _retValue = -1;
            String use_yn = "";

            if (s_rbUSE.Checked)
            {
                use_yn = "Y";
            }
            else if (s_rbEND.Checked)
            {
                use_yn = "N";
            }

            try
            {
                DataTable _dt = base.GetDataTable("P_mngWHSMST_S1"
                    , s_txtWHCD.Text
                    , s_txtWHNM.Text
                    , use_yn
                    );


                if (gridControl1.InvokeRequired)
                {
                    gridControl1.Invoke(new Action(() => gridControl1.DataSource = _dt));
                }
                else
                {
                    gridControl1.DataSource = _dt;
                }

                _retValue = _dt.Rows.Count;
            }
            catch
            {
                throw;
            }

            return _retValue;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            DataTable dt = gridControl1.DataSource as DataTable;

            String wh_cd = "";
            String wh_nm = "";            
            String str_dt = "";
            String end_dt = "";
            String wh_cd_old = "";


            //P_NO 누락건 체크
            try
            {
                base.BeginTransaction();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dRow = dt.Rows[i];
                    wh_cd = "";
                    wh_nm = "";                    
                    str_dt = "";
                    end_dt = "";
                    wh_cd_old = "";

                    if (dt.Rows[i].RowState.ToString() == "Deleted")
                    {
                        wh_cd = dRow["wh_cd", DataRowVersion.Original].ToString();                 //변수가져오는 방법..
                        wh_cd_old = dRow["wh_cd_old", DataRowVersion.Original].ToString();
                    }
                    else
                    {
                        wh_cd = dRow["wh_cd"].ToString();                 //변수가져오는 방법..
                        wh_cd_old = dRow["wh_cd_old"].ToString();
                    }

                    if (wh_cd_old != "" && dt.Rows[i].RowState.ToString() == "Deleted")
                    {
                        base.ExecuteNonQuery("P_mngWHSMST_IUD1"
                        , dt.Rows[i].RowState                    // 상태 added modified deleted
                        , base.GetCookie("USRID")           // 시스템수정자ID   
                        , wh_cd
                        , wh_nm                        
                        , str_dt
                        , end_dt
                        , wh_cd_old
                        );
                    }
                    else if (wh_cd != "" && dt.Rows[i].RowState.ToString() != "Unchanged")
                    {

                        wh_nm = dRow["wh_nm"].ToString();                        
                        str_dt = dRow["str_dt"].ToString();
                        end_dt = dRow["end_dt"].ToString();
                        wh_cd_old = dRow["wh_cd_old"].ToString();

                        base.ExecuteNonQuery("P_mngWHSMST_IUD1"
                        , dt.Rows[i].RowState                    // 상태 added modified deleted
                        , base.GetCookie("USRID")           // 시스템수정자ID   
                        , wh_cd
                        , wh_nm                        
                        , str_dt
                        , end_dt
                        , wh_cd_old
                        );

                    }
                }

                base.CommitTransaction();

                MessageBox.Show("창고 정보를 저장 하였습니다.");

            }
            catch (Exception err)
            {
                base.RollbackTransaction();
                MessageBox.Show(err.Message);
            }
        }

        
    }
}


