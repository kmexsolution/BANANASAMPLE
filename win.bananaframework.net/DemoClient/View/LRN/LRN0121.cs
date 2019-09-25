using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.LRN
{
	/// <summary>
	/// 제  목: 비즈론 상환계획표 생성 프로그레스 화면
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-29 20:43
	/// 설  명: 
	/// </summary>
	public partial class LRN0121 : DemoClient.Controllers.BasePopupForm
	{
		public string _IDX { get; set; }
        public string _STR_CD { get; set; }
        public List<string> _RPYSEQ { get; set; }
        public List<string> _RPYDT { get; set; }
        public List<string> _PRINCIPAL { get; set; }
        public List<string> _RPYAMT { get; set; }
        public List<string> _INTEREST { get; set; }
        public List<string> _LNMST { get; set; }

        //public List<string> StoreInfo { get; set; }

        #region LRN0121 : 생성자 함수
        /// <summary>
		/// 생성자 함수
		/// </summary>
        public LRN0121()
		{
			InitializeComponent();
		}
		#endregion

        #region LRN0121_Shown : 폼 보이기 이벤트
        /// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void LRN0121_Shown(object sender, EventArgs e)
		{
			System.Threading.Thread.Sleep(1000);
			Application.DoEvents();
			
			BizLoanRegister();
		}
		#endregion

        #region BizLoanRegister : 비즈론 원장 등록 및 상환 계획표 등록 처리
        /// <summary>
        /// 비즈론 원장 등록 및 상환 계획표 등록 처리
		/// </summary>
		void BizLoanRegister()
		{
			try
			{
                _pgBar.Maximum = _RPYSEQ.Count;

                decimal sumINTREST = 0m;

                for (int i = 0; i < _RPYSEQ.Count; i++)
                {
                    _pgBar.Value = i + 1;

                    //string[] temp = _RPYSEQ[i].Split('^');
                    _lblStatus.Text = string.Format("[{0}/{1}]", i + 1, _RPYSEQ.Count);

                    base.ExecuteNonQuery("PCSP_LRN0121_C1"
                        , this._IDX
                        , this._RPYSEQ[i]
                        , this._RPYDT[i]
                        , this._PRINCIPAL[i]
                        , this._RPYAMT[i]
                        , this._INTEREST[i]
                        , this._STR_CD
                        );

                    sumINTREST += Convert.ToDecimal(_INTEREST[i]);

                    if(i == _RPYSEQ.Count - 1)
                    {
                        // 대출원장 변경
                        base.ExecuteNonQuery("PCSP_LRN0121_U1"
                        , this._IDX
                        , this._RPYDT[i]                    // 상환종료일자
                        , this._RPYAMT[0]                // 일상환금액
                        , sumINTREST                            // 총상환이자
                        , base.GetCookie("USRID")				// 심사자ID, 시스템수정자ID
                        , base.GetCookie("USRNM")				// 심사자명, 시스템수정자명
                        );
                    }

                    System.Threading.Thread.Sleep(10);
                    Application.DoEvents();
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
	}
}
