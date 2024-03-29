﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
    public partial class BAS0703 : DemoClient.Controllers.BasePopupForm
    {
        public int IDX { get; set; }
        public string AGT_CD { get; set; }

        #region BAS0703 : 생성자 함수
        /// <summary>
        /// 생성자 함수
        /// </summary>
        public BAS0703()
        {
            InitializeComponent();
        }
        #endregion

        #region BAS0703_Shown : 폼 보이기 이벤트
        /// <summary>
        /// 폼 보이기 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BAS0703_Shown(object sender, EventArgs e)
        {
            try
            {
                // 등록
                if (this.IDX == 0)
                {
					_dtpCALL_DT_STRT.Value = System.DateTime.Now;
                    timer1.Enabled = true;
                }
                // 수정
                else
                {
                    DataTable _dt = base.GetDataTable("PCSP_BAS0700_R6"
                        , this.IDX
                        );

                    _dtpCALL_DT_STRT.Value = (DateTime)_dt.Rows[0]["CALL_DT_STRT"];
                    _dtpCALL_DT_END.Value = (DateTime)_dt.Rows[0]["CALL_DT_END"];
                    _txtCALL_NM.Text = _dt.Rows[0]["CALL_NM"].ToString();
                    _txtMEMO.Text = _dt.Rows[0]["MEMO"].ToString();
                }

                _txtCALL_NM.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region timer1_Tick : 종료시각 업데이트
        /// <summary>
        /// 종료시각 업데이트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            _dtpCALL_DT_END.Value = System.DateTime.Now;
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
                timer1.Enabled = false;

                // 등록
                if (this.IDX == 0)
                {
                    base.ExecuteNonQuery("PCSP_BAS0703_C1"
                        , this.AGT_CD												// 대리점코드
                        , _txtCALL_NM.Text											// 통화상대명
                        , _dtpCALL_DT_STRT.Value.ToString("yyyy-MM-dd HH:mm:ss")	// 통화시작시각
                        , _dtpCALL_DT_END.Value.ToString("yyyy-MM-dd HH:mm:ss")		// 통화종료시각
                        , _txtMEMO.Text												// 메모
                        , ""														// 비고
                        , base.GetCookie("USRID")									// 시스템수정자ID
                        , base.GetCookie("USRNM")									// 시스템수정자명
                        );
                }
                // 수정
                else
                {
                    base.ExecuteNonQuery("PCSP_BAS0703_U1"
                        , this.IDX													// 일련번호
                        , _txtCALL_NM.Text											// 통화상대명
                        , _dtpCALL_DT_STRT.Value.ToString("yyyy-MM-dd HH:mm:ss")	// 통화시작시각
                        , _dtpCALL_DT_END.Value.ToString("yyyy-MM-dd HH:mm:ss")		// 통화종료시각
                        , _txtMEMO.Text												// 메모
                        , ""														// 비고
                        , base.GetCookie("USRID")									// 시스템수정자ID
                        , base.GetCookie("USRNM")									// 시스템수정자명
                        );
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region _btnClose_Click : 닫기 버튼 클릭 이벤트
        /// <summary>
        /// 닫기 버튼 클릭 이벤트
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
