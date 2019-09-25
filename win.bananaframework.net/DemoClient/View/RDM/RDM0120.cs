using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DemoClient.View.RDM
{
	/// <summary>
	/// 제  목: 상환마감처리 화면
	/// 작성자: 한인수 (crowlead1208@devpia.com, 010-8633-2208)
	/// 작성일: 2016-08-04 14:55
	/// 설  명: 엑셀 업로드 후 데이터를 저장하는 화면입니다.
	/// </summary>
    public partial class RDM0120 : DemoClient.Controllers.BasePopupForm
	{
		DataTable _DataTable = null;

		#region RDM0120 : 생성자
		/// <summary>
		/// 생성자
		/// </summary>
		public RDM0120()
        {
            InitializeComponent();
        }
		#endregion

		#region RDM0120_Load : 폼 로드
		/// <summary>
		/// 폼 로드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RDM0120_Load(object sender, EventArgs e)
		{
			try
			{
				// 상환.은행코드
				DataTable _dt	= base.GetDataTable("CHP_AJAX_CODEHELPER", "Common", "A02", "", "", "", "");
				base.SetListItem(_cmbBANK_CD, _dt, "TOTAL_CODE", "CODE_NAME", false);

                _cmbBANK_CD.SelectedValue = "A02016";
                _cmbBANK_CD.Visible = false;
                label1.Visible = false;

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
					else if (colum.GetType() == typeof(DataGridViewButtonColumn))
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

		#region _btnFindFile_Click : 파일 찾기 버튼 클릭 이벤트
		/// <summary>
		/// 파일 찾기 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnFindFile_Click(object sender, EventArgs e)
		{
			try
			{
				string fileName = string.Empty;

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					if (openFileDialog1.FileNames.Length > 1)
					{
						MessageBox.Show("파일은 1개만 저장이 됩니다.");
						return;
					}
					else
					{
						if (openFileDialog1.FileNames[0].Split('.')[1] != "xlsx" && openFileDialog1.FileNames[0].Split('.')[1] != "xls")
						{
							MessageBox.Show("엑셀파일만 업로드 가능합니다.");
							return;
						}

						foreach (string file in openFileDialog1.FileNames)
						{
							fileName += string.Format("{0};", file);
						}

						gridView1.DataSource	= null;
						_cmbBANK_CD.Enabled		= true;
					}
				}

				_txtFile.Text = fileName;

                if (!string.IsNullOrEmpty(fileName))
                {
                    _btnInsert_Click(null, null);
                }

			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region _btnInsert_Click : 추가 버튼 클릭 이벤트
		/// <summary>
		/// 추가 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnInsert_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(_txtFile.Text))
				{
					// 엑셀 파일 추가 후 상환은행은 고정이 된다.
					_cmbBANK_CD.Enabled		= false;

					string _strFilePath		= _txtFile.Text.Replace(";", "");
					DataTable _dtExcel		= new System.Data.DataTable();

					#region 엑셀 문서 내용 추출
					// 엑셀 OleDB 체크
					OleDbEnumerator enumerator = new OleDbEnumerator();
					DataTable _dtOleDB = enumerator.GetElements();

					List<string> aryProviders = new List<string>();

					//string _strInfo = string.Empty;

					//foreach (DataRow row in _dtOleDB.Rows)
					//{
					//	foreach (DataColumn col in _dtOleDB.Columns)
					//	{
					//		Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
					//		_strInfo += string.Format("{0} = {1};", col.ColumnName, row[col]);
					//	}
					//	Console.WriteLine("==================================");
					//	_strInfo += "==================================";
					//}  


					foreach (DataRow row in _dtOleDB.Rows)
					{
						aryProviders.Add(row[0].ToString());
					}
					_dtOleDB.Dispose();

					aryProviders.Sort((p, n) => n.CompareTo(p));

					


					string sFoundString = aryProviders.Find(m => m.StartsWith("Microsoft.ACE.OLEDB.12.0"));
					string sExtended = "Excel 12.0;HDR=YES";

					if (string.IsNullOrEmpty(sFoundString))
					{
						sFoundString = aryProviders.Find(m => m.StartsWith("Microsoft.ACE.OLEDB.4.0"));
						sExtended = "Excel 12.0;HDR=YES";
					}
						
					if (string.IsNullOrEmpty(sFoundString))
					{
						sFoundString = aryProviders.Find(m => m.StartsWith("Microsoft.Jet.OLEDB.4.0"));
						sExtended = "Excel 8.0;HDR=YES;IMEX=1";
					}

					object missing			= System.Reflection.Missing.Value;
					string strProvider		= string.Empty;

					// 엑셀 업로드 변수 체크 필요 
					// http://hind.pe.kr/1198 에서 확인 필요
					strProvider = string.Format("Provider={0}; Data Source='{1}';Extended Properties='{2}'", sFoundString, _strFilePath, sExtended);
					//strProvider = "Provider=Microsoft.ACE.OLEDB.4.0; Data Source=" + _txtFile.Text + @";Extended Properties='Excel 12.0;HDR=YES'";
					//strProvider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + _strFilePath + @"';Extended Properties='Excel 12.0;HDR=YES'";
					//strProvider = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + _strFilePath + @"';Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";

					// 엑셀 문서 내용 추출
					using (OleDbConnection conn = new OleDbConnection(strProvider))
					{
						conn.Open();
						var dtSchema			= conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
						string sheet1			= dtSchema.Rows[0].Field<string>("TABLE_NAME");
						OleDbCommand cmd		= new OleDbCommand(String.Format("SELECT * FROM [{0}]", sheet1), conn);
						OleDbDataAdapter adp	= new OleDbDataAdapter();
						adp.SelectCommand		= cmd;
						adp.Fill(_dtExcel);

						adp.Dispose();
						cmd.Dispose();
					}
					#endregion

					DataTable _dt = new DataTable();

					_dt.Columns.Add("CHK", typeof(string));
					_dt.Columns.Add("STR_NM", typeof(string));
					_dt.Columns.Add("btn_STR", typeof(string));
					_dt.Columns.Add("PRSNT_NM", typeof(string));
					_dt.Columns.Add("BI_SAUP_NO", typeof(string));
					_dt.Columns.Add("BI_BINF_CD", typeof(string));
					_dt.Columns.Add("DUEDATE", typeof(string));
					_dt.Columns.Add("AMOUNT", typeof(string));
					_dt.Columns.Add("SUM_AMOUNT", typeof(string));
					_dt.Columns.Add("ABSTRACT", typeof(string));
					_dt.Columns.Add("STR_CONTENT", typeof(string));
					_dt.Columns.Add("STR_BRANCH", typeof(string));
					_dt.Columns.Add("STR_CD", typeof(string));
                    _dt.Columns.Add("SENDFEE", typeof(string));

                    DateTime dateValue;
					for	(int i = 0; i < _dtExcel.Rows.Count; i++)
					{
						// 지급월일이 datetime인 것들만 담아준다
						if (DateTime.TryParse(_dtExcel.Rows[i][1].ToString().Replace("(", "").Replace(")", ""), out dateValue))
						{
							// 입금액이 0원이거나 공백인 경우 처리를 안한다.
							if (_dtExcel.Rows[i][5].ToString() == "0" || _dtExcel.Rows[i][5].ToString() == "")
							{
								continue;
							}

							string _strSTR_NM		= string.Empty;
							string _strPRSNT_NM		= string.Empty;
							string _strBI_SAUP_NO	= string.Empty;
							string _strBI_BINF_CD	= string.Empty;
							string _strSTR_CD		= string.Empty;
                            string _sendfee         = string.Empty;

                            DataTable _dtTemp = base.GetDataTable(
								"PCSP_RDM0120_R1"
								, _dtExcel.Rows[i][3].ToString()	// 기재내용
								, _dtExcel.Rows[i][7].ToString()	// 취급지점
								, _cmbBANK_CD.SelectedValue
								);

							// 기재내용과 취급지점으로 매핑된 가맹점 정보가 있으면 해당 정보를 가져온다.
							// 기재내용과 취급지점이 같은 것도 있을 수가 있으니 사용자에게 가맹점 검색 버튼으로 새로 등록 가능하게끔 유도 요망
							if (_dtTemp.Rows.Count > 0)
							{
								_strSTR_NM			= _dtTemp.Rows[0]["STR_NM"].ToString();
								_strPRSNT_NM		= _dtTemp.Rows[0]["PRSNT_NM"].ToString();
								_strBI_SAUP_NO		= _dtTemp.Rows[0]["BI_SAUP_NO"].ToString();
								_strBI_BINF_CD		= _dtTemp.Rows[0]["BI_BINF_CD"].ToString();
								_strSTR_CD			= _dtTemp.Rows[0]["STR_CD"].ToString();
                                _sendfee            = _dtTemp.Rows[0]["SENDFEE"].ToString();
                            }

							DataRow _dr				= _dt.NewRow();
							_dr["CHK"]				= _strSTR_CD == "" ? "N" : "Y";
							_dr["STR_NM"]			= _strSTR_NM;
							_dr["btn_STR"]			= "검색";
							_dr["PRSNT_NM"]			= _strPRSNT_NM;
							_dr["BI_SAUP_NO"]		= _strBI_SAUP_NO;
							_dr["BI_BINF_CD"]		= _strBI_BINF_CD;
							_dr["DUEDATE"]			= _dtExcel.Rows[i][1].ToString().Replace("(", "").Replace(")", "");
							_dr["AMOUNT"]			= _dtExcel.Rows[i][5].ToString();				// 입금
							_dr["SUM_AMOUNT"]		= _dtExcel.Rows[i][6].ToString();				// 거래후 잔액
							_dr["ABSTRACT"]			= _dtExcel.Rows[i][2].ToString();				// 적요
							_dr["STR_CONTENT"]		= _dtExcel.Rows[i][3].ToString();				// 기재내용
							_dr["STR_BRANCH"]		= _dtExcel.Rows[i][7].ToString();				// 취급지점
							_dr["STR_CD"]			= _strSTR_CD;
                            _dr["SENDFEE"]          = _sendfee;

                            _dt.Rows.Add(_dr);
						}
					}

					_DataTable = _dt;
					gridView1.DataSource = _DataTable;
					//gridView1.DataSource = _dt;


					
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		#endregion

		#region gridView1_CellContentClick : 그리드 셀 내부 컨텐츠 클릭 이벤트(버튼 클릭만 허용)
		/// <summary>
		/// 그리드 셀 내부 컨텐츠 클릭 이벤트(버튼 클릭만 허용)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var senderGrid = (DataGridView)sender;

				// 그리드 셀 내부 컨텐츠가 버튼일 경우만 찾는다
				if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
				{
					Common.STR_Form form = new Common.STR_Form();
					DialogResult res = form.ShowDialog();

					if (res == System.Windows.Forms.DialogResult.OK)
					{
						gridView1.Rows[e.RowIndex].Cells["CHK"].Value			= "Y";
						gridView1.Rows[e.RowIndex].Cells["STR_CD"].Value		= form.strSTR_Data.Split('|')[0];	// 가맹점코드
						gridView1.Rows[e.RowIndex].Cells["STR_NM"].Value		= form.strSTR_Data.Split('|')[1];	// 가맹점명
						gridView1.Rows[e.RowIndex].Cells["PRSNT_NM"].Value		= form.strSTR_Data.Split('|')[2];	// 대표자명
						//gridView1.Rows[e.RowIndex].Cells["ADDR_BSC"].Value		= form.strSTR_Data.Split('|')[3];	// 기본주소
						gridView1.Rows[e.RowIndex].Cells["BI_BINF_CD"].Value	= form.strSTR_Data.Split('|')[4];	// 사업자구분
						gridView1.Rows[e.RowIndex].Cells["BI_SAUP_NO"].Value	= form.strSTR_Data.Split('|')[5];	// 사업자등록번호
						//gridView1.Rows[e.RowIndex].Cells["TELNO"].Value			= form.strSTR_Data.Split('|')[6];	// 전화번호
						//gridView1.Rows[e.RowIndex].Cells["FAXNO"].Value			= form.strSTR_Data.Split('|')[7];	// 팩스번호

						DataTable _dtTemp = base.GetDataTable(
							"PCSP_RDM0120_R2"
							, form.strSTR_Data.Split('|')[0].ToString()	// 가맹점코드
							);

						if (_dtTemp.Rows.Count > 0)
						{
							gridView1.Rows[e.RowIndex].Cells["SENDFEE"].Value = _dtTemp.Rows[0]["SENDFEE"].ToString();
						}
					}
				}
				else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
				{
					gridView1.Rows[e.RowIndex].Cells["CHK"].Value = gridView1.Rows[e.RowIndex].Cells["CHK"].Value.ToString() == "Y" ? "N" : "Y";
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
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
                string msg = null;
                
                if (gridView1.RowCount > 0)
				{
					for (int i = 0; i < gridView1.RowCount; i++)
					{
						//if (string.IsNullOrEmpty(gridView1.Rows[i].Cells["STR_CD"].Value.ToString()))
						//{
						//	msg = "가맹점이 선택되지 않았습니다.";
						//	break;
						//}

                        if (string.IsNullOrEmpty(gridView1.Rows[i].Cells["AMOUNT"].Value.ToString()))
                        {
                            msg = "맡기신 금액이 0원입니다. 확인하시기 바랍니다.";
                            break;
                        }

                        if (Convert.ToDecimal(gridView1.Rows[i].Cells["AMOUNT"].Value) <= 0)
                        {
                            msg = "맡기신 금액이 0원 이하입니다. 확인하시기 바랍니다.";
                            break;
                        }

						if (gridView1.Rows[i].Cells["CHK"].Value.ToString() == "Y")
						{
							base.ExecuteNonQuery(
								"PCSP_RDM0120_C1"
								, gridView1.Rows[i].Cells["STR_CD"].Value.ToString()									// 가맹점코드
								, gridView1.Rows[i].Cells["STR_CONTENT"].Value.ToString()								// 기재내용
								, gridView1.Rows[i].Cells["STR_BRANCH"].Value.ToString()								// 취급지점
								, gridView1.Rows[i].Cells["ABSTRACT"].Value.ToString()									// 적요
								, _cmbBANK_CD.SelectedValue																// 은행코드
								, gridView1.Rows[i].Cells["DUEDATE"].Value.ToString().Split(' ')[0].Replace('.', '-')	// 입금일
								, gridView1.Rows[i].Cells["DUEDATE"].Value.ToString().Split(' ')[1]						// 입금시간
								, gridView1.Rows[i].Cells["AMOUNT"].Value == null ? 0 : decimal.Parse(gridView1.Rows[i].Cells["AMOUNT"].Value.ToString())			// 입금액
								, gridView1.Rows[i].Cells["SUM_AMOUNT"].Value == null ? 0 : decimal.Parse(gridView1.Rows[i].Cells["SUM_AMOUNT"].Value.ToString())	// 입금총액
								, gridView1.Rows[i].Cells["SENDFEE"].Value == null ? 0 : decimal.Parse(gridView1.Rows[i].Cells["SENDFEE"].Value.ToString())			// 송금수수료
                            );
						}

                        msg = "저장하였습니다.";
					}

					MessageBox.Show(msg);

                    this.Close();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
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
			_DataTable.Columns.Remove("CHK");
			DataColumn _newColumn = new DataColumn("CHK", typeof(string));
			_newColumn.DefaultValue = "Y";
			_DataTable.Columns.Add(_newColumn);
			//for (int i = 0; i < _DataTable.Rows.Count; i++)
			//{
			//	_DataTable.Rows[i]["CHK"] = "Y";
			//_DataTable.Rows[i]["CHK"] = "true";
			//}
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
			_DataTable.Columns.Remove("CHK");
			DataColumn _newColumn = new DataColumn("CHK", typeof(string));
			_newColumn.DefaultValue = "N";
			_DataTable.Columns.Add(_newColumn);
		}
		#endregion

    }
}