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
    public partial class mngLOCMST : DemoClient.Controllers.BaseForm
    {
        private Thread _thread;
        public mngLOCMST()
        {
            InitializeComponent();
        }

        private void mngLOCMST_Load(object sender, EventArgs e)
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
            DataTable _dt = base.GetDataTable("P_mngLOCMST_S1"
                , s_txtLOCCD.Text
                , s_txtLOCNM.Text
                , s_lupWHCD.EditValue.ToString()
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
                
            gridView1.AddNewRow();

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

            String wh_cd  = "";
            String loc_cd = "";
            String loc_nm = "";
            String str_dt = "";
            String end_dt = "";
            String wh_cd_old = "";
            String loc_cd_old = "";


            //P_NO 누락건 체크
            try
            {
                base.BeginTransaction();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dRow = dt.Rows[i];
                    wh_cd = "";
                    loc_cd = "";
                    loc_nm = "";
                    str_dt = "";
                    end_dt = "";
                    wh_cd_old = "";
                    loc_cd_old = "";

                    if (dt.Rows[i].RowState.ToString() == "Deleted")
                    {
                        wh_cd = dRow["wh_cd", DataRowVersion.Original].ToString();                 //변수가져오는 방법..
                        loc_cd = dRow["loc_cd", DataRowVersion.Original].ToString();
                        wh_cd_old = dRow["wh_cd_old", DataRowVersion.Original].ToString();
                        loc_cd_old = dRow["loc_cd_old", DataRowVersion.Original].ToString();
                    }
                    else
                    {
                        wh_cd = dRow["wh_cd"].ToString();                 //변수가져오는 방법..
                        wh_cd_old = dRow["wh_cd_old"].ToString();
                        loc_cd = dRow["loc_cd"].ToString();                 //변수가져오는 방법..
                        loc_cd_old = dRow["loc_cd_old"].ToString();
                    }

                    if (wh_cd_old != "" && loc_cd_old != "" && dt.Rows[i].RowState.ToString() == "Deleted")
                    {
                        base.ExecuteNonQuery("P_mngLOCMST_IUD1"
                        , dt.Rows[i].RowState                    // 상태 added modified deleted
                        , base.GetCookie("USRID")           // 시스템수정자ID   
                        , wh_cd
                        , loc_cd
                        , loc_nm
                        , str_dt
                        , end_dt                        
                        , wh_cd_old
                        , loc_cd_old
                        );
                    }
                    else if (wh_cd != "" && loc_cd != "" && dt.Rows[i].RowState.ToString() != "Unchanged")
                    {

                        
                        loc_nm = dRow["loc_nm"].ToString();
                        str_dt = dRow["str_dt"].ToString();
                        end_dt = dRow["end_dt"].ToString();
                        wh_cd_old = dRow["wh_cd_old"].ToString();
                        loc_cd_old = dRow["loc_cd_old"].ToString();

                        base.ExecuteNonQuery("P_mngLOCMST_IUD1"
                        , dt.Rows[i].RowState                    // 상태 added modified deleted
                        , base.GetCookie("USRID")           // 시스템수정자ID   
                        , wh_cd
                        , loc_cd
                        , loc_nm
                        , str_dt
                        , end_dt                       
                        , wh_cd_old
                        , loc_cd_old
                        );

                    }
                }

                base.CommitTransaction();

                MessageBox.Show("로케이션 정보를 저장 하였습니다.");

            }
            catch (Exception err)
            {
                base.RollbackTransaction();
                MessageBox.Show(err.Message);
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //DevExpress.XtraGrid.Views.Base.ColumnView view = sender as DevExpress.XtraGrid.Views.Base.ColumnView;
            //string sCondCode = Convert.ToString(view.GetRowCellValue(e.RowHandle, view.Columns["wh_cd"]));
            //if (sCondCode == "")
            //{
            //    e.Valid = false;
            //    e.ErrorText = "창고코드를 입력하십시오.";
               
            //}

            //view.SetColumnError(view.Columns["wh_cd"], sCondCode == "" ? "창고코드를 입력하십시오." : null);

            //if (e.Valid == false) return;
            

            

        }

        private void ribWH_CD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            Common.frmPopUp form = new Common.frmPopUp("WHSMST", gridView1.GetFocusedRowCellDisplayText("wh_cd"));
            DialogResult res = form.ShowDialog();
            
            if (res == System.Windows.Forms.DialogResult.OK)
            {            
                gridView1.SetFocusedRowCellValue("wh_cd", form.dRow["wh_cd"].ToString());
                gridView1.SetFocusedRowCellValue("wh_nm", form.dRow["wh_nm"].ToString());
               
            }
        }

        private void ribWH_CD_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "")
            {
                gridView1.SetFocusedRowCellValue("wh_nm", "");
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            //int row_idx = e.RowHandle;
            //if (gridView1.FocusedRowHandle < 0) row_idx = 0;
            //if (row_idx == gridView1.RowCount - 1)
            //{
            //    gridView1.AddNewRow();
            //}
        }
    }
}

