using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoClient.View.BAS
{
	/// <summary>
	/// 제  목: 대리점.구비서류이력조회
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-08 21:27
	/// 설  명: 대리점의 구비서류 변경이력을 조회하는 화면입니다.
	/// </summary>
	public partial class BAS0780 : DemoClient.Controllers.BaseForm
	{
		private Thread _thread;	// 검색 쓰레드

		#region BAS0780 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0780()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0780_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0780_Load(object sender, EventArgs e)
		{
			try
			{
				//// 컬럼 밴드 처리-변경 전
				//var band01	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND01", HeaderText = "변경 전", BackColor = Color.Azure, UseBackColor = true };
				//band01.Columns.Add(_DOC_GUBUN_NM);
				//band01.Columns.Add(_DOC_FILE_NAME);
				//band01.Columns.Add(_DOC_FILE_TYPE);
				//band01.Columns.Add(_DOC_FILE_SIZE);
				//band01.Columns.Add(_MEMO);
				//band01.Columns.Add(_DOC_FILE_DOWNLOAD);
				//this.gridView1.AddBand(band01);
				
				//// 컬럼 밴드 처리-변경 후
				//var band02	= new BANANA.Windows.Controls.DataGridView.ColumnBandInfo { Name = "BAND02", HeaderText = "변경 후", BackColor = Color.LightBlue, UseBackColor = true };
				//band02.Columns.Add(DOC_GUBUN_NM);
				//band02.Columns.Add(DOC_FILE_NAME);
				//band02.Columns.Add(DOC_FILE_TYPE);
				//band02.Columns.Add(DOC_FILE_SIZE);
				//band02.Columns.Add(MEMO);
				//band02.Columns.Add(DOC_FILE_DOWNLOAD);
				//this.gridView1.AddBand(band02);

				// 서류종류
				DataTable _dt01	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "D02", "", "", "", "");
				base.SetListItem(_cmbDOC_GUBUN_CD_S, _dt01, "TOTAL_CODE", "CODE_NAME", true);
				
				_dtpSYSMODDATE_S_S.Value	= Convert.ToDateTime(System.DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd 00:00:00"));
				_dtpSYSMODDATE_E_S.Value	= Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0780_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0780_Shown(object sender, EventArgs e)
		{
			progressBar1.Top	= this.Height / 2 - 100;
			progressBar1.Left	= this.Width / 2 - progressBar1.Width / 2;
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
			_txtAGT_NM_S.ReadOnly			= !_bTrue;
			_txtAGT_CD_S.ReadOnly			= !_bTrue;
			_cmbDOC_GUBUN_CD_S.Enabled		= _bTrue;
			_txtDOC_FILE_NAME_S.ReadOnly	= !_bTrue;
			_txtMEMO_S.ReadOnly				= !_bTrue;
			_txtSYSREGNAME_S.ReadOnly		= !_bTrue;
			_dtpSYSMODDATE_S_S.Enabled		= _bTrue;
			_dtpSYSMODDATE_E_S.Enabled		= _bTrue;
			_btnSearch.Enabled				= _bTrue;
			_btnExcel.Enabled				= _bTrue;

			gridView1.Enabled				= _bTrue;
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

			try
			{
				DataTable _dt			= base.GetDataTable("PCSP_BAS0780_R1"
					, base.GetCookie("COMPANY_CD")
					, _txtAGT_NM_S.Text
					, _txtAGT_CD_S.Text
					, _cmbDOC_GUBUN_CD_S.SelectedValue
					, _txtSYSREGNAME_S.Text
					, _txtDOC_FILE_NAME_S.Text
					, _txtMEMO_S.Text
					, _dtpSYSMODDATE_S_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					, _dtpSYSMODDATE_E_S.Value.ToString("yyyy-MM-dd HH:mm:ss")
					);
				gridView1.DataSource	= _dt;

				_retValue				= _dt.Rows.Count;
			}
			catch
			{
				throw;
			}

			return _retValue;
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
				_dic.Add("O", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("Q", "yyyy-MM-dd HH:mm:ss");
				_dic.Add("S", "yyyy-MM-dd HH:mm:ss");

				_dic.Add("I", "@");
				_dic.Add("N", "@");
				
				_dic.Add("A", "#,###");
				_dic.Add("H", "#,###");
				_dic.Add("M", "#,###");
				BANANA.Windows.Controls.DataGridView _newGridView	= gridView1.Copy();

				// DataGridViewImageColumn 삭제
				_newGridView.Columns.RemoveAt(15);
				_newGridView.Columns.RemoveAt(9);

				_newGridView.ExportToExcel(_dic);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView1_CellContentClick : 파일 다운로드 아이콘 클릭 이벤트
		/// <summary>
		/// 파일 다운로드 아이콘 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9)
			{
				// 파일이 없는 경우
				if (gridView1.Rows[e.RowIndex].Cells["_DOC_FILE_DOWNLOAD"].ToolTipText == "")
				{
					return;
				}

				gridView1.Enabled		= false;
				progressBar1.Visible	= true;
				base.SetWaitCursor();

				_thread		= new Thread(() => OpenFile(Convert.ToInt32(gridView1.Rows[e.RowIndex].Cells["IDX"].Value.ToString()), true));
				_thread.Start();
			}
			else if (e.ColumnIndex == 15)
			{
				// 파일이 없는 경우
				if (gridView1.Rows[e.RowIndex].Cells["DOC_FILE_DOWNLOAD"].ToolTipText == "")
				{
					return;
				}

				gridView1.Enabled		= false;
				progressBar1.Visible	= true;
				base.SetWaitCursor();

				_thread		= new Thread(() => OpenFile(Convert.ToInt32(gridView1.Rows[e.RowIndex].Cells["IDX"].Value.ToString()), false));
				_thread.Start();
			}
		}

		void OpenFile(int IDX, bool IsBefore)
		{
			try
			{
				DataTable _dt		= base.GetDataTable("PCSP_BAS0780_R2"
					, IDX
					, IsBefore ? "Y" : "N"
					);

				string tempPath		= System.IO.Path.GetTempPath();
				string tempFileName	= _dt.Rows[0]["DOC_FILE_NAME"].ToString();
				string fullFileName	= string.Format("{0}{1}", tempPath, tempFileName);

				// 임시 폴더에 파일을 저장
				byte[] buff			= (byte[])_dt.Rows[0]["DOC_FILE_DATA"];
				File.WriteAllBytes(fullFileName, buff);

				// 임시 파일을 실행
				Process proc					= new Process();
				proc.StartInfo.FileName			= fullFileName;
				proc.StartInfo.UseShellExecute	= true;
				proc.Start(); 
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			finally
			{
				gridView1.Enabled	= true;

				progressBar1.Invoke((MethodInvoker)delegate()
				{
					progressBar1.Visible	= false;
				});

				base.RestoreCursor();
			}
		}
		#endregion

		#region gridView1_DataBindingComplete : 구비서류 아이콘 매핑
		/// <summary>
		/// 구비서류 아이콘 매핑
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			try
			{
				foreach (DataGridViewRow row in gridView1.Rows)
				{
					// 변경 전
					switch (row.Cells["_DOC_FILE_TYPE"].Value.ToString())
					{
						case "XLS":
							row.Cells[9].Value			= _iglDocuments.Images[0];
							row.Cells[9].ToolTipText	= "엑셀 문서";
							break;
						case "PPT":
							row.Cells[9].Value			= _iglDocuments.Images[1];
							row.Cells[9].ToolTipText	= "파워포인트 문서";
							break;
						case "DOC":
							row.Cells[9].Value			= _iglDocuments.Images[2];
							row.Cells[9].ToolTipText	= "워드 문서";
							break;
						case "HWP":
							row.Cells[9].Value			= _iglDocuments.Images[3];
							row.Cells[9].ToolTipText	= "한글 문서";
							break;
						case "PDF":
							row.Cells[9].Value			= _iglDocuments.Images[4];
							row.Cells[9].ToolTipText	= "PDF 문서";
							break;
						case "JPG":
							row.Cells[9].Value			= _iglDocuments.Images[5];
							row.Cells[9].ToolTipText	= "JPG 이미지";
							break;
						case "PNG":
							row.Cells[9].Value			= _iglDocuments.Images[6];
							row.Cells[9].ToolTipText	= "PNG 이미지";
							break;
						case "GIF":
							row.Cells[9].Value			= _iglDocuments.Images[7];
							row.Cells[9].ToolTipText	= "GIF 이미지";
							break;
						case "BMP":
							row.Cells[9].Value			= _iglDocuments.Images[8];
							row.Cells[9].ToolTipText	= "BMP 이미지";
							break;
						default:
							row.Cells[9].Value			= _iglDocuments.Images[9];
							row.Cells[9].ToolTipText	= "";
							break;
					}
					
					// 변경 후
					switch (row.Cells["DOC_FILE_TYPE"].Value.ToString())
					{
						case "XLS":
							row.Cells[15].Value			= _iglDocuments.Images[0];
							row.Cells[15].ToolTipText	= "엑셀 문서";
							break;
						case "PPT":
							row.Cells[15].Value			= _iglDocuments.Images[1];
							row.Cells[15].ToolTipText	= "파워포인트 문서";
							break;
						case "DOC":
							row.Cells[15].Value			= _iglDocuments.Images[2];
							row.Cells[15].ToolTipText	= "워드 문서";
							break;
						case "HWP":
							row.Cells[15].Value			= _iglDocuments.Images[3];
							row.Cells[15].ToolTipText	= "한글 문서";
							break;
						case "PDF":
							row.Cells[15].Value			= _iglDocuments.Images[4];
							row.Cells[15].ToolTipText	= "PDF 문서";
							break;
						case "JPG":
							row.Cells[15].Value			= _iglDocuments.Images[5];
							row.Cells[15].ToolTipText	= "JPG 이미지";
							break;
						case "PNG":
							row.Cells[15].Value			= _iglDocuments.Images[6];
							row.Cells[15].ToolTipText	= "PNG 이미지";
							break;
						case "GIF":
							row.Cells[15].Value			= _iglDocuments.Images[7];
							row.Cells[15].ToolTipText	= "GIF 이미지";
							break;
						case "BMP":
							row.Cells[15].Value			= _iglDocuments.Images[8];
							row.Cells[15].ToolTipText	= "BMP 이미지";
							break;
						default:
							row.Cells[15].Value			= _iglDocuments.Images[9];
							row.Cells[15].ToolTipText	= "";
							break;
					}
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion
	}
}
