﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.Export;

namespace DemoClient.View.BAS
{
    public partial class mngPRCMST : DemoClient.Controllers.BaseForm //, ContWrollers.IBaseForm
    {
        private Thread _thread;
        public mngPRCMST()
        {
            InitializeComponent();

            gridView1.BestFitColumns();
        }

        private void mngPRCMST_Load(object sender, EventArgs e)
        {

        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            // 스톱와치 시작
            base.MainForm.StartStopWatch();
            // 커서 기다림
            base.SetWaitCursor();

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

                // 스톱와치 중지
                base.MainForm.StopStopWatch();
                // 커서 복원
                base.RestoreCursor();
            }
        }

        int Search()
        {
            int _retValue = -1;

            try
            {
                DataTable _dt = base.GetDataTable("P_mngPRCMST_S1"
                    , _proc_cd.Text
                    , _str_dt.Text
                    , _end_dt.Text
                    , _use_yn.EditValue
                    );

                if (gridControl1.InvokeRequired)
                {
                    gridControl1.Invoke(new Action(() => gridControl1.DataSource = _dt));
                }
                else
                {
                    gridControl1.DataSource = _dt;
                }
            }
            catch
            {
                throw;
            }

            return _retValue;
        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
            {
                //그리드 수정불가하게 막음
                gridView1.CloseEditor();
                //그리드의 row가 유효한지 확인하고 값을 datasource에 저장
                gridView1.UpdateCurrentRow();

                DataTable dt = gridControl1.DataSource as DataTable;

                String proc_cd = "";
                String proc_cd_old = "";
                String proc_nm = "";
                String str_dt = "";
                String end_dt = "";
                String use_yn = "";
                String rmks = "";
                String mid = "";
                String cid = "";

                for (int q = 0; q < dt.Rows.Count; q++)
                {
                    DataRow chkRow = dt.Rows[q];
                    proc_cd = chkRow["proc_cd"].ToString();
                    if (proc_cd == "")
                    {
                        MessageBox.Show("공정코드는 필수로 입력해야합니다.");
                        return;
                    }
                }

                try
                {
                    base.BeginTransaction();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dRow = dt.Rows[i];

                        if (dt.Rows[i].RowState.ToString() == "Deleted")
                        {
                            //dRow["mol_cd", DataRowVersion.Original] = 해당컬럼을 삭제하기전 원본데이터 행에서 가져옴
                            //해당컬럼을 삭제하기전 원본데이터 행에서 가져옴 -> 문자형으로 변경 -> 변수대입
                            proc_cd_old = dRow["proc_cd_old", DataRowVersion.Original].ToString();
                            //if (dRow["dst_dt", DataRowVersion.Original].ToString() != "") end_dt = dRow["dst_dt", DataRowVersion.Original].ToString().Substring(0, 10);
                            mid = base.GetCookie("USRID");

                            base.ExecuteNonQuery("P_mngPRCMST_D1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , proc_cd_old
                                    //, end_dt
                                    , mid
                                    );
                        }
                        else
                        {
                            proc_cd = dRow["proc_cd"].ToString();                                                                        //금형코드
                            proc_cd_old = dRow["proc_cd_old"].ToString();


                            //dt.Rows[i].RowState.ToString() 행의 현재 상태를 가져옴
                            if (proc_cd != "" && dt.Rows[i].RowState.ToString() != "Unchanged")
                            {
                                proc_nm = dRow["proc_nm"].ToString();                                                                        //금형 명
                                if (dRow["str_dt"].ToString() != "") str_dt = dRow["str_dt"].ToString().Substring(0, 10);                                                      //제작일
                                if (dRow["end_dt"].ToString() != "") end_dt = dRow["end_dt"].ToString().Substring(0, 10);                                                     //양산시작일
                                use_yn = dRow["use_yn"].ToString();                                                                       //NO.RACK(CAVIDAD)
                                rmks = dRow["rmks"].ToString();                                                                          //비고                                                                         //시스템 수정일
                                mid = base.GetCookie("USRID");                                                                          //시스템 수정자ID                                                                        //시스템 ~등록일~
                                cid = base.GetCookie("USRID");                                                                          //시스템 등록자ID

                                base.ExecuteNonQuery("P_mngPRCMST_IUD1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , proc_cd
                                    , proc_nm
                                    , str_dt
                                    , end_dt
                                    , use_yn
                                    , rmks
                                    , mid
                                    , cid
                                    );
                            };
                        }
                    }
                    base.CommitTransaction();
                    MessageBox.Show("작업장정보를 저장 하였습니다.");
                }
                catch (Exception err)
                {
                    base.RollbackTransaction();
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void _btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                base.BeginTransaction();
                DialogResult delask = MessageBox.Show("삭제하면 되돌릴수 없습니다. \n 삭제 하시겠습니까?", "※주의※", MessageBoxButtons.YesNo);

                //그리드 수정불가하게 막음
                gridView1.CloseEditor();
                //그리드의 row가 유효한지 확인하고 값을 datasource에 저장
                gridView1.UpdateCurrentRow();
                if (delask == DialogResult.Yes)
                {
                    DataTable dt = gridControl1.DataSource as DataTable;

                    String proc_cd_old = "";
                    String end_dt = "";
                    String mid = "";

                    int row_ind = gridView1.FocusedRowHandle;
                    gridView1.DeleteRow(row_ind);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dRow = dt.Rows[i];

                        if (dt.Rows[i].RowState.ToString() == "Deleted")
                        {
                            //dRow["mol_cd", DataRowVersion.Original] = 해당컬럼을 삭제하기전 원본데이터 행에서 가져옴
                            //해당컬럼을 삭제하기전 원본데이터 행에서 가져옴 -> 문자형으로 변경 -> 변수대입
                            proc_cd_old = dRow["proc_cd_old", DataRowVersion.Original].ToString();
                            if (dRow["end_dt", DataRowVersion.Original].ToString() != "") end_dt = dRow["end_dt", DataRowVersion.Original].ToString().Substring(0, 10);
                            mid = base.GetCookie("USRID");

                            base.ExecuteNonQuery("P_mngPRCMST_D1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , proc_cd_old
                                    //, end_dt
                                    , mid
                                    );
                        }
                    }
                }
                base.CommitTransaction();
            }
            catch (Exception err)
            {
                base.RollbackTransaction();
                MessageBox.Show(err.Message);
            }
        }
    }
}
