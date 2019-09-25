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
	/// 제  목: 구비서류추가
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-05 21:01
	/// 설  명: 가맹점의 구비서류를 추가하는 화면입니다.
	/// </summary>
	public partial class BAS0802 : DemoClient.Controllers.BasePopupForm
	{
		#region Fields
		private Thread _thread;	// 저장 쓰레드

		bool _isFirstOpen	= true;
		private byte[] _fileBuff { get; set; }
		private string _fileName { get; set; }
		#endregion
		
		#region Properties
		public int IDX { get; set; }
		public string STR_CD { get; set; }
		#endregion

		#region BAS0802 : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BAS0802()
		{
			InitializeComponent();
		}
		#endregion

		#region BAS0802_Load : 폼 로드 이벤트
		/// <summary>
		/// 폼 로드 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0802_Load(object sender, EventArgs e)
		{
			try
			{
				// 서류종류
				DataTable _dt01	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "D01", "", "", "", "");
				base.SetListItem(_cmbDOC_GUBUN_CD, _dt01, "TOTAL_CODE", "CODE_NAME");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region BAS0802_Shown : 폼 보이기 이벤트
		/// <summary>
		/// 폼 보이기 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BAS0802_Shown(object sender, EventArgs e)
		{
			try
			{
				// 등록
				if (this.IDX == 0)
				{
					if (_isFirstOpen)
					{
						System.Threading.Thread.Sleep(10);
						Application.DoEvents();

						_btnFindFiles.PerformClick();

						_isFirstOpen	= false;
					}
				}
				// 수정
				else
				{
					DataTable _dt	= base.GetDataTable("PCSP_BAS0800_R4"
						, this.IDX
						);
						
					_cmbDOC_GUBUN_CD.SelectedValue	= _dt.Rows[0]["DOC_GUBUN_CD"].ToString();
					_txtMEMO.Text					= _dt.Rows[0]["MEMO"].ToString();
					_fileBuff						= (byte[])_dt.Rows[0]["DOC_FILE_DATA"];
					_fileName						= _dt.Rows[0]["DOC_FILE_NAME"].ToString();
					_btnViewFile.Visible			= true;

					// 수정일 경우에는 파일을 여러 개 선택할 수 없다.
					openFileDialog1.Multiselect		= false;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnFindFiles_Click : 파일 찾기 버튼 클릭 이벤트
		/// <summary>
		/// 파일 찾기 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnFindFiles_Click(object sender, EventArgs e)
		{
			string fileName	= string.Empty;
			
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// 등록
				if (this.IDX == 0)
				{
					foreach (string file in openFileDialog1.FileNames)
					{
						fileName	+= string.Format("{0};", file);
					}
				}
				// 수정
				else
				{
					fileName	= openFileDialog1.FileName;
				}
			}

			_txtFile.Text	= fileName;
		}
		#endregion
		
		#region EnableControls1 : 컨트롤 활성화/비활성화 처리
		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		/// <param name="_bTrue"></param>
		void EnableControls1(bool _bTrue)
		{
			_cmbDOC_GUBUN_CD.Enabled	= _bTrue;
			_btnFindFiles.Enabled		= _bTrue;
			_btnSave.Enabled			= _bTrue;
			_btnClose.Enabled			= _bTrue;
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
				EnableControls1(false);

				panel1.Left		= (this.Width - panel1.Width) / 2;
				panel1.Top		= 30;
				panel1.Visible	= true;

				_thread		= new Thread(new ThreadStart(SaveFile));
				_thread.Start();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		void SaveFile()
		{
			try
			{
				base.BeginTransaction();

				// 등록
				if (this.IDX == 0)
				{
					if (_txtFile.Text == "")
					{
						MessageBox.Show("등록할 파일(들)을 선택하세요.");
						return;
					}

					string[] fileNames	= _txtFile.Text.Split(';');
					_lblStatus.Text		= string.Format("0/{0}", fileNames.Length - 1);

					int i	= 0;
					foreach (string fileName in fileNames)
					{
						if (!string.IsNullOrEmpty(fileName))
						{
							_lblStatus.Text		= string.Format("{0}/{1}", i + 1, fileNames.Length - 1);

							FileStream fs		= new FileStream(fileName, FileMode.Open, FileAccess.Read);
							BinaryReader br		= new BinaryReader(fs);
							FileInfo fileInfo	= new FileInfo(fileName);

							long numBytes		= fileInfo.Length;
							byte[] buff			= br.ReadBytes(Convert.ToInt32(numBytes.ToString()));

							base.ExecuteNonQuery("PCSP_BAS0802_C1"
								, this.STR_CD									// 가맹점코드
								, base.GetString(_cmbDOC_GUBUN_CD)				// 구비서류항목
								, fileInfo.Name									// 파일명
								, fileInfo.Extension.Replace(".", "").ToUpper()	// 파일종류(확장자)
								, buff											// 파일바이너리데이터
								, Convert.ToInt32(numBytes.ToString())			// 파일크기
								, _txtMEMO.Text									// 메모
								, ""											// 비고
								, base.GetCookie("USRID")						// 시스템수정자ID
								, base.GetCookie("USRNM")						// 시스템수정자명
								);
						}

						i++;
					}
				}
				// 수정
				else
				{
					long numBytes		= 0;
					byte[] buff			= null;
					string fileName		= string.Empty;
					string fileExt		= string.Empty;
					
					if (_txtFile.Text != "")
					{
						FileStream fs		= new FileStream(_txtFile.Text, FileMode.Open, FileAccess.Read);
						BinaryReader br		= new BinaryReader(fs);
						FileInfo fileInfo	= new FileInfo(_txtFile.Text);

						numBytes			= fileInfo.Length;
						buff				= br.ReadBytes(Convert.ToInt32(numBytes.ToString()));
						fileName			= fileInfo.Name;
						fileExt				= fileInfo.Extension.Replace(".", "").ToUpper();
					}

					base.ExecuteNonQuery("PCSP_BAS0802_U1"
						, this.IDX										// 일련번호
						, this.STR_CD									// 가맹점코드
						, base.GetString(_cmbDOC_GUBUN_CD)				// 구비서류항목
						, fileName										// 파일명
						, fileExt										// 파일종류(확장자)
						, buff											// 파일바이너리데이터
						, Convert.ToInt32(numBytes.ToString())			// 파일크기
						, _txtMEMO.Text									// 메모
						, ""											// 비고
						, base.GetCookie("USRID")						// 시스템수정자ID
						, base.GetCookie("USRNM")						// 시스템수정자명
						);
				}

				base.CommitTransaction();
				
				_txtFile.Text	= "";

				this.DialogResult	= System.Windows.Forms.DialogResult.OK;

				timer1.Enabled		= true;
			}
			catch (Exception err)
			{
				base.RollbackTransaction();
				MessageBox.Show(err.Message);
			}
			finally
			{
				EnableControls1(true);

				panel1.Invoke((MethodInvoker)delegate()
				{
					panel1.Visible	= false;
				});
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

		#region timer1_Tick : 화면 닫기
		/// <summary>
		/// 화면 닫기
		/// 쓰레드 안에서 화면 닫기가 에러남
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region _btnViewFile_Click : 파일 보기 버튼 클릭 이벤트
		/// <summary>
		/// 파일 보기 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnViewFile_Click(object sender, EventArgs e)
		{
			try
			{
				string tempPath		= System.IO.Path.GetTempPath();
				string fullFileName	= string.Format("{0}{1}", tempPath, _fileName);

				File.WriteAllBytes(fullFileName, _fileBuff);

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
		}
		#endregion
	}
}