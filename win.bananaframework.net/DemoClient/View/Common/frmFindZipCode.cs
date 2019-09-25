using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.Common
{
	/// <summary>
	/// 우편번호 찾기
	/// 네이버 우편번호 찾기 스크린 스크핑
	/// http://nxd.search.naver.com/dsearch_r0/zipcode.naver?where=zipcode_svc&p1={0}
	/// </summary>
	public partial class frmFindZipCode : DemoClient.Controllers.BasePopupForm
	{
		Thread _thread;
		DataTable _dtZipCode;
		string _areCode		= string.Empty;

		#region Properties
		/// <summary>
		/// 우편번호 컨트롤
		/// </summary>
		public BANANA.Windows.Controls.TextBox ZipCodeTextBox { get; set; }

		/// <summary>
		/// 기본주소 컨트롤
		/// </summary>
		public BANANA.Windows.Controls.TextBox AddressBasicTextBox { get; set; }
		#endregion

		#region frmFindZipCode : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public frmFindZipCode()
		{
			InitializeComponent();
		}
		#endregion

		#region frmFindZipCode_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmFindZipCode_Load(object sender, EventArgs e)
		{
			_flpArea.Visible	= false;
			_flpArea.Height		= 0;
		}
		#endregion

		#region frmFindZipCode_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmFindZipCode_Shown(object sender, EventArgs e)
		{
			_txtAddress.Focus();
		}
		#endregion

		#region EnableControls : 컨트롤 활성화/비활성화
		/// <summary>
		/// 컨트롤 활성화/비활성화
		/// </summary>
		/// <param name="_bTrue"></param>
		void EnableControls(bool _bTrue)
		{
			_txtAddress.Enabled		= _bTrue;
			_btnSearch.Enabled		= _bTrue;
			gridView1.Enabled		= _bTrue;
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
			try
			{
				if (_txtAddress.Text.Trim() == "")
				{
					MessageBox.Show("검색할 주소를 입력하세요.");
					_txtAddress.Focus();
					return;
				}

				_areCode	= string.Empty;
			
				_flpArea.Invoke((MethodInvoker)delegate()
				{
					_flpArea.Visible	= false;
					_flpArea.Height		= 0;
				});

				_dtZipCode	= new DataTable();
				_dtZipCode.Columns.Add("ZipCode", typeof(string));
				_dtZipCode.Columns.Add("AddressDoro", typeof(string));
				_dtZipCode.Columns.Add("AddressJibun", typeof(string));

				base.SetWaitCursor();
				EnableControls(false);
				_pnlLoading.Invoke((MethodInvoker)delegate()
				{
					_pnlLoading.Visible	= true;
				});

				_thread		= new Thread(new ThreadStart(Search));
				_thread.Start();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		void Search()
		{
			try
			{
				BANANA.Windows.ScreenScraping _sc	= new BANANA.Windows.ScreenScraping();
				
				_flpArea.Invoke((MethodInvoker)delegate()
				{
					_flpArea.Controls.Clear();
				});
				
				int currPage	= 1;
				int lastPage	= -1;

				string urlOrgn	= "http://csearch.naver.com/content/eprender.nhn?where=nexearch&pkid=252&q={0}%20%EC%9A%B0%ED%8E%B8%EB%B2%88%ED%98%B8&key=address_kor";
				string url		= string.Format(urlOrgn, System.Web.HttpUtility.UrlEncode(_txtAddress.Text), currPage);
				string html		= _sc.GetHtmlSource(url);
				
				string[] temp	= _sc.FindText(html, "class=\"pgn\">", "</a>");
				lastPage		= temp.Length == 0 ? 1 : Convert.ToInt32(temp[temp.Length - 1]);

				// html 파싱 -> 지역별 갯수
				string[] tempArea		= _sc.FindText(html, "<ul class=\"sort\" id=\"ds_region\">", "</ul>");
				string[] areaCode		= new string[] {};
				string[] areaName		= new string[] {};
				if (tempArea.Length > 0)
				{
					areaCode	= _sc.FindText(tempArea[0], "zipcode_svc&region=", "\" onClick");
					areaName	= _sc.FindText(tempArea[0], "event);\">", "</a>");
				}

				while (currPage <= lastPage)
				{
					if (currPage > 1)
					{
						string _tempUrl		= string.Format("&u1=all&u3={0}", (currPage -1) * 100 + 1);
						string _tempUrl2	= url + _tempUrl;
						html				= _sc.GetHtmlSource(_tempUrl2);
						temp				= _sc.FindText(html, "class=\"pgn\">", "</a>");
						if (temp.Length == 0)
						{
							break;
						}
						int tmpLastPage		= Convert.ToInt32(temp[temp.Length - 1]);
						if (tmpLastPage > lastPage)
						{
							lastPage	= tmpLastPage;
						}
					}

					// html 파싱 -> DataTable
					string[] tempBody	= _sc.FindText(html, "<tbody>", "</tbody>");
					if (tempBody.Length == 0)
					{
						// 검색결과가 없음
						return;
					}
					html				= tempBody[0];
					string[] tr			= _sc.FindText(html, "<tr>", "</tr>");
					foreach (string s in tr)
					{
						string _zipCode	= _sc.FindText(s, "<td class=\"tc\"><strong>", "</strong>")[0];
						
						//string[] doro	= _sc.FindText(s, "<dt><img src=\"http://sstatic.naver.net/keypage/lifesrch/zipcode/img/btn_road.gif\" width=\"37\" height=\"14\" alt=\"도로명\"></dt> <dd><span class=\"r_addr\">", "</span></dd>");
						//string _doro	= doro.Length == 0 ? "" : doro[0];
						//_doro			= 
						
						//string[] jibun	= _sc.FindText(s, "<dt><img src=\"http://sstatic.naver.net/keypage/lifesrch/zipcode/img/btn_num.gif\" width=\"37\" height=\"14\" alt=\"지번\"></dt> <dd><span class=\"r_addr\">", "</span></dd>");
						//string _jibun	= jibun.Length == 0 ? "" : jibun[0];
						//_jibun			= _sc.RemoveHtmlCode(_jibun, true);

						string[] _addr		= _sc.FindText(s, "<dd>", "</dd>");

						string _doro		= _sc.RemoveHtmlCode(_addr[0], true);
						string _jibun		= _sc.RemoveHtmlCode(_addr[1], true);

						DataRow _dr			= _dtZipCode.NewRow();
						_dr["ZipCode"]		= _zipCode.Trim();
						_dr["AddressDoro"]	= _doro.Trim();
						_dr["AddressJibun"]	= _jibun.Trim();
						_dtZipCode.Rows.Add(_dr);
					}

					currPage++;
				}

				gridView1.DataSource	= _dtZipCode;
				
				if (areaCode.Length > 0)
				{
					_flpArea.Invoke((MethodInvoker)delegate()
					{
						_flpArea.Visible	= true;
						_flpArea.Height		= 50;
					});

					for (int i = 0; i < areaCode.Length; i++)
					{
						LinkLabel _lnkArea	= new LinkLabel();
						_lnkArea.Text		= areaName[i + 1];
						_lnkArea.Tag		= areaCode[i];
						_lnkArea.Click		+= _lnkArea_Click;
						_flpArea.Invoke((MethodInvoker)delegate()
						{
							_flpArea.Controls.Add(_lnkArea);
						});
					}
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				_pnlLoading.Invoke((MethodInvoker)delegate()
				{
					_pnlLoading.Visible	= false;
				});
				EnableControls(true);
				base.RestoreCursor();

				_txtAddress.Focus();
			}
		}
		#endregion

		#region _lnkArea_Click : 지역 클릭 이벤트
		/// <summary>
		/// 지역 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void _lnkArea_Click(object sender, EventArgs e)
		{
			LinkLabel _lnkArea	= (LinkLabel)sender;
			_areCode			= _lnkArea.Tag.ToString();
			
			_flpArea.Invoke((MethodInvoker)delegate()
			{
				_flpArea.Visible	= false;
				_flpArea.Height		= 0;
			});

			_dtZipCode	= new DataTable();
			_dtZipCode.Columns.Add("ZipCode", typeof(string));
			_dtZipCode.Columns.Add("AddressDoro", typeof(string));
			_dtZipCode.Columns.Add("AddressJibun", typeof(string));

			base.SetWaitCursor();
			EnableControls(false);
			_pnlLoading.Invoke((MethodInvoker)delegate()
			{
				_pnlLoading.Visible	= true;
			});

			_thread		= new Thread(new ThreadStart(Search));
			_thread.Start();
		}
		#endregion

		#region _txtAddress_KeyDown : KeyDown 이벤트
		/// <summary>
		/// KeyDown 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _txtAddress_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_btnSearch.PerformClick();
			}
		}
		#endregion

		#region gridView1_CellDoubleClick : 우편번호 선택 더블클릭 이벤트
		/// <summary>
		/// 우편번호 선택 더블클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (gridView1.CurrentRow == null)
					return;

				DataGridViewRow _row	= gridView1.CurrentRow;
				if (ZipCodeTextBox == null)
				{
					MessageBox.Show("[개발오류] 우편번호 컨트롤을 지정하지 않았습니다.");
					return;
				}
				else if (AddressBasicTextBox == null)
				{
					MessageBox.Show("[개발오류] 주소 컨트롤을 지정하지 않았습니다.");
					return;
				}
				
				ZipCodeTextBox.Text			= _row.Cells["ZipCode"].Value.ToString();
				AddressBasicTextBox.Text	= _row.Cells["AddressDoro"].Value.ToString();
				
				// OK 반환
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
