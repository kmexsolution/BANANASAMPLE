using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using DevExpress.Utils;
using DevExpress.Export;
using DemoClient.Controllers;

namespace DemoClient.View.BAS
{
    public partial class mngMOLMST : DemoClient.Controllers.BaseForm //, Controllers.IBaseForm
    {
        // 검색 쓰레드
        private Thread _thread;
        public mngMOLMST()
        {
            InitializeComponent();
            
            gridView1.BestFitColumns();
        }

        private void mngMOLMST_Load(object sender, EventArgs e)
        {
            try
            {
                SetLookup1();

                //LookupColumn에 대한 값을 초기화함
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                //col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_NAME", "", 100);
                //컬럼을 오름차순으로 정렬함
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //Lookupedit 셋팅
        public void SetLookup1()
        {
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col1;
            DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER", "MOLD", "MGT", "", "", "", "");
            gate_tylookup.Properties.DataSource = _dt01;
            gate_tylookup.Properties.ValueMember = "TOTAL_CODE";
            gate_tylookup.Properties.DisplayMember = "CODE_NAME";
            col1 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_NAME", "GATE TYPE", 100);
            col1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gate_tylookup.Properties.Columns.Add(col1);

            repositoryItemLookUpEdit3.DataSource = _dt01;
            repositoryItemLookUpEdit3.ValueMember = "TOTAL_CODE";
            repositoryItemLookUpEdit3.DisplayMember = "CODE_NAME";
            repositoryItemLookUpEdit3.Columns.Add(col1);

            DevExpress.XtraEditors.Controls.LookUpColumnInfo col2;
            DataTable _dt02 = base.GetDataTable("CHP_AJAX_CODEHELPER", "MOLD", "MT0", "", "", "", "");
            mol_typelookup.Properties.DataSource = _dt02;
            mol_typelookup.Properties.ValueMember = "TOTAL_CODE";
            mol_typelookup.Properties.DisplayMember = "CODE_NAME";
            col2 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_NAME", "금형타입", 100);
            col2.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            mol_typelookup.Properties.Columns.Add(col2);

            repositoryItemLookUpEdit2.DataSource = _dt02;
            repositoryItemLookUpEdit2.ValueMember = "TOTAL_CODE";
            repositoryItemLookUpEdit2.DisplayMember = "CODE_NAME";
            repositoryItemLookUpEdit2.Columns.Add(col2);

            DevExpress.XtraEditors.Controls.LookUpColumnInfo col3;
            DataTable _dt03 = base.GetDataTable("CHP_AJAX_CODEHELPER", "MOLD", "MG0", "", "", "", "");
            mol_gdlookup.Properties.DataSource = _dt03;
            mol_gdlookup.Properties.ValueMember = "TOTAL_CODE";
            mol_gdlookup.Properties.DisplayMember = "CODE_NAME";
            col3 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_NAME", "금형등급", 100);
            col3.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            mol_gdlookup.Properties.Columns.Add(col3);

            repositoryItemLookUpEdit1.DataSource = _dt03;
            repositoryItemLookUpEdit1.ValueMember = "TOTAL_CODE";
            repositoryItemLookUpEdit1.DisplayMember = "CODE_NAME";
            repositoryItemLookUpEdit1.Columns.Add(col3);
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
                DataTable _dt = base.GetDataTable("P_mngMOLMST_S1"
                    , _mol_cd.Text
                    , gate_tylookup.EditValue.ToString()
                    , mol_typelookup.EditValue.ToString()
                    , mol_gdlookup.EditValue.ToString()
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
        #endregion


        #region _btnSave_Click : 저장 버튼 클릭 이벤트
        private void _btnSave_Click(object sender, EventArgs e)
        {
                //그리드 수정불가하게 막음
                gridView1.CloseEditor();
                //그리드의 row가 유효한지 확인하고 값을 datasource에 저장
                gridView1.UpdateCurrentRow();

                DataTable dt = gridControl1.DataSource as DataTable;

                String mol_cd = "";
                String mol_cd_old = "";
                String mol_no = "";
                String mol_nm = "";
                String mol_bano = "";
                String mo_ba_yn = "";
                String loc_cd = "";
                String cust_cd = "";
                double mol_hori = 0;
                double mol_vert = 0;
                double mol_high = 0;
                double mol_wht = 0;
                String gate_ty = "";
                double cavity = 0;
                String mol_type = "";
                String mol_gd = "";
                String rack_no = "";
                String crt_dt = "";
                String p_str_dt = "";
                String dst_dt = "";
                String rmks = "";
                String mid = "";
                String cid = "";

            for (int q = 0; q < dt.Rows.Count; q++)
            {
                DataRow chkrow = dt.Rows[q];
                mol_cd = chkrow["mol_cd"].ToString();
                if (mol_cd == "" && dt.Rows[q].RowState.ToString() != "Unchanged")
                {
                    MessageBox.Show("몰드 코드는 필수로 입력해야합니다.");
                    return;
                }
            }


            try
            {
                DialogResult savask = MessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                if (savask == DialogResult.Yes)
                {
                    base.BeginTransaction();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dRow = dt.Rows[i];

                        if (dt.Rows[i].RowState.ToString() == "Deleted")
                        {
                            //dRow["mol_cd", DataRowVersion.Original] = 해당컬럼을 삭제하기전 원본데이터 행에서 가져옴
                            //해당컬럼을 삭제하기전 원본데이터 행에서 가져옴 -> 문자형으로 변경 -> 변수대입
                            mol_cd_old = dRow["mol_cd_old", DataRowVersion.Original].ToString();
                            if (dRow["dst_dt", DataRowVersion.Original].ToString() != "") dst_dt = dRow["dst_dt", DataRowVersion.Original].ToString().Substring(0, 10);
                            mid = base.GetCookie("USRID");

                            base.ExecuteNonQuery("P_mngMOLMST_D1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , mol_cd_old
                                    , dst_dt
                                    , mid
                                    );
                        }
                        else
                        {
                            mol_cd = dRow["mol_cd"].ToString();                                                                        //금형코드
                            mol_cd_old = dRow["mol_cd_old"].ToString();


                            //dt.Rows[i].RowState.ToString() 행의 현재 상태를 가져옴
                            if (mol_cd != "" && dt.Rows[i].RowState.ToString() != "Unchanged")
                            {
                                mol_no = dRow["mol_no"].ToString();                                                                        //금형번호
                                mol_nm = dRow["mol_nm"].ToString();                                                                        //금형 명
                                mol_bano = dRow["mol_bano"].ToString();                                                                      //NO.MOLDE BASE
                                mo_ba_yn = dRow["mo_ba_yn"].ToString();                                                                      //Molde Base 사용여부
                                loc_cd = dRow["loc_cd"].ToString();                                                                        //금형위치
                                cust_cd = dRow["cust_cd"].ToString();                                                                       //금형제작처
                                if (dRow["mol_hori"].ToString() != "") mol_hori = Convert.ToDouble(dRow["mol_hori"].ToString());             //가로
                                                                                                                                             //if (dRow["mol_hori"].ToString() != "") mol_hori = Convert.ToDouble(dRow["mol_hori"].ToString());           
                                if (dRow["mol_vert"].ToString() != "") mol_vert = Convert.ToDouble(dRow["mol_vert"].ToString());  //세로
                                if (dRow["mol_high"].ToString() != "") mol_high = Convert.ToDouble(dRow["mol_high"].ToString());  //높이
                                if (dRow["mol_wht"].ToString() != "") mol_wht = Convert.ToDouble(dRow["mol_wht"].ToString());     //무게
                                gate_ty = dRow["gate_ty"].ToString();                                                                       //Gate Type
                                if (dRow["cavity"].ToString() != "") cavity = Convert.ToDouble(dRow["cavity"].ToString());        //cavity
                                mol_type = dRow["mol_type"].ToString();                                                                      //금형타입
                                mol_gd = dRow["mol_gd"].ToString();                                                                        //금형등급
                                rack_no = dRow["rack_no"].ToString();                                                                       //NO.RACK(CAVIDAD)
                                if (dRow["crt_dt"].ToString() != "") crt_dt = dRow["crt_dt"].ToString().Substring(0, 10);                                                      //제작일
                                if (dRow["p_str_dt"].ToString() != "") p_str_dt = dRow["p_str_dt"].ToString().Substring(0, 10);                                                     //양산시작일
                                if (dRow["dst_dt"].ToString() != "") dst_dt = dRow["dst_dt"].ToString().Substring(0, 10);                                                                        //폐기/반품일
                                rmks = dRow["rmks"].ToString();                                                                          //비고                                                                         //시스템 수정일
                                mid = base.GetCookie("USRID");                                                                          //시스템 수정자ID                                                                        //시스템 ~등록일~
                                cid = base.GetCookie("USRID");                                                                          //시스템 등록자ID

                                base.ExecuteNonQuery("P_mngMOLMST_IUD1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , mol_cd
                                    , mol_cd_old
                                    , mol_no
                                    , mol_nm
                                    , mol_bano
                                    , mo_ba_yn
                                    , loc_cd
                                    , cust_cd
                                    , mol_hori
                                    , mol_vert
                                    , mol_high
                                    , mol_wht
                                    , gate_ty
                                    , cavity
                                    , mol_type
                                    , mol_gd
                                    , rack_no
                                    , crt_dt
                                    , p_str_dt
                                    , dst_dt
                                    , rmks
                                    , mid
                                    , cid
                                    );
                            };
                        }
                    }
                    base.CommitTransaction();
                    _btnSearch_Click(sender, e);
                    MessageBox.Show("금형정보를 저장 하였습니다.");
                }
                else
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
        #endregion

        #region _btnDel_Click : 삭제 버튼 클릭 이벤트
        /// <summary>
        /// 삭제 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    String mol_cd_old = "";
                    String dst_dt = "";
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
                            mol_cd_old = dRow["mol_cd_old", DataRowVersion.Original].ToString();
                            if (dRow["dst_dt", DataRowVersion.Original].ToString() != "") dst_dt = dRow["dst_dt", DataRowVersion.Original].ToString().Substring(0, 10);
                            mid = base.GetCookie("USRID");

                            base.ExecuteNonQuery("P_mngMOLMST_D1"
                                    , dt.Rows[i].RowState //row 상태 값
                                    , mol_cd_old
                                    , dst_dt
                                    , mid
                                    );
                        }
                    }
                    base.CommitTransaction();
                    _btnSearch_Click(sender, e);
                    MessageBox.Show("삭제가 완료되었습니다.");
                }
            }
            catch (Exception err)
            {
                base.RollbackTransaction();
                MessageBox.Show(err.Message);
            }
        }
        #endregion

    }
}