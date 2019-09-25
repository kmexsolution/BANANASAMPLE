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
    public partial class PNOMST : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
    {
        private Thread _thread;
        public PNOMST()
        {
            InitializeComponent();
        }

        private void PNOMST_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
                    , "Common"
                    , "PGB"
                    , ""
                    , ""
                    , ""
                    , ""
                    );

                s_lupPGB.Properties.DataSource = _dt01;
                s_lupPGB.Properties.DisplayMember = "CODE_NAME";
                s_lupPGB.Properties.ValueMember = "TOTAL_CODE";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_NAME", "품목구분", 100);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                s_lupPGB.Properties.Columns.Add(col);
                 


                _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
                    , "Common"
                    , "SGB"
                    , ""
                    , ""
                    , ""
                    , ""
                    );



                _dt01 = base.GetDataTable("P_mngMDLMST_S1"
                    , ""
                    , ""
                    , "Y"
                    );

                //repositoryItemGridLookUpEdit2.DataSource = _dt01;
                //repositoryItemGridLookUpEdit2.ValueMember = "mdl_cd";
                //repositoryItemGridLookUpEdit2.DisplayMember = "mdl_nm";
                



                //검색
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

            try
            {
                DataTable _dt = base.GetDataTable("P_mngPNOMST_S1"                    
                    ,"","",""
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

            String p_no = "";
            String p_name  = "";
            String p_gb    = "";
            String unit_bc = "";
            String spec    = "";
            String color_bc= "";
            String mdl_cd  = "";
            String sup_gb  = "";
            String mol_no  = "";
            String resin_ty = "";
            Double inc_qry = 0;
            String cst_pn  = "";
            Double p_wg    = 0;
            String in_wh   = "";
            String in_loc  = "";
            String sto_yn  = "";
            Double sto_qty = 0;
            String str_dt = "";
            String end_dt  = "";
            String end_rmk = "";
            String p_no_old = "";


            //P_NO 누락건 체크
            try
            {
                base.BeginTransaction();
                for (int i = 0; i < dt.Rows.Count ; i++)
                {
                    p_no = gridView1.GetRowCellValue(i, "p_no").ToString();   //변수가져오는 방법..
                    if (p_no != "" && dt.Rows[i].RowState.ToString() != "Unchanged")
                    {
                        
                        p_name = gridView1.GetRowCellValue(i, "p_name").ToString();
                        p_gb = gridView1.GetRowCellValue(i, "p_gb").ToString();
                        unit_bc = gridView1.GetRowCellValue(i, "unit_bc").ToString();
                        spec = gridView1.GetRowCellValue(i, "spec").ToString();
                        color_bc = gridView1.GetRowCellValue(i, "color_bc").ToString();
                        mdl_cd = gridView1.GetRowCellValue(i, "mdl_cd").ToString();
                        sup_gb = gridView1.GetRowCellValue(i, "sup_gb").ToString();
                        mol_no = gridView1.GetRowCellValue(i, "mol_no").ToString();
                        
                        resin_ty = gridView1.GetRowCellValue(i, "resin_ty").ToString();
                        inc_qry = Convert.ToDouble(gridView1.GetRowCellDisplayText(i, "inc_qty"));
                        cst_pn = gridView1.GetRowCellValue(i, "cst_pn").ToString();                       
                        p_wg = Convert.ToDouble(gridView1.GetRowCellDisplayText(i, "p_wg"));
                        in_wh = gridView1.GetRowCellValue(i, "in_wh").ToString();
                        in_loc = gridView1.GetRowCellValue(i, "in_loc").ToString();
                        sto_yn = gridView1.GetRowCellValue(i, "sto_yn").ToString();                                                
                        sto_qty = Convert.ToDouble(gridView1.GetRowCellDisplayText(i, "sto_qty"));
                      
                        str_dt = Convert.ToDateTime(gridView1.GetRowCellDisplayText(i, "str_dt")).ToString("yyyy-MM-dd");
                        end_dt = Convert.ToDateTime(gridView1.GetRowCellDisplayText(i, "end_dt")).ToString("yyyy-MM-dd");
                        end_rmk = gridView1.GetRowCellValue(i, "end_rmk").ToString();
                        p_no_old = gridView1.GetRowCellValue(i, "p_no_old").ToString();

                        base.ExecuteNonQuery("P_mngPNOMST_IUD1"
                        , dt.Rows[i].RowState                    // 상태 added modified deleted
                        , base.GetCookie("USRID")           // 시스템수정자ID   
                        , p_no
                        , p_name
                        , p_gb
                        , unit_bc
                        , spec
                        , color_bc
                        , mdl_cd
                        , sup_gb
                        , mol_no
                        , resin_ty
                        , inc_qry
                        , cst_pn
                        , p_wg
                        , in_wh
                        , in_loc
                        , sto_yn
                        , sto_qty
                        , str_dt
                        , end_dt
                        , end_rmk
                        , p_no_old
                        );
                    }
                }
                    base.CommitTransaction();

                    //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    //this.Close();
               
            }
            catch (Exception err)
            {
                base.RollbackTransaction();
                MessageBox.Show(err.Message);

                //this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            }
    
            
        }


        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            Common.frmFindZipCode form = new Common.frmFindZipCode();
            form.ZipCodeTextBox = _txtZIP_NO;
            form.AddressBasicTextBox = _txtADDR_BSC;
 //오류           form.dRow = dr;
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
//오류                gridView1.SetFocusedRowCellValue("mdl_cd", form.dRow.Cells["ZipCode"].Value.ToString());
            }
           
        }
    }
}
