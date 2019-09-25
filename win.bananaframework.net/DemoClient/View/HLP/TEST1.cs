using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.HLP
{
    public partial class TEST1 : DemoClient.Controllers.BaseForm
    {
        public TEST1()
        {
            InitializeComponent();
        }


        private void bananaButton1_Click(object sender, EventArgs e)
        {
            String dec = "pJjdgJi4mugWIsVVoq+j/uH190gbEe6inRjQ+bN9F1Xuyi0ytyZCUsiCt47dvcdV3vVMCBYSCMkpohNykHbD6ocQTAWR4Hu3IqyoXG+flos495e1UoX6bFJ7uSY5vynM7Ivf9u8yh2bxAY4uOZEZTeZdVbX22Mci";
            textBox2.Text = base.GetDecryptTripleDES(dec);
        }


        
                private void _btnSearch_Click_1(object sender, EventArgs e)

        {/*
                        // 스톱와치 시작
                        base.MainForm.StartStopWatch();
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
                            DataTable _dt = base.GetDataTable("PCSP_BAS0700_R1"
                                , base.GetCookie("COMPANY_CD")
                                , _txtAGT_NM_S.Text
                                , _txtAGT_CD_S.Text
                                , _txtPRSNT_NM_S.Text
                                , _txtADDR_BSC_S.Text
                                , _cmbBI_BINF_CD_S.SelectedValue
                                , _txtBI_SAUP_NO_S.Text
                                );
                            gridView1.DataSource = _dt;

                            _retValue = _dt.Rows.Count;
                        }
                        catch
                        {
                            throw;
                        }

                        return _retValue;*/
        }
        
    
    }
}
