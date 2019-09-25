using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.ACC
{
	/// <summary>
	/// 제  목: 정산마감처리
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-07-29 20:43
	/// 설  명: 정산마감을 처리하는 화면입니다.
	/// </summary>
	public partial class ACC0100 : DemoClient.Controllers.BaseForm, Controllers.IBaseForm
	{
		// 검색 쓰레드
		private Thread _thread;

		#region ACC0100 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public ACC0100()
		{
			InitializeComponent();
		}
		#endregion

		#region ACC0100_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ACC0100_Load(object sender, EventArgs e)
		{
			try
			{
				_dtpTRADEDATE_S_S.Value     = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00");
				_dtpTRADEDATE_E_S.Value		= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59");
				
				gridView1.ReadOnly			= false;
				
				// 전체 그리드 ReadOnly 속성값 부여
				// 2016-12-01 한인수 수정
				// GridView.cs에서 하고 싶었으나 각 화면의 속성값을 최종적으로 가져가게 되어 화면단에서 처리
				foreach (DataGridViewColumn colum in gridView1.Columns)
				{
					colum.ReadOnly = true;

					// 체크박스는 따로 속성에서 빼준다.
					if (colum.GetType() == typeof(DataGridViewCheckBoxColumn))
					{
						colum.ReadOnly = false;
					}
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region ClearControls : 컨트롤 초기화
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		public void ClearControls()
		{
		}
		#endregion

		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls1(bool _bTrue)
		{
			_txtSTR_NM_S.ReadOnly		= !_bTrue;
			_txtSTR_CD_S.ReadOnly		= !_bTrue;
			_dtpTRADEDATE_S_S.Enabled	= _bTrue;
			_dtpTRADEDATE_E_S.Enabled	= _bTrue;
			_btnSearch.Enabled			= _bTrue;
			_btnExcel.Enabled			= _bTrue;
		}
		#endregion

		#region EnableControls2 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		public void EnableControls2(bool _bTrue)
		{
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
				int res		= Search();
				string message	= string.Format("{0:N0}건이 검색되었습니다.", res);

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
			int _retValue	= -1;

			string _strP	= "PCSP_ACC0100_R1";

			try
			{
				DataSet _ds = base.GetDataSet(_strP
					, base.GetCookie("COMPANY_CD")
					, _txtSTR_NM_S.Text
					, _txtSTR_CD_S.Text
					, _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					);
				gridView1.DataSource	= _ds.Tables[0];

				// 승인
				_txtAPPRAMT.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["APPRAMT"].ToString());

				// 취소
				_txtCNCLAMT.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["CNCLAMT"].ToString());

				// 매입카드수수료
				_txtBUYING_FEE.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["BUYING_FEE"].ToString());

				// 합계
				_txtSUB_TOTAL.Text		= string.Format("{0}", _ds.Tables[1].Rows[0]["SUB_TOTAL"].ToString());

				_retValue				= _ds.Tables[0].Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion

		#region gridView1_DataBindingComplete : 선택불가 Row에 대한 처리
		/// <summary>
		/// 선택불가 Row에 대한 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
            // 입금금액차이(입금금액 - 입금예정금액)
            var diffRows = gridView1.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToDecimal(row.Cells["TRAMTDIFF"].Value.ToString()) != 0)
                .Select(row => row);
            foreach (DataGridViewRow row in diffRows)
            {
                row.Cells["TRAMTDIFF"].Style = new DataGridViewCellStyle() { ForeColor = Color.Red };
            }
        }
		#endregion

		#region _btnCheckAll_Click : 전체체크 버튼 클릭 이벤트
		/// <summary>
		/// 전체체크 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnCheckAll_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in gridView1.Rows)
			{
				gridView1.Rows[row.Index].Cells["CHK"].Value	= "Y";
			}
		}
		#endregion

		#region _btnUnCheckAll_Click : 전체해제 버튼 클릭 이벤트
		/// <summary>
		/// 전체해제 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnUnCheckAll_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in gridView1.Rows)
			{
				gridView1.Rows[row.Index].Cells["CHK"].Value	= "N";
			}
		}
		#endregion

		#region _btnExcel_Click : 엑셀 버튼 클릭 이벤트
		/// <summary>
		/// 엑셀 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				Dictionary<string, string> _dic = new Dictionary<string, string>();
				_dic.Add("A", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("B", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("C", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("D", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("E", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("F", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("G", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("H", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("I", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("J", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("K", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("L", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("Q", "yyyy-MM-dd HH:mm:ss");
				//_dic.Add("S", "yyyy-MM-dd HH:mm:ss");

				//_dic.Add("I", "@");
				//_dic.Add("N", "@");

				//_dic.Add("A", "#,###");
				//_dic.Add("H", "#,###");
				//_dic.Add("M", "#,###");
				gridView1.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				BANANA.Windows.Logger.Error(err);
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnCalMagam_Click : 정산마감처리 버튼 클릭 이벤트
		/// <summary>
		/// 정산마감처리 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnCalMagam_Click(object sender, EventArgs e)
		{
            var simflag = "N";
            
            try
            {
                EnableControls1(false);

                string sdate = null;
                string edate = null;

                sdate = _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd");
                edate = _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd");

                int norun = 0;

                List<string> _str_cd = new List<string>();
                List<string> _gijun_dt = new List<string>();
                List<decimal> _expamt = new List<decimal>();
                List<decimal> _tramt = new List<decimal>();
                List<decimal> _manamt = new List<decimal>();
                List<string> _agt_cd = new List<string>();

                // 선택된 행
                var selRows = gridView1.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells["CHK"].Value.ToString().Trim().Equals("Y") &&
                                    (row.Cells["MAGAM_YN"].Value.ToString().IndexOf("N") > 0))
                    .Select(row => row);
                foreach (DataGridViewRow row in selRows)
                {
                    // 가맹점명 & 코드
                    _str_cd.Add(row.Cells["STR_CD"].Value.ToString().Trim() + "^" + row.Cells["STR_NM"].Value.ToString().Trim());

                    // 입금일자
                    string[] temp = row.Cells["DUEDATE"].Value.ToString().Split(' ');

                    // 입금 자료가 없을 경우 입금일자를 강제로 세팅
                    if (temp[0].Equals(""))
                    {
                        temp[0] = sdate;
                    }

                    _gijun_dt.Add(temp[0]);
                    

                    // 정산처리 대상일은 1일치 검색에만 정산처리를 합니다.(처리대상 이자가 달라지기 때문에)
                    if (!temp[0].Equals(sdate) || !temp[0].Equals(edate))
                    {
                        norun++;
                    }

                    // 입금예정금액
                    _expamt.Add(Convert.ToDecimal(row.Cells["SUB_TOTAL"].Value.ToString()));

                    // 입금금액
                    _tramt.Add(Convert.ToDecimal(row.Cells["TRAMT"].Value.ToString()));

                    // 강제출금액
                    _manamt.Add(Convert.ToDecimal(row.Cells["MNS_AMT_00"].Value.ToString()));

                    // 대리점코드
                    _agt_cd.Add(row.Cells["AGT_CD"].Value.ToString());

                }

                #region Validation Check

                if (selRows.Count() == 0)
                {
                    MessageBox.Show("정산처리 대상이 없습니다. 처리 대상을 선택하세요.");
                    return;
                }

                if (string.Compare(sdate, edate) != 0)
                {
                    MessageBox.Show("정산처리를 하기 위해서는 검색일자가 동일해야 합니다.");
                    return;
                }

                if (norun > 0)
                {
                    MessageBox.Show("조회된 대상으로는 정산처리를 할 수 없습니다.\r\n재검색하시기 바랍니다.");
                    return;
                }

                #endregion

                ACC0110 _form = new ACC0110();

                _form.SimFlag = simflag;            // 시뮬에이션 여부
                _form.GijunDate = _gijun_dt;        // 정산일자
                _form.StoreInfo = _str_cd;          // 가맹점코드
                _form.EXPAMT = _expamt;          // 입금예정금액
                _form.TRAMT = _tramt;           // 입금금액
                _form.MANAMT = _manamt;          // 강제출금액
                _form.AGT_CD = _agt_cd;          // 대리점코드

                DialogResult res = _form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("정산마감을 완료 하였습니다.");
					Search();
                }
                else if (res == System.Windows.Forms.DialogResult.Ignore)
                {
                    MessageBox.Show("정산마감 처리가 실패 했습니다. 관리자에게 문의 하시기 바랍니다.");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                EnableControls1(true);
            }
		}
		#endregion

        #region _btnSIMULATION_Click : 시뮬레이션 버튼 클릭 이벤트
        /// <summary>
        /// 시뮬레이션 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSIMULATION_Click(object sender, EventArgs e)
        {
            var simflag = "Y";

            try
            {
                EnableControls1(false);

                string sdate = null;
                string edate = null;

                sdate = _dtpTRADEDATE_S_S.Value.ToString("yyyy-MM-dd");
                edate = _dtpTRADEDATE_E_S.Value.ToString("yyyy-MM-dd");

                int norun = 0;

                List<string> _str_cd = new List<string>();
                List<string> _gijun_dt = new List<string>();
                List<decimal> _expamt = new List<decimal>();
                List<decimal> _tramt = new List<decimal>();
                List<decimal> _manamt = new List<decimal>();
                List<string> _agt_cd = new List<string>();

                // 선택된 행
                var selRows = gridView1.Rows.Cast<DataGridViewRow>()
                    .Where(row => row.Cells["CHK"].Value.ToString().Trim().Equals("Y") &&
                                    (row.Cells["MAGAM_YN"].Value.ToString().IndexOf("N") > 0))
                    .Select(row => row);
                foreach (DataGridViewRow row in selRows)
                {
                    // 가맹점명 & 코드
                    _str_cd.Add(row.Cells["STR_CD"].Value.ToString().Trim() + "^" + row.Cells["STR_NM"].Value.ToString().Trim());

                    // 입금일자
                    string[] temp = row.Cells["DUEDATE"].Value.ToString().Split(' ');
                    _gijun_dt.Add(temp[0]);

                    // 정산처리 대상일은 1일치 검색에만 정산처리를 합니다.(처리대상 이자가 달라지기 때문에)
                    if (!temp[0].Equals(sdate) || !temp[0].Equals(edate))
                    {
                        norun++;
                    }

                    // 입금예정금액
                    _expamt.Add(Convert.ToDecimal(row.Cells["SUB_TOTAL"].Value.ToString()));

                    // 입금금액
                    _tramt.Add(Convert.ToDecimal(row.Cells["TRAMT"].Value.ToString()));

                    // 강제출금액
                    _manamt.Add(Convert.ToDecimal(row.Cells["MNS_AMT_00"].Value.ToString()));

                    // 대리점코드
                    _agt_cd.Add(row.Cells["AGT_CD"].Value.ToString());

                }

                #region Validation Check

                if (selRows.Count() == 0)
                {
                    MessageBox.Show("정산처리 대상이 없습니다. 처리 대상을 선택하세요.");
                    return;
                }

                if (string.Compare(sdate, edate) != 0)
                {
                    MessageBox.Show("정산처리를 하기 위해서는 검색일자가 동일해야 합니다.");
                    return;
                }

                if (norun > 0)
                {
                    MessageBox.Show("조회된 대상으로는 정산처리를 할 수 없습니다.\r\n재검색하시기 바랍니다.");
                    return;
                }

                #endregion

                ACC0110 _form = new ACC0110();

                _form.SimFlag = simflag;            // 시뮬에이션 여부
                _form.GijunDate = _gijun_dt;        // 정산일자
                _form.StoreInfo = _str_cd;          // 가맹점코드
                _form.EXPAMT = _expamt;          // 입금예정금액
                _form.TRAMT = _tramt;           // 입금금액
                _form.MANAMT = _manamt;          // 강제출금액
                _form.AGT_CD = _agt_cd;          // 대리점코드

                DialogResult res = _form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("정산마감을 완료 하였습니다.");
                }
                else if (res == System.Windows.Forms.DialogResult.Ignore)
                {
                    MessageBox.Show("정산마감 처리가 실패 했습니다. 관리자에게 문의 하시기 바랍니다.");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                EnableControls1(true);
            }
        }

        #endregion

        

    }
}
