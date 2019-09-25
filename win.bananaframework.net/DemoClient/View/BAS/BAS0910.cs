using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
    /// <summary>
    /// 제  목: 여신사정보등록
    /// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
    /// 작성일: 2014-08-05 21:22
    /// 설  명: 여신사정보를 신규로 등록하는 화면입니다.
    /// </summary>
    public partial class BAS0910 : DemoClient.Controllers.BasePopupForm
    {
        #region BAS0910 : 생성자 함수
        /// <summary>
        /// 생성자 함수
        /// </summary>
        public BAS0910()
        {
            InitializeComponent();
        }
        #endregion

        #region BAS110_Load : 폼 로드 이벤트
        /// <summary>
        /// 폼 로드 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BAS0910_Load(object sender, EventArgs e)
        {
            try
            {
                // 사업자구분
                DataTable _dt = base.GetDataTable("CHP_AJAX_CODEHELPER"
                    , "Common"
                    , "A01"
                    , ""
                    , ""
                    , ""
                    , ""
                    );
                base.SetListItem(_cmbBI_BINF_CD
                    , _dt
                    , "TOTAL_CODE"
                    , "CODE_NAME"
                    );
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                this.Close();
            }

        }
        #endregion

        #region BAS0910_Shown : 폼 보이기 이벤트
        /// <summary>
        /// 폼 보이기 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BAS0910_Shown(object sender, EventArgs e)
        {
            _txtLNR_NM.Focus();
        }
        #endregion

        #region _chkAuto_CheckedChanged : 자동채번 체크 이벤트
        /// <summary>
        /// 자동채번 체크 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (_chkAuto.Checked)
            {
                _txtLNR_CD.ReadOnly = true;
            }
            else
            {
                _txtLNR_CD.ReadOnly = false;
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

        #region _btnSave_Click : 저장 버튼 이벤트
        /// <summary>
        /// 저장 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 사업자등록번호
                string bizno = string.Empty;
                if (!base.ValidateFormat(_txtBI_SAUP_NO, "{0:###-##-#####}", out bizno))
                    return;

                // 법인등록번호
                string bubinno = string.Empty;
                if (!base.ValidateFormat(_txtBI_BUBIN_NO, "{0:######-#######}", out bubinno))
                    return;

				//// 우편번호 01
				//string zipno_01 = string.Empty;
				//if (!base.ValidateFormat(_txtZIP_NO, "{0:###-###}", out zipno_01))
				//	return;

				//// 우편번호 02
				//string zipno_02 = string.Empty;
				//if (!base.ValidateFormat(_txtBI_ZIP_NO, "{0:###-###}", out zipno_02))
				//	return;

                base.ExecuteNonQuery("PCSP_BAS0910_C1"
                    , _chkAuto.Checked ? "AUTO" : _txtLNR_CD.Text	    // 여신사코드
                    , _txtLNR_NM.Text								    // 여신사명
                    , _txtPRSNT_NM.Text									// 대표자명
					, _txtZIP_NO.Text									// 우편번호
                    , _txtADDR_BSC.Text									// 기본주소
                    , _txtADDR_DTL.Text									// 상세주소
                    , _txtTELNO.Text									// 전화번호
                    , _txtFAXNO.Text									// 팩스번호
                    , _txtBI_COMPANY_NM.Text							// 법인명(단체명)
                    , _txtBI_PRSNT_NM.Text								// 대표자명
                    , _cmbBI_BINF_CD.SelectedValue						// 사업자구분
                    , bizno												// 사업자등록번호
                    , bubinno											// 법인등록번호
					, _txtBI_ZIP_NO.Text								// 우편번호
                    , _txtBI_ADDR_BSC.Text								// 기본주소
                    , _txtBI_ADDR_DTL.Text								// 상세주소
                    , _txtBI_UPTE.Text									// 업태
                    , _txtBI_JONGMOK.Text								// 종목
                    , _txtBI_EMAIL.Text									// 세금계산서 이메일
                    , _txtMEMO.Text										// 메모
                    , ""												// 비고
                    , base.GetCookie("USRID")							// 시스템등록자ID
                    , base.GetCookie("USRNM")							// 시스템등록자명
                    );

                MessageBox.Show("신규 여신사를 등록하였습니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region _btnClose_Click : 닫기 버튼 이벤트
        /// <summary>
        /// 닫기 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
