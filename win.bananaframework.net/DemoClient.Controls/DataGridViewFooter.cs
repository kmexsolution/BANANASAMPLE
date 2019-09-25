using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DemoClient.Controls
{
	public class DataGridViewFooter : BANANA.Windows.Controls.DataGridView
	{
		#region DataGridViewFooter : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public DataGridViewFooter()
		{	
			this.Dock						= DockStyle.Bottom;
			this.ScrollBars					= ScrollBars.Vertical;
			this.ColumnHeadersVisible		= false;
			this.AllowUserToResizeColumns	= true;
			this.AutoSizeColumnsMode		= DataGridViewAutoSizeColumnsMode.None;
		}
		#endregion

		#region OnLayout : 레이아웃 이벤트
		/// <summary>
		/// 레이아웃 이벤트
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLayout(LayoutEventArgs e)
		{
			base.OnLayout(e);

			// 헤더 체크박스 숨김
			//this.HideHeaderCheckBox();
		}
		#endregion

		#region ResizeColumnWidth : 컬럼 넓이 변경 함수
		/// <summary>
		/// 컬럼 넓이 변경 함수
		/// </summary>
		/// <param name="Column"></param>
		public void ResizeColumnWidth(DataGridViewColumn Column)
		{
			try
			{
				DataGridViewColumn[] _col	= this.Columns
					.Cast<DataGridViewColumn>()
					//.Where(w => w.GetType() == typeof(DataGridViewTextBoxColumn2))
					.Where(w => w.Name == Column.Name)
					.ToArray();
				if (_col.Length > 0)
				{
					_col[0].Width		= Column.Width;
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region Enabled : 컨트롤 활성화 여부
		/// <summary>
		/// 컨트롤 활성화 여부
		/// </summary>
		[DefaultValue(typeof(bool), "true")]
		[Category("BANANA Framework")]
		[Description("컨트롤의 활성화 여부를 가져오거나 저장합니다.")]
		public new bool Enabled
		{
			get
			{
				return base.Enabled;
			}
			set
			{
				if (DelegateProperty)
					base.Invoke(new Action(() => base.Enabled = value));
				else
					base.Enabled = value;
			}
		}
		#endregion
	}
}
