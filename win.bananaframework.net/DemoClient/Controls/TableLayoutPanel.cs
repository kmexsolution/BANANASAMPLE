using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DemoClient.Controls
{
	/// <summary>
	/// 제  목: 테이블레이아웃판넬
	/// 작성자: 한인수 (crowlead1208@naver.com, 010-8633-2208)
	/// 작성일: 2014-08-01 18:51
	/// 설  명: 넓이에 따라서, 자동으로 줄여지고 넓어지는 테이블레이아웃판넬이다.
	/// </summary>
	public class TableLayoutPanel : System.Windows.Forms.TableLayoutPanel
	{
		#region Fields
		int _defaultHeight						= -1;
		int _defaultParentHeight				= -1;
		int _defaultRowHeight					= -1;
		int _defaultColCount					= -1;
		int _defaultRowCount					= -1;
		bool _isSavedDefault					= false;
		bool _skipSizeChangedEvent				= false;
		List<RemovedControl> _removedControl	= new List<RemovedControl>();
		#endregion

		#region TableLayoutPanel : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public TableLayoutPanel()
		{
			this.CellBorderStyle	= TableLayoutPanelCellBorderStyle.Single;
		}
		#endregion

		// Methods
		#region GetMainForm : 메인 폼을 찾음
		/// <summary>
		/// 메인 폼을 찾음
		/// 윈도우 상태가 최대화 되었는지 여부를 확인하기 위함
		/// </summary>
		/// <param name="Control"></param>
		/// <returns></returns>
		frmMain GetMainForm(System.Windows.Forms.Control Control)
		{
			if (Control.GetType() == typeof(frmMain))
			{
				return (frmMain)Control;
			}
			else
			{
				if (Control.Parent == null)
					return null;
				return GetMainForm(Control.Parent);
			}
		}
		#endregion

		// Override
		#region OnPaint : 기본 설정 가져오기
		/// <summary>
		/// 기본 설정 가져오기
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (!DesignMode && !_isSavedDefault)
			{
				// 기본 높이 가져오기
				_defaultRowHeight		= this.GetRowHeights()[0];

				// 기본 열의 갯수 가져오기
				_defaultColCount		= this.ColumnCount;

				// 기본 행의 갯수 가져오기
				_defaultRowCount		= this.RowCount;

				// 기본 높이 가져오기
				_defaultHeight			= this.Height;

				// 부모 컨트롤의 기본 높이 가져오기
				_defaultParentHeight	= this.Parent.Height;

				_isSavedDefault	= true;
			}

			base.OnPaint(e);
		}
		#endregion

		#region OnSizeChanged : 화면 크기 변경 이벤트
		/// <summary>
		/// 화면 크기 변경 이벤트
		/// </summary>
		/// <param name="e"></param>
		protected override void OnSizeChanged(EventArgs e)
		{
			if (!DesignMode && !_skipSizeChangedEvent)
			{
				bool _isAllVisible	= true;
				for (int i = 0; i < this.Controls.Count; i++)
				{
					System.Windows.Forms.Control _control	= this.Controls[i];

					// FlowLayoutPanel 같은 컨트롤에 올라와 있는 컨트롤
					if (_control.Controls.Count > 0)
					{
						for (int j = 0; j < _control.Controls.Count; j++)
						{
							if (!IsControlFullyVisible(_control.Controls[j]))
							{
								this.Parent.Height		+= _defaultRowHeight;
								_isAllVisible			= false;
								_skipSizeChangedEvent	= true;
								this.Height				+= _defaultRowHeight;

								RemoveControl(_control, true);
								break;
							}
						}
					}
					// Cell 안에 들어있는 컨트롤
					else
					{
						if (!IsControlFullyVisible(_control))
						{
							this.Parent.Height		+= _defaultRowHeight;
							_isAllVisible			= false;
							_skipSizeChangedEvent	= true;
							this.Height				+= _defaultRowHeight;

							RemoveControl(_control, false);
						}
					}
				}

				// 모든 컨트롤이 보이는지 여부를 확인한다.
				frmMain _mainForm	= GetMainForm(this);

				if ((_mainForm != null)
					&& (!DesignMode)
					&& (_isAllVisible)
					&& (_mainForm.WindowState == FormWindowState.Maximized)
					)
				{
					RestoreControls();
				}
			}
			else
			{
				_skipSizeChangedEvent	= false;
			}

			base.OnSizeChanged(e);
		}
		#endregion

		#region RemoveControl : 컨트롤의 위치 이동
		/// <summary>
		/// 컨트롤의 위치 이동
		/// </summary>
		/// <param name="Control"></param>
		/// <param name="IsContainer"></param>
		void RemoveControl(System.Windows.Forms.Control Control, bool IsContainer)
		{
			try
			{
				int _emptyCol					= -1;
				int _emptyRow					= -1;

				// 컨트롤의 넓이는 이동하기 전에 파악해야 한다.
				int _controlWidth		= -1;
				if (IsContainer)
				{
					_controlWidth	= 0;
					for (int i = 0; i < Control.Controls.Count; i++)
					{
						_controlWidth	+= Control.Controls[i].Width;
					}
				}
				else
				{
					_controlWidth	= Control.Width;
				}



				// 이동 전의 컨트롤 상태를 저장한다.
				RemovedControl _remControl		= new RemovedControl();
				_remControl.Control				= Control;
				_remControl.PreviousColSpan		= this.GetColumnSpan(Control);
				_remControl.PreviousRowSpan		= this.GetRowSpan(Control);
				_remControl.PreviousPosition.X	= this.GetColumn(Control);
				_remControl.PreviousPosition.Y	= this.GetRow(Control);

				/*
				 * 마지막 행의 열들을 루프돌면서 빈 공간을 찾는다.
				 * 단, 화면의 넓이가 줄어들었다고 가정을 하였기 때문에 해당 열이 이동할 컨트롤의 열보다 적어야 한다.
				 */
				for (int i = 0; i < _remControl.PreviousPosition.X - 1; i++)
				{
					if (this.GetControlFromPosition(i, _defaultRowCount - 1) == null)
					{
						_emptyCol	= i;
						_emptyRow	= _defaultRowCount - 1;
					}
				}

				// 빈 셀이 없다.
				if ((_emptyCol == -1) && (_emptyRow == -1))
				{
					// 신규 행으로 컨트롤을 이동한다.
					int currentRowCount					= this.RowCount + 1;
					this.Controls.Add(Control, 0, currentRowCount - 1);
					//this.RowStyles[currentRowCount - 1]	= newRowStyle;

					_remControl.MovedPosition.X	= 0;
					_remControl.MovedPosition.Y	= currentRowCount - 1;
				}
				else
				{
					// 빈 셀로 컨트롤을 이동한다.
					this.Controls.Add(Control, _emptyCol, _emptyRow);

					_remControl.MovedPosition.X	= _emptyCol;
					_remControl.MovedPosition.Y	= _emptyRow;
				}

				// 컨트롤의 넓이와 셀의 넓이를 비교하여, 컨트롤의 넓이가 더 클 경우 ColumnSpan을 정해 준다.
				if (_controlWidth > this.GetColumnWidths()[_remControl.MovedPosition.X])
				{
					this.SetColumnSpan(Control, 2);
				}

				_removedControl.Add(_remControl);



				// 현재 이동하려는 컨트롤 바로 앞의 컨트롤이 라벨이라면, 같이 이동 하자.
				System.Windows.Forms.Control _leftControl	= this.GetControlFromPosition(_remControl.PreviousPosition.X - 1, _remControl.PreviousPosition.Y);
				if ((_leftControl.GetType() == typeof(BANANA.Windows.Controls.Label))
					|| (_leftControl.GetType() == typeof(System.Windows.Forms.Label)))
				{
					RemoveControl(_leftControl, false);
				}
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#region RestoreControls : 컨트롤의 위치 복원
		/// <summary>
		/// 컨트롤의 위치 복원
		/// </summary>
		void RestoreControls()
		{
			if (_defaultRowCount > -1)
			{
				for (int i = 0; i < _removedControl.Count; i++)
				{
					this.Controls.Add(_removedControl[i].Control, _removedControl[i].PreviousPosition.X, _removedControl[i].PreviousPosition.Y);
					this.SetColumnSpan(_removedControl[i].Control, _removedControl[i].PreviousColSpan);
					this.SetRowSpan(_removedControl[i].Control, _removedControl[i].PreviousRowSpan);
					_removedControl.RemoveAt(i);
				}

				this.Invalidate();

				this.RowCount		= _defaultRowCount;
				this.Height			= _defaultHeight;
				this.Parent.Height	= _defaultParentHeight;
			}
		}
		#endregion

		#region IsControlFullyVisible : 컨트롤이 화면에 보이는지 여부 반환
		/// <summary>
		/// 컨트롤이 화면에 보이는지 여부 반환
		/// </summary>
		/// <param name="child"></param>
		/// <returns></returns>
		bool IsControlFullyVisible(System.Windows.Forms.Control child)
		{
			/*
			 * PointToScreen 함수를 다녀오면, TextAlign이 right인 BANANA.Windows.Controls.TextBox의 폰트가 bold로 변해 버리는 버그가 있다.
			 */
			var pos	= this.PointToClient(child.PointToScreen(Point.Empty));

			if (pos.X + child.Width > this.Width)
			{
				return false;
			}

			return true;
		}
		#endregion
	}

	#region internal class RemovedControl : 위치가 이동된 컨트롤
	/// <summary>
	/// 위치가 이동된 컨트롤
	/// </summary>
	internal class RemovedControl
	{
		public System.Windows.Forms.Control Control { get; set; }
		public Position PreviousPosition { get; set; }
		public int PreviousRowSpan { get; set; }
		public int PreviousColSpan { get; set; }
		public Position MovedPosition { get; set; }

		public RemovedControl()
		{
			this.PreviousPosition	= new Position();
			this.MovedPosition		= new Position();
		}
		
		public class Position
		{
			public int X { get; set; }
			public int Y { get; set; }
		}
	}
	#endregion
}
