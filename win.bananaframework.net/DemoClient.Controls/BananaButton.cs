using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DemoClient.Controls
{
	public class BananaButton : BANANA.Windows.Controls.Button
	{
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public BananaButton()
		{

		}

		#region ButtonImage : 버튼 이미지
		/// <summary>
		/// 버튼 이미지
		/// </summary>
		[DefaultValue(DemoClient.Controls.ButtonImage.Search)]
		public ButtonImage ButtonImage { get; set; }
		#endregion

	}
}
