using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.ACC
{
	/// <summary>
	/// 제  목: 정산마감처리중 프로그레스 화면
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-29 20:43
	/// 설  명: 
	/// </summary>
	public partial class ACC0110 : DemoClient.Controllers.BasePopupForm
	{
        public String SimFlag { get; set; }
        public List<string> GijunDate { get; set; }
		public List<string> StoreInfo { get; set; }
        public List<decimal> EXPAMT { get; set; }
        public List<decimal> TRAMT { get; set; }
        public List<decimal> MANAMT { get; set; }
        public List<string> AGT_CD { get; set; }
        
		#region ACC0110 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public ACC0110()
		{
			InitializeComponent();
		}
		#endregion

		#region ACC0110_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ACC0110_Shown(object sender, EventArgs e)
		{
			System.Threading.Thread.Sleep(1000);
			Application.DoEvents();
			
			CalMagam();
		}
		#endregion

		#region CalMagam : 마감처리
		/// <summary>
		/// 마감처리
		/// </summary>
		void CalMagam()
		{
			try
			{
				_pgBar.Maximum	= StoreInfo.Count;

                #region property(정산)

                int acc0100_idx = 0;                    // 일련번호(정산)
                decimal acc0100_loanamt = 0m;           // 대출원금
                decimal acc0100_accountfee = 0m;        // 정산수수료
                decimal acc0100_intst = 0m;             // 대출이자
                decimal acc0100_ortnamt = 0m;           // 원상환액(여신사)
                int acc0100_sendfeecnt = 0;             // 발생송금수수료건수
                decimal acc0100_sendfee = 0m;           // 발생송금수수료
                decimal acc0100_rtnloanamt = 0m;        // 대출원금정산금액
                decimal acc0100_nonloanamt = 0m;        // 대출원금미정산액 
                decimal acc0100_rtnaccountfee = 0m;     // 정산수수료정산금액
                decimal acc0100_rtnintst = 0m;          // 대출이자정산금액
                decimal acc0100_nonaccountfee = 0m;     // 정산수수료미정산액
                decimal acc0100_nonintst = 0m;          // 대출이자미정산액
                decimal acc0100_pyovramt = 0m;          // 즉시결제정산후과입금액
                decimal acc0100_pynonamt = 0m;          // 즉시결제정산후미입금액
                decimal acc0100_rrtnamt = 0m;           // 실상환액(여신사)
                decimal acc0100_bzamt = 0m;             // 비즈론차감가능액
                decimal acc0100_bzdlyintst = 0m;        // 정산전비즈론연체이자합계
                decimal acc0100_bzintst = 0m;           // 정산전비즈론상환이자합계
                decimal acc0100_bzloanamt = 0m;         // 정산전비즈론대출원금합계
                decimal acc0100_bzrtndlyinst = 0m;      // 비즈론연체이자정산액
                decimal acc0100_bzrtnintst = 0m;        // 비즈론상환이자정산액
                decimal acc0100_bzrtnloanamt = 0m;      // 비즈론대출원금정산액
                decimal acc0100_expddtamt = 0m;         // 차감상환처리이전대기금액
                decimal acc0100_ddtamt = 0m;            // 정산전차감예정금액
                decimal acc0100_rtnddtamt = 0m;         // 차감상환액
                decimal acc0100_expdpstamt = 0m;        // 보증금처리이전대기금액
                decimal acc0100_dpstamt = 0m;           // 정산전보증금예정금액
                decimal acc0100_rtndpstamt = 0m;        // 보증금상환액
                decimal acc0100_finovrfee = 0m;         // 최종과입금액
                decimal acc0100_finnonamt = 0m;         // 차감으로등록할대출원금

                #endregion

                #region property(금일출금대상정보)

                int p_idx = 0;                  // 출금원장 일련번호
                decimal p_appramt = 0m;          // 승인금액
                decimal p_cnclamt = 0m;          // 취소금액
                decimal p_buying_fee = 0m;       // 카드수수료
                decimal p_lnamt = 0m;            // 대출원금(대상)
                decimal p_accountfee = 0m;       // 정산수수료(대상)
                decimal p_lnintst = 0m;          // 대출이자(대상)
                decimal p_sub_total = 0m;        // 입금예정금액(소계) = 승인금액 - 카드수수료

                #endregion
                
                #region property(출금정보)

                decimal v_tramt = 0m;            // 입금금액
                decimal n_tramt = 0m;            // 미정산금액
                decimal tmpamt = 0m;             // 임시금액(계산)

                decimal v_appramt = 0m;          // 승인금액
				decimal v_cnclamt = 0m;          // 승인금액
                decimal v_buying_fee = 0m;       // 카드수수료
                decimal v_sub_total = 0m;        // 입금예정금액(소계) = 승인금액 - 카드수수료
                decimal v_lnamt = 0m;            // 대출원금(대상)
                decimal v_accountfee = 0m;       // 정산수수료(대상)
                decimal v_lnintst = 0m;          // 대출이자(대상)

                decimal sendfee = 0m;            // 송금수수료

                #endregion

                #region property(차감정보)

                int v_mns_idx = 0;              // 차감일련번호

                decimal v_mnsamt = 0m;          // 차감등록금액
                decimal v_mns_actn_amt = 0m;    // 차감처리된금액

                decimal v_ddtamt = 0m;          // 차감정산대상금액
                decimal r_ddtamt = 0m;          // 차감상환액
                decimal n_ddtamt = 0m;          // 차감미상환액

                decimal v_balamt = 0m;          // 차감잔액

                #endregion

                #region property(비즈론정보)

                int v_idx = 0;                  // 비즈론 대출번호
                int v_lnmnt = 0;                // 비즈론 대출일수
                int v_rpyseq = 0;               // 비즈론 상환회차
                
                decimal v_bzprcp = 0m;          // 비즈론상환원금(스케쥴)
                decimal v_bzintst = 0m;         // 비즈론상환이자(스케쥴)
                
                decimal v_bzn_prcp = 0m;          // 비즈론미상환원금(스케쥴)
                decimal v_bzn_intst = 0m;         // 비즈론미상환이자(스케쥴)
                decimal v_bzn_dlyintst = 0m;      // 비즈론미상환연체이자(스케쥴)

                decimal r_bzprcp = 0m;          // 비즈론상환원금
                decimal r_bzintst = 0m;         // 비즈론상환이자
                decimal r_bzdlyintst = 0m;      // 비즈론상환연체이자
                decimal r_bztotamt = 0m;        // 비즈론상환금액합계

                string v_ddttypeyn = null;      // 대체차감코드

                #endregion

                decimal v_manamt = 0m;          // 강제출금액

                #region property(보증예치금정보)

                int v_dpst_idx = 0;              // 차감일련번호

                decimal v_exp_dpst_amt = 0m;          // 차감등록금액
                decimal v_dpst_actn_amt = 0m;    // 차감처리된금액

                decimal v_dpstamt = 0m;          // 차감정산대상금액
                decimal r_dpstamt = 0m;          // 차감상환액
                decimal n_dpstamt = 0m;          // 차감미상환액

                #endregion
                
                base.BeginTransaction();

				for (int i = 0; i < StoreInfo.Count; i++)
				{
					_pgBar.Value		= i + 1;

					string[] strinfo		= StoreInfo[i].Split('^');
                    _lblStatus.Text = string.Format("[{0}/{1}] {2}({3})", i + 1, StoreInfo.Count, strinfo[1], strinfo[0]);

                    
                    // 일련번호 채번
                    DataSet _ds0 = base.GetDataSet("PCSP_ACC0110_R0"
                        , "SELECT NEXT VALUE FOR SEQ_ACC0100_IDX"
                    );

                    acc0100_idx = Convert.ToInt32(_ds0.Tables[0].Rows[0][0]);


                    // 정산 자료 입력
                    base.ExecuteNonQuery("PCSP_ACC0110_C1"
                        , acc0100_idx                                                       // 일련번호
                        , this.GijunDate[0]                                                 // 정산일자
                        , strinfo[0]                                                        // 가맹점 코드
                        , this.AGT_CD[i]                                                    // 대리점 코드
                        , this.EXPAMT[i]                                                    // 입금예정금액
                        , this.TRAMT[i]                                                     // 실입금액
                        , this.MANAMT[i]                                                    // 강제출금액
                        , base.GetCookie("USRID")                                           // 시스템등록자ID
                        , base.GetCookie("USRNM")                                           // 시스템등록자명
                        );

                    // 한도반영
                    base.ExecuteNonQuery("PCSP_ACC0110_U12"
                        , strinfo[0]                                                        // 가맹점 코드
                        , this.TRAMT[i]                                                     // 실입금액
                        );

					string _strP = "PCSP_ACC0110_R5";

                    // 금일 출금 대상 정보 조회
					DataTable _dt5 = base.GetDataTable(_strP
                        , this.GijunDate[0]
                        , strinfo[0]
                    );
                    
                    v_tramt = (decimal)this.TRAMT[i];                                                       // 입금금액
                    v_manamt = (decimal)this.MANAMT[i];                                                     // 강제출금액

                    p_sub_total = 0m;

                    if (_dt5.Rows.Count > 0)
                    {
                        for (int p_int = 0; p_int < _dt5.Rows.Count; p_int++)
                        {
                            p_idx = Convert.ToInt32(_dt5.Rows[p_int]["IDX"].ToString());                                // 출금원장일련번호
                            p_appramt = Convert.ToDecimal(_dt5.Rows[p_int]["TAPPRAMT"].ToString());                       // 출금대기승인금액
                            p_cnclamt = Convert.ToDecimal(_dt5.Rows[p_int]["TCNCLAMT"].ToString());                       // 출금대기취소금액
                            p_buying_fee = Convert.ToDecimal(_dt5.Rows[p_int]["TBUYING_FEE"].ToString());                 // 출금대기카드수수료
                            p_lnamt = Convert.ToDecimal(_dt5.Rows[p_int]["TLNAMT"].ToString());                           // 출금대기대출원금
                            p_accountfee = Convert.ToDecimal(_dt5.Rows[p_int]["TACCOUNT_FEE"].ToString());                 // 출금대기대출원금
                            p_lnintst = Convert.ToDecimal(_dt5.Rows[p_int]["TLNINTST"].ToString());                       // 출금대기대출이자

                            p_sub_total += p_lnamt;                                                                      // 출금대기대출원금합계

                            // 정산 자료 변경
                            base.ExecuteNonQuery("PCSP_ACC0110_U11"
                                , p_idx                         // 출금원장일련번호
                                , p_appramt                     // 출금대기승인금액
                                , p_cnclamt                     // 출금대기취소금액
                                , p_buying_fee                  // 출금대기카드수수료
                                , p_lnamt                       // 출금대기대출원금
                                , p_accountfee                  // 출금대기정산수수료
                                , p_lnintst                     // 출금대기대출이자
                                , acc0100_idx                   // 정산일련번호
                                );


                        }
                    }

                    v_tramt = p_sub_total + v_manamt + v_tramt;                                             // 최종처리대상금액

                    // 정산 대상 정보 조회

                    DataSet _ds = base.GetDataSet("PCSP_ACC0110_R1"
                        , this.GijunDate[0]
                        , strinfo[0]
                    );

                    if(_ds.Tables[0].Rows.Count > 0)
                    { 

                        //v_tramt = (decimal)this.TRAMT[i];                                                       // 입금금액
                        //v_manamt = (decimal)this.MANAMT[i];                                                     // 강제출금액

                        //v_tramt = p_sub_total + v_manamt + v_tramt;                                             // 최종처리대상금액

						v_appramt = Convert.ToDecimal(_ds.Tables[0].Rows[0]["APPRAMT"].ToString());             // 승인금액
						v_cnclamt = Convert.ToDecimal(_ds.Tables[0].Rows[0]["CNCLAMT"].ToString());				//취소금액
						v_buying_fee = Convert.ToDecimal(_ds.Tables[0].Rows[0]["BUYING_FEE"].ToString());       // 카드수수료
						v_sub_total = Convert.ToDecimal(_ds.Tables[0].Rows[0]["SUB_TOTAL"].ToString());         // 입금예정금액(소계) = 승인금액 - 카드수수료
						v_lnamt = Convert.ToDecimal(_ds.Tables[0].Rows[0]["LNAMT"].ToString());                 // 대출원금
						v_accountfee = Convert.ToDecimal(_ds.Tables[0].Rows[0]["ACCOUNT_FEE"].ToString());      // 정산수수료
						v_lnintst = Convert.ToDecimal(_ds.Tables[0].Rows[0]["LNINTST"].ToString());             // 대출이자

						acc0100_loanamt = v_lnamt;
						acc0100_accountfee = v_accountfee;
						acc0100_intst = v_lnintst;
						acc0100_ortnamt = v_lnamt + v_lnintst;

						// 출금(승인) 정산
						#region 출금(승인) 정산 처리

						// 정산수수료
						tmpamt = v_tramt - v_accountfee;

						if (tmpamt >= 0m)
						{
							acc0100_rtnaccountfee = v_accountfee;
							acc0100_nonaccountfee = 0m;
							v_tramt = tmpamt;
						}
						else
						{
							acc0100_rtnaccountfee = v_tramt;
							acc0100_nonaccountfee = Math.Abs(tmpamt);
							v_tramt = 0m;
							n_tramt += Math.Abs(tmpamt);
						}


						// 여신사이자정산
						tmpamt = v_tramt - v_lnintst;

						if (tmpamt >= 0m)
						{
							acc0100_rtnintst = v_lnintst;
							acc0100_nonintst = 0m;
							v_tramt = tmpamt;
						}
						else
						{
							acc0100_rtnintst = v_tramt;
							acc0100_nonintst = Math.Abs(tmpamt);
							v_tramt = 0m;
							n_tramt += Math.Abs(tmpamt);
						}

						// 여신사원금정산
						tmpamt = v_tramt - v_lnamt;
						if (tmpamt >= 0m)
						{
							acc0100_rtnloanamt = v_lnamt;
							acc0100_nonloanamt = 0m;
							v_tramt = tmpamt;
						}
						else
						{
							acc0100_rtnloanamt = v_tramt;
							acc0100_nonloanamt = Math.Abs(tmpamt);
							v_tramt = 0m;
							n_tramt += Math.Abs(tmpamt);
						}

						acc0100_pyovramt = v_tramt > 0m ? v_tramt : 0m;	    // 즉결정산 후 과입금
						acc0100_pynonamt = n_tramt > 0m ? n_tramt : 0m;	    // 즉결정산 후 미입금


						acc0100_rrtnamt = acc0100_rtnloanamt + acc0100_rtnaccountfee + acc0100_rtnintst - sendfee;	// 여신사로 실상환액

						// 송금수수료
						if (sendfee > 0m)
						{
							// 차감 자료에 등록
						}

						// 정산 자료 변경
						base.ExecuteNonQuery("PCSP_ACC0110_U1"
							, acc0100_loanamt                       // 대출원금
							, acc0100_intst                         // 대출이자
							, acc0100_accountfee                    // 정산수수료
							, acc0100_ortnamt                       // 원상환액(여신사)
							, acc0100_rtnloanamt                    // 대출원금정산금액
							, acc0100_nonloanamt                    // 대출원금미정산액
							, acc0100_rtnaccountfee                 // 정산수수료정산금액
							, acc0100_nonaccountfee                 // 정산수수료미정산액
							, acc0100_rtnintst                      // 대출이자정산금액
							, acc0100_nonintst                      // 대출이자미정산액
							, acc0100_pyovramt                      // 즉시결제정산후과입금액
							, acc0100_pynonamt                      // 즉시결제정산후미입금액
							, acc0100_rrtnamt                       // 실상환액(여신사)
							, acc0100_idx                           // 일련번호
							);
                        

                        #endregion
                    }


                    var finYn = "N";

                    // 차감 정산
                    #region 차감 정산 처리
                    
                    DataTable _dtBAS0830 = base.GetDataTable("PCSP_ACC0110_R2"
                                            , this.GijunDate[0]
                                            , strinfo[0]
											, v_appramt + v_cnclamt
                                            , (v_appramt - v_buying_fee)
                                            );
                    
                    acc0100_expddtamt	= v_tramt;

					tmpamt				= 0m;
					acc0100_ddtamt      = 0m;          // 대출이자
                    acc0100_rtnddtamt   = 0m;          // 원상환액(여신사)

					if (_dtBAS0830.Rows.Count > 0)
                    {
                        for (var ddt = 0; ddt < _dtBAS0830.Rows.Count; ddt++)
                        {
                            if(v_tramt <= 0m)
                            {
                                break;
                            }

                            v_mns_idx = Convert.ToInt32(_dtBAS0830.Rows[ddt]["IDX"].ToString());                         // 차감일련번호
							v_mnsamt = Convert.ToDecimal(_dtBAS0830.Rows[ddt]["MNS_AMT"].ToString());                    // 차감등록금액
							v_mns_actn_amt = Convert.ToDecimal(_dtBAS0830.Rows[ddt]["MNS_ACTN_AMT"].ToString());         // 차감처리된금액
							v_ddtamt = Convert.ToDecimal(_dtBAS0830.Rows[ddt]["TOTAL_MNS_AMT"].ToString());              // 차감대상금액계산(정액/정률)
                            
                            acc0100_ddtamt += v_ddtamt;

                            tmpamt = v_tramt - v_ddtamt;

                            if (tmpamt > 0m)
                            {
                                r_ddtamt = v_ddtamt;
                                v_ddtamt = tmpamt;
								v_tramt = tmpamt;
                            }
                            else
                            {
                                r_ddtamt = v_tramt;
                                v_ddtamt = 0m;
								v_tramt = 0m;
                            }

                            // 차감잔액 계산
                            v_balamt = v_ddtamt - r_ddtamt;

                            if(v_balamt < 0m)
                            {
                                v_balamt = 0m;
                            }

                            // 대상 차감 완료여부를 재설정합니다.
                            n_ddtamt = v_mnsamt - v_mns_actn_amt - r_ddtamt;
                            //n_ddtamt = v_ddtamt;
                            finYn = n_ddtamt <= 0m ? "Y" : "N";
                            
                            // 차감자료 입력 
                            base.ExecuteNonQuery("PCSP_ACC0110_C2"
                                , v_mns_idx                 // 정산일자
                                , acc0100_idx			    // 출금정산일련번호
                                , GijunDate[0]			    // 실행일자
                                , r_ddtamt  			    // 실행금액
                                , v_balamt                  // 차감잔액
                                , base.GetCookie("USRID")   // 시스템등록자ID
                                , base.GetCookie("USRNM")   // 시스템등록자명
                                , finYn
                                );

                            acc0100_rtnddtamt += r_ddtamt;

                        }
                        
                    }

                    // 정산 자료 변경
                    base.ExecuteNonQuery("PCSP_ACC0110_U2"
                        , acc0100_expddtamt             // 대출원금
                        , acc0100_ddtamt                // 대출이자
                        , acc0100_rtnddtamt             // 원상환액(여신사)
                        , acc0100_idx                   // 일련번호
                        );
                    
                    #endregion

                    // 비즈론 정산
                    #region 비즈론 정산처리
                    
                    tmpamt = 0m;
                    acc0100_bzamt = v_tramt;

                    DataSet _ds2 = base.GetDataSet("PCSP_ACC0110_R3"
                                            , this.GijunDate[0]
                                            , strinfo[0]
                                        );

					acc0100_bzamt = 0m;
					acc0100_bzdlyintst = 0m;
					acc0100_bzintst = 0m;
					acc0100_bzloanamt = 0m;
					acc0100_bzrtndlyinst = 0m;
					acc0100_bzrtnintst = 0m;
					acc0100_bzrtnloanamt = 0m;

                    if (_ds2.Tables[0].Rows.Count > 0)
                    {
                        for (var biz = 0; biz < _ds2.Tables[0].Rows.Count; biz++)
                        {
							v_bzn_prcp = Convert.ToDecimal(_ds2.Tables[0].Rows[biz]["NONPRCP"]);
							v_bzn_intst = Convert.ToDecimal(_ds2.Tables[0].Rows[biz]["NONINTST"]);
							v_bzn_dlyintst = Convert.ToDecimal(_ds2.Tables[0].Rows[biz]["CDLYINTST"]);

							acc0100_bzdlyintst += v_bzn_dlyintst;    // 정산전비즈론연체이자합계
							acc0100_bzintst += v_bzn_intst;          // 정산전비즈론상환이자합계
							acc0100_bzloanamt += v_bzn_prcp;         // 정산전비즈론대출원금합계

                            if (v_tramt <= 0m)
                            {
                                continue;
                            }

                            v_idx = Convert.ToInt32(_ds2.Tables[0].Rows[biz]["IDX"]);
                            v_lnmnt = Convert.ToInt32(_ds2.Tables[0].Rows[biz]["LNMNT"]);
                            v_rpyseq = Convert.ToInt32(_ds2.Tables[0].Rows[biz]["RPYSEQ"]);

                            

                            v_bzprcp = Convert.ToDecimal(_ds2.Tables[0].Rows[biz]["RTNPRCP"]);
                            v_bzintst = Convert.ToDecimal(_ds2.Tables[0].Rows[biz]["RTNINTST"]);

                            v_ddttypeyn = _ds2.Tables[0].Rows[biz]["DDTTYPEYN"].ToString();

                            

                            // 연체이자 상환
                            tmpamt = v_tramt - v_bzn_dlyintst;
                            if (tmpamt >= 0m)
                            {
                                r_bzdlyintst = v_bzn_dlyintst;
                                v_bzn_dlyintst = 0m;
                                v_tramt = tmpamt;
                            }
                            else
                            {
                                r_bzdlyintst = v_tramt;
                                v_bzn_dlyintst = Math.Abs(tmpamt);
                                v_tramt = 0m;
                            }

                            // 이자 상환
                            tmpamt = v_tramt - v_bzn_intst;
                            if (tmpamt >= 0m)
                            {
                                r_bzintst = v_bzn_intst;
                                v_bzn_intst = 0m;
                                v_bzintst = v_bzintst + r_bzintst;
                                v_tramt = tmpamt;
                            }
                            else
                            {
                                r_bzintst = v_tramt;
                                v_bzn_intst = Math.Abs(tmpamt);
                                v_bzintst = v_bzintst + r_bzintst;
                                v_tramt = 0m;
                            }

                            // 원금 상환
                            tmpamt = v_tramt - v_bzn_prcp;

                            if (tmpamt >= 0m)
                            {
                                r_bzprcp = v_bzn_prcp;
                                v_bzn_prcp = 0m;
                                v_bzprcp = v_bzprcp + r_bzprcp;
                                v_tramt = tmpamt;
                            }
                            else
                            {
                                r_bzprcp = v_tramt;
                                v_bzn_prcp = Math.Abs(tmpamt);
                                v_bzprcp = v_bzprcp + r_bzprcp;
                                v_tramt = 0m;
                            }

                            r_bztotamt = r_bzprcp + r_bzintst + r_bzdlyintst;

                            //// 대상 비즈론 회차의 완료여부를 재설정합니다.
                            //drLOAN["RPYYN"] = v_bzn_prcp == 0m ? "Y" : "N";

                            // 정산 자료 입력할 금액
                            acc0100_bzrtndlyinst += r_bzdlyintst;
                            acc0100_bzrtnintst += r_bzintst;
                            acc0100_bzrtnloanamt += r_bzprcp;

                            // 비즈론 상환 내역 입력
                            base.ExecuteNonQuery("PCSP_ACC0110_C3"
                                , v_idx                             // 대출원장 일련번호
                                , v_rpyseq                          // 상환번호
                                , GijunDate[0]                      // 상환일자
                                , r_bzprcp                          // 상환원금
                                , r_bzintst                         // 상환이자
                                , r_bzdlyintst                      // 상환연체이자
                                , r_bztotamt                        // 상환금액 합계
                                , acc0100_idx                       // 연관아이디(상환번호)
                                , strinfo[0]                        // 가맹점 코드
                                , AGT_CD[i]                         // 대리점 코드
                                , v_ddttypeyn                       // 대체차감 코드
                                , base.GetCookie("USRID")           // 시스템등록자ID
                                , base.GetCookie("USRNM")           // 시스템등록자명
                                );

                            // 비즈론 상환 계획표 변경
                            base.ExecuteNonQuery("PCSP_ACC0110_U3"
                                , v_bzprcp                          // 상환원금
                                , v_bzintst                         // 상환이자
                                , v_bzn_prcp                        // 미상환원금
                                , v_bzn_intst                       // 미상환이자
                                , v_bzn_dlyintst                    // 미상환연체이자
                                , v_bzn_prcp == 0m ? "Y" : "N"      // 상환완료여부
                                , v_idx                             // 대출원장 일련번호
                                , v_rpyseq                          // 상환번호
                                );

                            // 대출 상태 완료 체크
                            if (v_bzn_prcp == 0 && v_lnmnt.Equals(v_rpyseq))
                            {
                                base.ExecuteNonQuery("PCSP_ACC0110_U4"
                                , v_idx                             // 대출원장 일련번호
                                , base.GetCookie("USRID")           // 시스템수정자ID
                                , base.GetCookie("USRNM")           // 시스템수정자명
                                );
                            }
                        }


                        
                    }
					//else
					//{
					//	acc0100_bzamt = 0m;
					//	acc0100_bzdlyintst = 0m;
					//	acc0100_bzintst = 0m;
					//	acc0100_bzloanamt = 0m;
					//	acc0100_bzrtndlyinst = 0m;
					//	acc0100_bzrtnintst = 0m;
					//	acc0100_bzrtnloanamt = 0m;
					//}

                    // 정산 자료 변경(비즈론 입금 처리)
                    base.ExecuteNonQuery("PCSP_ACC0110_U10"
                        , acc0100_bzamt                 // 비즈론차감가능액
                        , acc0100_bzdlyintst            // 정산전비즈론연체이자합계
                        , acc0100_bzintst               // 정산전비즈론상환이자합계
                        , acc0100_bzloanamt             // 정산전비즈론대출원금합계
                        , acc0100_bzrtndlyinst          // 비즈론연체이자정산액
                        , acc0100_bzrtnintst            // 비즈론상환이자정산액
                        , acc0100_bzrtnloanamt          // 비즈론대출원금정산액
                        , acc0100_idx                   // 일련번호
                        );


                    if(v_tramt > 0m)
                    {
                        
                    }

                    #endregion

                    // 강제출금
                    #region 강제출금 처리

                    base.ExecuteNonQuery("PCSP_ACC0110_U5"
                        , GijunDate[0]                      // 검색기준일자
                        , strinfo[0]                        // 가맹점코드
                        , base.GetCookie("USRID")           // 시스템수정자ID
                        , base.GetCookie("USRNM")           // 시스템수정자명
                        );

                    #endregion

                    // 보증예치금
                    #region 보증예치금

                    DataSet _ds3 = base.GetDataSet("PCSP_ACC0110_R4"
                                           , this.GijunDate[0]
                                           , strinfo[0]
                                           , v_appramt
                                           , (v_appramt - v_buying_fee)
                                           );

                    acc0100_expdpstamt = 0m;
                    acc0100_expdpstamt += v_tramt;


					tmpamt = 0m;
					acc0100_dpstamt = 0m;          // 보증금대상금액
					acc0100_rtndpstamt = 0m;          // 보증금상환금액

                    if (_ds3.Tables[0].Rows.Count > 0)
                    {
                        acc0100_dpstamt = 0m;              // 보증금대상금액
                        acc0100_rtndpstamt = 0m;            // 보증금상환금액

                        for (var dpst = 0; dpst < _ds3.Tables[0].Rows.Count; dpst++)
                        {
                            if (v_tramt <= 0m)
                            {
                                break;
                            }

                            v_dpst_idx = Convert.ToInt32(_ds3.Tables[0].Rows[dpst]["IDX"].ToString());                         // 차감일련번호
                            v_dpstamt = Convert.ToDecimal(_ds3.Tables[0].Rows[dpst]["DPST_AMT"].ToString());                    // 보증금설정금액
                            v_dpst_actn_amt = Convert.ToDecimal(_ds3.Tables[0].Rows[dpst]["DPST_ACTN_AMT"].ToString());         // 보증금처리된금액
                            v_dpstamt = Convert.ToDecimal(_ds3.Tables[0].Rows[dpst]["TOTAL_DPST_AMT"].ToString());              // 보증금처리대상금액

                            acc0100_dpstamt += v_dpstamt;

                            // 연체이자 상환
                            tmpamt = v_tramt - v_ddtamt;

                            if (tmpamt > 0m)
                            {
                                r_dpstamt = v_dpstamt;
                                v_dpstamt = tmpamt;
                            }
                            else
                            {
                                r_dpstamt = v_dpstamt;
                                v_dpstamt = 0m;
                            }

                            // 대상 차감 완료여부를 재설정합니다.
                            n_dpstamt = v_dpstamt - v_dpst_actn_amt - r_dpstamt;
                            finYn = n_dpstamt == 0m ? "Y" : "N";
                            //drDDTN["STATE"] = "Z370004";
                            //drDDTN["STATENM"] = "완료";


                            // 보증예치금 입력 
                            base.ExecuteNonQuery("PCSP_ACC0110_C4"
                                , v_dpst_idx                 // 정산일자
                                , acc0100_idx               // 출금정산일련번호
                                , GijunDate[0]              // 실행일자
                                , r_dpstamt                 // 실행금액
                                , base.GetCookie("USRID")   // 시스템등록자ID
                                , base.GetCookie("USRNM")   // 시스템등록자명
                                , finYn
                                );

                            acc0100_rtndpstamt += r_dpstamt;

                        }
                        
                    }



                    // 정산 자료 변경
                    base.ExecuteNonQuery("PCSP_ACC0110_U6"
                            , acc0100_expdpstamt            // 보증금가능액
                            , acc0100_dpstamt               // 보증금대상금액
                            , acc0100_rtndpstamt            // 보증금상환금액
                            , acc0100_idx                   // 일련번호
                            );
                    #endregion

                    // 출금원장 변경
                    #region 출금원장 변경

                    base.ExecuteNonQuery("PCSP_ACC0110_U7"
                        , this.GijunDate[0]
                        , strinfo[0]
                        , acc0100_idx                   // 일련번호
                        , base.GetCookie("USRID")       // 시스템수정자ID
                        , base.GetCookie("USRNM")       // 시스템수정자명
                    );


                    #endregion

                    #region 정산자료 변경(과입금/미입금 처리)

                    acc0100_finovrfee = v_tramt - acc0100_rtndpstamt;
                    acc0100_finnonamt = n_tramt;

                    // 정산 자료 변경
                    base.ExecuteNonQuery("PCSP_ACC0110_U8"
                        , acc0100_finovrfee             // 과입금액
                        , acc0100_finnonamt             // 미입금액
                        , acc0100_idx                   // 일련번호
                        );

                    #endregion

                    #region 미입금에 대한 차감자료 등록 처리

                    if(n_tramt > 0m)
                    {
                        // 대출이자 및 원금 등록
                        if (acc0100_nonintst > 0m || acc0100_nonloanamt > 0m)
                        {
                            base.ExecuteNonQuery("PCSP_ACC0110_C5"
                                , this.GijunDate[0]
                                , strinfo[0]
								, acc0100_nonaccountfee         // 정산수수료미입금액
                                , acc0100_nonintst              // 대출이자미입금액
                                , acc0100_nonloanamt            // 대출원금미입금액
                                , base.GetCookie("USRID")       // 시스템응록자ID
                                , base.GetCookie("USRNM")       // 시스템등록자명
                                );
                        }

                    }

                    #endregion


                    // 입금내역 처리
                    #region 입금내역 처리

                    base.ExecuteNonQuery("PCSP_ACC0110_U9"
                                , this.GijunDate[0]
                                , strinfo[0]
                                , acc0100_idx
                                , base.GetCookie("USRID")       // 시스템응록자ID
                                , base.GetCookie("USRNM")       // 시스템등록자명
                                );


                    #endregion

                    System.Threading.Thread.Sleep(10);
					Application.DoEvents();
				}

                base.CommitTransaction();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
			}
			catch (Exception err)
			{
                base.RollbackTransaction();
				MessageBox.Show(err.Message);

                this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			}

		}
		#endregion
	}
}
