using System;
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
using System.IO;

namespace DemoClient.View.BAS
{
    public partial class mngPRCPNO : DemoClient.Controllers.BaseForm
    {
        string _Sql = string.Empty;
        string _SqlText = string.Empty;
        private Thread _thread;
        String str = string.Empty;
        public mngPRCPNO()
        {
            InitializeComponent();

            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            
            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
        }

        private void mngPRCPNO_Load(object sender, EventArgs e)
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

        void Set_sql(String _Sql, String str)
        {
            if (_Sql == "Search")
            {
                _SqlText = "";
                _SqlText += "SELECT line_cd,line_nm FROM LINMST  \r\n";
                _SqlText += " WHERE use_yn = 'Y'  \r\n";
                _SqlText += " AND line_cd like '%'+'" + _line_cd.Text + "'+'%'  \r\n";
            }
            else if (_Sql == "Search1")
            {
                _SqlText = "";
                _SqlText += "SELECT A.line_cd, C.line_nm, A.proc_cd, D.proc_nm, A.p_no,                    \r\n";
                _SqlText += "       E.p_name,  A.mes_scr, A.c_time,  A.prt_yn,  A.prt_img,                 \r\n";
                _SqlText += "       A.use_yn,  A.cid,     A.cdt,     A.mid,     A.mdt,                     \r\n";
                _SqlText += "       A.p_no as p_no_old                                                     \r\n";
                _SqlText += "FROM PRCPNO A                                                                 \r\n";
                _SqlText += "       INNER JOIN LINPRC B ON A.proc_cd = B.proc_cd AND A.line_cd = B.line_cd \r\n";
                _SqlText += "       INNER JOIN LINMST C ON A.line_cd = C.line_cd                           \r\n";
                _SqlText += "       INNER JOIN PRCMST D ON A.proc_cd = D.proc_cd                           \r\n";
                _SqlText += "       INNER JOIN PNOMST E ON A.p_no = E.p_no                                 \r\n";
                _SqlText += " WHERE A.use_yn ='" + _use_yn.EditValue + "'                                  \r\n";
                _SqlText += "       AND A.line_cd like '%'+'" + str + "'+'%'                               \r\n";
                _SqlText += "       AND A.proc_cd like '%'+'" + _proc_cd.Text + "'+'%'                     \r\n";
                _SqlText += "       AND A.p_no like '%'+'" + _p_no.Text + "'+'%'                           \r\n";
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

                Set_sql("Search", "");
                DataTable _dt01 = base.GetDataTable(_SqlText);

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
                String linecd = dRow["line_cd"].ToString();

                Set_sql("Search1", linecd);
                _dt02 = base.GetDataTable(_SqlText);

                gridControl2.DataSource = _dt02;

                gridView2.AddNewRow();
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
            String proc_cd = "";
            String p_no = "";
            String p_no_old = "";
            String mes_scr = "";
            double c_time = 0;
            Image  prt_img = null;
            String prt_yn = "";
            String use_yn = "";
            String mid = "";
            String cid = "";

            //추가 사항 필수값 체크
            for (int q = 0; q < dt.Rows.Count; q++)
            {
                DataRow chkRow = dt.Rows[q];
                proc_cd = chkRow["proc_cd"].ToString();
                p_no = chkRow["p_no"].ToString();
                if(proc_cd == "" && p_no == "")
                {
                    MessageBox.Show("공정코드와 품목코드는 필수로 입력해야합니다.");
                    return;
                }
            }

            try
            {
                DialogResult savask = MessageBox.Show("저장하시겠습니까?", "※주의※", MessageBoxButtons.YesNo);
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
                    for (int j = 0; j <= (dt2.Rows.Count - 1); j++)
                    {
                        DataRow dRow2 = dt2.Rows[j];
                        if (dt2.Rows[j].RowState.ToString() == "Deleted")
                        {
                            DialogResult delask = MessageBox.Show("삭제 하시겠습니까?", "※주의※", MessageBoxButtons.YesNo);
                            //dRow["mol_cd", DataRowVersion.Original] = 해당컬럼을 삭제하기전 원본데이터 행에서 가져옴
                            //해당컬럼을 삭제하기전 원본데이터 행에서 가져옴 -> 문자형으로 변경 -> 변수대입
                            line_cd = dRow["line_cd"].ToString();
                            proc_cd = dRow2["proc_cd", DataRowVersion.Original].ToString();
                            p_no_old = dRow2["p_no_old", DataRowVersion.Original].ToString();
                            mid = base.GetCookie("USRID");
                            if (delask == DialogResult.Yes)
                            {
                                base.ExecuteNonQuery("P_mngPRCPNO_D1"
                                        , dt2.Rows[j].RowState //row 상태 값
                                        , line_cd
                                        , proc_cd
                                        , p_no_old
                                        , mid
                                        );
                            }
                        }
                        else
                        {

                            line_cd = dRow["line_cd"].ToString();
                            proc_cd = dRow2["proc_cd"].ToString();
                            p_no = dRow2["p_no"].ToString();                                                                        //금형코드
                            if (proc_cd != null && proc_cd != "")
                            {

                                //dt.Rows[i].RowState.ToString() 행의 현재 상태를 가져옴
                                if (p_no != "" && dt2.Rows[j].RowState.ToString() != "Unchanged")
                                {
                                    p_no_old = dRow2["p_no_old"].ToString();
                                    mes_scr = dRow2["mes_scr"].ToString();
                                    if (dRow2["use_yn"].ToString() == "") { use_yn = "Y"; } else { use_yn = dRow2["use_yn"].ToString(); }
                                    if (dRow2["c_time"].ToString() != "") c_time = Convert.ToDouble(dRow2["c_time"].ToString());
                                    
                                    //MemoryStream ms = new MemoryStream();
                                    //prt_img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    //byte[] bytes = ms.ToArray();

                                    prt_img = null;
                                    prt_yn = dRow2["prt_yn"].ToString();
                                    //공정번호
                                    mid = base.GetCookie("USRID");                                                                          //시스템 수정자ID
                                    cid = base.GetCookie("USRID");                                                                          //시스템 등록자ID

                                           base.ExecuteNonQuery("P_mngPRCPNO_IUD1"
                                        , dt2.Rows[j].RowState //row 상태 값
                                        , proc_cd
                                        , line_cd
                                        , p_no
                                        , p_no_old
                                        , mes_scr
                                        , use_yn
                                        , c_time
                                        , prt_img
                                        , prt_yn
                                        , mid
                                        , cid
                                        );
                                }
                            }
                        }
                    }
                }
                base.CommitTransaction();
                MessageBox.Show("작업장정보를 저장 하였습니다.");
                }else
                {
                    return;
                }
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
                gridView2.CloseEditor();
                //그리드의 row가 유효한지 확인하고 값을 datasource에 저장
                gridView1.UpdateCurrentRow();
                gridView2.UpdateCurrentRow();
                if (delask == DialogResult.Yes)
                {
                    DataTable dt = gridControl1.DataSource as DataTable;
                    DataTable dt2 = gridControl2.DataSource as DataTable;

                    String line_cd = "";
                    String proc_cd = "";
                    String p_no_old = "";
                    String mid = "";

                    int row_idx = gridView1.FocusedRowHandle;
                    int row_idx2 = gridView2.FocusedRowHandle;
                    gridView2.DeleteRow(row_idx2);

                    DataRow dRow = dt.Rows[row_idx];

                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {

                        DataRow dRow2 = dt2.Rows[i];

                        if (dt2.Rows[i].RowState.ToString() == "Deleted")
                        {
                            //dRow["mol_cd", DataRowVersion.Original] = 해당컬럼을 삭제하기전 원본데이터 행에서 가져옴
                            //해당컬럼을 삭제하기전 원본데이터 행에서 가져옴 -> 문자형으로 변경 -> 변수대입
                            line_cd = dRow["line_cd"].ToString();
                            proc_cd = dRow2["proc_cd", DataRowVersion.Original].ToString();
                            p_no_old = dRow2["p_no_old", DataRowVersion.Original].ToString();
                            mid = base.GetCookie("USRID");

                            base.ExecuteNonQuery("P_mngPRCPNO_D1"
                                    , dt2.Rows[i].RowState //row 상태 값
                                    , line_cd
                                    , proc_cd
                                    , p_no_old
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

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView2.FocusedRowHandle == gridView2.RowCount - 1)
            {
                gridView2.AddNewRow();
            }
        }

        //공정: 공정명 클릭 시 공정코드 및 공정명 입력
        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable dt = gridView2.DataSource as DataTable;
            int rowidx = gridView2.FocusedRowHandle;
            //int rowidx2 = gridView1.FocusedRowHandle;
            Common.frmPopUp pop = new Common.frmPopUp("LINPRC", gridView1.GetFocusedRowCellDisplayText("line_cd").ToString());

            DialogResult res = pop.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                gridView2.SetRowCellValue(rowidx, "proc_cd", pop.dRow["proc_cd"].ToString());
                gridView2.SetRowCellValue(rowidx, "proc_nm", pop.dRow["proc_nm"].ToString());
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        //팝업: 품명 클릭 시 품목코드 및 품명 입력
        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable dt = gridView2.DataSource as DataTable;
            int rowidx = gridView2.FocusedRowHandle;

            Common.frmPopUp pop = new Common.frmPopUp("PNOMST", gridView2.GetFocusedRowCellDisplayText("p_name").ToString());

            DialogResult res = pop.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {

                gridView2.SetRowCellValue(rowidx, "p_no", pop.dRow["p_no"].ToString());
                gridView2.SetRowCellValue(rowidx, "p_name", pop.dRow["p_name"].ToString());
            }
        }
        
        //팝업: 품명 클릭 시 품목코드 및 품명 입력
        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable dt = gridView2.DataSource as DataTable;
            int rowidx = gridView2.FocusedRowHandle;

            Common.frmPopUp pop = new Common.frmPopUp("PNOMST", gridView2.GetFocusedRowCellDisplayText("p_name").ToString());

            DialogResult res = pop.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {

                gridView2.SetRowCellValue(rowidx, "p_no", pop.dRow["p_no"].ToString());
                gridView2.SetRowCellValue(rowidx, "p_name1", pop.dRow["p_name"].ToString());
            }
        }
    }
}