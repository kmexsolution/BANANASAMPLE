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
    /// <summary>
    /// 제  목: 여신사정보관리
    /// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
    /// 작성일: 2014-08-05 21:22
    /// 설  명: 여신사정보를 관리하는 화면입니다.
    /// </summary>
    public partial class BAS0900 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
        // 검색 쓰레드
        private Thread _thread;

        #region BAS0900 : 생성자 함수
        /// <summary>
        /// 생성자 함수
        /// </summary>
		public BAS0900()
		{
			InitializeComponent();
        }
        #endregion

        #region BAS0900_Load : 폼 로드 이벤트
        /// <summary>
        /// 폼 로드 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BAS0900_Load(object sender, EventArgs e)
        {
            try
            {
				//// 컬럼 밴드 처리-사업자등록증정보
				//var band01 = new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND01", HeaderText = "사업자등록증정보", BackColor = Color.Azure, UseBackColor = true };
				//band01.Columns.Add(BI_COMPANY_NM);
				//band01.Columns.Add(BI_PRSNT_NM);
				//band01.Columns.Add(BI_SAUP_NO);
				//band01.Columns.Add(BI_BUBIN_NO);
				//band01.Columns.Add(BI_ZIP_NO);
				//band01.Columns.Add(BI_ADDR_BSC);
				//band01.Columns.Add(BI_UPTE);
				//band01.Columns.Add(BI_JONGMOK);
				//band01.Columns.Add(BI_EMAIL);
				//this.gridView1.AddBand(band01);

                // 사업자구분(수정)
                DataTable _dt01 = base.GetDataTable("CHP_AJAX_CODEHELPER"
                    , "Common"
                    , "A01"
                    , ""
                    , ""
                    , ""
                    , ""
                    );
                base.SetListItem(_cmbBI_BINF_CD
                    , _dt01
                    , "TOTAL_CODE"
                    , "CODE_NAME"
                    );

                // 사업자구분(검색)
                DataTable _dt02 = _dt01.Copy();
                base.SetListItem(_cmbBI_BINF_CD_S
                    , _dt02
                    , "TOTAL_CODE"
                    , "CODE_NAME"
                    , true
                    );
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region BAS0900_Shown : 폼 보이기 이벤트
        /// <summary>
        /// 폼 보이기 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BAS0900_Shown(object sender, EventArgs e)
        {
            _txtLNR_NM_S.Focus();
        }
        #endregion

        #region ClearControls : 컨트롤 초기화
        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        public void ClearControls()
        {
            _txtLNR_CD.Text					= "";	// 회사코드
            _txtLNR_NM.Text					= "";	// 회사명
            _txtPRSNT_NM.Text				= "";	// 대표자명
            _txtZIP_NO.Text					= "";	// 우편번호
            _txtADDR_BSC.Text				= "";	// 기본주소
            _txtADDR_DTL.Text				= "";	// 상세주소
            _txtTELNO.Text					= "";	// 전화번호
            _txtFAXNO.Text					= "";	// 팩스번호
            _txtBI_COMPANY_NM.Text			= "";	// 법인명(단체명)
            _txtBI_PRSNT_NM.Text			= "";	// 대표자명
            _cmbBI_BINF_CD.SelectedIndex	= 0;	// 사업자구분
            _txtBI_SAUP_NO.Text				= "";	// 사업자등록번호
            _txtBI_BUBIN_NO.Text			= "";	// 법인등록번호
            _txtBI_ZIP_NO.Text				= "";	// 우편번호
            _txtBI_ADDR_BSC.Text			= "";	// 기본주소
            _txtBI_ADDR_DTL.Text			= "";	// 상세주소
            _txtBI_UPTE.Text				= "";	// 업태
            _txtBI_JONGMOK.Text				= "";	// 종목
            _txtBI_EMAIL.Text				= "";	// 세금계산서 이메일
            labelmemo.Text					= "";	// 메모
        }
        #endregion

        #region EnableControls1 : 컨트롤 활성화/비활성화 처리
        /// <summary>
        /// 컨트롤 활성화/비활성화 처리
        /// </summary>
        /// <param name="_bTrue"></param>
        public void EnableControls1(bool _bTrue)
        {
            _txtLNR_NM_S.ReadOnly = !_bTrue;
            _txtLNR_CD_S.ReadOnly = !_bTrue;
            _txtPRSNT_NM_S.ReadOnly = !_bTrue;
            _txtADDR_BSC_S.ReadOnly = !_bTrue;
            _cmbBI_BINF_CD_S.Enabled = _bTrue;
            _txtBI_SAUP_NO_S.ReadOnly = !_bTrue;
            _btnSearch.Enabled = _bTrue;
            gridView1.Enabled = _bTrue;
        }
        #endregion

        #region EnableControls2 : 컨트롤 활성화/비활성화 처리
        /// <summary>
        /// 컨트롤 활성화/비활성화 처리
        /// </summary>
        /// <param name="_bTrue"></param>
        public void EnableControls2(bool _bTrue)
        {
            _txtLNR_NM.ReadOnly = !_bTrue;
            _txtPRSNT_NM.ReadOnly = !_bTrue;
            _txtZIP_NO.ReadOnly = !_bTrue;
            _btnFindZipCode01.Enabled = _bTrue;
            _txtADDR_BSC.ReadOnly = !_bTrue;
            _txtADDR_DTL.ReadOnly = !_bTrue;
            _txtTELNO.ReadOnly = !_bTrue;
            _txtFAXNO.ReadOnly = !_bTrue;
            _txtMEMO.ReadOnly = !_bTrue;
            _txtBI_COMPANY_NM.ReadOnly = !_bTrue;
            _txtBI_PRSNT_NM.ReadOnly = !_bTrue;
            _cmbBI_BINF_CD.Enabled = _bTrue;
            _txtBI_SAUP_NO.ReadOnly = !_bTrue;
            _txtBI_BUBIN_NO.ReadOnly = !_bTrue;
            _txtBI_ZIP_NO.ReadOnly = !_bTrue;
            _btnFindZipCode02.Enabled = _bTrue;
            _txtBI_ADDR_BSC.ReadOnly = !_bTrue;
            _txtBI_ADDR_DTL.ReadOnly = !_bTrue;
            _txtBI_UPTE.ReadOnly = !_bTrue;
            _txtBI_JONGMOK.ReadOnly = !_bTrue;
            _txtBI_EMAIL.ReadOnly = !_bTrue;

            _btnSave.Enabled = _bTrue;
            _btnSave2.Enabled = _bTrue;
            _btnDel.Enabled = _bTrue;
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
                DataTable _dt = base.GetDataTable("PCSP_BAS0900_R1"
                    , _txtLNR_NM_S.Text
                    , _txtLNR_CD_S.Text
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

            return _retValue;
        }
        #endregion

        #region _btnSave_Click : 저장 버튼 클릭 이벤트
        /// <summary>
        /// 저장 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                base.ExecuteNonQuery("PCSP_BAS0900_U1"
                    , _txtLNR_CD.Text			    // 여신사코드
                    , _txtLNR_NM.Text			    // 여신사명
                    , _txtPRSNT_NM.Text				// 대표자명
                    , _txtZIP_NO.Text				// 우편번호
                    , _txtADDR_BSC.Text				// 기본주소
                    , _txtADDR_DTL.Text				// 상세주소
                    , _txtTELNO.Text				// 전화번호
                    , _txtFAXNO.Text				// 팩스번호
                    , _txtBI_COMPANY_NM.Text		// 법인명(단체명)
                    , _txtBI_PRSNT_NM.Text			// 대표자명
                    , _cmbBI_BINF_CD.SelectedValue	// 사업자구분
                    , _txtBI_SAUP_NO.Text			// 사업자등록번호
                    , _txtBI_BUBIN_NO.Text			// 법인등록번호
                    , _txtBI_ZIP_NO.Text			// 우편번호
                    , _txtBI_ADDR_BSC.Text			// 기본주소
                    , _txtBI_ADDR_DTL.Text			// 상세주소
                    , _txtBI_UPTE.Text				// 업태
                    , _txtBI_JONGMOK.Text			// 종목
                    , _txtBI_EMAIL.Text				// 세금계산서 이메일
                    , _txtMEMO.Text			    	// 메모
                    , ""							// 비고
                    , base.GetCookie("USRID")		// 시스템수정자ID
                    , base.GetCookie("USRNM")		// 시스템수정자명
                    );

                MessageBox.Show("회사정보를 수정 하였습니다.");

				gridView1.Rows[gridView1.CurrentRow.Index].Cells["FAXNO"].Value = _txtFAXNO.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region collapsibleSplitter1_DoubleClick : 스플릿바 더블 클릭 이벤트
        /// <summary>
        /// 스플릿바 더블 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collapsibleSplitter1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.Width = 707;
        }
        #endregion

        #region 우편번호 자동 입력
        private void _txtADDR_DTL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_txtZIP_NO.Text) && !string.IsNullOrEmpty(_txtADDR_BSC.Text) && !string.IsNullOrEmpty(_txtADDR_DTL.Text))
            {
                _txtZIP_NO.Text = Controllers.ZipCode.GetZipCode(string.Format("{0} {1}", _txtADDR_BSC.Text, _txtADDR_DTL.Text));
            }
        }

        private void _txtBI_ADDR_DTL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_txtBI_ZIP_NO.Text) && !string.IsNullOrEmpty(_txtBI_ADDR_BSC.Text) && !string.IsNullOrEmpty(_txtBI_ADDR_DTL.Text))
            {
                _txtBI_ZIP_NO.Text = Controllers.ZipCode.GetZipCode(string.Format("{0} {1}", _txtBI_ADDR_BSC.Text, _txtBI_ADDR_DTL.Text));
            }
        }
        #endregion

        #region tabControl1_SelectedIndexChanged : 탭 선택 이벤트
        /// <summary>
        /// 탭 선택 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                _txtLNR_NM.Focus();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                _txtBI_COMPANY_NM.Focus();
            }
        }
        #endregion

        #region _btnFindZipCode01_Click : 우편번호 찾기 버튼 이벤트
        /// <summary>
        /// 우편번호 찾기 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnFindZipCode01_Click(object sender, EventArgs e)
        {
            Common.frmFindZipCode form = new Common.frmFindZipCode();
            form.ZipCodeTextBox = _txtZIP_NO;
            form.AddressBasicTextBox = _txtADDR_BSC;
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                _txtADDR_DTL.Focus();
            }
        }
        #endregion

        #region _btnFindZipCode02_Click : 우편번호 찾기 버튼 이벤트
        /// <summary>
        /// 우편번호 찾기 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnFindZipCode02_Click(object sender, EventArgs e)
        {
            Common.frmFindZipCode form = new Common.frmFindZipCode();
            form.ZipCodeTextBox = _txtBI_ZIP_NO;
            form.AddressBasicTextBox = _txtBI_ADDR_BSC;
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                _txtBI_ADDR_DTL.Focus();
            }
        }
        #endregion

        #region _btnAdd_Click : 추가 버튼 이벤트
        /// <summary>
        /// 추가 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BAS0910 form = new BAS0910();
                form.ShowDialog();

                // 새로운 정보 바인딩
                Search();
                ClearControls();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region grvBAS0900_CellClick : 그리드 클릭 시, 상세정보 바인딩
        /// <summary>
        /// 그리드 클릭 시, 상세정보 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvBAS0900_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    // 스플릿바 처리
                    if (collapsibleSplitter1.IsCollapsed)
                    {
                        collapsibleSplitter1.ToggleState();
                    }

                    EnableControls2(true);

                    DataTable _dt = base.GetDataTable("PCSP_BAS0900_R2"
                        , gridView1.Rows[e.RowIndex].Cells["LNR_CD"].Value
                        );
                    _txtLNR_CD.Text = _dt.Rows[0]["LNR_CD"].ToString();
                    _txtLNR_NM.Text = _dt.Rows[0]["LNR_NM"].ToString();
                    _txtPRSNT_NM.Text = _dt.Rows[0]["PRSNT_NM"].ToString();
                    _txtZIP_NO.Text = _dt.Rows[0]["ZIP_NO"].ToString().Trim();
                    _txtADDR_BSC.Text = _dt.Rows[0]["ADDR_BSC"].ToString();
                    _txtADDR_DTL.Text = _dt.Rows[0]["ADDR_DTL"].ToString();
                    _txtTELNO.Text = _dt.Rows[0]["TELNO"].ToString();
                    _txtFAXNO.Text = _dt.Rows[0]["FAXNO"].ToString();
                    _txtMEMO.Text = _dt.Rows[0]["MEMO"].ToString();
                    _txtBI_COMPANY_NM.Text = _dt.Rows[0]["BI_COMPANY_NM"].ToString();
                    _txtBI_PRSNT_NM.Text = _dt.Rows[0]["BI_PRSNT_NM"].ToString();
                    _cmbBI_BINF_CD.SelectedValue = _dt.Rows[0]["BI_BINF_CD"].ToString();
                    _txtBI_SAUP_NO.Text = _dt.Rows[0]["BI_SAUP_NO"].ToString().Trim();
                    _txtBI_BUBIN_NO.Text = _dt.Rows[0]["BI_BUBIN_NO"].ToString().Trim();
                    _txtBI_ZIP_NO.Text = _dt.Rows[0]["BI_ZIP_NO"].ToString().Trim();
                    _txtBI_ADDR_BSC.Text = _dt.Rows[0]["BI_ADDR_BSC"].ToString();
                    _txtBI_ADDR_DTL.Text = _dt.Rows[0]["BI_ADDR_DTL"].ToString();
                    _txtBI_UPTE.Text = _dt.Rows[0]["BI_UPTE"].ToString();
                    _txtBI_JONGMOK.Text = _dt.Rows[0]["BI_JONGMOK"].ToString();
                    _txtBI_EMAIL.Text = _dt.Rows[0]["BI_EMAIL"].ToString();
                }
            }
            catch (Exception err)
            {
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
                DialogResult res = MessageBox.Show("회사정보를 삭제하시면 해당 회사에 속한 모든 정보가 일괄적으로 삭제 됩니다,.\r\n\r\n계속 하시겠습니까?", "회사정보 삭제", MessageBoxButtons.YesNo);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    base.ExecuteNonQuery("PCSP_BAS0900_D1"
                        , _txtLNR_CD.Text
                        );

                    MessageBox.Show("회사정보를 삭제 하였습니다.");

                    // 부모창의 콤보박스 재 로드
                    base.MainForm.LoadCompany();

                    // 재 검색
                    Search();
                    ClearControls();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region 검색 버튼 자동으로 클릭
        /// <summary>
        /// 텍스트박스 엔터키 입력 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUSR_NM_S_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _btnSearch.PerformClick();

                // 비프소리 중지
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        #endregion

        #region grvBAS0900_CellDoubleClick : 그리드 더블 클릭 시, 상세 정보 보여줌
        /// <summary>
        /// 그리드 더블 클릭 시, 상세 정보 보여줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvBAS0900_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (collapsibleSplitter1.IsCollapsed)
            {
                collapsibleSplitter1.ToggleState();
            }
        }
        #endregion
    }
}
