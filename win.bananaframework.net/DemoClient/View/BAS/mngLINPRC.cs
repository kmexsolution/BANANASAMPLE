using System;
using System.Collections;
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
    public partial class mngLINPRC : DemoClient.Controllers.BaseForm
    {
        string _Sql = string.Empty;
        string _SqlText = string.Empty;
        private Thread _thread;
        public mngLINPRC()
        {
            InitializeComponent();

            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
        }

        private void mngLINPRC_Load(object sender, EventArgs e)
        {

        }

        #region _btnSearch_Click : (왼쪽)검색 버튼 클릭 이벤트
        /// <summary>
        /// (왼쪽)검색 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSearch_Click(object sender, EventArgs e)
        {
            
            // 스톱와치 시작
            base.MainForm.StartStopWatch();
            // 커서 기다림
            base.SetWaitCursor();

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

                // 스톱와치 중지
                base.MainForm.StopStopWatch();
                // 커서 복원
                base.RestoreCursor();
            }
        }

        void Set_sql(String _Sql)
        {
            _SqlText = "";
            _SqlText += "SELECT LINE_CD,LINE_NM FROM LINMST  \n";
            _SqlText += " WHERE use_yn = '"+_use_yn.EditValue + "'  \n";
            _SqlText += " AND line_cd like '%'+'"+_line_cd.Text+ "'+'%'  \n";
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
                Set_sql(_Sql);
                DataTable _dt01 = base.GetDataTable(_SqlText);

                //그리드1클릭시 클릭한 행의 행수를 가져옴
                int row_idx = 0;
                row_idx = gridView1.FocusedRowHandle;

                if (gridControl1.InvokeRequired)
                {
                    gridControl1.Invoke(new Action(() => gridControl1.DataSource = _dt01));
                    gridControl2.Invoke(new Action(() => gridControl2.DataSource = null));
                }
                else
                {
                    gridControl1.DataSource = _dt01;
                    gridControl2.DataSource = null;
                }

            }
            catch
            {
                throw;
            }

            return _retValue;
        }
        #endregion

        private void _btnSearch1_Click(object sender, EventArgs e)
        {
            int row_idx = gridView1.FocusedRowHandle;
            DataTable _dt01 = (DataTable)gridControl1.DataSource;
            if (gridView1.DataSource != null)
            {
                DataTable _dt02;
                //rowcount는 1부터 시작하므로 0이아니면 

                DataRow dRow = _dt01.Rows[row_idx];
                String linecd = dRow["LINE_CD"].ToString();

                _dt02 = base.GetDataTable("SELECT A.proc_cd AS proc_cd_old, A.proc_cd, B.proc_nm, A.str_dt, A.end_dt, \r\n"
                                                         + " A.use_yn, A.cid, A.cdt, A.mid, A.mdt \r\n"
                                                         + " FROM LINPRC A \r\n"
                                                         + " INNER JOIN PRCMST B ON A.proc_cd = B.proc_cd \r\n"
                                                         + " WHERE A.line_cd = '" + linecd
                                                         //+ "' AND A.str_dt like '%'+'" + _str_dt.Text +"'+'%"
                                                         //+ "' AND A.end_dt like '%'+'" + _end_dt.Text +"'+'%"
                                                         + "' AND A.use_yn = 'Y' \r\n"
                                                         );
                gridControl2.DataSource = _dt02;
            }
        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
                //그리드 수정불가하게 막음
                gridView1.CloseEditor();
                gridView2.CloseEditor();
                //그리드의 row가 유효한지 확인하고 값을 datasource에 저장
                gridView1.UpdateCurrentRow();
                gridView2.UpdateCurrentRow();

                DataTable dt = gridControl1.DataSource as DataTable;
                DataTable dt2 = gridControl2.DataSource as DataTable;

                String line_cd = "";
                String line_cd_old = "";
                String proc_cd = "";
                String proc_cd_old = "";
                String proc_nm = "";
                Nullable<DateTime> str_dt = null;
                Nullable<DateTime> end_dt = null;
                String use_yn = "";
                String mid = "";
                String cid = "";

            for (int q = 0; q < dt.Rows.Count; q++)
            {
                DataRow chkRow = dt.Rows[q];
                proc_cd = chkRow["proc_cd"].ToString();
                if (proc_cd != null && proc_cd != "")
                {
                    MessageBox.Show("공정코드는 필수로 입력해야합니다.");
                    return;
                }
            }


                try
                {
                    DialogResult savask = MessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (savask == DialogResult.Yes)
                    {
                    base.BeginTransaction();
                    int i = gridView1.FocusedRowHandle;

                        DataRow dRow = dt.Rows[i];

                        if (dt.Rows[i].RowState.ToString() == "Deleted")
                        {

                        }
                        else
                        {
                            for (int j = 0; j <= (dt2.Rows.Count-1); j++)
                            {
                                DataRow dRow2 = dt2.Rows[j];
                                if (dt2.Rows[j].RowState.ToString() == "Deleted")
                                {
                                    DialogResult delask = MessageBox.Show("삭제 하시겠습니까?", "※주의※", MessageBoxButtons.YesNo);
                                //dRow["mol_cd", DataRowVersion.Original] = 해당컬럼을 삭제하기전 원본데이터 행에서 가져옴
                                //해당컬럼을 삭제하기전 원본데이터 행에서 가져옴 -> 문자형으로 변경 -> 변수대입
                                line_cd = dRow["line_cd"].ToString();
                                proc_cd_old = dRow2["proc_cd_old", DataRowVersion.Original].ToString();
                                    end_dt = dRow2["end_dt", DataRowVersion.Original] as Nullable<DateTime>;
                                    mid = base.GetCookie("USRID");
                                    if (delask == DialogResult.Yes)
                                    {
                                    base.ExecuteNonQuery("P_mngLINPRC_D1"
                                            , dt2.Rows[j].RowState //row 상태 값
                                            , line_cd
                                            , proc_cd_old
                                            , mid
                                            );
                                    }
                                }
                                else
                                {
                                
                                    line_cd = dRow["line_cd"].ToString();
                                    line_cd_old = dRow["line_cd", DataRowVersion.Original].ToString();
                                    proc_cd = dRow2["proc_cd"].ToString();                                                                        //금형코드
                                    if (proc_cd != null && proc_cd != "")
                                    {
                                        proc_cd_old = dRow2["proc_cd", DataRowVersion.Original].ToString();
                                        //dt.Rows[i].RowState.ToString() 행의 현재 상태를 가져옴
                                        if (proc_cd != "" && dt2.Rows[j].RowState.ToString() != "Unchanged")
                                        {
                                            proc_cd = dRow2["proc_cd"].ToString();                                                                  //공정번호
                                            proc_nm = dRow2["proc_nm"].ToString();                                                                  //공정 명
                                        
                                            str_dt = dRow2["str_dt"] as Nullable<DateTime>;             //적용시작일
                                            end_dt = dRow2["end_dt"] as Nullable<DateTime>;            //적용종료일
                                            if (dRow2["use_yn"].ToString() == "") { use_yn = "Y"; }else { use_yn = dRow2["use_yn"].ToString(); }
                                            mid = base.GetCookie("USRID");                                                                          //시스템 수정자ID
                                            cid = base.GetCookie("USRID");                                                                          //시스템 등록자ID
                                        
                                            base.ExecuteNonQuery("P_mngLINPRC_IUD1"
                                                , dt2.Rows[j].RowState //row 상태 값
                                                , line_cd
                                                , line_cd_old
                                                , proc_cd
                                                , proc_cd_old
                                                , str_dt
                                                , end_dt
                                                , use_yn
                                                , mid
                                                , cid
                                                );
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                     return;
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

        private void _btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                base.BeginTransaction();
                DialogResult delask = MessageBox.Show("삭제 하시겠습니까?", "※주의※", MessageBoxButtons.YesNo);

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

                            base.ExecuteNonQuery("P_mngLINPRC_D1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , line_cd_old
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

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int rowidx = gridView2.FocusedRowHandle;
           
            Common.frmPopUp pop = new Common.frmPopUp("PNOMST", gridView2.GetFocusedRowCellDisplayText("p_no").ToString());

            DialogResult res = pop.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
               gridView2.SetRowCellValue(rowidx, "p_no", pop.dRow["p_no"].ToString());
               gridView2.SetRowCellValue(rowidx, "p_name", pop.dRow["p_name"].ToString());
            }
        }

        

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView2.FocusedRowHandle == gridView2.RowCount - 1)
            {
                gridView2.AddNewRow();
            }
        }
    }
}
