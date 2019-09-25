using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace DemoClient.Controls
{
	public class GridView : BANANA.Windows.Controls.DataGridView
	{
		#region Fields
		Controls.DataGridViewFooter _footer						= null;
		string _footerGridId									= "BANANA.Windows.Controls.DataGrid.Footer";

		// 컬럼 넓이를 맞출 컬럼 인덱스들
		List<DataGridViewColumn> _columns	= null;
		#endregion

		public Controls.DataGridViewFooter FooterGrid
		{
			get { return _footer; }
		}

		//// Properties
		//#region DataSource : 푸터 그리드 생성
		///// <summary>
		///// 푸터 그리드 생성
		///// </summary>
		//public override object DataSource
		//{
		//	get
		//	{
		//		return base.DataSource;
		//	}
		//	set
		//	{
		//		this.Invoke((MethodInvoker)delegate
		//		{
		//			// 푸터 그리드 삽입
		//			if ((this.Parent != null) && (value != null) && (this.ShowFooter))
		//			{
		//				_columns = new List<DataGridViewColumn>();

		//				_footer = new Control.DataGridViewFooter();
		//				#region 푸터 옵션
		//				_footer.Name = _footerGridId;
		//				_footer.Height = this.ColumnHeadersHeight;
		//				//_footer.ShowHeaderCheckBox		= this.ShowHeaderCheckBox;
		//				#endregion

		//				#region 푸터에 컬럼 복사
		//				foreach (DataGridViewColumn _col in this.Columns)
		//				{
		//					if (_col.Name != "__CHK")
		//					{
		//						DataGridViewColumn _col2 = (DataGridViewColumn)_col.Clone();
		//						_footer.Columns.Add(_col2);

		//						// 컬럼 넓이를 맞추기 위해서 큐에 집어 넣는다.
		//						if (_col.Visible)
		//						{
		//							_columns.Add(_col);
		//						}
		//					}
		//				}
		//				#endregion

		//				System.Windows.Forms.Control[] _footerGridControl = this.Parent.Controls.Find(_footerGridId, true);
		//				if (_footerGridControl.Length > 0)
		//				{
		//					this.Parent.Controls.Remove(_footerGridControl[0]);
		//				}
		//				this.Parent.Controls.Add(_footer);
		//				this.BringToFront();

		//				DataTable _dtOrgn = (DataTable)value;
		//				DataTable _dt = _dtOrgn.Clone();
		//				DataRow _dr = _dt.NewRow();
		//				for (int i = 0; i < _dt.Columns.Count; i++)
		//				{
		//					if (_dt.Columns[i].DataType == typeof(Int64))
		//					{
		//						DataGridViewColumn[] _cols = this.Columns
		//							.Cast<DataGridViewColumn>()
		//							.Where(w => w.DataPropertyName == _dt.Columns[i].ColumnName)
		//							.ToArray();

		//						if (_cols.Length > 0)
		//						{
		//							DataGridViewTextBoxColumn2 _col2 = (DataGridViewTextBoxColumn2)_cols[0];
		//							switch (_col2.FooterMath)
		//							{
		//								case FooterMath.Avg:
		//									{
		//										var _avg = _dtOrgn.AsEnumerable()
		//											.Average(x => x.Field<Double>(_dt.Columns[i].ColumnName));

		//										_dr[_dt.Columns[i].ColumnName] = _avg;

		//										break;
		//									}

		//								case FooterMath.Sum:
		//									{
		//										var _sum = _dtOrgn.AsEnumerable()
		//											.Sum(x => x.Field<Int64>(_dt.Columns[i].ColumnName));

		//										_dr[_dt.Columns[i].ColumnName] = _sum;

		//										break;
		//									}
		//							}
		//						}
		//					}
		//					else if (_dt.Columns[i].DataType == typeof(Int32))
		//					{
		//						DataGridViewColumn[] _cols = this.Columns
		//							.Cast<DataGridViewColumn>()
		//							.Where(w => w.DataPropertyName == _dt.Columns[i].ColumnName)
		//							.ToArray();

		//						if (_cols.Length > 0)
		//						{
		//							DataGridViewTextBoxColumn2 _col2 = (DataGridViewTextBoxColumn2)_cols[0];
		//							switch (_col2.FooterMath)
		//							{
		//								case FooterMath.Avg:
		//									{
		//										var _avg = _dtOrgn.AsEnumerable()
		//											.Average(x => x.Field<Double>(_dt.Columns[i].ColumnName));

		//										_dr[_dt.Columns[i].ColumnName] = _avg;

		//										break;
		//									}

		//								case FooterMath.Sum:
		//									{
		//										var _sum = _dtOrgn.AsEnumerable()
		//											.Sum(x => x.Field<Int32>(_dt.Columns[i].ColumnName));

		//										_dr[_dt.Columns[i].ColumnName] = _sum;

		//										break;
		//									}
		//							}
		//						}
		//					}
		//					else if (_dt.Columns[i].DataType == typeof(Double))
		//					{
		//						DataGridViewColumn[] _cols = this.Columns
		//							.Cast<DataGridViewColumn>()
		//							.Where(w => w.DataPropertyName == _dt.Columns[i].ColumnName)
		//							.ToArray();

		//						if (_cols.Length > 0)
		//						{
		//							DataGridViewTextBoxColumn2 _col2 = (DataGridViewTextBoxColumn2)_cols[0];
		//							switch (_col2.FooterMath)
		//							{
		//								case FooterMath.Avg:
		//									{
		//										var _avg = _dtOrgn.AsEnumerable()
		//											.Average(x => x.Field<Double>(_dt.Columns[i].ColumnName));

		//										_dr[_dt.Columns[i].ColumnName] = _avg;

		//										break;
		//									}

		//								case FooterMath.Sum:
		//									{
		//										var _sum = _dtOrgn.AsEnumerable()
		//											.Sum(x => x.Field<Double>(_dt.Columns[i].ColumnName));

		//										_dr[_dt.Columns[i].ColumnName] = _sum;

		//										break;
		//									}
		//							}
		//						}
		//					}
		//				}
		//				_dt.Rows.Add(_dr);
		//				_footer.DataSource = _dt;
		//			}

		//			base.DataSource = value;
		//		});
				
		//	}
		//}
		//#endregion

		#region ShowFooter : 푸터 그리드를 보여줄지 여부
		/// <summary>
		/// 푸터 그리드를 보여줄지 여부
		/// </summary>
		[Category("BANANA Framework")]
		[DefaultValue(typeof(bool), "false")]
		[Description("푸터 그리드를 보여줄지 여부를 가져오거나 저장합니다.")]
		public bool ShowFooter { get; set; }
		#endregion

		#region SelectionMode : 행 선택 방법
		/// <summary>
		/// 행 선택 방법
		/// </summary>
		[DefaultValue(typeof(DataGridViewSelectionMode), "CellSelect")]
		new public DataGridViewSelectionMode SelectionMode { get; set; }
		#endregion

		#region GridView : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public GridView() : base()
		{	
			this.AllowUserToAddRows				= false;
			this.AutoSizeColumnsMode			= DataGridViewAutoSizeColumnsMode.AllCells;
			this.BackgroundColor				= System.Drawing.Color.White;
			DataGridViewCellStyle _style		= new DataGridViewCellStyle();
			_style.WrapMode						= DataGridViewTriState.False;
			//_style.BackColor					= Color.White;	// 이거 없으면 스크롤 할 때, 컬럼 헤더의 글자가 깨져 보임 -> 화면마다 ColumnHeadersDefaultCellStyle의 BackColor를 지정하는 것으로 변경
			this.ColumnHeadersDefaultCellStyle	= _style;
			this.ColumnHeadersHeightSizeMode	= DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DelegateProperty				= true;
			this.Dock							= DockStyle.Fill;
			this.ReadOnly						= false;
			this.SelectionMode					= DataGridViewSelectionMode.FullRowSelect;

			// 자동컬럼생성
			this.AutoGenerateColumns			= false;
		}
		#endregion

		#region OnCellEndEdit : 푸터 그리드 합계 업데이트
		/// <summary>
		/// 푸터 그리드 합계 업데이트
		/// </summary>
		/// <param name="e"></param>
		protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
		{
			base.OnCellEndEdit(e);

			if (this.ShowFooter)
			{
				decimal _sum	= this.Rows
					.Cast<DataGridViewRow>()
					.Sum(f => Convert.ToInt32(f.Cells[e.ColumnIndex].Value));
				_footer.Rows[0].Cells[e.ColumnIndex].Value	= _sum;
			}
		}
		#endregion
	}
}
